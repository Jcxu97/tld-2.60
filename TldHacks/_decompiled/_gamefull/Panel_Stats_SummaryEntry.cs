using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200026C")]
public class Panel_Stats_SummaryEntry : MonoBehaviour
{
	[Token(Token = "0x4001622")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_Sprite_Icon;

	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label_Value;

	[Token(Token = "0x4001624")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_Label_Title;

	[Token(Token = "0x6001546")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Stats_SummaryEntry()
	{
	}
}
