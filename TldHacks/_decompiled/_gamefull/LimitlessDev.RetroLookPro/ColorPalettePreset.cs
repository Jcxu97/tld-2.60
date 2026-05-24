using System;
using Cpp2ILInjected;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
[Token(Token = "0x2000D07")]
public class ColorPalettePreset : ScriptableObject
{
	[Token(Token = "0x400812F")]
	[FieldOffset(Offset = "0x18")]
	public effectPreset preset;

	[Token(Token = "0x60066F9")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ColorPalettePreset()
	{
	}
}
