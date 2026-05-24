using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Cooking;
using TLD.IntBackedUnit;
using TLD.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000635")]
public class Panel_CookWater : Panel_AutoReferenced
{
	[Token(Token = "0x2000636")]
	private delegate void OnDelegate();

	[Token(Token = "0x4003B23")]
	private static readonly ItemLiquidVolume s_DeltaLiters;

	[Token(Token = "0x4003B24")]
	private static readonly ItemLiquidVolume s_DeltaLitersImperial;

	[Token(Token = "0x4003B25")]
	[FieldOffset(Offset = "0x30")]
	public CookSettings m_CookSettings;

	[Token(Token = "0x4003B26")]
	[FieldOffset(Offset = "0x38")]
	public float m_HoursRemainingFullFireSprite;

	[Token(Token = "0x4003B27")]
	[FieldOffset(Offset = "0x3C")]
	public Color m_ScrollListSelectedColor;

	[Token(Token = "0x4003B28")]
	[FieldOffset(Offset = "0x4C")]
	public Color m_ScrollListUnselectedColor;

	[Token(Token = "0x4003B29")]
	[FieldOffset(Offset = "0x60")]
	public ScrollList m_FoodScrollList;

	[Token(Token = "0x4003B2A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_Label_EstimatedFireDuration;

	[Token(Token = "0x4003B2B")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_Label_FireTemperature;

	[Token(Token = "0x4003B2C")]
	[FieldOffset(Offset = "0x78")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003B2D")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_MouseButtonParent;

	[Token(Token = "0x4003B2E")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_ActionButtonObject;

	[Token(Token = "0x4003B2F")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_ActionSecondaryButtonObject;

	[Token(Token = "0x4003B30")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_ButtonIncreaseWater;

	[Token(Token = "0x4003B31")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_ButtonDecreaseWater;

	[Token(Token = "0x4003B32")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_ButtonIncreaseWaterBG;

	[Token(Token = "0x4003B33")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_ButtonDecreaseWaterBG;

	[Token(Token = "0x4003B34")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_WaterAmountLabel;

	[Token(Token = "0x4003B35")]
	[FieldOffset(Offset = "0xC0")]
	public Transform m_WaterSelectTransform;

	[SerializeField]
	[Token(Token = "0x4003B36")]
	[FieldOffset(Offset = "0xC8")]
	private AssetReferenceTexture2D m_MeltSnowIcon;

	[SerializeField]
	[Token(Token = "0x4003B37")]
	[FieldOffset(Offset = "0xD0")]
	private AssetReferenceTexture2D m_BoilWaterIcon;

	[Header("Cooked Item")]
	[Token(Token = "0x4003B38")]
	[FieldOffset(Offset = "0xD8")]
	public UITexture m_Texture_CookedItem;

	[Token(Token = "0x4003B39")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel m_Label_CookedItemName;

	[Token(Token = "0x4003B3A")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_Label_CookedItemDesc;

	[Token(Token = "0x4003B3B")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_Label_CookedItemWeight;

	[Token(Token = "0x4003B3C")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_Label_CookedItemCookTime;

	[Token(Token = "0x4003B3D")]
	[FieldOffset(Offset = "0x100")]
	private UILabel m_Label_ButtonAction;

	[Token(Token = "0x4003B3E")]
	[FieldOffset(Offset = "0x108")]
	private UILabel m_Label_ButtonSecondaryAction;

	[Token(Token = "0x4003B3F")]
	[FieldOffset(Offset = "0x110")]
	private ItemLiquidVolume m_BoilWaterLiters;

	[Token(Token = "0x4003B40")]
	[FieldOffset(Offset = "0x118")]
	private ItemLiquidVolume m_MeltSnowLiters;

	[Token(Token = "0x4003B41")]
	[FieldOffset(Offset = "0x120")]
	private GameObject m_FireContainer;

	[Token(Token = "0x4003B42")]
	[FieldOffset(Offset = "0x128")]
	private Fire m_Fire;

	[Token(Token = "0x4003B43")]
	[FieldOffset(Offset = "0x130")]
	private CookingPotItem m_CookingPotInteractedWith;

	[Token(Token = "0x4003B44")]
	[FieldOffset(Offset = "0x138")]
	private int m_SelectedFoodIndexVal;

	[Token(Token = "0x4003B45")]
	[FieldOffset(Offset = "0x140")]
	private readonly List<GearItem> m_FoodList;

	[Token(Token = "0x4003B46")]
	[FieldOffset(Offset = "0x148")]
	private readonly List<CookingItemListEntry> m_CookingItemList;

	[Token(Token = "0x4003B47")]
	[FieldOffset(Offset = "0x150")]
	private readonly List<OnDelegate> m_DoWaterDelegates;

	[Token(Token = "0x4003B48")]
	[FieldOffset(Offset = "0x158")]
	private readonly List<OnDelegate> m_OnWaterUpDelegates;

	[Token(Token = "0x4003B49")]
	[FieldOffset(Offset = "0x160")]
	private readonly List<OnDelegate> m_OnWaterDownDelegates;

	[Token(Token = "0x4003B4A")]
	[FieldOffset(Offset = "0x168")]
	private readonly List<string> m_WaterButtonStrings;

	[Token(Token = "0x4003B4B")]
	[FieldOffset(Offset = "0x170")]
	private int m_LastFireMinutes;

	[Token(Token = "0x4003B4C")]
	[FieldOffset(Offset = "0x174")]
	private int m_LastFireTemperature;

	[Token(Token = "0x170002EB")]
	private int SelectedFoodIndex
	{
		[Token(Token = "0x60031BC")]
		[Address(RVA = "0x9D66E0", Offset = "0x9D54E0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0x9D66F0", Offset = "0x9D54F0", Length = "0x5C3")]
		set
		{
		}
	}

	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x9D6CC0", Offset = "0x9D5AC0", Length = "0x1BE")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x9D6E80", Offset = "0x9D5C80", Length = "0x57C")]
	private void Update()
	{
	}

	[Token(Token = "0x60031C0")]
	[Address(RVA = "0x9D7400", Offset = "0x9D6200", Length = "0x4C")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60031C1")]
	[Address(RVA = "0x9D7450", Offset = "0x9D6250", Length = "0x357")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60031C2")]
	[Address(RVA = "0x6491F0", Offset = "0x647FF0", Length = "0x52")]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[Token(Token = "0x60031C3")]
	[Address(RVA = "0x9D77B0", Offset = "0x9D65B0", Length = "0x2E6")]
	private void RefreshFireDurationLabel()
	{
	}

	[Token(Token = "0x60031C4")]
	[Address(RVA = "0x9D7AA0", Offset = "0x9D68A0", Length = "0x63")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[Token(Token = "0x60031C5")]
	[Address(RVA = "0x9D7B10", Offset = "0x9D6910", Length = "0xE2")]
	public void OnDoAction()
	{
	}

	[Token(Token = "0x60031C6")]
	[Address(RVA = "0x9D7C00", Offset = "0x9D6A00", Length = "0x252")]
	public void OnDoActionSecondary()
	{
	}

	[Token(Token = "0x60031C7")]
	[Address(RVA = "0x9D7E60", Offset = "0x9D6C60", Length = "0x2DE")]
	public void OnBoil()
	{
	}

	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x9D8140", Offset = "0x9D6F40", Length = "0x363")]
	public void OnBoilUp()
	{
	}

	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x9D84B0", Offset = "0x9D72B0", Length = "0x18F")]
	public void OnBoilDown()
	{
	}

	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x9D8640", Offset = "0x9D7440", Length = "0xAE")]
	private ItemLiquidVolume ReduceToNearestDeltaMultiple(ItemLiquidVolume numLiters)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x60031CB")]
	[Address(RVA = "0x9D86F0", Offset = "0x9D74F0", Length = "0xD1")]
	private ItemLiquidVolume GetDeltaLiters()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x60031CC")]
	[Address(RVA = "0x9D87D0", Offset = "0x9D75D0", Length = "0x3A9")]
	public void OnMeltSnow()
	{
	}

	[Token(Token = "0x60031CD")]
	[Address(RVA = "0x9D8B80", Offset = "0x9D7980", Length = "0x1D6")]
	public void OnMeltSnowUp()
	{
	}

	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x9D8D60", Offset = "0x9D7B60", Length = "0xD9")]
	public void OnMeltSnowDown()
	{
	}

	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x9D8E40", Offset = "0x9D7C40", Length = "0xA1")]
	private void OnDoWater()
	{
	}

	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x9D8EF0", Offset = "0x9D7CF0", Length = "0xA1")]
	public void OnWaterDown()
	{
	}

	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x9D8FA0", Offset = "0x9D7DA0", Length = "0xA1")]
	public void OnWaterUp()
	{
	}

	[Token(Token = "0x60031D2")]
	[Address(RVA = "0x9D9050", Offset = "0x9D7E50", Length = "0x45")]
	public void PlayButtonClick()
	{
	}

	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x9D90A0", Offset = "0x9D7EA0", Length = "0x253")]
	public void SetFireContainer(GameObject go)
	{
	}

	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x9D9300", Offset = "0x9D8100", Length = "0x13B")]
	public void ExitCookingInterface()
	{
	}

	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x9D9440", Offset = "0x9D8240", Length = "0x18D")]
	private void UpdateScrollLists()
	{
	}

	[Token(Token = "0x60031D6")]
	[Address(RVA = "0x9D95D0", Offset = "0x9D83D0", Length = "0x93")]
	private void ScrollDown()
	{
	}

	[Token(Token = "0x60031D7")]
	[Address(RVA = "0x9D9670", Offset = "0x9D8470", Length = "0x6D")]
	private void ScrollUp()
	{
	}

	[Token(Token = "0x60031D8")]
	[Address(RVA = "0x9D96E0", Offset = "0x9D84E0", Length = "0xD3")]
	private bool SelectedFoodIsSnow()
	{
		return false;
	}

	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x9D97C0", Offset = "0x9D85C0", Length = "0x195")]
	private bool SelectedFoodIsWater()
	{
		return false;
	}

	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x9D9960", Offset = "0x9D8760", Length = "0x8D")]
	private GearItem GetSelectedFood()
	{
		return null;
	}

	[Token(Token = "0x60031DB")]
	[Address(RVA = "0x9D99F0", Offset = "0x9D87F0", Length = "0x197")]
	private GameObject GetBoilableWaterSupply()
	{
		return null;
	}

	[Token(Token = "0x60031DC")]
	[Address(RVA = "0x9D9B90", Offset = "0x9D8990", Length = "0xE75")]
	private void RefreshFoodList()
	{
	}

	[Token(Token = "0x60031DD")]
	[Address(RVA = "0x9DAA10", Offset = "0x9D9810", Length = "0x3BC")]
	private void RefreshWater()
	{
	}

	[Token(Token = "0x60031DE")]
	[Address(RVA = "0x9DADD0", Offset = "0x9D9BD0", Length = "0x26A")]
	private void RefreshSnow()
	{
	}

	[Token(Token = "0x60031DF")]
	[Address(RVA = "0x9DB040", Offset = "0x9D9E40", Length = "0xA")]
	private void MakeDefaultSelections()
	{
	}

	[Token(Token = "0x60031E0")]
	[Address(RVA = "0x9DB050", Offset = "0x9D9E50", Length = "0x165")]
	private void ClampMeltSnowAmount()
	{
	}

	[Token(Token = "0x60031E1")]
	[Address(RVA = "0x9DB1C0", Offset = "0x9D9FC0", Length = "0x35E")]
	private void ClampWaterBoilAmount()
	{
	}

	[Token(Token = "0x60031E2")]
	[Address(RVA = "0x9DB520", Offset = "0x9DA320", Length = "0x535")]
	private void UpdateGearItem()
	{
	}

	[Token(Token = "0x60031E3")]
	[Address(RVA = "0x9DBA60", Offset = "0x9DA860", Length = "0x122")]
	private void EnableActionButton(bool enabled)
	{
	}

	[Token(Token = "0x60031E4")]
	[Address(RVA = "0x9DBB90", Offset = "0x9DA990", Length = "0x66A")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60031E5")]
	[Address(RVA = "0x9DC200", Offset = "0x9DB000", Length = "0x15B")]
	private void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x60031E6")]
	[Address(RVA = "0x9DC360", Offset = "0x9DB160", Length = "0x419")]
	public Panel_CookWater()
	{
	}
}
