using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
[Token(Token = "0x2000D09")]
public class effectPresets : ScriptableObject
{
	[Token(Token = "0x4008135")]
	[FieldOffset(Offset = "0x18")]
	public List<ColorPalettePreset> presetsList;

	[Token(Token = "0x60066FB")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public effectPresets()
	{
	}
}
