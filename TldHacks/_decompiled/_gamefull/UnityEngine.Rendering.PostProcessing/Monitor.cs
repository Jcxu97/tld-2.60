using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CC0")]
public abstract class Monitor
{
	[Token(Token = "0x4007F3A")]
	[FieldOffset(Offset = "0x18")]
	internal bool requested;

	[Token(Token = "0x170006C3")]
	[field: Token(Token = "0x4007F39")]
	[field: FieldOffset(Offset = "0x10")]
	public RenderTexture output
	{
		[Token(Token = "0x600652C")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x600652D")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		protected set;
	}

	[Token(Token = "0x600652E")]
	[Address(RVA = "0x100F470", Offset = "0x100E270", Length = "0xEC")]
	public bool IsRequestedAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x600652F")]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[Token(Token = "0x6006530")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	internal virtual bool NeedsHalfRes()
	{
		return false;
	}

	[Token(Token = "0x6006531")]
	[Address(RVA = "0x100F560", Offset = "0x100E360", Length = "0x23B")]
	protected void CheckOutput(int width, int height)
	{
	}

	[Token(Token = "0x6006532")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	internal virtual void OnEnable()
	{
	}

	[Token(Token = "0x6006533")]
	[Address(RVA = "0x100F7A0", Offset = "0x100E5A0", Length = "0x52")]
	internal virtual void OnDisable()
	{
	}

	[Token(Token = "0x6006534")]
	internal abstract void Render(PostProcessRenderContext context);

	[Token(Token = "0x6006535")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected Monitor()
	{
	}
}
