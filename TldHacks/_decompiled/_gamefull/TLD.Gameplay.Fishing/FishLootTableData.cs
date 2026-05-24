using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

[CreateAssetMenu(menuName = "The Long Dark/Fishing/Fish Loot Table")]
[Token(Token = "0x20014C4")]
public class FishLootTableData : LootTableData
{
	[SerializeField]
	[Token(Token = "0x40095EE")]
	[FieldOffset(Offset = "0x38")]
	private GameplayTag m_RareFishTag;

	[Token(Token = "0x40095EF")]
	[FieldOffset(Offset = "0x48")]
	private float m_LureModifier;

	[Token(Token = "0x60082FF")]
	[Address(RVA = "0x1240180", Offset = "0x123EF80", Length = "0xC7")]
	public void SetLureModifier(float modifier)
	{
	}

	[Token(Token = "0x6008300")]
	[Address(RVA = "0x1240250", Offset = "0x123F050", Length = "0xF8")]
	protected override int GetEntryWeight(RandomTableDataEntry<AssetReferenceGearItem> entry)
	{
		return 0;
	}

	[Token(Token = "0x6008301")]
	[Address(RVA = "0x1240350", Offset = "0x123F150", Length = "0x6B")]
	public FishLootTableData()
	{
	}
}
