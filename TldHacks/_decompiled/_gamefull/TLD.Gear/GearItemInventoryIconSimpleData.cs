using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Inventory Icons/Simple")]
[Token(Token = "0x200143B")]
public class GearItemInventoryIconSimpleData : GearItemInventoryIconData
{
	[SerializeField]
	[Token(Token = "0x400936A")]
	[FieldOffset(Offset = "0x18")]
	private Texture2D m_Icon;

	[Token(Token = "0x6008118")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public override Texture2D GetInventoryIcon(GearItem item)
	{
		return null;
	}

	[Token(Token = "0x6008119")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public override Texture2D GetInventoryIcon(float condition)
	{
		return null;
	}

	[Token(Token = "0x600811A")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public GearItemInventoryIconSimpleData()
	{
	}
}
