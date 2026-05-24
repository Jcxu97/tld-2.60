using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CF5")]
internal sealed class LogHistogram
{
	[Token(Token = "0x4008044")]
	public const int rangeMin = -9;

	[Token(Token = "0x4008045")]
	public const int rangeMax = 9;

	[Token(Token = "0x4008046")]
	private const int k_Bins = 128;

	[Token(Token = "0x170006F3")]
	[field: Token(Token = "0x4008047")]
	[field: FieldOffset(Offset = "0x10")]
	public ComputeBuffer data
	{
		[Token(Token = "0x600667D")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x600667E")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x600667F")]
	[Address(RVA = "0x1028E20", Offset = "0x1027C20", Length = "0x695")]
	public void Generate(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006680")]
	[Address(RVA = "0x10294C0", Offset = "0x10282C0", Length = "0x45")]
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6006681")]
	[Address(RVA = "0x1029510", Offset = "0x1028310", Length = "0x67")]
	public void Release()
	{
	}

	[Token(Token = "0x6006682")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LogHistogram()
	{
	}
}
