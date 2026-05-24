using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DC7")]
public class ShowIfAttribute : DrawerAttribute
{
	[Token(Token = "0x400847F")]
	[FieldOffset(Offset = "0x10")]
	public readonly string fieldName;

	[Token(Token = "0x4008480")]
	[FieldOffset(Offset = "0x18")]
	public readonly int checkValue;

	[Token(Token = "0x17000752")]
	public override int priority
	{
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006ADE")]
	[Address(RVA = "0x409680", Offset = "0x408480", Length = "0x5B")]
	public ShowIfAttribute(string fieldName, int checkValue)
	{
	}
}
