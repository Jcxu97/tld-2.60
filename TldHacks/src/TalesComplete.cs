#if !STORY_EDITION
using System;
using System.Collections.Generic;
using System.IO;
using Il2Cpp;
using Il2CppInteractiveObjects;
using Il2CppNodeCanvas.StateMachines;
using UnityEngine;

namespace TldHacks;

// v9.8 一键完成 DLC 任务(外域传说 Tales 1~3,只在生存模式)。
//   任务脚本是 NodeCanvas FSM,资源包里解出来的结构见 _work/tales/README.md。
//   每个步骤都有一个"做过没"的 bool,步骤自己把它设成 true。这里按顺序直接跳进每个没做过的步骤,
//   让游戏自己发物品、勾目标、开门、解锁徽章和专长;只有过场动画那几步不跳,改成手动把 bool 设好。
//   需要玩家在野外捡到的任务道具先发进背包,脚本里"背包有这件东西"的条件就会自己往下走。
//   塔和隐藏地堡另走全局存档改状态;当前没加载的场景,进场景时再补一次(SceneFix)。
internal static class TalesComplete
{
    private const float ArmSeconds = 4f;
    private const int FramesPerStep = 4;
    private const int StateWaitFrames = 120;
    private const float StepTimeoutSeconds = 90f;

    private sealed class Tale
    {
        public string Id, Wait, Setup, SetupVar;
        public string[] Items;
        public string[] PreSetVars;
        public string[] Steps; // 成对:步骤名, 这一步自己设的 bool
    }

    private static readonly Tale[] Tales =
    {
        new Tale
        {
            Id = "sideTale1", Wait = "Tale 1 Wait", Setup = "Tale 1 setup", SetupVar = "talesFoundStartNote",
            // 第一件是 Anim Prep 发的(那步是过场,跳过);笔记 1~5 是野外捡的
            Items = new[] { "GEAR_HandheldShortwave", "GEAR_Tale1ChiefNote1", "GEAR_Tale1ChiefNote2", "GEAR_Tale1ChiefNote3", "GEAR_Tale1ChiefNote4", "GEAR_Tale1ChiefNote5" },
            PreSetVars = new string[0],
            Steps = new[]
            {
                "Tale 1 Transmitter 1 (AF)", "tale1Transmitter1Repaired",
                "Tale 1 Transmitter 2", "tale1Transmitter2Repaired",
                "Tale 1 Transmitter 3", "tale1Transmitter3Repaired",
                "Tale 1 Transmitter 4", "tale1Transmitter4Repaired",
                "Enter BI Bunker", "bunkerAEnter",
                "Enter PV Bunker", "bunkerBEnter",
                "Enter HRV Bunker", "bunkerCEnter",
                "Tale 1 Bunker BI - got log book", "tale1FoundNote2",
                "Tale 1 Bunker PV - Got log book", "tale1FoundNote3",
                "Tale 1 Bunker HRV - got log book", "tale1FoundNote1",
                "Tale1 Bunker PV - got transcript", "tale1FoundTranscript3",
                "Tale 1 Bunker BI - got transcript", "tale1FoundTranscript2",
                "Tale 1 Bunker HRV - got transcript", "tale1FoundTranscript1",
                "BI Objectives Complete", "tale1BleakInletDone",
                "PV Objectives complete", "tale1PleasantValleyDone",
                "HRV Objectives complete", "tale1HRVDone",
                "Final Bunker Objective", "tale1FinalObjectiveAdded",
                "Final Bunker Enable", "finalBunkerActive",
                "Enter XL Bunker", "bunkerXLEnter",
                "Final Bunker Collectibles Active", "bunkerXLCollectibles",
                "Tale 1 XL Bunker - got log book", "tale1FoundNote4",
                "Tale 1 XL Bunker - got transcript", "tale1FoundTranscript4",
                "Tales 1 Complete", "tale1Complete",
            },
        },
        new Tale
        {
            Id = "sideTale2", Wait = "Tale 2 Wait", Setup = "Tale 2 setup", SetupVar = "beginTale2",
            Items = new[] { "GEAR_Tale2GeologistNote1", "GEAR_Respirator", "GEAR_Tale2_LockerKey", "GEAR_BoltCutters", "GEAR_Tale2_CorpseKey", "GEAR_Tale2RudigerNote1", "GEAR_Tale2SecurityChiefBones" },
            // 矿洞那段过场(碰尖塔、睡两小时、看控制室)会重新锁上密室门,
            //   不先设好这几个 bool,玩家以后走进去还会被锁住
            PreSetVars = new[] { "touchSpire", "wakeUp", "lockControlRoom" },
            Steps = new[]
            {
                "Read Geologist's Note", "readGeologistNote",
                "Enable GeoBones Cache", "bonesSiteFound",
                "Tale 2 Obj 0", "bonesSiteDone",
                "Read Logbook 1", "readLogbook1",
                "Read Foreman Report 1", "readForemanReport1",
                "Found BoltCutters", "gotBoltCutters",
                "found Locker Key", "gotLockerKey1",
                "Locate  Crash Site - done", "locateCrashSite",
                "Found Respirator", "foundRespirator",
                "Search Concentrator - done", "searchConcentrator",
                "Tale 2 Obj 1 + 2 = 3", "aboveGroundDone",
                "Obj 3 Upper Mine", "locateUpperMineEntrance",
                "Obj 3 Corpse Key", "locateUpperMineKey",
                "Read Foreman Report 2", "readForemanReport2",
                "Read Foreman Report 3", "readForemanReport3",
                "Read Logbook 2", "readLogbook2",
                "Read Logbook 3", "readLogbook3",
                "After Spire Touch", "auroraOn",
                "got Rudiger Note", "gotRudigerNote",
                "got Bones", "gotChiefBones",
                "Read Final Logbook", "readLogbook4",
                "Read Final Foreman Report", "readForemanReport4",
                "Rudiger Room Search - done", "machineRoomComplete",
                "Burial Site Active", "activateBurial",
                "Lay Bones To Rest", "bonesAtRest",
            },
        },
        new Tale
        {
            Id = "sideTale3", Wait = "Tale 3 Wait", Setup = "Tale 3 setup", SetupVar = "beginTale3",
            Items = new[] { "GEAR_Tale3_ForemanRefugeKey", "GEAR_Tale_03_PostCard_05", "GEAR_SecurityChiefID", "GEAR_Rudiger_Watch" },
            // 气象站那步要等极光,只加一个目标,随后的 Weather Station Done 会把它勾掉
            PreSetVars = new[] { "atWeatherStationAurora" },
            Steps = new[]
            {
                "Weather Station Cache active", "weatherCacheActive",
                "Read Foreman's Log 1", "hasForemanLog1",
                "Found Foreman's Refuge Key", "hasRefugeKey",
                "Weather Station Done", "weatherStationDone",
                "Foreman Refuge Unlock", "foremanRefugeUnlocked",
                "Read Foreman's Log 2", "hasForemanLog2",
                "Rudiger Hideout Active", "rudigerHideoutActive",
                "Entered Rudiger Basement", "enteredBasement",
                "Read Read Rudiger Note 1", "hasRudigerNote1",
                "Found Loose Hideout Polaroid", "hasHideoutPolaroid",
                "Rudiger Hideout Done", "rudigerHideoutDone",
                "High Peak Path Active", "highPeakPathActive",
                "Entered High Peak Path", "enteredHighPeakPath",
                "Search High Peak Summit -- Foreman", "hasForemanLog3",
                "Search High Peak Summit -- Rudiger", "hasRudigerNote2",
                "Search High Peak Summit -- Done", "mountainPassComplete",
                "Omega Bunker Active", "omegaBunkerActive",
                "Omega Bunker -- Hidden Door activate", "hiddenDoorActive",
                "Omega Bunker -- Enter Hidden Room", "omegaEnterHiddenRoom",
                "Search Omega Bunker -- Foreman", "hasForemanLog4",
                "Search Omega Bunker -- Rudiger", "hasRudigerNote3",
                "Has Security Chief ID", "hasSecurityChiefID",
                "Has Rudiger Watch", "hasRudigerWatch",
                "Tale 3 Complete", "tale3Complete",
            },
        },
    };

    private static float _armedUntil;

    public static void Trigger()
    {
        try
        {
            if (_active) { CheatState.LastActionLog = I18n.T("DLC 任务还在处理中", "DLC tales are still running"); return; }
            if (!InGame()) return;
            if (GameManager.IsStoryMode())
            {
                CheatState.LastActionLog = I18n.T("剧情模式没有 DLC 任务", "Story mode has no DLC tales");
                return;
            }
            if (Owner("sideTale1") == null)
            {
                CheatState.LastActionLog = I18n.T("没有找到 DLC 任务(没装外域传说 DLC,或者是挑战模式)", "No DLC tales found (no Far Territory DLC, or a challenge)");
                ModMain.Log?.Msg("[Tales] sideTale1 not found");
                return;
            }
            float now = Time.realtimeSinceStartup;
            if (now > _armedUntil)
            {
                _armedUntil = now + ArmSeconds;
                CheatState.LastActionLog = I18n.T("再点一次「完成DLC任务」确认。会先备份当前存档",
                    "Click Finish DLC Tales again to confirm. The current save is backed up first");
                return;
            }
            _armedUntil = 0f;
            BackupSave();
            Start();
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] Trigger: {ex}"); }
    }

    private static bool InGame()
    {
        try
        {
            if (GameManager.GetPlayerManagerComponent() == null || GameManager.GetPlayerTransform() == null) return false;
            if (GameManager.IsMainMenuActive() || GameManager.IsEmptySceneActive()) return false;
            return true;
        }
        catch { return false; }
    }

    // 拷的是磁盘上最后一次存档,也就是按按钮之前的状态
    private static void BackupSave()
    {
        try
        {
            string name = SaveGameSystem.GetCurrentSaveName();
            if (string.IsNullOrEmpty(name)) return;
            string root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Hinterland", "TheLongDark");
            string src = Path.Combine(root, "Survival", name);
            if (!File.Exists(src)) { ModMain.Log?.Msg($"[Tales] no save file to back up: {src}"); return; }
            string dir = Path.Combine(root, $"Survival.backup-tales-{DateTime.Now:yyyyMMdd-HHmmss}");
            Directory.CreateDirectory(dir);
            File.Copy(src, Path.Combine(dir, name), true);
            ModMain.Log?.Msg($"[Tales] backed up {src} -> {dir}");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] backup failed: {ex.Message}"); }
    }

    private static FSMOwner Owner(string missionId)
    {
        try { return GameManager.GetMissionServicesManager()?.GetMissionManager(missionId)?.m_FSMOwner; }
        catch { return null; }
    }

    private static Il2CppNodeCanvas.Framework.Variable FindVar(FSMOwner owner, string name)
    {
        Il2CppNodeCanvas.Framework.Variable v = null;
        try { v = owner?.blackboard?.GetVariable(name, null); } catch { }
        if (v != null) return v;
        try { v = GameManager.GetMissionServicesManager()?.m_GlobalBlackboard?.GetVariable(name, null); } catch { }
        return v;
    }

    // 任务变量第一次被设置时才建出来,找不到就是这一步还没做过。读失败才返回 null
    private static bool? GetBool(FSMOwner owner, string name)
    {
        var v = FindVar(owner, name);
        if (v == null) return false;
        try { var o = v.value; return o != null && o.Unbox<bool>(); } catch { return null; }
    }

    private static bool InGlobal(FSMOwner owner, string name)
    {
        try { if (owner?.blackboard?.GetVariable(name, null) != null) return false; } catch { }
        try { return GameManager.GetMissionServicesManager()?.m_GlobalBlackboard?.GetVariable(name, null) != null; } catch { return false; }
    }

    // 还没有的变量建在和 sibling 同一块黑板上,游戏脚本读的就是那块
    private static bool SetBool(FSMOwner owner, string name, bool val, string sibling)
    {
        var v = FindVar(owner, name);
        if (v == null)
        {
            try
            {
                if (InGlobal(owner, sibling)) GameManager.GetMissionServicesManager().m_GlobalBlackboard.AddVariable(name, Box(val));
                else owner.blackboard.AddVariable(name, Box(val));
                return FindVar(owner, name) != null;
            }
            catch (Exception ex) { ModMain.Log?.Msg($"[Tales] add var {name}: {ex.Message}"); return false; }
        }
        try
        {
            var typed = v.TryCast<Il2CppNodeCanvas.Framework.Variable<bool>>();
            if (typed != null) { typed.value = val; return true; }
            v.value = Box(val);
            return true;
        }
        catch { return false; }
    }

    private static unsafe Il2CppSystem.Object Box(bool val)
    {
        var p = Il2CppInterop.Runtime.IL2CPP.il2cpp_value_box(Il2CppInterop.Runtime.Il2CppClassPointerStore<bool>.NativeClassPtr, (IntPtr)(&val));
        return new Il2CppSystem.Object(p);
    }

    private static string StateName(FSMOwner owner)
    {
        try { return owner.currentRootStateName; } catch { return null; }
    }

    private enum Phase { Setup, Items, Steps }

    private static bool _active;
    private static int _tale, _step, _delay, _waited;
    private static float _busySince;
    private static Phase _phase;
    private static int _jumped, _skipped, _missing, _given;

    private static void Start()
    {
        _jumped = _skipped = _missing = _given = 0;
        FixWorld();
        _tale = 0; _step = 0; _delay = 0; _waited = 0; _busySince = 0f;
        _phase = Phase.Setup;
        _active = true;
        CheatState.LastActionLog = I18n.T("正在完成 DLC 任务,大约一分钟,期间别读档、别回主菜单", "Finishing DLC tales. This takes about one minute. Do not load a save or go to the main menu");
        ModMain.Log?.Msg("[Tales] start");
    }

    public static void Tick()
    {
        if (!_active) return;
        if (_delay > 0) { _delay--; return; }
        try { Step(); }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[Tales] {ex}");
            Finish();
        }
    }

    private static void Step()
    {
        // 切图、传送加载时先停着,地图加载完接着跑;回主菜单才算结束
        if (!InGame())
        {
            bool menu = false;
            try { menu = GameManager.IsMainMenuActive(); } catch { }
            if (menu) { ModMain.Log?.Msg("[Tales] back to the main menu, stopped"); Finish(); }
            return;
        }
        if (_tale >= Tales.Length) { Finish(); return; }
        var t = Tales[_tale];
        var owner = Owner(t.Id);
        if (owner == null) { ModMain.Log?.Msg($"[Tales] {t.Id} not found, skipped"); NextTale(); return; }

        string st = StateName(owner);
        if (_phase == Phase.Setup)
        {
            if (_waited == 0) ZeroWaits(owner, t.Id);
            bool? begun = GetBool(owner, t.SetupVar);
            if (begun == false)
            {
                if (st != "Start" && _waited++ < StateWaitFrames) return;
                owner.TriggerState(t.Setup);
                ModMain.Log?.Msg($"[Tales] {t.Id}: {t.Setup} (was {st})");
                _jumped++;
            }
            else if (begun == null) _missing++;
            _phase = Phase.Items; _waited = 0; _delay = FramesPerStep;
            return;
        }
        if (_phase == Phase.Items)
        {
            var inv = GameManager.GetInventoryComponent();
            // 读过的笔记会从背包挪进日志,数背包数不准,任务做完就不再发
            bool finished = GetBool(owner, t.Steps[t.Steps.Length - 1]) == true;
            foreach (var item in finished ? Array.Empty<string>() : t.Items)
            {
                if (inv != null && inv.GetNumGearWithName(item) > 0) continue;
                Cheats.SpawnItem(item, 1);
                _given++;
            }
            foreach (var v in t.PreSetVars)
                if (!SetBool(owner, v, true, t.SetupVar)) { _missing++; ModMain.Log?.Msg($"[Tales] {t.Id}: var {v} not found"); }
            _phase = Phase.Steps; _step = 0; _delay = FramesPerStep;
            return;
        }

        // 步骤里的动作按顺序执行,有的中间带 Wait(开避难所门等 3.5 秒,开密室门等 45 秒)。
        //   提前跳走后面的动作就丢了,而那一步已经标成做过,不会再来,所以必须等它退回等待状态
        if (st != t.Wait)
        {
            if (_busySince <= 0f) _busySince = Time.realtimeSinceStartup;
            if (Time.realtimeSinceStartup - _busySince < StepTimeoutSeconds) return;
            ModMain.Log?.Msg($"[Tales] {t.Id}: still in {st} after {StepTimeoutSeconds}s, going on");
        }
        _busySince = 0f;
        if (_step >= t.Steps.Length) { NextTale(); return; }
        string name = t.Steps[_step], flag = t.Steps[_step + 1];
        _step += 2;
        bool? done = GetBool(owner, flag);
        if (done == false)
        {
            if (owner.TriggerState(name) == null) { _missing++; ModMain.Log?.Msg($"[Tales] {t.Id}: state {name} not found"); }
            else { _jumped++; ModMain.Log?.Msg($"[Tales] {t.Id}: {name}"); }
            _delay = FramesPerStep;
        }
        else if (done == null) { _missing++; ModMain.Log?.Msg($"[Tales] {t.Id}: var {flag} unreadable, {name} skipped"); }
        else _skipped++;
    }

    // 改的是内存里这份任务脚本的等待时间,不进存档。正在等的那一步下一帧就走完
    private static void ZeroWaits(FSMOwner owner, string id)
    {
        int n = 0;
        try
        {
            var nodes = owner.graph?.allNodes;
            if (nodes == null) return;
            for (int i = 0; i < nodes.Count; i++)
            {
                var acts = nodes[i]?.TryCast<ActionState>()?.actionList?.actions;
                if (acts == null) continue;
                for (int j = 0; j < acts.Count; j++)
                {
                    var w = acts[j]?.TryCast<Il2CppNodeCanvas.Tasks.Actions.Wait>();
                    if (w?.waitTime == null || w.waitTime._value <= 0f) continue;
                    w.waitTime._value = 0f;
                    n++;
                }
            }
        }
        catch (Exception ex) { ModMain.Log?.Msg($"[Tales] {id}: zero waits: {ex.Message}"); }
        if (n > 0) ModMain.Log?.Msg($"[Tales] {id}: waits set to 0: {n}");
    }

    private static void NextTale()
    {
        _tale++; _step = 0; _waited = 0;
        _phase = Phase.Setup;
        _delay = FramesPerStep;
    }

    private static void Finish()
    {
        _active = false;
        Dump();
        ModMain.Log?.Msg($"[Tales] done jumped={_jumped} alreadyDone={_skipped} missingVars={_missing} itemsGiven={_given}");
        CheatState.LastActionLog = _missing > 0
            ? I18n.T($"DLC 任务处理完了,有 {_missing} 处没执行成功,详情看日志 [Tales]", $"DLC tales done, {_missing} steps failed, see [Tales] in the log")
            : I18n.T($"DLC 任务已完成:执行 {_jumped} 步,发了 {_given} 件任务道具。睡一觉或换个地图让游戏存档",
                     $"DLC tales finished: {_jumped} steps, {_given} tale items. Sleep or change map so the game saves");
    }

    // 三个任务路线上固定摆放的装备(场景里地上摆的,加上箱子里脚本指定的那几件),
    //   箱子按掉落表随机刷的不算。笔记、钥匙、修塔材料不在这里,完成任务时已经发了
    private static readonly (string Name, int Count)[] TaleRewards =
    {
        // Tale 1:任务开头的短波;Alpha 地堡;Gamma 地堡抽屉;Omega 地堡
        ("GEAR_HandheldShortwave", 1), ("GEAR_Flashlight", 2), ("GEAR_BedRoll", 1), ("GEAR_RifleAmmoSingle", 6),
        ("GEAR_QualityWinterCoat", 1), ("GEAR_HatGatorBalaclavaA", 1), ("GEAR_EmergencyStim", 3), ("GEAR_BookCooking", 1),
        // Tale 2:选矿厂;矿洞
        ("GEAR_Respirator", 1), ("GEAR_Canister", 6), ("GEAR_BoltCutters", 1), ("GEAR_Flashlight_LongLasting", 2), ("GEAR_WoodworkingTools", 1),
        ("GEAR_MinersPants", 1), ("GEAR_CashBundle", 2), ("GEAR_GoldNugget", 1), ("GEAR_RevolverAmmoBox", 1), ("GEAR_RifleAmmoBox", 1),
        // Tale 3:Omega 地堡隐藏房间;工头避难所
        ("GEAR_TacticalJacket", 1), ("GEAR_SecurityChiefID", 1), ("GEAR_Rudiger_Watch", 1),
        ("GEAR_FilmBoxSepia", 1), ("GEAR_FilmBoxColour", 1), ("GEAR_FilmBoxBW", 1),
        // 以下不是任务里固定能拿到的,按任务主题配的额外奖励:战术套装、矿工套装、工头腰带、拍胶卷用的相机
        ("GEAR_TacticalGloves", 1), ("GEAR_BedRoll_Down", 1),
        ("GEAR_MinersHelmet", 1), ("GEAR_MinersJacket", 1), ("GEAR_MinersBoots", 1), ("GEAR_KeroseneLamp_Spelunkers", 1),
        ("GEAR_ToolBelt", 1), ("GEAR_Camera", 1), ("GEAR_InsulatedFlask_G", 1),
    };

    public static void GiveRewards()
    {
        try
        {
            if (!InGame()) return;
            if (GameManager.IsStoryMode())
            {
                CheatState.LastActionLog = I18n.T("剧情模式没有 DLC 任务", "Story mode has no DLC tales");
                return;
            }
            var inv = GameManager.GetInventoryComponent();
            int given = 0, had = 0;
            // 背包里已经够数的不再补,多按几次也不会越发越多
            foreach (var (item, count) in TaleRewards)
            {
                int have = inv != null ? inv.GetNumGearWithName(item) : 0;
                if (have >= count) { had++; continue; }
                Cheats.SpawnItem(item, count - have);
                given += count - have;
            }
            ModMain.Log?.Msg($"[Tales] rewards given={given} alreadyHad={had}");
            CheatState.LastActionLog = I18n.T($"已发 {given} 件任务奖励,背包里已经有的 {had} 种没再发",
                $"Gave {given} tale rewards. {had} kinds already in the backpack were skipped");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] rewards: {ex}"); }
    }

    // 只读,把三个任务、塔、隐藏地堡的状态写进日志,方便核对。完成任务结束时自动调一次
    public static void Dump()
    {
        try
        {
            if (!InGame()) return;
            foreach (var t in Tales)
            {
                var owner = Owner(t.Id);
                if (owner == null) { ModMain.Log?.Msg($"[Tales] {t.Id}: none"); continue; }
                var sb = new System.Text.StringBuilder();
                sb.Append($"[Tales] {t.Id}: state={StateName(owner)} bb={(InGlobal(owner, t.SetupVar) ? "global" : "owner")} {t.SetupVar}={GetBool(owner, t.SetupVar)}");
                foreach (var v in t.PreSetVars) sb.Append($" {v}={GetBool(owner, v)}");
                for (int i = 1; i < t.Steps.Length; i += 2) sb.Append($" {t.Steps[i]}={GetBool(owner, t.Steps[i])}");
                ModMain.Log?.Msg(sb.ToString());
            }
            DumpWorld();
            CheatState.LastActionLog = I18n.T("任务状态已写进日志 [Tales]", "Tale state written to the log, see [Tales]");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] Dump: {ex}"); }
    }

    private static List<TransmitterData> AllTransmitters(TransmitterManager tm)
    {
        var res = new List<TransmitterData>();
        try
        {
            var list = tm.GetAllTransmitters()?.TryCast<Il2CppSystem.Collections.Generic.List<TransmitterData>>();
            if (list != null) for (int i = 0; i < list.Count; i++) if (list[i] != null) res.Add(list[i]);
        }
        catch (Exception ex) { ModMain.Log?.Msg($"[Tales] GetAllTransmitters: {ex.Message}"); }
        return res;
    }

    // 塔和隐藏地堡的状态在全局存档里,不进场景也能改
    private static void FixWorld()
    {
        int towers = 0, caches = 0;
        try
        {
            var tm = TransmitterManager.Instance;
            if (tm != null)
                foreach (var d in AllTransmitters(tm))
                {
                    var rs = tm.GetTransmitterState(d);
                    if (rs == null) { ModMain.Log?.Msg($"[Tales] no state for {d.name}"); continue; }
                    rs.m_IsFixed = true; rs.m_IsOpen = true; rs.m_IsDiscovered = true;
                    var parts = rs.m_RepairableItems;
                    if (parts != null) for (int i = 0; i < parts.Count; i++) if (parts[i] != null) parts[i].m_IsRepaired = true;
                    towers++;
                }
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] towers: {ex.Message}"); }
        try
        {
            var tim = TrackableItemsManager.Instance;
            var items = tim?.m_ActiveItems;
            if (items != null)
                for (int i = 0; i < items.Count; i++)
                {
                    var d = items[i];
                    if (d == null) continue;
                    string guid = d.Guid;
                    var sd = tim.GetTrackableItemSavedData(guid);
                    if (sd == null) { sd = new TrackableItemSaveData(); tim.m_SaveData[guid] = sd; }
                    sd.m_IsUncovered = true;
                    caches++;
                }
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] caches: {ex.Message}"); }
        ModMain.Log?.Msg($"[Tales] world: towers={towers} hiddenCaches={caches}");
        SceneFix();
    }

    private static int _sceneFixFrames;

    // 场景初始化时存档还没应用完,等几秒再看
    public static void OnSceneInitialized(string sceneName)
    {
        if (string.IsNullOrEmpty(sceneName) || sceneName.Contains("MainMenu") || sceneName.Contains("Empty")) { _sceneFixFrames = 0; return; }
        _sceneFixFrames = 300;
    }

    public static void TickSceneFix()
    {
        if (_sceneFixFrames <= 0) return;
        if (--_sceneFixFrames > 0) return;
        try { if (InGame() && !GameManager.IsStoryMode() && Owner("sideTale1") != null) SceneFix(); }
        catch (Exception ex) { ModMain.Log?.Error($"[Tales] SceneFix: {ex.Message}"); }
    }

    // 全局存档说修好了、找到了、门开了,当前场景里的东西却没跟上,就补上。
    //   只处理两边对不上的情况,没用过这个功能的存档两边本来就一致,什么都不会做
    private static void SceneFix()
    {
        int towers = 0, caches = 0, locks = 0;
        var tm = TransmitterManager.Instance;
        if (tm != null)
            foreach (var tr in UnityEngine.Object.FindObjectsOfType<Transmitter>())
            {
                try
                {
                    var rs = tr.m_TransmitterData != null ? tm.GetTransmitterState(tr.m_TransmitterData) : null;
                    if (rs == null || !rs.m_IsFixed) continue;
                    bool changed = false;
                    var parts = tr.m_ChildrenRepairables;
                    if (parts != null)
                        for (int i = 0; i < parts.Count; i++)
                        {
                            var p = parts[i];
                            if (p == null || p.IsRepaired) continue;
                            var save = new RepairableItemSaveState();
                            save.m_Guid = ObjectGuid.MaybeGetGuidFromGameObject(p.gameObject);
                            save.m_IsRepaired = true;
                            p.Deserialize(save);
                            if (!p.IsRepaired) p.IsRepaired = true;
                            changed = true;
                        }
                    if (changed || !tr.IsFixed) tr.UpdateRuntimeState();
                    if (rs.m_IsOpen && !tr.IsOpen)
                    {
                        try { tr.m_SwitchHandle?.Open(true); } catch { }
                        if (!tr.IsOpen) tr.OnOpenSwitch();
                        changed = true;
                    }
                    if (changed) towers++;
                }
                catch (Exception ex) { ModMain.Log?.Msg($"[Tales] tower in scene: {ex.Message}"); }
            }

        var tim = TrackableItemsManager.Instance;
        if (tim != null)
            foreach (var ti in UnityEngine.Object.FindObjectsOfType<TrackableItem>())
            {
                try
                {
                    var sd = ti.m_SceneObject != null ? tim.GetTrackableItemSavedData(ti.m_SceneObject.Guid) : null;
                    if (sd == null || !sd.m_IsUncovered) continue;
                    var root = ti.m_UncoveredObjectRoot;
                    if (root != null && root.activeSelf) continue;
                    ti.SetItemUncovered(true);
                    ti.RevealOnMap();
                    caches++;
                }
                catch (Exception ex) { ModMain.Log?.Msg($"[Tales] cache in scene: {ex.Message}"); }
            }

        // Tale 2 矿洞里的门只在矿洞场景加载着的时候才能被脚本解锁
        var owner2 = Owner("sideTale2");
        if (owner2 != null)
        {
            if (GetBool(owner2, "auroraOn") == true)
                locks += Unlock("controlRoomDoorLock1") + Unlock("controlRoomDoorLock2") + Unlock("chamberDoorLock1") + Unlock("chamberDoorLock2");
            if (GetBool(owner2, "machineRoomComplete") == true)
                locks += Unlock("mine_ShortCutDoor");
        }
        if (towers + caches + locks > 0) ModMain.Log?.Msg($"[Tales] scene fix: towers={towers} caches={caches} locks={locks}");
    }

    private static int Unlock(string missionObject)
    {
        try
        {
            var moi = GameManager.GetMissionServicesManager()?.FindMissionObject(missionObject);
            if (moi == null) return 0;
            var lk = moi.GetComponent<Lock>() ?? moi.GetComponentInChildren<Lock>(true);
            if (lk == null || !lk.IsLocked()) return 0;
            lk.SetLockState(LockState.Unlocked);
            return 1;
        }
        catch { return 0; }
    }

    private static readonly string[] SceneObjects =
    {
        "talesXLBunkerActive", "bunkerXLLogbookCollision", "tale02CrashCacheActive", "GeologistCache", "Tale02_CacheBurial",
        "foremanRefugeDoor_Unlocked", "trueRudigerSnowMound", "Tale03_SnowClear_Prefab", "activeWeatherStationCache", "hiddenDoorActivate",
    };

    private static void DumpWorld()
    {
        var tm = TransmitterManager.Instance;
        if (tm != null)
            foreach (var d in AllTransmitters(tm))
            {
                var rs = tm.GetTransmitterState(d);
                int parts = rs?.m_RepairableItems?.Count ?? -1;
                ModMain.Log?.Msg($"[Tales] tower {d.name}: fixed={rs?.m_IsFixed} open={rs?.m_IsOpen} discovered={rs?.m_IsDiscovered} parts={parts}");
            }
        var tim = TrackableItemsManager.Instance;
        var items = tim?.m_ActiveItems;
        if (items != null)
            for (int i = 0; i < items.Count; i++)
            {
                var d = items[i];
                if (d == null) continue;
                ModMain.Log?.Msg($"[Tales] cache {d.name}: uncovered={tim.GetTrackableItemSavedData(d.Guid)?.m_IsUncovered}");
            }
        var msm = GameManager.GetMissionServicesManager();
        if (msm != null)
        {
            var sb = new System.Text.StringBuilder("[Tales] managed objects:");
            foreach (var n in SceneObjects)
            {
                bool has = false;
                try { has = msm.HasCustomManagedObject(n); } catch { }
                sb.Append($" {n}={has}");
            }
            ModMain.Log?.Msg(sb.ToString());
        }
    }
}
#endif
