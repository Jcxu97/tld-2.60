using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[CreateAssetMenu(menuName = "The Long Dark/Trader/Trader Conversation")]
[Token(Token = "0x20013B3")]
public class TraderConversation : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4009045")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsSpecialRequest;

	[Header("Dialogue")]
	[SerializeField]
	[Token(Token = "0x4009046")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DialogueChoiceText;

	[SerializeField]
	[Token(Token = "0x4009047")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_AudioEvent;

	[Header("Gains")]
	[SerializeField]
	[Token(Token = "0x4009048")]
	[FieldOffset(Offset = "0x30")]
	private int m_TrustGained;

	[SerializeField]
	[Token(Token = "0x4009049")]
	[FieldOffset(Offset = "0x38")]
	private List<AssetReferenceTradeExchange> m_UnlockedExchanges;

	[SerializeField]
	[Token(Token = "0x400904A")]
	[FieldOffset(Offset = "0x40")]
	private List<AssetReferenceTraderConversation> m_UnlockedConversations;

	[Token(Token = "0x17000AB1")]
	public bool IsSpecialRequest
	{
		[Token(Token = "0x6007DDB")]
		[Address(RVA = "0xC880B0", Offset = "0xC86EB0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AB2")]
	public LocalizedString DialogueChoiceText
	{
		[Token(Token = "0x6007DDC")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB3")]
	public AK.Wwise.Event AudioEvent
	{
		[Token(Token = "0x6007DDD")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB4")]
	public int TrustGained
	{
		[Token(Token = "0x6007DDE")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000AB5")]
	public List<AssetReferenceTradeExchange> UnlockedExchanges
	{
		[Token(Token = "0x6007DDF")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB6")]
	public List<AssetReferenceTraderConversation> UnlockedConversations
	{
		[Token(Token = "0x6007DE0")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007DE1")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public TraderConversation()
	{
	}
}
