using System;
using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x200104E")]
public class BlackboardOnlyAttribute : Attribute
{
	[Token(Token = "0x6006E35")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BlackboardOnlyAttribute()
	{
	}
}
