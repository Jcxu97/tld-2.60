#if !STORY_EDITION && !EP5_EDITION
using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// 一键采集全图动物尸体 / 植物,范围和一键清图一样是当前已加载的场景,分帧做。
//   尸体借剥皮面板的 TransferMeat/Hide/GutFromCarcassToInventory:它们读面板的 m_BodyHarvest 和三个菜单项的数量,
//   所以每具尸体先把这几个值设成全部可取的量再调,重量、状态、冻结都按原版算。任务尸体和背包里的兔子不碰。
//   植物直接调 Harvestable.Harvest(),和手动采集同一条路。
internal static class MapHarvest
{
    private const int CarcassesPerFrame = 2;
    private const int PlantsPerFrame = 10;

    private static readonly List<BodyHarvest> _bodies = new List<BodyHarvest>();
    private static readonly List<Harvestable> _plants = new List<Harvestable>();
    private static int _idx, _done, _failed, _items;
    private static float _meatKg;
    private static bool _active, _isPlants, _errLogged, _inPlant;
    private static string _scene;

    internal static bool Active => _active;

    public static void Trigger(bool plants)
    {
        try
        {
            if (_active) { Finish(I18n.T("采集已停止", "Harvest stopped")); return; }
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null || GameManager.GetPlayerTransform() == null) return;
            try { if (GameManager.IsMainMenuActive() || GameManager.IsEmptySceneActive()) return; } catch { }
            try { if (pm.IsInspectModeActive()) return; } catch { }

            _bodies.Clear(); _plants.Clear();
            _idx = _done = _failed = _items = 0; _meatKg = 0f; _errLogged = false;
            _isPlants = plants;
            if (plants)
            {
                foreach (var h in UnityEngine.Object.FindObjectsOfType<Harvestable>())
                    try { if (h != null && !h.IsHarvested()) _plants.Add(h); } catch { }
            }
            else
            {
                foreach (var bh in UnityEngine.Object.FindObjectsOfType<BodyHarvest>())
                    try { if (Wanted(bh)) _bodies.Add(bh); } catch { }
            }
            try { _scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name; } catch { _scene = null; }
            int n = plants ? _plants.Count : _bodies.Count;
            if (n == 0)
            {
                CheatState.LastActionLog = plants ? I18n.T("这张图没有可采的植物", "No plants to harvest here")
                                                  : I18n.T("这张图没有可采的尸体", "No carcasses to harvest here");
                return;
            }
            _active = true;
            CheatState.LastActionLog = plants ? I18n.T($"开始采集 {n} 株植物", $"Harvesting {n} plants")
                                              : I18n.T($"开始采集 {n} 具尸体", $"Harvesting {n} carcasses");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[MapHarvest] trigger {ex.Message}"); _active = false; }
    }

    private static bool Wanted(BodyHarvest bh)
    {
        if (bh == null || bh.m_DestroyPending) return false;
        if (!string.IsNullOrEmpty(bh.m_MissionIdSerialized) || bh.m_BearHuntAiRedux != null) return false;
        var gi = bh.m_GearItem;
        if (gi != null && gi.m_InPlayerInventory) return false;
        // 活着的动物身上也挂着 BodyHarvest,只采已经死了的
        var ai = bh.GetComponentInParent<BaseAi>();
        if (ai != null && ai.GetAiMode() != AiMode.Dead) return false;
        return bh.m_MeatAvailableKG.ToQuantity(1f) > 0.001f || bh.m_HideAvailableUnits > 0 || bh.m_GutAvailableUnits > 0;
    }

    internal static void Tick()
    {
        if (!_active) return;
        try
        {
            string scene = null;
            try { scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name; } catch { }
            if (scene != _scene) { Finish(I18n.T("换了场景,采集已停止", "Scene changed. Harvest stopped")); return; }

            GrabAll.PushGate();
            try
            {
                if (_isPlants)
                {
                    for (int n = 0; n < PlantsPerFrame && _idx < _plants.Count; n++, _idx++)
                    {
                        var h = _plants[_idx];
                        try
                        {
                            if (h == null || h.IsHarvested()) continue;
                            _inPlant = true;
                            try { h.Harvest(); } finally { _inPlant = false; }
                            if (h == null || h.IsHarvested()) { _done++; GivePlant(h); } else _failed++;
                        }
                        catch (Exception ex) { Fail(ex); }
                    }
                }
                else
                {
                    var panel = InterfaceManager.GetPanel<Panel_BodyHarvest>();
                    if (panel == null) { Finish(I18n.T("剥皮面板没加载,采集已停止", "Harvest panel missing. Harvest stopped")); return; }
                    for (int n = 0; n < CarcassesPerFrame && _idx < _bodies.Count; n++, _idx++)
                        HarvestBody(panel, _bodies[_idx]);
                }
            }
            finally { GrabAll.PopGate(); }

            if (_idx >= (_isPlants ? _plants.Count : _bodies.Count)) Finish(null);
        }
        catch (Exception ex) { ModMain.Log?.Error($"[MapHarvest] tick {ex.Message}"); Finish(null); }
    }

    private static void HarvestBody(Panel_BodyHarvest panel, BodyHarvest bh)
    {
        if (bh == null || bh.m_DestroyPending) return;
        var prev = panel.m_BodyHarvest;
        try
        {
            panel.m_BodyHarvest = bh;
            var meat = bh.m_MeatAvailableKG;
            float kg = meat.ToQuantity(1f);
            if (kg > 0.001f && bh.m_MeatPrefab != null)
            {
                panel.m_MenuItem_Meat.HarvestAmount = meat;
                panel.TransferMeatFromCarcassToInventory();
                _meatKg += kg;
            }
            int hides = bh.m_HideAvailableUnits;
            if (hides > 0 && bh.m_HidePrefab != null)
            {
                panel.m_MenuItem_Hide.HarvestUnits = hides;
                panel.TransferHideFromCarcassToInventory();
            }
            int guts = bh.m_GutAvailableUnits;
            if (guts > 0 && bh.m_GutPrefab != null)
            {
                panel.m_MenuItem_Gut.HarvestUnits = guts;
                panel.TransferGutFromCarcassToInventory();
            }
            // 原版转移完自己会扣尸体上的余量;没扣的话手动清零,免得再点一次又给一份
            if (bh.m_MeatAvailableKG.ToQuantity(1f) >= kg - 0.001f && kg > 0.001f) bh.m_MeatAvailableKG = default;
            if (bh.m_HideAvailableUnits >= hides && hides > 0) bh.m_HideAvailableUnits = 0;
            if (bh.m_GutAvailableUnits >= guts && guts > 0) bh.m_GutAvailableUnits = 0;
            bh.MaybeRoundMeatAvailableToZero();
            _done++;
        }
        catch (Exception ex) { Fail(ex); }
        finally { try { panel.m_BodyHarvest = prev; } catch { } }
    }

    // 2.58 起 Harvest() 不直接进背包:按 m_NumPrimary 在脚边生成再进检视,第二种物品等退出检视才给。
    // 批量采时 EnterInspectMode 被下面的补丁跳过,这里按原版算好的数量直接放进背包
    private static void GivePlant(Harvestable h)
    {
        var pm = GameManager.GetPlayerManagerComponent();
        if (pm == null) return;
        if (h.m_InspectItem != null) Give(pm, h.m_InspectItem, 1);
        else Give(pm, h.m_GearPrefab, h.m_NumPrimary);
        if (h.m_SecondGearPrefab != null && h.m_NumSecondary > 0 && !h.m_HasInspectedSecondary)
        {
            Give(pm, h.m_SecondGearPrefab, h.m_NumSecondary);
            h.m_HasInspectedSecondary = true;
        }
    }

    private static void Give(PlayerManager pm, GearItem prefab, int count)
    {
        if (prefab == null) return;
        for (int i = 0; i < count; i++)
            try { if (pm.InstantiateItemInPlayerInventory(prefab, 1, 100f, PlayerManager.InventoryInstantiateFlags.None) != null) _items++; }
            catch (Exception ex) { Fail(ex); return; }
    }

    [HarmonyLib.HarmonyPatch(typeof(Harvestable), "EnterInspectMode")]
    internal static class Patch_SkipInspect
    {
        static bool Prefix() => !_inPlant;
    }

    private static void Fail(Exception ex)
    {
        _failed++;
        if (_errLogged) return;
        _errLogged = true;
        ModMain.Log?.Warning($"[MapHarvest] {(_isPlants ? "plant" : "carcass")} {ex.GetType().Name} {ex.Message}");
    }

    private static void Finish(string reason)
    {
        _active = false;
        string summary = _isPlants
            ? I18n.T($"采集植物完成:{_done} 株,进背包 {_items} 件", $"Plants harvested: {_done}, {_items} items added")
            : I18n.T($"采集尸体完成:{_done} 具,肉约 {_meatKg:F1} 公斤", $"Carcasses harvested: {_done}, about {_meatKg:F1} kg of meat");
        if (_failed > 0) summary += I18n.T($",失败 {_failed}", $", {_failed} failed");
        CheatState.LastActionLog = reason == null ? summary : reason + (I18n.IsEnglish ? ". " : "。") + summary;
        ModMain.Log?.Msg($"[MapHarvest] done plants={_isPlants} total={(_isPlants ? _plants.Count : _bodies.Count)} done={_done} failed={_failed} items={_items} meatKg={_meatKg:F1} reason={reason}");
        _bodies.Clear(); _plants.Clear();
    }
}
#endif
