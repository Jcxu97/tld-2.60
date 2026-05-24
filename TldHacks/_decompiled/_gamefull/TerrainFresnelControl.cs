using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000310")]
public class TerrainFresnelControl : MonoBehaviour
{
	[Token(Token = "0x4001AEF")]
	[FieldOffset(Offset = "0x20")]
	public float m_FresnelExponent;

	[Token(Token = "0x4001AF0")]
	[FieldOffset(Offset = "0x24")]
	public float m_FresnelBias;

	[Token(Token = "0x4001AF1")]
	[FieldOffset(Offset = "0x28")]
	public float m_FresnelGain;

	[Token(Token = "0x4001AF2")]
	[FieldOffset(Offset = "0x2C")]
	public Color m_FresnelColour;

	[Token(Token = "0x4001AF3")]
	[FieldOffset(Offset = "0x40")]
	private Terrain m_Terrain;

	[Token(Token = "0x4001AF4")]
	[FieldOffset(Offset = "0x48")]
	private Material m_TerrainMat;

	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x6F90B0", Offset = "0x6F7EB0", Length = "0x3AA")]
	private void Start()
	{
	}

	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x6F9460", Offset = "0x6F8260", Length = "0x1F0")]
	public void UpdateFresnel(float fresnelExponent, float fresnelBias, float fresnelGain, Color fresnelColour)
	{
	}

	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x6F9660", Offset = "0x6F8460", Length = "0x68")]
	public TerrainFresnelControl()
	{
	}
}
