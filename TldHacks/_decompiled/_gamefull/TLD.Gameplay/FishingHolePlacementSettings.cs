using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/FishingHolePlacementSettings")]
[Token(Token = "0x20014A0")]
public class FishingHolePlacementSettings : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4009582")]
	[FieldOffset(Offset = "0x18")]
	private AssetReferenceWithComponent<IceFishingHole> m_IceFishingHoleReference;

	[Token(Token = "0x4009583")]
	[FieldOffset(Offset = "0x20")]
	public float m_BuildRangeMin;

	[Token(Token = "0x4009584")]
	[FieldOffset(Offset = "0x24")]
	public float m_BuildRangeMax;

	[Token(Token = "0x60082D5")]
	[Address(RVA = "0x123E860", Offset = "0x123D660", Length = "0x118")]
	public IceFishingHole Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60082D6")]
	[Address(RVA = "0x123E980", Offset = "0x123D780", Length = "0xE")]
	public FishingHolePlacementSettings()
	{
	}
}
