using System;
using Cpp2ILInjected;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
[Token(Token = "0x2000D08")]
public class effectPreset
{
	[Token(Token = "0x4008130")]
	[FieldOffset(Offset = "0x10")]
	public string effectName;

	[Token(Token = "0x4008131")]
	[FieldOffset(Offset = "0x18")]
	public int numberOfColors;

	[Token(Token = "0x4008132")]
	[FieldOffset(Offset = "0x20")]
	public Color32[] palette;

	[Token(Token = "0x4008133")]
	[FieldOffset(Offset = "0x28")]
	public bool changed;

	[Token(Token = "0x4008134")]
	[FieldOffset(Offset = "0x30")]
	public Color32[] pixels;

	[Token(Token = "0x60066FA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public effectPreset()
	{
	}
}
