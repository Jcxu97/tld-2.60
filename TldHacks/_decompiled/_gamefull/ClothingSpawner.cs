using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019B")]
public class ClothingSpawner : MonoBehaviour
{
	[Token(Token = "0x200019C")]
	private struct WornClothing
	{
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x0")]
		public AssetReferenceFirstPersonClothing m_Reference;

		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x8")]
		public FirstPersonClothing m_Clothing;
	}

	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ClothingParent;

	[SerializeField]
	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_RootBoneReference;

	[SerializeField]
	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x30")]
	private SkinnedMeshRenderer m_SkinningReference;

	[SerializeField]
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x38")]
	private AssetReferenceFirstPersonClothing m_BaseMaleArmsPrefab;

	[SerializeField]
	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x40")]
	private AssetReferenceFirstPersonClothing m_BaseMaleHandsPrefab;

	[SerializeField]
	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceFirstPersonClothing m_BaseFemaleArmsPrefab;

	[SerializeField]
	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x50")]
	private AssetReferenceFirstPersonClothing m_BaseFemaleHandsPrefab;

	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsVisible;

	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x59")]
	private bool m_ForceDefaultArms;

	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x5A")]
	private bool m_ForceDefaultHands;

	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0x60")]
	private WornClothing m_WornArms;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x70")]
	private WornClothing m_WornHands;

	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x60FB40", Offset = "0x60E940", Length = "0x3AE")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x60FEF0", Offset = "0x60ECF0", Length = "0x8D")]
	private void UpdateClothingForRegion(ClothingRegion region, ref WornClothing currentClothing, AssetReferenceFirstPersonClothing defaultClothing, bool forceDefault)
	{
	}

	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x60FF80", Offset = "0x60ED80", Length = "0x39E")]
	private void GetOutermostClothingPrefab(ClothingRegion region, out AssetReferenceFirstPersonClothing selectedPrefab, out GearItem selectedGearItem)
	{
		selectedPrefab = null;
		selectedGearItem = null;
	}

	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x610320", Offset = "0x60F120", Length = "0x3A8")]
	private void MaybeReplaceClothing(ref WornClothing currentClothing, AssetReferenceFirstPersonClothing newClothingReference, GearItem newClothingGearItem)
	{
	}

	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x6106D0", Offset = "0x60F4D0", Length = "0x1BE")]
	public void EnableActiveClothing(bool enable)
	{
	}

	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x610890", Offset = "0x60F690", Length = "0x8")]
	public void ForceDefaultClothing(bool forceDefaultArms, bool forceDefaultHands)
	{
	}

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x40E470", Offset = "0x40D270", Length = "0x4")]
	public string SetHandMeshState(string name)
	{
		return null;
	}

	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x6108A0", Offset = "0x60F6A0", Length = "0x1C9")]
	private FirstPersonClothing CreateInstance(AssetReferenceFirstPersonClothing prefab, GearItem gearItem)
	{
		return null;
	}

	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ClothingSpawner()
	{
	}
}
