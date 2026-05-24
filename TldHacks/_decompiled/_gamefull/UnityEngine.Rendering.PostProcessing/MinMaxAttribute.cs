using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
[Token(Token = "0x2000C7A")]
public sealed class MinMaxAttribute : Attribute
{
	[Token(Token = "0x4007DBC")]
	[FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x4007DBD")]
	[FieldOffset(Offset = "0x14")]
	public readonly float max;

	[Token(Token = "0x6006480")]
	[Address(RVA = "0xEEC480", Offset = "0xEEB280", Length = "0xB")]
	public MinMaxAttribute(float min, float max)
	{
	}
}
