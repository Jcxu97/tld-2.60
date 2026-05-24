using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
[Token(Token = "0x2000C79")]
public sealed class MinAttribute : Attribute
{
	[Token(Token = "0x4007DBB")]
	[FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x600647F")]
	[Address(RVA = "0x4A7A10", Offset = "0x4A6810", Length = "0x6")]
	public MinAttribute(float min)
	{
	}
}
