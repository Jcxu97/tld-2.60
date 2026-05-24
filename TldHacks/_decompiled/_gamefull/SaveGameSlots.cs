using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200091D")]
public class SaveGameSlots
{
	[Token(Token = "0x200091E")]
	public enum Timestamp
	{
		[Token(Token = "0x4005EEF")]
		Update,
		[Token(Token = "0x4005EF0")]
		Unchanged
	}

	[Token(Token = "0x200091F")]
	private class SaveSlotTypeEqualityComparer : IEqualityComparer<SaveSlotType>
	{
		[Token(Token = "0x4005EF1")]
		public static readonly SaveSlotTypeEqualityComparer Comparer;

		[Token(Token = "0x600532D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		private SaveSlotTypeEqualityComparer()
		{
		}

		[Token(Token = "0x600532E")]
		[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
		public bool Equals(SaveSlotType x, SaveSlotType y)
		{
			return false;
		}

		[Token(Token = "0x600532F")]
		[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
		public int GetHashCode(SaveSlotType saveSlotType)
		{
			return 0;
		}
	}

	[Token(Token = "0x2000920")]
	private class SaveSlotCounter
	{
		[Token(Token = "0x4005EF2")]
		private const string TOTAL = "total";

		[Token(Token = "0x4005EF3")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, int> m_Counts;

		[Token(Token = "0x4005EF4")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, object> m_Events;

		[Token(Token = "0x6005331")]
		[Address(RVA = "0xE5B590", Offset = "0xE5A390", Length = "0xCB")]
		public void Reset()
		{
		}

		[Token(Token = "0x6005332")]
		[Address(RVA = "0xE5B660", Offset = "0xE5A460", Length = "0x166")]
		public void AddSlot(string name)
		{
		}

		[Token(Token = "0x6005333")]
		[Address(RVA = "0xE5B7D0", Offset = "0xE5A5D0", Length = "0x220")]
		public Dictionary<string, object> FinalizeEventData()
		{
			return null;
		}

		[Token(Token = "0x6005334")]
		[Address(RVA = "0xE5BA00", Offset = "0xE5A800", Length = "0x159")]
		public SaveSlotCounter()
		{
		}
	}

	[Token(Token = "0x4005EDF")]
	public static string AUTOSAVE_SLOT_NAME;

	[Token(Token = "0x4005EE0")]
	public static string SANDBOX_SLOT_PREFIX;

	[Token(Token = "0x4005EE1")]
	public static string STORY_SLOT_PREFIX;

	[Token(Token = "0x4005EE2")]
	public static string CHALLENGE_SLOT_PREFIX;

	[Token(Token = "0x4005EE3")]
	public static string CHECKPOINT_SLOT_PREFIX;

	[Token(Token = "0x4005EE4")]
	public static string AUTOSAVE_SLOT_PREFIX;

	[Token(Token = "0x4005EE5")]
	public static string QUICKSAVE_SLOT_PREFIX;

	[Token(Token = "0x4005EE6")]
	public static int MAX_AUTOSAVES;

	[Token(Token = "0x4005EE7")]
	private static SlotData m_AutoSaveSlot;

	[Token(Token = "0x4005EE8")]
	private static List<SlotData> m_SaveSlots;

	[Token(Token = "0x4005EE9")]
	private static HashSet<string> m_InvalidSlots;

	[Token(Token = "0x4005EEA")]
	public static Episode m_LastPlayedEpisode;

	[Token(Token = "0x4005EEB")]
	private static DateTime m_LastPlayedEpisodeTimeStamp;

	[Token(Token = "0x4005EED")]
	private static Dictionary<string, string> m_SlotDisplayNames;

	[Token(Token = "0x17000374")]
	[field: Token(Token = "0x4005EEC")]
	public static bool HasLoadedAllSavedGameFiles
	{
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0xE53520", Offset = "0xE52320", Length = "0x54")]
		get;
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0xE53580", Offset = "0xE52380", Length = "0x59")]
		private set;
	}

	[Token(Token = "0x60052ED")]
	[Address(RVA = "0xE535E0", Offset = "0xE523E0", Length = "0x1A5")]
	public static void Init()
	{
	}

	[Token(Token = "0x60052EE")]
	[Address(RVA = "0xE53790", Offset = "0xE52590", Length = "0x24F")]
	public static void ReInit()
	{
	}

	[Token(Token = "0x60052EF")]
	[Address(RVA = "0xE539E0", Offset = "0xE527E0", Length = "0x260")]
	public static void LoadAllSavedGameFiles()
	{
	}

	[Token(Token = "0x60052F0")]
	[Address(RVA = "0xE53C50", Offset = "0xE52A50", Length = "0x1CC")]
	public static uint GetUnusedGameId()
	{
		return 0u;
	}

	[Token(Token = "0x60052F1")]
	[Address(RVA = "0xE53E20", Offset = "0xE52C20", Length = "0xB1")]
	public static bool IsValidSavedGameName(string name)
	{
		return false;
	}

	[Token(Token = "0x60052F2")]
	[Address(RVA = "0xE53EE0", Offset = "0xE52CE0", Length = "0x12B")]
	public static bool IsStorySavedGameName(string name)
	{
		return false;
	}

	[Token(Token = "0x60052F3")]
	[Address(RVA = "0xE54010", Offset = "0xE52E10", Length = "0x1A6")]
	public static bool SaveExists(SaveSlotType slotType, uint gameId)
	{
		return false;
	}

	[Token(Token = "0x60052F4")]
	[Address(RVA = "0xE541C0", Offset = "0xE52FC0", Length = "0x1B2")]
	public static bool SaveExists(string fileName)
	{
		return false;
	}

	[Token(Token = "0x60052F5")]
	[Address(RVA = "0xE54380", Offset = "0xE53180", Length = "0x1D3")]
	public static void GetSlotDataFor(SaveSlotType slotType, ref List<SlotData> slots)
	{
	}

	[Token(Token = "0x60052F6")]
	[Address(RVA = "0xE54560", Offset = "0xE53360", Length = "0x3A2")]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[Token(Token = "0x60052F7")]
	[Address(RVA = "0xE54910", Offset = "0xE53710", Length = "0x38F")]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[Token(Token = "0x60052F8")]
	[Address(RVA = "0xE54CA0", Offset = "0xE53AA0", Length = "0xB9")]
	public static bool SlotsAreLoading(SaveSlotType slotType)
	{
		return false;
	}

	[Token(Token = "0x60052F9")]
	[Address(RVA = "0xE54D60", Offset = "0xE53B60", Length = "0x103")]
	public static void SetLoadingPriority(SaveSlotType slotType)
	{
	}

	[Token(Token = "0x60052FA")]
	[Address(RVA = "0xE54E70", Offset = "0xE53C70", Length = "0xE7")]
	public static bool WriteSlotToDisk(string slotName)
	{
		return false;
	}

	[Token(Token = "0x60052FB")]
	[Address(RVA = "0xE54F60", Offset = "0xE53D60", Length = "0x27B")]
	public static void WriteSlotToDisk(SlotData slot, Timestamp timestampState)
	{
	}

	[Token(Token = "0x60052FC")]
	[Address(RVA = "0xE551E0", Offset = "0xE53FE0", Length = "0x55")]
	public static bool HasSaveSlot(string slotname)
	{
		return false;
	}

	[Token(Token = "0x60052FD")]
	[Address(RVA = "0xE55240", Offset = "0xE54040", Length = "0xEF")]
	public static DateTime GetTimestampForSlot(string slotname)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60052FE")]
	[Address(RVA = "0xE55330", Offset = "0xE54130", Length = "0xA6")]
	public static void AddInvalidSlotName(string name)
	{
	}

	[Token(Token = "0x60052FF")]
	[Address(RVA = "0xE553E0", Offset = "0xE541E0", Length = "0x22A")]
	public static bool CreateSlotFromData(string dataAsString, string filename, int compressedSizeBytes)
	{
		return false;
	}

	[Token(Token = "0x6005300")]
	[Address(RVA = "0xE55610", Offset = "0xE54410", Length = "0x2C6")]
	public static void AddSlotData(SlotData sd)
	{
	}

	[Token(Token = "0x6005301")]
	[Address(RVA = "0xE558E0", Offset = "0xE546E0", Length = "0x2BF")]
	public static SlotData CreateSlot(string slotname, SaveSlotType gameMode, uint gameId, Episode episode)
	{
		return null;
	}

	[Token(Token = "0x6005302")]
	[Address(RVA = "0xE55BA0", Offset = "0xE549A0", Length = "0x17F")]
	public static void UpdateLastEpisodePlayedFromSlot(string dataAsString)
	{
	}

	[Token(Token = "0x6005303")]
	[Address(RVA = "0xE55D20", Offset = "0xE54B20", Length = "0x83")]
	public static void ClearAutoSave()
	{
	}

	[Token(Token = "0x6005304")]
	[Address(RVA = "0xE55DB0", Offset = "0xE54BB0", Length = "0x2A2")]
	public static bool DeleteSlot(string slotName)
	{
		return false;
	}

	[Token(Token = "0x6005305")]
	[Address(RVA = "0xE56060", Offset = "0xE54E60", Length = "0x320")]
	private static SlotData FindNewestAssociatedSaveSlot(SlotData source)
	{
		return null;
	}

	[Token(Token = "0x6005306")]
	[Address(RVA = "0xE56390", Offset = "0xE55190", Length = "0x294")]
	private static void RebaseMatchingSaves(SlotData source, SlotData target)
	{
	}

	[Token(Token = "0x6005307")]
	[Address(RVA = "0xE56630", Offset = "0xE55430", Length = "0x1C7")]
	private static bool HasCheckpointSave(SlotData slot)
	{
		return false;
	}

	[Token(Token = "0x6005308")]
	[Address(RVA = "0xE56800", Offset = "0xE55600", Length = "0x21C")]
	private static void ReassignCheckpointSaves(SlotData source, SlotData target)
	{
	}

	[Token(Token = "0x6005309")]
	[Address(RVA = "0xE56A20", Offset = "0xE55820", Length = "0x149")]
	public static void DeleteAllSlotsForGameId(uint gameId)
	{
	}

	[Token(Token = "0x600530A")]
	[Address(RVA = "0xE56B70", Offset = "0xE55970", Length = "0x1E5")]
	private static void DeleteSlot(SlotData slotData)
	{
	}

	[Token(Token = "0x600530B")]
	[Address(RVA = "0xE56D60", Offset = "0xE55B60", Length = "0x6D7")]
	public static bool CopyData(string sourceSlotname, string destSlotname, SaveSlotType gameMode = SaveSlotType.UNKNOWN)
	{
		return false;
	}

	[Token(Token = "0x600530C")]
	[Address(RVA = "0xE57440", Offset = "0xE56240", Length = "0x315")]
	public static List<string> GetExtraInstancesOfFilename(string slotname, string filename)
	{
		return null;
	}

	[Token(Token = "0x600530D")]
	[Address(RVA = "0xE57760", Offset = "0xE56560", Length = "0xD0")]
	public static bool HasFilenameInSlot(string slotname, string filename)
	{
		return false;
	}

	[Token(Token = "0x600530E")]
	[Address(RVA = "0xE57840", Offset = "0xE56640", Length = "0x8E")]
	public static void DeleteFileFromSlot(string slotname, string filename)
	{
	}

	[Token(Token = "0x600530F")]
	[Address(RVA = "0x19E9500", Offset = "0x19E8300", Length = "0x9A")]
	public static bool TryLoadDataFromSlot<T>(string slotname, string filename, out T data)
	{
		data = default(T);
		return false;
	}

	[Token(Token = "0x6005310")]
	[Address(RVA = "0x19E9650", Offset = "0x19E8450", Length = "0x2F9")]
	public static bool TryLoadDataFromSlotUsingGuid<T>(string slotname, string guid, out T data)
	{
		data = default(T);
		return false;
	}

	[Token(Token = "0x6005311")]
	[Address(RVA = "0xE578D0", Offset = "0xE566D0", Length = "0x1FA")]
	public static bool FindOrCreateSlotData(string slotname, SaveSlotType gameMode, Episode episode, uint saveId, out SlotData slot)
	{
		slot = null;
		return false;
	}

	[Token(Token = "0x6005312")]
	[Address(RVA = "0xE57AD0", Offset = "0xE568D0", Length = "0x10A")]
	public static bool SaveDataToSlot(SlotData slot, string key, object data)
	{
		return false;
	}

	[Token(Token = "0x6005313")]
	[Address(RVA = "0xE57BE0", Offset = "0xE569E0", Length = "0x374")]
	public static string BuildSlotName(Episode episode, SaveSlotType slotType, uint n)
	{
		return null;
	}

	[Token(Token = "0x6005314")]
	[Address(RVA = "0xE57F60", Offset = "0xE56D60", Length = "0x265")]
	public static SaveSlotType GetSaveSlotTypeFromName(string name)
	{
		return default(SaveSlotType);
	}

	[Token(Token = "0x6005315")]
	[Address(RVA = "0xE581D0", Offset = "0xE56FD0", Length = "0x1EE")]
	public static string GetSlotPrefix(SaveSlotType slotType)
	{
		return null;
	}

	[Token(Token = "0x6005316")]
	[Address(RVA = "0xE583C0", Offset = "0xE571C0", Length = "0x10A")]
	public static string GetUserDefinedSlotName(string slotName)
	{
		return null;
	}

	[Token(Token = "0x6005317")]
	[Address(RVA = "0xE584D0", Offset = "0xE572D0", Length = "0x10F")]
	public static bool SetUserDefinedSlotName(string slotName, string displayName)
	{
		return false;
	}

	[Token(Token = "0x6005318")]
	[Address(RVA = "0xE585E0", Offset = "0xE573E0", Length = "0x128")]
	public static void SaveUserDefinedSlotName(string slotName, string newUserDefinedName)
	{
	}

	[Token(Token = "0x6005319")]
	[Address(RVA = "0xE58710", Offset = "0xE57510", Length = "0x176")]
	public static void SetSlotDisplayName(string slotName, string displayName)
	{
	}

	[Token(Token = "0x600531A")]
	[Address(RVA = "0xE58890", Offset = "0xE57690", Length = "0xEE")]
	public static void ClearSlotDisplayName(string slotName)
	{
	}

	[Token(Token = "0x600531B")]
	[Address(RVA = "0xE58980", Offset = "0xE57780", Length = "0x3CD")]
	public static void AddGUIDToPrevSceneSave(string slotName, string sceneName, string guid)
	{
	}

	[Token(Token = "0x600531C")]
	[Address(RVA = "0xE58D50", Offset = "0xE57B50", Length = "0x103")]
	public static List<string> GetSceneKeysForCurrentSaveSlot()
	{
		return null;
	}

	[Token(Token = "0x600531D")]
	[Address(RVA = "0xE58E60", Offset = "0xE57C60", Length = "0x371")]
	public static string GetOldestAutosaveName(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x600531E")]
	[Address(RVA = "0xE591E0", Offset = "0xE57FE0", Length = "0x5E")]
	public static string GetBaseNameForSave(string name)
	{
		return null;
	}

	[Token(Token = "0x600531F")]
	[Address(RVA = "0xE59240", Offset = "0xE58040", Length = "0x1B3")]
	public static void SetBaseNameForSave(string name, string basename)
	{
	}

	[Token(Token = "0x6005320")]
	[Address(RVA = "0xE59400", Offset = "0xE58200", Length = "0xD5")]
	public static void SetBaseNameForSave(SlotData dest, SlotData source)
	{
	}

	[Token(Token = "0x6005321")]
	[Address(RVA = "0xE594E0", Offset = "0xE582E0", Length = "0x20C")]
	public static int GetNumSaveSlotsInUse()
	{
		return 0;
	}

	[Token(Token = "0x6005322")]
	[Address(RVA = "0xE596F0", Offset = "0xE584F0", Length = "0x21F")]
	public static SlotData GetSaveSlotFromName(string name)
	{
		return null;
	}

	[Token(Token = "0x6005323")]
	[Address(RVA = "0xE59910", Offset = "0xE58710", Length = "0x6F")]
	public static string GetCloudResourceName(string slotname)
	{
		return null;
	}

	[Token(Token = "0x6005324")]
	[Address(RVA = "0xE59980", Offset = "0xE58780", Length = "0x526")]
	public static SaveSlotInfo CreateSaveSlotInfo(SlotData slot)
	{
		return null;
	}

	[Token(Token = "0x6005325")]
	[Address(RVA = "0xE59EB0", Offset = "0xE58CB0", Length = "0x4D9")]
	private static bool FillSaveSlotInfo(SlotData slot, SaveSlotInfo saveSlotInfo)
	{
		return false;
	}

	[Token(Token = "0x6005326")]
	[Address(RVA = "0xE5A390", Offset = "0xE59190", Length = "0x32A")]
	public static void PrepareSaveSlotForLoad(string slotName, SaveSlotInfo saveSlotInfo)
	{
	}

	[Token(Token = "0x6005327")]
	[Address(RVA = "0xE5A6C0", Offset = "0xE594C0", Length = "0x34B")]
	public static void UpdateSlotGameMode(string slotName, ExperienceModeType currentMode, ExperienceModeType newMode)
	{
	}

	[Token(Token = "0x6005328")]
	[Address(RVA = "0xE5AA10", Offset = "0xE59810", Length = "0x1A8")]
	public static uint GetSaveSlotId(string name)
	{
		return 0u;
	}

	[Token(Token = "0x6005329")]
	[Address(RVA = "0xE5ABC0", Offset = "0xE599C0", Length = "0x197")]
	public static int GetSaveSlotsBytesUsed()
	{
		return 0;
	}

	[Token(Token = "0x600532A")]
	[Address(RVA = "0xE5AD60", Offset = "0xE59B60", Length = "0x192")]
	public static void HandleOnSlotSaved(string name, int compressedSizeBytes)
	{
	}

	[Token(Token = "0x600532B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SaveGameSlots()
	{
	}
}
