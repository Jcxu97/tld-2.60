using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
[Token(Token = "0x2000D8D")]
public sealed class fsForwardAttribute : Attribute
{
	[Token(Token = "0x400842F")]
	[FieldOffset(Offset = "0x10")]
	public string MemberName;

	[Token(Token = "0x60069AA")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public fsForwardAttribute(string memberName)
	{
	}
}
