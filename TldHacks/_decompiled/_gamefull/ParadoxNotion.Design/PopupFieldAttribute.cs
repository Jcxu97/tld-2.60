using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DCF")]
public class PopupFieldAttribute : DrawerAttribute
{
	[Token(Token = "0x4008484")]
	[FieldOffset(Offset = "0x10")]
	public readonly object[] options;

	[Token(Token = "0x6006AEA")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public PopupFieldAttribute(params object[] options)
	{
	}
}
