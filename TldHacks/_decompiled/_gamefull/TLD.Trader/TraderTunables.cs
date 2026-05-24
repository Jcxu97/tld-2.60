using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Serializable]
[Token(Token = "0x20013C3")]
public struct TraderTunables
{
	[Header("Availability")]
	[Min(0f)]
	[Token(Token = "0x40090D8")]
	[FieldOffset(Offset = "0x0")]
	public float m_DaysBeforeAvailable;

	[Min(0f)]
	[Token(Token = "0x40090D9")]
	[FieldOffset(Offset = "0x4")]
	public float m_HoursUnavailableAfterCompletedTrade;

	[Header("Exchange Rolling")]
	[Min(0f)]
	[Token(Token = "0x40090DA")]
	[FieldOffset(Offset = "0x8")]
	public int m_CommonExchangesDrawn;

	[Min(0f)]
	[Token(Token = "0x40090DB")]
	[FieldOffset(Offset = "0xC")]
	public int m_RareExchangesDrawn;

	[Min(0f)]
	[Token(Token = "0x40090DC")]
	[FieldOffset(Offset = "0x10")]
	public int m_ExtraRareExchangesDrawn;

	[Header("Trade Tuning")]
	[Range(0f, 1f)]
	[Token(Token = "0x40090DD")]
	[FieldOffset(Offset = "0x14")]
	public float m_MinExchangeItemCondition;

	[Min(0f)]
	[Token(Token = "0x40090DE")]
	[FieldOffset(Offset = "0x18")]
	public int m_TradeTrustGained;

	[Min(0f)]
	[Token(Token = "0x40090DF")]
	[FieldOffset(Offset = "0x1C")]
	public int m_PartialTradeTrustGained;

	[Header("Cancel Trade Penalty")]
	[Min(0f)]
	[Token(Token = "0x40090E0")]
	[FieldOffset(Offset = "0x20")]
	public int m_NoPenaltyTradeCancels;

	[Min(0f)]
	[Token(Token = "0x40090E1")]
	[FieldOffset(Offset = "0x24")]
	public int m_CancelTradeTrustLost;

	[Header("Repeated Contact Penalty")]
	[Min(0f)]
	[Token(Token = "0x40090E2")]
	[FieldOffset(Offset = "0x28")]
	public int m_RepeatedContactPenaltyStart;

	[Min(0f)]
	[Token(Token = "0x40090E3")]
	[FieldOffset(Offset = "0x2C")]
	public int m_RepeatedContactPenaltyTrustLost;

	[Header("Exchange Reward Condition")]
	[Token(Token = "0x40090E4")]
	[FieldOffset(Offset = "0x30")]
	public GearStartCondition m_RewardStartCondition;
}
