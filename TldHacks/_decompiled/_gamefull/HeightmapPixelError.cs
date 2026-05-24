using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002FF")]
public class HeightmapPixelError : MonoBehaviour
{
	[Token(Token = "0x4001A73")]
	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_ULTRA;

	[Token(Token = "0x4001A74")]
	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_HIGH;

	[Token(Token = "0x4001A75")]
	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_MEDIUM;

	[Token(Token = "0x4001A76")]
	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_LOW;

	[Token(Token = "0x4001A77")]
	[FieldOffset(Offset = "0x20")]
	public float m_Ultra;

	[Token(Token = "0x4001A78")]
	[FieldOffset(Offset = "0x24")]
	public float m_High;

	[Token(Token = "0x4001A79")]
	[FieldOffset(Offset = "0x28")]
	public float m_Medium;

	[Token(Token = "0x4001A7A")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Low;

	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x6F5790", Offset = "0x6F4590", Length = "0x104")]
	public float GetPixelError(QualityTerrainLod quality)
	{
		return 0f;
	}

	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x6F58A0", Offset = "0x6F46A0", Length = "0x199")]
	public static float GetDefaultPixelError(QualityTerrainLod quality)
	{
		return 0f;
	}

	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x6F5A40", Offset = "0x6F4840", Length = "0xD2")]
	public HeightmapPixelError()
	{
	}
}
