using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003D9")]
public class MultiplyNighttimeParticleOpacity : MonoBehaviour
{
	[Token(Token = "0x40022BE")]
	[FieldOffset(Offset = "0x20")]
	public float m_OpacityMultiplier;

	[Token(Token = "0x40022BF")]
	[FieldOffset(Offset = "0x24")]
	public bool m_OverrideIfHoldingLight;

	[Token(Token = "0x40022C0")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem m_PS;

	[Token(Token = "0x40022C1")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem.MainModule m_PSMain;

	[Token(Token = "0x40022C2")]
	[FieldOffset(Offset = "0x38")]
	private UniStormWeatherSystem m_UniStorm;

	[Token(Token = "0x40022C3")]
	[FieldOffset(Offset = "0x40")]
	private Color m_OriginalColor;

	[Token(Token = "0x40022C4")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurrentAlpha;

	[Token(Token = "0x40022C5")]
	[FieldOffset(Offset = "0x54")]
	private float m_DestinationAlpha;

	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x7AF060", Offset = "0x7ADE60", Length = "0x247")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x7AF2B0", Offset = "0x7AE0B0", Length = "0x2A5")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x784250", Offset = "0x783050", Length = "0x4E")]
	public MultiplyNighttimeParticleOpacity()
	{
	}
}
