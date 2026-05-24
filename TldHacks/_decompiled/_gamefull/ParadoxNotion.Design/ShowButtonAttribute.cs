using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DD1")]
public class ShowButtonAttribute : DrawerAttribute
{
	[Token(Token = "0x4008487")]
	[FieldOffset(Offset = "0x10")]
	public readonly string buttonTitle;

	[Token(Token = "0x4008488")]
	[FieldOffset(Offset = "0x18")]
	public readonly string methodnameCallback;

	[Token(Token = "0x6006AED")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public ShowButtonAttribute(string buttonTitle, string methodnameCallback)
	{
	}
}
