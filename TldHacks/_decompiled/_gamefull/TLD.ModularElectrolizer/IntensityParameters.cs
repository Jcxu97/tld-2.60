using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[CreateAssetMenu(menuName = "Aurora/Intensity Parameters")]
[Token(Token = "0x20013D6")]
public class IntensityParameters : ScriptableObject
{
	[Token(Token = "0x4009159")]
	[FieldOffset(Offset = "0x18")]
	public float m_InitialIntensity;

	[Token(Token = "0x400915A")]
	[FieldOffset(Offset = "0x1C")]
	public float m_LightIntensityMultiplier;

	[Token(Token = "0x400915B")]
	[FieldOffset(Offset = "0x20")]
	public float m_EmissiveIntensityMultiplier;

	[Token(Token = "0x400915C")]
	[FieldOffset(Offset = "0x24")]
	public float m_IntensityUpdateThresholdPercent;

	[Token(Token = "0x400915D")]
	[FieldOffset(Offset = "0x28")]
	public bool m_LightFadeWithAurora;

	[Token(Token = "0x400915E")]
	[FieldOffset(Offset = "0x29")]
	public bool m_LightsScaleByRelativeValue;

	[Token(Token = "0x400915F")]
	[FieldOffset(Offset = "0x2A")]
	public bool m_RandomAuroraColor;

	[Token(Token = "0x4009160")]
	[FieldOffset(Offset = "0x2B")]
	public bool m_OverrideEmissiveColor;

	[Token(Token = "0x4009161")]
	[FieldOffset(Offset = "0x2C")]
	public Color m_OverrideColor;

	[Token(Token = "0x6007EA7")]
	[Address(RVA = "0x11E37E0", Offset = "0x11E25E0", Length = "0x2E")]
	public IntensityParameters()
	{
	}
}
