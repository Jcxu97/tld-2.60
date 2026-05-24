using Cpp2ILInjected;

[Token(Token = "0x20004F0")]
public struct Affliction
{
	[Token(Token = "0x4002D4D")]
	[FieldOffset(Offset = "0x0")]
	public readonly string m_Cause;

	[Token(Token = "0x4002D4E")]
	[FieldOffset(Offset = "0x8")]
	public readonly AfflictionType m_AfflictionType;

	[Token(Token = "0x4002D4F")]
	[FieldOffset(Offset = "0xC")]
	public readonly AfflictionBodyArea m_Location;

	[Token(Token = "0x4002D50")]
	[FieldOffset(Offset = "0x10")]
	public readonly int m_Id;

	[Token(Token = "0x4002D51")]
	[FieldOffset(Offset = "0x14")]
	private readonly bool m_IsValid;

	[Token(Token = "0x4002D52")]
	public static readonly int AfflictionBodyAreaCount;

	[Token(Token = "0x4002D53")]
	public static readonly int AfflictionTypesCount;

	[Token(Token = "0x4002D54")]
	public static Affliction InvalidAffliction;

	[Token(Token = "0x4002D55")]
	public const string DEFINITION_ASSET_PREFIX = "Affliction_";

	[Token(Token = "0x6002565")]
	[Address(RVA = "0x87AE10", Offset = "0x879C10", Length = "0xD4")]
	public Affliction(AfflictionType afflictionType, string causeLocalizationId, AfflictionBodyArea location, int id)
	{
		m_Cause = null;
		m_AfflictionType = default(AfflictionType);
		m_Location = default(AfflictionBodyArea);
		m_Id = 0;
		m_IsValid = false;
	}

	[Token(Token = "0x6002566")]
	[Address(RVA = "0x87AEF0", Offset = "0x879CF0", Length = "0x62")]
	public Affliction(string cause)
	{
		m_Cause = null;
		m_AfflictionType = default(AfflictionType);
		m_Location = default(AfflictionBodyArea);
		m_Id = 0;
		m_IsValid = false;
	}

	[Token(Token = "0x6002567")]
	[Address(RVA = "0x4D1070", Offset = "0x4CFE70", Length = "0x5")]
	public bool IsValid()
	{
		return false;
	}

	[Token(Token = "0x6002568")]
	[Address(RVA = "0x87AF60", Offset = "0x879D60", Length = "0x2F")]
	public bool CompareTo(Affliction toCompare)
	{
		return false;
	}

	[Token(Token = "0x6002569")]
	[Address(RVA = "0x87AF90", Offset = "0x879D90", Length = "0x31")]
	public bool CompareTo(AfflictionButton toCompare)
	{
		return false;
	}

	[Token(Token = "0x600256A")]
	[Address(RVA = "0x87AFD0", Offset = "0x879DD0", Length = "0x18B")]
	public static string GetDisplayNameLocId(AfflictionType affType)
	{
		return null;
	}

	[Token(Token = "0x600256B")]
	[Address(RVA = "0x87B160", Offset = "0x879F60", Length = "0x18B")]
	public static string SpriteNameFromAfflictionType(AfflictionType affType)
	{
		return null;
	}

	[Token(Token = "0x600256C")]
	[Address(RVA = "0x87B2F0", Offset = "0x87A0F0", Length = "0x1E0")]
	public static string LocalizedNameFromAfflictionType(AfflictionType affType, int index)
	{
		return null;
	}

	[Token(Token = "0x600256D")]
	[Address(RVA = "0x87B4D0", Offset = "0x87A2D0", Length = "0x18B")]
	public static string GetDescriptionLocId(AfflictionType affType)
	{
		return null;
	}

	[Token(Token = "0x600256E")]
	[Address(RVA = "0x87B660", Offset = "0x87A460", Length = "0xA1")]
	public static string GetDisplayName(AfflictionType affType)
	{
		return null;
	}

	[Token(Token = "0x600256F")]
	[Address(RVA = "0x87B710", Offset = "0x87A510", Length = "0x68")]
	public static bool IsBeneficial(AfflictionType affType)
	{
		return false;
	}

	[Token(Token = "0x6002570")]
	[Address(RVA = "0x87B780", Offset = "0x87A580", Length = "0x40")]
	public static bool IsRisk(AfflictionType affType)
	{
		return false;
	}

	[Token(Token = "0x6002571")]
	[Address(RVA = "0x87B7F0", Offset = "0x87A5F0", Length = "0x1F")]
	public static bool AfflictionTypeIsBuff(AfflictionType affType)
	{
		return false;
	}

	[Token(Token = "0x6002572")]
	[Address(RVA = "0x87B810", Offset = "0x87A610", Length = "0x90")]
	public static bool IsBadAffliction(AfflictionType affType)
	{
		return false;
	}
}
