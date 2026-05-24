using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000295")]
public class WeaponPickerGridItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x20")]
	private BodyHarvestSettings m_BodyHarvestSettings;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x28")]
	private Panel_WeaponPicker m_WeaponPicker;

	[SerializeField]
	[Token(Token = "0x4001752")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Container> m_Container;

	[SerializeField]
	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Space]
	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x40")]
	public UIButton m_Button;

	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x48")]
	public TweenScale m_TweenScale;

	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x50")]
	public UITexture m_GearSprite;

	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_EquippedSprite;

	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_RuinedSprite;

	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_LiquidLabel;

	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_StackLabel;

	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_NameLabel;

	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_SelectedSprite;

	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x88")]
	public Color m_BlueGreenColor;

	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0x98")]
	public Color m_WhiteColor;

	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_ItemElements;

	[Token(Token = "0x4001760")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_HoverEffect;

	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0xB8")]
	private int m_SelectionIndex;

	[Token(Token = "0x4001762")]
	[FieldOffset(Offset = "0xC0")]
	private GearItem m_GearItem;

	[Token(Token = "0x4001763")]
	[FieldOffset(Offset = "0xC8")]
	private float m_previousItemNormalizedCondition;

	[Token(Token = "0x4001764")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_previousItemIsWornOut;

	[Token(Token = "0x4001765")]
	[FieldOffset(Offset = "0xCD")]
	private bool m_IsInContainer;

	[Token(Token = "0x4001766")]
	[FieldOffset(Offset = "0xCE")]
	private bool m_IsInHoverState;

	[Token(Token = "0x4001767")]
	[FieldOffset(Offset = "0xCF")]
	private bool m_IsSelected;

	[Token(Token = "0x4001768")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_UnitLabel;

	[Token(Token = "0x4001769")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite m_UnitSprite;

	[Token(Token = "0x400176A")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_EmptyItemEnabled;

	[Token(Token = "0x6001633")]
	[Address(RVA = "0x6B40F0", Offset = "0x6B2EF0", Length = "0x151")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001634")]
	[Address(RVA = "0x6B4250", Offset = "0x6B3050", Length = "0x357")]
	public void RefreshEmptyItem(int index)
	{
	}

	[Token(Token = "0x6001635")]
	[Address(RVA = "0x6B45B0", Offset = "0x6B33B0", Length = "0xD79")]
	public void Refresh(GearItem gi, int index)
	{
	}

	[Token(Token = "0x6001636")]
	[Address(RVA = "0x6B5330", Offset = "0x6B4130", Length = "0x22B")]
	public void Update()
	{
	}

	[Token(Token = "0x6001637")]
	[Address(RVA = "0x6B5560", Offset = "0x6B4360", Length = "0x15A")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6001638")]
	[Address(RVA = "0x6B56C0", Offset = "0x6B44C0", Length = "0xF8")]
	public void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6001639")]
	[Address(RVA = "0x6B57C0", Offset = "0x6B45C0", Length = "0x594")]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[Token(Token = "0x600163A")]
	[Address(RVA = "0x5DD350", Offset = "0x5DC150", Length = "0x7")]
	public int GetSelectionIndex()
	{
		return 0;
	}

	[Token(Token = "0x600163B")]
	[Address(RVA = "0x6B5D60", Offset = "0x6B4B60", Length = "0x8")]
	public void MarkAsContainerItem()
	{
	}

	[Token(Token = "0x600163C")]
	[Address(RVA = "0x6B5D70", Offset = "0x6B4B70", Length = "0x107")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x600163D")]
	[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
	public GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x600163E")]
	[Address(RVA = "0x6B5E80", Offset = "0x6B4C80", Length = "0x205")]
	public void DoubleClick()
	{
	}

	[Token(Token = "0x600163F")]
	[Address(RVA = "0x6B6090", Offset = "0x6B4E90", Length = "0x19E")]
	private void UpdateConditionDisplay()
	{
	}

	[Token(Token = "0x6001640")]
	[Address(RVA = "0x6B6230", Offset = "0x6B5030", Length = "0xE8")]
	private void DisableButton()
	{
	}

	[Token(Token = "0x6001641")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WeaponPickerGridItem()
	{
	}
}
