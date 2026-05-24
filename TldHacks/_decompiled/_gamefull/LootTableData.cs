using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Loot Table")]
[Token(Token = "0x20004BA")]
public class LootTableData : RandomTableData<AssetReferenceGearItem>
{
	[Token(Token = "0x600241F")]
	[Address(RVA = "0x862270", Offset = "0x861070", Length = "0x146")]
	protected override bool ShouldFilterOutPrefab(GameObject prefab)
	{
		return false;
	}

	[Token(Token = "0x6002420")]
	[Address(RVA = "0x8623C0", Offset = "0x8611C0", Length = "0x57")]
	private bool IsValidGearItem(GameObject prefab)
	{
		return false;
	}

	[Token(Token = "0x6002421")]
	[Address(RVA = "0x862420", Offset = "0x861220", Length = "0x4CE")]
	private bool ShouldDisableForCurrentMode(GameObject prefab)
	{
		return false;
	}

	[Token(Token = "0x6002422")]
	[Address(RVA = "0x8628F0", Offset = "0x8616F0", Length = "0x139")]
	private ExperienceMode GetCurrentExperienceMode()
	{
		return null;
	}

	[Token(Token = "0x6002423")]
	[Address(RVA = "0x862A30", Offset = "0x861830", Length = "0x64")]
	public LootTableData()
	{
	}
}
