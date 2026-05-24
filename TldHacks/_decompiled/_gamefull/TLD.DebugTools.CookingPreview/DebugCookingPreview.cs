using System;
using Cpp2ILInjected;
using TLD.Cooking;
using UnityEngine;

namespace TLD.DebugTools.CookingPreview;

[Token(Token = "0x20013E4")]
public class DebugCookingPreview : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20013E5")]
	public class CookingPhaseEffectPairing
	{
		[Token(Token = "0x40091A7")]
		[FieldOffset(Offset = "0x10")]
		public CookingPotItem.CookingState m_CookingState;

		[Token(Token = "0x40091A8")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_EffectRoot;

		[Token(Token = "0x6007EE0")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public CookingPhaseEffectPairing()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40091A1")]
	[FieldOffset(Offset = "0x20")]
	private CookingPotItem.GrubMeshType m_GrubMeshType;

	[SerializeField]
	[Token(Token = "0x40091A2")]
	[FieldOffset(Offset = "0x28")]
	private MeshFilter m_GrubMeshFilter;

	[SerializeField]
	[Token(Token = "0x40091A3")]
	[FieldOffset(Offset = "0x30")]
	private MeshRenderer m_GrubMeshRenderer;

	[SerializeField]
	[Token(Token = "0x40091A4")]
	[FieldOffset(Offset = "0x38")]
	private CookingPhaseEffectPairing[] m_CookingPhaseEffectPairings;

	[Token(Token = "0x40091A5")]
	[FieldOffset(Offset = "0x40")]
	private GearItem m_CurrentCookingItem;

	[Token(Token = "0x40091A6")]
	[FieldOffset(Offset = "0x48")]
	private CookingPotItem.CookingState m_CurrentCookingState;

	[Token(Token = "0x6007EDC")]
	[Address(RVA = "0x11E7EF0", Offset = "0x11E6CF0", Length = "0x3BC")]
	private void UpdateCookingItem()
	{
	}

	[Token(Token = "0x6007EDD")]
	[Address(RVA = "0x11E82B0", Offset = "0x11E70B0", Length = "0x2B2")]
	public void RecipeChanged(RecipeData recipe)
	{
	}

	[Token(Token = "0x6007EDE")]
	[Address(RVA = "0x11E8570", Offset = "0x11E7370", Length = "0xA")]
	public void CookingStateChanged(CookingPotItem.CookingState cookingState)
	{
	}

	[Token(Token = "0x6007EDF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DebugCookingPreview()
	{
	}
}
