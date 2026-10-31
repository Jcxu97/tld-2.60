using System;
using System.Reflection;
using System.Runtime;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

// v8.3 版本号只写在 ModMain.VERSION 一处,其余全部由它拼出来。
//   之前四处各写一遍,菜单标题栏一直停在 v8.0 而 MelonInfo 已经是 8.1.0,玩家看到两个版本号。
//   常量拼接是编译期常量,所以 attribute 里也能用。唯一还要手动跟的是 csproj 的 <Version>。
#if STORY_EDITION
[assembly: MelonInfo(typeof(TldHacks.ModMain), "TldHacksStory", "1.3", "user")]
#elif EP5_EDITION
[assembly: MelonInfo(typeof(TldHacks.ModMain), "TldHacksEp5", "1.0", "user")]
#else
[assembly: MelonInfo(typeof(TldHacks.ModMain), "TldHacks", TldHacks.ModMain.VERSION + ".0", "user")]
// 程序集版本。csproj 设了 GenerateAssemblyInfo=false,<Version> 不会进 DLL 元数据,
//   右键看属性一直是 0.0.0.0,玩家对不上自己装的是哪一版,所以这里显式写。
[assembly: AssemblyVersion(TldHacks.ModMain.VERSION + ".0")]
[assembly: AssemblyFileVersion(TldHacks.ModMain.VERSION + ".0")]
[assembly: AssemblyInformationalVersion(TldHacks.ModMain.VERSION)]
#endif
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonAdditionalDependencies("ModSettings")]
[assembly: MelonOptionalDependencies("ModData")]

namespace TldHacks;

public class ModMain : MelonMod
{
    // 全 mod 唯一的版本号来源。MelonInfo / 程序集版本 / 菜单标题栏 / 启动日志都从这里取。
    internal const string VERSION = "10.9";

    public static MelonLogger.Instance Log;
    internal static TldHacksSettings Settings;

    private int _posTick = 0;
    private int _frame = 0;
    private static bool _tsActive1, _tsActive2;
    // v6.9.6 崩溃哨兵延后清除:确认稳定进入游戏后才清,使"加载存档即崩"能被下次启动的安全模式接住
    private bool _sentinelCleared = false;
    private int _stableFrames = 0;
    private static bool _gameSceneEntered = false;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;
        try
        {
            RegisterSettings();
            Settings?.HideRetiredFields();

            // 把 Settings 持久值同步到 CheatState
            SyncStateFromSettings();

            // v2.7.79 DiagUnpatchAll:启动时卸掉 MelonLoader 自动挂的所有 [HarmonyPatch] attribute,
            //   跳过 DynamicPatch.Reconcile() → TldHacks 全程 0 patch 挂载
            if (Settings.DiagUnpatchAll)
            {
                try { HarmonyInstance.UnpatchSelf(); }
                catch (Exception ex) { Log.Warning($"[DiagUnpatch] UnpatchSelf: {ex.Message}"); }
                // DynamicPatch 自己的 instance 也清一下,防上次残留(正常启动不会残留,保险起见)
                try { new HarmonyLib.Harmony("TldHacks.Dynamic").UnpatchSelf(); } catch { }
                // Mod Options 英文化用的是独立 Harmony instance,UnpatchSelf 收不到,单独卸
                ModSettingsEn.Remove();
                Log.Msg("[DIAG] DiagUnpatchAll = ON → TldHacks 所有 Harmony patch 已卸载,Reconcile / 所有 tick 已停。重启游戏仍会重新应用此开关。");
            }
            else
            {
                // 写崩溃哨兵:内容 = 升级后的崩溃计数。若本次也没稳定进场景,下次启动读到更高
                //   等级 → 逐级加强恢复(1=关 bool;>=2=全量重置默认但留 UI/绑定)。
                try { System.IO.File.WriteAllText(SentinelPath, _pendingSentinelLevel.ToString()); } catch { }
                DynamicPatch.Reconcile();
                DynamicPatch.SelfCheck();   // v7.0 可维护性:启动即暴露解析失败的补丁(游戏更新破坏检测)
            }

            // v2.7.64 加载 scene transition 历史记录
            TransitionRecorder.Init();
            try { GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency; } catch { }

            // v6.9.2 拦截 CatchColdMod 在清除窗口期内反复加感冒/肺炎(只在 ClearInProgress 或 ReSweep 时拦)
            try { TryPatchCatchColdMod(); } catch (Exception ex) { Log.Warning($"[CatchColdGuard] init: {ex.Message}"); }

            Log.Msg($"TldHacks v{VERSION} loaded, menu hotkey = {Settings.MenuHotkey}, items = {ItemDatabase.All.Count}+{ItemDatabaseMod.All.Count} mod, transitions = {TransitionRecorder.Count}");
        }
        catch (Exception ex) { Log.Error($"[Init] {ex}"); }
    }

    // v6.9.2 反射 patch CatchColdMod.ColdUtils.{ApplyCold,ApplyPneumonia}:
    // 一键清除负面期间 + 5s ReSweep 窗口内拦截这两个方法,避免 HypothermiaEnd Postfix 触发的反复加感冒
    // → ColdPhase 飙升 → 升级肺炎 race
    // 没装 CatchColdMod 静默跳过,zero coupling
    private void TryPatchCatchColdMod()
    {
        Type coldUtilsType = null;
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            try
            {
                if (asm.GetName().Name != "CatchColdMod") continue;
                coldUtilsType = asm.GetType("CatchColdMod.ColdUtils");
                if (coldUtilsType != null) break;
            }
            catch { }
        }
        if (coldUtilsType == null) return; // 用户没装 CatchColdMod

        var prefixMI = typeof(ModMain).GetMethod(nameof(CatchColdGuardPrefix),
            BindingFlags.NonPublic | BindingFlags.Static);
        var prefix = new HarmonyLib.HarmonyMethod(prefixMI);
        int patched = 0;
        foreach (var name in new[] { "ApplyCold", "ApplyPneumonia" })
        {
            try
            {
                var mi = coldUtilsType.GetMethod(name, BindingFlags.Public | BindingFlags.Static);
                if (mi != null) { HarmonyInstance.Patch(mi, prefix: prefix); patched++; }
            }
            catch (Exception ex) { Log.Warning($"[CatchColdGuard] patch {name}: {ex.Message}"); }
        }
        Log.Msg($"[CatchColdGuard] Patched CatchColdMod.ColdUtils ({patched} methods) — clear-affliction window blocks reinfection.");
    }

    // 拦截器:清除窗口内 return false 跳过 ApplyCold/ApplyPneumonia
    private static bool CatchColdGuardPrefix()
    {
        if (CheatState.AfflictionClearInProgress || CheatState.AfflictionClearReSweepFramesLeft > 0)
        {
            return false; // skip original
        }
        return true;
    }

    // v3.0.6 跨版本配置兼容: 老 JSON + 新字段时不再整个 Load 失败,
    //   逐字段反射救援 — 兼容字段保留用户值,不兼容字段静默用默认。
    //   仅在 OnInitializeMelon 启动时跑一次,运行时零开销。
    //   全程 try-catch 兜底,任何异常退化为标准 AddToModSettings 路径。
    // v7.5 关键修复:哨兵路径必须绝对(同 JsonConfigPath 用库的 ModsDirectory)。旧版用相对
    //   "Mods/TldHacks.loading",玩家进程 cwd != 游戏根时哨兵写/读的是错位置 → 崩溃恢复安全模式
    //   永不触发 → 玩家只能手删 TldHacks.json 才能进存档(正是本次 bug 的真凶之一)。
    private static readonly string SentinelPath = ResolveSentinelPath();
    private static string ResolveSentinelPath()
    {
        try { return System.IO.Path.Combine(MelonLoader.Utils.MelonEnvironment.ModsDirectory, "TldHacks.loading"); }
        catch { return System.IO.Path.Combine("Mods", "TldHacks.loading"); }
    }

    // v7.5 崩溃升级计数:哨兵文件内容 = 连续"启动但未稳定进场景"的次数。
    //   0 缺失=正常;1=上次崩了(安全模式:关所有 bool,留数值/热键);>=2=关光 bool 仍崩
    //   (非 bool 元凶)→ 全量重置默认但保留 UI/绑定。稳定游玩 180 帧或正常退出即清零。
    private static int _pendingSentinelLevel = 1;
    private static int ReadSentinelLevel()
    {
        try
        {
            if (!System.IO.File.Exists(SentinelPath)) return 0;
            var txt = System.IO.File.ReadAllText(SentinelPath).Trim();
            if (int.TryParse(txt, out int n)) return n < 0 ? 0 : n;
            return 1;   // 兼容旧版哨兵(内容是 DateTime)→ 视为至少崩过 1 次
        }
        catch { return 0; }
    }

    // 全量重置时保留的纯 UI/绑定字段:热键/菜单位置/缩放/语言。这些绝不可能影响存档加载,
    //   保住它们玩家就不用重绑热键、重摆菜单(直击"得重新设置了"的痛点)。
    private static readonly System.Collections.Generic.HashSet<string> _preserveOnReset = new()
    {
        "MenuHotkey", "FlyHotkey", "MenuScale", "MenuWidth", "MenuHeight", "MenuX", "MenuY", "MenuPauseGame", "SpawnerTeleportH",
        "LanguageMode", "QoL_DropKey", "QoL_BulkKey", "QoL_BackKey", "JumpKey",
        "TimeScaleKey1", "TimeScaleKey2", "GrabAllKey", "MapM_BunkerKey", "MapM_RevealKey",
    };

    internal static void ClearSentinel()
    {
        try { if (System.IO.File.Exists(SentinelPath)) System.IO.File.Delete(SentinelPath); } catch { }
    }

    // 库 (JsonModSettings) 用 MelonEnvironment.ModsDirectory 解析成绝对路径;我们必须用同一路径,
    //   否则净化的是错文件(部分玩家进程 cwd != 游戏根 → 相对 "Mods/..." 指向别处 → 净化无效)。
    private static string JsonConfigPath()
    {
        try { return System.IO.Path.Combine(MelonLoader.Utils.MelonEnvironment.ModsDirectory, "TldHacks.json"); }
        catch { return System.IO.Path.Combine("Mods", "TldHacks.json"); }
    }

    // v7.0 关键修复(存档进不去的根因):在 `new TldHacksSettings()` 之前先把磁盘 JSON 净化成
    //   100% 兼容当前字段的版本。根因 = JsonModSettings 基类构造函数会立即 Load+Populate,
    //   任何旧字段类型不兼容会在构造当场抛异常 → Settings 永远 null → SyncStateFromSettings 与
    //   运行时上百处 ModMain.Settings.X 全部 NPE → 加载存档崩 → 玩家被迫手删 TldHacks.json。
    //   旧 SafeLoad 跑在构造之后(太晚)且用相对路径(可能指错文件),所以对部分玩家无效。
    //   pre-flight 跑在构造之前 + 用库的绝对路径,从根上消除。只保留可转换的已知字段、
    //   slider 越界钳到边界,丢弃不兼容字段与孤儿字段;有变更先备份再写回。
    private static readonly string[] RetiredSettingKeys = { "OneClickDisableAll" };

    // 跟库(TinyJSON)落盘的字段集合一致:public 字段 + 带 [Include] 的 internal 字段(勋章数值、诊断开关)。
    //   只认 public 会把 [Include] 字段当孤儿删掉,改过的值每次重开游戏都被清回默认。
    private static System.Collections.Generic.IEnumerable<FieldInfo> PersistedSettingFields()
    {
        foreach (var f in typeof(TldHacksSettings).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            if (f.IsPublic || f.IsDefined(typeof(TLD.TinyJSON.Include), true)) yield return f;
    }

    private static void PreflightSanitizeJson(string path)
    {
        try
        {
            if (string.IsNullOrEmpty(path) || !System.IO.File.Exists(path)) return;

            string raw = System.IO.File.ReadAllText(path);
            Newtonsoft.Json.Linq.JObject jobj;
            try { jobj = Newtonsoft.Json.Linq.JObject.Parse(raw); }
            catch
            {
                // JSON 语法损坏 → 备份 + 删除 → 库会写一份全新默认(等价玩家手删,但自动完成)
                try { System.IO.File.Copy(path, path + ".corrupt-" + DateTime.Now.ToString("yyyyMMdd-HHmmss"), true); } catch { }
                try { System.IO.File.Delete(path); } catch { }
                Log?.Warning("[Settings] pre-flight: JSON 损坏,已备份并重置为默认。");
                return;
            }

            var fields = PersistedSettingFields();
            var validNames = new System.Collections.Generic.HashSet<string>();
            var clean = new Newtonsoft.Json.Linq.JObject();
            int kept = 0, dropped = 0, clamped = 0;

            foreach (var f in fields)
            {
                if (f.IsStatic || f.IsInitOnly) continue;
                validNames.Add(f.Name);
                var token = jobj[f.Name];
                if (token == null) continue;   // 老 JSON 没这字段 → 留给库用类初始化默认值(新增字段走新默认)
                try
                {
                    object val = token.ToObject(f.FieldType);
                    if (val == null) { dropped++; continue; }
                    var sa = f.GetCustomAttribute<ModSettings.SliderAttribute>();
                    if (sa != null)
                    {
                        if (f.FieldType == typeof(float))
                        {
                            float fv = (float)val, fc = Mathf.Clamp(fv, sa.From, sa.To);
                            if (fc != fv) { val = fc; clamped++; }
                        }
                        else if (f.FieldType == typeof(int))
                        {
                            int iv = (int)val, ic = Mathf.Clamp(iv, (int)sa.From, (int)sa.To);
                            if (ic != iv) { val = ic; clamped++; }
                        }
                    }
                    clean[f.Name] = Newtonsoft.Json.Linq.JToken.FromObject(val);
                    kept++;
                }
                catch { dropped++; }   // 类型不兼容(老版本字段类型变了)→ 丢弃 → 库用默认
            }

            int orphans = 0, retired = 0;
            foreach (var prop in jobj.Properties())
                if (!validNames.Contains(prop.Name))
                {
                    if (Array.IndexOf(RetiredSettingKeys, prop.Name) >= 0) retired++; else orphans++;
                }

            // 版本里主动删掉的字段不算坏配置:静默去掉,不留 broken 备份
            if (retired > 0 && dropped == 0 && orphans == 0 && clamped == 0)
            {
                System.IO.File.WriteAllText(path, clean.ToString(Newtonsoft.Json.Formatting.Indented));
                Log?.Msg($"[Settings] 去掉 {retired} 个已删除的旧字段");
            }
            else if (dropped > 0 || orphans > 0 || clamped > 0)
            {
                try { System.IO.File.Copy(path, path + ".broken-" + DateTime.Now.ToString("yyyyMMdd-HHmmss"), true); } catch { }
                System.IO.File.WriteAllText(path, clean.ToString(Newtonsoft.Json.Formatting.Indented));
                Log?.Warning($"[Settings] pre-flight 净化: 保留 {kept}, 丢弃 {dropped} 不兼容, 删除 {orphans} 孤儿, 钳制 {clamped} 越界。库现在可正常加载,存档不再被卡。");
            }
        }
        catch (Exception ex) { Log?.Warning($"[Settings] pre-flight 异常(已忽略,退回旧路径): {ex.Message}"); }
    }

    // v7.6 补最后一个洞:pre-flight 用 Newtonsoft 判兼容,库(JsonModSettings)却用 TinyJSON/
    //   Convert.ChangeType 加载,两者不完全一致 —— 极少数跨版本值 Newtonsoft 放行、库却拒绝,
    //   构造函数当场抛 → Settings 永远 null → 存档进不去,而且哨兵写在构造之后(此处根本到不了)
    //   → 崩溃恢复救不了 → 玩家每次启动同样崩,只能手删 json。此方法在构造抛异常时被调用:
    //   解析磁盘 JSON,只保留 _preserveOnReset(热键/菜单/语言)里类型可转换的字段,丢弃其余全部,
    //   备份后写回。让库能构造成功且玩家不用重绑热键(直击"得重新设置了")。补救本身失败则整删。
    private static void SalvageJsonKeepPreserved(string path)
    {
        try
        {
            if (string.IsNullOrEmpty(path) || !System.IO.File.Exists(path)) return;
            var jobj = Newtonsoft.Json.Linq.JObject.Parse(System.IO.File.ReadAllText(path));
            var clean = new Newtonsoft.Json.Linq.JObject();
            foreach (var f in typeof(TldHacksSettings).GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                if (f.IsStatic || f.IsInitOnly || !_preserveOnReset.Contains(f.Name)) continue;
                var token = jobj[f.Name];
                if (token == null) continue;
                try
                {
                    object val = token.ToObject(f.FieldType);   // 只留能转换的;转不了就丢
                    if (val != null) clean[f.Name] = Newtonsoft.Json.Linq.JToken.FromObject(val);
                }
                catch { }
            }
            try { System.IO.File.Copy(path, path + ".ctorfail-" + DateTime.Now.ToString("yyyyMMdd-HHmmss"), true); } catch { }
            System.IO.File.WriteAllText(path, clean.ToString(Newtonsoft.Json.Formatting.Indented));
        }
        catch
        {
            try { System.IO.File.Delete(path); } catch { }   // 补救失败 → 整删,让库写全新默认
        }
    }

    private static void RegisterSettings()
    {
        var path = JsonConfigPath();
        PreflightSanitizeJson(path);   // v7.0:必须在构造之前净化,否则库构造函数直接抛 → 存档进不去

        // Mod Options 面板英文化:必须在 new TldHacksSettings() 之前挂 —— 基类构造函数就会跑
        //   ValidateFields → Attributes.GetAttributes,晚一步就赶不上第一次流出。
        //   语言=中文 / 挂载失败 → 完全不挂,面板保持中文(等于现状)。
        ModSettingsEn.Apply(path);

        // v7.6:构造函数是最后一个可能抛的点(库用 TinyJSON/Convert.ChangeType,比 pre-flight 的
        //   Newtonsoft 更严,极少数值能溜过 pre-flight 却让构造抛)。此处第一次崩就地补救(留热键/
        //   菜单/语言,删其余),不依赖"多次崩溃逐级升级"—— 因为构造崩时哨兵根本写不进,无法升级。
        try { Settings = new TldHacksSettings(); }
        catch (Exception ex)
        {
            Log?.Warning($"[Settings] 构造函数抛异常({ex.Message})→ 库加载器比 pre-flight 更严,就地补救(保留热键/菜单/语言)");
            SalvageJsonKeepPreserved(path);
            try { Settings = new TldHacksSettings(); }
            catch (Exception ex2)
            {
                // 补救后仍抛(极端)→ 整删 json,保证库能用全新默认构造成功,绝不让 Settings 留 null
                Log?.Warning($"[Settings] 补救后仍抛({ex2.Message})→ 删除 json 用全新默认");
                try { System.IO.File.Delete(path); } catch { }
                Settings = new TldHacksSettings();
            }
        }

        // 崩溃哨兵:上次启动挂了 patch 后没成功进场景 → 逐级恢复。
        //   level 1 = 安全模式(加载配置但关所有 bool,留数值/热键)
        //   level >=2 = 关光 bool 仍崩(元凶是某个非 bool 值)→ 全量重置默认但保留 UI/绑定
        // 关键:本次启动前把哨兵写成"更高一级",若本次又没稳定进场景,下次就自动升级恢复力度;
        //   稳定 180 帧或正常退出会清零(见 OnUpdate / OnDeinitializeMelon)。
        int crashLevel = ReadSentinelLevel();
        bool crashRecovery = crashLevel >= 1;
        bool fullReset = crashLevel >= 2;
        _pendingSentinelLevel = crashLevel + 1;   // 本次若再崩,下次读到的等级
        if (crashRecovery)
        {
            Log?.Warning(fullReset
                ? $"[Settings] 连续 {crashLevel} 次加载崩溃 → 强恢复: 全量重置为默认值(仅保留热键/菜单/语言)"
                : "[Settings] 检测到上次加载崩溃 → 安全模式: 加载配置但禁用所有开关");
        }

        // 全新安装 → 直接走标准路径
        if (!System.IO.File.Exists(path))
        {
            try { Settings.AddToModSettings("TldHacks"); }
            catch (Exception ex) { Log?.Error($"[Settings] AddToModSettings(new): {ex.Message}"); }
            return;
        }

        // 已有 JSON → 反射救援
        bool needRewrite = false;
        try
        {
            string raw = System.IO.File.ReadAllText(path);
            var jobj = Newtonsoft.Json.Linq.JObject.Parse(raw);

            int ok = 0, dropped = 0, orphans = 0, clamped = 0;
            var fields = PersistedSettingFields();
            var validNames = new System.Collections.Generic.HashSet<string>();
            foreach (var f in fields)
            {
                if (f.IsStatic || f.IsInitOnly) continue;
                validNames.Add(f.Name);
                var token = jobj[f.Name];
                if (token == null) continue;
                try
                {
                    object val = token.ToObject(f.FieldType);
                    if (val != null)
                    {
                        // Slider 范围 clamp:超界值钳到边界,防止运行时异常
                        var sa = f.GetCustomAttribute<ModSettings.SliderAttribute>();
                        if (sa != null)
                        {
                            if (f.FieldType == typeof(float))
                            {
                                float fv = (float)val;
                                float fc = Mathf.Clamp(fv, sa.From, sa.To);
                                if (fc != fv) { val = fc; clamped++; }
                            }
                            else if (f.FieldType == typeof(int))
                            {
                                int iv = (int)val;
                                int ic = Mathf.Clamp(iv, (int)sa.From, (int)sa.To);
                                if (ic != iv) { val = ic; clamped++; }
                            }
                        }
                        f.SetValue(Settings, val);
                    }
                    ok++;
                }
                catch { dropped++; }
            }

            // 孤儿字段:JSON 有但当前 Settings 类没有 → 触发 rewrite 把 JSON 净化掉
            // (老版本删除/重命名的字段残留在 JSON 里,会让 ModSettings 库二次 Load 行为异常)
            foreach (var prop in jobj.Properties())
            {
                if (!validNames.Contains(prop.Name)) orphans++;
            }

            if (dropped > 0 || orphans > 0 || clamped > 0)
            {
                // 不兼容字段 / 孤儿字段 / 越界值 → 备份老文件 + 写回净化版本(让库 Load 不失败)
                string stamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                string backup = path + ".broken-" + stamp;
                try { System.IO.File.Copy(path, backup, true); } catch { }
                needRewrite = true;
                Log?.Warning($"[Settings] 救援老配置: 保留 {ok} 字段, 丢弃 {dropped} 不兼容, 删除 {orphans} 孤儿字段, 钳制 {clamped} 越界值。备份: {System.IO.Path.GetFileName(backup)}");
            }
            else
            {
                Log?.Msg($"[Settings] 配置全部兼容 ({ok} 字段)");
            }
        }
        catch (Exception ex)
        {
            // 救援本身炸了(JSON 语法错/磁盘错) → 备份+清掉,走标准默认路径
            Log?.Warning($"[Settings] SafeLoad 失败 ({ex.Message}),备份原文件并使用默认值");
            try
            {
                string backup = path + ".corrupt-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                System.IO.File.Move(path, backup);
            }
            catch { try { System.IO.File.Delete(path); } catch { } }
            Settings = new TldHacksSettings();
        }

        // 崩溃恢复:level 1 只关 bool(留数值/热键);level >=2 全量重置默认(仅留 UI/绑定)。
        if (crashRecovery)
        {
            // v6.9.6 整体 try 兜底 + 逐字段 try:任何反射异常都不能炸穿 RegisterSettings,
            //   否则下面的 AddToModSettings 永不执行 → 库加载失败 → 存档进不去(正是要修的根因之一)。
            try
            {
                var defaults = new TldHacksSettings();
                var fields = typeof(TldHacksSettings).GetFields(BindingFlags.Public | BindingFlags.Instance);
                int resetCount = 0;
                foreach (var f in fields)
                {
                    try
                    {
                        if (f.IsStatic || f.IsInitOnly) continue;
                        // level >=2:重置所有字段(元凶可能是某个非 bool 值),但保留纯 UI/绑定字段。
                        // level 1:只重置 bool 开关。
                        if (fullReset)
                        {
                            if (_preserveOnReset.Contains(f.Name)) continue;
                        }
                        else
                        {
                            if (f.FieldType != typeof(bool)) continue;
                        }
                        object defVal = f.GetValue(defaults);
                        object curVal = f.GetValue(Settings);
                        if (!Equals(curVal, defVal)) { f.SetValue(Settings, defVal); resetCount++; }
                    }
                    catch { }
                }
                Log?.Warning(fullReset
                    ? $"[Settings] 强恢复: 全量重置 {resetCount} 个字段为默认值, 保留热键/菜单/语言绑定"
                    : $"[Settings] 安全模式: 重置 {resetCount} 个 bool 开关为默认值, 保留所有数值/热键设置");
            }
            catch (Exception ex) { Log?.Warning($"[Settings] 崩溃恢复重置异常(已忽略): {ex.Message}"); }
            needRewrite = true;
        }

        // 净化文件:把 hydrate 后的 settings 序列化回去,确保库 Load 不会撞旧字段
        if (needRewrite)
        {
            try
            {
                var jo = Newtonsoft.Json.Linq.JObject.FromObject(Settings);
                // Newtonsoft 只写 public,把 [Include] 的 internal 字段补上,否则这里一写就丢勋章数值
                foreach (var f in PersistedSettingFields())
                    if (!f.IsPublic) jo[f.Name] = Newtonsoft.Json.Linq.JToken.FromObject(f.GetValue(Settings));
                string clean = jo.ToString(Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(path, clean);
            }
            catch (Exception ex) { Log?.Warning($"[Settings] 写净化 JSON 失败: {ex.Message}"); }
        }

        // 注册到 ModSettings UI(库会再 Load 一遍,但此时文件结构已 100% 兼容)
        try { Settings.AddToModSettings("TldHacks"); }
        catch (Exception ex)
        {
            // 极小概率仍失败 → 备份+全默认+二次重试
            Log?.Warning($"[Settings] AddToModSettings 失败 ({ex.Message}),备份并重置");
            try
            {
                string backup = path + ".unloadable-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                System.IO.File.Move(path, backup);
            }
            catch { }
            Settings = new TldHacksSettings();
            try { Settings.AddToModSettings("TldHacks"); }
            catch (Exception ex2) { Log?.Error($"[Settings] 二次注册仍失败: {ex2.Message}"); }
        }
    }

    private void SyncStateFromSettings()
    {
        // 诊断开关开启时等价于"一键禁用所有功能"
        if (Settings.DiagPauseRuntime || Settings.DiagUnpatchAll)
        {
            Cheats.DisableAllCheats();
            return;
        }

        CheatState.GodMode = Settings.GodMode;
        // v3.0.4r4: GodMode 隐含 NoFallDamage + NoSprainRisk(用户语义:无敌应该全免)
        CheatState.NoFallDamage = Settings.NoFallDamage || Settings.GodMode;
        CheatState.AlwaysWarm = Settings.AlwaysWarm;
        CheatState.NoHunger = Settings.NoHunger;
        CheatState.NoThirst = Settings.NoThirst;
        CheatState.NoFatigue = Settings.NoFatigue;
        CheatState.InfiniteDurability = Settings.InfiniteDurability;
        CheatState.InstantKillAnimals = Settings.InstantKillAnimals;
        CheatState.FreezeAnimals = Settings.FreezeAnimals;
        CheatState.Stealth = Settings.Stealth;
        CheatState.TrueInvisible = Settings.TrueInvisible;
        CheatState.ThinIceNoBreak = Settings.ThinIceNoBreak;
        CheatState.IgnoreLock = Settings.IgnoreLock;
        CheatState.QuickOpenContainer = Settings.QuickOpenContainer;
        CheatState.NoWetClothes = Settings.NoWetClothes;
        CheatState.FreeCraft = Settings.FreeCraft;
        CheatState.FreeRepair = Settings.FreeRepair;
        CheatState.QuickCraft = Settings.QuickCraft;
        CheatState.InfiniteAmmo = Settings.InfiniteAmmo;
        CheatState.NoJam = Settings.NoJam;
        CheatState.NoRecoil = Settings.NoRecoil;
        CheatState.NoAimSway = Settings.NoAimSway;
        CheatState.NoAimStamina = Settings.NoAimStamina;
        CheatState.SuperAccuracy = Settings.SuperAccuracy;
        CheatState.SpeedMultiplier = Settings.SpeedMultiplier;
        CheatState.NoSprainRisk = Settings.NoSprainRisk || Settings.GodMode;  // v3.0.4r4 GodMode 隐含
        CheatState.ImmuneAnimalDamage = Settings.ImmuneAnimalDamage;
        CheatState.NoSuffocating = Settings.NoSuffocating;
        CheatState.QuickFire = Settings.QuickFire;
        CheatState.QuickClimb = Settings.QuickClimb;
        CheatState.QuickAction = Settings.QuickAction;
        // CT 复刻 v2.7.45+
        CheatState.QuickCook = Settings.QuickCook;
        CheatState.NoBurn = Settings.NoBurn;
        CheatState.QuickSearch = Settings.QuickSearch;
        CheatState.QuickHarvest = Settings.QuickHarvest;
        CheatState.QuickBreakDown = Settings.QuickBreakDown;
        CheatState.UnlockSafes = Settings.UnlockSafes;
        CheatState.LampFuelNoDrain = Settings.LampFuelNoDrain;
        CheatState.LampMute = Settings.LampMute;
        CheatState.FlaskNoHeatLoss = Settings.FlaskNoHeatLoss;
        CheatState.FlaskInfiniteVol = Settings.FlaskInfiniteVol;
        CheatState.FlaskAnyItem = Settings.FlaskAnyItem;
        CheatState.QuickEvolve = Settings.QuickEvolve;
        CheatState.InfiniteContainer = Settings.InfiniteContainer;
        CheatState.FireTemp300 = Settings.FireTemp300;
        CheatState.FireNeverDie = Settings.FireNeverDie;
        CheatState.FireMaxBurnHours = Settings.FireMaxBurnHours;
        CheatState.NoFrostbiteRisk = Settings.NoFrostbiteRisk;
        CheatState.WellFedBuff = Settings.WellFedBuff;
        CheatState.FreezingBuff = Settings.FreezingBuff;
        CheatState.FatigueBuff = Settings.FatigueBuff;
        CheatState.ClearDeathPenalty = Settings.ClearDeathPenalty;
        CheatState.QuickFishing = Settings.QuickFishing;
        // v2.7.86 新增功能
        CheatState.FireAnywhere = Settings.FireAnywhere;
        CheatState.FreeFireFuel = Settings.FreeFireFuel;
        CheatState.TechBackpack = Settings.TechBackpack;
        CheatState.TechBackpackKg = Settings.TechBackpackKg;
        CheatState.TorchFullValue = Settings.TorchFullValue;
        CheatState.InfiniteStamina = Settings.InfiniteStamina;
        CheatState.MapClickTP = Settings.MapClickTP;
        // v2.7.64 商人 + 美洲狮
        CheatState.TraderUnlimitedList = Settings.TraderUnlimitedList;
        CheatState.TraderMaxTrust = Settings.TraderMaxTrust;
        CheatState.TraderInstantExchange = Settings.TraderInstantExchange;
        CheatState.TraderAlwaysAvailable = Settings.TraderAlwaysAvailable;
        CheatState.CougarInstantActivate = Settings.CougarInstantActivate;
        CheatState.BlockAutoPickupOwnDrops = Settings.BlockAutoPickupOwnDrops;
        CheatState.SilentFootsteps = Settings.SilentFootsteps;
        CheatState.RunWithLantern = Settings.RunWithLantern;
        CheatState.NoAutoEquipCharcoal = Settings.NoAutoEquipCharcoal;
        CheatState.AutoExtinguishOnRest = Settings.AutoExtinguishOnRest;
        CheatState.DisableTorchLeftClick = Settings.DisableTorchLeftClick;
        CheatState.DisableLampLeftClick = Settings.DisableLampLeftClick;
        // HouseLights 整合
        CheatState.HL_Enabled = Settings.HL_Enabled;
        CheatState.HL_EnableOutside = Settings.HL_EnableOutside;
        CheatState.HL_WhiteLights = Settings.HL_WhiteLights;
        CheatState.HL_NoFlicker = Settings.HL_NoFlicker;
        CheatState.HL_CastShadows = Settings.HL_CastShadows;
        CheatState.HL_LightAudio = Settings.HL_LightAudio;
        CheatState.HL_Intensity = Settings.HL_Intensity;
        CheatState.HL_RangeMultiplier = Settings.HL_RangeMultiplier;
        CheatState.HL_CullDistance = Settings.HL_CullDistance;
        CheatState.HL_InteractDistance = Settings.HL_InteractDistance;
        // v2.7.96 整合 Batch 2
        CheatState.PauseInJournal = Settings.PauseInJournal;
        CheatState.SkipIntro = Settings.SkipIntro;
        CheatState.MuteCougarMenuSound = Settings.MuteCougarMenuSound;
        CheatState.VehicleKeepFov = Settings.VehicleKeepFov;
        CheatState.DroppableUndroppables = Settings.DroppableUndroppables;
        CheatState.RememberBreakdownTool = Settings.RememberBreakdownTool;
        CheatState.VehicleFreeLook = Settings.VehicleFreeLook;
        CheatStateESP.RecoilScale = Settings.RecoilScaleESP;
        CheatStateESP.MagicBullet = Settings.MagicBullet;
        // v2.8.0 批量整合 — Tab 6: Universal Tweaks
        // v2.8.0 批量整合 — Tab 7: QoL
        CheatState.QoL_Enabled = Settings.QoL_Enabled;
        bool qol = Settings.QoL_Enabled;   // QoL 总开关管(小改动 / 随地睡 / 自动绘图)三节
        CheatState.QoL_NoSaveOnSprain = qol && Settings.QoL_NoSaveOnSprain;
        CheatState.QoL_NoSaveOnSprainFalls = qol && Settings.QoL_NoSaveOnSprainFalls;
        CheatState.QoL_WakeUpCall = qol && Settings.QoL_WakeUpCall;
        CheatState.QoL_AuroraSense = qol && Settings.QoL_AuroraSense;
        CheatState.QoL_ShowTimeSleep = qol && Settings.QoL_ShowTimeSleep;
        CheatState.QoL_NoPitchBlack = qol && Settings.QoL_NoPitchBlack;
        CheatState.QoL_MapTextOutline = qol && Settings.QoL_MapTextOutlineEnabled;
        CheatState.QoL_BuryCorpses = qol && Settings.QoL_BuryCorpses;
        CheatState.QoL_SleepAnywhere = qol && Settings.QoL_SleepAnywhere;
        SleepAnywhereState.FatigueRecoveryPenalty = Settings.QoL_SleepFatigueRecovery;
        SleepAnywhereState.ConditionGainRate = Settings.QoL_SleepConditionRecovery;
        SleepAnywhereState.FreezingScale = Settings.QoL_SleepFreezingScale;
        SleepAnywhereState.FreezingHealthLoss = Settings.QoL_SleepFreezingHealthLoss;
        SleepAnywhereState.HypothermicHealthLoss = Settings.QoL_SleepHypothermicHealthLoss;
        SleepAnywhereState.PassTimeExposurePenalty = Settings.QoL_SleepPassTimeExposure;
        SleepAnywhereState.LowHealthInterrupt = Settings.QoL_SleepInterrupt;
        SleepAnywhereState.SleepInterruptionThreshold = Settings.QoL_SleepInterruptThreshold;
        SleepAnywhereState.InterruptionCooldown = Settings.QoL_SleepInterruptCooldown;
        SleepAnywhereState.HudMessage = Settings.QoL_SleepInterruptHudMsg;
        SleepAnywhereState.ApplyInterruptToBeds = Settings.QoL_SleepInterruptAllBeds;
        SleepAnywhereState.SensitivityScale = Settings.QoL_SleepSensitivityScale;
        SleepAnywhereState.AdjustedSensitivity = Settings.QoL_SleepAdjustedSensitivity;
        CheatState.QoL_AutoSurvey = qol && Settings.QoL_AutoSurvey;

        // v2.8.0 批量整合 — Tab 8: Crafting & Fire
        CheatState.Craft_Anywhere = Settings.Craft_Anywhere;
        CheatState.Craft_MoreCookingSlots = Settings.Craft_MoreCookingSlots;
        // v2.8.0 批量整合 — Tab 9: World & Items
        CheatState.World_Sprainkle = Settings.World_Sprainkle;
        CheatState.World_SprainklePreset = Settings.World_SprainklePreset;
        CheatState.World_SprainkleSlopeMin = Settings.World_SprainkleSlopeMin;
        CheatState.World_SprainkleSlopeIncrease = Settings.World_SprainkleSlopeIncrease;
        CheatState.World_SprainkleBaseChanceMoving = Settings.World_SprainkleBaseChanceMoving;
        CheatState.World_SprainkleEncumberChance = Settings.World_SprainkleEncumberChance;
        CheatState.World_SprainkleExhaustionChance = Settings.World_SprainkleExhaustionChance;
        CheatState.World_SprainkleSprintChance = Settings.World_SprainkleSprintChance;
        CheatState.World_SprainkleCrouchChance = Settings.World_SprainkleCrouchChance;
        CheatState.World_SprainkleMinSecondsRisk = Settings.World_SprainkleMinSecondsRisk;
        CheatState.World_SprainkleWristMovementChance = Settings.World_SprainkleWristMovementChance;
        CheatState.World_SprainkleSprintUIOn = Settings.World_SprainkleSprintUIOn;
        CheatState.World_SprainkleSprintUIOff = Settings.World_SprainkleSprintUIOff;
        CheatState.World_SprainkleAnkleEnabled = Settings.World_SprainkleAnkleEnabled;
        CheatState.World_SprainkleAnkleDurMin = Settings.World_SprainkleAnkleDurMin;
        CheatState.World_SprainkleAnkleDurMax = Settings.World_SprainkleAnkleDurMax;
        CheatState.World_SprainkleAnkleRestHours = Settings.World_SprainkleAnkleRestHours;
        CheatState.World_SprainkleAnkleFallChance = Settings.World_SprainkleAnkleFallChance;
        CheatState.World_SprainkleWristEnabled = Settings.World_SprainkleWristEnabled;
        CheatState.World_SprainkleWristDurMin = Settings.World_SprainkleWristDurMin;
        CheatState.World_SprainkleWristDurMax = Settings.World_SprainkleWristDurMax;
        CheatState.World_SprainkleWristRestHours = Settings.World_SprainkleWristRestHours;
        CheatState.World_SprainkleWristFallChance = Settings.World_SprainkleWristFallChance;
        CheatState.World_BowRepair = Settings.World_BowRepair;
        CheatState.World_BowRepairDLC = Settings.World_BowRepairDLC;
        CheatState.World_CaffeinatedSodas = Settings.World_CaffeinatedSodas;
        CheatState.World_SodaOrangeEnabled = Settings.World_SodaOrangeEnabled;
        CheatState.World_SodaSummitEnabled = Settings.World_SodaSummitEnabled;
        CheatState.World_SodaGrapeEnabled = Settings.World_SodaGrapeEnabled;
        CheatState.World_CarcassMoving = Settings.World_CarcassMoving;
        CheatState.World_CarcassMovingAll = Settings.World_CarcassMovingAll;
        CheatState.World_ElectricTorch = Settings.World_ElectricTorch;

        // TinyTweaks
        CheatState.TT_CapFeelsEnabled = Settings.TT_CapFeelsEnabled;
        CheatState.TT_FallDeathGoat = Settings.TT_FallDeathGoat;
        CheatState.TT_DroppedOrientation = Settings.TT_DroppedOrientation;
        CheatState.TT_ExtendedFOV = Settings.TT_ExtendedFOV;
        CheatState.TT_PauseOnRadial = Settings.TT_PauseOnRadial;
        CheatState.TT_RespawnPlants = Settings.TT_RespawnPlants;
        CheatState.TT_ShowTraderTrust = Settings.TT_ShowTraderTrust;
#if STORY_GUARD
        // 剧情版:在所有 Settings→CheatState 拷贝之后强制清零被 BLOCK 的沙盒专属/传送开关。
        // 沙盒版无此符号,本调用不存在,DLL 字节不变。
        StoryGuard.Enforce();
#endif
    }

    // v7.5 正常退出即清哨兵:防"在主菜单待着从没进存档就退出"这类非崩溃留下 stale 哨兵,
    //   否则下次启动会误判成崩溃 → 误进恢复模式(升级后甚至可能全量重置)。硬崩溃时本回调
    //   不保证触发,正是我们要的:那种情况哨兵留存 → 下次启动接住并恢复。
    public override void OnApplicationQuit()
    {
        // v7.7 退出兜底:把延迟落盘的脏数据写掉(正常退出路径必到,硬崩溃时丢的只是 ≤0.5s 内的设置改动)
        try { Settings?.FlushPendingSave(); } catch { }
        // 载入存档卡住后玩家点叉关游戏也走这里,那时不能清,否则下次启动接不住
        if (!_gameSceneEntered) ClearSentinel();
    }

    public override void OnLateInitializeMelon()
    {
        // BlueprintCleaner 的 ScrollBehaviourItem.OnClick Postfix 调用了 TLD 2.55 中不存在的
        // GameManager.IsBootSceneActive()，导致 MissingMethodException 刷屏。
        // 在所有 mod 加载完后移除该 broken postfix。
        // 2.24 无 Il2CppTLD.UI.Scroll 命名空间(滚动列表体系是 2.55 引入的),
        // 且剧情版不会装 BlueprintCleaner(它依赖 2.55 的蓝图系统),整块跳过。
#if !STORY_EDITION
        try
        {
            var target = HarmonyLib.AccessTools.Method(typeof(Il2CppTLD.UI.Scroll.ScrollBehaviourItem), "OnClick");
            if (target != null)
            {
                var patchInfo = HarmonyLib.Harmony.GetPatchInfo(target);
                if (patchInfo != null)
                {
                    foreach (var p in patchInfo.Postfixes)
                    {
                        if (p.PatchMethod?.DeclaringType?.Assembly?.GetName()?.Name == "BlueprintCleaner")
                        {
                            HarmonyInstance.Unpatch(target, p.PatchMethod);
                            Log.Msg("[Compat] Unpatched BlueprintCleaner broken Postfix on ScrollBehaviourItem.OnClick");
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ex) { Log.Warning($"[Compat] BlueprintCleaner unpatch failed: {ex.Message}"); }
#endif
    }

    public override void OnUpdate()
    {
        // 帧计数在方法中段才自增,前面的 tick 抛一次异常的话,不补这一下就会停在同一个相位每帧重抛,后面的 tick 全停
        bool advanced = false;
        try
        {
            if (Settings == null) return;
            if (Settings.DiagPauseRuntime) return;  // v2.7.75 诊断开关
            if (Settings.DiagUnpatchAll) return;    // v2.7.79 UnpatchAll 模式下也停掉 tick / Reconcile

            // v6.9.6 崩溃哨兵延后清除:在真正可玩的游戏场景中稳定运行 ~10s(600 帧)后才清。
            //   "更新后存档进不去"的崩溃多发生在存档数据加载/应用阶段(场景 init 之后),
            //   若像旧版那样在场景 init 时立即清,这类崩溃就逃过了下次启动的安全模式 → 玩家只能删 JSON。
            //   延后到稳定运行后清,可让"加载即崩"被下次启动接住(安全模式关所有 bool 开关)。
            if (!_sentinelCleared)
            {
                bool inGameplay = false;
                // 卡在载入画面时帧还在跑,不能算稳定;窗口放宽到约 10 秒,盖住进图后头几秒的卡死
                try
                {
                    bool inScene = !Il2Cpp.GameManager.IsMainMenuActive() && !Il2Cpp.GameManager.IsEmptySceneActive();
                    _gameSceneEntered |= inScene;
                    inGameplay = inScene && !Il2Cpp.InterfaceManager.IsPanelEnabled<Il2Cpp.Panel_Loading>();
                }
                catch { }
                if (inGameplay)
                {
                    if (++_stableFrames >= 600) { ClearSentinel(); _sentinelCleared = true; }
                }
                else _stableFrames = 0;
            }

            // Menu toggle
            if (Settings.MenuHotkey != KeyCode.None && Input.GetKeyDown(Settings.MenuHotkey))
            {
                Menu.Toggle();
                if (Menu.Open) try { System.GC.Collect(0, System.GCCollectionMode.Optimized, false); } catch { }
            }

            // 物品生成器搜索框自己收键盘(IMGUI 文本框在这个版本不可用),必须每帧一次
            Menu.UpdateSearchInput();

            // 搜索框收字期间,下面这些直接读键盘的热键全部让路(否则敲 e/f 会触发时间加速)
            bool typing = Menu.CapturingKeys;

            // Fly toggle hotkey
            if (!typing && Settings.FlyHotkey != KeyCode.None && Input.GetKeyDown(Settings.FlyHotkey))
            {
                CheatState.CFly = !CheatState.CFly;
                ConsoleBridge.Run("fly");
            }

            // v7.7 一键搜刮:按键把半径内全部物品收进背包(一次性动作,不挂 patch)
            if (!typing && Settings.GrabAllKey != KeyCode.None && Input.GetKeyDown(Settings.GrabAllKey))
                GrabAll.Trigger(Settings.GrabAllRadius, Settings.GrabAllNotify);

            // Time scale —— 按住加速,松开恢复
            // v2.8.1: 不再用 DetermineIfOverlayIsActive (读条面板也算 overlay 导致加速失效)
            //   只在暂停菜单/uConsole 时屏蔽,读条/制作/搜刮等进度条期间允许加速
            if (Settings.TimeScaleKey1 != KeyCode.None || Settings.TimeScaleKey2 != KeyCode.None || _tsActive1 || _tsActive2 || Time.timeScale != 1f)
            {
                bool held1 = !typing && Settings.TimeScaleKey1 != KeyCode.None && Input.GetKey(Settings.TimeScaleKey1);
                bool held2 = !typing && Settings.TimeScaleKey2 != KeyCode.None && Input.GetKey(Settings.TimeScaleKey2);
                bool blocked = uConsole.m_On;
                if (!blocked)
                {
                    var pause = InterfaceManager.GetPanel<Panel_PauseMenu>();
                    if (pause != null) try { blocked = pause.isActiveAndEnabled; } catch { }
                }
                if (!blocked && held1)
                {
                    _tsActive1 = true; _tsActive2 = false;
                    Time.timeScale = GameManager.m_GlobalTimeScale = Settings.TimeScale1;
                }
                else if (!blocked && held2)
                {
                    _tsActive2 = true; _tsActive1 = false;
                    Time.timeScale = GameManager.m_GlobalTimeScale = Settings.TimeScale2;
                }
                else if (_tsActive1 || _tsActive2)
                {
                    _tsActive1 = _tsActive2 = false;
                    Time.timeScale = GameManager.m_GlobalTimeScale = 1f;
                }
            }

            // Speed multiplier (菜单全局倍速滑块)
            if (CheatState.SpeedMultiplier > 0f
                && Mathf.Abs(CheatState.SpeedMultiplier - 1f) > 0.01f
                && Mathf.Abs(Time.timeScale - CheatState.SpeedMultiplier) > 0.01f)
                Time.timeScale = CheatState.SpeedMultiplier;

            // 快速采集延迟完成 (QuickCraft v2.7.42 改走 IncrementProgress Prefix,不需要 Tick)
            QuickHarvestRunner.Tick();

            // v2.7.80 同步频率 5s → 0.5s(300→30 帧)—— 修 "ModSettings Disable All 后 5 秒内还生效" 根因
            //   SyncStateFromSettings 只是 ~50 个 bool copy,成本可忽略
            if (_frame > 0 && (_frame % 30) == 15)
            {
                SyncStateFromSettings();
                if (Settings.World_BowRepair)
                    Patch_GearItem_Awake_BowRepair.PreloadMaterials();
                Patch_GearDegrade.InvalidateCache();
                // v7.7 延迟落盘的真正写盘点(见 Settings.RequestSave)。无脏标记时是一次 bool 判定,零成本。
                Settings.FlushPendingSave();
                // v7.7 交互加速倍率拖回 1 后,把改过的 panel 字段写回 vanilla 基准
                //   (patch 此时已卸载,没人再跑 prefix,只能在这里还)。无待还项时只是一次 Count 判定。
                //   按 key 逐个判自己那个滑条是否已回 1(见 SpeedyGuard.RestoreSettled)。
                if (SpeedyGuard.HasPending) SpeedyGuard.RestoreSettled();

                // v8.2 修「UI 里勾了开关要等几秒才生效」。
                //   动态 patch 只在下面 (_frame % 300) == 25 那一处 Reconcile,60fps 约 5 秒一次,
                //   帧率低时更久。CheatState 是当场就写的,所以玩家看到的是"开关亮了但功能没反应",
                //   等几秒后才忽然生效 —— 正是"UI 和 Mod Settings 对不上"的实际观感。
                //   改过开关才 Reconcile 一次(脏标记见 Settings.RequestSave / OnConfirm),
                //   没改过时只是一次 bool 判定;Reconcile 对没变化的 patch 自己早退,
                //   所以拖滑条时也不会反复挂卸。
                //   衰减 / 鹿肉倍率三个 spec 的条件读 DecayState / MeatState,它们平时由 TweaksRuntime 每 60 帧另起一个计数器同步,
                //   这里先同步一次,否则约七成的改动会被一次还看着旧值的 Reconcile 吃掉脏标记,又要等 5 秒。
                if (TldHacksSettings.ConsumePatchDirty()) { TweaksRuntime.SyncDecayState(Settings); DynamicPatch.Reconcile(); }
            }

            // v2.7.88: 体力恢复直接每帧写字段 (跳过 Harmony hook,确保滑条立即生效)
            try { Patch_StaminaTweaks.ApplyTick(); } catch { }
            // v2.7.88: 哈气特效兜底,每帧主动写字段
            try { BreathHandlerTick.Tick(); } catch { }
            // v2.7.88r3: 出门自动开地图
            try { AutoOpenMapHandler.Tick(); } catch { }
            // v2.7.88: 空格秒完成 (拆解/采集/制作/修理 面板按空格立刻完成)
            try { SpaceFinishHandler.Tick(); } catch { }
            // v8.3 一键搜刮的逐件确认队列。队列空着时第一句 bool 判定就返回,零成本。
            try { GrabAll.TickQueue(); } catch { }
#if !STORY_EDITION
            try { MapClear.Tick(); } catch { }
#if !EP5_EDITION
            try { MapHarvest.Tick(); } catch { }
#endif
            try { TalesComplete.Tick(); TalesComplete.TickSceneFix(); } catch { }
#endif

            // v2.7.75 稳定节奏:动态 patch 只在固定低频点 reconcile。
            if ((_frame % 300) == 25) DynamicPatch.Reconcile();
#if !STORY_EDITION
            // v6.0.7 FlaskAnyItem 原生 NOP patch(2.24 无保温瓶,整类已排除)
            if ((_frame % 300) == 30) FlaskNativePatch.Sync();
#endif
            // v7.5 篝火燃烧上限 keeper:持续把 FireManager cap 顶在目标值,修"已存在篝火加不过12h"
            if ((_frame % 300) == 35) FireCapKeeper.Tick();

            // (InfiniteCarry 已去除,由其他 mod 覆盖)

            // v2.7.21 FPS 修:所有 tick 按 frame modulo 摊到不同帧
            // 之前 _extraTick==90 时 7 个 sub-tick 同帧触发 = 单帧 ~50ms 巨 spike = 跳帧
            // 现在每种 tick 有自己的 phase + period,最多 1 个 heavy tick/帧
            _frame++;
            advanced = true;

            // Infinite durability: 每 300 帧(~5s)phase 0
            if (CheatState.InfiniteDurability && (_frame % 300) == 0)
                Cheats.TickInfiniteDurability();

            // v2.7.26 FPS 优化:
            //   TrueInvisible 字段设置从 tick 扫 FindObjects 改成 BaseAi.Start Postfix(新 AI 出生时自动设)
            //   TickAnimalsFull 降到 600 帧(10s)仅做兜底,Stealth 的 SetAiMode(Flee) 也仍走这里
            //   TickAnimalsCheap(1s,只设玩家 m_AiTarget.m_IsEnabled 1 字段)保留
            if ((_frame % 60) == 5)
                CheatsTick.TickAnimalsCheap();
            if ((_frame % 600) == 30)
                CheatsTick.TickAnimalsFull();

            // v2.7.84 TickStatus 从 60 帧搬到 OnLateUpdate 每帧 —— 消除 HUD 值"掉到中间→跳回满"闪烁
            //   Unity 顺序:MonoBehaviour.Update(游戏的 Fatigue.Update 在这耗体力) → LateUpdate(我们这里 clamp)→ Render
            //   每帧 clamp 5 个字段,<10μs/帧,FPS 影响可忽略;GodMode 的 HP 同理
            // 注:此处不再调 TickStatus,见 OnLateUpdate()

            // 其余 sub-tick 每 180 帧一次(3s),错开 phase
            if ((_frame % 180) == 15)  CheatsTick.TickGuns();
            if ((_frame % 180) == 45)  CheatsTick.TickClothingWetness();
            if ((_frame % 180) == 75)  CheatsTick.TickClimbRope();
            if ((_frame % 180) == 135) CheatsTick.TickLocks();
            if ((_frame % 180) == 165) CheatsTick.TickQuickActions();

            // One-shot 类:状态变化时重设即可,低频 OK
            if ((_frame % 180) == 90) { ExtraOneShot.TickSprainRisk(); }

            // 天气锁定:每 60 帧(~1s)查一次,游戏计时器切走了才重新 apply(见 SetWeatherStageInternal)
            if (CheatState.WeatherLocked && (_frame % 60) == 30)
                try { Cheats.SetWeatherStageInternal(CheatState.WeatherLockedStage); } catch { }

            // v2.8.2 NoFallDamage reactive tick — 检测+清除扭伤/衣物破损
            if (CheatState.NoFallDamage && (_frame % 30) == 7) CheatsTick.TickNoFallDamage();

            // v6.9.1 AfflictionGuard reactive tick — 防止 IL2CPP prefix 漏网导致 affliction 半启动→游戏状态损坏
            if ((CheatState.GodMode || CheatState.ImmuneAnimalDamage || CheatState.NoSuffocating) && (_frame % 60) == 37)
                CheatsTick.TickAfflictionGuard();

            // v6.7.1 ClearAllAfflictions 二次扫窗口:用户点了一键清除负面之后 ~5s 内分多个 tick 扫
            //   防御目标:整合包里第三方 Cold/Sickness mod 把 vanilla XxxEnd 当 Postfix 钩子反补"感冒"
            //   仅在窗口期内生效,不开窗口=零开销;只在关键 tick 扫(覆盖 next-frame / 同 tick / 隔几帧 几种 Postfix 时序)
            if (CheatState.AfflictionClearReSweepFramesLeft > 0)
            {
                int left = CheatState.AfflictionClearReSweepFramesLeft;
                CheatState.AfflictionClearReSweepFramesLeft--;
                // 在 left=300/299/295/270/240/180/120/60/1 这几个点各扫一次(共 9 次,FPS 无感)
                if (left == 300 || left == 299 || left == 295 || left == 270
                    || left == 240 || left == 180 || left == 120 || left == 60 || left == 1)
                {
                    try { Cheats.ClearAllAfflictionsInternal(); } catch { }
                }
            }

            // 摄像机 / 武器 aim:v2.7.83 从 120 帧降到 30 帧(0.5s),更灵敏
            if ((_frame % 30) == 20) CheatsTick.TickCamera();

            // 玩家位置:菜单打开时 ~1 秒刷一次
            if (Menu.Open && ++_posTick >= 60)
            {
                _posTick = 0;
                Cheats.UpdatePlayerPosition();
            }

            // 跨场景传送 pending tick
            Teleport.TickPendingTeleport();
            TeleportFallGuard.Tick();

            // v2.7.94 MotionTrackerLite 持续强制启用(5s)
            if ((_frame % 300) == 50) MotionTrackerLiteHelper.EnsureVisible();
            // 每 300 帧在暂停/菜单安全时机做 Gen0 优化回收
            if ((_frame % 300) == 50)
            {
                try
                {
                    if (GameManager.m_IsPaused || InterfaceManager.IsOverlayActiveImmediate())
                        System.GC.Collect(0, System.GCCollectionMode.Optimized, false);
                }
                catch { }
            }

            // v2.7.94 双击地图图标传送
            MapClickTeleport.Tick();

            // v2.7.94 TweaksRuntime: 实时应用滑块设置(移动/图形/光源/衰减)
            TweaksRuntime.Tick();


            // v2.7.95 跳跃(整合 Jump mod) — v3.0.3 加总开关
            if (Settings.JumpEnabled) JumpHelper.Tick();

            // v2.7.95 GunZoom 滚轮输入
            if (Settings.GunZoomEnabled) GunZoomState.UpdateScroll();



            WakeUpCallHelper.OnUpdateTick();
            AutoSurveyHelper.OnUpdateTick();
#if !STORY_EDITION
            MapMKeys.Tick();
            CeX.Tick();
#endif
#if !STORY_EDITION && !EP5_EDITION
            CollMap.Tick();
#endif

            // 魔法子弹:预览目标降频更新(内部 0.25s 节流,关闭时立即清空,零开销)
            if (CheatStateESP.MagicBullet) MagicBulletSystem.UpdatePreview();

            if (!NLBFontFixHelper.Exhausted)
            {
                int nlbPeriod = NLBFontFixHelper.Fixed ? 3600 : 300;
                if ((_frame % nlbPeriod) == 200)
                    try { NLBFontFixHelper.PatchOnce(); } catch { }
            }

            // 每 60 秒主动做一次 Gen0 收集，避免累积到大暂停
            if ((_frame % 3600) == 1800)
                try { System.GC.Collect(0, System.GCCollectionMode.Optimized, false); } catch { }

#if !STORY_EDITION
            // ShowTraderTrust 仅在用户开启时才 tick(2.24 无商人系统,整块已排除)
            if (CheatState.TT_ShowTraderTrust && (_frame % 60) == 5)
                try { ShowTraderTrustHelper.Tick(); } catch { }
            if (Patch_TraderManager_CloseTrade.Pending && (_frame % 30) == 7)
                Patch_TraderManager_CloseTrade.Tick();
#endif

        }
        catch (Exception ex) { if (!advanced) _frame++; Log?.Error($"[OnUpdate] {ex}"); }
    }

    public override void OnLateUpdate()
    {
        if (Settings != null && (Settings.DiagPauseRuntime || Settings.DiagUnpatchAll)) return;
#if !STORY_EDITION
        Stacking.OnLateUpdate();   // 2.24 无 InventoryGridDataItem,整个 Stacking.cs 已排除
#endif
        // v2.7.84 HUD 状态 clamp 每帧跑 —— LateUpdate 在 Update 的 drain 后、render 前,UI 不看到"掉到中间值"闪烁
        CheatsTick.TickStatus();
    }

    public override void OnGUI()
    {
        if (Settings != null && (Settings.DiagPauseRuntime || Settings.DiagUnpatchAll)) return;
        Menu.Draw();
#if !STORY_EDITION
        ShowTraderTrustHelper.DrawGUI();
#endif
        MagicBulletOverlay.OnGUI();
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        // v6.9.6 进入游戏场景后不再"立即"清哨兵 —— "更新后存档进不去"的崩溃发生在
        //   场景 init 之后的存档数据加载/应用阶段。立即清会让那种崩溃逃过下次启动的安全模式。
        //   改为:每次场景切换都重置稳定计时,由 OnUpdate 跑满 180 帧无崩才清(见 OnUpdate)。
        if (!_sentinelCleared) _stableFrames = 0;
        BreakDownCleanup.Armed = false;
        if (sceneName != null && sceneName.Contains("MainMenu")) I18n.MarkGameReady();
        Patch_GearItem_Awake_BowRepair.OnSceneInitialized();
        Teleport.OnSceneLoaded(sceneName);
        // v2.7.64 学习 scene transition 字段到 JSON,解决 DLC Tale 跨区物品丢失
        TransitionRecorder.OnSceneInitialized(sceneName);
#if !STORY_EDITION
        TalesComplete.OnSceneInitialized(sceneName);
#endif
        // v2.7.29 关键修:跨场景时清 BaseAi HashSet,避免 stale wrapper 残留 → AccessViolation
        try { BaseAiRegistry.Known.Clear(); } catch { }
        // v2.7.93 同理:4 个新注册表也跨场景清
        try { GearItemRegistry.Known.Clear(); } catch { }
        try { GunItemRegistry.Known.Clear(); } catch { }
        try { LockRegistry.Known.Clear(); } catch { }
        try { PlayerClimbRopeRegistry.Known.Clear(); } catch { }
        // v2.7.64 清 HeatSource snapshot dict,防 long session 累积旧场景的 stale IntPtr
        try { Patch_HeatSource_Update.Snapshots.Clear(); } catch { }
        // v2.7.80 快速采集/割肉 snapshot 闭环 —— 实例随场景 GC,字段污染自然消失
        try { HarvestableSnaps.Snapshots.Clear(); } catch { }
        try { Patch_Harvest_Refresh_Quick.Snapshots.Clear(); } catch { }
        // v7.7 同理清秒搜刮的 hold-time 快照(实例随场景销毁,旧 IntPtr 失效;
        //   不清会让 cleanupDone 永远不成立 → patch 卸不掉)
#if !STORY_EDITION
        try { Patch_TimedHold_UpdateHoldInteraction_QuickSearch.Snapshots.Clear(); } catch { }
#endif
        // v7.7 交互加速的 base-value 字典也没人清过(见审计 M2),同样是跨场景 stale wrapper
#if !STORY_EDITION
        try { Patch_Speedy_HoldInteraction.Data.Clear(); } catch { }
#endif
        try { SpeedyGuard.OnSceneChange(); } catch { }
        // v7.7 日志暂停:跨场景时 Enable(false) 不一定会来(面板随场景销毁),而
        //   m_GlobalTimeScale 是 static → 冻在 0 会带进新场景。这里兜底写回并清标志。
        try
        {
            if (PauseInJournalState.IsPaused)
            {
                Il2Cpp.GameManager.m_GlobalTimeScale = 1f;
                PauseInJournalState.IsPaused = false;
            }
        }
        catch { }
        // v2.7.64 清 AutoPickupGuard 的 DroppedAt dict —— 跨 scene 后地上 gear 会重新 spawn,旧 Pointer 失效
        try { AutoPickupGuard.DroppedAt.Clear(); } catch { }
        try { Patch_GearDegrade.InvalidateCache(); } catch { }
        try { RespawnablePlantsState.OnSceneLoaded(); } catch { }
#if !STORY_EDITION
        try { ShowTraderTrustHelper.OnSceneChange(); } catch { }
#endif
#if !STORY_EDITION && !EP5_EDITION
        FeatsSandbox.OnSceneInitialized(Settings);
#endif
        // v2.7.64 清 BreakDown snapshot —— 跨 scene 后 BreakDown 组件重新 spawn,stale ptr
        try { Patch_BreakDown_UpdateDuration.Snapshots.Clear(); } catch { }
        // v2.7.84 清 vp_FPSCamera 缓存 + 重置 aim 诊断 —— 跨场景相机实例重建
        try { CheatsTick.InvalidateCameraCache(); } catch { }
        // v2.7.94 MotionTrackerLite 默认启用雷达
        try { MotionTrackerLiteHelper.EnsureVisible(); } catch { }
        try { NLBFontFixHelper.OnSceneChange(); } catch { }
        // v2.7.94 地图传送缓存清理
        try { MapClickTeleport.OnSceneChange(); } catch { }
        // v2.7.96 CougarSoundBegone
        try { CougarSoundKiller.OnSceneLoad(sceneName); } catch { }
        // v2.7.96 BreakDownToolMemory 跨场景清理
        try { BreakDownToolMemory.LastToolIndex.Clear(); } catch { }
        // v7.7 坠落伤害倍率:GameManager.Awake 时 FallDamage 组件还没就绪,在这里补写
        try { Patch_FallDamageMultiplier.ApplyNow(); } catch { }
        // 场景切换是安全的 GC 时机 — 此时有 loading screen 遮挡，做完整回收
        try { System.GC.Collect(2, System.GCCollectionMode.Forced, true); } catch { }
    }
}

internal static class MotionTrackerLiteHelper
{
    private static System.Reflection.FieldInfo _visField;
    private static bool _resolved;

    public static void EnsureVisible()
    {
        if (!_resolved)
        {
            _resolved = true;
            var t = System.Type.GetType("MotionTrackerLite.Tracker, MotionTrackerLite")
                 ?? HarmonyLib.AccessTools.TypeByName("MotionTrackerLite.Tracker")
                 ?? HarmonyLib.AccessTools.TypeByName("MotionTrackerLite.ModMain");
            if (t != null)
                _visField = t.GetField("Enabled", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
        }
        if (_visField != null) _visField.SetValue(null, true);
    }
}

// v4.0r5 NorthernLightsBroadcast 字体修复
// IL2CPP 模式下 NLB 的 assetbundle prefab 里 TMP_Text.fontAsset 反序列化后为 null → 所有文字空白
// 修法:场景加载后主动搜索所有 font==null 的 TextMeshProUGUI 并赋值(TLD vanilla 用 NGUI 不用 TMP,
// 所以 font==null 的 TMP 只可能来自第三方 mod bundle)
internal static class NLBFontFixHelper
{
    private static bool _fixed;
    public static bool Fixed => _fixed;
    private static int _scanAttempts;
    public static bool Exhausted { get; private set; }
    private static Il2CppTMPro.TMP_FontAsset _cachedFont;
    private static UnityEngine.Material _cachedMat;

    public static void OnSceneChange() { _scanAttempts = 0; Exhausted = false; }

    public static void PatchOnce()
    {
        if (Exhausted) return;
        try
        {
            var allTmp = UnityEngine.Resources.FindObjectsOfTypeAll<Il2CppTMPro.TextMeshProUGUI>();
            if (allTmp == null || allTmp.Count == 0) { if (++_scanAttempts > 10) Exhausted = true; return; }

            if (_cachedFont == null)
            {
                var all = UnityEngine.Resources.FindObjectsOfTypeAll<Il2CppTMPro.TMP_FontAsset>();
                if (all != null && all.Count > 0)
                {
                    foreach (var f in all)
                    {
                        if (f == null) continue;
                        try
                        {
                            if (f.name != null && f.name.Contains("LiberationSans") && f.material != null && f.atlasTexture != null)
                            { _cachedFont = f; break; }
                        }
                        catch { }
                    }
                    if (_cachedFont == null)
                    {
                        foreach (var f in all)
                        {
                            if (f == null) continue;
                            try
                            {
                                if (f.name != null && !f.name.Contains("Arcade") && f.material != null && f.atlasTexture != null)
                                { _cachedFont = f; break; }
                            }
                            catch { }
                        }
                    }
                    if (_cachedFont == null)
                    {
                        foreach (var f in all)
                        {
                            if (f == null) continue;
                            try { if (f.material != null) { _cachedFont = f; break; } } catch { }
                        }
                    }
                }
            }
            if (_cachedFont == null) return;
            if (_cachedMat == null) try { _cachedMat = _cachedFont.material; } catch { }

            int count = 0;
            foreach (var tmp in allTmp)
            {
                if (tmp == null) continue;
                bool broken = false;
                try { broken = (tmp.font == null); } catch { broken = true; }
                if (!broken)
                {
                    try { var n = tmp.font.name; if (n == null) broken = true; } catch { broken = true; }
                }
                if (!broken)
                {
                    try { var m = tmp.font.material; if (m == null) broken = true; } catch { broken = true; }
                }
                if (!broken)
                {
                    try { var a = tmp.font.atlasTexture; if (a == null) broken = true; } catch { broken = true; }
                }
                if (broken)
                {
                    tmp.font = _cachedFont;
                    if (_cachedMat != null)
                        try { tmp.fontSharedMaterial = _cachedMat; } catch { }
                    try { tmp.ForceMeshUpdate(true, true); } catch { }
                    count++;
                }
            }
            if (count > 0)
            {
                _fixed = true;
                _scanAttempts = 0;   // 这次真修到东西 → 重新给满额度(可能还有后续 bundle 加载进来)
                ModMain.Log?.Msg($"[NLB] Fixed {count} TMP_Text with broken font -> {_cachedFont.name}");
            }
            else if (++_scanAttempts > 10)
            {
                // v7.7 性能修:原先 _scanAttempts 只在 allTmp 为空时递增,于是场景里只要存在
                //   任何 TMP 对象(任何用 TMP 的第三方 mod 都会带来),额度永不消耗 →
                //   Resources.FindObjectsOfTypeAll 全托管堆扫描 + 每个结果 3-4 次属性桥
                //   无限期每 5s(修好后 60s)复发一次,表现为周期性 5-30ms hitch。
                //   连续 10 轮扫到 TMP 但没有一个 font 坏掉 = NLB 的 bundle 要么没装要么已修好,
                //   可以停扫。切场景时 OnSceneChange 会重置额度,新 bundle 仍能被接住。
                Exhausted = true;
            }
        }
        catch { }
    }
}

// v2.7.95 整合 Jump mod — 完整版(支持负重/卡路里/体力/疲劳限制 + JumpKing 无限制模式)
internal static class JumpHelper
{
    public static void Tick()
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || s.JumpKey == UnityEngine.KeyCode.None) return;
            if (!Il2Cpp.InputManager.GetKeyDown(Il2Cpp.InputManager.m_CurrentContext, s.JumpKey)) return;
            var cam = Il2Cpp.GameManager.GetVpFPSCamera();
            if (cam == null || !cam.Controller.isGrounded) return;
            if (Il2Cpp.uConsole.m_On || Il2Cpp.InterfaceManager.IsOverlayActiveCached()) return;
            if (Il2Cpp.GameManager.GetPlayerManagerComponent().PlayerIsCrouched()) return;

            var player = Il2Cpp.GameManager.GetVpFPSPlayer();
            float jumpForce = s.JumpHeight / 100f;

            if (s.JumpKing || Il2Cpp.GameManager.GetPlayerManagerComponent().m_God)
            {
                player.Controller.MotorJumpForce = jumpForce;
                player.Controller.Jump();
                return;
            }

            // 限制检查
            if (Il2Cpp.GameManager.GetSprainedAnkleComponent().HasSprainedAnkle())
            { Il2Cpp.HUDMessage.AddMessage(I18n.T("你受伤了，无法跳跃", "Sprained — can't jump"), true, true); return; }

            float weight = Il2Cpp.GameManager.GetInventoryComponent().GetTotalWeightKG().ToQuantity(1f);
            float weightCap = s.JumpWeightLimit + s.JumpWeightLimit * 0.334f;
            if (weight >= weightCap)
            { Il2Cpp.HUDMessage.AddMessage(I18n.T("携带物品过重，无法跳跃", "Too heavy — can't jump"), true, true); return; }

            if ((int)Il2Cpp.GameManager.GetHungerComponent().GetHungerLevel() == 4)
            { Il2Cpp.HUDMessage.AddMessage(I18n.T("饥饿状态无法跳跃", "Starving — can't jump"), true, true); return; }

            if ((int)Il2Cpp.GameManager.GetThirstComponent().GetThirstLevel() == 4)
            { Il2Cpp.HUDMessage.AddMessage(I18n.T("脱水时无法跳跃", "Dehydrated — can't jump"), true, true); return; }

            if ((int)Il2Cpp.GameManager.GetFatigueComponent().GetFatigueLevel() == 4)
            { Il2Cpp.HUDMessage.AddMessage(I18n.T("疲惫时无法跳跃", "Exhausted — can't jump"), true, true); return; }

            float stamina = Il2Cpp.GameManager.GetPlayerMovementComponent().m_SprintStamina;
            if (stamina < s.JumpStaminaCost * 0.5f)
            { return; }

            // 负重影响跳跃高度
            float weightRatio = weight / s.JumpWeightLimit * 100f;
            float heightMult = 100f / (1f + UnityEngine.Mathf.Pow(weightRatio / 115f, 10f)) / 100f;
            player.Controller.MotorJumpForce = jumpForce * heightMult;

            // 消耗
            if (s.JumpCalorieCost > 0)
            {
                float calCost = (UnityEngine.Mathf.Round(heightMult * 100f) >= 100f)
                    ? s.JumpCalorieCost * 0.5f : s.JumpCalorieCost;
                Il2Cpp.GameManager.GetHungerComponent().RemoveReserveCalories(calCost);
            }

            if (s.JumpStaminaCost > 0)
                Il2Cpp.GameManager.GetPlayerMovementComponent().AddSprintStamina(-s.JumpStaminaCost);

            if (s.JumpFatigueCost > 0)
                Il2Cpp.GameManager.GetFatigueComponent().AddFatigue(s.JumpFatigueCost);

            player.Controller.Jump();
        }
        catch { }
    }
}
