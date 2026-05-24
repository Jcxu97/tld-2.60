using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.All)]
[Token(Token = "0x2000DC1")]
public class NameAttribute : Attribute
{
	[Token(Token = "0x4008476")]
	[FieldOffset(Offset = "0x10")]
	public readonly string name;

	[Token(Token = "0x4008477")]
	[FieldOffset(Offset = "0x18")]
	public readonly int priority;

	[Token(Token = "0x6006AD5")]
	[Address(RVA = "0x409680", Offset = "0x408480", Length = "0x5B")]
	public NameAttribute(string name, int priority = 0)
	{
	}
}
