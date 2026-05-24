using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003C8")]
public class LightRandomColor : MonoBehaviour
{
	[Token(Token = "0x400221A")]
	[FieldOffset(Offset = "0x20")]
	public MinMax m_Hue;

	[Token(Token = "0x400221B")]
	[FieldOffset(Offset = "0x28")]
	public MinMax m_Saturation;

	[Token(Token = "0x400221C")]
	[FieldOffset(Offset = "0x30")]
	public MinMax m_Value;

	[Token(Token = "0x400221D")]
	[FieldOffset(Offset = "0x38")]
	public float m_LerpSpeed;

	[Token(Token = "0x400221E")]
	[FieldOffset(Offset = "0x3C")]
	public float m_IntervalSeconds;

	[Token(Token = "0x400221F")]
	[FieldOffset(Offset = "0x40")]
	private Color m_TargetColor;

	[Token(Token = "0x4002220")]
	[FieldOffset(Offset = "0x50")]
	private Light m_Light;

	[Token(Token = "0x4002221")]
	[FieldOffset(Offset = "0x58")]
	private float m_CurrentTime;

	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x7A6690", Offset = "0x7A5490", Length = "0x11D")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D92")]
	[Address(RVA = "0x7A67B0", Offset = "0x7A55B0", Length = "0x367")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LightRandomColor()
	{
	}
}
