using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Beachcombing/Big Item Table")]
[Token(Token = "0x2001457")]
public class BeachcombingBigItemTableData : RandomTableData<AssetReferenceCustomSpawnedItem>
{
	[Token(Token = "0x40093C4")]
	[FieldOffset(Offset = "0x38")]
	private List<BeachcombingBigItemLocation> m_Locations;

	[Token(Token = "0x600817A")]
	[Address(RVA = "0x121D860", Offset = "0x121C660", Length = "0xC8")]
	public void FilterItemsForLocations(List<BeachcombingBigItemLocation> locations)
	{
	}

	[Token(Token = "0x600817B")]
	[Address(RVA = "0x121D930", Offset = "0x121C730", Length = "0x98")]
	protected override bool ShouldFilterOutItem(AssetReferenceCustomSpawnedItem item)
	{
		return false;
	}

	[Token(Token = "0x600817C")]
	[Address(RVA = "0x121D9D0", Offset = "0x121C7D0", Length = "0x18D")]
	private bool ShouldFilterOutForLocation(AssetReferenceCustomSpawnedItem item)
	{
		return false;
	}

	[Token(Token = "0x600817D")]
	[Address(RVA = "0x121DB60", Offset = "0x121C960", Length = "0xFF")]
	public BeachcombingBigItemTableData()
	{
	}
}
