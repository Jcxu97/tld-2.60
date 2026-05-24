using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using TLD.Logging;
using TLD.SaveState;
using UnityEngine;

[Token(Token = "0x2000922")]
public class SaveGameSystem
{
	[Token(Token = "0x2000923")]
	public delegate void SaveCompletedDelegate();

	[Token(Token = "0x2000924")]
	public class PhotoData
	{
		[Token(Token = "0x4005F30")]
		[FieldOffset(Offset = "0x10")]
		public string m_AssociatedSave;

		[Token(Token = "0x4005F31")]
		[FieldOffset(Offset = "0x18")]
		public byte[] m_JpegData;

		[Token(Token = "0x4005F32")]
		[FieldOffset(Offset = "0x20")]
		public int m_Width;

		[Token(Token = "0x4005F33")]
		[FieldOffset(Offset = "0x24")]
		public int m_Height;

		[Token(Token = "0x4005F34")]
		[FieldOffset(Offset = "0x28")]
		public TextureFormat m_TextureFormat;

		[Token(Token = "0x60053AC")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PhotoData()
		{
		}
	}

	[Token(Token = "0x2000925")]
	private enum PhotoLoadQueueRequestType
	{
		[Token(Token = "0x4005F36")]
		Delete,
		[Token(Token = "0x4005F37")]
		Load,
		[Token(Token = "0x4005F38")]
		Save,
		[Token(Token = "0x4005F39")]
		Purge
	}

	[Token(Token = "0x2000926")]
	private class PhotoLoadQueueEntry
	{
		[Token(Token = "0x4005F3A")]
		[FieldOffset(Offset = "0x10")]
		public PhotoLoadQueueRequestType m_RequestType;

		[Token(Token = "0x4005F3B")]
		[FieldOffset(Offset = "0x14")]
		public int m_PhotoIndex;

		[Token(Token = "0x4005F3C")]
		[FieldOffset(Offset = "0x18")]
		public PhotoData m_PhotoToSave;

		[Token(Token = "0x4005F3D")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D m_DestTexture;

		[Token(Token = "0x60053AD")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PhotoLoadQueueEntry()
		{
		}
	}

	[Token(Token = "0x2000927")]
	private class PhotoFile
	{
		[Token(Token = "0x4005F3E")]
		[FieldOffset(Offset = "0x10")]
		public string m_FileName;

		[Token(Token = "0x4005F3F")]
		[FieldOffset(Offset = "0x18")]
		public int m_SizeBytes;

		[Token(Token = "0x4005F40")]
		[FieldOffset(Offset = "0x1C")]
		public int m_NextPhotoIndex;

		[Token(Token = "0x4005F41")]
		[FieldOffset(Offset = "0x20")]
		public List<PhotoLoadQueueEntry> m_LoadQueue;

		[Token(Token = "0x60053AE")]
		[Address(RVA = "0xE75B40", Offset = "0xE74940", Length = "0xAD")]
		public PhotoFile()
		{
		}
	}

	[Token(Token = "0x2000928")]
	private enum UserInitializationStage
	{
		[Token(Token = "0x4005F43")]
		LoadingProfile,
		[Token(Token = "0x4005F44")]
		ValidatingProfile,
		[Token(Token = "0x4005F45")]
		LoadingSettings,
		[Token(Token = "0x4005F46")]
		Done
	}

	[CompilerGenerated]
	[Token(Token = "0x200092D")]
	private sealed class _003CSaveGameCoroutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005F4C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005F4D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005F4E")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4005F4F")]
		[FieldOffset(Offset = "0x28")]
		private Stopwatch _003Cwatch_003E5__2;

		[Token(Token = "0x17000379")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60053BB")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037A")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60053BD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60053B8")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CSaveGameCoroutine_003Ed__57(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60053BA")]
		[Address(RVA = "0xE75D10", Offset = "0xE74B10", Length = "0x366")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0xE76080", Offset = "0xE74E80", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x200092E")]
	private sealed class _003CSaveScreenshotDataCoroutine_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005F50")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005F51")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005F52")]
		[FieldOffset(Offset = "0x20")]
		private WaitForEndOfFrame _003CendOfFrame_003E5__2;

		[Token(Token = "0x4005F53")]
		[FieldOffset(Offset = "0x28")]
		private Texture2D _003Ct_003E5__3;

		[Token(Token = "0x1700037B")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60053C1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037C")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60053C3")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CSaveScreenshotDataCoroutine_003Ed__146(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60053C0")]
		[Address(RVA = "0xE760C0", Offset = "0xE74EC0", Length = "0x95E")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0xE76A20", Offset = "0xE75820", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4005EF8")]
	private static bool s_AsyncEnabled;

	[Token(Token = "0x4005EF9")]
	private static Queue<SlotData> s_AsyncSlotDataQueue;

	[Token(Token = "0x4005EFA")]
	private static Mutex s_AsyncSlotDataMutex;

	[Token(Token = "0x4005EFB")]
	private static bool s_CheckIsGameDataSaving;

	[Token(Token = "0x4005EFC")]
	private static Thread s_SavingThread;

	[Token(Token = "0x4005EFD")]
	private static EventWaitHandle s_WaitHandle;

	[Token(Token = "0x4005EFE")]
	private static bool s_HasSlotQueueData;

	[Token(Token = "0x4005EFF")]
	private static bool s_SavingThreadActive;

	[Token(Token = "0x4005F00")]
	private static Queue<string> s_ForcedSyncSlotQueue;

	[Token(Token = "0x4005F01")]
	private static Mutex s_ForcedSyncMutex;

	[Token(Token = "0x4005F02")]
	private static bool s_HasForcedSyncQueueData;

	[Token(Token = "0x4005F03")]
	private static float m_LastAutosave;

	[Token(Token = "0x4005F04")]
	private static BootSaveGameFormat m_BootSaveGameFormat;

	[Token(Token = "0x4005F05")]
	public static LogFilter s_LogFilter;

	[Token(Token = "0x4005F06")]
	public static string m_SlotToLoadOnStart;

	[Token(Token = "0x4005F07")]
	public static string m_MigrateSlotOnStart;

	[Token(Token = "0x4005F08")]
	public static bool m_CanMigrateSave;

	[Token(Token = "0x4005F09")]
	public static bool m_SceneRestoreInProgress;

	[Token(Token = "0x4005F0A")]
	public static bool m_DidSceneRestore;

	[Token(Token = "0x4005F0B")]
	public static int m_GlobalSaveGameFormatVersion;

	[Token(Token = "0x4005F0C")]
	public static int m_SceneSaveGameFormatVersion;

	[Token(Token = "0x4005F0D")]
	public static Episode m_CurrentEpisode;

	[Token(Token = "0x4005F0E")]
	public static SaveSlotType m_CurrentGameMode;

	[Token(Token = "0x4005F0F")]
	public static uint m_CurrentGameId;

	[Token(Token = "0x4005F10")]
	public static string m_CurrentSaveName;

	[Token(Token = "0x4005F11")]
	public static bool m_EnableSaveLoad;

	[Token(Token = "0x4005F12")]
	public static SaveCompletedDelegate m_OnSaveCompletedEvent;

	[Token(Token = "0x4005F13")]
	public static bool s_Initialized;

	[Token(Token = "0x4005F15")]
	private static bool s_DebugVerbose;

	[Token(Token = "0x4005F16")]
	private static GlobalSaveGameFormat m_GlobalSaveGameFormat;

	[Token(Token = "0x4005F17")]
	private static InfoSaveGameFormat m_InfoSaveGameFormat;

	[Token(Token = "0x4005F18")]
	private const string PHOTO_DISPLAYNAME = "Photo";

	[Token(Token = "0x4005F19")]
	private const string PHOTO_PREFIX = "photo";

	[Token(Token = "0x4005F1A")]
	private static List<PhotoFile> s_PhotoFiles;

	[Token(Token = "0x4005F1B")]
	public static bool s_PurgeUnreferencedPhotos;

	[Token(Token = "0x4005F1C")]
	private const string PROFILE_DISPLAYNAME = "Profile (Survival)";

	[Token(Token = "0x4005F1D")]
	public const string DEFAULT_PROFILE_FILENAME = "profile_survival";

	[Token(Token = "0x4005F1E")]
	public const string LEGACY_PROFILE_FILENAME = "user001";

	[Token(Token = "0x4005F1F")]
	private const int SPLIT_PROFILE_VERSION = 100;

	[Token(Token = "0x4005F20")]
	public static string s_ProfileFilename;

	[Token(Token = "0x4005F21")]
	public static string s_LegacyProfileFileName;

	[Token(Token = "0x4005F23")]
	private static SceneSaveGameFormat m_SceneSaveGameFormat;

	[Token(Token = "0x4005F24")]
	private static SlotData m_ScreenshotSlot;

	[Token(Token = "0x4005F25")]
	private static IEnumerator s_ScreenshotCoroutine;

	[Token(Token = "0x4005F26")]
	private static RenderTexture s_TemporaryRenderTexture;

	[Token(Token = "0x4005F27")]
	private static ScreenshotSaveGameFormat m_ScreenshotSaveGameFormat;

	[Token(Token = "0x4005F28")]
	private const string SETTINGS_DISPLAYNAME = "Settings (Survival)";

	[Token(Token = "0x4005F29")]
	public const string DEFAULT_SETTINGS_FILENAME = "settings_survival";

	[Token(Token = "0x4005F2A")]
	public const string LEGACY_SETTINGS_FILENAME = "usercfg";

	[Token(Token = "0x4005F2B")]
	public static string s_SettingsFilename;

	[Token(Token = "0x4005F2C")]
	public static string s_LegacySettingsFileName;

	[Token(Token = "0x4005F2D")]
	private static string s_MigratedSettingsData;

	[Token(Token = "0x4005F2F")]
	private static UserInitializationStage m_InitializationStage;

	[Token(Token = "0x17000375")]
	[field: Token(Token = "0x4005F14")]
	public static int LegacySaveBytesUsed
	{
		[Token(Token = "0x600534B")]
		[Address(RVA = "0xE5DF50", Offset = "0xE5CD50", Length = "0x56")]
		get;
		[Token(Token = "0x600534C")]
		[Address(RVA = "0xE5DFB0", Offset = "0xE5CDB0", Length = "0x5B")]
		set;
	}

	[Token(Token = "0x17000376")]
	[field: Token(Token = "0x4005F22")]
	private static bool IsLoadingUserProfile
	{
		[Token(Token = "0x6005383")]
		[Address(RVA = "0xE6E580", Offset = "0xE6D380", Length = "0x57")]
		get;
		[Token(Token = "0x6005384")]
		[Address(RVA = "0xE6E5E0", Offset = "0xE6D3E0", Length = "0x5C")]
		set;
	}

	[Token(Token = "0x17000377")]
	[field: Token(Token = "0x4005F2E")]
	private static bool IsLoadingUserSettings
	{
		[Token(Token = "0x6005399")]
		[Address(RVA = "0xE73C80", Offset = "0xE72A80", Length = "0x57")]
		get;
		[Token(Token = "0x600539A")]
		[Address(RVA = "0xE73CE0", Offset = "0xE72AE0", Length = "0x5C")]
		set;
	}

	[Token(Token = "0x17000378")]
	public static bool IsInitializingUser
	{
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0xE74AB0", Offset = "0xE738B0", Length = "0x5A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6005339")]
	[Address(RVA = "0xE5BD60", Offset = "0xE5AB60", Length = "0x53")]
	public static bool IsAsyncEnabled()
	{
		return false;
	}

	[Token(Token = "0x600533A")]
	[Address(RVA = "0xE5BDC0", Offset = "0xE5ABC0", Length = "0xB6")]
	public static bool IsAsyncSaveRunning()
	{
		return false;
	}

	[Token(Token = "0x600533B")]
	[Address(RVA = "0xE5BE80", Offset = "0xE5AC80", Length = "0xED")]
	public static void WaitForAsyncSave()
	{
	}

	[Token(Token = "0x600533C")]
	[Address(RVA = "0xE5BF70", Offset = "0xE5AD70", Length = "0x9F")]
	public static void SetAsyncEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600533D")]
	[Address(RVA = "0xE5C010", Offset = "0xE5AE10", Length = "0xCD")]
	public static void ShutdownAsync()
	{
	}

	[Token(Token = "0x600533E")]
	[Address(RVA = "0xE5C0E0", Offset = "0xE5AEE0", Length = "0x1BF")]
	private static void EnqueueAsyncSave(string slotName)
	{
	}

	[Token(Token = "0x600533F")]
	[Address(RVA = "0xE5C2A0", Offset = "0xE5B0A0", Length = "0x52F")]
	private static void InitAsync()
	{
	}

	[Token(Token = "0x6005340")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void LogIsAsyncEnabled()
	{
	}

	[Token(Token = "0x6005341")]
	[Address(RVA = "0xE5C7E0", Offset = "0xE5B5E0", Length = "0x4F2")]
	private static void ExecuteAsyncSaving()
	{
	}

	[Token(Token = "0x6005342")]
	[Address(RVA = "0xE5CCE0", Offset = "0xE5BAE0", Length = "0x61F")]
	private static bool HandleNextAsyncSlot(out string slotName)
	{
		slotName = null;
		return false;
	}

	[Token(Token = "0x6005343")]
	[Address(RVA = "0xE5D310", Offset = "0xE5C110", Length = "0x1B6")]
	public static void WaitAsyncSaveComplete(string slotName)
	{
	}

	[Token(Token = "0x6005344")]
	[Address(RVA = "0xE5D4D0", Offset = "0xE5C2D0", Length = "0x2CA")]
	private static bool IsAsyncSavePending(string slotName)
	{
		return false;
	}

	[Token(Token = "0x6005345")]
	[Address(RVA = "0xE5D7A0", Offset = "0xE5C5A0", Length = "0x35E")]
	private static void UpdateAsync()
	{
	}

	[Token(Token = "0x6005346")]
	[Address(RVA = "0xE5DB00", Offset = "0xE5C900", Length = "0x45")]
	public static void OnGameManagerShutdown()
	{
	}

	[Token(Token = "0x6005347")]
	[Address(RVA = "0xE5DB50", Offset = "0xE5C950", Length = "0x9E")]
	public static void ResetAutosaveTimer()
	{
	}

	[Token(Token = "0x6005348")]
	[Address(RVA = "0xE5DBF0", Offset = "0xE5C9F0", Length = "0x113")]
	public static float SecondsUntilNextAutosave()
	{
		return 0f;
	}

	[Token(Token = "0x6005349")]
	[Address(RVA = "0xE5DD10", Offset = "0xE5CB10", Length = "0x54")]
	private static void UpdateAutosave()
	{
	}

	[Token(Token = "0x600534A")]
	[Address(RVA = "0xE5DD70", Offset = "0xE5CB70", Length = "0x1D2")]
	private static void SaveBootData(SlotData slot)
	{
	}

	[Token(Token = "0x600534D")]
	[Address(RVA = "0xE5E010", Offset = "0xE5CE10", Length = "0x31C")]
	public static void Init()
	{
	}

	[Token(Token = "0x600534E")]
	[Address(RVA = "0xE5E330", Offset = "0xE5D130", Length = "0xC0")]
	public static void Update()
	{
	}

	[Token(Token = "0x600534F")]
	[Address(RVA = "0xE5E3F0", Offset = "0xE5D1F0", Length = "0xBF1")]
	public static void SaveGame(string name, string sceneSaveName)
	{
	}

	[Token(Token = "0x6005350")]
	[Address(RVA = "0xE5EFF0", Offset = "0xE5DDF0", Length = "0x9A")]
	private static void PrepareSaveData(SlotData slot, string sceneSaveName)
	{
	}

	[Token(Token = "0x6005351")]
	[Address(RVA = "0xE5F090", Offset = "0xE5DE90", Length = "0x1B1")]
	private static void PrepareSaveData_Verbose(SlotData slot, string sceneSaveName)
	{
	}

	[Token(Token = "0x6005352")]
	[Address(RVA = "0xE5F250", Offset = "0xE5E050", Length = "0x2D5")]
	private static void SaveGeneralData(SlotData slot)
	{
	}

	[IteratorStateMachine(typeof(_003CSaveGameCoroutine_003Ed__57))]
	[Token(Token = "0x6005353")]
	[Address(RVA = "0xE5F530", Offset = "0xE5E330", Length = "0x9A")]
	private static IEnumerator SaveGameCoroutine(string name)
	{
		return null;
	}

	[Token(Token = "0x6005354")]
	[Address(RVA = "0xE5F5D0", Offset = "0xE5E3D0", Length = "0x6CB")]
	public static void RestoreGame(string name)
	{
	}

	[Token(Token = "0x6005355")]
	[Address(RVA = "0xE5FCA0", Offset = "0xE5EAA0", Length = "0x215")]
	public static void RestoreGameForEpisodeMigration(string name)
	{
	}

	[Token(Token = "0x6005356")]
	[Address(RVA = "0xE5FEC0", Offset = "0xE5ECC0", Length = "0x54")]
	public static void ResetForSceneLoad()
	{
	}

	[Token(Token = "0x6005357")]
	[Address(RVA = "0xE5FF20", Offset = "0xE5ED20", Length = "0xB7")]
	public static void ConfigureRestoreFromSlot(string slotName)
	{
	}

	[Token(Token = "0x6005358")]
	[Address(RVA = "0xE5FFE0", Offset = "0xE5EDE0", Length = "0x58")]
	public static bool IsRestoreInProgress()
	{
		return false;
	}

	[Token(Token = "0x6005359")]
	[Address(RVA = "0xE60040", Offset = "0xE5EE40", Length = "0xB8")]
	public static bool IsSceneRestoreInProgress()
	{
		return false;
	}

	[Token(Token = "0x600535A")]
	[Address(RVA = "0xE60100", Offset = "0xE5EF00", Length = "0xD0")]
	public static void DeleteSaveFiles(string name)
	{
	}

	[Token(Token = "0x600535B")]
	[Address(RVA = "0xE601D0", Offset = "0xE5EFD0", Length = "0x189")]
	public static void DeleteSaveFilesForGameId(uint gameId)
	{
	}

	[Token(Token = "0x600535C")]
	[Address(RVA = "0xE60360", Offset = "0xE5F160", Length = "0x195")]
	public static void SetCurrentSaveInfo(Episode episode, SaveSlotType gameMode, uint saveId, string savename)
	{
	}

	[Token(Token = "0x600535D")]
	[Address(RVA = "0xE60500", Offset = "0xE5F300", Length = "0x112")]
	public static void GenerateNewSaveName()
	{
	}

	[Token(Token = "0x600535E")]
	[Address(RVA = "0xE60620", Offset = "0xE5F420", Length = "0x57")]
	public static string GetCurrentSaveName()
	{
		return null;
	}

	[Token(Token = "0x600535F")]
	[Address(RVA = "0xE60680", Offset = "0xE5F480", Length = "0x4C")]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[Token(Token = "0x6005360")]
	[Address(RVA = "0xE606D0", Offset = "0xE5F4D0", Length = "0x5A")]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[Token(Token = "0x6005361")]
	[Address(RVA = "0xE60730", Offset = "0xE5F530", Length = "0x20E")]
	public static SaveSlotInfo GetNewestSaveSlotForActiveGame()
	{
		return null;
	}

	[Token(Token = "0x6005362")]
	[Address(RVA = "0xE60940", Offset = "0xE5F740", Length = "0x3BB")]
	public static SaveGameOperationReturnValue TryLoadDataString(string dataAsString, string name, int compressedSizeBytes)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x6005363")]
	[Address(RVA = "0xE60D00", Offset = "0xE5FB00", Length = "0x502")]
	public static SaveGameOperationReturnValue OnSaveCompleted(string name, int compressedSizeBytes)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x6005364")]
	[Address(RVA = "0xE61210", Offset = "0xE60010", Length = "0x1A5")]
	private static void GetActiveMissionLocId(GlobalSaveGameFormat globalData, ref SaveSlotInfo saveSlotInfo)
	{
	}

	[Token(Token = "0x6005365")]
	[Address(RVA = "0xE613C0", Offset = "0xE601C0", Length = "0x189")]
	private static void MaybeSetUserDefinedName(ref SaveSlotInfo saveSlotInfo)
	{
	}

	[Token(Token = "0x6005366")]
	[Address(RVA = "0xE61550", Offset = "0xE60350", Length = "0x348")]
	public static string SetDefaultUserDefinedSlotName(string slotname)
	{
		return null;
	}

	[Token(Token = "0x6005367")]
	[Address(RVA = "0xE618A0", Offset = "0xE606A0", Length = "0x157")]
	private static void MaybeSwitchToUninstancedFilename(string slot, string filename)
	{
	}

	[Token(Token = "0x6005368")]
	[Address(RVA = "0xE61A00", Offset = "0xE60800", Length = "0x54")]
	private static void SaveCompletedInternal(bool success)
	{
	}

	[Token(Token = "0x6005369")]
	[Address(RVA = "0xE61A60", Offset = "0xE60860", Length = "0x78")]
	public static int GetSaveSlotsBytesUsed()
	{
		return 0;
	}

	[Token(Token = "0x600536A")]
	[Address(RVA = "0xE61AE0", Offset = "0xE608E0", Length = "0x57")]
	public static bool IsDebugVerbose()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600536B")]
	[Address(RVA = "0xE61B40", Offset = "0xE60940", Length = "0x43")]
	public static void LogVerbose(string msg)
	{
	}

	[Token(Token = "0x600536C")]
	[Address(RVA = "0xE61B90", Offset = "0xE60990", Length = "0xBA")]
	public static void WarningInRelease(string msg)
	{
	}

	[Token(Token = "0x600536D")]
	[Address(RVA = "0xE61C50", Offset = "0xE60A50", Length = "0xBA")]
	public static void LogInRelease(string msg)
	{
	}

	[Token(Token = "0x600536E")]
	[Address(RVA = "0xE61D10", Offset = "0xE60B10", Length = "0x5D")]
	public static void ToggleDebugVerbose()
	{
	}

	[Token(Token = "0x600536F")]
	[Address(RVA = "0xE61D70", Offset = "0xE60B70", Length = "0x14A")]
	private static void SaveGameModeData(SlotData slot)
	{
	}

	[Token(Token = "0x6005370")]
	[Address(RVA = "0xE61EC0", Offset = "0xE60CC0", Length = "0x14A")]
	private static void RestoreGameModeData(string slotName)
	{
	}

	[Token(Token = "0x6005371")]
	[Address(RVA = "0xE62010", Offset = "0xE60E10", Length = "0x5148")]
	private static void SaveGlobalData(SlotData slot)
	{
	}

	[Token(Token = "0x6005372")]
	[Address(RVA = "0xE67160", Offset = "0xE65F60", Length = "0x3895")]
	private static bool RestoreGlobalData(string name)
	{
		return false;
	}

	[Token(Token = "0x6005373")]
	[Address(RVA = "0xE6AA00", Offset = "0xE69800", Length = "0x415")]
	private static bool RestoreGlobalDataForEspisodeMigration(string name)
	{
		return false;
	}

	[Token(Token = "0x6005374")]
	[Address(RVA = "0xE6AE20", Offset = "0xE69C20", Length = "0x1B8")]
	private static void RestoreGlobalDataPreSceneRestore(string name)
	{
	}

	[Token(Token = "0x6005375")]
	[Address(RVA = "0xE6AFE0", Offset = "0xE69DE0", Length = "0x289")]
	private static void RestoreGlobalDataPostSceneRestore(string name)
	{
	}

	[Token(Token = "0x6005376")]
	[Address(RVA = "0xE6B270", Offset = "0xE6A070", Length = "0xA9B")]
	private static void SaveInfoData(SlotData slot)
	{
	}

	[Token(Token = "0x6005377")]
	[Address(RVA = "0xE6BD10", Offset = "0xE6AB10", Length = "0x8C")]
	public static void DeletePhoto(string photoID)
	{
	}

	[Token(Token = "0x6005378")]
	[Address(RVA = "0xE6BDA0", Offset = "0xE6ABA0", Length = "0x197")]
	public static int GetPhotosBytesUsed()
	{
		return 0;
	}

	[Token(Token = "0x6005379")]
	[Address(RVA = "0xE6BF40", Offset = "0xE6AD40", Length = "0x4B")]
	public static bool IsPhotoFilename(string fileName)
	{
		return false;
	}

	[Token(Token = "0x600537A")]
	[Address(RVA = "0xE6BF90", Offset = "0xE6AD90", Length = "0x1CA")]
	public static bool LoadPhoto(string photoID, Texture destTexture)
	{
		return false;
	}

	[Token(Token = "0x600537B")]
	[Address(RVA = "0xE6C160", Offset = "0xE6AF60", Length = "0x3F6")]
	public static string GetNextPhotoID()
	{
		return null;
	}

	[Token(Token = "0x600537C")]
	[Address(RVA = "0xE6C560", Offset = "0xE6B360", Length = "0x68")]
	public static string SavePhoto(string gameName, Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x600537D")]
	[Address(RVA = "0xE6C5D0", Offset = "0xE6B3D0", Length = "0x2E8")]
	public static string SavePhoto(string gameName, string photoID, Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x600537E")]
	[Address(RVA = "0xE6C8C0", Offset = "0xE6B6C0", Length = "0xE8")]
	public static bool SavePhoto(string photoID, PhotoData photoData)
	{
		return false;
	}

	[Token(Token = "0x600537F")]
	[Address(RVA = "0xE6C9B0", Offset = "0xE6B7B0", Length = "0x2AB")]
	private static bool AddEntryToPhotoLoadQueue(string photoID, PhotoLoadQueueEntry entry)
	{
		return false;
	}

	[Token(Token = "0x6005380")]
	[Address(RVA = "0xE6CC60", Offset = "0xE6BA60", Length = "0x1546")]
	public static void HandleOnPhotoLoaded(string fileName, string data, int compressedSizeBytes)
	{
	}

	[Token(Token = "0x6005381")]
	[Address(RVA = "0xE6E1B0", Offset = "0xE6CFB0", Length = "0x16B")]
	public static void HandleOnPhotoSaved(string fileName, int compressedSizeBytes)
	{
	}

	[Token(Token = "0x6005382")]
	[Address(RVA = "0xE6E320", Offset = "0xE6D120", Length = "0x257")]
	public static void MaybePurgeUnreferencedPhotos(string currentSave)
	{
	}

	[Token(Token = "0x6005385")]
	[Address(RVA = "0xE6E640", Offset = "0xE6D440", Length = "0xE9")]
	private static void LoadUserProfile()
	{
	}

	[Token(Token = "0x6005386")]
	[Address(RVA = "0xE6E730", Offset = "0xE6D530", Length = "0x15A")]
	public static void HandleCheckIfProfileExists(bool dataExists, string name)
	{
	}

	[Token(Token = "0x6005387")]
	[Address(RVA = "0xE6E890", Offset = "0xE6D690", Length = "0x178")]
	public static void ShowProfileLoadError()
	{
	}

	[Token(Token = "0x6005388")]
	[Address(RVA = "0xE6EA10", Offset = "0xE6D810", Length = "0x5F")]
	private static void OnLoadErrorConfirm()
	{
	}

	[Token(Token = "0x6005389")]
	[Address(RVA = "0xE6EA70", Offset = "0xE6D870", Length = "0x383")]
	public static void HandleOnProfileLoaded(string profileData, int compressedSizeBytes)
	{
	}

	[Token(Token = "0x600538A")]
	[Address(RVA = "0xE6EE00", Offset = "0xE6DC00", Length = "0x71")]
	public static void HandleOnProfileSaved(int compressedSizeBytes)
	{
	}

	[Token(Token = "0x600538B")]
	[Address(RVA = "0xE6EE80", Offset = "0xE6DC80", Length = "0x5A")]
	private static ProfileState GenerateNewProfile()
	{
		return null;
	}

	[Token(Token = "0x600538C")]
	[Address(RVA = "0xE6EEE0", Offset = "0xE6DCE0", Length = "0x17A")]
	public static void SaveProfile()
	{
	}

	[Token(Token = "0x600538D")]
	[Address(RVA = "0xE6F060", Offset = "0xE6DE60", Length = "0x122")]
	public static bool IsProfileFilename(string name)
	{
		return false;
	}

	[Token(Token = "0x600538E")]
	[Address(RVA = "0xE6F190", Offset = "0xE6DF90", Length = "0x11C")]
	public static bool IsLegacyProfileFilename(string name)
	{
		return false;
	}

	[Token(Token = "0x600538F")]
	[Address(RVA = "0xE6F2B0", Offset = "0xE6E0B0", Length = "0x26A3")]
	private static void SaveSceneData(SlotData slot, string sceneSaveName)
	{
	}

	[Token(Token = "0x6005390")]
	[Address(RVA = "0xE71960", Offset = "0xE70760", Length = "0x157F")]
	private static bool LoadSceneData(string name, string sceneSaveName)
	{
		return false;
	}

	[Token(Token = "0x6005391")]
	[Address(RVA = "0xE72EE0", Offset = "0xE71CE0", Length = "0x234")]
	private static void LoadSceneDataAdditive(string name, string sceneSaveName)
	{
	}

	[Token(Token = "0x6005392")]
	[Address(RVA = "0xE73120", Offset = "0xE71F20", Length = "0x228")]
	public static void SaveScreenshotData(SlotData slot)
	{
	}

	[Token(Token = "0x6005393")]
	[Address(RVA = "0xE73350", Offset = "0xE72150", Length = "0xA7")]
	public static void TickScreenshotCoroutine()
	{
	}

	[IteratorStateMachine(typeof(_003CSaveScreenshotDataCoroutine_003Ed__146))]
	[Token(Token = "0x6005394")]
	[Address(RVA = "0xE73400", Offset = "0xE72200", Length = "0x3D")]
	private static IEnumerator SaveScreenshotDataCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6005395")]
	[Address(RVA = "0xE73440", Offset = "0xE72240", Length = "0x31C")]
	public static Texture2D CreateTextureData(string savename)
	{
		return null;
	}

	[Token(Token = "0x6005396")]
	[Address(RVA = "0xE73760", Offset = "0xE72560", Length = "0x21D")]
	public static Texture2D CreateTextureData(ScreenshotSaveGameFormat screenshotData)
	{
		return null;
	}

	[Token(Token = "0x6005397")]
	[Address(RVA = "0xE73980", Offset = "0xE72780", Length = "0x5B")]
	public static bool IsWaitingForScreenshot()
	{
		return false;
	}

	[Token(Token = "0x6005398")]
	[Address(RVA = "0xE739E0", Offset = "0xE727E0", Length = "0x29F")]
	public static void AbortScreenshot()
	{
	}

	[Token(Token = "0x600539B")]
	[Address(RVA = "0xE73D40", Offset = "0xE72B40", Length = "0x1E0")]
	public static void LoadUserSettings()
	{
	}

	[Token(Token = "0x600539C")]
	[Address(RVA = "0xE73F20", Offset = "0xE72D20", Length = "0x15A")]
	public static void HandleCheckIfSettingsExists(bool dataExists, string name)
	{
	}

	[Token(Token = "0x600539D")]
	[Address(RVA = "0xE74080", Offset = "0xE72E80", Length = "0x39F")]
	public static void HandleOnSettingsLoaded(string settingsData, int compressedSizeBytes)
	{
	}

	[Token(Token = "0x600539E")]
	[Address(RVA = "0xE74420", Offset = "0xE73220", Length = "0x71")]
	public static void HandleOnSettingsSaved(int compressedSizeBytes)
	{
	}

	[Token(Token = "0x600539F")]
	[Address(RVA = "0xE744A0", Offset = "0xE732A0", Length = "0x237")]
	private static SettingsState GenerateNewSettings()
	{
		return null;
	}

	[Token(Token = "0x60053A0")]
	[Address(RVA = "0xE746E0", Offset = "0xE734E0", Length = "0x17A")]
	public static void SaveSettings()
	{
	}

	[Token(Token = "0x60053A1")]
	[Address(RVA = "0xE74860", Offset = "0xE73660", Length = "0x122")]
	public static bool IsSettingsFilename(string name)
	{
		return false;
	}

	[Token(Token = "0x60053A2")]
	[Address(RVA = "0xE74990", Offset = "0xE73790", Length = "0x11C")]
	public static bool IsLegacySettingsFilename(string name)
	{
		return false;
	}

	[Token(Token = "0x60053A4")]
	[Address(RVA = "0xE74B10", Offset = "0xE73910", Length = "0x11F")]
	public static void InitializeUser()
	{
	}

	[Token(Token = "0x60053A5")]
	[Address(RVA = "0xE74C30", Offset = "0xE73A30", Length = "0x32D")]
	private static void UpdateUserInitialization()
	{
	}

	[Token(Token = "0x60053A6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SaveGameSystem()
	{
	}
}
