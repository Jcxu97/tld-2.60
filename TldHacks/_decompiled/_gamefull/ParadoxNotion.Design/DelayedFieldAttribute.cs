using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DCB")]
public class DelayedFieldAttribute : DrawerAttribute
{
	[Token(Token = "0x6006AE6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DelayedFieldAttribute()
	{
	}
}
