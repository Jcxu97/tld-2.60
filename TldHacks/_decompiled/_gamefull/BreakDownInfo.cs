using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000207")]
public class BreakDownInfo : MonoBehaviour
{
	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_BreakDownNameLabel;

	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_DurationLabel;

	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_EstimatedCaloriesBurnedLabel;

	[Token(Token = "0x6001260")]
	[Address(RVA = "0x611A10", Offset = "0x610810", Length = "0x2D")]
	public void Show(bool show)
	{
	}

	[Token(Token = "0x6001261")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BreakDownInfo()
	{
	}
}
