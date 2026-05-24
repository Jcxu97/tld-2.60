using System;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[Token(Token = "0x200104F")]
public class CanvasGroup
{
	[Token(Token = "0x4008522")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4008523")]
	[FieldOffset(Offset = "0x18")]
	public Rect rect;

	[Token(Token = "0x4008524")]
	[FieldOffset(Offset = "0x28")]
	public Color color;

	[Token(Token = "0x6006E36")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CanvasGroup()
	{
	}

	[Token(Token = "0x6006E37")]
	[Address(RVA = "0x10B5F90", Offset = "0x10B4D90", Length = "0x52")]
	public CanvasGroup(Rect rect, string name)
	{
	}
}
