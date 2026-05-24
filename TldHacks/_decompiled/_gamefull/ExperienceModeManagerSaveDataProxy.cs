using Cpp2ILInjected;
using Newtonsoft.Json;
using TLD.Gameplay;

[Token(Token = "0x2000736")]
public class ExperienceModeManagerSaveDataProxy
{
	[Token(Token = "0x4004C65")]
	[FieldOffset(Offset = "0x10")]
	public string m_CurrentModeType;

	[Token(Token = "0x4004C66")]
	[FieldOffset(Offset = "0x18")]
	public string m_CustomModeString;

	[Token(Token = "0x4004C67")]
	[FieldOffset(Offset = "0x20")]
	public string m_PreviousModeType;

	[JsonIgnore]
	[Token(Token = "0x1700031B")]
	public GameModeConfig CurrentMode
	{
		[Token(Token = "0x6004115")]
		[Address(RVA = "0xC1A950", Offset = "0xC19750", Length = "0xA9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004116")]
		[Address(RVA = "0xC1AA00", Offset = "0xC19800", Length = "0x141")]
		set
		{
		}
	}

	[JsonIgnore]
	[Token(Token = "0x1700031C")]
	public ExperienceModeType PreviousModeType
	{
		[Token(Token = "0x6004117")]
		[Address(RVA = "0xC1AB50", Offset = "0xC19950", Length = "0xB")]
		get
		{
			return default(ExperienceModeType);
		}
		[Token(Token = "0x6004118")]
		[Address(RVA = "0xC1AB60", Offset = "0xC19960", Length = "0xAC")]
		set
		{
		}
	}

	[JsonIgnore]
	[Token(Token = "0x1700031D")]
	public ExperienceModeType CurrentModeType
	{
		[Token(Token = "0x6004119")]
		[Address(RVA = "0xC1AC10", Offset = "0xC19A10", Length = "0xB")]
		get
		{
			return default(ExperienceModeType);
		}
		[Token(Token = "0x600411A")]
		[Address(RVA = "0xC1AC20", Offset = "0xC19A20", Length = "0xAC")]
		set
		{
		}
	}

	[Token(Token = "0x600411B")]
	[Address(RVA = "0xC1ACD0", Offset = "0xC19AD0", Length = "0x72")]
	private static ExperienceModeType StringToExperienceModeType(string xpMode)
	{
		return default(ExperienceModeType);
	}

	[Token(Token = "0x600411C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ExperienceModeManagerSaveDataProxy()
	{
	}
}
