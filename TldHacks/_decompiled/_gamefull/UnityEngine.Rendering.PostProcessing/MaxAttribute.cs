using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
[Token(Token = "0x2000C78")]
public sealed class MaxAttribute : Attribute
{
	[Token(Token = "0x4007DBA")]
	[FieldOffset(Offset = "0x10")]
	public readonly float max;

	[Token(Token = "0x600647E")]
	[Address(RVA = "0x4A7A10", Offset = "0x4A6810", Length = "0x6")]
	public MaxAttribute(float max)
	{
	}
}
