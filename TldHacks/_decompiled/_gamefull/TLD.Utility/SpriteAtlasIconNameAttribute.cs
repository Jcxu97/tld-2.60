using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Utility;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
[Token(Token = "0x200134D")]
public class SpriteAtlasIconNameAttribute : PropertyAttribute
{
	[Token(Token = "0x4008E2E")]
	private const string BaseAtlas = "Base Atlas_hd";

	[Token(Token = "0x17000A50")]
	[field: Token(Token = "0x4008E2F")]
	[field: FieldOffset(Offset = "0x18")]
	public string Atlas
	{
		[Token(Token = "0x6007B75")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6007B76")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6007B77")]
	[Address(RVA = "0x11A1980", Offset = "0x11A0780", Length = "0x87")]
	public SpriteAtlasIconNameAttribute()
	{
	}

	[Token(Token = "0x6007B78")]
	[Address(RVA = "0x4A5700", Offset = "0x4A4500", Length = "0x52")]
	public SpriteAtlasIconNameAttribute(string atlas)
	{
	}
}
