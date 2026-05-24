using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000308")]
public class LodBias : MonoBehaviour
{
	[Token(Token = "0x4001A92")]
	public static float DEFAULT_LODBIAS_PCLOW;

	[Token(Token = "0x4001A93")]
	public static float DEFAULT_LODBIAS_PCMEDIUM;

	[Token(Token = "0x4001A94")]
	public static float DEFAULT_LODBIAS_PCHIGH;

	[Token(Token = "0x4001A95")]
	public static float DEFAULT_LODBIAS_PCULTRA;

	[Token(Token = "0x4001A96")]
	public static float DEFAULT_LODBIAS_PCFANCY;

	[Token(Token = "0x4001A97")]
	[FieldOffset(Offset = "0x20")]
	public float m_PcLowBias;

	[Token(Token = "0x4001A98")]
	[FieldOffset(Offset = "0x24")]
	public float m_PcMediumBias;

	[Token(Token = "0x4001A99")]
	[FieldOffset(Offset = "0x28")]
	public float m_PcHighBias;

	[Token(Token = "0x4001A9A")]
	[FieldOffset(Offset = "0x2C")]
	public float m_PcUltraBias;

	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x6F7430", Offset = "0x6F6230", Length = "0x158")]
	public float GetLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x6F7590", Offset = "0x6F6390", Length = "0x1D3")]
	public static float GetDefaultLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x6F7770", Offset = "0x6F6570", Length = "0xD2")]
	public LodBias()
	{
	}
}
