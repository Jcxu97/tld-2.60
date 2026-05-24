using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Class)]
[Token(Token = "0x2000DBE")]
public class ExecutionPriorityAttribute : Attribute
{
	[Token(Token = "0x4008475")]
	[FieldOffset(Offset = "0x10")]
	public readonly int priority;

	[Token(Token = "0x6006AD2")]
	[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
	public ExecutionPriorityAttribute(int priority)
	{
	}
}
