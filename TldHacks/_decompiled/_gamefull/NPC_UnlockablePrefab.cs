using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200087C")]
public class NPC_UnlockablePrefab : MonoBehaviour
{
	[Token(Token = "0x40057BD")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x40057BE")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedRequirementsDescription;

	[Token(Token = "0x40057BF")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x40057C0")]
	[FieldOffset(Offset = "0x38")]
	public int m_TrustToUnlock;

	[Token(Token = "0x1700035E")]
	public string m_DisplayName
	{
		[Token(Token = "0x6004DAF")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035F")]
	public string m_RequirementsDescription
	{
		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000360")]
	public string m_Description
	{
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004DB2")]
	[Address(RVA = "0xD901E0", Offset = "0xD8EFE0", Length = "0x14E")]
	public NPC_UnlockablePrefabInfo GetPrefabInfo()
	{
		return null;
	}

	[Token(Token = "0x6004DB3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NPC_UnlockablePrefab()
	{
	}
}
