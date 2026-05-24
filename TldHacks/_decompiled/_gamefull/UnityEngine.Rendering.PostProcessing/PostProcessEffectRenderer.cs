using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CD5")]
public abstract class PostProcessEffectRenderer
{
	[Token(Token = "0x4007F7B")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_ResetHistory;

	[Token(Token = "0x6006597")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6006598")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public virtual DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6006599")]
	[Address(RVA = "0x4A1DD0", Offset = "0x4A0BD0", Length = "0x5")]
	public virtual void ResetHistory()
	{
	}

	[Token(Token = "0x600659A")]
	[Address(RVA = "0x9F0CA0", Offset = "0x9EFAA0", Length = "0x11")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x600659B")]
	public abstract void Render(PostProcessRenderContext context);

	[Token(Token = "0x600659C")]
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	[Token(Token = "0x600659D")]
	[Address(RVA = "0x4A1DD0", Offset = "0x4A0BD0", Length = "0x5")]
	protected PostProcessEffectRenderer()
	{
	}
}
[Token(Token = "0x2000CD6")]
public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
{
	[Token(Token = "0x170006CA")]
	public T settings
	{
		[Token(Token = "0x600659E")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x600659F")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		internal set;
	}

	[Token(Token = "0x60065A0")]
	[Address(RVA = "0x1E786B0", Offset = "0x1E774B0", Length = "0xBC")]
	internal override void SetSettings(PostProcessEffectSettings settings)
	{
	}

	[Token(Token = "0x60065A1")]
	[Address(RVA = "0x4A1DD0", Offset = "0x4A0BD0", Length = "0x5")]
	protected PostProcessEffectRenderer()
	{
	}
}
