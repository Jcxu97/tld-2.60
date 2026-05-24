using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[CreateAssetMenu(menuName = "The Long Dark/Trader/Trade Exchange")]
[Token(Token = "0x20013AD")]
public class TradeExchange : ScriptableObject
{
	[Flags]
	[Token(Token = "0x20013AE")]
	public enum TradeExchangeFlags
	{
		[Token(Token = "0x4009031")]
		None = 0,
		[Token(Token = "0x4009032")]
		UnlockedByDefault = 1,
		[Token(Token = "0x4009033")]
		IsRareExchange = 2,
		[Token(Token = "0x4009034")]
		IsAlwaysShown = 4,
		[Token(Token = "0x4009035")]
		IsSpecialRequest = 8
	}

	[SerializeField]
	[Token(Token = "0x400902D")]
	[FieldOffset(Offset = "0x18")]
	private TradeExchangeFlags m_Flags;

	[SerializeField]
	[Token(Token = "0x400902E")]
	[FieldOffset(Offset = "0x20")]
	private List<TradeExchangeData> m_PossibleExchanges;

	[NonSerialized]
	[Token(Token = "0x400902F")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<TradeExchangeData> m_FilteredExchanges;

	[Token(Token = "0x17000AB0")]
	public TradeExchangeFlags Flags
	{
		[Token(Token = "0x6007DBC")]
		[Address(RVA = "0x40E0D0", Offset = "0x40CED0", Length = "0x4")]
		get
		{
			return default(TradeExchangeFlags);
		}
	}

	[Token(Token = "0x6007DBD")]
	[Address(RVA = "0x11CE670", Offset = "0x11CD470", Length = "0x2A7")]
	public bool FilterExchangeData()
	{
		return false;
	}

	[Token(Token = "0x6007DBE")]
	[Address(RVA = "0x11CE920", Offset = "0x11CD720", Length = "0x3B1")]
	public TradeExchangeData GetRandomTradeExchangeData(TraderState currentTraderState)
	{
		return null;
	}

	[Token(Token = "0x6007DBF")]
	[Address(RVA = "0x11CECE0", Offset = "0x11CDAE0", Length = "0xB6")]
	public TradeExchange()
	{
	}
}
