using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D91")]
public class fsConfig
{
	[Token(Token = "0x4008435")]
	[FieldOffset(Offset = "0x10")]
	public Type[] SerializeAttributes;

	[Token(Token = "0x4008436")]
	[FieldOffset(Offset = "0x18")]
	public Type[] IgnoreSerializeAttributes;

	[Token(Token = "0x4008437")]
	[FieldOffset(Offset = "0x20")]
	public string CustomDateTimeFormatString;

	[Token(Token = "0x4008438")]
	[FieldOffset(Offset = "0x28")]
	public bool Serialize64BitIntegerAsString;

	[Token(Token = "0x4008439")]
	[FieldOffset(Offset = "0x29")]
	public bool SerializeEnumsAsInteger;

	[Token(Token = "0x60069BA")]
	[Address(RVA = "0x1078C20", Offset = "0x1077A20", Length = "0x368")]
	public fsConfig()
	{
	}
}
