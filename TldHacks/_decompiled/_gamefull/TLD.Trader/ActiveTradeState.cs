using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Trader;

[Token(Token = "0x20013BF")]
public class ActiveTradeState
{
	[Token(Token = "0x20013C0")]
	public enum State
	{
		[Token(Token = "0x40090D1")]
		Open,
		[Token(Token = "0x40090D2")]
		Closed,
		[Token(Token = "0x40090D3")]
		Completed
	}

	[Token(Token = "0x20013C1")]
	public class ActiveExchangeState
	{
		[Token(Token = "0x40090D4")]
		[FieldOffset(Offset = "0x10")]
		public TradeExchangeData m_Exchange;

		[Token(Token = "0x40090D5")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerExchangedItem> m_ExchangedItems;

		[Token(Token = "0x6007E54")]
		[Address(RVA = "0x11DDA20", Offset = "0x11DC820", Length = "0xAD")]
		public ActiveExchangeState()
		{
		}
	}

	[Token(Token = "0x20013C2")]
	public class PlayerExchangedItem
	{
		[Token(Token = "0x40090D6")]
		[FieldOffset(Offset = "0x10")]
		public AssetReference m_PrefabReference;

		[Token(Token = "0x40090D7")]
		[FieldOffset(Offset = "0x18")]
		public GearItemSaveDataProxy m_SerializedGear;

		[Token(Token = "0x6007E55")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PlayerExchangedItem()
		{
		}
	}

	[Token(Token = "0x40090CD")]
	[FieldOffset(Offset = "0x10")]
	public string m_ExchangeBoxScene;

	[Token(Token = "0x40090CE")]
	[FieldOffset(Offset = "0x18")]
	public State m_TradeState;

	[Token(Token = "0x40090CF")]
	[FieldOffset(Offset = "0x20")]
	public List<ActiveExchangeState> m_ExchangeStates;

	[Token(Token = "0x6007E4F")]
	[Address(RVA = "0x11DD330", Offset = "0x11DC130", Length = "0x166")]
	public bool IsFullyFilled()
	{
		return false;
	}

	[Token(Token = "0x6007E50")]
	[Address(RVA = "0x11DD4A0", Offset = "0x11DC2A0", Length = "0x166")]
	public bool HasAnyFilled()
	{
		return false;
	}

	[Token(Token = "0x6007E51")]
	[Address(RVA = "0x11DD610", Offset = "0x11DC410", Length = "0x1B8")]
	public float CalculateExchangedRatio()
	{
		return 0f;
	}

	[Token(Token = "0x6007E52")]
	[Address(RVA = "0x11DD7D0", Offset = "0x11DC5D0", Length = "0x194")]
	public bool HasRewards()
	{
		return false;
	}

	[Token(Token = "0x6007E53")]
	[Address(RVA = "0x11DD970", Offset = "0x11DC770", Length = "0xAD")]
	public ActiveTradeState()
	{
	}
}
