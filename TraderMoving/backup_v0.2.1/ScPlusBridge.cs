using System;
using System.Collections;
using System.Reflection;

namespace TraderMoving;

// ═══════════════════════════════════════════════════════════════
// SafehouseCustomizationPlus 桥接层(全反射,不编译期依赖它)
//
// 为什么要这么绕:
//   SCPlus 已经把无线电注册进了可搬运表(CarryableData.carryablePrefabDefinition
//   里的 "INTERACTIVE_SURVIVAL_TraderRadio"),但写死 pickupable = false。
//
//   直接把它改成 true 会出事。SCPlus 读档时(SaveLoadPatches.cs:80-94):
//     pickupable == false → "原地移动原件"分支,原件保留
//     pickupable == true  → else 分支,原件 active=false,改从 prefab 重建
//   而带 TraderRadio 组件的 prefab 不存在(已核实主 catalog 和 DLC01.json)。
//   SCPlus 自己那个 ReconstructTraderRadio() 造出来的是没有 TraderRadio 组件的
//   空壳,呼不出商人。所以永久改成 true = 读档后电台变哑巴或消失。
//
// 解法:分时段翻转。
//   平时保持 false(让它走"原地移动原件",绝不触发重建),
//   只在玩家确认收纳的那一瞬间改 true 放行 OnPickup,收完立刻改回 false。
//
// 风险:依赖它的私有实现细节。所以用 const modVersion 做版本守卫,
//   对不上或任何一步反射失败 → Available = false,上层降级为抱着走,
//   绝不半路崩。
// ═══════════════════════════════════════════════════════════════

internal static class ScPlusBridge
{
    // 已验证兼容的 SCPlus 版本。它的 Utility.modVersion 是 const string,
    // 读 const 不触发静态构造(cctor 里有 Il2Cpp 依赖,触发会炸),正好适合做守卫。
    private const string VerifiedVersion = "1.9.4";

    private const string RadioKey = "INTERACTIVE_SURVIVAL_TraderRadio";

    internal static bool Available { get; private set; }
    internal static string DetectedVersion { get; private set; } = "";
    internal static string FailReason { get; private set; } = "";

    private static IDictionary _prefabDef;      // Dictionary<string, ObjectToModify> 的非泛型视图
    private static FieldInfo _pickupableField;  // ObjectToModify.pickupable
    private static object _radioEntry;          // 无线电那条 ObjectToModify 实例

    // ── 初始化 ────────────────────────────────────────────

    internal static void Init()
    {
        try
        {
            var asm = FindAssembly();
            if (asm == null) { Fail("SCPlus 程序集未加载"); return; }

            DetectedVersion = ReadVersion(asm);
            if (DetectedVersion != VerifiedVersion)
            {
                // 版本不同不一定坏,但不能假装验证过。放行但记录,便于日志定位。
                ModMain.Log?.Warning(
                    $"[ScPlusBridge] SCPlus 版本 {DetectedVersion} 与已验证版本 {VerifiedVersion} 不同,"
                    + "字典结构若有变化会自动降级");
            }

            var cdType = asm.GetType("SCPlus.CarryableData");
            if (cdType == null) { Fail("找不到 SCPlus.CarryableData"); return; }

            // 字段本身是 public(类是 internal,但 internal 只挡编译不挡反射)
            var fi = cdType.GetField("carryablePrefabDefinition", BindingFlags.Public | BindingFlags.Static);
            if (fi == null) { Fail("找不到 carryablePrefabDefinition 字段"); return; }

            // 取值会触发 SCPlus 的静态构造。此时游戏里 Il2Cpp 已就绪,正常;
            // 万一抛异常也被外层 catch 接住,降级处理。
            _prefabDef = fi.GetValue(null) as IDictionary;
            if (_prefabDef == null) { Fail("carryablePrefabDefinition 不是 IDictionary"); return; }

            if (!_prefabDef.Contains(RadioKey)) { Fail($"字典里没有 {RadioKey}"); return; }
            _radioEntry = _prefabDef[RadioKey];
            if (_radioEntry == null) { Fail("无线电条目为 null"); return; }

            _pickupableField = _radioEntry.GetType().GetField("pickupable", BindingFlags.Public | BindingFlags.Instance);
            if (_pickupableField == null) { Fail("找不到 ObjectToModify.pickupable"); return; }

            // 落地校验:确认现在读出来确实是 false(SCPlus 的既有状态)。
            // 如果已经是 true,说明别的 mod 动过它,我们不该再插手。
            bool cur = (bool)_pickupableField.GetValue(_radioEntry);
            if (cur)
            {
                Fail("pickupable 已被其他 mod 改成 true,不重复接管");
                return;
            }

            Available = true;
            ModMain.Log?.Msg($"[ScPlusBridge] 就绪 — SCPlus {DetectedVersion},无线电条目已接管");
        }
        catch (Exception ex)
        {
            Fail($"初始化异常: {ex.GetType().Name}: {ex.Message}");
        }
    }

    private static void Fail(string reason)
    {
        Available = false;
        FailReason = reason;
        ModMain.Log?.Warning($"[ScPlusBridge] 不可用({reason}) → 降级为抱着走");
    }

    private static Assembly FindAssembly()
    {
        foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
        {
            var n = a.GetName().Name;
            if (n != null && n.Contains("SafehouseCustomization")) return a;
        }
        return null;
    }

    private static string ReadVersion(Assembly asm)
    {
        try
        {
            var u = asm.GetType("SCPlus.Utility");
            var f = u?.GetField("modVersion", BindingFlags.Public | BindingFlags.Static);
            // const 读的是元数据默认值,不触发 cctor
            var v = f?.GetRawConstantValue() ?? f?.GetValue(null);
            return v as string ?? "?";
        }
        catch { return "?"; }
    }

    // ── 分时段翻转 ────────────────────────────────────────

    // 在 body 执行期间把无线电临时标成可拾取。无论 body 是否抛异常,
    // 结束后一定还原成 false —— 这是防止"读档触发重建导致电台消失"的关键。
    internal static bool WithPickupable(Action body)
    {
        if (!Available || body == null) return false;

        bool original;
        try { original = (bool)_pickupableField.GetValue(_radioEntry); }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[ScPlusBridge] 读 pickupable 失败: {ex.Message}");
            return false;
        }

        try
        {
            _pickupableField.SetValue(_radioEntry, true);
            body();
            return true;
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[ScPlusBridge] 收纳过程异常: {ex}");
            return false;
        }
        finally
        {
            // finally 保证还原。这一句是整个桥接层最重要的一行:
            // 漏了它,下次读档 SCPlus 就会走重建分支,电台变空壳。
            try { _pickupableField.SetValue(_radioEntry, original); }
            catch (Exception ex)
            {
                // 还原失败是严重状态,必须大声报出来
                ModMain.Log?.Error($"[ScPlusBridge] 严重:pickupable 还原失败({ex.Message})"
                                 + " —— 建议立刻退出游戏不要存档,否则读档后电台可能失效");
            }
        }
    }

    // 当前标记状态,给自检和日志用
    internal static bool CurrentPickupable()
    {
        if (!Available) return false;
        try { return (bool)_pickupableField.GetValue(_radioEntry); }
        catch { return false; }
    }

    // ── 补 DecorationItem ─────────────────────────────────

    // SCPlus 只在 _DLC01 后缀场景里给无线电挂 DecorationItem(SCPMain.cs:155-165),
    // 而且靠 TryGetCarryableRoot 按【名字】找根对象。所以两件事要保证:
    //   1. 对象上有 DecorationItem,否则背包收纳链根本进不去
    //   2. 对象名字含 INTERACTIVE_SURVIVAL_TraderRadio,否则 SCPlus 的
    //      SanitizeObjectName + 字典查询对不上(它用 Contains 匹配,
    //      见 CarryableData.cs:298 和 DecorationPatches.cs:148)
    // 缺就调它自己的 SCPMain.MakeIntoDecoration 补,不自己造 —— 那样图标、
    // 重量、放置规则、本地化名都能跟它保持一致。
    internal static bool EnsureDecoration(UnityEngine.GameObject go)
    {
        if (!Available || go == null) return false;
        try
        {
            // 名字对不上先修名字。SCPlus 的 SanitizeObjectName 会去掉括号内容和
            // 结尾数字,所以直接用标准 key 最稳。
            if (!go.name.ToLower().Contains(RadioKey.ToLower()))
            {
                ModMain.Log?.Msg($"[ScPlusBridge] 对象名 '{go.name}' 不含字典 key,改名为 {RadioKey}");
                go.name = RadioKey;
            }

            // 已经有 DecorationItem 也要过一遍 m_AllowInInventory —— SCPlus 挂的那个
            // 未必设过(它只在 Start 的 Postfix 里设,时机不一定命中)
            var existing = go.GetComponent<Il2Cpp.DecorationItem>()
                        ?? go.GetComponentInChildren<Il2Cpp.DecorationItem>();
            if (existing != null)
            {
                EnsureInventoryAllowed(existing);
                return true;
            }

            var asm = FindAssembly();
            var main = asm?.GetType("SCPlus.SCPMain");
            var mk = main?.GetMethod("MakeIntoDecoration", BindingFlags.Public | BindingFlags.Static);
            if (mk == null)
            {
                ModMain.Log?.Warning("[ScPlusBridge] 找不到 SCPMain.MakeIntoDecoration,无法补 DecorationItem");
                return false;
            }

            mk.Invoke(null, new object[] { go });
            var made = go.GetComponentInChildren<Il2Cpp.DecorationItem>();
            bool ok = made != null;
            ModMain.Log?.Msg($"[ScPlusBridge] 补 DecorationItem: {(ok ? "成功" : "失败")}");
            if (ok) EnsureInventoryAllowed(made);
            return ok;
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[ScPlusBridge] EnsureDecoration 异常: {ex.Message}");
            return false;
        }
    }

    // ── 关键修复:m_AllowInInventory ─────────────────────
    //
    // 症状:能收进背包,但背包里找不到。
    // 根因:DecorationItem.m_AllowInInventory 是 private,原版无线电是 false。
    //   SCPlus 只在 DecorationItem.Start 的 Postfix 里把它设成 true
    //   (DecorationPatches.cs:40-48),而我们是【运行时新加】这个组件,
    //   Start 那个 patch 在这条路径上不保证跑过 —— 于是背包 UI 认为这东西
    //   不该出现在背包里,收进去了也不显示。
    //
    // 同理 m_Category(private,DecorationCategory 枚举)决定它归到背包哪个
    // 分类页签下,默认值 Floor(0) 可能不是玩家会去翻的那一页,所以显式设
    // Props 更容易找到。
    internal static void EnsureInventoryAllowed(Il2Cpp.DecorationItem di)
    {
        if (di == null) return;
        var t = di.GetType();

        SetPrivate(t, di, "m_AllowInInventory", true, "允许进背包");
        // 背包分类设成 Props(杂物)。按名字解析而不是写死 2 —— 已实测
        // DecorationCategory = {Floor:0, Furniture:1, Props:2, WallProps:3},
        // 但按名字取值能扛住将来枚举顺序变动。
        SetCategoryByName(t, di, "Props");
    }

    // 【实测教训】Il2CppInterop 把 IL2Cpp 的字段全部包装成 C# 属性。
    // 反编译源码里看到的 `private bool m_AllowInInventory;` 在运行时是
    // 【可写属性】m_AllowInInventory,GetField 拿不到,必须 GetProperty。
    // 离线验证过:GetField 全 FAIL,GetProperty 全 OK 且 canWrite=True。
    // 仍保留 GetField 作后备,防不同 interop 版本行为不一致。
    private const BindingFlags Member = BindingFlags.Public | BindingFlags.NonPublic
                                      | BindingFlags.Instance;

    private static void SetPrivate(Type t, object inst, string name, object val, string label)
    {
        try
        {
            var p = t.GetProperty(name, Member);
            if (p != null && p.CanWrite)
            {
                object old = SafeGet(() => p.GetValue(inst));
                p.SetValue(inst, Coerce(p.PropertyType, val));
                ModMain.Log?.Msg($"[ScPlusBridge] {label}: {name} {old} → {SafeGet(() => p.GetValue(inst))}");
                return;
            }

            var f = t.GetField(name, Member);
            if (f != null)
            {
                object old = SafeGet(() => f.GetValue(inst));
                f.SetValue(inst, Coerce(f.FieldType, val));
                ModMain.Log?.Msg($"[ScPlusBridge] {label}: {name} {old} → {SafeGet(() => f.GetValue(inst))}");
                return;
            }

            ModMain.Log?.Warning($"[ScPlusBridge] 找不到可写成员 {name},跳过({label})");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[ScPlusBridge] 设置 {name} 失败: {ex.Message}");
        }
    }

    private static void SetCategoryByName(Type t, object inst, string categoryName)
    {
        try
        {
            var p = t.GetProperty("m_Category", Member);
            if (p == null || !p.CanWrite)
            {
                ModMain.Log?.Warning("[ScPlusBridge] m_Category 不可写,跳过分类设置");
                return;
            }
            if (!p.PropertyType.IsEnum) return;

            foreach (var n in Enum.GetNames(p.PropertyType))
            {
                if (n != categoryName) continue;
                object old = SafeGet(() => p.GetValue(inst));
                p.SetValue(inst, Enum.Parse(p.PropertyType, n));
                ModMain.Log?.Msg($"[ScPlusBridge] 背包分类: {old} → {n}");
                return;
            }
            ModMain.Log?.Warning($"[ScPlusBridge] DecorationCategory 里没有 {categoryName},保持原值");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[ScPlusBridge] 设置分类失败: {ex.Message}");
        }
    }

    private static object Coerce(Type target, object val)
        => target.IsEnum ? Enum.ToObject(target, val) : Convert.ChangeType(val, target);

    private static object SafeGet(Func<object> f)
    {
        try { return f() ?? "null"; } catch { return "?"; }
    }

    // 触发 SCPlus 的收纳:移出场景层级 + 进背包。
    // 这两步照抄它 OnPickup 里 FlareGun 特例的做法(DecorationPatches.cs:136-137),
    // 那是它自己验证过的"直接进背包"路径。
    internal static bool StowToInventory(UnityEngine.GameObject go)
    {
        if (!Available || go == null) return false;

        var di = go.GetComponent<Il2Cpp.DecorationItem>() ?? go.GetComponentInChildren<Il2Cpp.DecorationItem>();
        if (di == null)
        {
            ModMain.Log?.Warning("[ScPlusBridge] 对象上没有 DecorationItem,收纳中止");
            return false;
        }

        bool done = false;
        WithPickupable(() =>
        {
            // 让 SCPlus 把它登记进自己的 carryable 列表(补图标/重量),
            // 这样背包里显示正常。SetupCarryable 是 public static。
            TrySetupCarryable(di);

            // 图标缺失时补一个,否则背包格子里是空白(容易被误认为"东西没进去")
            TryRelevantSetup(di);

            di.RemoveFromHierarchy();
            Il2Cpp.GameManager.GetInventoryComponent()
                .AddDecoration(di, Il2Cpp.PlayerManager.InventoryInstantiateFlags.None);
            done = true;
        });

        if (!done) return false;

        // 【不盲报成功】用游戏自己的接口确认它真进了背包。
        // 这条是上一版"收进去却找不到"暴露出来的教训:AddDecoration 不抛异常
        // 不代表 UI 认它。
        try
        {
            bool inInv = Il2Cpp.GameManager.GetInventoryComponent().DecorationInInventory(di);
            if (!inInv)
            {
                ModMain.Log?.Error("[ScPlusBridge] AddDecoration 已调用但 DecorationInInventory=false"
                                 + " —— 背包不认这个物品,收纳判定为失败");
                return false;
            }
            ModMain.Log?.Msg("[ScPlusBridge] 已确认在背包中");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[ScPlusBridge] 无法确认背包状态({ex.Message}),按成功处理");
        }

        return true;
    }

    // 收纳失败后的回滚:把物体放回场景里的原位。
    // RemoveFromHierarchy 可能已经执行,不回滚的话物体既不在背包也不在场景。
    internal static void RestoreToScene(UnityEngine.GameObject go,
                                       UnityEngine.Vector3 pos,
                                       UnityEngine.Quaternion rot)
    {
        if (go == null) return;
        try
        {
            var di = go.GetComponent<Il2Cpp.DecorationItem>()
                  ?? go.GetComponentInChildren<Il2Cpp.DecorationItem>();
            if (di != null)
            {
                // 如果它进了背包列表,先摘出来
                try
                {
                    var inv = Il2Cpp.GameManager.GetInventoryComponent();
                    if (inv != null && inv.DecorationInInventory(di))
                        inv.RemoveDecoration(di);
                }
                catch { }
            }

            go.SetActive(true);
            go.transform.SetPositionAndRotation(pos, rot);

            var active = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            var root = ((UnityEngine.Component)go.transform.root).gameObject;
            if (root.scene != active)
                UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(root, active);

            ModMain.Log?.Msg($"[ScPlusBridge] 已恢复到场景原位 {pos}");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[ScPlusBridge] 恢复原位失败: {ex}");
        }
    }

    private static void TryRelevantSetup(Il2Cpp.DecorationItem di)
    {
        try
        {
            var asm = FindAssembly();
            var main = asm?.GetType("SCPlus.SCPMain");
            var m = main?.GetMethod("RelevantSetupForDecorationItem", BindingFlags.Public | BindingFlags.Static);
            // 签名 (DecorationItem di, bool weightOnly = false)
            m?.Invoke(null, new object[] { di, false });
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[ScPlusBridge] RelevantSetup 失败(不影响收纳): {ex.Message}");
        }
    }

    private static void TrySetupCarryable(Il2Cpp.DecorationItem di)
    {
        try
        {
            var asm = FindAssembly();
            var cd = asm?.GetType("SCPlus.CarryableData");
            var m = cd?.GetMethod("SetupCarryable", BindingFlags.Public | BindingFlags.Static);
            m?.Invoke(null, new object[] { di, true });
        }
        catch (Exception ex)
        {
            // 登记失败不致命(只影响图标/重量显示),继续收纳
            ModMain.Log?.Warning($"[ScPlusBridge] SetupCarryable 失败(不影响收纳): {ex.Message}");
        }
    }
}
