using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003D1")]
public class LinkLightIntensityToEmissiveTex : MonoBehaviour
{
	[Token(Token = "0x4002285")]
	[FieldOffset(Offset = "0x20")]
	public Light m_SourceLight;

	[Token(Token = "0x4002286")]
	[FieldOffset(Offset = "0x28")]
	public Material m_DestinationMaterial;

	[Token(Token = "0x4002287")]
	[FieldOffset(Offset = "0x30")]
	public float m_IntensityMultiplier;

	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x7AB700", Offset = "0x7AA500", Length = "0xC5")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x4BB120", Offset = "0x4B9F20", Length = "0x4A")]
	public LinkLightIntensityToEmissiveTex()
	{
	}
}
