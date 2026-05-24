using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Trader;

[Serializable]
[Token(Token = "0x20013B1")]
public class TradeExchangeData : IEquatable<TradeExchangeData>
{
	[Token(Token = "0x4009036")]
	private const string SPECIAL_REQUEST = "GAMEPLAY_SpecialRequest";

	[Token(Token = "0x4009037")]
	[FieldOffset(Offset = "0x10")]
	public LocalizedString m_Description;

	[Min(1f)]
	[Token(Token = "0x4009038")]
	[FieldOffset(Offset = "0x18")]
	public int m_MaxExchangeInSingleTrade;

	[Header("Gains")]
	[Token(Token = "0x4009039")]
	[FieldOffset(Offset = "0x20")]
	public AssetReferenceGearItemData m_GainedItem;

	[Min(1f)]
	[Token(Token = "0x400903A")]
	[FieldOffset(Offset = "0x28")]
	public int m_GainedItemAmount;

	[Token(Token = "0x400903B")]
	[FieldOffset(Offset = "0x30")]
	public List<AssetReferenceTradeExchange> m_UnlockedExchanges;

	[Token(Token = "0x400903C")]
	[FieldOffset(Offset = "0x38")]
	public List<AssetReferenceTraderConversation> m_UnlockedConversations;

	[Header("Cost")]
	[Token(Token = "0x400903D")]
	[FieldOffset(Offset = "0x40")]
	public List<ExchangeItem> m_ExchangeItems;

	[Token(Token = "0x400903E")]
	[FieldOffset(Offset = "0x48")]
	public List<ExchangeItem> m_CheapExchangeItems;

	[HideInInspector]
	[Token(Token = "0x400903F")]
	[FieldOffset(Offset = "0x50")]
	public string m_TradeExchangeName;

	[HideInInspector]
	[Token(Token = "0x4009040")]
	[FieldOffset(Offset = "0x58")]
	public bool m_IsSpecialRequest;

	[Token(Token = "0x4009041")]
	[FieldOffset(Offset = "0x60")]
	private AsyncOperationHandle<GearItemData> m_GainedItemGearItemDataHandle;

	[Token(Token = "0x4009042")]
	[FieldOffset(Offset = "0x78")]
	private string m_CachedTradeExchangeHeader;

	[Token(Token = "0x4009043")]
	[FieldOffset(Offset = "0x80")]
	private int m_CachedBaseItemCount;

	[Token(Token = "0x6007DC4")]
	[Address(RVA = "0x11CEEF0", Offset = "0x11CDCF0", Length = "0x136")]
	~TradeExchangeData()
	{
	}

	[Token(Token = "0x6007DC5")]
	[Address(RVA = "0x11CF030", Offset = "0x11CDE30", Length = "0x43")]
	public bool IsValidInCurrentGamemode()
	{
		return false;
	}

	[Token(Token = "0x6007DC6")]
	[Address(RVA = "0x11CF080", Offset = "0x11CDE80", Length = "0x568")]
	private bool IsGainedItemValidInCurrentGamemode()
	{
		return false;
	}

	[Token(Token = "0x6007DC7")]
	[Address(RVA = "0x11CF5F0", Offset = "0x11CE3F0", Length = "0x163")]
	private bool AreExchangeItemsValidInCurrentGamemode(List<ExchangeItem> exchangeItems)
	{
		return false;
	}

	[Token(Token = "0x6007DC8")]
	[Address(RVA = "0x11CF760", Offset = "0x11CE560", Length = "0x157")]
	public GearItemData GetGainedItemData()
	{
		return null;
	}

	[Token(Token = "0x6007DC9")]
	[Address(RVA = "0x11CF8C0", Offset = "0x11CE6C0", Length = "0x72")]
	public Texture2D GetGainedItemIcon()
	{
		return null;
	}

	[Token(Token = "0x6007DCA")]
	[Address(RVA = "0x11CF940", Offset = "0x11CE740", Length = "0x28E")]
	public string GetTradeExchangeHeader(int multiplier = 1)
	{
		return null;
	}

	[Token(Token = "0x6007DCB")]
	[Address(RVA = "0x11CFBD0", Offset = "0x11CE9D0", Length = "0x297")]
	private int CalculateBaseItemCount()
	{
		return 0;
	}

	[Token(Token = "0x6007DCC")]
	[Address(RVA = "0x11CFE70", Offset = "0x11CEC70", Length = "0x149")]
	private string BuildTradeExchangeHeader()
	{
		return null;
	}

	[Token(Token = "0x6007DCD")]
	[Address(RVA = "0x11CFFC0", Offset = "0x11CEDC0", Length = "0xE")]
	public List<ExchangeItem> GetActiveExchangeItems()
	{
		return null;
	}

	[Token(Token = "0x6007DCE")]
	[Address(RVA = "0x11CFFD0", Offset = "0x11CEDD0", Length = "0x173")]
	public bool IsFullyExchanged()
	{
		return false;
	}

	[Token(Token = "0x6007DCF")]
	[Address(RVA = "0x11D0150", Offset = "0x11CEF50", Length = "0x236")]
	public bool IsAnyExchanged()
	{
		return false;
	}

	[Token(Token = "0x6007DD0")]
	[Address(RVA = "0x11D0390", Offset = "0x11CF190", Length = "0x1CF")]
	public void UpdateExchanged(List<GearItemObject> exchangedItems)
	{
	}

	[Token(Token = "0x6007DD1")]
	[Address(RVA = "0x11D0560", Offset = "0x11CF360", Length = "0x2F8")]
	public float CalculateExchangedRatio()
	{
		return 0f;
	}

	[Token(Token = "0x6007DD2")]
	[Address(RVA = "0x11D0860", Offset = "0x11CF660", Length = "0x199")]
	public ExchangeItem FindExchangeItemMatch(GearItem gearItem)
	{
		return null;
	}

	[Token(Token = "0x6007DD3")]
	[Address(RVA = "0x11D0A00", Offset = "0x11CF800", Length = "0x3AC")]
	public TradeExchangeData CloneForActiveTrade(int numExchangesMultiplier, bool useCheapItems)
	{
		return null;
	}

	[Token(Token = "0x6007DD4")]
	[Address(RVA = "0x11D0DB0", Offset = "0x11CFBB0", Length = "0x25C")]
	private List<ExchangeItem> CloneExchangeItemsForActiveTrade(List<ExchangeItem> sourceItems, int numExchangesMultiplier)
	{
		return null;
	}

	[Token(Token = "0x6007DD5")]
	[Address(RVA = "0x11D1010", Offset = "0x11CFE10", Length = "0x84")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Token(Token = "0x6007DD6")]
	[Address(RVA = "0x11D10A0", Offset = "0x11CFEA0", Length = "0x1C4")]
	public bool Equals(TradeExchangeData other)
	{
		return false;
	}

	[Token(Token = "0x6007DD7")]
	[Address(RVA = "0x11D1270", Offset = "0x11D0070", Length = "0x98")]
	public override int GetHashCode()
	{
		return 0;
	}

	[Token(Token = "0x6007DD8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TradeExchangeData()
	{
	}
}
