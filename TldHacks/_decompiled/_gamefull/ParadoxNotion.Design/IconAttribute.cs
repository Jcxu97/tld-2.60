using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Class)]
[Token(Token = "0x2000DC4")]
public class IconAttribute : Attribute
{
	[Token(Token = "0x400847A")]
	[FieldOffset(Offset = "0x10")]
	public readonly string iconName;

	[Token(Token = "0x400847B")]
	[FieldOffset(Offset = "0x18")]
	public readonly bool fixedColor;

	[Token(Token = "0x400847C")]
	[FieldOffset(Offset = "0x20")]
	public readonly string runtimeIconTypeCallback;

	[Token(Token = "0x400847D")]
	[FieldOffset(Offset = "0x28")]
	public readonly Type fromType;

	[Token(Token = "0x6006AD8")]
	[Address(RVA = "0x1094E40", Offset = "0x1093C40", Length = "0xBF")]
	public IconAttribute(string iconName = "", bool fixedColor = false, string runtimeIconTypeCallback = "")
	{
	}

	[Token(Token = "0x6006AD9")]
	[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
	public IconAttribute(Type fromType)
	{
	}
}
