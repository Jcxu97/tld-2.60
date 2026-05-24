using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000D98")]
public sealed class fsIgnoreAttribute : Attribute
{
	[Token(Token = "0x60069EC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsIgnoreAttribute()
	{
	}
}
