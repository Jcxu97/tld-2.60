#if !STORY_EDITION
using System;
using System.Collections;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppTLD.Gameplay;
using MelonLoader;
using UnityEngine;

namespace TldHacks;

// v9.7 整合地图管理(MapManager 1.1.7,The Illusion / zhaochun8787 / hzb1130)。行为照原 mod,只改了这几处:
//   全开地图热键默认是反引号,和控制台同一个键,开控制台地图就全开了 → 默认不绑
//   设置关着时把 shouldAllowVistaReveals 改成 false,原版捡宝丽来的远景开图也没了 → 只在开着时改成 true
//   远景点不用宝丽来:把宝丽来的预制体本身塞进背包 → 用 InstantiateItemInPlayerInventory 生成一张
//   ResetOpts 是静态的只加不减,关掉箭头或居中要重启 → 每次打开现算
//   地堡修复把所有地堡内部重新随机,读档也重换,还会重复 → 只换空的和入侵者版的,按地堡 ID 固定挑,不重复
//   地堡热键按写死的坐标开图 → 先找当前场景里真正刷出来的地堡,找不到生成点才用原坐标
internal static class MapM
{
    private static TldHacksSettings S => ModMain.Settings;

    private static int _standalone = -1;
    // 玩家只覆盖了新版、没删独立的 MapManager.dll 时,两边补丁会叠在一起,这时我们这边全部不挂
    internal static bool StandaloneLoaded
    {
        get
        {
            if (_standalone < 0)
            {
                bool found = false;
                try
                {
                    foreach (var m in MelonBase.RegisteredMelons)
                        if (m?.Info?.Name == "MapManager") { found = true; break; }
                }
                catch { }
                // 启动时别的 mod 可能还没注册完,前 600 帧没找到就下次再找
                if (found) { _standalone = 1; ModMain.Log?.Warning("[MapM] 独立的 MapManager.dll 还在 Mods 里,TldHacks 的地图管理不启用"); }
                else if (Time.frameCount > 600) _standalone = 0;
                return found;
            }
            return _standalone == 1;
        }
    }

    private static bool On => S != null && S.MapM_Enabled && !StandaloneLoaded;
    internal static bool MapOpen => On && (S.MapM_PlayerArrow || S.MapM_CenterOnPlayer || S.MapM_HideHarvested);
    internal static bool Survey => On && (S.MapM_SurveyRange != 1f || S.MapM_RevealVista);
    internal static bool SurveyTime => On && S.MapM_SurveyTime != 1f;
    internal static bool UnlockSurvey => On && S.MapM_UnlockSurvey;
    internal static bool RevealVista => On && S.MapM_RevealVista;
    internal static bool VistaNoPolaroid => On && S.MapM_VistaNoPolaroid;
    internal static bool Corpse => On && S.MapM_CorpseOnMap;
    internal static bool HideHarvested => On && S.MapM_HideHarvested;
    internal static bool FillBunkers => On && S.MapM_FillEmptyBunkers;
    internal static bool InterloperBunker => On && S.MapM_InterloperBunker;
    internal static bool Keys => On && (S.MapM_BunkerKey != KeyCode.None || S.MapM_RevealKey != KeyCode.None);

    internal static bool Loading()
    {
        try { return InterfaceManager.IsPanelEnabled<Panel_Loading>(); } catch { return true; }
    }
}

internal static class Patch_MapM_MapEnable
{
    private static void Postfix(Panel_Map __instance, bool enable)
    {
        if (!enable || __instance == null) return;
        var s = ModMain.Settings;
        try
        {
            if (s.MapM_PlayerArrow || s.MapM_CenterOnPlayer)
            {
                int opts = 1;
                if (s.MapM_PlayerArrow) opts |= 4;
                if (s.MapM_CenterOnPlayer) opts |= 2;
                // 2026-10 更新新加的开关,原版默认不显示玩家图标
                if (s.MapM_PlayerArrow) Panel_Map.s_ForceShowPlayerIcon = true;
                __instance.ResetToNormal((Panel_Map.ResetOpts)opts);
                MelonCoroutines.Start(TintNextFrame(__instance));
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] map open {ex.Message}"); }
        if (s.MapM_HideHarvested) MapMHarvest.Cleanup(__instance);
    }

    private static bool _forcedLogged;
    private static UIAtlas _arrowAtlas;

    // 2026-10 更新后玩家图标挂的图集里没有它要的图(ico_map_directional),图标开着也画不出来;
    // 换成内存里含这张图的图集(实测是 Base Atlas)
    private static void FixAtlas(UISprite sp)
    {
        if (sp == null || sp.GetAtlasSprite() != null) return;
        if (_arrowAtlas == null || _arrowAtlas.GetSprite(sp.spriteName) == null)
        {
            _arrowAtlas = null;
            foreach (var a in Resources.FindObjectsOfTypeAll<UIAtlas>())
                if (a != null && a.GetSprite(sp.spriteName) != null) { _arrowAtlas = a; break; }
            ModMain.Log?.Msg($"[MapM] 玩家图标图集缺 {sp.spriteName},改用 {(_arrowAtlas != null ? _arrowAtlas.name : "none")}");
        }
        if (_arrowAtlas == null) return;
        sp.atlas = _arrowAtlas;
        sp.MarkAsChanged();
    }

    private static IEnumerator TintNextFrame(Panel_Map map)
    {
        yield return null;
        try
        {
            var icon = map?.m_PlayerIcon;
            if (icon == null) yield break;
            var s = ModMain.Settings;
            // 2026-10 游戏更新后 ResetToNormal 有条件分支会藏掉玩家图标,图标位置留在旧坐标,居中也跟着偏。
            // 这里照原版算法(地区名 + 世界坐标换地图坐标)补一次
            if (!icon.gameObject.activeSelf)
            {
                var player = GameManager.GetPlayerTransform();
                string region = map.GetMapNameOfCurrentScene();
                if (player != null && !string.IsNullOrEmpty(region))
                {
                    icon.localPosition = map.WorldPositionToMapPosition(region, player.position);
                    icon.localRotation = map.WorldRotationToMapRotation(region, player.rotation);
                    if (s.MapM_PlayerArrow) icon.gameObject.SetActive(true);
                    if (s.MapM_CenterOnPlayer) map.CenterOnPoint(icon.localPosition);
                    if (!_forcedLogged) { _forcedLogged = true; ModMain.Log?.Msg($"[MapM] 原版藏了玩家图标,已补上 region={region} pos={icon.localPosition}"); }
                }
            }
            if (!s.MapM_PlayerArrow) yield break;
            var sp = icon.GetComponent<UISprite>();
            FixAtlas(sp);
            if (sp != null) sp.color = Color.red;
            var tx = icon.GetComponent<UITexture>();
            if (tx != null) tx.color = Color.red;
            var sr = icon.GetComponent<SpriteRenderer>();
            if (sr != null) sr.color = Color.red;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] coroutine {ex.Message}"); }
    }
}

// 原 mod 就是所有开图都乘倍率(木炭、自动绘图、宝丽来、地堡热键),玩家习惯的是这个效果,照搬
internal static class Patch_MapM_NearbyCheck
{
    private static void Prefix(Panel_Map __instance, ref float radius, ref bool shouldAllowVistaReveals)
    {
        try
        {
            if (!__instance.SceneCanBeMapped(__instance.GetMapNameOfCurrentScene()) || MapM.Loading()) return;
            radius *= ModMain.Settings.MapM_SurveyRange;
            if (ModMain.Settings.MapM_RevealVista) shouldAllowVistaReveals = true;
        }
        catch { }
    }
}

// 原 mod 在木炭 Awake 时乘一次,改了设置要换场景才对新木炭生效,照搬
internal static class Patch_MapM_SurveyMinutes
{
    private static void Postfix(CharcoalItem __instance)
    {
        try { __instance.m_SurveyGameMinutes *= ModMain.Settings.MapM_SurveyTime; } catch { }
    }
}

internal static class Patch_MapM_SurveyVisibility
{
    private static void Postfix(ref bool __result) => __result = true;
}

// 远景点没有对应的宝丽来时,原版检查照片那一刻生成一张放进背包,效果和带着照片一样(照片也会记进收藏)
internal static class Patch_MapM_VistaPolaroid
{
    internal static bool Suppress;

    private static void Postfix(VistaLocation __instance, ref bool __result)
    {
        if (__result || __instance == null) return;
        try
        {
            var gi = __instance.m_RequiredGearItem;
            var pm = GameManager.GetPlayerManagerComponent();
            if (gi == null || pm == null) return;
            Suppress = true;
            try
            {
                if (pm.InstantiateItemInPlayerInventory(gi, 1, 1f, PlayerManager.InventoryInstantiateFlags.None) != null) __result = true;
            }
            finally { Suppress = false; }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] vista polaroid {ex.Message}"); }
    }
}

// 上面生成照片时原版会弹地图跳到照片位置,原 mod 也拦了这一步;这里只拦我们自己生成的那一次,捡到真照片照常开图
internal static class Patch_MapM_PolaroidReveal
{
    private static bool Prefix() => !Patch_MapM_VistaPolaroid.Suppress;
}

internal static class Patch_MapM_CorpseOnMap
{
    private static void Postfix(BaseAi __instance)
    {
        try
        {
            var md = __instance?.gameObject?.GetComponent<MapDetail>();
            if (md != null) md.ShowOnMap(true);
        }
        catch { }
    }
}

// 尸骸标记是按位置写进地图存档的,不跟着尸骸走。搬起、采完、烂掉都要自己删,室外放下再按新位置标
internal static class MapMCorpse
{
    private static MapDetail Find(GameObject go)
    {
        if (go == null) return null;
        var md = go.GetComponent<MapDetail>();
        return md != null ? md : go.GetComponentInParent<MapDetail>();
    }

    internal static void Remove(GameObject go)
    {
        if (!MapM.Corpse || MapM.Loading()) return;
        try
        {
            var md = Find(go);
            if (md == null) return;
            var panel = InterfaceManager.GetPanel<Panel_Map>();
            if (panel != null) { panel.RemoveMapDetailFromMap(md, 0f); panel.RefreshIconVisibility(); }
            else md.ShowOnMap(false);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] corpse remove {ex.Message}"); }
    }

    internal static void Show(GameObject go)
    {
        if (!MapM.Corpse) return;
        try
        {
            var panel = InterfaceManager.GetPanel<Panel_Map>();
            if (panel == null || !panel.SceneCanBeMapped(panel.GetMapNameOfCurrentScene())) return;
            Find(go)?.ShowOnMap(true);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] corpse show {ex.Message}"); }
    }
}

internal static class Patch_MapM_CorpseDestroy
{
    private static void Prefix(BodyHarvest __instance)
    {
        if (__instance != null) MapMCorpse.Remove(((Component)__instance).gameObject);
    }
}

internal static class MapMHarvest
{
    // 照原 mod:组里每棵要么采过要么没激活,就算采完。两组(自身的、共用图标的)任一组满足即可
    internal static bool AllHarvested(MapDetail md, bool sharedToo = true)
    {
        var arr = md.m_HarvestablesForMapVisibility;
        if (arr != null && arr.Length > 0)
        {
            bool any = false, all = true;
            for (int i = 0; i < arr.Length && all; i++) Check(arr[i], ref any, ref all);
            if (any && all) return true;
        }
        var list = sharedToo ? md.m_HarvestablesSharingIcon : null;
        if (list != null && list.Count > 0)
        {
            bool any = false, all = true;
            for (int i = 0; i < list.Count && all; i++) Check(list[i], ref any, ref all);
            if (any && all) return true;
        }
        return false;
    }

    private static void Check(Harvestable h, ref bool any, ref bool all)
    {
        if (h == null) return;
        any = true;
        var go = h.gameObject;
        if (!h.m_Harvested && go != null && go.activeInHierarchy) all = false;
    }

    internal static void Remove(MapDetail md, float delayHours, bool sharedToo = true)
    {
        if (md == null || MapM.Loading() || !AllHarvested(md, sharedToo)) return;
        var panel = InterfaceManager.GetPanel<Panel_Map>();
        if (panel != null) { panel.RemoveMapDetailFromMap(md, delayHours); panel.RefreshIconVisibility(); }
        else md.ShowOnMap(false);
    }

    internal static void Cleanup(Panel_Map panel)
    {
        try
        {
            if (MapM.Loading()) return;
            var all = MapDetailManager.s_MapDetails;
            if (all == null) return;
            var hit = new List<MapDetail>();
            for (int i = 0; i < all.Count; i++)
            {
                var md = all[i];
                if (md != null && md.m_IsSurveyed && AllHarvested(md)) hit.Add(md);
            }
            foreach (var md in hit) panel.RemoveMapDetailFromMap(md, 0f);
            if (hit.Count > 0) panel.RefreshIconVisibility();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] harvest cleanup {ex.Message}"); }
    }
}

internal static class Patch_MapM_DetailSurveyed
{
    private static void Postfix(MapDetail __instance)
    {
        try { if (__instance != null && __instance.m_IsSurveyed) MapMHarvest.Remove(__instance, 0.5f); } catch { }
    }
}

internal static class Patch_MapM_DetailUnlock
{
    private static void Postfix(MapDetail __instance)
    {
        try { if (__instance != null && __instance.m_IsUnlocked) MapMHarvest.Remove(__instance, 0.5f, false); } catch { }
    }
}
// 每个地堡都换成 A~F 六种完整版里随机一种。有的难度给的内部全是空版(一两件东西),完整版(五十件起)不在清单里,
// 所以照空版复制一份、场景换成完整版(两种版本进门点名字一样)。先六种各一个再重复;按这个档原版的分配结果定种子,
// 同一个档每次读档一样,不同档不一样。存档里写回原版的名字,关掉开关或删 mod 存档照旧能读。
internal static class Patch_MapM_BunkerDistribute
{
    private const string ClonePrefix = "TldHacks_PrepperCache";
    private static readonly string[] Types = { "A", "B", "C", "D", "E", "F" };
    private static BunkerInteriorSpecification[] _full;
    private static bool _logged, _saveLogged;
    internal static readonly Dictionary<string, string> OrigById = new();

    private static bool IsClone(BunkerInteriorSpecification b) => b != null && (b.name ?? "").StartsWith(ClonePrefix);

    private static BunkerInteriorSpecification[] Full(BunkerInteriorSpecification tpl)
    {
        if (_full != null) return _full;
        var list = new List<BunkerInteriorSpecification>();
        foreach (var t in Types)
        {
            Il2CppTLD.Scenes.SceneSet ss = null;
            // 2026-10 游戏更新后地址从完整路径改成了短名字,两个都试
            foreach (var key in new[] { $"PrepperCache{t}", $"Assets/ScriptableObjects/Scenes/Sets/Interiors/PrepperCache{t}.asset" })
            {
                try
                {
                    ss = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<Il2CppTLD.Scenes.SceneSet>(
                        (Il2CppSystem.Object)key).WaitForCompletion();
                }
                catch (Exception ex) { ModMain.Log?.Warning($"[MapM] load {key}: {ex.GetType().Name} {ex.Message}"); }
                if (ss != null) break;
            }
            if (ss == null) { ModMain.Log?.Warning($"[MapM] no scene set PrepperCache{t}"); continue; }
            var c = UnityEngine.Object.Instantiate(tpl);
            c.name = ClonePrefix + t;
            c.m_Interior = ss;
            c.hideFlags = HideFlags.DontUnloadUnusedAsset;
            list.Add(c);
        }
        return _full = list.ToArray();
    }

    private static uint Fnv(string s)
    {
        uint h = 2166136261;
        foreach (char c in s ?? "") { h ^= c; h *= 16777619; }
        return h;
    }

    private static void Postfix(BunkerDistributor __instance) => Fill(__instance);

    // 换区域读档时原版新建配对,入口已在场景里就当场套上原内部;只改字段太晚,要重新挂一次让新内部生效
    private static void Set(BunkerDistributor.BunkerLocationInteriorPair p, BunkerInteriorSpecification x)
    {
        if (p.m_ReplacementInterior == x) return;
        p.m_ReplacementInterior = x;
        try { p.Detach(); p.Attach(); }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] bunker reattach {ex.Message}"); }
    }

    private static BunkerDistributor _last;

    // 关掉开关后:把地堡分配换回原版的那份,换完写存档的补丁才能卸
    internal static bool RestoreDone()
    {
        try
        {
            var reps = _last?.m_Replacements;
            var all = _last?.m_BunkerInteriors;
            if (reps == null || all == null) return true;
            int n = 0;
            bool allOk = true;
            for (int i = 0; i < reps.Count; i++)
            {
                var p = reps[i];
                if (p == null || !IsClone(p.m_ReplacementInterior)) continue;
                string id = "";
                try { id = p.m_LocationReference?.Guid ?? ""; } catch { }
                if (id.Length == 0) id = "#" + i;
                BunkerInteriorSpecification orig = null;
                if (OrigById.TryGetValue(id, out var name))
                    for (int k = 0; k < all.Length && orig == null; k++)
                        if (all[k] != null && !IsClone(all[k]) && all[k].name == name) orig = all[k];
                // 找不到原版的先跳过,别挡住后面的;返回 false 让存档补丁继续挂着改名
                if (orig == null) { allOk = false; continue; }
                Set(p, orig);
                n++;
            }
            if (n > 0) ModMain.Log?.Msg($"[MapM] {n} bunkers set back to the game's own interiors");
            return allOk;
        }
        catch { return false; }
    }

    internal static void Fill(BunkerDistributor d)
    {
        try
        {
            _last = d;
            var all = d?.m_BunkerInteriors;
            var reps = d?.m_Replacements;
            if (all == null || all.Length == 0 || reps == null || reps.Count == 0) return;
            BunkerInteriorSpecification tpl = null;
            for (int i = 0; i < all.Length && tpl == null; i++) if (all[i] != null && !IsClone(all[i])) tpl = all[i];
            if (tpl == null) return;
            var full = Full(tpl);
            if (full.Length == 0) return;

            var todo = new List<(string id, BunkerDistributor.BunkerLocationInteriorPair p)>();
            for (int i = 0; i < reps.Count; i++)
            {
                var p = reps[i];
                if (p == null) continue;
                string id = "";
                try { id = p.m_LocationReference?.Guid ?? ""; } catch { }
                if (id.Length == 0) id = "#" + i;
                var cur = p.m_ReplacementInterior;
                if (cur != null && !IsClone(cur)) OrigById[id] = cur.name;
                todo.Add((id, p));
            }
            todo.Sort((x, y) => string.CompareOrdinal(x.id, y.id));
            var seed = new System.Text.StringBuilder();
            foreach (var t in todo) seed.Append(t.id).Append(':').Append(OrigById.TryGetValue(t.id, out var o) ? o : "").Append(';');
            var rng = new System.Random((int)Fnv(seed.ToString()));

            var bag = new List<BunkerInteriorSpecification>();
            var picks = new List<string>();
            foreach (var t in todo)
            {
                if (bag.Count == 0)
                {
                    bag.AddRange(full);
                    for (int i = bag.Count - 1; i > 0; i--) { int j = rng.Next(i + 1); (bag[i], bag[j]) = (bag[j], bag[i]); }
                }
                var x = bag[bag.Count - 1];
                bag.RemoveAt(bag.Count - 1);
                Set(t.p, x);
                picks.Add(x.name.Substring(ClonePrefix.Length));
            }
            if (!_logged)
            {
                _logged = true;
                var names = new List<string>();
                for (int i = 0; i < all.Length; i++) if (all[i] != null) names.Add(all[i].name);
                ModMain.Log?.Msg($"[MapM] bunker interiors: {string.Join(", ", names)}");
            }
            ModMain.Log?.Msg($"[MapM] bunkers {todo.Count}: {string.Join(" ", picks)}");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] bunker fill {ex.Message}"); }
    }

    // 存档只写原版有的名字
    internal static void FixSave(BunkerDistributor d, Il2CppSystem.Collections.Generic.List<BunkerLocationSaveData> data)
    {
        try
        {
            if (data == null) return;
            string fallback = null;
            var all = d?.m_BunkerInteriors;
            for (int i = 0; all != null && i < all.Length && fallback == null; i++) if (all[i] != null && !IsClone(all[i])) fallback = all[i].name;
            var log = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                // BunkerLocationSaveData 是值类型,data[i] 拿到的是拷贝,改完要写回列表
                var e = data[i];
                if (e == null) continue;
                if ((e.m_InteriorId ?? "").StartsWith(ClonePrefix))
                {
                    e.m_InteriorId = OrigById.TryGetValue(e.m_BunkerId ?? "", out var o) ? o : fallback;
                    data[i] = e;
                }
                if (!_saveLogged) { var w = data[i]; log.Add(w.m_BunkerId + "=" + w.m_InteriorId); }
            }
            if (!_saveLogged) { _saveLogged = true; ModMain.Log?.Msg($"[MapM] bunker save: {string.Join(", ", log)}"); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] bunker save {ex.Message}"); }
    }
}

internal static class Patch_MapM_BunkerDeserialize
{
    private static void Postfix(BunkerDistributor __instance) => Patch_MapM_BunkerDistribute.Fill(__instance);
}

internal static class Patch_MapM_BunkerSerialize
{
    private static void Postfix(BunkerDistributor __instance, Il2CppSystem.Collections.Generic.List<BunkerLocationSaveData> __result)
        => Patch_MapM_BunkerDistribute.FixSave(__instance, __result);
}

// 入侵者和厄难原版一个地堡都不刷,这里让每个区域刷一个
internal static class Patch_MapM_InterloperHatch
{
    private static void Prefix(RandomSpawnObject __instance)
    {
        try
        {
            if (__instance != null && __instance.gameObject.name == "PrepperHatch" && __instance.m_NumObjectsToEnableInterloper < 1)
                __instance.m_NumObjectsToEnableInterloper = 1;
        }
        catch { }
    }
}

internal static class MapMKeys
{
    // 找不到场景里的地堡生成点时才用这份坐标(原 mod 的数据)
    private static readonly (string region, Vector3 pos)[] Fixed =
    {
        ("MarshRegion", new Vector3(592.06f, -84.87f, -106.82f)),
        ("BlackrockRegion", new Vector3(706.7f, 373.11f, 816.39f)),
        ("CanneryRegion", new Vector3(328.35f, 343.25f, 835.17f)),
        ("AshCanyon", new Vector3(-42.28f, 171.5f, -794.88f)),
        ("RiverValleyRegion", new Vector3(362.06f, 237.53f, 376.08f)),
        ("TimberwolfMountain", new Vector3(1673.5f, 205.75f, 967.92f)),
        ("MountainTownRegion", new Vector3(1829.84f, 443.03f, 1770.76f)),
        ("LakeRegion", new Vector3(1029.65f, 90.51f, -50.71f)),
        ("RuralRegion", new Vector3(335.83f, 185.33f, 2257.27f)),
        ("RuralRegion", new Vector3(422.32f, 176.3f, 1457.14f)),
    };

    internal static void Tick()
    {
        if (!MapM.Keys) return;
        try
        {
            if (GameManager.IsMainMenuActive() || InputManager.instance == null || uConsole.m_On) return;
            var s = ModMain.Settings;
            var ctx = InputManager.m_CurrentContext;
            if (s.MapM_RevealKey != KeyCode.None && InputManager.GetKeyDown(ctx, s.MapM_RevealKey))
            {
                var panel = InterfaceManager.GetPanel<Panel_Map>();
                if (panel != null)
                {
                    panel.RevealCurrentScene();
                    HUDMessage.AddMessage(I18n.T("当前区域地图已全开", "Map of this region revealed"), false, false);
                }
            }
            if (s.MapM_BunkerKey != KeyCode.None && InputManager.GetKeyDown(ctx, s.MapM_BunkerKey)) ShowBunkers();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MapM] key {ex.Message}"); }
    }

    private static void ShowBunkers()
    {
        var panel = InterfaceManager.GetPanel<Panel_Map>();
        if (panel == null) return;
        int found = 0, spawners = 0;
        // 2.60 起每个区域只有一个固定入口(Design/BunkerHatch 下挂 BunkerLocation),没有 PrepperHatch 了
        var locs = UnityEngine.Object.FindObjectsOfType<BunkerLocation>();
        for (int i = 0; locs != null && i < locs.Count; i++)
        {
            var bl = locs[i];
            if (bl == null || !bl.gameObject.activeInHierarchy) continue;
            spawners++;
            panel.DoNearbyDetailsCheck(15f, true, true, bl.transform.position, false);
            found++;
        }
        var all = spawners > 0 ? null : UnityEngine.Object.FindObjectsOfType<RandomSpawnObject>();
        for (int i = 0; all != null && i < all.Count; i++)
        {
            var rs = all[i];
            if (rs == null || rs.gameObject.name != "PrepperHatch") continue;
            spawners++;
            var objs = rs.m_ObjectList;
            for (int j = 0; objs != null && j < objs.Length; j++)
            {
                var go = objs[j];
                if (go == null || !go.activeSelf) continue;
                panel.DoNearbyDetailsCheck(15f, true, true, go.transform.position, false);
                found++;
            }
        }
        if (spawners == 0)
        {
            string region = null;
            try { region = panel.GetMapNameOfCurrentScene(); } catch { }
            foreach (var f in Fixed)
                if (f.region == region) { panel.DoNearbyDetailsCheck(15f, true, true, f.pos, false); found++; }
        }
        ModMain.Log?.Msg($"[MapM] bunker key spawners={spawners} shown={found}");
        HUDMessage.AddMessage(found > 0
            ? I18n.T($"已在地图上标出 {found} 个地堡", $"{found} bunker(s) marked on the map")
            : I18n.T("这个区域没有刷出地堡(要在室外按)", "No bunker in this region (use it outdoors)"), false, false);
    }
}
#endif
