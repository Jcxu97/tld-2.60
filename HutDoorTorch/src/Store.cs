using System;
using System.Collections.Generic;
using System.Text.Json;
using HarmonyLib;
using Il2Cpp;
using ModData;
using UnityEngine;

namespace HutDoorTorch;

[Serializable]
internal class DoorRecord
{
    public string scene = "";
    public float x, z;       // 小屋根物体的位置,同一个场景里用它认是哪间
    public bool open;
}

[Serializable]
internal class TorchRecord
{
    public string scene = "";
    public float px, py, pz;
    public float rx, ry, rz, rw = 1f;

    internal Vector3 Pos => new(px, py, pz);
    internal Quaternion Rot => new(rx, ry, rz, rw);
}

[Serializable]
internal class StoreFile
{
    public int version = 1;
    public List<DoorRecord> doors = new();
    public List<TorchRecord> torches = new();
}

// 装上的门和挂上的火把都不归游戏存档管,记在 mod 自己的存档里,进场景时照着摆出来
internal static class Store
{
    private static readonly ModDataManager Manager = new("HutDoorTorch");
    private const string Tag = "placed";
    private static readonly JsonSerializerOptions Opts = new() { IncludeFields = true };

    internal static StoreFile Data = new();
    private static string _loaded;

    internal static string Scene
    {
        get { try { return GameManager.m_ActiveScene ?? ""; } catch { return ""; } }
    }

    internal static void Save()
    {
        try
        {
            Manager.Save(JsonSerializer.Serialize(Data, Opts), Tag);
            _loaded = SaveName();
        }
        catch (Exception ex) { ModMain.Log.Error("存档写入失败: " + ex); }
    }

    internal static void LoadIfNewSession()
    {
        string name = SaveName();
        if (_loaded != null && _loaded == name) return;
        _loaded = name;
        try
        {
            string json = Manager.Load(Tag);
            Data = string.IsNullOrEmpty(json) ? new StoreFile() : JsonSerializer.Deserialize<StoreFile>(json, Opts) ?? new StoreFile();
            Data.doors ??= new();
            Data.torches ??= new();
        }
        catch (Exception ex)
        {
            ModMain.Log.Error("存档读入失败,按空处理: " + ex.Message);
            Data = new StoreFile();
        }
        ModMain.Log.Msg($"存档读入({name}):门 {Data.doors.Count} 扇,火把 {Data.torches.Count} 支");
    }

    internal static void Forget() { _loaded = null; Data = new StoreFile(); }

    private static string SaveName()
    {
        try { return SaveGameSystem.GetCurrentSaveName() ?? ""; } catch { return ""; }
    }
}

[HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.SaveSceneData), new Type[] { typeof(SlotData), typeof(string) })]
internal static class Patch_SaveSceneData
{
    private static void Postfix() => Store.Save();
}

[HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.LoadSceneData), new Type[] { typeof(string), typeof(string) })]
internal static class Patch_LoadSceneData
{
    private static void Prefix() => Store.LoadIfNewSession();
}
