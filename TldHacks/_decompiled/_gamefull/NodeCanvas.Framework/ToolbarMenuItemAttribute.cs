using System;
using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[AttributeUsage(AttributeTargets.Method)]
[Token(Token = "0x200104D")]
public class ToolbarMenuItemAttribute : Attribute
{
	[Token(Token = "0x4008521")]
	[FieldOffset(Offset = "0x10")]
	public readonly string path;

	[Token(Token = "0x6006E34")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public ToolbarMenuItemAttribute(string path)
	{
	}
}
