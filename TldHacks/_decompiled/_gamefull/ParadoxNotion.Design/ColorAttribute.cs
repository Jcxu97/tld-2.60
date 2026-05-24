using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Class)]
[Token(Token = "0x2000DC5")]
public class ColorAttribute : Attribute
{
	[Token(Token = "0x400847E")]
	[FieldOffset(Offset = "0x10")]
	public readonly string hexColor;

	[Token(Token = "0x6006ADA")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public ColorAttribute(string hexColor)
	{
	}
}
