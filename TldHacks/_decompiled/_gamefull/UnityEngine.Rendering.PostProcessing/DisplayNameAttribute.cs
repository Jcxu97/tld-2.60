using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
[Token(Token = "0x2000C77")]
public sealed class DisplayNameAttribute : Attribute
{
	[Token(Token = "0x4007DB9")]
	[FieldOffset(Offset = "0x10")]
	public readonly string displayName;

	[Token(Token = "0x600647D")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public DisplayNameAttribute(string displayName)
	{
	}
}
