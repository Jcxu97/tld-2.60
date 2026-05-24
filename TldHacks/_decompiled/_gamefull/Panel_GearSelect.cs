using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000657")]
public class Panel_GearSelect : Panel_AutoReferenced
{
	[Token(Token = "0x2000658")]
	public enum ListItemFilter
	{
		[Token(Token = "0x4003DE2")]
		None,
		[Token(Token = "0x4003DE3")]
		InventoryAll,
		[Token(Token = "0x4003DE4")]
		InventoryBodyHarvestTool,
		[Token(Token = "0x4003DE5")]
		InventoryStruggleWeapon
	}

	[Token(Token = "0x4003DBE")]
	private const string SPRITE_NOTOOL = "ico_NoTool";

	[Token(Token = "0x4003DBF")]
	private const string LOCID_ERR_NOCOOKINGITEMS = "GAMEPLAY_NoCookingItemsInInventory";

	[Token(Token = "0x4003DC0")]
	private const string LOCID_ERR_NOCOOKINGSLOTS = "GAMEPLAY_NoCookingSlotsAvailable";

	[Token(Token = "0x4003DC1")]
	private const string LOCID_ERR_NOCOOKINGPOTS = "GAMEPLAY_NoCookingPotsInInventory";

	[Token(Token = "0x4003DC2")]
	private const string LOCID_NOTOOL = "GAMEPLAY_NoTool";

	[Token(Token = "0x4003DC3")]
	private const string LOCID_SELECT = "GAMEPLAY_Select";

	[Token(Token = "0x4003DC4")]
	private const string LOCID_BACK = "GAMEPLAY_ButtonBack";

	[SerializeField]
	[Token(Token = "0x4003DC5")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Cooking> m_Cooking;

	[SerializeField]
	[Token(Token = "0x4003DC6")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_CookWater> m_CookWater;

	[SerializeField]
	[Token(Token = "0x4003DC7")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Log> m_Log;

	[Token(Token = "0x4003DC8")]
	[FieldOffset(Offset = "0x48")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x4003DC9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x4003DCA")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x4003DCB")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_ButtonLeftGamepad;

	[Token(Token = "0x4003DCC")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_ButtonLeftGamepadSprite;

	[Token(Token = "0x4003DCD")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_ButtonRightGamepad;

	[Token(Token = "0x4003DCE")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_ButtonRightGamepadSprite;

	[Token(Token = "0x4003DCF")]
	[FieldOffset(Offset = "0x80")]
	public GenericButtonMouseSpawner m_MouseButtonSelectGear;

	[Token(Token = "0x4003DD0")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_Label;

	[Token(Token = "0x4003DD1")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_ItemStatsObject;

	[Token(Token = "0x4003DD2")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x4003DD3")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_WeightLabel;

	[Token(Token = "0x4003DD4")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget[] m_WidgetsToDisableForNoBG;

	[Token(Token = "0x4003DD5")]
	[FieldOffset(Offset = "0xB0")]
	public Transform m_PanelContentTransform;

	[Token(Token = "0x4003DD6")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 m_PanelContentPosNormal;

	[Token(Token = "0x4003DD7")]
	[FieldOffset(Offset = "0xC4")]
	public Vector3 m_PanelContentPosNoBG;

	[SerializeField]
	[Token(Token = "0x4003DD8")]
	[FieldOffset(Offset = "0xD0")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003DD9")]
	[FieldOffset(Offset = "0xD8")]
	private readonly List<GearSelectCoverflow> m_CoverflowGearItems;

	[Token(Token = "0x4003DDA")]
	[FieldOffset(Offset = "0xE0")]
	private readonly List<GearItem> m_GearItems;

	[Token(Token = "0x4003DDB")]
	[FieldOffset(Offset = "0xE8")]
	private GearItem m_SelectedItem;

	[Token(Token = "0x4003DDC")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_IsStruggleWeaponSelection;

	[Token(Token = "0x4003DDD")]
	[FieldOffset(Offset = "0xF8")]
	private Action m_OnSelectAction;

	[Token(Token = "0x4003DDE")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_FeedFireGameObject;

	[Token(Token = "0x4003DDF")]
	[FieldOffset(Offset = "0x108")]
	private GearPlacePoint m_GearPlacePointSelected;

	[Token(Token = "0x4003DE0")]
	[FieldOffset(Offset = "0x110")]
	private GameObject m_CookingGameObject;

	[Token(Token = "0x60033D7")]
	[Address(RVA = "0xA4EF30", Offset = "0xA4DD30", Length = "0x47")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60033D8")]
	[Address(RVA = "0xA4EF80", Offset = "0xA4DD80", Length = "0x13C")]
	private void Update()
	{
	}

	[Token(Token = "0x60033D9")]
	[Address(RVA = "0xA4F0C0", Offset = "0xA4DEC0", Length = "0x1D")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60033DA")]
	[Address(RVA = "0xA4F0E0", Offset = "0xA4DEE0", Length = "0x161")]
	public void Enable(bool enable, ListItemFilter filter, bool isStruggleWeaponSelection)
	{
	}

	[Token(Token = "0x60033DB")]
	[Address(RVA = "0xA4F250", Offset = "0xA4E050", Length = "0x2D0")]
	private void Enable(bool enable, List<GearItem> listItems, bool isStruggleWeaponSelection, Action onGearSelected)
	{
	}

	[Token(Token = "0x60033DC")]
	[Address(RVA = "0xA4F530", Offset = "0xA4E330", Length = "0x22E")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60033DD")]
	[Address(RVA = "0xA4F760", Offset = "0xA4E560", Length = "0xA2")]
	public void SelectItemByIndex(int index)
	{
	}

	[Token(Token = "0x60033DE")]
	[Address(RVA = "0xA4F810", Offset = "0xA4E610", Length = "0xFE")]
	public void PreviousGear()
	{
	}

	[Token(Token = "0x60033DF")]
	[Address(RVA = "0xA4F910", Offset = "0xA4E710", Length = "0xFE")]
	public void NextGear()
	{
	}

	[Token(Token = "0x60033E0")]
	[Address(RVA = "0xA4FA10", Offset = "0xA4E810", Length = "0x207")]
	public void SelectGear()
	{
	}

	[Token(Token = "0x60033E1")]
	[Address(RVA = "0x502630", Offset = "0x501430", Length = "0x8")]
	public GearItem GetSelectedItem()
	{
		return null;
	}

	[Token(Token = "0x60033E2")]
	[Address(RVA = "0xA4FC20", Offset = "0xA4EA20", Length = "0x9FD")]
	public void ShowCookFoodPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[Token(Token = "0x60033E3")]
	[Address(RVA = "0xA50620", Offset = "0xA4F420", Length = "0x741")]
	public void ShowCookWaterPicker(GameObject fireObject, GameObject cookingObject)
	{
	}

	[Token(Token = "0x60033E4")]
	[Address(RVA = "0x97CFA0", Offset = "0x97BDA0", Length = "0x52")]
	public void SetSelectedGearPlacePoint(GearPlacePoint selectedGearPlacePoint)
	{
	}

	[Token(Token = "0x60033E5")]
	[Address(RVA = "0xA50D70", Offset = "0xA4FB70", Length = "0x39A")]
	private static void GetItems(ListItemFilter filter, List<GearItem> itemList)
	{
	}

	[Token(Token = "0x60033E6")]
	[Address(RVA = "0xA51110", Offset = "0xA4FF10", Length = "0x96")]
	private GearItem GetScrolllistCurrentItem()
	{
		return null;
	}

	[Token(Token = "0x60033E7")]
	[Address(RVA = "0xA511B0", Offset = "0xA4FFB0", Length = "0x95")]
	private void UpdateSelectedGear(int selectedGearIndex)
	{
	}

	[Token(Token = "0x60033E8")]
	[Address(RVA = "0xA51250", Offset = "0xA50050", Length = "0x322")]
	private void UpdateSelectedGear(GearItem selectedGear)
	{
	}

	[Token(Token = "0x60033E9")]
	[Address(RVA = "0xA51580", Offset = "0xA50380", Length = "0x1F3")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x60033EA")]
	[Address(RVA = "0xA51780", Offset = "0xA50580", Length = "0x2C6")]
	private void UpdateInputSelection()
	{
	}

	[Token(Token = "0x60033EB")]
	[Address(RVA = "0xA51A50", Offset = "0xA50850", Length = "0x3BF")]
	private void SetupScrollList()
	{
	}

	[Token(Token = "0x60033EC")]
	[Address(RVA = "0xA51E10", Offset = "0xA50C10", Length = "0x1F7")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60033ED")]
	[Address(RVA = "0xA52010", Offset = "0xA50E10", Length = "0xA2")]
	private void SetPreviousPanelActive(bool toggle)
	{
	}

	[Token(Token = "0x60033EE")]
	[Address(RVA = "0xA520C0", Offset = "0xA50EC0", Length = "0x3DB")]
	private void DoFirePickerAction()
	{
	}

	[Token(Token = "0x60033EF")]
	[Address(RVA = "0xA524A0", Offset = "0xA512A0", Length = "0x2DA")]
	private void DoBoilPickerAction()
	{
	}

	[Token(Token = "0x60033F0")]
	[Address(RVA = "0xA52780", Offset = "0xA51580", Length = "0x14F")]
	private static bool TryFindFire(GameObject fireObject, out Fire fire)
	{
		fire = null;
		return false;
	}

	[Token(Token = "0x60033F1")]
	[Address(RVA = "0xA528D0", Offset = "0xA516D0", Length = "0x223")]
	private static GameObject GetInteractiveParentRoot(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60033F2")]
	[Address(RVA = "0xA52B00", Offset = "0xA51900", Length = "0x1E3")]
	private GearPlacePoint FindFireEmptyPlacePoint()
	{
		return null;
	}

	[Token(Token = "0x60033F3")]
	[Address(RVA = "0xA52CF0", Offset = "0xA51AF0", Length = "0x5AF")]
	private CookingSlot FindFireEmptyCookingSlot()
	{
		return null;
	}

	[Token(Token = "0x60033F4")]
	[Address(RVA = "0xA532A0", Offset = "0xA520A0", Length = "0x2A9")]
	private void SetBGWidgetsEnabled(bool shouldEnable)
	{
	}

	[Token(Token = "0x60033F5")]
	[Address(RVA = "0xA53550", Offset = "0xA52350", Length = "0x220")]
	private void RefreshGearItemIcons()
	{
	}

	[Token(Token = "0x60033F6")]
	[Address(RVA = "0xA53780", Offset = "0xA52580", Length = "0xC9")]
	private void MaybePlayPlacedPotAudio(GearPlacePoint gpp, GearItem gearItem)
	{
	}

	[Token(Token = "0x60033F7")]
	[Address(RVA = "0xA53850", Offset = "0xA52650", Length = "0x20F")]
	public Panel_GearSelect()
	{
	}
}
