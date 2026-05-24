using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DCE")]
public class TextAreaFieldAttribute : DrawerAttribute
{
	[Token(Token = "0x4008483")]
	[FieldOffset(Offset = "0x10")]
	public readonly int numberOfLines;

	[Token(Token = "0x6006AE9")]
	[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
	public TextAreaFieldAttribute(int numberOfLines)
	{
	}
}
