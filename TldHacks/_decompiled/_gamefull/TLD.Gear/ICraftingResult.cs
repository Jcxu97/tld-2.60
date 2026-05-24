using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.Placement;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x200141F")]
public interface ICraftingResult
{
	[Token(Token = "0x600803F")]
	string GetCraftingDisplayName();

	[Token(Token = "0x6008040")]
	StackableItem GetStackableItem();

	[Token(Token = "0x6008041")]
	string GetDescription();

	[Token(Token = "0x6008042")]
	Texture2D GetInventoryIconTexture();

	[Token(Token = "0x6008043")]
	ItemWeight GetItemWeightKG(float stackMultiplier, bool ignoreClothingBonus);

	[Token(Token = "0x6008044")]
	InProgressCraftItem InitializeCraftInProgress();

	[Token(Token = "0x6008045")]
	[Address(RVA = "0x1205F30", Offset = "0x1204D30", Length = "0x12A")]
	string GetObjectName()
	{
		return null;
	}

	[Token(Token = "0x6008046")]
	bool AllowedInInventory();

	[Token(Token = "0x6008047")]
	PlaceMeshRules GetPlacementRules();
}
