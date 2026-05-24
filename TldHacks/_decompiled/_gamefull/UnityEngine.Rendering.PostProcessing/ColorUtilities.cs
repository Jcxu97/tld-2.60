using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CEF")]
public static class ColorUtilities
{
	[Token(Token = "0x4008028")]
	private const float logC_cut = 0.011361f;

	[Token(Token = "0x4008029")]
	private const float logC_a = 5.555556f;

	[Token(Token = "0x400802A")]
	private const float logC_b = 0.047996f;

	[Token(Token = "0x400802B")]
	private const float logC_c = 0.244161f;

	[Token(Token = "0x400802C")]
	private const float logC_d = 0.386036f;

	[Token(Token = "0x400802D")]
	private const float logC_e = 5.301883f;

	[Token(Token = "0x400802E")]
	private const float logC_f = 0.092819f;

	[Token(Token = "0x6006659")]
	[Address(RVA = "0x10279D0", Offset = "0x10267D0", Length = "0x2A")]
	public static float StandardIlluminantY(float x)
	{
		return 0f;
	}

	[Token(Token = "0x600665A")]
	[Address(RVA = "0x1027A00", Offset = "0x1026800", Length = "0x8D")]
	public static Vector3 CIExyToLMS(float x, float y)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600665B")]
	[Address(RVA = "0x1027A90", Offset = "0x1026890", Length = "0x122")]
	public static Vector3 ComputeColorBalance(float temperature, float tint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600665C")]
	[Address(RVA = "0x1027BC0", Offset = "0x10269C0", Length = "0x66")]
	public static Vector3 ColorToLift(Vector4 color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600665D")]
	[Address(RVA = "0x1027C30", Offset = "0x1026A30", Length = "0xA8")]
	public static Vector3 ColorToInverseGamma(Vector4 color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600665E")]
	[Address(RVA = "0x1027CE0", Offset = "0x1026AE0", Length = "0x6E")]
	public static Vector3 ColorToGain(Vector4 color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600665F")]
	[Address(RVA = "0x1027D50", Offset = "0x1026B50", Length = "0x57")]
	public static float LogCToLinear(float x)
	{
		return 0f;
	}

	[Token(Token = "0x6006660")]
	[Address(RVA = "0x1027DB0", Offset = "0x1026BB0", Length = "0x4C")]
	public static float LinearToLogC(float x)
	{
		return 0f;
	}

	[Token(Token = "0x6006661")]
	[Address(RVA = "0x1027E00", Offset = "0x1026C00", Length = "0x8F")]
	public static uint ToHex(Color c)
	{
		return 0u;
	}

	[Token(Token = "0x6006662")]
	[Address(RVA = "0x1027E90", Offset = "0x1026C90", Length = "0x77")]
	public static Color ToRGBA(uint hex)
	{
		return default(Color);
	}
}
