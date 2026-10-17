#if !STORY_EDITION
using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// v9.7 一键清图:当前已加载场景里所有散落物品 + 所有能开的容器里的东西,全部收进背包。
//   室内是单独场景,只有走进去才加载,所以在室外按只清室外(车、箱子这些也算)。
//   尸体、保险箱、上锁容器都收。不收拿到过手的东西(m_BeenInPlayerInventory,保护基地里丢的和箱子里存的)。不管超重。
//   任务物品单独一个按钮(missionOnly):普通清图不碰任务物品和任务容器。
//   任务进度靠原版拾取 / 进背包的通知推进,所以散落的走 ProcessPickupItemInteraction;
//   容器收完一律标已搜刮,不然原版打开时会再生成一份;任务容器靠东西进背包的通知推进,不靠打开事件。
//   分帧收,第一次点只提示,4 秒内再点同一个按钮才开始;收的过程中再点一次就停。
internal static class MapClear
{
    private const int ItemsPerFrame = 25;
    private const int ContainersPerFrame = 3;
    private const float ArmSeconds = 4f;

    private static readonly List<GearItem> _items = new List<GearItem>();
    private static readonly List<Container> _containers = new List<Container>();
    private static int _itemIdx, _contIdx;
    private static bool _active;
    private static float _armedUntil;
    private static bool _armedMission, _missionOnly;
    private static string _scene;
    private static int _grabbed, _fromContainers, _failed, _contSearched, _contSkipped, _contLogged;

    internal static bool IsArmed(bool missionOnly) => _armedMission == missionOnly && Time.realtimeSinceStartup <= _armedUntil;

    public static void Trigger(bool missionOnly)
    {
        try
        {
            if (_active) { Finish(I18n.T("一键清图已停止", "Map clear stopped")); return; }

            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null || GameManager.GetPlayerTransform() == null) return;
            try { if (GameManager.IsMainMenuActive() || GameManager.IsEmptySceneActive()) return; } catch { }
            try { if (pm.IsInspectModeActive()) return; } catch { }

#if STORY_GUARD
            // 剧情里收走任务物品会卡死剧情
            if (missionOnly && StoryGuard.InStory)
            {
                CheatState.LastActionLog = I18n.T("剧情模式下不能清任务物品", "Clear Mission Items is off in story mode");
                return;
            }
#endif
            float now = Time.realtimeSinceStartup;
            if (now > _armedUntil || _armedMission != missionOnly)
            {
                _armedUntil = now + ArmSeconds;
                _armedMission = missionOnly;
                CheatState.LastActionLog = missionOnly
                    ? I18n.T("再点一次「清任务物品」确认。慎用,可能卡住任务!", "Click Clear Mission Items again to confirm. Use with care, a mission can stop!")
                    : I18n.T("再点一次「一键清图」确认:当前地图所有物品和容器都会收进背包", "Click Clear Map again to confirm. All items and containers on this map go to your backpack.");
                return;
            }
            _armedUntil = 0f;
            _missionOnly = missionOnly;

            _items.Clear(); _containers.Clear();
            _itemIdx = _contIdx = 0;
            _grabbed = _fromContainers = _failed = _contSearched = _contSkipped = _contLogged = 0;
            try { _scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name; } catch { _scene = null; }

            CollectLoose();
            CollectContainers();
            _active = true;
            CheatState.LastActionLog = I18n.T($"正在清图:{_items.Count} 件散落物品,{_containers.Count} 个容器",
                $"Clearing map: {_items.Count} loose items, {_containers.Count} containers");
            ModMain.Log?.Msg($"[MapClear] start scene={_scene} loose={_items.Count} containers={_containers.Count} skippedContainers={_contSkipped}");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[MapClear] {ex.Message}");
            CheatState.LastActionLog = I18n.T("一键清图失败(见日志)", "Map clear failed (see log)");
        }
    }

    private static bool IsMission(GearItem gi) => gi.m_MissionObject != null;

    private static bool IsMission(Container c) => c.m_MissionObject != null || !string.IsNullOrEmpty(c.m_MissionSupplyObjectiveId);

    // 普通模式只收非任务物品;任务模式收任务物品,任务容器里的东西全收
    private static bool SkipItem(GearItem gi, bool missionContainer = false)
    {
        if (gi.m_InPlayerInventory || gi.m_BeenInPlayerInventory || gi.m_HasBeenOwnedByPlayer) return true;
        return _missionOnly ? !(missionContainer || IsMission(gi)) : IsMission(gi);
    }

    private static void CollectLoose()
    {
        var all = UnityEngine.Object.FindObjectsOfType<GearItem>();
        if (all == null) return;
        for (int i = 0; i < all.Count; i++)
        {
            var gi = all[i];
            if (gi == null) continue;
            try
            {
                var go = gi.gameObject;
                // 没激活的是容器里的东西,走容器那条路
                if (go == null || !go.activeInHierarchy) continue;
                if (gi.m_BodyHarvest != null || gi.m_BodyHarvestItem != null) continue;
                if (SkipItem(gi) || GrabAll.IsTravois(go)) continue;
                _items.Add(gi);
            }
            catch { }
        }
    }

    private static void CollectContainers()
    {
        var seen = new HashSet<IntPtr>();
        AddContainers(ContainerManager.m_Containers, seen);
        AddContainers(ContainerManager.m_CorpseContainers, seen);
    }

    private static void AddContainers(Il2CppSystem.Collections.Generic.List<Container> list, HashSet<IntPtr> seen)
    {
        if (list == null) return;
        for (int i = 0; i < list.Count; i++)
        {
            var c = list[i];
            if (c == null || !seen.Add(c.Pointer)) continue;
            try
            {
                if (c.m_DestoryPending || c.CanNeverBeOpened() || (!_missionOnly && IsMission(c))) { _contSkipped++; continue; }
                _containers.Add(c);
            }
            catch { _contSkipped++; }
        }
    }

    internal static void Tick()
    {
        if (!_active) return;
        try
        {
            string scene = null;
            try { scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name; } catch { }
            if (scene != _scene) { Finish(I18n.T("换了场景,一键清图已停止", "Scene changed. Map clear stopped")); return; }

            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { Finish(null); return; }

            GrabAll.PushGate();
            try
            {
                for (int n = 0; n < ItemsPerFrame && _itemIdx < _items.Count; n++, _itemIdx++)
                {
                    var gi = _items[_itemIdx];
                    try
                    {
                        if (gi == null || gi.m_InPlayerInventory) continue;
                        if (pm.ProcessPickupItemInteraction(gi, false, false, true)) _grabbed++; else _failed++;
                    }
                    catch { _failed++; }
                }

                if (_itemIdx >= _items.Count)
                    for (int n = 0; n < ContainersPerFrame && _contIdx < _containers.Count; n++, _contIdx++)
                        LootContainer(pm, _containers[_contIdx]);
            }
            finally { GrabAll.PopGate(); }

            if (_itemIdx >= _items.Count && _contIdx >= _containers.Count) Finish(null);
        }
        catch (Exception ex) { ModMain.Log?.Error($"[MapClear] tick {ex.Message}"); Finish(null); }
    }

    // ponytail: 容器方法只有签名、看不到方法体。PopulateContents 只把抽到的东西放进 m_GearToInstantiate,
    //   原版打开容器时才 InstantiateContents 真正生成物品,所以这里自己补一次,生成出来再逐件 RemoveGear(toInventory) 进背包。
    //   生成过就标已搜刮(不然原版打开时再生成一份);没搬走的还在箱子里,玩家之后打开还能自己拿。
    //   如果实测还有残留或复制,改成打开 Panel_Container 调 OnMoveAllToInventory。
    private static void LootContainer(PlayerManager pm, Container c)
    {
        if (c == null) return;
        try
        {
            bool missionContainer = IsMission(c);
            int pending = -1, pendingAfter = -1;
            if (!c.IsInspected()) c.PopulateContents();
            try
            {
                pending = c.m_GearToInstantiate?.Count ?? -1;
                if (pending > 0) c.InstantiateContents();
                pendingAfter = c.m_GearToInstantiate?.Count ?? -1;
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[MapClear] instantiate {ex.Message}"); }

            var tmp = new Il2CppSystem.Collections.Generic.List<GearItem>();
            c.GetItems(tmp);
            int found = tmp.Count, moved = 0, left = 0;
            for (int i = 0; i < tmp.Count; i++)
            {
                var gi = tmp[i];
                if (gi == null) continue;
                if (SkipItem(gi, missionContainer)) continue;
                try
                {
                    c.RemoveGear(gi, true);
                    if (!gi.m_InPlayerInventory) pm.AddItemToPlayerInventory(gi, true, false);
                }
                catch { _failed++; }
            }
            // 能叠加的东西进背包后会并进已有那一堆,原物体不算在背包里,所以按容器里还剩几件来算
            tmp.Clear();
            c.GetItems(tmp);
            int skipped = 0;
            for (int i = 0; i < tmp.Count; i++)
            {
                var gi = tmp[i];
                if (gi == null) continue;
                if (SkipItem(gi, missionContainer)) skipped++; else left++;
            }
            moved = Math.Max(0, found - skipped - left);
            _fromContainers += moved;
            // 内容已经生成在箱子里了,不标已搜刮的话原版打开时还会再生成一份;剩下的东西还在箱子里,玩家照样能拿
            c.MarkAsInspected();
            _contSearched++;
            if (_contLogged++ < 40)
                ModMain.Log?.Msg($"[MapClear] container {c.gameObject?.name} pending={pending}->{pendingAfter} found={found} moved={moved} left={left} mine={skipped}");
        }
        catch (Exception ex) { _failed++; ModMain.Log?.Warning($"[MapClear] container {ex.Message}"); }
    }

    private static void Finish(string reason)
    {
        _active = false;
        _items.Clear(); _containers.Clear();
        string summary = _missionOnly
            ? (I18n.IsEnglish ? $"Mission items: {_grabbed} loose, {_fromContainers} from containers"
                              : $"任务物品:散落 {_grabbed} 件,容器里 {_fromContainers} 件")
            : (I18n.IsEnglish ? $"Map clear: {_grabbed} loose items, {_fromContainers} items from {_contSearched} containers"
                              : $"清图完成:散落物品 {_grabbed} 件,{_contSearched} 个容器里 {_fromContainers} 件");
        CheatState.LastActionLog = reason == null ? summary : reason + (I18n.IsEnglish ? ". " : "。") + summary;
        ModMain.Log?.Msg($"[MapClear] done grabbed={_grabbed} fromContainers={_fromContainers} searched={_contSearched} skipped={_contSkipped} failed={_failed} mission={_missionOnly} reason={reason}");
    }
}
#endif
