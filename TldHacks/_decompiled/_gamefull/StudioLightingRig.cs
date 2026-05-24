using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003FD")]
public class StudioLightingRig : MonoBehaviour
{
	[Token(Token = "0x40023E9")]
	[FieldOffset(Offset = "0x20")]
	public bool m_FaceCamera;

	[Token(Token = "0x40023EA")]
	[FieldOffset(Offset = "0x21")]
	public bool m_OnNPC;

	[Token(Token = "0x40023EB")]
	[FieldOffset(Offset = "0x22")]
	public bool m_BacklightTakesFresnelColor;

	[Header("Light fading")]
	[Token(Token = "0x40023EC")]
	[FieldOffset(Offset = "0x23")]
	public bool m_FadeLightsWhenOnSide;

	[Token(Token = "0x40023ED")]
	[FieldOffset(Offset = "0x24")]
	public float m_AmountToFadeKey;

	[Token(Token = "0x40023EE")]
	[FieldOffset(Offset = "0x28")]
	public float m_AmountToFadeBack;

	[Token(Token = "0x40023EF")]
	[FieldOffset(Offset = "0x2C")]
	private float m_BaseFadeCalculation;

	[Token(Token = "0x40023F0")]
	[FieldOffset(Offset = "0x30")]
	private float m_KeyFadeCalculation;

	[Token(Token = "0x40023F1")]
	[FieldOffset(Offset = "0x34")]
	private float m_BackFadeCalculation;

	[Token(Token = "0x40023F2")]
	[FieldOffset(Offset = "0x38")]
	private float[] m_KeyInitialIntensity;

	[Token(Token = "0x40023F3")]
	[FieldOffset(Offset = "0x40")]
	private float[] m_BackInitialIntensity;

	[Header("Lights")]
	[Token(Token = "0x40023F4")]
	[FieldOffset(Offset = "0x48")]
	public Light[] m_KeyLights;

	[Token(Token = "0x40023F5")]
	[FieldOffset(Offset = "0x50")]
	public Light[] m_BackLights;

	[Token(Token = "0x40023F6")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_PlayerTarget;

	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x7C0C20", Offset = "0x7BFA20", Length = "0x340")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x7C0F70", Offset = "0x7BFD70", Length = "0x728")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x7C16A0", Offset = "0x7C04A0", Length = "0x58")]
	public StudioLightingRig()
	{
	}
}
