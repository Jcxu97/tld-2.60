using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000254")]
public class ItemDescriptionPage : MonoBehaviour
{
	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Inventory> m_InventoryPanel;

	[SerializeField]
	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_GenericProgressBar> m_ProgressBar;

	[Header("General")]
	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_ItemNameLabel;

	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_BGNormal;

	[SerializeField]
	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0x48")]
	private UIGrid m_VerticalGrid;

	[SerializeField]
	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x50")]
	private UIGrid m_StatsGrid;

	[Header("Top Left Notes")]
	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_ItemNotesIcon;

	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_ItemNotesIconShadow;

	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ItemNotesLabel;

	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0x70")]
	public string m_WearingIcon;

	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x78")]
	public string m_InProgressIcon;

	[Header("Top Left Clothing Notes")]
	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_ClothingNotesIcon;

	[Token(Token = "0x40014BD")]
	[FieldOffset(Offset = "0x88")]
	public UISprite m_ClothingNotesIconShadow;

	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x90")]
	public UILabel m_ClothingNotesLabel;

	[Header("Top Right Status")]
	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x98")]
	public UISprite m_TopRightStatusIcon;

	[Token(Token = "0x40014C0")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite m_TopRightStatusIconShadow;

	[Token(Token = "0x40014C1")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel m_TopRightStatusLabel;

	[Header("Top Left Status")]
	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite m_TopLeftStatusIcon;

	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite m_TopLeftStatusIconShadow;

	[Token(Token = "0x40014C4")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_TopLeftStatusLabel;

	[Header("Stack Status")]
	[Token(Token = "0x40014C5")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite m_StackStatusIcon;

	[Token(Token = "0x40014C6")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite m_StackStatusIconShadow;

	[Token(Token = "0x40014C7")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel m_StackStatusLabel;

	[Token(Token = "0x40014C8")]
	[FieldOffset(Offset = "0xE0")]
	public Color m_StackStatusColor;

	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0xF0")]
	public string m_LiquidIcon;

	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0xF8")]
	public string m_LampFuelIcon;

	[Header("Favorite")]
	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_FavoriteObject;

	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_FavoriteCheckmark;

	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_FavoriteLabel;

	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x118")]
	public Color m_FavoriteLabelColorChecked;

	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x128")]
	public Color m_FavoriteLabelColorUnchecked;

	[Header("Food Hot Status")]
	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0x138")]
	public string m_FoodHotStatusIcon;

	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x140")]
	public Color m_FoodHotStatusColor;

	[Header("Food Cold Status")]
	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x150")]
	public string m_FoodColdStatusIcon;

	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x158")]
	public Color m_FoodColdStatusColor;

	[Header("Frozen Status")]
	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x168")]
	public string m_FrozenStatusIcon;

	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x170")]
	public Color m_FrozenStatusColor;

	[Header("Wet Status")]
	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x180")]
	public string m_WetStatusIcon;

	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x188")]
	public Color m_WetStatusColor;

	[Header("Clothing Layer Status")]
	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x198")]
	public UISprite m_ClothingLayerStatusIcon;

	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0x1A0")]
	public UISprite m_ClothingLayerStatusIconShadow;

	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0x1A8")]
	public UILabel m_ClothingLayerStatusLabel;

	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x1B0")]
	public string m_ClothingOuterLayerIcon;

	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x1B8")]
	public string m_ClothingInnerLayerIcon;

	[Header("Dish Benefits")]
	[SerializeField]
	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x1C0")]
	private GameObject m_DishEffectSpacer;

	[SerializeField]
	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0x1C8")]
	private GameObject m_BGDishWithBenefits;

	[SerializeField]
	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0x1D0")]
	private DishEffectInfo m_DishEffectInfo;

	[Header("Description")]
	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0x1D8")]
	public UILabel m_ItemDescLabel;

	[Token(Token = "0x40014E1")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject m_ClothingStatsObject;

	[Header("Condition")]
	[SerializeField]
	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0x1E8")]
	private GameObject m_ConditionObject;

	[Token(Token = "0x40014E3")]
	[FieldOffset(Offset = "0x1F0")]
	public UISprite m_ItemConditionSprite;

	[Token(Token = "0x40014E4")]
	[FieldOffset(Offset = "0x1F8")]
	public UILabel m_ItemConditionLabel;

	[Token(Token = "0x40014E5")]
	[FieldOffset(Offset = "0x200")]
	public UISprite m_ItemConditionArrow;

	[Token(Token = "0x40014E6")]
	[FieldOffset(Offset = "0x208")]
	public UISprite m_PermanentItemSprite;

	[Header("Crafting")]
	[Token(Token = "0x40014E7")]
	[FieldOffset(Offset = "0x210")]
	public CraftingProgress m_CraftingProgress;

	[Header("Mobility")]
	[Token(Token = "0x40014E8")]
	[FieldOffset(Offset = "0x218")]
	public UILabel m_ItemMobilityLabel;

	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x220")]
	public UISprite m_ItemMobilityArrow;

	[Header("Toughness")]
	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x228")]
	public UILabel m_ItemToughnessLabel;

	[Token(Token = "0x40014EB")]
	[FieldOffset(Offset = "0x230")]
	public UISlider m_ItemToughnessSlider;

	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0x238")]
	public UISprite m_ItemToughnessArrow;

	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x240")]
	public float m_ItemToughnessMaxValue;

	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x248")]
	public UISprite m_ItemToughnessFillSprite;

	[Header("Waterproofness")]
	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x250")]
	public UILabel m_ItemWaterproofnessLabel;

	[Token(Token = "0x40014F0")]
	[FieldOffset(Offset = "0x258")]
	public UISlider m_ItemWaterproofnessSlider;

	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x260")]
	public UISprite m_ItemWaterproofnessArrow;

	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x268")]
	public UISprite m_ItemWaterproofFillSprite;

	[Header("Warmth")]
	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x270")]
	public UILabel m_ItemWarmthLabel;

	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x278")]
	public UISprite m_ItemWarmthArrow;

	[Header("Weight")]
	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x280")]
	public UILabel m_ItemWeightLabel;

	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x288")]
	public UISprite m_ItemWeightArrow;

	[Header("Calories")]
	[SerializeField]
	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0x290")]
	private GameObject m_CaloriesObject;

	[SerializeField]
	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x298")]
	private UILabel m_CaloriesLabel;

	[Header("VitaminC")]
	[SerializeField]
	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x2A0")]
	private GameObject m_VitaminCObject;

	[SerializeField]
	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x2A8")]
	private UILabel m_VitaminCLabel;

	[Header("Windproof")]
	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x2B0")]
	public UILabel m_ItemWindproofLabel;

	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x2B8")]
	public UISprite m_ItemWindproofArrow;

	[Header("Compare Colors")]
	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x2C0")]
	public Color m_CompareColorBetter;

	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x2D0")]
	public Color m_CompareColorWorse;

	[Header("Item Stat Colors")]
	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x2E0")]
	public Color m_BlueGreenColor;

	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x2F0")]
	public Color m_WhiteColor;

	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x300")]
	public Color m_RedColor;

	[Header("Insulated Flask")]
	[SerializeField]
	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x310")]
	private GameObject m_FlaskTopLevel;

	[SerializeField]
	[Token(Token = "0x4001503")]
	[FieldOffset(Offset = "0x318")]
	private GameObject m_FlaskCold;

	[SerializeField]
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x320")]
	private GameObject m_FlaskHot;

	[SerializeField]
	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x328")]
	private UISprite m_FlaskHotFillSprite;

	[SerializeField]
	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x330")]
	private UILabel m_FlaskContentsLabel;

	[Header("Travois")]
	[SerializeField]
	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x338")]
	private GameObject m_InvalidTravoisDeployLocation;

	[Header("Heat Pad")]
	[SerializeField]
	[Token(Token = "0x4001508")]
	[FieldOffset(Offset = "0x340")]
	private GameObject m_HeatPadTopLevel;

	[SerializeField]
	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x348")]
	private UILabel m_HeatPadTimeLeft;

	[SerializeField]
	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x350")]
	private UILabel m_HeatPadTemperature;

	[Header("Buttons")]
	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x358")]
	public UIButton m_UIButton_ButtonEquip;

	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x360")]
	public UIButton m_UIButton_ButtonDrop;

	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0x368")]
	public GameObject m_MouseButtonEquip;

	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0x370")]
	public GameObject m_MouseButtonExamine;

	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0x378")]
	public GameObject m_MouseButtonDrop;

	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0x380")]
	public UILabel m_Label_MouseButtonEquip;

	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0x388")]
	public UILabel m_Label_MouseButtonExamine;

	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0x390")]
	public UILabel m_Label_MouseButtonDrop;

	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0x398")]
	public OnButtonDelegate m_OnDropDelegate;

	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0x3A0")]
	public OnButtonDelegate m_OnActionsDelegate;

	[Token(Token = "0x4001515")]
	[FieldOffset(Offset = "0x3A8")]
	public OnButtonDelegate m_OnEquipDelegate;

	[Token(Token = "0x600146D")]
	[Address(RVA = "0x686CF0", Offset = "0x685AF0", Length = "0x4A4")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600146E")]
	[Address(RVA = "0x6871A0", Offset = "0x685FA0", Length = "0x131F")]
	public void UpdateGearItemDescription(GearItem gi, GearItem compareItem, OnButtonDelegate onDrop, OnButtonDelegate onActions, OnButtonDelegate onEquip, bool allowActions)
	{
	}

	[Token(Token = "0x600146F")]
	[Address(RVA = "0x6884C0", Offset = "0x6872C0", Length = "0x795")]
	public void UpdateDecorationItemDescription(DecorationItem di, OnButtonDelegate onDrop)
	{
	}

	[Token(Token = "0x6001470")]
	[Address(RVA = "0x688C60", Offset = "0x687A60", Length = "0x3CB")]
	public bool CanExamine(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6001471")]
	[Address(RVA = "0x689030", Offset = "0x687E30", Length = "0x2D2")]
	public bool CanDrop(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6001472")]
	[Address(RVA = "0x689310", Offset = "0x688110", Length = "0x260")]
	public bool CanDrop(DecorationItem di)
	{
		return false;
	}

	[Token(Token = "0x6001473")]
	[Address(RVA = "0x689580", Offset = "0x688380", Length = "0xBF7")]
	public static string GetEquipButtonLocalizationId(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x6001474")]
	[Address(RVA = "0x68A180", Offset = "0x688F80", Length = "0x189")]
	public static string GetDropButtonLocalizationId(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x6001475")]
	[Address(RVA = "0x68A310", Offset = "0x689110", Length = "0x25")]
	public void OnDrop()
	{
	}

	[Token(Token = "0x6001476")]
	[Address(RVA = "0x68A340", Offset = "0x689140", Length = "0x25")]
	public void OnActions()
	{
	}

	[Token(Token = "0x6001477")]
	[Address(RVA = "0x68A370", Offset = "0x689170", Length = "0x25")]
	public void OnEquip()
	{
	}

	[Token(Token = "0x6001478")]
	[Address(RVA = "0x68A3A0", Offset = "0x6891A0", Length = "0x68")]
	public void OnFavorite()
	{
	}

	[Token(Token = "0x6001479")]
	[Address(RVA = "0x68A410", Offset = "0x689210", Length = "0x260")]
	private string BuildItemDescription(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x600147A")]
	[Address(RVA = "0x68A680", Offset = "0x689480", Length = "0x44F")]
	private void UpdateConditionDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x600147B")]
	[Address(RVA = "0x68AAD0", Offset = "0x6898D0", Length = "0x2B0")]
	private void UpdateAndEnableTopRightStatus(string text, string spriteName, Color c)
	{
	}

	[Token(Token = "0x600147C")]
	[Address(RVA = "0x68AD90", Offset = "0x689B90", Length = "0x2B0")]
	private void UpdateAndEnableTopLeftStatus(string text, string spriteName, Color c)
	{
	}

	[Token(Token = "0x600147D")]
	[Address(RVA = "0x68B050", Offset = "0x689E50", Length = "0x304")]
	private void UpdateAndEnableStackStatus(string text, string spriteName, Color c)
	{
	}

	[Token(Token = "0x600147E")]
	[Address(RVA = "0x68B360", Offset = "0x68A160", Length = "0x2B0")]
	private void UpdateAndEnableClothingLayerStatus(string text, string spriteName, Color c)
	{
	}

	[Token(Token = "0x600147F")]
	[Address(RVA = "0x68B620", Offset = "0x68A420", Length = "0x606")]
	private void UpdateTopRightStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001480")]
	[Address(RVA = "0x68BC30", Offset = "0x68AA30", Length = "0x302")]
	private void UpdateTopLeftStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001481")]
	[Address(RVA = "0x68BF40", Offset = "0x68AD40", Length = "0x51B")]
	private void UpdateStackStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001482")]
	[Address(RVA = "0x68C460", Offset = "0x68B260", Length = "0x22A")]
	private void UpdateClothingLayerStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0x68C690", Offset = "0x68B490", Length = "0x1D2")]
	private void UpdateFavoriteStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0x68C870", Offset = "0x68B670", Length = "0x1CE")]
	private void UpdateInsulatedFlaskIndicators(InsulatedFlask insulatedFlask)
	{
	}

	[Token(Token = "0x6001485")]
	[Address(RVA = "0x68CA40", Offset = "0x68B840", Length = "0x1B9")]
	private void UpdateTravoisDeployStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001486")]
	[Address(RVA = "0x68CC00", Offset = "0x68BA00", Length = "0x215")]
	private void UpdateHeatPadStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6001487")]
	[Address(RVA = "0x68CE20", Offset = "0x68BC20", Length = "0x2F3")]
	private string StripBraces(string text)
	{
		return null;
	}

	[Token(Token = "0x6001488")]
	[Address(RVA = "0x68D120", Offset = "0x68BF20", Length = "0x93")]
	private void UpdateWeightDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0x68D1C0", Offset = "0x68BFC0", Length = "0x1ED")]
	private void UpdateCaloriesDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x600148A")]
	[Address(RVA = "0x68D3B0", Offset = "0x68C1B0", Length = "0x1CA")]
	private void UpdateVitaminCDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x600148B")]
	[Address(RVA = "0x68D580", Offset = "0x68C380", Length = "0xB4")]
	private void UpdateWindproofDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x600148C")]
	[Address(RVA = "0x68D640", Offset = "0x68C440", Length = "0xB4")]
	private void UpdateWarmthDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x600148D")]
	[Address(RVA = "0x68D700", Offset = "0x68C500", Length = "0xC6")]
	private void UpdateMobilityDisplay(GearItem gi)
	{
	}

	[Token(Token = "0x600148E")]
	[Address(RVA = "0x68D7D0", Offset = "0x68C5D0", Length = "0x353")]
	private void UpdateWaterproofnessDisplay(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x600148F")]
	[Address(RVA = "0x68DB30", Offset = "0x68C930", Length = "0x30F")]
	private void UpdateToughnessDisplay(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x6001490")]
	[Address(RVA = "0x68DE40", Offset = "0x68CC40", Length = "0x4A0")]
	public void UpdateButtons(GearItem gi, bool allowActions)
	{
	}

	[Token(Token = "0x6001491")]
	[Address(RVA = "0x68E2F0", Offset = "0x68D0F0", Length = "0x1A3")]
	public static string GetExamineButtonLocalizationID(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x6001492")]
	[Address(RVA = "0x68E4A0", Offset = "0x68D2A0", Length = "0x7D6")]
	private string GetItemInfoString(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0x68EC80", Offset = "0x68DA80", Length = "0x3D2")]
	private Color GetColorForInfoString(GearItem gi)
	{
		return default(Color);
	}

	[Token(Token = "0x6001494")]
	[Address(RVA = "0x68F060", Offset = "0x68DE60", Length = "0x32E")]
	private void UpdateComparisonArrows(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0x68F390", Offset = "0x68E190", Length = "0x15B")]
	private void UpdateItemConditionArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0x68F4F0", Offset = "0x68E2F0", Length = "0x1B3")]
	private void UpdateItemMobilityArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x6001497")]
	[Address(RVA = "0x68F6B0", Offset = "0x68E4B0", Length = "0x1B3")]
	private void UpdateItemToughnessArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x6001498")]
	[Address(RVA = "0x68F870", Offset = "0x68E670", Length = "0x1C3")]
	private void UpdateItemWaterproofnessArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0x68FA40", Offset = "0x68E840", Length = "0x1D5")]
	private void UpdateItemWarmthArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x600149A")]
	[Address(RVA = "0x68FC20", Offset = "0x68EA20", Length = "0x201")]
	private void UpdateItemWeightArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x600149B")]
	[Address(RVA = "0x68FE30", Offset = "0x68EC30", Length = "0x1D5")]
	private void UpdateItemWindproofArrow(GearItem gi, GearItem compareItem)
	{
	}

	[Token(Token = "0x600149C")]
	[Address(RVA = "0x690010", Offset = "0x68EE10", Length = "0xCF")]
	private void UpdateArrow(UISprite sprite, int compareValue)
	{
	}

	[Token(Token = "0x600149D")]
	[Address(RVA = "0x6900E0", Offset = "0x68EEE0", Length = "0x136")]
	private void DisableAllComparisonArrows()
	{
	}

	[Token(Token = "0x600149E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ItemDescriptionPage()
	{
	}
}
