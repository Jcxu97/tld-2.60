using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Cooking;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Scroll;
using TLD.Utility;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000633")]
public class Panel_Cooking : Panel_AutoReferenced, IAccelerateTimeProvider, IScrollModel
{
	[Token(Token = "0x2000634")]
	private enum NavArea
	{
		[Token(Token = "0x4003B21")]
		Category,
		[Token(Token = "0x4003B22")]
		CookingItem
	}

	[Token(Token = "0x4003AC4")]
	private const string ACTION_INVENTORY_SORT = "Inventory_Sort";

	[Token(Token = "0x4003AC5")]
	private const string ACTION_PICKUP_COOKINGPOT = "FeedFire_TakeTorch";

	[Token(Token = "0x4003AC6")]
	private const string ACTION_CONTINUE = "Continue";

	[Token(Token = "0x4003AC7")]
	private const string ACTION_BACK = "Escape";

	[Token(Token = "0x4003AC8")]
	private const string LOCID_HEATUP = "GAMEPLAY_HeatUp";

	[Token(Token = "0x4003AC9")]
	private const string LOCID_PICKUP = "GAMEPLAY_PickUp";

	[Token(Token = "0x4003ACA")]
	private const string LOCID_SELECT = "GAMEPLAY_Select";

	[Token(Token = "0x4003ACB")]
	private const string LOCID_COOK = "GAMEPLAY_Cook";

	[Token(Token = "0x4003ACC")]
	private const string LOCID_SORT = "GAMEPLAY_Sort";

	[Token(Token = "0x4003ACD")]
	private const string LOCID_BACK = "GAMEPLAY_ButtonBack";

	[Token(Token = "0x4003ACE")]
	private const string LOCID_CANNOTCOOKWITHPOT = "GAMEPLAY_CannotCookWithSelectedPot";

	[Token(Token = "0x4003ACF")]
	private const string LOCID_EMBERS = "GAMEPLAY_Embers";

	[Token(Token = "0x4003AD0")]
	private const string TEXT_INFINITY = "∞";

	[SerializeField]
	[Token(Token = "0x4003AD1")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_PanelTitleLabel;

	[SerializeField]
	[Token(Token = "0x4003AD2")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_CookingTitle;

	[SerializeField]
	[Token(Token = "0x4003AD3")]
	[FieldOffset(Offset = "0x40")]
	private LocalizedString m_RecipeBookTitle;

	[SerializeField]
	[Token(Token = "0x4003AD4")]
	[FieldOffset(Offset = "0x48")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x4003AD5")]
	[FieldOffset(Offset = "0x50")]
	private ButtonLegendContainer m_SortButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x4003AD6")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_MouseButtonParent;

	[SerializeField]
	[Token(Token = "0x4003AD7")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_ActionButtonObject;

	[SerializeField]
	[Token(Token = "0x4003AD8")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_ActionSecondaryButtonObject;

	[SerializeField]
	[Token(Token = "0x4003AD9")]
	[FieldOffset(Offset = "0x70")]
	private GameObject[] m_ActiveOnlyWhenFoodListHasItems;

	[Header("Fire Properties")]
	[SerializeField]
	[Token(Token = "0x4003ADA")]
	[FieldOffset(Offset = "0x78")]
	private UILabel m_Label_EstimatedFireDuration;

	[SerializeField]
	[Token(Token = "0x4003ADB")]
	[FieldOffset(Offset = "0x80")]
	private UILabel m_Label_FireTemperature;

	[SerializeField]
	[Token(Token = "0x4003ADC")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_ActiveCookingDetails;

	[Header("Cooked Item")]
	[SerializeField]
	[Token(Token = "0x4003ADD")]
	[FieldOffset(Offset = "0x90")]
	private UITexture m_Texture_CookedItem;

	[SerializeField]
	[Token(Token = "0x4003ADE")]
	[FieldOffset(Offset = "0x98")]
	private UILabel m_Label_CookedItemName;

	[SerializeField]
	[Token(Token = "0x4003ADF")]
	[FieldOffset(Offset = "0xA0")]
	private UILabel m_Label_CookedItemDesc;

	[SerializeField]
	[Token(Token = "0x4003AE0")]
	[FieldOffset(Offset = "0xA8")]
	private UILabel m_Label_CookedItemCondition;

	[SerializeField]
	[Token(Token = "0x4003AE1")]
	[FieldOffset(Offset = "0xB0")]
	private UILabel m_Label_CookedItemCalories;

	[SerializeField]
	[Token(Token = "0x4003AE2")]
	[FieldOffset(Offset = "0xB8")]
	private UILabel m_Label_CookedItemHydration;

	[SerializeField]
	[Token(Token = "0x4003AE3")]
	[FieldOffset(Offset = "0xC0")]
	private UILabel m_Label_CookedItemWeight;

	[SerializeField]
	[Token(Token = "0x4003AE4")]
	[FieldOffset(Offset = "0xC8")]
	private UILabel m_Label_CookedItemCookTime;

	[SerializeField]
	[Token(Token = "0x4003AE5")]
	[FieldOffset(Offset = "0xD0")]
	private DishEffectInfo m_DishEffectInfo;

	[SerializeField]
	[Token(Token = "0x4003AE6")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject m_SmallStatsBG;

	[SerializeField]
	[Token(Token = "0x4003AE7")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_StatsBG;

	[Header("Recipes")]
	[SerializeField]
	[Token(Token = "0x4003AE8")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject m_SpecialRecipeIndicator;

	[SerializeField]
	[Token(Token = "0x4003AE9")]
	[FieldOffset(Offset = "0xF0")]
	private LocalizedString m_RecipePreparationText;

	[SerializeField]
	[Token(Token = "0x4003AEA")]
	[FieldOffset(Offset = "0xF8")]
	private float m_RecipePreparationDisplayTimeSeconds;

	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x4003AEB")]
	[FieldOffset(Offset = "0x100")]
	private string m_RecipePreparationSprite;

	[SerializeField]
	[Token(Token = "0x4003AEC")]
	[FieldOffset(Offset = "0x108")]
	private float m_SkillIncreaseChanceOnFailure;

	[SerializeField]
	[Token(Token = "0x4003AED")]
	[FieldOffset(Offset = "0x10C")]
	private float m_SkillIncreaseChanceOnSuccess;

	[Header("Recipe Ingredients")]
	[SerializeField]
	[Token(Token = "0x4003AEE")]
	[FieldOffset(Offset = "0x110")]
	private GameObject m_IngredientsRoot;

	[SerializeField]
	[Token(Token = "0x4003AEF")]
	[FieldOffset(Offset = "0x118")]
	private Transform m_IngredientsParent;

	[SerializeField]
	[Token(Token = "0x4003AF0")]
	[FieldOffset(Offset = "0x120")]
	private UILabel m_SelectedIngredientLabel;

	[SerializeField]
	[Token(Token = "0x4003AF1")]
	[FieldOffset(Offset = "0x128")]
	private RecipeIngredientListItem m_IngredientItemPrefab;

	[SerializeField]
	[Token(Token = "0x4003AF2")]
	[FieldOffset(Offset = "0x130")]
	private Vector2Int m_IngredientGridSize;

	[SerializeField]
	[Token(Token = "0x4003AF3")]
	[FieldOffset(Offset = "0x138")]
	private Vector2 m_IngredientGridOffsets;

	[SerializeField]
	[Token(Token = "0x4003AF4")]
	[FieldOffset(Offset = "0x140")]
	private LiquidType m_PotableWater;

	[Header("Cooked Item Warning")]
	[SerializeField]
	[Token(Token = "0x4003AF5")]
	[FieldOffset(Offset = "0x148")]
	private GameObject m_WarningIndicator;

	[SerializeField]
	[Token(Token = "0x4003AF6")]
	[FieldOffset(Offset = "0x150")]
	private UILabel m_WarningLabel;

	[Header("Cooked VitaminC")]
	[SerializeField]
	[Token(Token = "0x4003AF7")]
	[FieldOffset(Offset = "0x158")]
	private GameObject m_CookedItemVitaminC_Root;

	[SerializeField]
	[Token(Token = "0x4003AF8")]
	[FieldOffset(Offset = "0x160")]
	private UILabel m_Label_CookedItemVitaminC;

	[Header("Sort")]
	[SerializeField]
	[Token(Token = "0x4003AF9")]
	[FieldOffset(Offset = "0x168")]
	private GameObject m_SortLabel;

	[SerializeField]
	[Token(Token = "0x4003AFA")]
	[FieldOffset(Offset = "0x170")]
	private GameObject m_SortButtonsObject;

	[SerializeField]
	[Token(Token = "0x4003AFB")]
	[FieldOffset(Offset = "0x178")]
	private UIButton[] m_SortButtons;

	[Header("Cookables List")]
	[SerializeField]
	[Token(Token = "0x4003AFC")]
	[FieldOffset(Offset = "0x180")]
	private UILabel m_RecipesHeader;

	[SerializeField]
	[Token(Token = "0x4003AFD")]
	[FieldOffset(Offset = "0x188")]
	private ScrollBehaviour m_ScrollBehaviour;

	[SerializeField]
	[Token(Token = "0x4003AFE")]
	[FieldOffset(Offset = "0x190")]
	private AssetLabelReference m_RecipeLabel;

	[SerializeField]
	[Token(Token = "0x4003AFF")]
	[FieldOffset(Offset = "0x198")]
	private GameObject m_EmptyListContent;

	[Header("Cookables List Categories")]
	[SerializeField]
	[Token(Token = "0x4003B00")]
	[FieldOffset(Offset = "0x1A0")]
	private CategoryButtonNavigation m_CategoryNavigation;

	[SerializeField]
	[Token(Token = "0x4003B01")]
	[FieldOffset(Offset = "0x1A8")]
	private List<CookingToolPanelFilterButton> m_FilterButtons;

	[SerializeField]
	[Token(Token = "0x4003B02")]
	[FieldOffset(Offset = "0x1B0")]
	private float m_FilterButtonOffset;

	[SerializeField]
	[Token(Token = "0x4003B03")]
	[FieldOffset(Offset = "0x1B8")]
	private Transform m_CategoryArrowTransform;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4003B04")]
	[FieldOffset(Offset = "0x1C0")]
	private AK.Wwise.Event m_OpenAudio;

	[Header("Error Messages")]
	[SerializeField]
	[Token(Token = "0x4003B05")]
	[FieldOffset(Offset = "0x1C8")]
	private LocalizedString m_ErrorSkillTooLow;

	[SerializeField]
	[Token(Token = "0x4003B06")]
	[FieldOffset(Offset = "0x1D0")]
	private LocalizedString m_ErrorWrongCookingPot;

	[SerializeField]
	[Token(Token = "0x4003B07")]
	[FieldOffset(Offset = "0x1D8")]
	private LocalizedString m_ErrorMissingIngredient;

	[SerializeField]
	[Token(Token = "0x4003B08")]
	[FieldOffset(Offset = "0x1E0")]
	private LocalizedString m_ErrorMissingNoCookingPotInInventory;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003B09")]
	[FieldOffset(Offset = "0x1E8")]
	private PanelReference<Panel_CanOpening> m_CanOpening;

	[SerializeField]
	[Token(Token = "0x4003B0A")]
	[FieldOffset(Offset = "0x1F0")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4003B0B")]
	[FieldOffset(Offset = "0x1F8")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4003B0C")]
	[FieldOffset(Offset = "0x200")]
	private PanelReference<Panel_RecipeBook> m_RecipeBook;

	[HideInInspector]
	[Token(Token = "0x4003B0D")]
	[FieldOffset(Offset = "0x208")]
	public bool m_ShowingAsRecipeBook;

	[Token(Token = "0x4003B0E")]
	[FieldOffset(Offset = "0x210")]
	private UILabel m_Label_ButtonAction;

	[Token(Token = "0x4003B0F")]
	[FieldOffset(Offset = "0x218")]
	private UILabel m_Label_ButtonSecondaryAction;

	[Token(Token = "0x4003B10")]
	[FieldOffset(Offset = "0x220")]
	private Fire m_Fire;

	[Token(Token = "0x4003B11")]
	[FieldOffset(Offset = "0x228")]
	private CookingSlot m_CookingSlot;

	[Token(Token = "0x4003B12")]
	[FieldOffset(Offset = "0x230")]
	private CookingPotItem m_CookingPotInteractedWith;

	[Token(Token = "0x4003B13")]
	[FieldOffset(Offset = "0x238")]
	private readonly CraftingOperation m_RecipePrepOperation;

	[Token(Token = "0x4003B14")]
	[FieldOffset(Offset = "0x240")]
	private readonly List<CookableItem> m_FoodList;

	[Token(Token = "0x4003B15")]
	[FieldOffset(Offset = "0x248")]
	private bool[] m_SortFlipDictionary;

	[Token(Token = "0x4003B16")]
	[FieldOffset(Offset = "0x250")]
	private readonly List<RecipeIngredientListItem> m_IngredientItems;

	[Token(Token = "0x4003B17")]
	[FieldOffset(Offset = "0x258")]
	private readonly List<HighlightButton> m_SortHighlightButtons;

	[Token(Token = "0x4003B18")]
	[FieldOffset(Offset = "0x260")]
	private NavArea m_CurrentNavArea;

	[Token(Token = "0x4003B19")]
	[FieldOffset(Offset = "0x268")]
	private readonly List<CookingToolPanelFilterButton> m_ValidFilterButtons;

	[Token(Token = "0x4003B1A")]
	[FieldOffset(Offset = "0x270")]
	private int m_SelectedFilterIndex;

	[Token(Token = "0x4003B1B")]
	[FieldOffset(Offset = "0x274")]
	private int m_SelectedSortIndex;

	[Token(Token = "0x4003B1C")]
	[FieldOffset(Offset = "0x278")]
	private int m_LastFireMinutes;

	[Token(Token = "0x4003B1D")]
	[FieldOffset(Offset = "0x27C")]
	private int m_LastFireTemperature;

	[Token(Token = "0x4003B1E")]
	[FieldOffset(Offset = "0x280")]
	private bool m_RecipesRefreshed;

	[Token(Token = "0x4003B1F")]
	[FieldOffset(Offset = "0x281")]
	private bool m_HasAnyRecipes;

	[Token(Token = "0x6003187")]
	[Address(RVA = "0x9CBDA0", Offset = "0x9CABA0", Length = "0x1181")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003188")]
	[Address(RVA = "0x9CCF30", Offset = "0x9CBD30", Length = "0x390")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003189")]
	[Address(RVA = "0x9CD2D0", Offset = "0x9CC0D0", Length = "0x7C")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x600318A")]
	[Address(RVA = "0x9CD350", Offset = "0x9CC150", Length = "0x45C")]
	private void Update()
	{
	}

	[Token(Token = "0x600318B")]
	[Address(RVA = "0x9CD7B0", Offset = "0x9CC5B0", Length = "0x32")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600318C")]
	[Address(RVA = "0x9CD7F0", Offset = "0x9CC5F0", Length = "0x64E")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600318D")]
	[Address(RVA = "0x9CDE40", Offset = "0x9CCC40", Length = "0x1DE")]
	private void LookAtCookingSlot()
	{
	}

	[Token(Token = "0x600318E")]
	[Address(RVA = "0x9CE020", Offset = "0x9CCE20", Length = "0x2A4")]
	public void SetCookingSlot(CookingSlot cookingSlot)
	{
	}

	[Token(Token = "0x600318F")]
	[Address(RVA = "0x97CF40", Offset = "0x97BD40", Length = "0x52")]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[Token(Token = "0x6003190")]
	[Address(RVA = "0x9CE2D0", Offset = "0x9CD0D0", Length = "0x2E9")]
	private void RefreshFireDurationLabel()
	{
	}

	[Token(Token = "0x6003191")]
	[Address(RVA = "0x9CE5C0", Offset = "0x9CD3C0", Length = "0x295")]
	public void OnDoAction()
	{
	}

	[Token(Token = "0x6003192")]
	[Address(RVA = "0x9CE860", Offset = "0x9CD660", Length = "0x252")]
	public void OnDoActionSecondary()
	{
	}

	[Token(Token = "0x6003193")]
	[Address(RVA = "0x9CEAC0", Offset = "0x9CD8C0", Length = "0x1D1")]
	public void OnCook()
	{
	}

	[Token(Token = "0x6003194")]
	[Address(RVA = "0x9CECA0", Offset = "0x9CDAA0", Length = "0x231")]
	private void OnCookRecipe(RecipeData recipe)
	{
	}

	[Token(Token = "0x6003195")]
	[Address(RVA = "0x9CEEE0", Offset = "0x9CDCE0", Length = "0x890")]
	private void OnCookNormalFood(GearItem gi)
	{
	}

	[Token(Token = "0x6003196")]
	[Address(RVA = "0x9CF780", Offset = "0x9CE580", Length = "0x17D")]
	public void ExitCookingInterface()
	{
	}

	[Token(Token = "0x6003197")]
	[Address(RVA = "0x9CF900", Offset = "0x9CE700", Length = "0xBE")]
	private void UpdateScrollLists()
	{
	}

	[Token(Token = "0x6003198")]
	[Address(RVA = "0x9CF9C0", Offset = "0x9CE7C0", Length = "0xBA")]
	private CookableItem GetSelectedCookableItem()
	{
		return default(CookableItem);
	}

	[Token(Token = "0x6003199")]
	[Address(RVA = "0x9CFA80", Offset = "0x9CE880", Length = "0x106B")]
	private void RefreshFoodList()
	{
	}

	[Token(Token = "0x600319A")]
	[Address(RVA = "0x9D0AF0", Offset = "0x9CF8F0", Length = "0x139")]
	private void UpdateFilterButtons()
	{
	}

	[Token(Token = "0x600319B")]
	[Address(RVA = "0x9D0C30", Offset = "0x9CFA30", Length = "0x2C5")]
	private void SetFilterBasedOnCookingPot()
	{
	}

	[Token(Token = "0x600319C")]
	[Address(RVA = "0x9D0F00", Offset = "0x9CFD00", Length = "0x1FC")]
	private void UpdateFilterIndexFromCategoryNavigation(int filterIndex)
	{
	}

	[Token(Token = "0x600319D")]
	[Address(RVA = "0x9D1100", Offset = "0x9CFF00", Length = "0x27C")]
	private void UpdateFilterIndex(int filterIndex)
	{
	}

	[Token(Token = "0x600319E")]
	[Address(RVA = "0x9D1380", Offset = "0x9D0180", Length = "0x189")]
	public void OnSortButtonClicked(UIButton sortButtonClicked)
	{
	}

	[Token(Token = "0x600319F")]
	[Address(RVA = "0x9D1510", Offset = "0x9D0310", Length = "0x8D")]
	private void UpdateSortIndex(int sortIndex)
	{
	}

	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x9D15A0", Offset = "0x9D03A0", Length = "0xC0")]
	private void UpdateSortButtons()
	{
	}

	[Token(Token = "0x60031A1")]
	[Address(RVA = "0x9D1670", Offset = "0x9D0470", Length = "0x15F")]
	private static bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return false;
	}

	[Token(Token = "0x60031A2")]
	[Address(RVA = "0x9D17D0", Offset = "0x9D05D0", Length = "0x125")]
	private static bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x60031A3")]
	[Address(RVA = "0x9D1900", Offset = "0x9D0700", Length = "0x14EE")]
	private void UpdateCookableItem()
	{
	}

	[Token(Token = "0x60031A4")]
	[Address(RVA = "0x9D2DF0", Offset = "0x9D1BF0", Length = "0x1B6")]
	private void ClearCookableItemFields()
	{
	}

	[Token(Token = "0x60031A5")]
	[Address(RVA = "0x9D2FB0", Offset = "0x9D1DB0", Length = "0x2D8")]
	private void UpdateRecipeContent(RecipeData recipe)
	{
	}

	[Token(Token = "0x60031A6")]
	[Address(RVA = "0x9D3290", Offset = "0x9D2090", Length = "0x468")]
	private void UpdateCookableContent(Cookable cookable)
	{
	}

	[Token(Token = "0x60031A7")]
	[Address(RVA = "0x9D3700", Offset = "0x9D2500", Length = "0x54A")]
	private void UpdateRecipeWarning(CookableItem cookableItem)
	{
	}

	[Token(Token = "0x60031A8")]
	[Address(RVA = "0x9D3C50", Offset = "0x9D2A50", Length = "0xDF1")]
	private void UpdateRecipeIngredients(RecipeData recipe)
	{
	}

	[Token(Token = "0x60031A9")]
	[Address(RVA = "0x9D4A50", Offset = "0x9D3850", Length = "0x271")]
	private static float GetCookedItemConditionPercent(GearItem rawItem)
	{
		return 0f;
	}

	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x9D4CD0", Offset = "0x9D3AD0", Length = "0x118")]
	private void EnableActionButton(bool enabled)
	{
	}

	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x9D4DF0", Offset = "0x9D3BF0", Length = "0x2E")]
	private void OnCancelRecipePreparation()
	{
	}

	[Token(Token = "0x60031AC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnRecipePrepEnd()
	{
	}

	[Token(Token = "0x60031AD")]
	[Address(RVA = "0x9D4E20", Offset = "0x9D3C20", Length = "0x2DF")]
	private void OnRecipePrepSuccess()
	{
	}

	[Token(Token = "0x60031AE")]
	[Address(RVA = "0x9D5100", Offset = "0x9D3F00", Length = "0x225")]
	private void OnRecipePrepInterruped(CraftingInterruptReason reason)
	{
	}

	[Token(Token = "0x60031AF")]
	[Address(RVA = "0x9D5330", Offset = "0x9D4130", Length = "0xA16")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x9D5D50", Offset = "0x9D4B50", Length = "0x25B")]
	private void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x60031B1")]
	[Address(RVA = "0x9D5FB0", Offset = "0x9D4DB0", Length = "0x50")]
	private void SetNavigationArea(NavArea target)
	{
	}

	[Token(Token = "0x60031B2")]
	[Address(RVA = "0x9D6010", Offset = "0x9D4E10", Length = "0x1A4")]
	public void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x60031B3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex)
	{
	}

	[Token(Token = "0x60031B4")]
	[Address(RVA = "0x9D61C0", Offset = "0x9D4FC0", Length = "0x1E")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x60031B5")]
	[Address(RVA = "0x9D61E0", Offset = "0x9D4FE0", Length = "0x60")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x60031B6")]
	[Address(RVA = "0x693740", Offset = "0x692540", Length = "0x8")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x60031B8")]
	[Address(RVA = "0x9D6250", Offset = "0x9D5050", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x60031B9")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x60031BA")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x60031BB")]
	[Address(RVA = "0x9D62D0", Offset = "0x9D50D0", Length = "0x409")]
	public Panel_Cooking()
	{
	}
}
