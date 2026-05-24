using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200023E")]
public class GearItemListEntry : MonoBehaviour
{
	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_NameLabel;

	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_ConditionSprite;

	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_ItemCountLabel;

	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x40")]
	private GearItem m_GearItem;

	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsSelected;

	[Token(Token = "0x40013E1")]
	[FieldOffset(Offset = "0x49")]
	public bool m_DisplayItemCount;

	[Token(Token = "0x40013E2")]
	[FieldOffset(Offset = "0x4A")]
	public bool m_DisplayCondition;

	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x4B")]
	public bool m_UpdateLabels;

	[Token(Token = "0x40013E4")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_UpdateColorsOnly;

	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x6768B0", Offset = "0x6756B0", Length = "0x151")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x676A10", Offset = "0x675810", Length = "0x423")]
	private void Update()
	{
	}

	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x676E40", Offset = "0x675C40", Length = "0x5B")]
	public void SetGearItem(GearItem gi)
	{
	}

	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x676EA0", Offset = "0x675CA0", Length = "0x4")]
	public void SetSelected(bool isSelected)
	{
	}

	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x676EB0", Offset = "0x675CB0", Length = "0x335")]
	private void UpdateColors()
	{
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x6771F0", Offset = "0x675FF0", Length = "0x47")]
	public GearItemListEntry()
	{
	}
}
