using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000601")]
public class Panel_ActionPicker : Panel_AutoReferenced
{
	[Token(Token = "0x2000602")]
	public delegate void OnCancelDelegate();

	[Token(Token = "0x400374D")]
	private const string SPRITE_STARTFIRE = "ico_skills_fireStarting";

	[Token(Token = "0x400374E")]
	private const string SPRITE_CHARCOAL = "icoMap_coal";

	[Token(Token = "0x400374F")]
	private const string SPRITE_PLACE = "ico_climb";

	[Token(Token = "0x4003750")]
	private const string SPRITE_COOK = "ico_cooking_pot";

	[Token(Token = "0x4003751")]
	private const string SPRITE_WATER = "ico_water_prep";

	[Token(Token = "0x4003752")]
	private const string SPRITE_BREAKDOWN = "ico_dismantle";

	[Token(Token = "0x4003753")]
	private const string SPRITE_TAKETORCH = "ico_torch";

	[Token(Token = "0x4003754")]
	private const string SPRITE_FEEDFIRE = "ico_feed_fire";

	[Token(Token = "0x4003755")]
	private const string SPRITE_CRAFTING = "ico_crafting";

	[Token(Token = "0x4003756")]
	private const string SPRITE_PICKUP = "ico_climb";

	[Token(Token = "0x4003757")]
	private const string LOCID_STARTFIRE = "GAMEPLAY_StartFire";

	[Token(Token = "0x4003758")]
	private const string LOCID_CHARCOAL = "GAMEPLAY_HarvestCharcoal";

	[Token(Token = "0x4003759")]
	private const string LOCID_PLACE = "GAMEPLAY_Place";

	[Token(Token = "0x400375A")]
	private const string LOCID_COOK = "GAMEPLAY_Cook";

	[Token(Token = "0x400375B")]
	private const string LOCID_WATER = "GAMEPLAY_Water";

	[Token(Token = "0x400375C")]
	private const string LOCID_BREAKDOWN = "GAMEPLAY_BreakDown";

	[Token(Token = "0x400375D")]
	private const string LOCID_FEEDFIRE = "GAMEPLAY_AddFuel";

	[Token(Token = "0x400375E")]
	private const string LOCID_TAKETORCH = "GAMEPLAY_TakeTorch";

	[Token(Token = "0x400375F")]
	private const string LOCID_CRAFTING = "GAMEPLAY_Crafting";

	[Token(Token = "0x4003760")]
	private const string LOCID_PICKUP = "GAMEPLAY_PickUp";

	[SerializeField]
	[Token(Token = "0x4003761")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Cooking> m_Cooking;

	[SerializeField]
	[Token(Token = "0x4003762")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_CookWater> m_CookWater;

	[SerializeField]
	[Token(Token = "0x4003763")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[SerializeField]
	[Token(Token = "0x4003764")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_FireStart> m_FireStart;

	[SerializeField]
	[Token(Token = "0x4003765")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_GearSelect> m_GearSelect;

	[SerializeField]
	[Token(Token = "0x4003766")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Crafting> m_Crafting;

	[SerializeField]
	[Token(Token = "0x4003767")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[Token(Token = "0x4003768")]
	[FieldOffset(Offset = "0x68")]
	public ActionPickerItem[] m_ActionPickerItemList;

	[Token(Token = "0x4003769")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_SpriteBG;

	[Token(Token = "0x400376A")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_SpriteBG_Glow;

	[Token(Token = "0x400376B")]
	[FieldOffset(Offset = "0x80")]
	public float m_ActionPickerItemOffset;

	[Token(Token = "0x400376C")]
	[FieldOffset(Offset = "0x84")]
	public float m_BGWidthPerItem;

	[SerializeField]
	[Token(Token = "0x400376D")]
	[FieldOffset(Offset = "0x88")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400376E")]
	[FieldOffset(Offset = "0x90")]
	public OnCancelDelegate OnCancelCallback;

	[Token(Token = "0x400376F")]
	[FieldOffset(Offset = "0x98")]
	private readonly List<ActionPickerItemData> m_ActionPickerItemDataList;

	[Token(Token = "0x4003770")]
	[FieldOffset(Offset = "0xA0")]
	private int m_SelectedIndex;

	[Token(Token = "0x4003771")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_ObjectInteractedWith;

	[Token(Token = "0x4003772")]
	[FieldOffset(Offset = "0xB0")]
	private FireplaceInteraction m_FireplaceInteractedWith;

	[Token(Token = "0x4003773")]
	[FieldOffset(Offset = "0xB8")]
	private CookingSlot m_CookingSlotInteractedWith;

	[Token(Token = "0x4003774")]
	[FieldOffset(Offset = "0xC0")]
	private FireState m_LastFireState;

	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x965700", Offset = "0x964500", Length = "0x99")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x9657A0", Offset = "0x9645A0", Length = "0x187")]
	private void Update()
	{
	}

	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x965930", Offset = "0x964730", Length = "0x1D0")]
	private bool ShouldRebuildActionPicker()
	{
		return false;
	}

	[Token(Token = "0x6002E68")]
	[Address(RVA = "0x965B10", Offset = "0x964910", Length = "0xF8")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002E69")]
	[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
	public GameObject GetObjectInteractedWith()
	{
		return null;
	}

	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x965C10", Offset = "0x964A10", Length = "0xB")]
	public void ShowActionPicker(GameObject interactionObject)
	{
	}

	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x965C20", Offset = "0x964A20", Length = "0x245")]
	public void ShowActionPicker(GameObject interactionObject, IEnumerable<ActionPickerItemData> itemData)
	{
	}

	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x965E70", Offset = "0x964C70", Length = "0x67")]
	private void ResetActionPicker()
	{
	}

	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x965EE0", Offset = "0x964CE0", Length = "0x6F")]
	private void RebuildActionPicker()
	{
	}

	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x965F50", Offset = "0x964D50", Length = "0x357")]
	public void UpdatePanelContent()
	{
	}

	[Token(Token = "0x6002E6F")]
	[Address(RVA = "0x9662B0", Offset = "0x9650B0", Length = "0x141")]
	private void MaybeUpdateFireplaceInteraction()
	{
	}

	[Token(Token = "0x6002E70")]
	[Address(RVA = "0x966400", Offset = "0x965200", Length = "0xF7")]
	private void MaybeUpdateCookingPotItem()
	{
	}

	[Token(Token = "0x6002E71")]
	[Address(RVA = "0x966500", Offset = "0x965300", Length = "0x134")]
	private void MaybeUpdateCookingSlot()
	{
	}

	[Token(Token = "0x6002E72")]
	[Address(RVA = "0x966640", Offset = "0x965440", Length = "0x58F")]
	private void AddLightFireActions(Fire fire)
	{
	}

	[Token(Token = "0x6002E73")]
	[Address(RVA = "0x966BD0", Offset = "0x9659D0", Length = "0x53D")]
	private void AddFeedFireActions(Fire fire)
	{
	}

	[Token(Token = "0x6002E74")]
	[Address(RVA = "0x967110", Offset = "0x965F10", Length = "0x316")]
	private void AddCookingPotActions()
	{
	}

	[Token(Token = "0x6002E75")]
	[Address(RVA = "0x967430", Offset = "0x966230", Length = "0x234")]
	private void AddCookingSlotActions()
	{
	}

	[Token(Token = "0x6002E76")]
	[Address(RVA = "0x967670", Offset = "0x966470", Length = "0x7E")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x9676F0", Offset = "0x9664F0", Length = "0xCC")]
	public void PreviousItem()
	{
	}

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x9677C0", Offset = "0x9665C0", Length = "0xDB")]
	public void NextItem()
	{
	}

	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x9678A0", Offset = "0x9666A0", Length = "0xD8")]
	public void OnSelect(int indexSelected)
	{
	}

	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x967980", Offset = "0x966780", Length = "0x101")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0x195E990", Offset = "0x195D790", Length = "0x117")]
	private bool TryGetComponentFromInteractedObject<T>(out T component) where T : MonoBehaviour
	{
		component = null;
		return false;
	}

	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0x967A90", Offset = "0x966890", Length = "0x282")]
	private void UpdateGamepadSelection()
	{
	}

	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0x967980", Offset = "0x966780", Length = "0x101")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6002E7E")]
	[Address(RVA = "0x967D20", Offset = "0x966B20", Length = "0x19E")]
	private void UpdateGamepadSelectedItem()
	{
	}

	[Token(Token = "0x6002E7F")]
	[Address(RVA = "0x967EC0", Offset = "0x966CC0", Length = "0x913")]
	private void EnableWithCurrentList()
	{
	}

	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x9687E0", Offset = "0x9675E0", Length = "0x79")]
	private void FireInteractCallback()
	{
	}

	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x968860", Offset = "0x967660", Length = "0xA0")]
	private void PlaceCookingItemOrToolCallback()
	{
	}

	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x968910", Offset = "0x967710", Length = "0xA0")]
	private void FireWaterCallback()
	{
	}

	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x9689C0", Offset = "0x9677C0", Length = "0x105")]
	private void TakeCharcoalCallback()
	{
	}

	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x968AD0", Offset = "0x9678D0", Length = "0xB4")]
	private void TakeTorchCallback()
	{
	}

	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x968B90", Offset = "0x967990", Length = "0x270")]
	private void DismantleFireCallback()
	{
	}

	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x968E10", Offset = "0x967C10", Length = "0x1E6")]
	private void DismantleFireCompleteCallback(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x969000", Offset = "0x967E00", Length = "0xA3")]
	private void CraftingCallback()
	{
	}

	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x9690B0", Offset = "0x967EB0", Length = "0x18D")]
	private void CookingPotPickUpCallback()
	{
	}

	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x969240", Offset = "0x968040", Length = "0xF7")]
	private void CookingPotCookCallback()
	{
	}

	[Token(Token = "0x6002E8A")]
	[Address(RVA = "0x969340", Offset = "0x968140", Length = "0x1BA")]
	private void CookingPotWaterCallback()
	{
	}

	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x969500", Offset = "0x968300", Length = "0x298")]
	private void CookingSlotCookCallback()
	{
	}

	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x9697A0", Offset = "0x9685A0", Length = "0x298")]
	private void CookingSlotWaterCallback()
	{
	}

	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x969A40", Offset = "0x968840", Length = "0x17F")]
	public Panel_ActionPicker()
	{
	}
}
