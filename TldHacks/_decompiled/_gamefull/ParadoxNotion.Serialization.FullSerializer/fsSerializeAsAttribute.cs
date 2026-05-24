using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000D9D")]
public sealed class fsSerializeAsAttribute : Attribute
{
	[Token(Token = "0x400844C")]
	[FieldOffset(Offset = "0x10")]
	public readonly string Name;

	[Token(Token = "0x6006A17")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public fsSerializeAsAttribute(string name)
	{
	}
}
