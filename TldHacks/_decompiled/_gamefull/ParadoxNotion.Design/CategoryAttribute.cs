using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.All)]
[Token(Token = "0x2000DC2")]
public class CategoryAttribute : Attribute
{
	[Token(Token = "0x4008478")]
	[FieldOffset(Offset = "0x10")]
	public readonly string category;

	[Token(Token = "0x6006AD6")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public CategoryAttribute(string category)
	{
	}
}
