using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// v7.7 — 一键搜刮:按键把玩家半径内(默认 15m)地上/场景里的全部 GearItem 直接收进背包。
//
// 设计取舍(遵守 FPS 红线):
//   本功能是「按键触发的一次性动作」,不挂任何 Harmony patch、不跑 per-frame 逻辑。
//   FindObjectsOfType<GearItem> 在大地图有 ~50-200ms 单次 spike,但只在玩家主动按键那一帧付出,
//   跟 Spawner tab 的刷物品按钮同性质,不影响正常游戏帧率。所以不需要走 DynamicPatch。
//
// 拾取方式:PlayerManager.ProcessPickupItemInteraction(gi, false, false, skipAudio) —— v8.1 换的。
//
// v8.1 修「捡了但地上东西不消失,能无限捡」(用户实测:室内一本书 + 一根羽毛 + 一根树枝,
//   按一下只有树枝真的消失,书和羽毛进了背包却还留在地上,可以反复捡到无限份)。
//   根因:v7.7-v8.0 用的 AddItemToPlayerInventory 只是**背包侧**的原语 —— 它负责把 gear 挂进
//   Inventory 列表,不负责拆掉这件东西在世界里的存在(interactive object 注销、collider/renderer
//   关掉、place point 解绑、ObjectGuid 记成已捡走 → 存档/回场景不再刷回来)。世界侧那套拆除是
//   vanilla 拾取交互 ProcessPickupItemInteraction 做的,它内部再去调 AddItemToPlayerInventory。
//   所以直接调底层 = 只加背包不清场景,于是"背包真的加了,但地上还在,还能再捡" —— 复制物资。
//   树枝之所以看着正常,是它命中了别的 mod 的拾取路径(ItemPicker 的树枝/石头专项),不是本功能的功劳,
//   这也正是"只有树枝消失"这个不对称现象的来源。
//   参照:ItemPicker 的批量拾取(GEAR_Stick/Stone/自定义列表)和 QoL 的 FastPick 都走
//   ProcessPickupItemInteraction,两者都不会留残影;而 MapManager 用 AddItemToPlayerInventory 的
//   那处(VistaLocation 的 polaroid)给的是**凭空发的**物品,本来就没有世界实例要清,不能照抄。
//   注:上面说的是「一次全收」那条路,它全程静默,vanilla 想发的 gear 提示用 Prefix 全拦
//   (见下面 QuietPickup)。想要拾取提示就开「逐件确认」,那条路走 vanilla 检视界面,见 TickQueue。
//
//   // ponytail: 用 FindObjectsOfType 全量扫 + 距离过滤,是最朴素可靠的做法;
//   //           若某地图物件数极大导致按键卡顿明显,可改 Physics.OverlapSphere 只取近处 collider 再取 GearItem。
internal static class GrabAll
{
    // 拾取半径下限,避免 slider 拖到 0 时白扫
    private const float MinRadius = 1f;

    // 提示闸门状态。_gate>0 表示"正在跑一次全收的循环",出了循环立刻归零。玩家自己
    //   手动捡东西的提示永远不受影响(这是 FPS 红线之外的另一条,别弄坏原有行为)。
    //   逐件确认那条路不抬闸门,那边全程用 vanilla 自己的界面和提示。
    private static int _gate;

    internal static bool InGrab => _gate > 0;

    // 闸门判定,由 GrabAllQuietPickup.Prefix 调,只读不写。
    internal static bool ShouldShowMessage() => _gate <= 0;

    // 为什么不是弹 HUD 提示:v8.2 先做的是自己发 GearMessage,实测能出来(日志 shown=8,
    //   HUD 右上角逐条播),但那不是玩家要的 —— 他要的是自己捡东西时那块物品特写,
    //   拿走 / 放回要点一下确认。那块是 PlayerManager.EnterInspectGearMode,模态的,
    //   一次只能显示一件,所以只能排队:开一件 → 等玩家点完 → 开下一件。
    //
    // 遵守 FPS 红线:队列空着时 TickQueue 第一句就是一次静态 bool 判定直接返回。
    private static readonly List<GearItem> _queue = new List<GearItem>();
    private static int _queueIdx;
    private static bool _queueActive;
    private static bool _asked;        // 已经对当前这件调过 EnterInspectGearMode
    private static bool _sawActive;    // 确实看见检视界面开起来了
    private static int _waitFrames;
    private static float _queueRadius;

    // 等检视界面开起来最多给多少帧。开不起来就跳过这一件,不能让队列卡死。
    private const int OpenTimeoutFrames = 90;

    private static void StartQueue(List<GearItem> cands, float radius, int skippedDrops, int scanned, int skippedLitter)
    {
        _queue.Clear();
        for (int i = 0; i < cands.Count; i++) _queue.Add(cands[i]);
        _queueIdx = 0;
        _asked = false;
        _sawActive = false;
        _waitFrames = 0;
        _queueRadius = radius;
        _queueActive = _queue.Count > 0;

        ModMain.Log?.Msg($"[GrabAll] 逐件确认开始 radius={radius:F0}m queued={_queue.Count} ownDrops={skippedDrops} litter={skippedLitter} scanned={scanned}");
        string litterZh = skippedLitter > 0 ? $",跳过树枝和石块 {skippedLitter} 件" : "";
        string litterEn = skippedLitter > 0 ? $", {skippedLitter} sticks and stones skipped" : "";
        CheatState.LastActionLog = _queue.Count == 0
            ? I18n.T($"附近没有可搜刮的物品(半径 {radius:F0}m{litterZh})", $"Nothing to grab within {radius:F0}m{litterEn}")
            : I18n.T($"逐件确认 {_queue.Count} 件(再按一次放弃剩下的{litterZh})",
                     $"Confirming {_queue.Count} items (press again to skip the rest{litterEn})");
    }

    private static void EndQueue(string status)
    {
        int taken = 0;
        for (int i = 0; i < _queue.Count; i++)
        {
            var gi = _queue[i];
            // 被合并销毁的(可堆叠物品)也算收上来了
            if (gi == null) { taken++; continue; }
            try { if (gi.m_InPlayerInventory) taken++; } catch { }
        }
        ModMain.Log?.Msg($"[GrabAll] 逐件确认结束 taken={taken}/{_queue.Count} radius={_queueRadius:F0}m ({status})");
        CheatState.LastActionLog = I18n.IsEnglish
            ? $"Grabbed {taken} of {_queue.Count} items"
            : $"已收下 {taken}/{_queue.Count} 件";

        _queue.Clear();
        _queueIdx = 0;
        _queueActive = false;
        _asked = false;
        _sawActive = false;
        _waitFrames = 0;
    }

    // 由 ModMain.OnUpdate 每帧调。队列空着时零成本。
    internal static void TickQueue()
    {
        if (!_queueActive) return;
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { EndQueue("player 丢了"); return; }

            // mod 菜单开着时挂起队列,不中断:从菜单里点「立即搜刮」按钮触发时菜单本来就是开的,
            //   当成中断会一件都弹不出来。关掉菜单后自动接着排。
            if (Menu.Open) return;

            // Esc = 放弃剩下的。Esc 同时也是 vanilla 退出检视的键,所以这里不去分辨
            //   "拿走"和"放回",两者都算这一件处理完了,只有 Esc 停整条队列。
            if (Input.GetKeyDown(KeyCode.Escape)) { EndQueue("玩家按 Esc 放弃"); return; }
            try { if (GameManager.IsMainMenuActive() || GameManager.IsEmptySceneActive()) { EndQueue("离开场景"); return; } } catch { }

            bool inspecting = false;
            try { inspecting = pm.IsInspectModeActive(); } catch { }

            if (_asked)
            {
                if (inspecting) { _sawActive = true; return; }
                if (!_sawActive)
                {
                    // 还没开起来。EnterInspectGearMode 里有动画和异步取资源,不是当帧就 active。
                    if (++_waitFrames < OpenTimeoutFrames) return;
                    ModMain.Log?.Warning($"[GrabAll] 第 {_queueIdx + 1} 件的检视界面没开起来,跳过");
                }
                _asked = false;
                _sawActive = false;
                _waitFrames = 0;
                _queueIdx++;
            }
            else if (inspecting)
            {
                return;   // 玩家自己在看别的东西,等他退出再接着排
            }

            while (_queueIdx < _queue.Count)
            {
                var gi = _queue[_queueIdx];
                bool usable = false;
                try
                {
                    usable = gi != null && !gi.m_InPlayerInventory
                             && gi.gameObject != null && gi.gameObject.activeInHierarchy;
                }
                catch { usable = false; }
                if (usable) break;
                _queueIdx++;
            }
            if (_queueIdx >= _queue.Count) { EndQueue("全部处理完"); return; }

            try
            {
                pm.EnterInspectGearMode(_queue[_queueIdx]);
                _asked = true;
                _sawActive = false;
                _waitFrames = 0;
            }
            catch (Exception ex)
            {
                ModMain.Log?.Warning($"[GrabAll] EnterInspectGearMode 第 {_queueIdx + 1} 件失败: {ex.Message}");
                _queueIdx++;
            }
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[GrabAll.TickQueue] {ex.Message}");
            EndQueue("异常中断");
        }
    }

    // Travois(雪橇)识别。类型在 2.55 是 Il2CppTLD.Gear.TravoisItem,2.24 未必同名,
    //   所以用反射按名字取一次并缓存:类型不存在就当"没有雪橇"处理,不抛异常。
    private static Type _travoisType;
    private static bool _travoisResolved;

    private static bool IsTravois(GameObject go)
    {
        try
        {
            if (!_travoisResolved)
            {
                _travoisResolved = true;
                var asm = typeof(GearItem).Assembly;
                _travoisType = asm.GetType("Il2CppTLD.Gear.TravoisItem") ?? asm.GetType("Il2Cpp.TravoisItem");
            }
            if (_travoisType == null) return false;
            return go.GetComponent(Il2CppInterop.Runtime.Il2CppType.From(_travoisType)) != null;
        }
        catch { return false; }
    }

    // 逐件确认时树枝和石块不弹也不收:遍地都是,一件件点太烦(用户自己用 ItemPicker 走路自动捡这两样)。
    //   一次全收那条路照旧全收。场景里的物体名会带 "(Clone)" 或 " (3)" 这类后缀,截掉再比。
    private static readonly char[] NameSuffixStart = { '(', ' ' };

    private static bool IsStickOrStone(GearItem gi)
    {
        try
        {
            string n = gi.name;
            int cut = n.IndexOfAny(NameSuffixStart);
            if (cut >= 0) n = n.Substring(0, cut);
            return n == "GEAR_Stick" || n == "GEAR_Stone";
        }
        catch { return false; }
    }

    // 半径内的候选物品。过滤条件独立出来,逐件确认和一次全收两条路用的是同一份判定。
    private static List<GearItem> Collect(Vector3 origin, float radius, out int skippedDrops, out int scanned)
    {
        skippedDrops = 0;
        scanned = 0;
        var list = new List<GearItem>();
        var all = UnityEngine.Object.FindObjectsOfType<GearItem>();
        if (all == null) return list;
        scanned = all.Count;
        float r2 = radius * radius;

        for (int i = 0; i < all.Count; i++)
        {
            var gi = all[i];
            if (gi == null) continue;
            try
            {
                // 已在背包 → 跳过
                if (gi.m_InPlayerInventory) continue;

                var go = gi.gameObject;
                // 未激活(多为关闭容器里的内容 / 未加载)→ 跳过,只收场景里真正存在的物品
                if (go == null || !go.activeInHierarchy) continue;

                // 尸骸上的可采集部件(生肉/皮毛)不是"地上物品",走拾取交互会出问题 → 跳过
                if (gi.m_BodyHarvest != null || gi.m_BodyHarvestItem != null) continue;

                // 距离过滤(3D,含高度差)
                if ((go.transform.position - origin).sqrMagnitude > r2) continue;

                // v8.1 雪橇(Travois)不能走普通拾取:它是拖拽物,vanilla 有独立的
                //   OnPickupFromTravoisInspection 路径。用普通拾取会把拖拽状态留在半路。
                //   跳过比"支持一半"安全,它本来也不是搜刮目标。
                if (IsTravois(go)) continue;

                // v8.1 尊重「跳过自己丢的物品」开关。那个开关的原意是"我特意丢在这儿的东西别自动捡回来"
                //   (基地整理物资时丢一地,不希望走过去又被吸走)。它原先只拦 ItemPicker 的自动
                //   拾取,是因为 GrabAll 那时压根没走 pickup 路径 → 这个开关对搜刮无效。
                //   现在两者走同一条路了,不一起处理就会出现"开了不捡丢物,一键搜刮照样吸走"。
                //   注意判据用玩家丢弃记录,不是 m_BeenInPlayerInventory,后者对"捡过又丢"
                //   的东西永久为真,会让这些物资从此再也搜不起来。
                if (CheatState.BlockAutoPickupOwnDrops
                    && AutoPickupGuard.DroppedAt.ContainsKey(gi.Pointer)) { skippedDrops++; continue; }

                list.Add(gi);
            }
            catch { /* 单个物品判定失败不影响其余 */ }
        }
        return list;
    }

    // 按键 / UI 按钮统一入口。radius 单位米。
    //   confirmEach=true 走 vanilla 检视界面逐件确认(见 TickQueue),false 一次全收不出提示。
    public static void Trigger(float radius, bool confirmEach)
    {
        try
        {
            if (radius < MinRadius) radius = MinRadius;

            // 逐件确认还没走完时再按一次 = 放弃剩下的。不重新扫场景。
            if (_queueActive)
            {
                EndQueue(I18n.T("已放弃剩下的确认", "Remaining items skipped"));
                return;
            }

            var pm = GameManager.GetPlayerManagerComponent();
            var pt = GameManager.GetPlayerTransform();
            if (pm == null || pt == null)
            {
                ModMain.Log?.Warning("[GrabAll] player 未就绪");
                return;
            }

            // 主菜单 / 空场景不干活
            try { if (GameManager.IsMainMenuActive() || GameManager.IsEmptySceneActive()) return; } catch { }

            // v8.1 检视界面(捡起来看那个特写)开着时不搜刮:那会儿 vanilla 自己正拿着
            //   m_PickupGearItem 走一套带动画的状态机,横插一脚会把它的状态搅乱。
            //   等玩家退出检视再按就是了。
            try { if (pm.IsInspectModeActive()) { ModMain.Log?.Msg("[GrabAll] 检视界面开着,跳过"); return; } } catch { }

            var cands = Collect(pt.position, radius, out int skippedDrops, out int scanned);

            if (confirmEach)
            {
                int litter = cands.RemoveAll(IsStickOrStone);
                StartQueue(cands, radius, skippedDrops, scanned, litter);
                return;
            }

            int grabbed = 0;
            int failed = 0;

            // 闸门在这段循环里拦掉 vanilla 的 gear 提示。静默模式就该是真静默。
            GrabAllQuietPickup.EnsureAttached();
            _gate++;
            try
            {
                for (int i = 0; i < cands.Count; i++)
                {
                    var gi = cands[i];
                    if (gi == null) { failed++; continue; }
                    try
                    {
                        // v8.1 关键修复:改走 vanilla 拾取交互。它内部会调 AddItemToPlayerInventory,
                        //   同时把世界侧那份拆掉(注销 interactive object / 关 collider+renderer /
                        //   解绑 place point / 记 ObjectGuid 已捡)。原先直调背包原语只做了后半段,
                        //   所以东西进了背包却留在地上,能反复捡 → 无限刷物资。
                        //   参数与 ItemPicker / QoL 一致:forceEquip=false, forceEquipImmediate=false,
                        //   第四参 skipAudio=true 连拾取音效一起省掉,一次收几十件不至于糊成一片。
                        bool ok;
#if STORY_EDITION
                        // 2.24 只有 3 参(item, forceEquip, skipAudio)
                        ok = pm.ProcessPickupItemInteraction(gi, false, true);
#else
                        ok = pm.ProcessPickupItemInteraction(gi, false, false, true);
#endif
                        if (ok) grabbed++; else failed++;
                    }
                    catch { failed++; /* 单个物品失败不影响其余 */ }
                }
            }
            finally { _gate--; }

            ModMain.Log?.Msg($"[GrabAll] radius={radius:F0}m grabbed={grabbed} failed={failed} ownDrops={skippedDrops} scanned={scanned}");
            CheatState.LastActionLog = I18n.IsEnglish
                ? $"Grabbed {grabbed} items within {radius:F0}m"
                : $"已搜刮 {grabbed} 件物品(半径 {radius:F0}m)";
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[GrabAll] {ex.Message}");
            CheatState.LastActionLog = I18n.IsEnglish
                ? "Grab All failed (see log)"
                : "一键搜刮失败(见日志)";
        }
    }
}

// v8.1 —— 搜刮期间的拾取提示节流。
//
// 为什么要 patch:改走 vanilla 拾取后,那条"拾取了 xxx"的 toast 由游戏自己发,
//   本文件不再手工发(否则每件两条)。但两个需求还得满足:
//   1) 「弹拾取提示」关掉时要真的静默 —— 不能因为改了拾取路径就把这个开关弄失效;
//   2) 开着时也要有上限 —— GearMessage 是排队逐条播的,一次收 50 件会霸屏几十秒。
//
// 挂在 GearMessage.AddMessageToQueue:所有 AddMessage / AddMessageFadeIn 重载最后都汇到
//   这一个静态方法,拦这一处就够,不用逐个重载挂。
//   两个版本签名不同(2.55 是 (Panel_HUD, GearMessageInfo, bool),2.24 是 (GearMessageInfo, bool)),
//   所以按名字取、Prefix 不声明任何参数 —— Harmony 允许 Prefix 只取自己要的参数,一个都不要
//   也合法。这样同一份源码两个版本都挂得上,不用 #if 分叉。
//
// 遵守 FPS 红线:按需挂一次(第一次搜刮时),之后常驻。Prefix 第一句是 `if (!GrabAll.InGrab)
//   return true;` —— 平时(非搜刮)是一次静态 int 比较就返回,不碰 IL2Cpp,开销可忽略;
//   而且这方法只在有 toast 要弹时才被调,本身不是每帧路径,所以不需要走 DynamicPatch。
internal static class GrabAllQuietPickup
{
    private const string HARMONY_ID = "TldHacks.GrabAllQuiet";
    private static bool _attached;

    public static void EnsureAttached()
    {
        if (_attached) return;
        _attached = true;   // 失败也不重试:免得每次按键都反射找一遍
        try
        {
            var mi = AccessTools.Method(typeof(GearMessage), "AddMessageToQueue");
            if (mi == null)
            {
                ModMain.Log?.Warning("[GrabAllQuiet] GearMessage.AddMessageToQueue 没找到,提示节流不生效(拾取本身不受影响)");
                return;
            }
            new HarmonyLib.Harmony(HARMONY_ID).Patch(mi,
                prefix: new HarmonyMethod(AccessTools.Method(typeof(GrabAllQuietPickup), nameof(Prefix))));
            ModMain.Log?.Msg("[GrabAllQuiet] hooked GearMessage.AddMessageToQueue");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[GrabAllQuiet] {ex.Message}"); }
    }

    private static bool Prefix()
    {
        if (!GrabAll.InGrab) return true;   // 玩家手动拾取 → 原样放行
        return GrabAll.ShouldShowMessage();
    }
}
