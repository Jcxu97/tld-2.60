using System;
using System.Collections;
using System.Collections.Generic;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace MoreBunkers;

// 进新地堡时按 Layouts 布置:藏掉原版杂物,摆家具和器械,箱子按主题装东西。
// 家具和箱子每次进来都重新摆(位置第一次算好后记下);货架上的东西只摆一次,之后靠游戏自己的场景存档;箱子里的东西由我们存
internal static class Stock
{
    private const float ItemGap = 0.025f, GroupGap = 0.08f;
    private static readonly string[] StripAlways = { "BreakDown", "DecorationItem", "Placeable" };
    // 能被安全屋模式搬动的摆件要留着的组件
    private static readonly string[] KeepMovable = { "GearPlacePoint", "ObjectGuid", "DecorationItem", "Placeable", "BreakDown", "DecorationPlacePoint" };
    // SafehouseCustomizationPlus 认得的器械,名字要和它表里的一样
    private static readonly HashSet<string> ScpNames = new() { "INTERACTIVE_Forge", "INTERACTIVE_AmmoWorkBench", "INTERACTIVE_PotBellyStove", "INTERACTIVE_StoveMetalA", "INTERACTIVE_IndustrialMillingMachine" };
    private static readonly List<Movable> Movables = new();
    private static BunkerDef _bunker;

    private sealed class Movable
    {
        public string Key, Name;
        public GameObject Go;
        public Vector3 Pos;
        public float Yaw;
    }

    private static object _co;
    private static GameObject _root;
    internal static readonly List<(string key, Container c)> Boxes = new();

    internal static void Begin(BunkerDef b)
    {
        Cancel();
        Boxes.Clear();
        Movables.Clear();
        _bunker = b;
        _co = MelonCoroutines.Start(Run(b));
    }

    internal static void Cancel()
    {
        if (_co != null) { try { MelonCoroutines.Stop(_co); } catch { } _co = null; }
    }

    // 游戏存档前调:把我们箱子里的东西记进 ModData
    internal static void SaveBoxes()
    {
        int n = 0;
        foreach (var (key, c) in Boxes)
        {
            try
            {
                if (c == null) continue;
                SaveData.Current.boxes[key] = c.Serialize() ?? "";
                n++;
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] save box {key} {ex.Message}"); }
        }
        if (CheckMovables()) n++;
        if (n > 0) SaveData.Save();
    }

    // 玩家用安全屋模式动过的摆件:挪了就记新位置;拿走、拆掉或挪出我们的根物体就交给游戏,以后不再重摆
    private static bool CheckMovables()
    {
        // 场景已经卸掉时什么都不判断,不然会把所有摆件当成被拿走
        if (_root == null || !_root.activeInHierarchy || _bunker == null || !StillIn(_bunker)) return false;
        bool changed = false;
        for (int i = Movables.Count - 1; i >= 0; i--)
        {
            var m = Movables[i];
            try
            {
                bool alive = m.Go != null;
                bool ours = alive && m.Go.activeInHierarchy && m.Go.transform.IsChildOf(_root.transform);
                if (!ours)
                {
                    bool inScene = alive && m.Go.activeInHierarchy;
                    SaveData.Current.handed[m.Key] = m.Name + "|" + (inScene ? Xyz(m.Go.transform.position, m.Go.transform.eulerAngles.y) : "");
                    SaveData.Current.moved.Remove(m.Key);
                    Movables.RemoveAt(i);
                    ModMain.Log?.Msg($"[MoreBunkers] {m.Key} {m.Name} left to the game");
                    changed = true;
                    continue;
                }
                var t = m.Go.transform;
                float yaw = t.eulerAngles.y;
                if ((t.position - m.Pos).sqrMagnitude > 0.02f * 0.02f || Mathf.Abs(Mathf.DeltaAngle(yaw, m.Yaw)) > 2f)
                {
                    m.Pos = t.position; m.Yaw = yaw;
                    SaveData.Current.station[m.Key] = new[] { m.Pos.x, m.Pos.y, m.Pos.z, yaw };
                    if (!SaveData.Current.moved.Contains(m.Key)) SaveData.Current.moved.Add(m.Key);
                    changed = true;
                }
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] check {m.Key} {ex.Message}"); }
        }
        return changed;
    }

    // 游戏或 SafehouseCustomizationPlus 已经按存档把这件摆回来了吗(名字对得上、位置在 20 厘米内)
    private static GameObject FindCopy(string name, Vector3 pos)
    {
        var all = UnityEngine.Object.FindObjectsOfType<DecorationItem>();
        for (int i = 0; all != null && i < all.Count; i++)
        {
            var d = all[i];
            if (d == null) continue;
            var go = d.gameObject;
            if (_root != null && go.transform.IsChildOf(_root.transform)) continue;
            if (!go.name.StartsWith(name, StringComparison.OrdinalIgnoreCase)) continue;
            var dp = go.transform.position - pos;
            dp.y = 0f;
            if (dp.sqrMagnitude < 0.2f * 0.2f) return go;
        }
        return null;
    }

    private static System.Reflection.MethodInfo _scpMake;
    private static bool _scpLooked;

    // 让 SafehouseCustomizationPlus 把器械当成能搬的东西;它只在场景刚加载时找一遍,我们的器械是后摆的
    private static void ScpMakeMovable(GameObject go)
    {
        if (!_scpLooked)
        {
            _scpLooked = true;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (asm.GetName().Name != "SafehouseCustomizationPlus") continue;
                _scpMake = asm.GetType("SCPlus.SCPMain")?.GetMethod("MakeIntoDecoration", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            }
            if (_scpMake == null) ModMain.Log?.Msg("[MoreBunkers] SafehouseCustomizationPlus not found, machines stay fixed");
        }
        if (_scpMake == null) return;
        try { _scpMake.Invoke(null, new object[] { go }); ModMain.Log?.Msg($"[MoreBunkers] {go.name} can be moved in safehouse mode"); }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] make {go.name} movable: {(ex.InnerException ?? ex).Message}"); }
    }

    private static string Xyz(Vector3 v, float yaw) => string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:F3},{1:F3},{2:F3},{3:F1}", v.x, v.y, v.z, yaw);

    // "名字|x,y,z,朝向" 拆开;拿进背包或拆掉的没有坐标
    private static bool HandedPose(string v, out string name, out Vector3 pos, out float yaw)
    {
        pos = default; yaw = 0f;
        var parts = (v ?? "").Split('|');
        name = parts[0];
        if (parts.Length < 2 || parts[1].Length == 0) return false;
        var n = parts[1].Split(',');
        if (n.Length < 3) return false;
        var ci = System.Globalization.CultureInfo.InvariantCulture;
        pos = new Vector3(float.Parse(n[0], ci), float.Parse(n[1], ci), float.Parse(n[2], ci));
        if (n.Length > 3) yaw = float.Parse(n[3], ci);
        return true;
    }

    // 交给游戏的摆件,游戏这次放回来的那一份;藏杂物时要跳过
    private static HashSet<IntPtr> HandedCopies(BunkerDef b)
    {
        var set = new HashSet<IntPtr>();
        foreach (var kv in SaveData.Current.handed)
        {
            if (!kv.Key.StartsWith(b.Id + "/") || !HandedPose(kv.Value, out var name, out var pos, out _)) continue;
            var go = FindCopy(name, pos);
            if (go != null) set.Add(go.Pointer);
        }
        return set;
    }

    // 消耗品的倍数:布置里的数量就是朝圣者下的件数(囤货地堡按一个人过半年备),别的难度按比例往下减。
    // 跟随游戏难度,或者按设置里选的那一档
    internal static float Plenty(out string tier, out float keep)
    {
        int a = ModMain.Settings?.Amount ?? 0;
        var t = ExperienceModeType.Stalker;
        if (a == 0) { try { t = ExperienceModeManager.GetCurrentExperienceModeType(); } catch { } }
        else t = a switch { 1 => ExperienceModeType.Pilgrim, 2 => ExperienceModeType.Voyageur, 4 => ExperienceModeType.Interloper, 5 => ExperienceModeType.Misery, _ => ExperienceModeType.Stalker };
        tier = t.ToString();
        keep = t switch { ExperienceModeType.Interloper => 0.75f, ExperienceModeType.Misery => 0.4f, _ => 1f };
        return t switch
        {
            ExperienceModeType.Pilgrim => 1f,
            ExperienceModeType.Voyageur => 0.5f,
            ExperienceModeType.Interloper => 0.65f / 3f,
            ExperienceModeType.Misery => 0.25f / 3f,
            _ => 1f / 3f,
        };
    }

    // 按件放的东西:上限不到 3 件的工具、武器、锅,还有书和衣服;吃的、喝的、药、能叠的和汽油桶跟难度走
    internal static bool ByPiece(G g) => g.Gear.StartsWith("Book", StringComparison.Ordinal) || IsClothing(g.Gear)
        || (g.Max < 3 && !g.Gear.StartsWith("Jerrycan", StringComparison.Ordinal) && !IsConsumable(g.Gear));

    private static readonly Dictionary<string, bool> _consumable = new();

    private static bool IsConsumable(string name)
    {
        if (_consumable.TryGetValue(name, out bool v)) return v;
        var pf = Gear(name.Split('|')[0]);
        v = pf != null && (pf.m_FoodItem != null || pf.m_LiquidItem != null || pf.m_FirstAidItem != null || pf.m_StackableItem != null);
        _consumable[name] = v;
        return v;
    }

    // 架子上十根一捆摆的零碎东西;布置里按根写。和 design/check.py 的 STACK 一样
    private static readonly HashSet<string> Bundled = new() { "ArrowManufactured", "Tinder", "RifleAmmoCasing", "RevolverAmmoCasing", "FlareGunAmmoSingle", "Stick", "BarkTinder" };

    private static readonly Dictionary<IntPtr, int> _pack = new();

    // 一件里有多少单位,照游戏预制件的默认值:弹药盒按发、药瓶按片、火柴按根、咖啡罐按份
    private static int Pack(GearItem pf)
    {
        if (pf == null || pf.m_StackableItem == null) return 1;
        if (!_pack.TryGetValue(pf.Pointer, out int u)) { u = Math.Max(1, pf.m_StackableItem.m_Units); _pack[pf.Pointer] = u; }
        return u;
    }

    private static bool IsBundled(string gear, GearItem pf) => pf.m_StackableItem != null && Bundled.Contains(gear);

    private static readonly Dictionary<string, bool> _clothing = new();

    private static bool IsClothing(string name)
    {
        if (_clothing.TryGetValue(name, out bool v)) return v;
        var pf = name.Contains('|') ? null : Gear(name);
        v = pf != null && pf.m_ClothingItem != null;
        _clothing[name] = v;
        return v;
    }

    private static float _keep = 1f;
    private static System.Random _rnd = new();

    // 难度高时按件的东西每件看机会留不留
    internal static int Keep(int n)
    {
        if (_keep >= 1f) return n;
        int r = 0;
        for (int i = 0; i < n; i++) if (_rnd.NextDouble() < _keep) r++;
        return r;
    }

    internal static int Amount(System.Random rnd, G g, float k)
    {
        if (ByPiece(g)) return Keep(Layouts.Roll(rnd, g));
        if (k >= 1f) return Layouts.Roll(rnd, g);
        return Layouts.Roll(rnd, new G(g.Gear, Mathf.RoundToInt(g.Min * k), Mathf.RoundToInt(g.Max * k), g.Pile));
    }

    internal static bool IsMovable(Piece p) => p.Theme == null && p.On == 0 && p.F != null;

    internal static string PrefabName(Piece p, Furn f) =>
        p.Station == "mill" ? "INTERACTIVE_IndustrialMillingMachine" : System.IO.Path.GetFileNameWithoutExtension(f.Path);

    // 场景名会带 _SANDBOX 之类的附加场景,用当前场景存档名里的编号判断还在不在这个地堡
    private static bool StillIn(BunkerDef b)
    {
        try { return Bunkers.ByGuid(GameManager.m_SceneTransitionData?.m_SceneSaveFilenameCurrent) == b; } catch { return false; }
    }

    internal static Vector3 EnterPoint()
    {
        var go = GameObject.Find("PrepperCacheEnterPoint");
        if (go != null) return go.transform.position;
        var p = GameManager.GetPlayerTransform();
        return p != null ? p.position : Vector3.zero;
    }

    private static IEnumerator Run(BunkerDef b)
    {
        float t = Time.realtimeSinceStartup + 2f;
        while (Time.realtimeSinceStartup < t) yield return null;
        if (!StillIn(b)) yield break;
        if (!Layouts.All.TryGetValue(b.Id, out var L)) yield break;
        if (!SceneLoaded(L.Interior, out string scenes))
        {
            ModMain.Log?.Warning($"[MoreBunkers] {b.Id}: scenes are {scenes}, layout is for {L.Interior}; this save was made with an older version");
            yield break;
        }

        var enter = EnterPoint();
        var off = Layouts.DesignEnter.TryGetValue(L.Interior, out var de) ? enter - de : Vector3.zero;
        off.y = 0f;
        string sig = Layouts.Sig(L);
        bool was = SaveData.Current.stocked.Contains(b.Id);
        SaveData.Current.layout.TryGetValue(b.Id, out var oldSig);
        if (was && oldSig != null && oldSig != sig && !oldSig.StartsWith("v2|")) { FromV1(b, oldSig, sig, L); oldSig = sig; }
        bool changed = was && oldSig != sig;
        string sceneSave = "";
        try { sceneSave = GameManager.m_SceneTransitionData?.m_SceneSaveFilenameCurrent ?? ""; } catch { }
        bool newScene = was && !changed && (!SaveData.Current.stockedSave.TryGetValue(b.Id, out var oldSave) || oldSave != sceneSave);
        bool first = !was || changed || newScene;
        if (changed) ModMain.Log?.Msg($"[MoreBunkers] {b.Id} layout changed, setting it up again ({sig})");
        if (newScene) ModMain.Log?.Msg($"[MoreBunkers] {b.Id} interior save is new ({sceneSave}), putting the shelves back");
        try { HideJunk(enter, HandedCopies(b)); if (first) ClearGear(enter); } catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] clear {ex}"); }
        if (changed) try { DropOldHanded(b, sig); } catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] old pieces {ex.Message}"); }
        yield return null;
        yield return null;
        if (!StillIn(b)) yield break;

        var gos = new GameObject[L.Pieces.Length];
        try
        {
            Stations.Reset();
            if (_root != null) UnityEngine.Object.Destroy(_root);
            _root = new GameObject("MoreBunkers_Interior");
            var holder = new GameObject("MoreBunkers_Holder");
            holder.SetActive(false);
            bool saved = false;
            for (int i = 0; i < L.Pieces.Length; i++)
            {
                try { gos[i] = Place(b, sig, L.Pieces[i], i, enter.y, off, holder.transform, gos, ref saved); }
                catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] piece {i} {L.Pieces[i].F} {ex.Message}"); }
            }
            UnityEngine.Object.Destroy(holder);
            if (saved) SaveData.Save();
            var names = new List<string>();
            for (int i = 0; i < L.Pieces.Length; i++)
            {
                var p = L.Pieces[i];
                if (gos[i] == null || !IsMovable(p)) continue;
                var tr = gos[i].transform;
                Movables.Add(new Movable { Key = $"{b.Id}/{sig}/{i}", Name = PrefabName(p, Layouts.Furniture[p.F]), Go = gos[i], Pos = tr.position, Yaw = tr.eulerAngles.y });
                if (gos[i].GetComponentInChildren<DecorationItem>(true) != null) names.Add(p.F);
            }
            ModMain.Log?.Msg($"[MoreBunkers] {b.Id} movable in safehouse mode: {string.Join(",", names)}");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] build {ex}"); }
        yield return null;
        yield return null;
        if (!StillIn(b)) yield break;

        var rnd = new System.Random();
        float plenty = Plenty(out string tier, out _keep);
        _rnd = rnd;
        Container spare = null;
        int filled = 0, restored = 0;
        var inBox = new List<Bounds>();
        for (int i = 0; i < L.Pieces.Length; i++)
        {
            var p = L.Pieces[i];
            if (gos[i] == null) continue;
            try
            {
                if (p.Station != null) Stations.Wire(b, p.Station, gos[i]);
                if (IsMovable(p) && ScpNames.Contains(gos[i].name)) ScpMakeMovable(gos[i]);
                if (p.Theme == null) continue;
                var c = gos[i].GetComponentInChildren<Container>(true);
                if (c == null) continue;
                c.m_GearToInstantiate?.Clear();
                c.DestroyAllGear();
                // 箱子按序号和家具存,布置改了位置也接着用
                string key = BoxKey(b, i, p);
                if (SaveData.Current.boxes.TryGetValue(key, out var text) && text != null)
                {
                    c.Deserialize(text, new Il2CppSystem.Collections.Generic.List<GearItem>());
                    restored++;
                    inBox.Add(Inside(gos[i]));
                }
                else
                {
                    foreach (var g in p.Theme) AddToBox(c, g.Gear, Amount(rnd, g, plenty));
                    SaveData.Current.boxes[key] = c.Serialize() ?? "";
                    filled++;
                }
                // 打开就能看到东西,像自己整理过的箱子,不用再搜
                try { c.MarkAsInspected(); } catch { }
                c.m_Inspected = true;
                Boxes.Add((key, c));
                spare ??= c;
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] piece {i} setup {ex.Message}"); }
        }
        if (filled > 0) SaveData.Save();
        if (inBox.Count > 0) DropLoose(inBox);

        if (first)
        {
            int placed = 0, over = 0;
            var pm = GameManager.GetPlayerManagerComponent();
            for (int i = 0; i < L.Pieces.Length; i++)
            {
                var p = L.Pieces[i];
                try
                {
                    if (p.Levels != null && gos[i] != null) FillShelf(pm, p, gos[i].transform, rnd, plenty, spare, ref placed, ref over);
                    if (p.Rack != null && gos[i] != null) FillRack(pm, p, gos[i], ref placed);
                    if (p.Items != null) FillLine(pm, p, enter.y, off, ref placed);
                }
                catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] fill {i} {ex.Message}"); }
            }
            if (!SaveData.Current.stocked.Contains(b.Id)) SaveData.Current.stocked.Add(b.Id);
            SaveData.Current.layout[b.Id] = sig;
            SaveData.Current.stockedSave[b.Id] = sceneSave;
            SaveData.Save();
            ModMain.Log?.Msg($"[MoreBunkers] {b.Id} stocked ({tier} x{plenty}, keep {_keep}): {placed} on display, {filled} boxes filled, {over} moved to a box");
        }
        else ModMain.Log?.Msg($"[MoreBunkers] {b.Id} rebuilt: {restored} boxes restored, {filled} filled");
        yield return null;
        Stations.AfterStart();
        _co = null;
    }

    internal static string BoxKey(BunkerDef b, int i, Piece p) => $"{b.Id}/box/{i}/{p.F}";

    // 1.0 的签名把数量也算进去了,1.1 只算摆件。两版摆件顺序一样,记录按序号改名接着用,地堡不重摆
    private static void FromV1(BunkerDef b, string oldSig, string sig, Layout L)
    {
        string from = $"{b.Id}/{oldSig}/", to = $"{b.Id}/{sig}/";
        string Re(string k) => k.StartsWith(from) ? to + k.Substring(from.Length) : k;
        var st = SaveData.Current.station;
        foreach (var k in new List<string>(st.Keys)) if (k.StartsWith(from)) { st[Re(k)] = st[k]; st.Remove(k); }
        var hd = SaveData.Current.handed;
        foreach (var k in new List<string>(hd.Keys)) if (k.StartsWith(from)) { hd[Re(k)] = hd[k]; hd.Remove(k); }
        var mv = SaveData.Current.moved;
        for (int j = 0; j < mv.Count; j++) mv[j] = Re(mv[j]);
        var bx = SaveData.Current.boxes;
        for (int i = 0; i < L.Pieces.Length; i++)
            if (bx.TryGetValue(from + i, out var text)) { bx[BoxKey(b, i, L.Pieces[i])] = text; bx.Remove(from + i); }
        SaveData.Current.layout[b.Id] = sig;
        SaveData.Save();
        ModMain.Log?.Msg($"[MoreBunkers] {b.Id}: kept the 1.0 layout as it is");
    }

    // 布置改了要整个重摆:旧布置里交给游戏的摆件如果还在原处,先删掉,免得和新摆的重复
    private static void DropOldHanded(BunkerDef b, string sig)
    {
        int n = 0;
        var keys = new List<string>(SaveData.Current.handed.Keys);
        foreach (var k in keys)
        {
            if (!k.StartsWith(b.Id + "/") || k.StartsWith($"{b.Id}/{sig}/")) continue;
            if (HandedPose(SaveData.Current.handed[k], out var name, out var pos, out _))
            {
                var go = FindCopy(name, pos);
                if (go != null) { UnityEngine.Object.Destroy(go); n++; }
            }
            SaveData.Current.handed.Remove(k);
        }
        SaveData.Current.moved.RemoveAll(k => k.StartsWith(b.Id + "/") && !k.StartsWith($"{b.Id}/{sig}/"));
        if (n > 0) ModMain.Log?.Msg($"[MoreBunkers] {b.Id}: removed {n} pieces from the old layout");
    }

    private static Bounds Inside(GameObject go)
    {
        var b = new Bounds(go.transform.position, Vector3.zero);
        bool any = false;
        // 没激活的模型 bounds 可能在原点,算进来箱子范围会拉到整个房间
        foreach (var r in go.GetComponentsInChildren<Renderer>(false))
        {
            if (r == null || !r.enabled) continue;
            if (!any) { b = r.bounds; any = true; } else b.Encapsulate(r.bounds);
        }
        b.Expand(-0.06f);
        return b;
    }

    // 箱子里的东西从我们的存档恢复;万一游戏也把它们当散落物品存了一份,箱体里面就会多出一份,删掉
    private static void DropLoose(List<Bounds> inBox)
    {
        int n = 0;
        var mine = new HashSet<IntPtr>();
        foreach (var (_, c) in Boxes)
        {
            if (c == null) continue;
            var l = new Il2CppSystem.Collections.Generic.List<GearItem>();
            c.GetItems(l);
            for (int k = 0; k < l.Count; k++) if (l[k] != null) mine.Add(l[k].Pointer);
        }
        var all = UnityEngine.Object.FindObjectsOfType<GearItem>();
        for (int i = 0; all != null && i < all.Count; i++)
        {
            var gi = all[i];
            if (gi == null || !gi.gameObject.activeInHierarchy || mine.Contains(gi.Pointer)) continue;
            if (_root != null && gi.transform.IsChildOf(_root.transform)) continue;
            var pos = gi.transform.position;
            foreach (var b in inBox)
                if (b.size.x > 0f && b.Contains(pos)) { UnityEngine.Object.Destroy(gi.gameObject); n++; break; }
        }
        if (n > 0) ModMain.Log?.Warning($"[MoreBunkers] removed {n} loose items found inside boxes");
    }

    private static bool SceneLoaded(string name, out string all)
    {
        var names = new List<string>();
        bool hit = false;
        for (int i = 0; i < UnityEngine.SceneManagement.SceneManager.sceneCount; i++)
        {
            string n = UnityEngine.SceneManagement.SceneManager.GetSceneAt(i).name;
            names.Add(n);
            if (n == name) hit = true;
        }
        all = string.Join(",", names);
        return hit;
    }

    // 原版放的箱子和箱子模型:失物招领箱和任务箱留着
    private static bool OldBox(Transform t) =>
        t.name.StartsWith("CONTAINER_") && !t.name.Contains("Inaccessible") && !InMission(t) && !Under(t, "LostAndFound");

    private static bool Under(Transform t, string part)
    {
        for (var x = t; x != null; x = x.parent) if (x.name.Contains(part)) return true;
        return false;
    }

    // 玩家自己摆的装饰(游戏放在 DesignPlaceable 下)和交给游戏的摆件不算杂物
    private static bool Kept(Transform t, HashSet<IntPtr> keep)
    {
        for (var x = t; x != null; x = x.parent)
            if (x.name == "DesignPlaceable" || keep.Contains(x.gameObject.Pointer)) return true;
        return false;
    }

    private static void HideJunk(Vector3 enter, HashSet<IntPtr> keep)
    {
        int n = 0;
        var all = UnityEngine.Object.FindObjectsOfType<Transform>();
        var hide = new List<GameObject>();
        for (int i = 0; all != null && i < all.Count; i++)
        {
            var t = all[i];
            if (t == null || !(Layouts.IsJunk(t.name) || OldBox(t))) continue;
            if ((t.position - enter).sqrMagnitude > 25f * 25f) continue;
            var top = t;
            while (top.parent != null && (Layouts.IsJunk(top.parent.name) || OldBox(top.parent))) top = top.parent;
            if (InBed(top) || Kept(top, keep)) continue;
            hide.Add(top.gameObject);
        }
        // 原版的简易床铺也收掉,换成布置里的床
        for (int i = 0; all != null && i < all.Count; i++)
        {
            var t = all[i];
            if (t == null || (_root != null && t.IsChildOf(_root.transform))) continue;
            if (!(t.name.StartsWith("INTERACTIVE_BedMattressI") || t.name.StartsWith("INTERACTIVE_MakeshiftBed"))) continue;
            if ((t.position - enter).sqrMagnitude > 25f * 25f || Kept(t, keep)) continue;
            hide.Add(t.gameObject);
        }
        foreach (var go in hide) if (go != null && go.activeSelf) { go.SetActive(false); n++; }

        int boxes = 0;
        var cs = UnityEngine.Object.FindObjectsOfType<Container>();
        for (int i = 0; cs != null && i < cs.Count; i++)
        {
            var c = cs[i];
            if (c == null || !c.name.StartsWith("CONTAINER_") || c.name.Contains("Inaccessible")) continue;
            if (c.m_MissionObject != null || !string.IsNullOrEmpty(c.m_MissionSupplyObjectiveId) || InMission(c.transform)) continue;
            if (_root != null && c.transform.IsChildOf(_root.transform)) continue;
            if (Kept(c.transform, keep)) continue;
            if ((c.transform.position - enter).sqrMagnitude > 25f * 25f) continue;
            c.gameObject.SetActive(false);
            boxes++;
        }
        ModMain.Log?.Msg($"[MoreBunkers] hid {n} junk objects and {boxes} old containers");
    }

    private static bool InBed(Transform t)
    {
        for (var x = t; x != null; x = x.parent) if (x.name.Contains("Bed") || x.name.Contains("Mattress")) return true;
        return false;
    }

    private static bool InMission(Transform t)
    {
        for (var x = t; x != null; x = x.parent) if (x.name.Contains("Mission") || x.name.Contains("Trader")) return true;
        return false;
    }

    private static bool Keep(GearItem gi)
    {
        // 玩家拿到过手的东西(自己丢下的、从架上拿走又放回的)不删
        if (gi.m_BeenInPlayerInventory || gi.m_HasBeenOwnedByPlayer) return true;
        if (gi.m_NarrativeCollectibleItem != null) return true;
        // 技能书也带任务标记,不能当任务物品留着,不然重摆时旧书不删又摆一套
        if (gi.m_MissionObject != null && !(gi.name ?? "").StartsWith("GEAR_Book")) return true;
        string n = gi.name ?? "";
        return n.Contains("Note") || n.Contains("Key") || n.Contains("Journal") || n.Contains("Collectible");
    }

    private static void ClearGear(Vector3 enter)
    {
        int gear = 0, kept = 0;
        var all = UnityEngine.Object.FindObjectsOfType<GearItem>();
        for (int i = 0; all != null && i < all.Count; i++)
        {
            var gi = all[i];
            if (gi == null || gi.m_InPlayerInventory || !gi.gameObject.activeInHierarchy) continue;
            if ((gi.transform.position - enter).sqrMagnitude > 25f * 25f) continue;
            if (Keep(gi)) { kept++; continue; }
            GearManager.DestroyGearObject(gi.gameObject);
            gear++;
        }
        ModMain.Log?.Msg($"[MoreBunkers] cleared {gear} loose items (kept {kept})");
    }

    private static GameObject LoadPrefab(string path)
    {
        // 有的预制件只用短名登记(比如 CONTAINER_MetalBox),全路径找不到就用短名再找一次
        foreach (var key in new[] { path, System.IO.Path.GetFileNameWithoutExtension(path) })
        {
            try
            {
                var go = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)key).WaitForCompletion();
                if (go != null) return go;
            }
            catch { }
        }
        return null;
    }

    // 在没激活的父物体下生成,先改好字段再激活,箱子的 Awake 才不会按原版战利品表刷东西
    private static GameObject Place(BunkerDef b, string sig, Piece p, int i, float refY, Vector3 off, Transform holder, GameObject[] gos, ref bool saved)
    {
        if (p.F == null || !Layouts.Furniture.TryGetValue(p.F, out var f)) return null;
        // 下面那件没摆出来,叠在上面的也不摆,免得落到房间原点
        if (p.On < 0 && (i + p.On < 0 || gos[i + p.On] == null)) return null;
        string key = $"{b.Id}/{sig}/{i}";
        bool movable = IsMovable(p);
        string pname = PrefabName(p, f);
        if (movable && SaveData.Current.handed.TryGetValue(key, out var hv))
        {
            // 拿进背包或拆掉了,或者游戏已经按它的存档放回来了:都不再摆
            if (!HandedPose(hv, out _, out var hp, out var hy) || FindCopy(pname, hp) != null) return null;
            // 游戏没放回来:照最后看到的位置摆回去,还算我们的
            SaveData.Current.handed.Remove(key);
            SaveData.Current.station[key] = new[] { hp.x, hp.y, hp.z, hy };
            if (!SaveData.Current.moved.Contains(key)) SaveData.Current.moved.Add(key);
            saved = true;
            ModMain.Log?.Warning($"[MoreBunkers] {key} {p.F}: the game did not put it back, placing it where it was last seen");
        }
        if (movable && SaveData.Current.moved.Contains(key) && SaveData.Current.station.TryGetValue(key, out var mv) && mv != null && mv.Length == 4
            && FindCopy(pname, new Vector3(mv[0], mv[1], mv[2])) != null)
        {
            SaveData.Current.handed[key] = pname + "|" + Xyz(new Vector3(mv[0], mv[1], mv[2]), mv[3]);
            SaveData.Current.moved.Remove(key);
            saved = true;
            ModMain.Log?.Msg($"[MoreBunkers] {key} {p.F}: the game already put it back, leaving it to the game");
            return null;
        }
        var pf = LoadPrefab(f.Path);
        if (pf == null) { ModMain.Log?.Warning($"[MoreBunkers] prefab missing {f.Path}"); return null; }
        var go = UnityEngine.Object.Instantiate(pf, holder);
        GameObject root = go;
        if (p.Station == "mill")
        {
            root = new GameObject("INTERACTIVE_IndustrialMillingMachine");
            root.transform.SetParent(holder, false);
            go.transform.SetParent(root.transform, false);
        }
        root.name = movable && ScpNames.Contains(pname) ? pname : $"MoreBunkers_{i}_{p.F}";

        bool keepAll = p.Station != null || p.Theme != null;
        foreach (var m in root.GetComponentsInChildren<MonoBehaviour>(true))
        {
            if (m == null) continue;
            string n = m.GetIl2CppType().Name;
            bool keep = movable ? (keepAll ? true : Array.IndexOf(KeepMovable, n) >= 0)
                                : (Array.IndexOf(StripAlways, n) < 0 && (keepAll || n == "GearPlacePoint" || n == "ObjectGuid"));
            if (!keep) UnityEngine.Object.DestroyImmediate(m);
        }
        if (movable && root.GetComponent<ObjectGuid>() == null) ObjectGuid.MaybeAttachObjectGuidAddOrReplace(root, Stations.MakeGuid($"{b.Guid}/{i}/root"));
        var guids = root.GetComponentsInChildren<ObjectGuid>(true);
        for (int k = 0; guids != null && k < guids.Count; k++)
            if (guids[k] != null) ObjectGuid.MaybeAttachObjectGuidAddOrReplace(guids[k].gameObject, Stations.MakeGuid($"{b.Guid}/{i}/{k}"));
        foreach (var c in root.GetComponentsInChildren<Container>(true))
        {
            if (c == null) continue;
            c.m_DisableSerialization = true;
            c.m_LootTableData = null; c.m_LockedLootTableData = null; c.m_LootTablePrefab = null; c.m_LockedLootTablePrefab = null;
            c.m_SpawnChance = 100f; c.m_RolledSpawnChance = true; c.m_ChanceEmpty = 0f;
            c.m_MinRandomItems = 0; c.m_MaxRandomItems = 0; c.m_MinRandomItemsLocked = 0; c.m_MaxRandomItemsLocked = 0;
            c.m_NotPopulated = false; c.m_StartInspected = false; c.m_Inspected = false;
            c.m_Lock = null;
            c.m_GearToInstantiate?.Clear();
        }

        var rot = Layouts.RotOf(p, f);
        Vector3 rootPos;
        var under = p.On < 0 && i + p.On >= 0 ? gos[i + p.On] : null;
        if (under != null)
        {
            rootPos = under.transform.position + Vector3.up * p.Mount;
            rot = under.transform.rotation;
        }
        else if (SaveData.Current.station.TryGetValue(key, out var s) && s != null && s.Length == 4 && !(p.Free && !SaveData.Current.moved.Contains(key)))
        {
            rootPos = new Vector3(s[0], s[1], s[2]);
            rot = Quaternion.Euler(0f, s[3], 0f);
        }
        else
        {
            bool tight = false;
            rootPos = p.Free ? Drop(p, f, rot, refY, off) : Snap(p, f, rot, refY, off, out tight);
            if (tight) ModMain.Log?.Warning($"[MoreBunkers] {key} {p.F}: no clear spot, placed against the wall anyway");
            SaveData.Current.station[key] = new[] { rootPos.x, rootPos.y, rootPos.z, rot.eulerAngles.y };
            saved = true;
        }
        root.transform.SetPositionAndRotation(rootPos, rot);
        root.transform.SetParent(_root.transform, true);
        Physics.SyncTransforms();
        ModMain.Log?.Msg($"[MoreBunkers] {key} {p.F} at {rootPos} yaw {rot.eulerAngles.y:F0}");
        return root;
    }

    // 从设计位置往背后推到贴墙;被墙上的立柱、管子挡住就沿墙左右挪一点再试
    private static Vector3 Snap(Piece p, Furn f, Quaternion rot, float refY, Vector3 off, out bool tight)
    {
        var ours = _root.transform;
        var face = Layouts.FaceDir(p.Face);
        // 贴墙、挪位、查空位都按正面朝向算;预制件自己的转角只影响最后的挂点
        var frot = Quaternion.Euler(0f, p.Face, 0f);
        var along = frot * Vector3.right;
        var designed = new Vector3(p.X, 0f, p.Z) + off;
        float y0 = p.Mount, h = f.H, w = f.W, d = f.D;
        float bw = w, bd = d;
        if (p.Rack != null) { bw = Mathf.Max(w, 1.6f); bd = 0.3f; }
        float[] slides = { 0f, 0.15f, -0.15f, 0.3f, -0.3f, 0.45f, -0.45f, 0.6f, -0.6f };
        Vector3 best = designed;
        float bestFloor = refY;
        tight = true;
        foreach (float sl in slides)
        {
            var c = designed + along * sl;
            float floor = Layouts.FloorAt(c.x, c.z, refY, ours);
            float dist = Layouts.WallDist(c, floor, frot, w, h, y0, -face, ours);
            if (dist < 3f) c += face * (d * 0.5f + 0.015f - dist);
            var box = c + face * ((bd - d) * 0.5f);
            if (sl == 0f) { best = c; bestFloor = floor; }
            if (!Layouts.Blocked(box, floor, frot, bw, bd, h, y0, ours, null))
            {
                best = c; bestFloor = floor; tight = false;
                break;
            }
        }
        var rootPos = best - rot * new Vector3(f.Cx, 0f, f.Cz);
        rootPos.y = bestFloor + f.RootY + p.Mount;
        return rootPos;
    }

    // 从上往下打,落在第一个碰到的面上(桌面、柜顶或地面),自己摆的家具也算
    private static Vector3 Drop(Piece p, Furn f, Quaternion rot, float refY, Vector3 off)
    {
        var c = new Vector3(p.X, 0f, p.Z) + off;
        float y = Layouts.FloorAt(c.x, c.z, refY, _root.transform);
        var hits = Physics.RaycastAll(new Vector3(c.x, y + 2.2f, c.z), Vector3.down, 2.4f, ~0, QueryTriggerInteraction.Ignore);
        float best = float.MaxValue;
        for (int i = 0; hits != null && i < hits.Count; i++)
        {
            var h = hits[i];
            if (h.collider == null || h.collider.isTrigger || h.normal.y < 0.7f) continue;
            if (h.collider.GetComponentInParent<GearItem>() != null) continue;
            var pl = GameManager.GetPlayerTransform();
            if (pl != null && h.collider.transform.IsChildOf(pl)) continue;
            if (h.distance < best) { best = h.distance; y = h.point.y; }
        }
        var rootPos = c - rot * new Vector3(f.Cx, 0f, f.Cz);
        rootPos.y = y + f.RootY + p.Mount;
        return rootPos;
    }

    // 货架板、桌面的实际高度:从格子上方往下打到这件家具自己的碰撞上,差太多就用设计值
    private static float Surface(Transform t, Vector3 world, float designY)
    {
        var hits = Physics.RaycastAll(new Vector3(world.x, designY + 0.3f, world.z), Vector3.down, 0.6f, ~0, QueryTriggerInteraction.Ignore);
        float best = float.MaxValue, y = designY;
        for (int i = 0; hits != null && i < hits.Count; i++)
        {
            var h = hits[i];
            if (h.collider == null || h.collider.isTrigger || !h.collider.transform.IsChildOf(t)) continue;
            if (h.distance < best) { best = h.distance; y = h.point.y; }
        }
        return y;
    }

    // 新加的物品名还没在游戏里实测过,载不到就换成相近的已知物品
    private static readonly Dictionary<string, string> Substitute = new()
    {
        ["Flashlight_LongLasting"] = "Flashlight", ["BlueFlare"] = "FlareA", ["ArrowManufacturedHead"] = "ArrowHead",
        ["ArrowManufacturedShaft"] = "ArrowShaft", ["Balaclava"] = "Toque", ["FleeceSweater"] = "WoolSweater",
        ["FleeceMittens"] = "Mittens", ["WireBundle"] = "ScrapMetal", ["ReclaimedWoodB"] = "Softwood", ["BarkTinder"] = "Tinder",
        ["FishingLine"] = "Line", ["Line"] = "Cloth", ["Gut"] = "Cloth", ["Leather"] = "LeatherDried",
        ["SprayPaintCan"] = "Flashlight", ["Stick"] = "Firelog", ["Hardwood"] = "Firelog", ["Softwood"] = "Firelog",
    };
    private static readonly HashSet<string> _warned = new();

    private static GearItem Gear(string name)
    {
        string n = name;
        for (int hop = 0; hop < 4 && n != null; hop++)
        {
            GearItem pf = null;
            try { pf = GearItem.LoadGearItemPrefab("GEAR_" + n); } catch { }
            if (pf != null)
            {
                if (n != name && _warned.Add(name)) ModMain.Log?.Warning($"[MoreBunkers] no GEAR_{name}, using GEAR_{n}");
                return pf;
            }
            n = Substitute.TryGetValue(n, out var next) ? next : (n.StartsWith("Book") && n != "BookA" ? "BookA" : null);
        }
        if (_warned.Add(name)) ModMain.Log?.Warning($"[MoreBunkers] no GEAR_{name}");
        return null;
    }

    // 每层按组从左到右排,组内一列列从后往前;放不下的进第一个箱子
    // 每层按组从左到右排,组内一列列从前往后;扁平的东西按 Pile 往上叠;放不下的进第一个箱子
    // 一组里写 "A|B|C" 表示轮流用这几种(比如一摞不同的书)
    private static void FillShelf(PlayerManager pm, Piece p, Transform t, System.Random rnd, float plenty, Container spare, ref int placed, ref int over)
    {
        var f = Layouts.Furniture[p.F];
        for (int li = 0; li < p.Levels.Length && li < f.Levels.Length; li++)
        {
            var lv = f.Levels[li];
            float depth = lv.Z1 - lv.Z0;
            var groups = new List<(List<(GearItem pf, int units)> items, float wid, float dep, float yaw, float h, int tiers, Bounds bx)>();
            float total = 0f;
            foreach (var g in p.Levels[li])
            {
                // "~0.34" 是给台面上摆件(收音机之类)留的空位
                if (g.Gear.StartsWith("~"))
                {
                    float gap = float.Parse(g.Gear.Substring(1), System.Globalization.CultureInfo.InvariantCulture);
                    total += gap + (groups.Count > 0 ? GroupGap : 0f);
                    groups.Add((new List<(GearItem, int)>(), gap, 0f, 0f, 0f, 1, default));
                    continue;
                }
                var kinds = new List<GearItem>();
                foreach (var name in g.Gear.Split('|'))
                {
                    var pf = Gear(name);
                    if (pf != null) kinds.Add(pf);
                }
                if (kinds.Count == 0) continue;
                // 架上摆的也算在总量里:朝圣者照布置的数量摆,别的难度跟着少;一件一件摆开,箭和火绒这类十根一捆
                int count = Layouts.Roll(rnd, g);
                count = ByPiece(g) ? Keep(count) : (plenty < 1f ? Mathf.RoundToInt(count * plenty) : count);
                if (count <= 0) continue;
                var items = new List<(GearItem, int)>();
                if (IsBundled(g.Gear, kinds[0]))
                {
                    int bundles = (count + 9) / 10;
                    for (int k = 0; k < bundles; k++) items.Add((kinds[0], count / bundles + (k < count % bundles ? 1 : 0)));
                }
                else for (int u = 0; u < count; u++) { var kd = kinds[u % kinds.Count]; items.Add((kd, Pack(kd))); }
                var bx = Layouts.ItemBox(kinds[0]);
                for (int k = 1; k < kinds.Count; k++) bx.Encapsulate(Layouts.ItemBox(kinds[k]));
                float sx = bx.size.x, sz = bx.size.z, h = bx.size.y;
                bool turn = sz > depth ? sx < sz : (sx <= depth && sz < sx);
                float wid = turn ? sz : sx, dep = turn ? sx : sz;
                int tiers = Mathf.Clamp(Mathf.Min(g.Pile, Mathf.FloorToInt((lv.Clear - 0.02f) / Mathf.Max(0.01f, h))), 1, 6);
                int per = Mathf.Max(1, Mathf.FloorToInt((depth + ItemGap) / (dep + ItemGap)));
                int cols = (items.Count + per * tiers - 1) / (per * tiers);
                total += cols * wid + (cols - 1) * ItemGap + (groups.Count > 0 ? GroupGap : 0f);
                groups.Add((items, wid, dep, turn ? 90f : 0f, h, tiers, bx));
            }
            float x = Mathf.Max(lv.X0, (lv.X0 + lv.X1) * 0.5f - total * 0.5f);
            foreach (var (items, wid, dep, yaw, h, tiers, bx) in groups)
            {
                if (items.Count == 0) { x += wid + GroupGap; continue; }
                int per = Mathf.Max(1, Mathf.FloorToInt((depth + ItemGap) / (dep + ItemGap)));
                int next = 0;
                var ry = Quaternion.Euler(0f, yaw, 0f);
                while (next < items.Count)
                {
                    if (x + wid > lv.X1 + 0.01f)
                    {
                        for (int k = next; k < items.Count; k++) if (spare != null && AddToBox(spare, items[k].pf, items[k].units)) over++;
                        ModMain.Log?.Warning($"[MoreBunkers] {p.F} level {li}: {items.Count - next} x {items[next].pf.name} did not fit; level needs {total:F2} of {lv.X1 - lv.X0:F2}; {Sizes(groups)}");
                        break;
                    }
                    int m = Mathf.Min(per * tiers, items.Count - next);
                    int rows = Mathf.Min(per, m);
                    float used = rows * dep + (rows - 1) * ItemGap;
                    float z = (lv.Z0 + lv.Z1) * 0.5f - used * 0.5f + dep * 0.5f;
                    var top = new float[rows];
                    for (int j = 0; j < m; j++)
                    {
                        int r = j % rows, tier = j / rows;
                        var (pf, units) = items[next + j];
                        var slot = new Vector3(x + wid * 0.5f, lv.Top, z + r * (dep + ItemGap));
                        var local = slot - ry * new Vector3(bx.center.x, 0f, bx.center.z);
                        var world = t.position + t.rotation * local;
                        float floor = tier == 0 ? Surface(t, t.position + t.rotation * slot, world.y) : top[r];
                        world.y = floor + 0.004f - bx.min.y;
                        var gi = Spawn(pm, pf, units, world, t.rotation * ry);
                        // 底层没刷出来时,上面那件落在板上,不落到 0 高度
                        if (gi == null) { if (tier == 0) top[r] = floor; continue; }
                        placed++;
                        // 按摆出来的实际模型落到板上或下面那件上面;预制件量的大小和实际显示的会差几厘米
                        if (Shape(gi, out var sb))
                        {
                            float dy = floor + 0.003f - sb.min.y;
                            if (Mathf.Abs(dy) < 0.3f) gi.transform.position += Vector3.up * dy;
                            top[r] = sb.max.y + (Mathf.Abs(dy) < 0.3f ? dy : 0f);
                        }
                        else top[r] = floor + h + 0.003f;
                    }
                    next += m;
                    x += wid + ItemGap;
                }
                x += GroupGap - ItemGap;
            }
        }
    }

    private static bool Shape(GearItem gi, out Bounds b)
    {
        b = default;
        bool any = false;
        foreach (var r in gi.GetComponentsInChildren<Renderer>(false))
        {
            if (r == null || !r.enabled || r.name.Contains("Inspect") || r.name.Contains("Shadow")) continue;
            if (!any) { b = r.bounds; any = true; } else b.Encapsulate(r.bounds);
        }
        return any;
    }

    private static string Sizes(List<(List<(GearItem pf, int units)> items, float wid, float dep, float yaw, float h, int tiers, Bounds bx)> groups)
    {
        var sb = new System.Text.StringBuilder();
        foreach (var g in groups)
            sb.Append(g.items.Count > 0 ? g.items[0].pf.name : "gap").Append(' ').Append(g.bx.size.x.ToString("F2")).Append('x').Append(g.bx.size.y.ToString("F2")).Append('x').Append(g.bx.size.z.ToString("F2")).Append(" n").Append(g.items.Count).Append(" t").Append(g.tiers).Append("; ");
        return sb.ToString();
    }

    private static void FillRack(PlayerManager pm, Piece p, GameObject go, ref int placed)
    {
        var pts = new List<GearPlacePoint>();
        foreach (var gp in go.GetComponentsInChildren<GearPlacePoint>(true)) if (gp != null) pts.Add(gp);
        pts.Sort((a, c) => c.transform.position.y.CompareTo(a.transform.position.y));
        for (int i = 0; i < p.Rack.Length && i < pts.Count; i++)
        {
            var pf = Gear(p.Rack[i]);
            if (pf == null) continue;
            if (Keep(1) == 0) continue;
            var pt = pts[i].transform;
            var gi = Spawn(pm, pf, 1, pt.position, pt.rotation);
            if (gi == null) continue;
            try { pts[i].PlaceGear(gi, true); } catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] rack {ex.Message}"); }
            placed++;
        }
        if (pts.Count < p.Rack.Length) ModMain.Log?.Warning($"[MoreBunkers] gun rack has {pts.Count} hooks for {p.Rack.Length} rifles");
    }

    // 一排立着靠墙的东西(弓)
    private static void FillLine(PlayerManager pm, Piece p, float refY, Vector3 off, ref int placed)
    {
        var dir = Layouts.FaceDir(p.LineDir);
        var fwd = Layouts.FaceDir(p.Face);
        // 薄的一面顺着这一排,弓身垂直于墙,后沿贴墙
        var rot = Quaternion.Euler(0f, p.LineDir, 0f);
        var ours = _root != null ? _root.transform : null;
        for (int i = 0; i < p.Items.Length; i++)
        {
            var pf = Gear(p.Items[i]);
            if (pf == null) continue;
            if (Keep(1) == 0) continue;
            var bx = Layouts.ItemBox(pf);
            var c = new Vector3(p.X, 0f, p.Z) + off + dir * (p.LineGap * i);
            float floor = Layouts.FloorAt(c.x, c.z, refY, ours);
            float back = float.MaxValue;
            var e = bx.extents;
            for (int k = 0; k < 8; k++)
            {
                var q = rot * (bx.center + new Vector3((k & 1) == 0 ? -e.x : e.x, (k & 2) == 0 ? -e.y : e.y, (k & 4) == 0 ? -e.z : e.z));
                back = Mathf.Min(back, Vector3.Dot(q, fwd));
            }
            var pos = c - dir * Vector3.Dot(rot * bx.center, dir);
            var from = new Vector3(c.x, floor + 0.6f, c.z) + fwd * 0.5f;
            if (Layouts.Ray(from, -fwd, 2.5f, ours, true, out var hit))
                pos += fwd * (Vector3.Dot(hit.point - pos, fwd) + 0.03f - back);
            else pos -= fwd * Vector3.Dot(rot * bx.center, fwd);
            pos.y = floor + 0.004f - bx.min.y;
            if (Spawn(pm, pf, 1, pos, rot) != null) placed++;
        }
    }

    private static GearItem Spawn(PlayerManager pm, GearItem pf, int units, Vector3 pos, Quaternion rot)
    {
        var gi = pm.InstantiateItemAtLocation(pf, units, pos, false);
        if (gi == null) return null;
        gi.transform.SetPositionAndRotation(pos, rot);
        Fresh(gi, units);
        return gi;
    }

    // 能叠的进箱子是一堆:箭这类按根,别的按件乘每件的单位
    private static void AddToBox(Container c, string gear, int n)
    {
        var pf = Gear(gear);
        if (pf == null || n <= 0) return;
        int ok = 0;
        if (pf.m_StackableItem != null) { if (AddToBox(c, pf, IsBundled(gear, pf) ? n : n * Pack(pf))) ok = n; }
        else for (int k = 0; k < n; k++) if (AddToBox(c, pf, 1)) ok++;
        if (ok < n) ModMain.Log?.Warning($"[MoreBunkers] box {c.name}: {gear} {ok} of {n} went in");
    }

    private static bool AddToBox(Container c, GearItem pf, int units)
    {
        try
        {
            var before = new Il2CppSystem.Collections.Generic.List<GearItem>();
            c.GetItems(before);
            var seen = new HashSet<IntPtr>();
            for (int i = 0; i < before.Count; i++) if (before[i] != null) seen.Add(before[i].Pointer);
            c.InstantiateGearPrefabInContainer(pf.gameObject);
            var after = new Il2CppSystem.Collections.Generic.List<GearItem>();
            c.GetItems(after);
            for (int i = 0; i < after.Count; i++)
                if (after[i] != null && !seen.Contains(after[i].Pointer)) { Fresh(after[i], units); return true; }
            return after.Count > before.Count;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] box {c.name} {pf.name}: {ex.Message}"); return false; }
    }

    private static void Fresh(GearItem gi, int units)
    {
        try { gi.SkipSpawnChanceRollInitialDecayAndAutoEvolve(); } catch { }
        try { gi.SetNormalizedHP(1f, true); } catch { }
        // 只给 1 也要写,不然留着预制件的默认值(咖啡罐 5、木火柴 12)
        if (gi.m_StackableItem != null && units >= 1) gi.m_StackableItem.m_Units = units;
        if (gi.name.StartsWith("GEAR_Jerrycan") && gi.m_LiquidItem != null) FillKerosene(gi.m_LiquidItem);
    }

    private static bool _canLogged;

    // 汽油桶刷出来是空的或者只有一点,灌满煤油
    private static void FillKerosene(LiquidItem li)
    {
        try
        {
            try { li.m_LiquidType = Il2CppTLD.Gear.LiquidType.GetKerosene(); } catch { }
            li.m_Liquid = li.m_LiquidCapacity;
            if (!_canLogged) { _canLogged = true; ModMain.Log?.Msg($"[MoreBunkers] jerrycan filled: {li.m_Liquid / Il2CppTLD.IntBackedUnit.ItemLiquidVolume.Liter:F1} L"); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] jerrycan {ex.Message}"); }
    }
}
