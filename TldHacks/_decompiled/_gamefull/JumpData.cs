using Cpp2ILInjected;
using TLD.Gameplay;

[Token(Token = "0x20002A1")]
public class JumpData
{
	[Token(Token = "0x4001797")]
	public const string EDITOR_FILE_TO_LOAD = "JMPED_FileToLoad";

	[Token(Token = "0x4001798")]
	public const int DISPLAY_NAME_MAX_LENGTH = 20;

	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x28")]
	public int m_EditorId;

	[Token(Token = "0x170001D1")]
	[field: Token(Token = "0x4001799")]
	[field: FieldOffset(Offset = "0x10")]
	public string m_ActiveMissionId
	{
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x170001D2")]
	[field: Token(Token = "0x400179A")]
	[field: FieldOffset(Offset = "0x18")]
	public string m_ActiveMissionLocId
	{
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x170001D3")]
	[field: Token(Token = "0x400179B")]
	[field: FieldOffset(Offset = "0x20")]
	public GameModeConfig GameModeConfig
	{
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x170001D4")]
	[field: Token(Token = "0x400179D")]
	[field: FieldOffset(Offset = "0x30")]
	public string m_FilePath
	{
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x170001D5")]
	[field: Token(Token = "0x400179E")]
	[field: FieldOffset(Offset = "0x38")]
	public float m_HoursSurvived
	{
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
		get;
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x5CF5B0", Offset = "0x5CE3B0", Length = "0x6")]
		protected set;
	}

	[Token(Token = "0x170001D6")]
	[field: Token(Token = "0x400179F")]
	[field: FieldOffset(Offset = "0x40")]
	public string m_Location
	{
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get;
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x170001D7")]
	[field: Token(Token = "0x40017A0")]
	[field: FieldOffset(Offset = "0x48")]
	public ScreenshotSaveGameFormat m_Screenshot
	{
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x170001D8")]
	[field: Token(Token = "0x40017A1")]
	[field: FieldOffset(Offset = "0x50")]
	public SlotData m_Slot
	{
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get;
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
		protected set;
	}

	[Token(Token = "0x600167C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected JumpData()
	{
	}

	[Token(Token = "0x600167D")]
	[Address(RVA = "0x6B90D0", Offset = "0x6B7ED0", Length = "0x606")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600167E")]
	[Address(RVA = "0x6B96E0", Offset = "0x6B84E0", Length = "0x26F")]
	public string GetTreePath()
	{
		return null;
	}

	[Token(Token = "0x600167F")]
	[Address(RVA = "0x6B9950", Offset = "0x6B8750", Length = "0xCA")]
	public bool IsStoryMode()
	{
		return false;
	}

	[Token(Token = "0x6001680")]
	[Address(RVA = "0x6B9A20", Offset = "0x6B8820", Length = "0x345")]
	public void Rename(string name)
	{
	}

	[Token(Token = "0x6001681")]
	[Address(RVA = "0x6B9D70", Offset = "0x6B8B70", Length = "0x770")]
	public static JumpData LoadFromFile(string path)
	{
		return null;
	}
}
