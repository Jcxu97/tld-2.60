using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization;

[Token(Token = "0x2000D7C")]
public class DeserializeFromAttribute : Attribute
{
	[Token(Token = "0x4008406")]
	[FieldOffset(Offset = "0x10")]
	public readonly string[] previousTypeFullNames;

	[Token(Token = "0x6006950")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public DeserializeFromAttribute(params string[] previousTypeNames)
	{
	}
}
