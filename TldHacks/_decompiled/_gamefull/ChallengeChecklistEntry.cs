using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000214")]
public class ChallengeChecklistEntry : MonoBehaviour
{
	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_NameLabel;

	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_CountLabel;

	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_ActiveSpriteObj;

	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_CompletedSpriteObj;

	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_NameLabelOrigPos;

	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_NameLabelNoCountPos;

	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x58")]
	private bool m_GotOrigPos;

	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x657190", Offset = "0x655F90", Length = "0x58A")]
	public float UpdateEntry(string name, string count, bool completed, float offsetY, float spacing)
	{
		return 0f;
	}

	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x657720", Offset = "0x656520", Length = "0x100")]
	private void GetOrigPos()
	{
	}

	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ChallengeChecklistEntry()
	{
	}
}
