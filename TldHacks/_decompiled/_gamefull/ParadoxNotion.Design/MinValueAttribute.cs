using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DCA")]
public class MinValueAttribute : DrawerAttribute
{
	[Token(Token = "0x4008482")]
	[FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x17000755")]
	public override int priority
	{
		[Token(Token = "0x6006AE3")]
		[Address(RVA = "0x457130", Offset = "0x455F30", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006AE4")]
	[Address(RVA = "0x4A7A10", Offset = "0x4A6810", Length = "0x6")]
	public MinValueAttribute(float min)
	{
	}

	[Token(Token = "0x6006AE5")]
	[Address(RVA = "0x1094F10", Offset = "0x1093D10", Length = "0xD")]
	public MinValueAttribute(int min)
	{
	}
}
