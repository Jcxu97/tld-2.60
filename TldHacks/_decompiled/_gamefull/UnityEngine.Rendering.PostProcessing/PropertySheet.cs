using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CF8")]
public sealed class PropertySheet
{
	[Token(Token = "0x170006F4")]
	[field: Token(Token = "0x400804A")]
	[field: FieldOffset(Offset = "0x10")]
	public MaterialPropertyBlock properties
	{
		[Token(Token = "0x6006688")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006689")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170006F5")]
	[field: Token(Token = "0x400804B")]
	[field: FieldOffset(Offset = "0x18")]
	internal Material material
	{
		[Token(Token = "0x600668A")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x600668B")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x600668C")]
	[Address(RVA = "0x1029ED0", Offset = "0x1028CD0", Length = "0x13F")]
	internal PropertySheet(Material material)
	{
	}

	[Token(Token = "0x600668D")]
	[Address(RVA = "0x102A010", Offset = "0x1028E10", Length = "0x20")]
	public void ClearKeywords()
	{
	}

	[Token(Token = "0x600668E")]
	[Address(RVA = "0x102A040", Offset = "0x1028E40", Length = "0x1E")]
	public void EnableKeyword(string keyword)
	{
	}

	[Token(Token = "0x600668F")]
	[Address(RVA = "0x102A060", Offset = "0x1028E60", Length = "0x1E")]
	public void DisableKeyword(string keyword)
	{
	}

	[Token(Token = "0x6006690")]
	[Address(RVA = "0x102A080", Offset = "0x1028E80", Length = "0xAC")]
	internal void Release()
	{
	}
}
