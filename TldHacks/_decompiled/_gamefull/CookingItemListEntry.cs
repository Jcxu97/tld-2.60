using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000219")]
public class CookingItemListEntry : MonoBehaviour
{
	[Token(Token = "0x200021A")]
	private enum ItemState
	{
		[Token(Token = "0x40012FB")]
		Unknown,
		[Token(Token = "0x40012FC")]
		Normal,
		[Token(Token = "0x40012FD")]
		WornOut,
		[Token(Token = "0x40012FE")]
		Opened,
		[Token(Token = "0x40012FF")]
		WaterSupply
	}

	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_NameLabel;

	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_ConditionSprite;

	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_ItemCountLabel;

	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x40")]
	public UITexture m_GearIconTexture;

	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_SelectedSprite;

	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_GearItem;

	[Token(Token = "0x40012F1")]
	[FieldOffset(Offset = "0x58")]
	public bool m_DisplayItemCount;

	[Token(Token = "0x40012F2")]
	[FieldOffset(Offset = "0x59")]
	public bool m_DisplayCondition;

	[Token(Token = "0x40012F3")]
	[FieldOffset(Offset = "0x5A")]
	public bool m_UpdateLabels;

	[Token(Token = "0x40012F4")]
	[FieldOffset(Offset = "0x5B")]
	public bool m_UpdateColorsOnly;

	[Token(Token = "0x40012F5")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsSelected;

	[Token(Token = "0x40012F6")]
	[FieldOffset(Offset = "0x60")]
	private int m_LastItemCount;

	[Token(Token = "0x40012F7")]
	[FieldOffset(Offset = "0x64")]
	private int m_LastRoundedCondition;

	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x68")]
	private ItemState m_ItemState;

	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0x70")]
	private AsyncOperationHandle<Texture2D> m_GearIconLoadOp;

	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x65DBC0", Offset = "0x65C9C0", Length = "0x14B")]
	private void Awake()
	{
	}

	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x65DD10", Offset = "0x65CB10", Length = "0x501")]
	private void Update()
	{
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x65E220", Offset = "0x65D020", Length = "0xF3")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x65E320", Offset = "0x65D120", Length = "0x10")]
	private void ClearState()
	{
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x65E330", Offset = "0x65D130", Length = "0x21")]
	public void SetSelected(bool isSelected)
	{
	}

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x65E360", Offset = "0x65D160", Length = "0xED")]
	public void SetGearItem(GearItem gi)
	{
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x65E450", Offset = "0x65D250", Length = "0x20B")]
	public void SetGearIconTexture(AssetReferenceTexture2D textureRef)
	{
	}

	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x65E660", Offset = "0x65D460", Length = "0x3A8")]
	private void UpdateColors()
	{
	}

	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x65EA10", Offset = "0x65D810", Length = "0x4F")]
	public CookingItemListEntry()
	{
	}
}
