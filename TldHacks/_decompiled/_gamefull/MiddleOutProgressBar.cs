using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000262")]
public class MiddleOutProgressBar : MonoBehaviour
{
	[Token(Token = "0x40015A5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_LeftSlider;

	[Token(Token = "0x40015A6")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_RightSlider;

	[HideInInspector]
	[Token(Token = "0x40015A7")]
	[FieldOffset(Offset = "0x30")]
	public float m_Value;

	[Token(Token = "0x60014E6")]
	[Address(RVA = "0x696D40", Offset = "0x695B40", Length = "0xA1")]
	public void SetValue(float newValue)
	{
	}

	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x696DF0", Offset = "0x695BF0", Length = "0xA6")]
	public void IncrementValue(float increment)
	{
	}

	[Token(Token = "0x60014E8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MiddleOutProgressBar()
	{
	}
}
