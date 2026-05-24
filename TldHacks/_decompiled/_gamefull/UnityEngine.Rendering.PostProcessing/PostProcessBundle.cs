using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CCF")]
public sealed class PostProcessBundle
{
	[Token(Token = "0x4007F51")]
	[FieldOffset(Offset = "0x20")]
	private PostProcessEffectRenderer m_Renderer;

	[Token(Token = "0x170006C4")]
	[field: Token(Token = "0x4007F4F")]
	[field: FieldOffset(Offset = "0x10")]
	public PostProcessAttribute attribute
	{
		[Token(Token = "0x6006571")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006572")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170006C5")]
	[field: Token(Token = "0x4007F50")]
	[field: FieldOffset(Offset = "0x18")]
	public PostProcessEffectSettings settings
	{
		[Token(Token = "0x6006573")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006574")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170006C6")]
	internal PostProcessEffectRenderer renderer
	{
		[Token(Token = "0x6006575")]
		[Address(RVA = "0x10127D0", Offset = "0x10115D0", Length = "0x16D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006576")]
	[Address(RVA = "0x1012940", Offset = "0x1011740", Length = "0x14E")]
	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	[Token(Token = "0x6006577")]
	[Address(RVA = "0x1012A90", Offset = "0x1011890", Length = "0x6B")]
	internal void Release()
	{
	}

	[Token(Token = "0x6006578")]
	[Address(RVA = "0x1012B00", Offset = "0x1011900", Length = "0x1B")]
	internal void ResetHistory()
	{
	}

	[Token(Token = "0x6006579")]
	[Address(RVA = "0x1971B50", Offset = "0x1970950", Length = "0x6B")]
	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x600657A")]
	[Address(RVA = "0x1971AD0", Offset = "0x19708D0", Length = "0x74")]
	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
