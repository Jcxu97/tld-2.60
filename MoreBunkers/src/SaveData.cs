using System;
using System.Collections.Generic;
using System.Text.Json;
using Il2Cpp;
using ModData;

namespace MoreBunkers;

internal class BunkerFile
{
    public int version = 1;
    // 地堡 id -> 这个存档选中的候选图下标
    public Dictionary<string, int> region = new();
    // 地堡 id -> 找到的位置 x, y, z, 朝向
    public Dictionary<string, float[]> pos = new();
    // 已经摆过东西的地堡 id
    public List<string> stocked = new();
    // 地堡 id/器械 id -> 器械位置 x, y, z, 朝向
    public Dictionary<string, float[]> station = new();
    // 地堡 id -> 游戏给内部场景用的存档名
    public Dictionary<string, string> interior = new();
    // 地堡 id/摆件序号 -> 箱子里的东西(游戏自己的格式)
    public Dictionary<string, string> boxes = new();
    // 地堡 id -> 上次布置时的布置签名
    public Dictionary<string, string> layout = new();
    // 被玩家用安全屋模式拿走或挪出去的摆件 -> "预制件名|x,y,z"(拿进背包或拆掉的没有坐标);之后归游戏管,不再重摆
    public Dictionary<string, string> handed = new();
    // 玩家在原地挪过的摆件:新位置记在 station 里,下次照新位置摆
    public List<string> moved = new();
    // 地堡 id -> 摆货架时的内部存档名;存档名变了说明是一份新的内部场景,货架要重新摆
    public Dictionary<string, string> stockedSave = new();
}

internal static class SaveData
{
    private static readonly ModDataManager Manager = new("MoreBunkers");
    private const string Tag = "bunkers";
    private static readonly JsonSerializerOptions JsonOpts = new() { IncludeFields = true };

    internal static BunkerFile Current = new();
    private static string _loadedSave;

    private static bool _saveWarned;

    internal static void Save()
    {
        try
        {
            if (!Manager.Save(JsonSerializer.Serialize(Current, JsonOpts), Tag) && !_saveWarned)
            {
                _saveWarned = true;
                ModMain.Log?.Warning("[MoreBunkers] save data not written yet (the save slot is not open)");
            }
        }
        catch (Exception ex) { ModMain.Log?.Error($"[MoreBunkers] save failed: {ex.Message}"); }
    }

    // 每进一个场景调一次,只在换了存档时真读
    internal static void LoadIfNewSession()
    {
        string name = CurrentSaveName();
        if (_loadedSave != null && _loadedSave == name) return;
        _loadedSave = name;
        try
        {
            string json = Manager.Load(Tag);
            Current = string.IsNullOrEmpty(json) ? new BunkerFile() : JsonSerializer.Deserialize<BunkerFile>(json, JsonOpts) ?? new BunkerFile();
            Current.region ??= new Dictionary<string, int>();
            Current.stocked ??= new List<string>();
            Current.pos ??= new Dictionary<string, float[]>();
            Current.station ??= new Dictionary<string, float[]>();
            Current.interior ??= new Dictionary<string, string>();
            Current.boxes ??= new Dictionary<string, string>();
            Current.layout ??= new Dictionary<string, string>();
            Current.handed ??= new Dictionary<string, string>();
            Current.moved ??= new List<string>();
            Current.stockedSave ??= new Dictionary<string, string>();
        }
        catch (Exception ex)
        {
            // 读不了的原文另存一份,别被下一次存档用空数据盖掉
            ModMain.Log?.Error($"[MoreBunkers] load failed, start empty (old data kept as {Tag}_broken): {ex.Message}");
            try { Manager.Save(Manager.Load(Tag) ?? "", Tag + "_broken"); } catch { }
            Current = new BunkerFile();
        }
        ModMain.Log?.Msg($"[MoreBunkers] save data loaded ({name}): {Current.region.Count} regions picked, {Current.stocked.Count} stocked");
    }

    internal static void ForgetSession()
    {
        _loadedSave = null;
        Current = new BunkerFile();
    }

    private static string CurrentSaveName()
    {
        try { return SaveGameSystem.GetCurrentSaveName() ?? ""; }
        catch { return ""; }
    }
}
