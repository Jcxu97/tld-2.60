using Cpp2ILInjected;

[Token(Token = "0x200087B")]
public class NPC_UnlockablePrefabInfo
{
	[Token(Token = "0x40057B8")]
	[FieldOffset(Offset = "0x10")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x40057B9")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_LocalizedRequirementsDescription;

	[Token(Token = "0x40057BA")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x40057BB")]
	[FieldOffset(Offset = "0x28")]
	public int m_TrustToUnlock;

	[Token(Token = "0x40057BC")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_Unlocked;

	[Token(Token = "0x1700035B")]
	public string m_DisplayName
	{
		[Token(Token = "0x6004DAB")]
		[Address(RVA = "0xD90120", Offset = "0xD8EF20", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035C")]
	public string m_RequirementsDescription
	{
		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0xD90180", Offset = "0xD8EF80", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035D")]
	public string m_Description
	{
		[Token(Token = "0x6004DAD")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004DAE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NPC_UnlockablePrefabInfo()
	{
	}
}
