using System;
using System.Collections.Generic;
using System.Text.Json;
using Il2Cpp;
using Il2CppTLD.Trader;
using ModData;
using UnityEngine;

namespace TraderMoving;

// 一条搬运记录。故意存得极简 —— 已核实 TraderRadio 和 ExchangeBox 都没有
// Serialize/Deserialize,自身无存档状态;所有交易进度在 TraderManager 的
// 全局存档里(GlobalSaveGameFormat.m_TraderSerialized)。所以只需要记
// "它现在在哪个场景的哪个位置"。
[Serializable]
internal class PlacementEntry
{
    public string kind = "";      // "Radio" / "ExchangeBox"
    public string scene = "";     // 所在场景(GameManager.m_ActiveScene)
    public float px, py, pz;      // 位置
    public float rx, ry, rz, rw;  // 旋转

    public Vector3 Pos => new Vector3(px, py, pz);
    public Quaternion Rot => new Quaternion(rx, ry, rz, rw);

    internal void SetPos(Vector3 v) { px = v.x; py = v.y; pz = v.z; }
    internal void SetRot(Quaternion q) { rx = q.x; ry = q.y; rz = q.z; rw = q.w; }
}

[Serializable]
internal class PlacementFile
{
    public List<PlacementEntry> entries = new();

    // 收进背包的东西不在场景里,读档时要跳过位置恢复。
    // 背包内容本身由 SCPlus 的存档管(carryables_carried),这里只记状态。
    public bool radioStowed;
    public bool boxStowed;
}

internal static class SaveData
{
    // ModDataManager 按 mod 名分文件,和 SCPlus 物理隔离。
    // 【绝不复用 SCPlus 的 "carryables" tag】,也不用它的 @type。
    private static readonly ModDataManager Manager = new("TraderMoving");
    private const string Tag = "placement";

    // IncludeFields:PlacementEntry 用的是公开字段不是属性,和 TldHacks 存档的做法一致
    private static readonly JsonSerializerOptions JsonOpts = new() { IncludeFields = true };

    // 运行时记录:哪些对象被搬到了非原生位置
    internal static PlacementFile Current = new();

    internal static void Save()
    {
        try
        {
            // 把当前场景里被搬过的对象位置刷新一遍
            RefreshFromScene();
            Current.radioStowed = StowRecord.RadioStowed;
            Current.boxStowed = StowRecord.BoxStowed;
            string json = JsonSerializer.Serialize(Current, JsonOpts);
            Manager.Save(json, Tag);
            ModMain.Log?.Msg($"[TraderMoving] 存档写入 {Current.entries.Count} 条");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[TraderMoving] Save 失败: {ex}");
        }
    }

    internal static void Load()
    {
        try
        {
            string json = Manager.Load(Tag);
            if (string.IsNullOrEmpty(json)) { Current = new PlacementFile(); return; }
            Current = JsonSerializer.Deserialize<PlacementFile>(json, JsonOpts) ?? new PlacementFile();
            StowRecord.RadioStowed = Current.radioStowed;
            StowRecord.BoxStowed = Current.boxStowed;
            ModMain.Log?.Msg($"[TraderMoving] 存档读入 {Current.entries.Count} 条"
                           + $"(背包中: 无线电={Current.radioStowed} 交易箱={Current.boxStowed})");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[TraderMoving] Load 失败,按空处理: {ex}");
            Current = new PlacementFile();
        }
    }

    // 把当前场景里找得到的无线电/交易箱的实际位置写进记录。
    // 只记【被搬过的】—— 没搬过的对象让游戏自己管,不插手。
    private static void RefreshFromScene()
    {
        string scene = GameManager.m_ActiveScene;
        if (string.IsNullOrEmpty(scene)) return;

        // 正在搬着的那个:记玩家位置(存档时它跟着玩家)
        if (CarryState.IsCarrying && CarryState.CarriedObj != null)
        {
            var e = Upsert(CarryState.Kind.ToString());
            e.scene = scene;
            e.SetPos(CarryState.CarriedObj.transform.position);
            e.SetRot(CarryState.CarriedObj.transform.rotation);
            return;
        }

        // 已经放下的:如果记录里有它且就在本场景,刷新成实际位置
        foreach (var e in Current.entries)
        {
            if (e.scene != scene) continue;
            var obj = FindInScene(e.kind);
            if (obj == null) continue;
            e.SetPos(obj.transform.position);
            e.SetRot(obj.transform.rotation);
        }
    }

    // 读档 / 进场景后,把记录里属于本场景的对象搬到记录位置。
    internal static void ApplyToScene()
    {
        string scene = GameManager.m_ActiveScene;
        if (string.IsNullOrEmpty(scene)) return;

        foreach (var e in Current.entries)
        {
            if (e.scene != scene) continue;

            // 在背包里的东西不在场景里,别去摆它 —— 由 SCPlus 的背包存档负责
            if (StowRecord.IsStowed(e.kind))
            {
                ModMain.Log?.Msg($"[TraderMoving] {e.kind} 在背包中,跳过位置恢复");
                continue;
            }

            var obj = FindInScene(e.kind);
            if (obj == null)
            {
                ModMain.Log?.Msg($"[TraderMoving] {e.kind} 记录指向本场景({scene})但场景里没找到,跳过");
                continue;
            }
            obj.transform.SetPositionAndRotation(e.Pos, e.Rot);
            ModMain.Log?.Msg($"[TraderMoving] {e.kind} 已就位 @ {scene} {e.Pos}");
        }
    }

    // 按组件类型在当前已加载场景里找。
    // 注意:全局唯一性假设 —— TraderManager.m_ExchangeBoxInScene 没有 [SerializeField],
    // 只能是运行时 FindObjectOfType 的缓存;社区代码(ShowTraderTrust、以及 TldHacks
    // 自己的 IntegratedPatches8)一律这么找。所以同一时刻只能有一台激活的无线电。
    internal static GameObject FindInScene(string kind)
    {
        try
        {
            if (kind == CarryKind.Radio.ToString())
            {
                var r = UnityEngine.Object.FindObjectOfType<TraderRadio>();
                return r != null ? ((Component)r).gameObject : null;
            }
            if (kind == CarryKind.ExchangeBox.ToString())
            {
                var b = UnityEngine.Object.FindObjectOfType<ExchangeBox>();
                return b != null ? ((Component)b).gameObject : null;
            }
        }
        catch { }
        return null;
    }

    private static PlacementEntry Upsert(string kind)
    {
        foreach (var e in Current.entries)
            if (e.kind == kind) return e;
        var ne = new PlacementEntry { kind = kind };
        Current.entries.Add(ne);
        return ne;
    }
}
