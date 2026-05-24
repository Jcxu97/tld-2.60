using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Class)]
[Token(Token = "0x2000DBC")]
public class DoNotListAttribute : Attribute
{
	[Token(Token = "0x6006AD0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DoNotListAttribute()
	{
	}
}
