using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[Token(Token = "0x200135C")]
internal class GameObjectWithComponentAsset : AssetReferenceUIRestriction
{
	[Token(Token = "0x17000A55")]
	[field: Token(Token = "0x4008E95")]
	[field: FieldOffset(Offset = "0x10")]
	private Type ComponentType
	{
		[Token(Token = "0x6007BA1")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6007BA2")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x6007BA3")]
	[Address(RVA = "0x11A8000", Offset = "0x11A6E00", Length = "0x13F")]
	public GameObjectWithComponentAsset(Type type)
	{
	}

	[Token(Token = "0x6007BA4")]
	[Address(RVA = "0x11A8140", Offset = "0x11A6F40", Length = "0x2B7")]
	public override bool ValidateAsset(UnityEngine.Object obj)
	{
		return false;
	}

	[Token(Token = "0x6007BA5")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public override bool ValidateAsset(string path)
	{
		return false;
	}
}
