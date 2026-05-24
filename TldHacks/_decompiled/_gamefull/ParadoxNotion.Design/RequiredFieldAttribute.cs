using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DC8")]
public class RequiredFieldAttribute : DrawerAttribute
{
	[Token(Token = "0x17000753")]
	public override int priority
	{
		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006AE0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RequiredFieldAttribute()
	{
	}
}
