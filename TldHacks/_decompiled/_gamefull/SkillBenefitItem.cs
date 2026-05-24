using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200027A")]
public class SkillBenefitItem : MonoBehaviour
{
	[Token(Token = "0x40016A2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_Background;

	[Token(Token = "0x40016A3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_LabelBenifit;

	[Token(Token = "0x60015A7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SkillBenefitItem()
	{
	}
}
