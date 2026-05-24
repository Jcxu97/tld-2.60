using Cpp2ILInjected;

[Token(Token = "0x2000018")]
public class vp_Perlin
{
	[Token(Token = "0x40001E6")]
	private const int B = 256;

	[Token(Token = "0x40001E7")]
	private const int BM = 255;

	[Token(Token = "0x40001E8")]
	private const int N = 4096;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x10")]
	private int[] p;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x18")]
	private float[,] g3;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x20")]
	private float[,] g2;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x28")]
	private float[] g1;

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x5761B0", Offset = "0x574FB0", Length = "0x1C")]
	private float s_curve(float t)
	{
		return 0f;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x5761D0", Offset = "0x574FD0", Length = "0x10")]
	private float lerp(float t, float a, float b)
	{
		return 0f;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x5761E0", Offset = "0x574FE0", Length = "0x40")]
	private void setup(float value, out int b0, out int b1, out float r0, out float r1)
	{
		b0 = default(int);
		b1 = default(int);
		r0 = default(float);
		r1 = default(float);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x576220", Offset = "0x575020", Length = "0x12")]
	private float at2(float rx, float ry, float x, float y)
	{
		return 0f;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x576240", Offset = "0x575040", Length = "0x1E")]
	private float at3(float rx, float ry, float rz, float x, float y, float z)
	{
		return 0f;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x576260", Offset = "0x575060", Length = "0xAE")]
	public float Noise(float arg)
	{
		return 0f;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x576310", Offset = "0x575110", Length = "0x2FC")]
	public float Noise(float x, float y)
	{
		return 0f;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x576610", Offset = "0x575410", Length = "0x6EF")]
	public float Noise(float x, float y, float z)
	{
		return 0f;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x576D00", Offset = "0x575B00", Length = "0xB2")]
	private void normalize2(ref float x, ref float y)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x576DC0", Offset = "0x575BC0", Length = "0xE6")]
	private void normalize3(ref float x, ref float y, ref float z)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x576EB0", Offset = "0x575CB0", Length = "0x6BF")]
	public vp_Perlin()
	{
	}
}
