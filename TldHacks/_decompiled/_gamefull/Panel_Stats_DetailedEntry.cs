using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200026B")]
public class Panel_Stats_DetailedEntry : MonoBehaviour
{
	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_Label_CurrentValue;

	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label_AllTimeValuePilgrim;

	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_Label_AllTimeValueVoyageur;

	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Label_AllTimeValueStalker;

	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_Label_AllTimeValueInterloper;

	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_Label_AllTimeValueMisery;

	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_Label_Title;

	[Token(Token = "0x6001545")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Stats_DetailedEntry()
	{
	}
}
