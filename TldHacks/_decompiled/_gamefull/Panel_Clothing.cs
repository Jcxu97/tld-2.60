using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

[Token(Token = "0x2000621")]
public class Panel_Clothing : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
{
	[Serializable]
	[Token(Token = "0x2000622")]
	public class HeadItemLayerAdjustment
	{
		[Token(Token = "0x4003A2F")]
		[FieldOffset(Offset = "0x10")]
		public GearItem m_Item;

		[Token(Token = "0x4003A30")]
		[FieldOffset(Offset = "0x18")]
		public List<GearItem> m_AdjustedBy;

		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public HeadItemLayerAdjustment()
		{
		}
	}

	[Token(Token = "0x2000623")]
	private class RefreshCoverflowNextFrame : IEnumerator
	{
		[Token(Token = "0x4003A31")]
		[FieldOffset(Offset = "0x10")]
		private readonly Panel_Clothing m_OwnerPanel;

		[Token(Token = "0x4003A32")]
		[FieldOffset(Offset = "0x18")]
		private bool m_Waited;

		[Token(Token = "0x170002E3")]
		public object Current
		{
			[Token(Token = "0x60030D3")]
			[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x9B66B0", Offset = "0x9B54B0", Length = "0x5C")]
		public RefreshCoverflowNextFrame(Panel_Clothing panelClothing)
		{
		}

		[Token(Token = "0x60030D4")]
		[Address(RVA = "0x9B6710", Offset = "0x9B5510", Length = "0x31")]
		public bool MoveNext()
		{
			return false;
		}

		[Token(Token = "0x60030D5")]
		[Address(RVA = "0x9B6750", Offset = "0x9B5550", Length = "0x5")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40039E5")]
	[FieldOffset(Offset = "0x30")]
	public MiniTopNav m_MiniTopNav;

	[Header("Item Description")]
	[Token(Token = "0x40039E6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_ItemDescriptionPageDummy;

	[Token(Token = "0x40039E7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ItemDescriptionPagePrefab;

	[Header("Temperature")]
	[Token(Token = "0x40039E8")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_FeelsLikeLabel;

	[Token(Token = "0x40039E9")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_AirTempLabel;

	[Token(Token = "0x40039EA")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_WindchillLabel;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40039EB")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x40039EC")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x40039ED")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x40039EE")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[SerializeField]
	[Token(Token = "0x40039EF")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x40039F0")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x40039F1")]
	[FieldOffset(Offset = "0x90")]
	public string m_OpenClothingAudio;

	[Token(Token = "0x40039F2")]
	[FieldOffset(Offset = "0x98")]
	public string m_CloseClothingAudio;

	[Token(Token = "0x40039F3")]
	[FieldOffset(Offset = "0xA0")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40039F4")]
	[FieldOffset(Offset = "0xA8")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x40039F5")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x40039F6")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_ButtonLeftGamepad;

	[Token(Token = "0x40039F7")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x40039F8")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_ButtonRightGamepad;

	[Token(Token = "0x40039F9")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_NonPaperDollObject;

	[Token(Token = "0x40039FA")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_PaperDollMale;

	[Token(Token = "0x40039FB")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_PaperDollFemale;

	[Token(Token = "0x40039FC")]
	[FieldOffset(Offset = "0xE8")]
	public Texture2D m_FullbodyTextureMale;

	[Token(Token = "0x40039FD")]
	[FieldOffset(Offset = "0xF0")]
	public Texture2D m_FullbodyTextureFemale;

	[Token(Token = "0x40039FE")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_CoverflowSection;

	[Token(Token = "0x40039FF")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_NoItemsOfTypeSection;

	[Token(Token = "0x4003A00")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_EmptySlotSection;

	[Token(Token = "0x4003A01")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_UseClothingItemLabel;

	[Token(Token = "0x4003A02")]
	[FieldOffset(Offset = "0x118")]
	public GenericClothingSlotSpawner[] m_BodyLayers;

	[Token(Token = "0x4003A03")]
	[FieldOffset(Offset = "0x120")]
	public GenericClothingSlotSpawner[] m_LegLayers;

	[Token(Token = "0x4003A04")]
	[FieldOffset(Offset = "0x128")]
	public GenericClothingSlotSpawner[] m_HandLayers;

	[Token(Token = "0x4003A05")]
	[FieldOffset(Offset = "0x130")]
	public GenericClothingSlotSpawner[] m_FeetLayers;

	[Token(Token = "0x4003A06")]
	[FieldOffset(Offset = "0x138")]
	public UITexture[] m_PaperDollHandsTextures;

	[Token(Token = "0x4003A07")]
	[FieldOffset(Offset = "0x140")]
	public UITexture[] m_PaperDollFeetTextures;

	[Token(Token = "0x4003A08")]
	[FieldOffset(Offset = "0x148")]
	public UILabel m_TotalWarmthLabel;

	[Token(Token = "0x4003A09")]
	[FieldOffset(Offset = "0x150")]
	public UILabel m_TotalWindproofLabel;

	[Token(Token = "0x4003A0A")]
	[FieldOffset(Offset = "0x158")]
	public UILabel m_TotalToughnessLabel;

	[Token(Token = "0x4003A0B")]
	[FieldOffset(Offset = "0x160")]
	public UILabel m_TotalMobilityLabel;

	[Token(Token = "0x4003A0C")]
	[FieldOffset(Offset = "0x168")]
	public UISlider m_TotalMobilitySlider;

	[Token(Token = "0x4003A0D")]
	[FieldOffset(Offset = "0x170")]
	public UILabel m_NumItemsLabel;

	[Token(Token = "0x4003A0E")]
	[FieldOffset(Offset = "0x178")]
	public UISprite m_FullHypothermiaSprite;

	[Token(Token = "0x4003A0F")]
	[FieldOffset(Offset = "0x180")]
	public UISprite m_HypothermiaRiskSprite;

	[Token(Token = "0x4003A10")]
	[FieldOffset(Offset = "0x188")]
	public UISprite m_HypothermiaRiskFillSprite;

	[Token(Token = "0x4003A11")]
	[FieldOffset(Offset = "0x190")]
	public GameObject m_ClothingStatLegend;

	[Token(Token = "0x4003A12")]
	[FieldOffset(Offset = "0x198")]
	public ClothingRegion[] m_DefaultSelectRegionOrder;

	[Token(Token = "0x4003A13")]
	[FieldOffset(Offset = "0x1A0")]
	public ClothingLayer[] m_DefaultSelectLayerOrder;

	[Token(Token = "0x4003A14")]
	[FieldOffset(Offset = "0x1A8")]
	public int m_HandsNormalLayer;

	[Token(Token = "0x4003A15")]
	[FieldOffset(Offset = "0x1AC")]
	public int m_HandsRaisedLayer;

	[Token(Token = "0x4003A16")]
	[FieldOffset(Offset = "0x1B0")]
	public List<string> m_HandItemsToRaiseLayer;

	[Token(Token = "0x4003A17")]
	[FieldOffset(Offset = "0x1B8")]
	public int m_FeetNormalLayer;

	[Token(Token = "0x4003A18")]
	[FieldOffset(Offset = "0x1BC")]
	public int m_FeetRaisedLayer;

	[Token(Token = "0x4003A19")]
	[FieldOffset(Offset = "0x1C0")]
	public List<string> m_FeetItemsToRaiseLayer;

	[Token(Token = "0x4003A1A")]
	[FieldOffset(Offset = "0x1C8")]
	public List<string> m_ToquesThatCannotLayerTogether;

	[Token(Token = "0x4003A1B")]
	[FieldOffset(Offset = "0x1D0")]
	public List<string> m_HeadItemsThatAltersToqueLayer;

	[Token(Token = "0x4003A1C")]
	[FieldOffset(Offset = "0x1D8")]
	public List<HeadItemLayerAdjustment> m_ItemLayerAdjustments;

	[Token(Token = "0x4003A1D")]
	[FieldOffset(Offset = "0x1E0")]
	public string m_EmptySlotTextureName;

	[Token(Token = "0x4003A1E")]
	[FieldOffset(Offset = "0x1E8")]
	private readonly List<ClothingSlot> m_ClothingSlots;

	[Token(Token = "0x4003A1F")]
	[FieldOffset(Offset = "0x1F0")]
	private readonly List<GearItemCoverflow> m_CoverflowItems;

	[Token(Token = "0x4003A20")]
	[FieldOffset(Offset = "0x1F8")]
	private readonly List<GearItem> m_ClothingItemsForSelectedSlot;

	[Token(Token = "0x4003A21")]
	[FieldOffset(Offset = "0x200")]
	private ClothingRegion m_SelectedRegion;

	[Token(Token = "0x4003A22")]
	[FieldOffset(Offset = "0x204")]
	private ClothingLayer m_SelectedLayer;

	[Token(Token = "0x4003A23")]
	[FieldOffset(Offset = "0x208")]
	private ItemDescriptionPage m_ItemDescriptionPage;

	[Token(Token = "0x4003A24")]
	[FieldOffset(Offset = "0x210")]
	private StringBuilder m_StringBuilder;

	[Token(Token = "0x4003A25")]
	[FieldOffset(Offset = "0x218")]
	private bool m_ShowPaperDollOnly;

	[Token(Token = "0x4003A26")]
	[FieldOffset(Offset = "0x21C")]
	private int m_SlotNavCameFromColumn;

	[Token(Token = "0x4003A27")]
	[FieldOffset(Offset = "0x220")]
	private uint m_OpenCloseAudioID;

	[Token(Token = "0x4003A28")]
	[FieldOffset(Offset = "0x224")]
	private bool m_IsDirty;

	[Token(Token = "0x4003A29")]
	[FieldOffset(Offset = "0x228")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x4003A2A")]
	[FieldOffset(Offset = "0x230")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x4003A2B")]
	[FieldOffset(Offset = "0x238")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x4003A2C")]
	[FieldOffset(Offset = "0x240")]
	private RefreshCoverflowNextFrame m_CoverflowRefresher;

	[Token(Token = "0x4003A2D")]
	private static readonly int s_PaperdollTextureShaderID;

	[Token(Token = "0x4003A2E")]
	[FieldOffset(Offset = "0x248")]
	private bool m_MovementPressedOnEnable;

	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x9AF8F0", Offset = "0x9AE6F0", Length = "0x409")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x9AFD00", Offset = "0x9AEB00", Length = "0x81B")]
	private void Update()
	{
	}

	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x9B0520", Offset = "0x9AF320", Length = "0x4C3")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60030A6")]
	[Address(RVA = "0x9B09F0", Offset = "0x9AF7F0", Length = "0x174")]
	private void SetDefaultSelection()
	{
	}

	[Token(Token = "0x60030A7")]
	[Address(RVA = "0x9B0B70", Offset = "0x9AF970", Length = "0x72")]
	public void ShowPaperDollOnly()
	{
	}

	[Token(Token = "0x60030A8")]
	[Address(RVA = "0x9B0BF0", Offset = "0x9AF9F0", Length = "0x142")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x9B0D40", Offset = "0x9AFB40", Length = "0x58")]
	private void MaybeFlagMovmentPressedOnEnable()
	{
	}

	[Token(Token = "0x60030AA")]
	[Address(RVA = "0x9B0DA0", Offset = "0x9AFBA0", Length = "0x70")]
	private bool ShouldIgnoreNavigationInput()
	{
		return false;
	}

	[Token(Token = "0x60030AB")]
	[Address(RVA = "0x9B0E10", Offset = "0x9AFC10", Length = "0x13C")]
	private void Navigate()
	{
	}

	[Token(Token = "0x60030AC")]
	[Address(RVA = "0x9B0F50", Offset = "0x9AFD50", Length = "0x2C7")]
	public void OnUseClothingItem()
	{
	}

	[Token(Token = "0x60030AD")]
	[Address(RVA = "0x9B1220", Offset = "0x9B0020", Length = "0x167")]
	public void OnDropItem()
	{
	}

	[Token(Token = "0x60030AE")]
	[Address(RVA = "0x9B1390", Offset = "0x9B0190", Length = "0x25B")]
	public void OnActionsButton()
	{
	}

	[Token(Token = "0x60030AF")]
	[Address(RVA = "0x9B15F0", Offset = "0x9B03F0", Length = "0x122")]
	public void NextTool()
	{
	}

	[Token(Token = "0x60030B0")]
	[Address(RVA = "0x9B1720", Offset = "0x9B0520", Length = "0x122")]
	public void PrevTool()
	{
	}

	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x9B1850", Offset = "0x9B0650", Length = "0xB7")]
	public void SelectItemByIndex(int index)
	{
	}

	[Token(Token = "0x60030B2")]
	[Address(RVA = "0x9B1910", Offset = "0x9B0710", Length = "0x39B")]
	public bool SelectClothingSlot(int col, int row, bool skipAudio = false)
	{
		return false;
	}

	[Token(Token = "0x60030B3")]
	[Address(RVA = "0x9B1CB0", Offset = "0x9B0AB0", Length = "0x225")]
	public ClothingSlot GetClothingSlot(ClothingRegion region, ClothingLayer layer)
	{
		return null;
	}

	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x9B1EE0", Offset = "0x9B0CE0", Length = "0x430")]
	public void SelectItemIfEquipped(GearItem gearItem)
	{
	}

	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x9B2320", Offset = "0x9B1120", Length = "0xE")]
	public void MoveCursorUp()
	{
	}

	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x9B2330", Offset = "0x9B1130", Length = "0xE")]
	public void MoveCursorDown()
	{
	}

	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x9B2340", Offset = "0x9B1140", Length = "0xF")]
	public void MoveCursorLeft()
	{
	}

	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x9B2350", Offset = "0x9B1150", Length = "0xF")]
	public void MoveCursorRight()
	{
	}

	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x9B2360", Offset = "0x9B1160", Length = "0xA")]
	public void UnequipItemInSelectedSlot()
	{
	}

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x9B2370", Offset = "0x9B1170", Length = "0x1CB")]
	public void UnequipItemInSelectedSlot(bool playAudio)
	{
	}

	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x9B2540", Offset = "0x9B1340", Length = "0x35")]
	public void MaybeRefreshVisuals()
	{
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x9B2580", Offset = "0x9B1380", Length = "0x135")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x9B26C0", Offset = "0x9B14C0", Length = "0x8E")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x9B2750", Offset = "0x9B1550", Length = "0x92E")]
	private void SetupScrollList()
	{
	}

	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x9B3080", Offset = "0x9B1E80", Length = "0x386")]
	private void RefreshCoverflowItems()
	{
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x9B3410", Offset = "0x9B2210", Length = "0x706")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x9B3B20", Offset = "0x9B2920", Length = "0x4E6")]
	private void UpdateGearStatsBlock()
	{
	}

	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x9B4010", Offset = "0x9B2E10", Length = "0x96C")]
	private void UpdateGlobalStatBars()
	{
	}

	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x9B4980", Offset = "0x9B3780", Length = "0x280")]
	private void UpdateTemperatureLabels()
	{
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x9B4C10", Offset = "0x9B3A10", Length = "0x546")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x9B5160", Offset = "0x9B3F60", Length = "0x24A")]
	private void ActivateTopLayerOnly(GenericClothingSlotSpawner[] layeredTextures)
	{
	}

	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x9B53B0", Offset = "0x9B41B0", Length = "0x296")]
	private void SelectDefaultSlot()
	{
	}

	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x9B5650", Offset = "0x9B4450", Length = "0xF5")]
	private void ToggleTexturesActive(UITexture[] textures, bool toggle)
	{
	}

	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x9B5750", Offset = "0x9B4550", Length = "0x47F")]
	private void MoveCursorUntilFindMatch(int horizontal, int vertical)
	{
	}

	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x9B5BD0", Offset = "0x9B49D0", Length = "0x2FF")]
	private void InstantiateItemDescriptionPage()
	{
	}

	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x9B5ED0", Offset = "0x9B4CD0", Length = "0x99")]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x9B5F70", Offset = "0x9B4D70", Length = "0x21C")]
	private void DeselectItems()
	{
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x9B6190", Offset = "0x9B4F90", Length = "0x38")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x9B61D0", Offset = "0x9B4FD0", Length = "0x1C3")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x9B63A0", Offset = "0x9B51A0", Length = "0x2A9")]
	public Panel_Clothing()
	{
	}
}
