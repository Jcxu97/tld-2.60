using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Inventory Icons/Openable (Smashable)")]
[Token(Token = "0x200143A")]
public class GearItemInventoryIconFoodData : GearItemInventoryIconData
{
	[SerializeField]
	[Token(Token = "0x4009368")]
	[FieldOffset(Offset = "0x18")]
	private Texture2D m_NormalTexture;

	[SerializeField]
	[Token(Token = "0x4009369")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D m_OpenedTexture;

	[Token(Token = "0x6008115")]
	[Address(RVA = "0x12154E0", Offset = "0x12142E0", Length = "0x257")]
	public override Texture2D GetInventoryIcon(GearItem item)
	{
		return null;
	}

	[Token(Token = "0x6008116")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public override Texture2D GetInventoryIcon(float condition)
	{
		return null;
	}

	[Token(Token = "0x6008117")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public GearItemInventoryIconFoodData()
	{
	}
}
