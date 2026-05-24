using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;

namespace TLD.Trader;

[Token(Token = "0x20013BD")]
public class TraderState
{
	[Token(Token = "0x20013BE")]
	public class UnlockedConversation
	{
		[Token(Token = "0x40090CB")]
		[FieldOffset(Offset = "0x10")]
		public string m_ConversationName;

		[Token(Token = "0x40090CC")]
		[FieldOffset(Offset = "0x18")]
		public int m_TrustThreshold;

		[Token(Token = "0x6007E4E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public UnlockedConversation()
		{
		}
	}

	[Token(Token = "0x40090BA")]
	[FieldOffset(Offset = "0x10")]
	public bool m_SystemEnabled;

	[Token(Token = "0x40090BB")]
	[FieldOffset(Offset = "0x14")]
	public int m_CurrentTrust;

	[Token(Token = "0x40090BC")]
	[FieldOffset(Offset = "0x18")]
	public int m_HighestTrust;

	[Token(Token = "0x40090BD")]
	[FieldOffset(Offset = "0x1C")]
	public int m_NumCancelledTrades;

	[Token(Token = "0x40090BE")]
	[FieldOffset(Offset = "0x20")]
	public int m_ContactsThisAurora;

	[Token(Token = "0x40090BF")]
	[FieldOffset(Offset = "0x24")]
	public float m_TimeLastTradeComplete;

	[Token(Token = "0x40090C0")]
	[FieldOffset(Offset = "0x28")]
	public bool m_HasInterruptedPlayerPassingTime;

	[Token(Token = "0x40090C1")]
	[FieldOffset(Offset = "0x30")]
	public readonly List<string> m_UnlockedExchangeNames;

	[Token(Token = "0x40090C2")]
	[FieldOffset(Offset = "0x38")]
	public readonly List<UnlockedConversation> m_UnlockedConversations;

	[Token(Token = "0x40090C3")]
	[FieldOffset(Offset = "0x40")]
	public readonly List<string> m_ConversationsHad;

	[Token(Token = "0x40090C4")]
	[FieldOffset(Offset = "0x48")]
	public readonly List<TraderImprovement> m_UnlockedTraderImprovements;

	[Token(Token = "0x40090C5")]
	[FieldOffset(Offset = "0x50")]
	public int m_LastAuroraNum;

	[Token(Token = "0x40090C6")]
	[FieldOffset(Offset = "0x58")]
	public readonly List<TradeExchangeData> m_AvailableExchangesThisAurora;

	[Token(Token = "0x40090C7")]
	[FieldOffset(Offset = "0x60")]
	public readonly List<TradeExchangeData> m_SpecialRequests;

	[Token(Token = "0x40090C8")]
	[FieldOffset(Offset = "0x68")]
	public ActiveTradeState m_ActiveTrade;

	[Token(Token = "0x40090C9")]
	[FieldOffset(Offset = "0x70")]
	public string m_SpecialRequestHeaderLocID;

	[Token(Token = "0x40090CA")]
	[FieldOffset(Offset = "0x78")]
	public string m_SpecialRequestDescriptionLocID;

	[Token(Token = "0x6007E47")]
	[Address(RVA = "0x11DBF80", Offset = "0x11DAD80", Length = "0x21F")]
	public bool IsTradeExchangeUnlocked(TradeExchange tradeExchange)
	{
		return false;
	}

	[Token(Token = "0x6007E48")]
	[Address(RVA = "0x11DC1A0", Offset = "0x11DAFA0", Length = "0x301")]
	public bool IsConversationAvailable(TraderConversation traderConversation)
	{
		return false;
	}

	[Token(Token = "0x6007E49")]
	[Address(RVA = "0x11DC4B0", Offset = "0x11DB2B0", Length = "0x2B1")]
	public bool HaveHadConversation(TraderConversation traderConversation)
	{
		return false;
	}

	[Token(Token = "0x6007E4A")]
	[Address(RVA = "0x11DC770", Offset = "0x11DB570", Length = "0x2E9")]
	public bool IsExchangeInActiveTrade(TradeExchange tradeExchange)
	{
		return false;
	}

	[Token(Token = "0x6007E4B")]
	[Address(RVA = "0x11DCA60", Offset = "0x11DB860", Length = "0x2C3")]
	public bool HasDrawnFromExchange(TradeExchange tradeExchange)
	{
		return false;
	}

	[Token(Token = "0x6007E4C")]
	[Address(RVA = "0x11DCD30", Offset = "0x11DBB30", Length = "0x289")]
	public bool HasExchangeRewardingItem(AssetReferenceGearItemData gearItemData)
	{
		return false;
	}

	[Token(Token = "0x6007E4D")]
	[Address(RVA = "0x11DCFC0", Offset = "0x11DBDC0", Length = "0x369")]
	public TraderState()
	{
	}
}
