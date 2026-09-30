using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Il2Cpp;
using ModData;
using UnityEngine;

namespace TraderMoving;

// 一样东西(无线电或交易箱)的去向。
// 原版的无线电和交易箱都没有自己的存档,交易进度全在 TraderManager 的全局存档里,
// 所以这里只记"原件拿没拿走、现在放在哪",每次进场景按记录把世界摆回去。
[Serializable]
internal class ItemRecord
{
    public bool taken;             // 原版那件已经被拿走(原处隐藏)
    public string originObjScene = ""; // 原件所在的场景名(物体自己的 scene.name,如 CampOffice_DLC01)
    public float ox, oy, oz;       // 原件被拿走时的位置,同场景有多件时用来认
    public float orx, ory, orz, orw = 1f; // 原件的朝向,放回原处用
    public bool carrying;          // 正抱在手上
    public bool placed;            // 已经放下
    public string scene = "";      // 放下时的 GameManager.m_ActiveScene
    public float px, py, pz, yaw;
    public bool asReal;            // 只对无线电:放回原来的屋子,用的是原版那台

    public string carriedFrom = "";      // 抱起时所在的场景,交易箱放下后交易从这里改送
    public string originActiveScene = ""; // 原件所在的主场景(GameManager.m_ActiveScene),放回原处时交易改回这里

    [JsonIgnore] public Vector3 Origin => new Vector3(ox, oy, oz);
    [JsonIgnore] public Quaternion OriginRot => new Quaternion(orx, ory, orz, orw);
    [JsonIgnore] public Vector3 Pos => new Vector3(px, py, pz);
    [JsonIgnore] public Quaternion Rot => Quaternion.Euler(0f, yaw, 0f);

    // 无线电放下时只换偏航角,原件本来的倾斜保留
    [JsonIgnore] public Quaternion RadioRot
    {
        get
        {
            var o = OriginRot;
            if (o.x == 0f && o.y == 0f && o.z == 0f && o.w == 0f) return Rot;
            return Rot * Quaternion.Inverse(Quaternion.Euler(0f, o.eulerAngles.y, 0f)) * o;
        }
    }

    internal void SetOrigin(Vector3 v, Quaternion q) { ox = v.x; oy = v.y; oz = v.z; orx = q.x; ory = q.y; orz = q.z; orw = q.w; }
    internal void SetPlace(string s, Vector3 v, float y) { scene = s; px = v.x; py = v.y; pz = v.z; yaw = y; }

    internal void Clear()
    {
        taken = carrying = placed = asReal = false;
        originObjScene = scene = originActiveScene = carriedFrom = "";
        ox = oy = oz = px = py = pz = yaw = 0f;
        orx = ory = orz = 0f; orw = 1f;
    }
}

[Serializable]
internal class PlacementFile
{
    public int version = 2;
    public ItemRecord radio = new();
    public ItemRecord box = new();
}

internal static class SaveData
{
    // 按 mod 名单独一个文件,不和 SCPlus 的 carryables 混用
    private static readonly ModDataManager Manager = new("TraderMoving");
    private const string Tag = "placement";
    private static readonly JsonSerializerOptions JsonOpts = new() { IncludeFields = true };

    internal static PlacementFile Current = new();
    private static string _loadedSave;

    internal static ItemRecord Of(CarryKind kind) => kind == CarryKind.Radio ? Current.radio : Current.box;

    internal static void Save()
    {
        try
        {
            World.RefreshRealRadioPosition();
            Manager.Save(JsonSerializer.Serialize(Current, JsonOpts), Tag);
            _loadedSave = CurrentSaveName();
            ModMain.Log?.Msg($"[TraderMoving] 存档写入 | 无线电 {Describe(Current.radio)} | 交易箱 {Describe(Current.box)}");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[TraderMoving] Save 失败: {ex}"); }
    }

    // 读档时每进一个场景都会调一次,只在换了存档时真读,
    // 否则会把这次游戏里还没存盘的改动冲掉
    internal static void LoadIfNewSession()
    {
        string name = CurrentSaveName();
        if (_loadedSave != null && _loadedSave == name) return;
        _loadedSave = name;
        try
        {
            string json = Manager.Load(Tag);
            Current = string.IsNullOrEmpty(json)
                ? new PlacementFile()
                : JsonSerializer.Deserialize<PlacementFile>(json, JsonOpts) ?? new PlacementFile();
            Current.radio ??= new ItemRecord();
            Current.box ??= new ItemRecord();
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[TraderMoving] Load 失败,按空处理: {ex.Message}");
            Current = new PlacementFile();
        }
        CarryState.RestoreFromRecord();
        ModMain.Log?.Msg($"[TraderMoving] 存档读入({name}) | 无线电 {Describe(Current.radio)} | 交易箱 {Describe(Current.box)}");
    }

    internal static void InvalidateSession() => _loadedSave = null;

    internal static void ForgetSession()
    {
        _loadedSave = null;
        Current = new PlacementFile();
    }

    internal static string Describe(ItemRecord r)
    {
        if (r == null || !r.taken) return "原处";
        if (r.carrying) return "抱在手上";
        if (r.placed) return $"{r.scene} {r.Pos}{(r.asReal ? " (原版)" : "")}";
        return "已拿走";
    }

    private static string CurrentSaveName()
    {
        try { return SaveGameSystem.GetCurrentSaveName() ?? ""; }
        catch { return ""; }
    }
}
