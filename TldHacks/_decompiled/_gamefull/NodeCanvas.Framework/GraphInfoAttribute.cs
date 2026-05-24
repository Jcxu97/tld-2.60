using System;
using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[AttributeUsage(AttributeTargets.Class)]
[Token(Token = "0x200104C")]
public class GraphInfoAttribute : Attribute
{
	[Token(Token = "0x400851D")]
	[FieldOffset(Offset = "0x10")]
	public string packageName;

	[Token(Token = "0x400851E")]
	[FieldOffset(Offset = "0x18")]
	public string docsURL;

	[Token(Token = "0x400851F")]
	[FieldOffset(Offset = "0x20")]
	public string resourcesURL;

	[Token(Token = "0x4008520")]
	[FieldOffset(Offset = "0x28")]
	public string forumsURL;

	[Token(Token = "0x6006E33")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GraphInfoAttribute()
	{
	}
}
