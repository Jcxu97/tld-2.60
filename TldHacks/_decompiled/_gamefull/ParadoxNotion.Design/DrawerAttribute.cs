using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DC6")]
public abstract class DrawerAttribute : Attribute
{
	[Token(Token = "0x17000751")]
	public virtual int priority
	{
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x1094F00", Offset = "0x1093D00", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006ADC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected DrawerAttribute()
	{
	}
}
