using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013A7")]
public class ExchangeBox : TimedHoldInteraction
{
	[Header("Box Elements")]
	[SerializeField]
	[Token(Token = "0x4008FFE")]
	[FieldOffset(Offset = "0x68")]
	private ObjectAnim m_ObjectAnim;

	[SerializeField]
	[Token(Token = "0x4008FFF")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_Lock;

	[Header("Water Supply References")]
	[SerializeField]
	[Token(Token = "0x4009000")]
	[FieldOffset(Offset = "0x78")]
	private GearItemData m_PotableWaterSupply;

	[SerializeField]
	[Token(Token = "0x4009001")]
	[FieldOffset(Offset = "0x80")]
	private GearItemData m_NonPotableWaterSupply;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4009002")]
	[FieldOffset(Offset = "0x88")]
	private AK.Wwise.Event m_BoxOpenEvent;

	[SerializeField]
	[Token(Token = "0x4009003")]
	[FieldOffset(Offset = "0x90")]
	private AK.Wwise.Event m_BoxCloseEvent;

	[Header("Box Locked Audio")]
	[SerializeField]
	[Token(Token = "0x4009004")]
	[FieldOffset(Offset = "0x98")]
	private AK.Wwise.Event m_BoxLockedEvent;

	[SerializeField]
	[Token(Token = "0x4009005")]
	[FieldOffset(Offset = "0xA0")]
	private float m_BoxLockedMinInterval;

	[Header("Interaction")]
	[SerializeField]
	[Token(Token = "0x4009006")]
	[FieldOffset(Offset = "0xA8")]
	private LocalizedString m_LockedPostFix;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4009007")]
	[FieldOffset(Offset = "0xB0")]
	private PanelReference<Panel_ExchangeBox> m_ExchangeBoxReference;

	[SerializeField]
	[Token(Token = "0x4009008")]
	[FieldOffset(Offset = "0xB8")]
	private PanelReference<Panel_PickUnits> m_PickUnits;

	[SerializeField]
	[Token(Token = "0x4009009")]
	[FieldOffset(Offset = "0xC0")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[Token(Token = "0x400900A")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_PendingClose;

	[Token(Token = "0x400900B")]
	[FieldOffset(Offset = "0xC9")]
	private bool m_IsOpening;

	[Token(Token = "0x400900C")]
	[FieldOffset(Offset = "0xCA")]
	private bool m_ShowingPanel;

	[Token(Token = "0x400900D")]
	[FieldOffset(Offset = "0xD0")]
	private ActiveTradeState m_ActiveTrade;

	[Token(Token = "0x400900E")]
	[FieldOffset(Offset = "0xD8")]
	private readonly List<List<GearItemObject>> m_Exchanges;

	[Token(Token = "0x400900F")]
	[FieldOffset(Offset = "0xE0")]
	private readonly List<GearItem> m_ItemsLockedInExchangeBox;

	[Token(Token = "0x4009010")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_IsLocked;

	[Token(Token = "0x4009011")]
	[FieldOffset(Offset = "0xE9")]
	private bool m_HasInitialized;

	[Token(Token = "0x4009012")]
	[FieldOffset(Offset = "0xEC")]
	private float m_BoxLockedEventTimer;

	[Token(Token = "0x17000AAB")]
	public bool CanPickupRewards
	{
		[Token(Token = "0x6007D76")]
		[Address(RVA = "0x11C7530", Offset = "0x11C6330", Length = "0x15")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007D77")]
	[Address(RVA = "0x11C7550", Offset = "0x11C6350", Length = "0x57")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007D78")]
	[Address(RVA = "0x11C75B0", Offset = "0x11C63B0", Length = "0x8B")]
	private void InitializeExchangeBox()
	{
	}

	[Token(Token = "0x6007D79")]
	[Address(RVA = "0x11C7640", Offset = "0x11C6440", Length = "0x26A")]
	private void Update()
	{
	}

	[Token(Token = "0x6007D7A")]
	[Address(RVA = "0x11C78B0", Offset = "0x11C66B0", Length = "0x27")]
	private void HandleOnExchangeBoxPanelClosed()
	{
	}

	[Token(Token = "0x6007D7B")]
	[Address(RVA = "0x11C78E0", Offset = "0x11C66E0", Length = "0xA0")]
	private bool IsPanelClosed()
	{
		return false;
	}

	[Token(Token = "0x6007D7C")]
	[Address(RVA = "0x11C7980", Offset = "0x11C6780", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007D7D")]
	[Address(RVA = "0x11C7990", Offset = "0x11C6790", Length = "0xD7")]
	public void SetActiveTrade(ActiveTradeState activeTrade)
	{
	}

	[Token(Token = "0x6007D7E")]
	[Address(RVA = "0x11C7A70", Offset = "0x11C6870", Length = "0x374")]
	private void CleanupPreparedItems()
	{
	}

	[Token(Token = "0x6007D7F")]
	[Address(RVA = "0x11C7DF0", Offset = "0x11C6BF0", Length = "0x114")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6007D80")]
	[Address(RVA = "0x11C7F10", Offset = "0x11C6D10", Length = "0x71")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6007D81")]
	[Address(RVA = "0x11C7F90", Offset = "0x11C6D90", Length = "0x1A7")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x6007D82")]
	[Address(RVA = "0x11C8140", Offset = "0x11C6F40", Length = "0x61")]
	public override void CancelHold()
	{
	}

	[Token(Token = "0x6007D83")]
	[Address(RVA = "0x11C81B0", Offset = "0x11C6FB0", Length = "0x1D")]
	protected override void EndHold()
	{
	}

	[Token(Token = "0x6007D84")]
	[Address(RVA = "0x11C81D0", Offset = "0x11C6FD0", Length = "0x4D")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6007D85")]
	[Address(RVA = "0x11C8220", Offset = "0x11C7020", Length = "0x4EF")]
	private void PrepareAndShowExchanges()
	{
	}

	[Token(Token = "0x6007D86")]
	[Address(RVA = "0x11C8710", Offset = "0x11C7510", Length = "0x806")]
	private void PrepareItemsInExchange(int exchange, List<ActiveTradeState.PlayerExchangedItem> exchangedItems)
	{
	}

	[Token(Token = "0x6007D87")]
	[Address(RVA = "0x11C8F20", Offset = "0x11C7D20", Length = "0x605")]
	private void PrepareAndShowRewards()
	{
	}

	[Token(Token = "0x6007D88")]
	[Address(RVA = "0x11C9530", Offset = "0x11C8330", Length = "0x2DA")]
	private void CloseExchangeBox()
	{
	}

	[Token(Token = "0x6007D89")]
	[Address(RVA = "0x11C9810", Offset = "0x11C8610", Length = "0x17A")]
	public bool TryAddToExistingStackable(int exchange, GearItem gearItem, out GearItem existingItem)
	{
		existingItem = null;
		return false;
	}

	[Token(Token = "0x6007D8A")]
	[Address(RVA = "0x11C9990", Offset = "0x11C8790", Length = "0x686")]
	public bool TryAddToExistingStackable(int exchange, GearItem gearItem, int units, out GearItem existingItem)
	{
		existingItem = null;
		return false;
	}

	[Token(Token = "0x6007D8B")]
	[Address(RVA = "0x11CA020", Offset = "0x11C8E20", Length = "0x275")]
	public void AddItem(int exchange, GearItem gearItem)
	{
	}

	[Token(Token = "0x6007D8C")]
	[Address(RVA = "0x11CA2A0", Offset = "0x11C90A0", Length = "0x357")]
	public void RemoveItem(int exchange, GearItem gearItem)
	{
	}

	[Token(Token = "0x6007D8D")]
	[Address(RVA = "0x11CA600", Offset = "0x11C9400", Length = "0x4D")]
	public int GetExchangeDataCount()
	{
		return 0;
	}

	[Token(Token = "0x6007D8E")]
	[Address(RVA = "0x11CA650", Offset = "0x11C9450", Length = "0xA5")]
	public TradeExchangeData GetExchangeData(int exchange)
	{
		return null;
	}

	[Token(Token = "0x6007D8F")]
	[Address(RVA = "0x11CA700", Offset = "0x11C9500", Length = "0xC6")]
	public void UpdateExchanged(int exchange)
	{
	}

	[Token(Token = "0x6007D90")]
	[Address(RVA = "0x11CA7D0", Offset = "0x11C95D0", Length = "0x73")]
	public List<GearItemObject> GetExchangedItems(int exchange)
	{
		return null;
	}

	[Token(Token = "0x6007D91")]
	[Address(RVA = "0x11CA850", Offset = "0x11C9650", Length = "0x366")]
	public GearItem GetWaterSupply(int exchange, LiquidQuality liquidQuality)
	{
		return null;
	}

	[Token(Token = "0x6007D92")]
	[Address(RVA = "0x11CABC0", Offset = "0x11C99C0", Length = "0xF1")]
	public bool IsLockedItem(int exchange, GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6007D93")]
	[Address(RVA = "0x11CACC0", Offset = "0x11C9AC0", Length = "0x281")]
	public int GetMissingAmount(int exchange, GearItem gearItem)
	{
		return 0;
	}

	[Token(Token = "0x6007D94")]
	[Address(RVA = "0x11CAF50", Offset = "0x11C9D50", Length = "0xC9")]
	public ItemLiquidVolume GetMissingLiquid(int exchange, GearItem gearItem)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6007D95")]
	[Address(RVA = "0x11CB020", Offset = "0x11C9E20", Length = "0x54")]
	private void SetLocked(bool isLocked)
	{
	}

	[Token(Token = "0x6007D96")]
	[Address(RVA = "0x11CB080", Offset = "0x11C9E80", Length = "0xC2")]
	private void AnimateBoxOpen()
	{
	}

	[Token(Token = "0x6007D97")]
	[Address(RVA = "0x11CB150", Offset = "0x11C9F50", Length = "0x108")]
	private void AnimateBoxClose()
	{
	}

	[Token(Token = "0x6007D98")]
	[Address(RVA = "0x11CB260", Offset = "0x11CA060", Length = "0x162")]
	public ExchangeBox()
	{
	}
}
