using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.Trader;
using TLD.UI;
using TLD.UI.Scroll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000448")]
public class Panel_TradeSelection : Panel_AutoReferenced, IScrollModel
{
	[Token(Token = "0x40026CA")]
	private const string GAMEPLAY_ACCEPT_TRADE = "GAMEPLAY_AcceptTrade";

	[Token(Token = "0x40026CB")]
	private const string GAMEPLAY_BUTTON_BACK = "GAMEPLAY_ButtonBack";

	[SerializeField]
	[Token(Token = "0x40026CC")]
	[FieldOffset(Offset = "0x30")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Trade Exchange List")]
	[SerializeField]
	[Token(Token = "0x40026CD")]
	[FieldOffset(Offset = "0x38")]
	private ScrollBehaviour m_ScrollBehaviour;

	[SerializeField]
	[Token(Token = "0x40026CE")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_TradesSelectedLabel;

	[SerializeField]
	[Token(Token = "0x40026CF")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_TradesSelectedText;

	[Header("Selected Exchange Roots")]
	[SerializeField]
	[Token(Token = "0x40026D0")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_SpecialRequestRoot;

	[SerializeField]
	[Token(Token = "0x40026D1")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_RegularRequestRoot;

	[Header("Selected Exchange View")]
	[SerializeField]
	[Token(Token = "0x40026D2")]
	[FieldOffset(Offset = "0x60")]
	private UILabel m_TradeExchangeDescriptionLabel;

	[SerializeField]
	[Token(Token = "0x40026D3")]
	[FieldOffset(Offset = "0x68")]
	private UITexture m_GainedItemTexture;

	[SerializeField]
	[Token(Token = "0x40026D4")]
	[FieldOffset(Offset = "0x70")]
	private UILabel m_GainedItemNameLabel;

	[SerializeField]
	[Token(Token = "0x40026D5")]
	[FieldOffset(Offset = "0x78")]
	private UIGrid m_GainedItemStatsGrid;

	[SerializeField]
	[Token(Token = "0x40026D6")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_GainedItemConditionParent;

	[SerializeField]
	[Token(Token = "0x40026D7")]
	[FieldOffset(Offset = "0x88")]
	private UILabel m_GainedItemConditionLabel;

	[SerializeField]
	[Token(Token = "0x40026D8")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_GainedItemCaloriesParent;

	[SerializeField]
	[Token(Token = "0x40026D9")]
	[FieldOffset(Offset = "0x98")]
	private UILabel m_GainedItemCaloriesLabel;

	[SerializeField]
	[Token(Token = "0x40026DA")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_GainedItemWeightParent;

	[SerializeField]
	[Token(Token = "0x40026DB")]
	[FieldOffset(Offset = "0xA8")]
	private UILabel m_GainedItemWeightLabel;

	[Header("Exchange Requirements")]
	[SerializeField]
	[Token(Token = "0x40026DC")]
	[FieldOffset(Offset = "0xB0")]
	private List<TradeExchangeRequirementItem> m_RequirementItems;

	[Header("Exchange Multiplier")]
	[SerializeField]
	[Token(Token = "0x40026DD")]
	[FieldOffset(Offset = "0xB8")]
	private UILabel m_ExchangeMultiplierLabel;

	[Token(Token = "0x40026DE")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<TradeExchangeData> m_TradeExchanges;

	[Token(Token = "0x40026DF")]
	[FieldOffset(Offset = "0xC8")]
	private int[] m_TradeExchangesMultiplier;

	[Token(Token = "0x40026E0")]
	[FieldOffset(Offset = "0xD0")]
	private readonly List<TradeExchangeData> m_SelectedTradeExchanges;

	[Token(Token = "0x40026E1")]
	[FieldOffset(Offset = "0xD8")]
	private GearItemData m_GainedItemData;

	[Token(Token = "0x40026E2")]
	[FieldOffset(Offset = "0xE0")]
	private AsyncOperationHandle<GameObject> m_GainedItemHandle;

	[Token(Token = "0x40026E3")]
	[FieldOffset(Offset = "0xF8")]
	private readonly List<GamepadButtonSprite> m_GamepadButtonSprites;

	[Token(Token = "0x40026E4")]
	[FieldOffset(Offset = "0x100")]
	private TraderRadio m_TraderRadio;

	[Token(Token = "0x17000215")]
	private TradeExchangeData SelectedTradeExchange
	{
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x7F4870", Offset = "0x7F3670", Length = "0x74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x7F48F0", Offset = "0x7F36F0", Length = "0x94")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x7F4990", Offset = "0x7F3790", Length = "0x237")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x7F4BD0", Offset = "0x7F39D0", Length = "0x52")]
	public void SetTraderRadio(TraderRadio traderRadio)
	{
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x7F4C30", Offset = "0x7F3A30", Length = "0xFC")]
	private void Update()
	{
	}

	[Token(Token = "0x600204F")]
	[Address(RVA = "0x7F4D30", Offset = "0x7F3B30", Length = "0x30D")]
	private void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x7F5040", Offset = "0x7F3E40", Length = "0x4A3")]
	private void RefreshAvailableExchanges()
	{
	}

	[Token(Token = "0x6002051")]
	[Address(RVA = "0x7F54F0", Offset = "0x7F42F0", Length = "0xA0")]
	private int SortTradeExchanges(TradeExchangeData a, TradeExchangeData b)
	{
		return 0;
	}

	[Token(Token = "0x6002052")]
	[Address(RVA = "0x7F55A0", Offset = "0x7F43A0", Length = "0x7EB")]
	private void UpdateSelectedExchange()
	{
	}

	[Token(Token = "0x6002053")]
	[Address(RVA = "0x7F5D90", Offset = "0x7F4B90", Length = "0x1FA")]
	private void UpdateSelectedExchangeRequirements(int multiplier)
	{
	}

	[Token(Token = "0x6002054")]
	[Address(RVA = "0x7F5F90", Offset = "0x7F4D90", Length = "0x486")]
	public void AddSelectedExchange()
	{
	}

	[Token(Token = "0x6002055")]
	[Address(RVA = "0x7F6420", Offset = "0x7F5220", Length = "0x499")]
	public void RemoveSelectedExchange()
	{
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x7F68C0", Offset = "0x7F56C0", Length = "0x4ED")]
	public void AcceptTrade()
	{
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	public void GoBack()
	{
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0x7F6DD0", Offset = "0x7F5BD0", Length = "0x16D")]
	public void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x6002059")]
	[Address(RVA = "0x7F6F40", Offset = "0x7F5D40", Length = "0x7")]
	public void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex)
	{
	}

	[Token(Token = "0x600205A")]
	[Address(RVA = "0x7F6F50", Offset = "0x7F5D50", Length = "0x26F")]
	public Panel_TradeSelection()
	{
	}
}
