using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.All)]
[Token(Token = "0x2000DC3")]
public class DescriptionAttribute : Attribute
{
	[Token(Token = "0x4008479")]
	[FieldOffset(Offset = "0x10")]
	public readonly string description;

	[Token(Token = "0x6006AD7")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public DescriptionAttribute(string description)
	{
	}
}
