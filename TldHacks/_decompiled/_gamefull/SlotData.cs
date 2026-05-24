using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using TLD.SaveState;

[Token(Token = "0x200091C")]
public class SlotData : BaseState
{
	[Token(Token = "0x4005ECD")]
	public static bool s_DebugAllowInvalidVersions;

	[Token(Token = "0x4005ECE")]
	public const int CURRENT_VERSION = 100;

	[Token(Token = "0x4005ECF")]
	public const int LOWEST_COMPATIBLE_VERSION = 100;

	[Token(Token = "0x4005ED0")]
	public const string BOOT_KEY = "boot";

	[Token(Token = "0x4005ED1")]
	public const string GLOBAL_KEY = "global";

	[Token(Token = "0x4005ED2")]
	public const string INFO_KEY = "info";

	[Token(Token = "0x4005ED3")]
	public const string SCREENSHOT_KEY = "screenshot";

	[Token(Token = "0x4005ED4")]
	[FieldOffset(Offset = "0x20")]
	public string m_InternalName;

	[Token(Token = "0x4005ED5")]
	[FieldOffset(Offset = "0x28")]
	public string m_BaseName;

	[Token(Token = "0x4005ED6")]
	[FieldOffset(Offset = "0x30")]
	public string m_DisplayName;

	[NonSerialized]
	[Token(Token = "0x4005ED7")]
	[FieldOffset(Offset = "0x38")]
	public string m_Filename;

	[Token(Token = "0x4005ED8")]
	[FieldOffset(Offset = "0x40")]
	public DateTime m_Timestamp;

	[Token(Token = "0x4005ED9")]
	[FieldOffset(Offset = "0x48")]
	public SaveSlotType m_GameMode;

	[Token(Token = "0x4005EDA")]
	[FieldOffset(Offset = "0x4C")]
	public uint m_GameId;

	[Token(Token = "0x4005EDB")]
	[FieldOffset(Offset = "0x50")]
	public Episode m_Episode;

	[NonSerialized]
	[Token(Token = "0x4005EDC")]
	[FieldOffset(Offset = "0x54")]
	public int m_CompressedSizeBytes;

	[Token(Token = "0x4005EDD")]
	[FieldOffset(Offset = "0x58")]
	public readonly List<string> m_InstalledOptionalContent;

	[NonSerialized]
	[Token(Token = "0x4005EDE")]
	[FieldOffset(Offset = "0x60")]
	private Mutex m_SlotDataMutex;

	[Token(Token = "0x60052E5")]
	[Address(RVA = "0xE53260", Offset = "0xE52060", Length = "0xC9")]
	public void Lock()
	{
	}

	[Token(Token = "0x60052E6")]
	[Address(RVA = "0xE53330", Offset = "0xE52130", Length = "0x33")]
	public void UnLock()
	{
	}

	[Token(Token = "0x60052E7")]
	[Address(RVA = "0xE53370", Offset = "0xE52170", Length = "0xD")]
	public bool IsValidVersion()
	{
		return false;
	}

	[Token(Token = "0x60052E8")]
	[Address(RVA = "0xE53380", Offset = "0xE52180", Length = "0x65")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60052E9")]
	[Address(RVA = "0xE533F0", Offset = "0xE521F0", Length = "0xEA")]
	public SlotData()
	{
	}
}
