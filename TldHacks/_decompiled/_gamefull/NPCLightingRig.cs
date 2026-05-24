using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003DC")]
public class NPCLightingRig : MonoBehaviour
{
	[Header("Target")]
	[SerializeField]
	[Token(Token = "0x40022D4")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_NPCTransform;

	[Header("Lights")]
	[Range(0f, 1f)]
	[Token(Token = "0x40022D5")]
	[FieldOffset(Offset = "0x28")]
	public float m_DayIntensityScalar;

	[Range(0f, 1f)]
	[Token(Token = "0x40022D6")]
	[FieldOffset(Offset = "0x2C")]
	public float m_NightIntensityScalar;

	[SerializeField]
	[Token(Token = "0x40022D7")]
	[FieldOffset(Offset = "0x30")]
	private Light m_LeftRimLight;

	[SerializeField]
	[Token(Token = "0x40022D8")]
	[FieldOffset(Offset = "0x38")]
	private Light m_RightRimLight;

	[SerializeField]
	[Token(Token = "0x40022D9")]
	[FieldOffset(Offset = "0x40")]
	private Light m_LeftFillLight;

	[SerializeField]
	[Token(Token = "0x40022DA")]
	[FieldOffset(Offset = "0x48")]
	private Light m_RightFillLight;

	[Header("Colors by angle")]
	[Range(0f, 360f)]
	[Token(Token = "0x40022DB")]
	[FieldOffset(Offset = "0x50")]
	public float m_RotationOffset;

	[SerializeField]
	[Token(Token = "0x40022DC")]
	[FieldOffset(Offset = "0x58")]
	private Gradient m_LeftRimColor;

	[SerializeField]
	[Token(Token = "0x40022DD")]
	[FieldOffset(Offset = "0x60")]
	private Gradient m_RightRimColor;

	[SerializeField]
	[Token(Token = "0x40022DE")]
	[FieldOffset(Offset = "0x68")]
	private Gradient m_LeftFillColor;

	[SerializeField]
	[Token(Token = "0x40022DF")]
	[FieldOffset(Offset = "0x70")]
	private Gradient m_RightFillColor;

	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x7B1B30", Offset = "0x7B0930", Length = "0xBE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x7B2720", Offset = "0x7B1520", Length = "0x51")]
	public NPCLightingRig()
	{
	}
}
