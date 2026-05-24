using System;
using Cpp2ILInjected;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
[Token(Token = "0x20009B3")]
public class ButtonAttribute : PropertyAttribute
{
	[Token(Token = "0x4006324")]
	[FieldOffset(Offset = "0x18")]
	public string buttonLabel;

	[Token(Token = "0x4006325")]
	[FieldOffset(Offset = "0x20")]
	public string methodName;

	[Token(Token = "0x4006326")]
	[FieldOffset(Offset = "0x28")]
	public bool isActiveAtRuntime;

	[Token(Token = "0x4006327")]
	[FieldOffset(Offset = "0x29")]
	public bool isActiveInEditor;

	[Token(Token = "0x600563C")]
	[Address(RVA = "0xEB4040", Offset = "0xEB2E40", Length = "0xD8")]
	public ButtonAttribute(string buttonLabel, string methodName, int order = 1)
	{
	}
}
