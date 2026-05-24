using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001FF")]
public class BasicMenu : MonoBehaviour
{
	[Token(Token = "0x2000200")]
	public enum MouseKeyboardControlBehavior
	{
		[Token(Token = "0x400123E")]
		AutoConfirmWhenSelected,
		[Token(Token = "0x400123F")]
		RequiresConfirmOrDoubleClick
	}

	[Token(Token = "0x2000201")]
	public enum UserControlMode
	{
		[Token(Token = "0x4001241")]
		None,
		[Token(Token = "0x4001242")]
		GamePad,
		[Token(Token = "0x4001243")]
		MouseKb
	}

	[Token(Token = "0x2000202")]
	public class BasicMenuItemModel
	{
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x10")]
		public readonly string m_Id;

		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x18")]
		public readonly int m_Value;

		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int m_ItemIndex;

		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x20")]
		public readonly Action m_Action;

		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x28")]
		public readonly string m_LabelText;

		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x30")]
		public readonly string m_DescriptionText;

		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x38")]
		public readonly string m_SecondaryText;

		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x40")]
		public readonly Color m_NormalTint;

		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x50")]
		public readonly Color m_HighlightTint;

		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x60")]
		public bool m_Selectable;

		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0x61")]
		public bool m_IsLocked;

		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x62")]
		public bool m_IsChecked;

		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x63")]
		public bool m_IsCloudItem;

		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x64")]
		public bool m_IsUpsell;

		[Token(Token = "0x6001252")]
		[Address(RVA = "0x64F220", Offset = "0x64E020", Length = "0x204")]
		public BasicMenuItemModel(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000203")]
	public class BasicMenuItemView
	{
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Display;

		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0x18")]
		public UIButton m_Button;

		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x20")]
		public DoubleClickButton m_DoubleClickButton;

		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_Label;

		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_Linebreak;

		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x38")]
		public UILabel m_SecondaryLabel;

		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_LockedIcon;

		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x48")]
		public GameObject m_CheckmarkIcon;

		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject m_CloudIcon;

		[Token(Token = "0x6001253")]
		[Address(RVA = "0x64F430", Offset = "0x64E230", Length = "0x34")]
		public void SetState(UIButtonColor.State state, bool immediate)
		{
		}

		[Token(Token = "0x6001254")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BasicMenuItemView()
		{
		}
	}

	[Token(Token = "0x2000204")]
	public delegate void OnSelectionUpdate(string id, int value, int itemIndex);

	[Header("Title")]
	[Token(Token = "0x4001211")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_TitleLabel;

	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_TitleHeaderLabel;

	[Token(Token = "0x4001213")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_TitleGroup;

	[Header("Selection")]
	[Token(Token = "0x4001214")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_SelectionMarker;

	[Token(Token = "0x4001215")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_DescriptionLabel;

	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Scrollbar;

	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_UpsellMarker;

	[Header("Colors")]
	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x58")]
	public Color m_ButtonTextColor_Hover;

	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x68")]
	public Color m_ButtonTextColor_Normal;

	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x78")]
	public Color m_ButtonTextColor_Selected;

	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x88")]
	public Color m_ButtonTextColor_Disabled;

	[Header("Color When Requires Confirm")]
	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x98")]
	public Color m_ButtonTextColor_HoverConfirmRequired;

	[Header("Menu item prefab")]
	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_BasicMenuItemPrefab;

	[Header("Menu items")]
	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0xB0")]
	public UIGrid m_MenuGrid;

	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0xB8")]
	public int m_SecondaryTextSpacing;

	[Header("BackButton")]
	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_MouseBackButton;

	[Token(Token = "0x4001221")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_MouseBackToHomeButton;

	[Header("ConfirmButton")]
	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_MouseConfirmButton;

	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0xD8")]
	public GenericButtonMouseSpawner m_MouseConfirmButtonSpawner;

	[Header("Backgrounds")]
	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_MainMenuBackgroundObject;

	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_CommonBackgroundObject;

	[Token(Token = "0x4001226")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_LeftAlignBackgroundObject;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001227")]
	[FieldOffset(Offset = "0xF8")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x100")]
	private PanelReference<Panel_Debug> m_Debug;

	[HideInInspector]
	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x108")]
	public MouseKeyboardControlBehavior m_MouseKeyboardControlBehavior;

	[HideInInspector]
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x10C")]
	public bool m_CanScroll;

	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x110")]
	private int m_MenuScrollOffset;

	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x114")]
	private int m_MenuSelectedButtonIndex;

	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x118")]
	private int m_PreviousMenuScrollOffset;

	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x11C")]
	private int m_PreviousSelectedButtonIndex;

	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x120")]
	private List<BasicMenuItemView> m_EnabledMenuItems;

	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x128")]
	private List<BasicMenuItemModel> m_ItemModelList;

	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x130")]
	private Action m_OnClickBackAction;

	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 m_HeaderLabelOriginalPosition;

	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x148")]
	private OnSelectionUpdate m_OnSelectionUpdateCallback;

	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x150")]
	private int m_DescriptionCurrentIndex;

	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x154")]
	private UserControlMode m_LastControlMode;

	[Token(Token = "0x4001237")]
	private const int m_MaxMenuItems = 8;

	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x158")]
	private UISlider m_ScrollbarSlider;

	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x160")]
	private List<BasicMenuItemView> m_MenuItems;

	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x168")]
	private MonoBehaviour m_OwnerContext;

	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x170")]
	private List<IBasicMenuExtension> m_MenuExtensions;

	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x178")]
	private bool m_ForceDisableBackbutton;

	[Token(Token = "0x170001C2")]
	[field: Token(Token = "0x400122B")]
	[field: FieldOffset(Offset = "0x10D")]
	public bool IsFocused
	{
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x648590", Offset = "0x647390", Length = "0x8")]
		get;
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x6485A0", Offset = "0x6473A0", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x6001219")]
	[Address(RVA = "0x6485B0", Offset = "0x6473B0", Length = "0x8")]
	public MonoBehaviour GetOwnerContext()
	{
		return null;
	}

	[Token(Token = "0x600121A")]
	[Address(RVA = "0x6485C0", Offset = "0x6473C0", Length = "0x2A1")]
	public void Awake()
	{
	}

	[Token(Token = "0x600121B")]
	[Address(RVA = "0x648870", Offset = "0x647670", Length = "0x11D")]
	public void AddExtension(IBasicMenuExtension menuExtension)
	{
	}

	[Token(Token = "0x600121C")]
	[Address(RVA = "0x648990", Offset = "0x647790", Length = "0xD9")]
	private void UpdateDescriptionForMouseControl()
	{
	}

	[Token(Token = "0x600121D")]
	[Address(RVA = "0x648A70", Offset = "0x647870", Length = "0x4BE")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x600121E")]
	[Address(RVA = "0x648F30", Offset = "0x647D30", Length = "0x2B2")]
	public void Reset()
	{
	}

	[Token(Token = "0x600121F")]
	[Address(RVA = "0x6491F0", Offset = "0x647FF0", Length = "0x52")]
	public void SetBackAction(Action onClickBackAction)
	{
	}

	[Token(Token = "0x6001220")]
	[Address(RVA = "0x649250", Offset = "0x648050", Length = "0xA4")]
	public void EnableConfirm(bool enable, string confirmTextLocId)
	{
	}

	[Token(Token = "0x6001221")]
	[Address(RVA = "0x649300", Offset = "0x648100", Length = "0x79")]
	public void UpdateMouseConfirmText(string confirmTextLocId)
	{
	}

	[Token(Token = "0x6001222")]
	[Address(RVA = "0x649380", Offset = "0x648180", Length = "0x52")]
	public void SetOnSelectionUpdateCallback(OnSelectionUpdate onSelectionUpdate)
	{
	}

	[Token(Token = "0x6001223")]
	[Address(RVA = "0x6493E0", Offset = "0x6481E0", Length = "0xB6")]
	public int GetItemValueIndex(int value)
	{
		return 0;
	}

	[Token(Token = "0x6001224")]
	[Address(RVA = "0x6494A0", Offset = "0x6482A0", Length = "0x419")]
	public BasicMenuItemModel AddItem(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
	{
		return null;
	}

	[Token(Token = "0x6001225")]
	[Address(RVA = "0x6498C0", Offset = "0x6486C0", Length = "0x8E")]
	public void AddLineBreak()
	{
	}

	[Token(Token = "0x6001226")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001227")]
	[Address(RVA = "0x6499F0", Offset = "0x6487F0", Length = "0x2C4")]
	public void Enable(bool enabled)
	{
	}

	[Token(Token = "0x6001228")]
	[Address(RVA = "0x649CC0", Offset = "0x648AC0", Length = "0x25F")]
	public void SetFocused(bool focused)
	{
	}

	[Token(Token = "0x6001229")]
	[Address(RVA = "0x649F20", Offset = "0x648D20", Length = "0x44")]
	public int GetItemCount()
	{
		return 0;
	}

	[Token(Token = "0x600122A")]
	[Address(RVA = "0x649F70", Offset = "0x648D70", Length = "0xA8")]
	public int GetSelectedItemIndex()
	{
		return 0;
	}

	[Token(Token = "0x600122B")]
	[Address(RVA = "0x64A020", Offset = "0x648E20", Length = "0xAA")]
	public string GetSelectedItemIndexNextId()
	{
		return null;
	}

	[Token(Token = "0x600122C")]
	[Address(RVA = "0x64A0D0", Offset = "0x648ED0", Length = "0x1B1")]
	public int GetSelectedItemIndexFromId(string id)
	{
		return 0;
	}

	[Token(Token = "0x600122D")]
	[Address(RVA = "0x64A290", Offset = "0x649090", Length = "0xA6")]
	public string GetSelectedItemId()
	{
		return null;
	}

	[Token(Token = "0x600122E")]
	[Address(RVA = "0x64A340", Offset = "0x649140", Length = "0xA8")]
	public int GetSelectedItemValue()
	{
		return 0;
	}

	[Token(Token = "0x600122F")]
	[Address(RVA = "0x64A3F0", Offset = "0x6491F0", Length = "0x1A2")]
	public bool HasActiveItemByID(string id)
	{
		return false;
	}

	[Token(Token = "0x6001230")]
	[Address(RVA = "0x64A5A0", Offset = "0x6493A0", Length = "0x1C3")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6001231")]
	[Address(RVA = "0x64A770", Offset = "0x649570", Length = "0x38")]
	public void OnConfirm()
	{
	}

	[Token(Token = "0x6001232")]
	[Address(RVA = "0x64A7B0", Offset = "0x6495B0", Length = "0x17C")]
	public void OnItemClicked(int index)
	{
	}

	[Token(Token = "0x6001233")]
	[Address(RVA = "0x64A930", Offset = "0x649730", Length = "0xDB")]
	public void OnItemDoubleClicked(int index)
	{
	}

	[Token(Token = "0x6001234")]
	[Address(RVA = "0x64AA10", Offset = "0x649810", Length = "0x37")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6001235")]
	[Address(RVA = "0x64AA50", Offset = "0x649850", Length = "0x337")]
	public static BasicMenu InstantiateMenu(GameObject prefab, GameObject root, GameObject defaultRoot, MonoBehaviour context)
	{
		return null;
	}

	[Token(Token = "0x6001236")]
	[Address(RVA = "0x64AD90", Offset = "0x649B90", Length = "0x16A")]
	public void UpdateTitle(string mainLocalizedTextId, string headerLocalizedTextId, Vector3 headerOffset)
	{
	}

	[Token(Token = "0x6001237")]
	[Address(RVA = "0x64AF00", Offset = "0x649D00", Length = "0xB1")]
	private bool AcceptInput()
	{
		return false;
	}

	[Token(Token = "0x6001238")]
	[Address(RVA = "0x64AFC0", Offset = "0x649DC0", Length = "0x2B5")]
	private void UpdateTitleHeader(string localizedTextId, Vector3 offset)
	{
	}

	[Token(Token = "0x6001239")]
	[Address(RVA = "0x64B280", Offset = "0x64A080", Length = "0x18D")]
	private void UpdateTitle(string localizedTextId)
	{
	}

	[Token(Token = "0x600123A")]
	[Address(RVA = "0x64B410", Offset = "0x64A210", Length = "0xAB")]
	public void SetItemSelectable(int itemIndex, bool selectable)
	{
	}

	[Token(Token = "0x600123B")]
	[Address(RVA = "0x64B4C0", Offset = "0x64A2C0", Length = "0x24B")]
	public void SetItemSelected(int itemIndex)
	{
	}

	[Token(Token = "0x600123C")]
	[Address(RVA = "0x64B710", Offset = "0x64A510", Length = "0x3D")]
	public void EnableBackButton(bool enable)
	{
	}

	[Token(Token = "0x600123D")]
	[Address(RVA = "0x64B750", Offset = "0x64A550", Length = "0x21")]
	public void EnableBackHomeButton(bool enable)
	{
	}

	[Token(Token = "0x600123E")]
	[Address(RVA = "0x64B780", Offset = "0x64A580", Length = "0x21")]
	public void EnableCommonBackground(bool enable)
	{
	}

	[Token(Token = "0x600123F")]
	[Address(RVA = "0x64B7B0", Offset = "0x64A5B0", Length = "0x148")]
	private void UpdateHoveredButton(int index, bool immediate)
	{
	}

	[Token(Token = "0x6001240")]
	[Address(RVA = "0x64B900", Offset = "0x64A700", Length = "0x210")]
	private int GetButtonIndexHovered()
	{
		return 0;
	}

	[Token(Token = "0x6001241")]
	[Address(RVA = "0x64BB20", Offset = "0x64A920", Length = "0x148")]
	private void SetButtonPressedFromMenuIndex(int buttonIndex, bool immediate)
	{
	}

	[Token(Token = "0x6001242")]
	[Address(RVA = "0x64BC70", Offset = "0x64AA70", Length = "0x13C")]
	private Color GetSelectedColor(int index)
	{
		return default(Color);
	}

	[Token(Token = "0x6001243")]
	[Address(RVA = "0x64BDB0", Offset = "0x64ABB0", Length = "0x861")]
	private void ProcessMenu(List<BasicMenuItemView> menuItems)
	{
	}

	[Token(Token = "0x6001244")]
	[Address(RVA = "0x64C620", Offset = "0x64B420", Length = "0x174")]
	private void UpdateDescription(int buttonIndex)
	{
	}

	[Token(Token = "0x6001245")]
	[Address(RVA = "0x64C7A0", Offset = "0x64B5A0", Length = "0x52F")]
	private void UpdateSelection(List<BasicMenuItemView> menuItems)
	{
	}

	[Token(Token = "0x6001246")]
	[Address(RVA = "0x64CCD0", Offset = "0x64BAD0", Length = "0x56")]
	private void ClampSelectedIndex()
	{
	}

	[Token(Token = "0x6001247")]
	[Address(RVA = "0x64CD30", Offset = "0x64BB30", Length = "0xA52")]
	private void RefreshEnableItems()
	{
	}

	[Token(Token = "0x6001248")]
	[Address(RVA = "0x64D790", Offset = "0x64C590", Length = "0x10E")]
	private bool CanItemBeSelected(int index)
	{
		return false;
	}

	[Token(Token = "0x6001249")]
	[Address(RVA = "0x64D8A0", Offset = "0x64C6A0", Length = "0xF2")]
	private void InternalClickAction(int index, bool doAction)
	{
	}

	[Token(Token = "0x600124A")]
	[Address(RVA = "0x64D9A0", Offset = "0x64C7A0", Length = "0x477")]
	private void RefreshButtonStateColors()
	{
	}

	[Token(Token = "0x600124B")]
	[Address(RVA = "0x64DE20", Offset = "0x64CC20", Length = "0x216")]
	private void RefreshScrollbarSettings()
	{
	}

	[Token(Token = "0x600124C")]
	[Address(RVA = "0x64E040", Offset = "0x64CE40", Length = "0x212")]
	private void UpdateScrollbar()
	{
	}

	[Token(Token = "0x600124D")]
	[Address(RVA = "0x64E260", Offset = "0x64D060", Length = "0x18D")]
	public void OnScrollbarChange()
	{
	}

	[Token(Token = "0x600124E")]
	[Address(RVA = "0x64E3F0", Offset = "0x64D1F0", Length = "0x214")]
	public void UpdateMenuExtensionButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[Token(Token = "0x600124F")]
	[Address(RVA = "0x64E610", Offset = "0x64D410", Length = "0x574")]
	private void InstantiateMenuItems()
	{
	}

	[Token(Token = "0x6001250")]
	[Address(RVA = "0x64EB90", Offset = "0x64D990", Length = "0x12A")]
	private int SelectNextValidItem(List<BasicMenuItemView> menuItems, int index, int delta)
	{
		return 0;
	}

	[Token(Token = "0x6001251")]
	[Address(RVA = "0x64ECC0", Offset = "0x64DAC0", Length = "0x554")]
	public BasicMenu()
	{
	}
}
