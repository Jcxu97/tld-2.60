using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
[Token(Token = "0x2000C7C")]
public sealed class TrackballAttribute : Attribute
{
	[Token(Token = "0x2000C7D")]
	public enum Mode
	{
		[Token(Token = "0x4007DC5")]
		None,
		[Token(Token = "0x4007DC6")]
		Lift,
		[Token(Token = "0x4007DC7")]
		Gamma,
		[Token(Token = "0x4007DC8")]
		Gain
	}

	[Token(Token = "0x4007DC3")]
	[FieldOffset(Offset = "0x10")]
	public readonly Mode mode;

	[Token(Token = "0x6006483")]
	[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
	public TrackballAttribute(Mode mode)
	{
	}
}
