using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200033B")]
public class Feat_BlizzardWalker : Feat
{
	[Header("Tuning")]
	[Range(1f, 5000f)]
	[Token(Token = "0x4001CF9")]
	[FieldOffset(Offset = "0x68")]
	public int m_BlizzardDaysOutsideCountRequired;

	[Range(1f, 100f)]
	[Token(Token = "0x4001CFA")]
	[FieldOffset(Offset = "0x6C")]
	public int m_WalkingSpeedInWindReductionPercent;

	[Token(Token = "0x4001CFB")]
	[FieldOffset(Offset = "0x70")]
	private float m_BlizzardHoursOutsideRequired;

	[Token(Token = "0x4001CFC")]
	private static float s_BlizzardHoursOutside;

	[Token(Token = "0x4001CFD")]
	private static float s_BlizzardHoursOutsideAccumulator;

	[Token(Token = "0x4001CFE")]
	private static Feat_BlizzardWalkerSaveData m_Feat_BlizzardWalkerSaveData;

	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x750F60", Offset = "0x74FD60", Length = "0x16")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x750F80", Offset = "0x74FD80", Length = "0x105")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x751090", Offset = "0x74FE90", Length = "0xDB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x751170", Offset = "0x74FF70", Length = "0x101")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x751280", Offset = "0x750080", Length = "0x36")]
	public float GetWalkingSpeedInWindReductionModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x7512C0", Offset = "0x7500C0", Length = "0x152")]
	public void IncrementHours(float hours)
	{
	}

	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x751420", Offset = "0x750220", Length = "0x112")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x751540", Offset = "0x750340", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x751600", Offset = "0x750400", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x7516E0", Offset = "0x7504E0", Length = "0x61")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001A82")]
	[Address(RVA = "0x751750", Offset = "0x750550", Length = "0x80")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x7517D0", Offset = "0x7505D0", Length = "0x17F")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_BlizzardWalker()
	{
	}
}
