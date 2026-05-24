using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001CB")]
public class Cairn : MonoBehaviour
{
	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x20")]
	public string m_BackerLookupNum;

	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x28")]
	public int m_JournalEntryNumber;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x6001068")]
	[Address(RVA = "0x627C40", Offset = "0x626A40", Length = "0x18D")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6001069")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Cairn()
	{
	}
}
