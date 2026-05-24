using Cpp2ILInjected;

[Token(Token = "0x2000019")]
public class vp_FractalNoise
{
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x10")]
	private vp_Perlin m_Noise;

	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x18")]
	private float[] m_Exponent;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x20")]
	private int m_IntOctaves;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x24")]
	private float m_Octaves;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x28")]
	private float m_Lacunarity;

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x577570", Offset = "0x576370", Length = "0x1A")]
	public vp_FractalNoise(float inH, float inLacunarity, float inOctaves)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x577590", Offset = "0x576390", Length = "0x26B")]
	public vp_FractalNoise(float inH, float inLacunarity, float inOctaves, vp_Perlin noise)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x577800", Offset = "0x576600", Length = "0x183")]
	public float HybridMultifractal(float x, float y, float offset)
	{
		return 0f;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x577990", Offset = "0x576790", Length = "0x183")]
	public float RidgedMultifractal(float x, float y, float offset, float gain)
	{
		return 0f;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x577B20", Offset = "0x576920", Length = "0x12E")]
	public float BrownianMotion(float x, float y)
	{
		return 0f;
	}
}
