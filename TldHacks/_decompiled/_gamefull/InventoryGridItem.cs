using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000252")]
public class InventoryGridItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001489")]
	[FieldOffset(Offset = "0x20")]
	private BodyHarvestSettings m_BodyHarvestSettings;

	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x28")]
	public UIButton m_Button;

	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x30")]
	public TweenScale m_TweenScale;

	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x38")]
	public UITexture m_GearSprite;

	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x40")]
	public UITexture m_PhotoSprite;

	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_EquippedSprite;

	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_RuinedSprite;

	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_LiquidLabel;

	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_StackLabel;

	[Token(Token = "0x4001492")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_WeightLabel;

	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_NameLabel;

	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_ConditionSprite;

	[Token(Token = "0x4001496")]
	[FieldOffset(Offset = "0x88")]
	public UISprite m_SelectedSprite;

	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x90")]
	public UISprite m_FavoritedSprite;

	[Token(Token = "0x4001498")]
	[FieldOffset(Offset = "0x98")]
	public Color m_BlueGreenColor;

	[Token(Token = "0x4001499")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_WhiteColor;

	[Token(Token = "0x400149A")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_GoodConditionSpriteColor;

	[Token(Token = "0x400149B")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_ItemElements;

	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_HoverEffect;

	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_NotificationFlag;

	[Token(Token = "0x400149E")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_HotIndicator;

	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_ColdIndicator;

	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_DecorationIndicator;

	[Token(Token = "0x40014A1")]
	[FieldOffset(Offset = "0xF8")]
	public CraftingProgress m_CraftingProgress;

	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x100")]
	public UILabel m_UnitLabel;

	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x108")]
	public UISprite m_UnitSprite;

	[Token(Token = "0x40014A4")]
	[FieldOffset(Offset = "0x110")]
	public bool m_IsSelected;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x118")]
	private PanelReference<Panel_Container> m_Container;

	[SerializeField]
	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x120")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x128")]
	private PanelReference<Panel_InsulatedFlask> m_Flask;

	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x130")]
	private int m_SelectionIndex;

	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0x138")]
	private GearItem m_GearItem;

	[Token(Token = "0x40014AA")]
	[FieldOffset(Offset = "0x140")]
	private DecorationItem m_DecorationItem;

	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0x148")]
	private float m_previousItemNormalizedCondition;

	[Token(Token = "0x40014AC")]
	[FieldOffset(Offset = "0x14C")]
	private bool m_previousItemIsWornOut;

	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x14D")]
	private bool m_IsInContainer;

	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0x14E")]
	private bool m_IsInHoverState;

	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x14F")]
	private bool m_EmptyItemEnabled;

	[Token(Token = "0x6001455")]
	[Address(RVA = "0x682730", Offset = "0x681530", Length = "0x11")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001456")]
	[Address(RVA = "0x682750", Offset = "0x681550", Length = "0x59B")]
	public void RefreshEmptyItem(int index)
	{
	}

	[Token(Token = "0x6001457")]
	[Address(RVA = "0x682CF0", Offset = "0x681AF0", Length = "0x1EC")]
	public void RefreshDataItem(InventoryGridDataItem dataItem, int index)
	{
	}

	[Token(Token = "0x6001458")]
	[Address(RVA = "0x682EE0", Offset = "0x681CE0", Length = "0x1252")]
	public void Refresh(GearItem gi, int index)
	{
	}

	[Token(Token = "0x6001459")]
	[Address(RVA = "0x684140", Offset = "0x682F40", Length = "0xA0C")]
	public void RefreshDecorationItem(DecorationItem decorationItem, int index)
	{
	}

	[Token(Token = "0x600145A")]
	[Address(RVA = "0x684B50", Offset = "0x683950", Length = "0x22B")]
	public void Update()
	{
	}

	[Token(Token = "0x600145B")]
	[Address(RVA = "0x684D80", Offset = "0x683B80", Length = "0x46C")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600145C")]
	[Address(RVA = "0x6851F0", Offset = "0x683FF0", Length = "0x35B")]
	public void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x600145D")]
	[Address(RVA = "0x685550", Offset = "0x684350", Length = "0xA19")]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[Token(Token = "0x600145E")]
	[Address(RVA = "0x685F70", Offset = "0x684D70", Length = "0x7")]
	public int GetSelectionIndex()
	{
		return 0;
	}

	[Token(Token = "0x600145F")]
	[Address(RVA = "0x685F80", Offset = "0x684D80", Length = "0x8")]
	public void MarkAsContainerItem()
	{
	}

	[Token(Token = "0x6001460")]
	[Address(RVA = "0x685F90", Offset = "0x684D90", Length = "0x1B5")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x6001461")]
	[Address(RVA = "0x686150", Offset = "0x684F50", Length = "0x8")]
	public GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x6001462")]
	[Address(RVA = "0x686160", Offset = "0x684F60", Length = "0x8")]
	public DecorationItem GetDecorationItem()
	{
		return null;
	}

	[Token(Token = "0x6001463")]
	[Address(RVA = "0x686170", Offset = "0x684F70", Length = "0x41E")]
	public void DoubleClick()
	{
	}

	[Token(Token = "0x6001464")]
	[Address(RVA = "0x55BD20", Offset = "0x55AB20", Length = "0x8")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x6001465")]
	[Address(RVA = "0x686590", Offset = "0x685390", Length = "0x628")]
	private void UpdateConditionDisplay()
	{
	}

	[Token(Token = "0x6001466")]
	[Address(RVA = "0x686BC0", Offset = "0x6859C0", Length = "0xFC")]
	private void DisableButton()
	{
	}

	[Token(Token = "0x6001467")]
	[Address(RVA = "0x686CC0", Offset = "0x685AC0", Length = "0x25")]
	public void DeselectItem()
	{
	}

	[Token(Token = "0x6001468")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InventoryGridItem()
	{
	}
}
