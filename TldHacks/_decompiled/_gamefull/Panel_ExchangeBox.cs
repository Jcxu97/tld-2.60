using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.Trader;
using TLD.UI.Generics;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x2000447")]
public class Panel_ExchangeBox : Panel_GenericContainerGearGrid
{
	[Token(Token = "0x40026A7")]
	private const string GAMEPLAY_CONFIRM = "GAMEPLAY_Confirm";

	[Token(Token = "0x40026A8")]
	private const string GAMEPLAY_EXCHANGE_BOX = "GAMEPLAY_ExchangeBox";

	[Header("Exchange Box Elements")]
	[SerializeField]
	[Token(Token = "0x40026A9")]
	[FieldOffset(Offset = "0x130")]
	private GameObject m_ActionButton;

	[SerializeField]
	[Token(Token = "0x40026AA")]
	[FieldOffset(Offset = "0x138")]
	private UILabel m_ActionButtonLabel;

	[Header("Rewards")]
	[SerializeField]
	[Token(Token = "0x40026AB")]
	[FieldOffset(Offset = "0x140")]
	private GameObject m_ExchangeBoxParent;

	[SerializeField]
	[Token(Token = "0x40026AC")]
	[FieldOffset(Offset = "0x148")]
	private GameObject m_RewardsParent;

	[SerializeField]
	[Token(Token = "0x40026AD")]
	[FieldOffset(Offset = "0x150")]
	private ScrollBehaviour m_RewardsTable;

	[SerializeField]
	[Token(Token = "0x40026AE")]
	[FieldOffset(Offset = "0x158")]
	private UIWidget m_RewardsWidget;

	[SerializeField]
	[Token(Token = "0x40026AF")]
	[FieldOffset(Offset = "0x160")]
	private UILabel m_NoItemsInRewardsLabel;

	[Header("Exchange Info")]
	[SerializeField]
	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0x168")]
	private UILabel m_ExchangeHeaderLabel;

	[SerializeField]
	[Token(Token = "0x40026B1")]
	[FieldOffset(Offset = "0x170")]
	private List<ExchangeBoxProgressListItem> m_ExchangeProgressItems;

	[Header("Exchange Selection")]
	[SerializeField]
	[Token(Token = "0x40026B2")]
	[FieldOffset(Offset = "0x178")]
	private UIGrid m_ExchangeButtonGrid;

	[SerializeField]
	[Token(Token = "0x40026B3")]
	[FieldOffset(Offset = "0x180")]
	private List<ExchangeButton> m_ExchangeButtons;

	[SerializeField]
	[Token(Token = "0x40026B4")]
	[FieldOffset(Offset = "0x188")]
	private List<GameObject> m_ExchangeButtonPrompts;

	[SerializeField]
	[Token(Token = "0x40026B5")]
	[FieldOffset(Offset = "0x190")]
	private UIGrid m_ExchangeButtonPipGrid;

	[SerializeField]
	[Token(Token = "0x40026B6")]
	[FieldOffset(Offset = "0x198")]
	private Color m_NormalPipColor;

	[SerializeField]
	[Token(Token = "0x40026B7")]
	[FieldOffset(Offset = "0x1A8")]
	private Color m_ShownPipColor;

	[SerializeField]
	[Token(Token = "0x40026B8")]
	[FieldOffset(Offset = "0x1B8")]
	private Color m_SelectedPipColor;

	[Header("Localization")]
	[SerializeField]
	[Token(Token = "0x40026B9")]
	[FieldOffset(Offset = "0x1C8")]
	private LocalizedString m_RewardsNotTakenMessage;

	[SerializeField]
	[Token(Token = "0x40026BA")]
	[FieldOffset(Offset = "0x1D0")]
	private LocalizedString m_TradeIncompleteMessage;

	[SerializeField]
	[Token(Token = "0x40026BB")]
	[FieldOffset(Offset = "0x1D8")]
	private LocalizedString m_CloseTradeText;

	[SerializeField]
	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0x1E0")]
	private LocalizedString m_TakeAllText;

	[SerializeField]
	[Token(Token = "0x40026BD")]
	[FieldOffset(Offset = "0x1E8")]
	private LocalizedString m_ExchangeText;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0x1F0")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0x1F8")]
	private PanelReference<Panel_PickUnits> m_PickUnits;

	[SerializeField]
	[Token(Token = "0x40026C0")]
	[FieldOffset(Offset = "0x200")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[Token(Token = "0x40026C1")]
	[FieldOffset(Offset = "0x208")]
	private readonly List<UISprite> m_ExchangeButtonPips;

	[Token(Token = "0x40026C2")]
	[FieldOffset(Offset = "0x210")]
	private readonly List<GearItem> m_LockedItemInventoryList;

	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x218")]
	private readonly List<GearItem> m_LockedItemContainerList;

	[Token(Token = "0x40026C4")]
	[FieldOffset(Offset = "0x220")]
	private ExchangeBox m_ExchangeBox;

	[Token(Token = "0x40026C5")]
	[FieldOffset(Offset = "0x228")]
	private Action m_OnExchangeBoxPanelClosed;

	[Token(Token = "0x40026C6")]
	[FieldOffset(Offset = "0x230")]
	private int m_FirstExchange;

	[Token(Token = "0x40026C7")]
	[FieldOffset(Offset = "0x234")]
	private int m_SelectedExchange;

	[Token(Token = "0x40026C8")]
	[FieldOffset(Offset = "0x238")]
	private int m_ExchangesCount;

	[Token(Token = "0x40026C9")]
	[FieldOffset(Offset = "0x23C")]
	private bool m_IsExchangeUIDirty;

	[Token(Token = "0x17000214")]
	private bool IsPickingUpRewards
	{
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x7EED90", Offset = "0x7EDB90", Length = "0x32")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600202D")]
	[Address(RVA = "0x7EEDD0", Offset = "0x7EDBD0", Length = "0x133")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600202E")]
	[Address(RVA = "0x7EEF10", Offset = "0x7EDD10", Length = "0xD0")]
	public void ShowExchangeBox(ExchangeBox exchangeBox, Action onExchangeBoxPanelClosed)
	{
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0x7EEFE0", Offset = "0x7EDDE0", Length = "0x257")]
	public override void ClosePanel()
	{
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0x7EF240", Offset = "0x7EE040", Length = "0x1B9")]
	private void OnConfirmRewardsTaken()
	{
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0x7EF400", Offset = "0x7EE200", Length = "0x2FC")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0x7EF700", Offset = "0x7EE500", Length = "0x77")]
	protected override void ResetSelectedIndex()
	{
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x7EF780", Offset = "0x7EE580", Length = "0x3D")]
	public void HandleOnActionButtonPressed()
	{
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x7EF7C0", Offset = "0x7EE5C0", Length = "0x2BA")]
	private void CloseTrade()
	{
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0x7EFA80", Offset = "0x7EE880", Length = "0x70")]
	private void HandleOnCloseTrade()
	{
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x7EFB00", Offset = "0x7EE900", Length = "0x868")]
	private void RefreshAvailableExchanges()
	{
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0x7F0370", Offset = "0x7EF170", Length = "0xA1")]
	public void HandleOnExchangeButtonLeftPressed()
	{
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x7F0420", Offset = "0x7EF220", Length = "0xA0")]
	public void HandleOnExchangeButtonRightPressed()
	{
	}

	[Token(Token = "0x6002039")]
	[Address(RVA = "0x7F04C0", Offset = "0x7EF2C0", Length = "0xF8")]
	public void HandleOnExchangeButtonPressed(ExchangeButton exchangeButton)
	{
	}

	[Token(Token = "0x600203A")]
	[Address(RVA = "0x7F05C0", Offset = "0x7EF3C0", Length = "0x4A2")]
	private void SetSelectedExchange(int selectedExchange)
	{
	}

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x7F0A70", Offset = "0x7EF870", Length = "0x3FC")]
	private void RefreshSelectedExchange()
	{
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x7F0E70", Offset = "0x7EFC70", Length = "0x16D")]
	protected override void RefreshTables()
	{
	}

	[Token(Token = "0x600203D")]
	[Address(RVA = "0x7F0FE0", Offset = "0x7EFDE0", Length = "0x8C7")]
	private void RefreshInventory()
	{
	}

	[Token(Token = "0x600203E")]
	[Address(RVA = "0x7F18B0", Offset = "0x7F06B0", Length = "0x6DE")]
	private void RefreshExchangeBox()
	{
	}

	[Token(Token = "0x600203F")]
	[Address(RVA = "0x7F1F90", Offset = "0x7F0D90", Length = "0x233")]
	public void TakeAllRewards()
	{
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x7F21D0", Offset = "0x7F0FD0", Length = "0xD1B")]
	public override void MoveItem()
	{
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x7F2EF0", Offset = "0x7F1CF0", Length = "0x37E")]
	private void HandleOnWaterTransfer(ItemLiquidVolume liters)
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x7F3270", Offset = "0x7F2070", Length = "0x3B2")]
	private void HandleOnStackableTransfer(int units)
	{
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x7F3630", Offset = "0x7F2430", Length = "0x452")]
	private void HandleOnItemTransfer()
	{
	}

	[Token(Token = "0x6002044")]
	[Address(RVA = "0x7F3A90", Offset = "0x7F2890", Length = "0xDE")]
	private GearItem GetSelectedGearItem()
	{
		return null;
	}

	[Token(Token = "0x6002045")]
	[Address(RVA = "0x7F3B70", Offset = "0x7F2970", Length = "0x73")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6002046")]
	[Address(RVA = "0x7F3BF0", Offset = "0x7F29F0", Length = "0x20E")]
	protected override void UpdateAlpha()
	{
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x7F3E00", Offset = "0x7F2C00", Length = "0x485")]
	protected override void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0x7F4290", Offset = "0x7F3090", Length = "0x3F4")]
	public override void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x7F4690", Offset = "0x7F3490", Length = "0x1D2")]
	public Panel_ExchangeBox()
	{
	}
}
