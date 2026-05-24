using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001439")]
public abstract class GearItemInventoryIconData : ScriptableObject
{
	[Token(Token = "0x6008112")]
	public abstract Texture2D GetInventoryIcon(GearItem item);

	[Token(Token = "0x6008113")]
	public abstract Texture2D GetInventoryIcon(float conditionPercent);

	[Token(Token = "0x6008114")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected GearItemInventoryIconData()
	{
	}
}
