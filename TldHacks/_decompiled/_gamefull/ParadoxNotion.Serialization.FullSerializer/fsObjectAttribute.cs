using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
[Token(Token = "0x2000D9B")]
public sealed class fsObjectAttribute : Attribute
{
	[Token(Token = "0x400844A")]
	[FieldOffset(Offset = "0x10")]
	public Type Converter;

	[Token(Token = "0x400844B")]
	[FieldOffset(Offset = "0x18")]
	public Type Processor;

	[Token(Token = "0x6006A0F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsObjectAttribute()
	{
	}
}
