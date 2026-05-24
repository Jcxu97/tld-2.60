using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Trader;

[Token(Token = "0x20013B7")]
public class TraderManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20013B8")]
	private struct TrustUnlock<T>
	{
		[Token(Token = "0x4009074")]
		[FieldOffset(Offset = "0x0")]
		public int TrustThreshold;

		[Token(Token = "0x4009075")]
		[FieldOffset(Offset = "0x0")]
		public T Unlock;
	}

	[Token(Token = "0x400905E")]
	public static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x400905F")]
	[FieldOffset(Offset = "0x20")]
	private AssetLabelReference m_TradeExchangeLabel;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4009060")]
	[FieldOffset(Offset = "0x28")]
	private State m_TradeActiveState;

	[SerializeField]
	[Token(Token = "0x4009061")]
	[FieldOffset(Offset = "0x30")]
	private State m_TradeInactiveState;

	[Header("Tuning")]
	[SerializeField]
	[Token(Token = "0x4009062")]
	[FieldOffset(Offset = "0x38")]
	private int m_MaxExchangesInTrade;

	[SerializeField]
	[Token(Token = "0x4009063")]
	[FieldOffset(Offset = "0x3C")]
	private int m_MinTrustLevel;

	[SerializeField]
	[Token(Token = "0x4009064")]
	[FieldOffset(Offset = "0x40")]
	private int m_MaxTrustLevel;

	[Header("Trader Conversation")]
	[SerializeField]
	[Token(Token = "0x4009065")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceTraderConversation m_InitialTraderConversation;

	[SerializeField]
	[Token(Token = "0x4009066")]
	[FieldOffset(Offset = "0x50")]
	private AssetReferenceTraderConversation m_LastIntroductionConversation;

	[Header("Trust Unlocks")]
	[SerializeField]
	[Token(Token = "0x4009067")]
	[FieldOffset(Offset = "0x58")]
	private List<TrustUnlock<AssetReferenceTradeExchange>> m_TradeExchangeUnlocks;

	[SerializeField]
	[Token(Token = "0x4009068")]
	[FieldOffset(Offset = "0x60")]
	private List<TrustUnlock<AssetReferenceTraderConversation>> m_ConversationUnlocks;

	[SerializeField]
	[Token(Token = "0x4009069")]
	[FieldOffset(Offset = "0x68")]
	private List<TrustUnlock<TraderImprovement>> m_TraderImprovementUnlocks;

	[Token(Token = "0x400906A")]
	public static bool s_EnableInNewGame;

	[Token(Token = "0x400906B")]
	public static bool s_ToggleInExistingGame;

	[Token(Token = "0x400906C")]
	public static bool s_Debug;

	[Token(Token = "0x400906D")]
	private static AsyncOperationHandle<IList<TradeExchange>> s_AllTradeExchanges;

	[Token(Token = "0x400906E")]
	private static AsyncOperationHandle<IList<TraderConversation>> s_AllTraderConversations;

	[Token(Token = "0x400906F")]
	private static AsyncOperationHandle<TraderConversation> s_InitialTraderConversationHandle;

	[Token(Token = "0x4009070")]
	private static AsyncOperationHandle<TraderConversation> s_LastIntroductionConversationsHandle;

	[Token(Token = "0x4009071")]
	[FieldOffset(Offset = "0x70")]
	private TraderState m_CurrentState;

	[Token(Token = "0x4009073")]
	[FieldOffset(Offset = "0xB0")]
	private ExchangeBox m_ExchangeBoxInScene;

	[Token(Token = "0x17000AB8")]
	public bool IsSystemEnabled
	{
		[Token(Token = "0x6007DF1")]
		[Address(RVA = "0x11D2420", Offset = "0x11D1220", Length = "0x1B")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AB9")]
	public bool UseCheapPrices
	{
		[Token(Token = "0x6007DF2")]
		[Address(RVA = "0x11D2440", Offset = "0x11D1240", Length = "0x7E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000ABA")]
	public int MinTrust
	{
		[Token(Token = "0x6007DF3")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000ABB")]
	public int MaxTrust
	{
		[Token(Token = "0x6007DF4")]
		[Address(RVA = "0x507940", Offset = "0x506740", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000ABC")]
	public int CurrentTrust
	{
		[Token(Token = "0x6007DF5")]
		[Address(RVA = "0x11D24C0", Offset = "0x11D12C0", Length = "0x1A")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000ABD")]
	public int MaxExchangesInTrade
	{
		[Token(Token = "0x6007DF6")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000ABE")]
	public bool TradeIsActive
	{
		[Token(Token = "0x6007DF7")]
		[Address(RVA = "0x11D24E0", Offset = "0x11D12E0", Length = "0x1F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000ABF")]
	public bool SpecialRequestActive
	{
		[Token(Token = "0x6007DF8")]
		[Address(RVA = "0x11D2500", Offset = "0x11D1300", Length = "0x2F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AC0")]
	public string SpecialRequestHeaderText
	{
		[Token(Token = "0x6007DF9")]
		[Address(RVA = "0x11D2530", Offset = "0x11D1330", Length = "0x60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC1")]
	public string SpecialRequestDescriptionText
	{
		[Token(Token = "0x6007DFA")]
		[Address(RVA = "0x11D25A0", Offset = "0x11D13A0", Length = "0x60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC2")]
	[field: Token(Token = "0x4009072")]
	[field: FieldOffset(Offset = "0x78")]
	public TraderTunables Tunables
	{
		[Token(Token = "0x6007DFB")]
		[Address(RVA = "0x11D2610", Offset = "0x11D1410", Length = "0x2A")]
		get;
		[Token(Token = "0x6007DFC")]
		[Address(RVA = "0x11D2640", Offset = "0x11D1440", Length = "0x27")]
		private set;
	}

	[Token(Token = "0x6007DFD")]
	[Address(RVA = "0x11D2670", Offset = "0x11D1470", Length = "0x124")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007DFE")]
	[Address(RVA = "0x11D27A0", Offset = "0x11D15A0", Length = "0x238")]
	private TraderTunables GetTunables()
	{
		return default(TraderTunables);
	}

	[Token(Token = "0x6007DFF")]
	[Address(RVA = "0x11D29E0", Offset = "0x11D17E0", Length = "0x2D4")]
	public List<TradeExchangeData> GetAvailableTradeExchanges()
	{
		return null;
	}

	[Token(Token = "0x6007E00")]
	[Address(RVA = "0x11D2CC0", Offset = "0x11D1AC0", Length = "0x1B")]
	public List<TradeExchangeData> GetSpecialRequests()
	{
		return null;
	}

	[Token(Token = "0x6007E01")]
	[Address(RVA = "0x11D2CE0", Offset = "0x11D1AE0", Length = "0x811")]
	private void RollExchanges()
	{
	}

	[Token(Token = "0x6007E02")]
	[Address(RVA = "0x11D3500", Offset = "0x11D2300", Length = "0x85")]
	private void AddTradeExchange(TradeExchange tradeExchange)
	{
	}

	[Token(Token = "0x6007E03")]
	[Address(RVA = "0x11D3590", Offset = "0x11D2390", Length = "0x2E8")]
	private List<TradeExchange> GetPossibleExchanges()
	{
		return null;
	}

	[Token(Token = "0x6007E04")]
	[Address(RVA = "0x11D3880", Offset = "0x11D2680", Length = "0x82")]
	public bool IsTraderAvailable()
	{
		return false;
	}

	[Token(Token = "0x6007E05")]
	[Address(RVA = "0x11D3910", Offset = "0x11D2710", Length = "0x89")]
	public bool IsTraderOutForExchange()
	{
		return false;
	}

	[Token(Token = "0x6007E06")]
	[Address(RVA = "0x11D39A0", Offset = "0x11D27A0", Length = "0x1B")]
	public bool GetHasInterruptedPlayerPassingTime()
	{
		return false;
	}

	[Token(Token = "0x6007E07")]
	[Address(RVA = "0x11D39C0", Offset = "0x11D27C0", Length = "0x1A")]
	public void SetHasInterruptedPlayerPassingTime(bool hasInterrupted)
	{
	}

	[Token(Token = "0x6007E08")]
	[Address(RVA = "0x11D39E0", Offset = "0x11D27E0", Length = "0x307")]
	public bool ShouldHaveInitialTraderConversation(out TraderConversation initialConversation)
	{
		initialConversation = null;
		return false;
	}

	[Token(Token = "0x6007E09")]
	[Address(RVA = "0x11D3CF0", Offset = "0x11D2AF0", Length = "0x1DD")]
	public bool HaveHadAllIntroductionConversations()
	{
		return false;
	}

	[Token(Token = "0x6007E0A")]
	[Address(RVA = "0x11D3ED0", Offset = "0x11D2CD0", Length = "0x127")]
	public void ContactTrader()
	{
	}

	[Token(Token = "0x6007E0B")]
	[Address(RVA = "0x11D4000", Offset = "0x11D2E00", Length = "0x61C")]
	public void GetAvailableConversations(List<TraderConversation> traderConversations)
	{
	}

	[Token(Token = "0x6007E0C")]
	[Address(RVA = "0x11D4620", Offset = "0x11D3420", Length = "0x36F")]
	public void NotifyConversationHad(TraderConversation traderConversation)
	{
	}

	[Token(Token = "0x6007E0D")]
	[Address(RVA = "0x11D4990", Offset = "0x11D3790", Length = "0x1E")]
	public bool HaveHadConversation(TraderConversation traderConversation)
	{
		return false;
	}

	[Token(Token = "0x6007E0E")]
	[Address(RVA = "0x11D49B0", Offset = "0x11D37B0", Length = "0x56E")]
	public void InitiateTrade(List<TradeExchangeData> exchanges, string exchangeBoxScene)
	{
	}

	[Token(Token = "0x6007E0F")]
	[Address(RVA = "0x11D4F20", Offset = "0x11D3D20", Length = "0x2F")]
	public bool IsTradeFullyFilled()
	{
		return false;
	}

	[Token(Token = "0x6007E10")]
	[Address(RVA = "0x11D4F50", Offset = "0x11D3D50", Length = "0x2F")]
	public bool AnyTradesFilled()
	{
		return false;
	}

	[Token(Token = "0x6007E11")]
	[Address(RVA = "0x11D4F80", Offset = "0x11D3D80", Length = "0x309")]
	public void CloseTrade()
	{
	}

	[Token(Token = "0x6007E12")]
	[Address(RVA = "0x11D5290", Offset = "0x11D4090", Length = "0x7C1")]
	public void CompleteTrade()
	{
	}

	[Token(Token = "0x6007E13")]
	[Address(RVA = "0x11D5A60", Offset = "0x11D4860", Length = "0x15F")]
	public void RemoveActiveTrade()
	{
	}

	[Token(Token = "0x6007E14")]
	[Address(RVA = "0x11D5BC0", Offset = "0x11D49C0", Length = "0x1B6")]
	public void CancelTrade(bool disregardPenalties = false)
	{
	}

	[Token(Token = "0x6007E15")]
	[Address(RVA = "0x11D5D80", Offset = "0x11D4B80", Length = "0x496")]
	private void MaybeReturnSpecialRequestItems(bool cancelled)
	{
	}

	[Token(Token = "0x6007E16")]
	[Address(RVA = "0x11D6220", Offset = "0x11D5020", Length = "0x1B")]
	public ActiveTradeState GetActiveTrade()
	{
		return null;
	}

	[Token(Token = "0x6007E17")]
	[Address(RVA = "0x11D6240", Offset = "0x11D5040", Length = "0xA4")]
	public float GetHoursSinceLastTradeComplete()
	{
		return 0f;
	}

	[Token(Token = "0x6007E18")]
	[Address(RVA = "0x11D62F0", Offset = "0x11D50F0", Length = "0x1E")]
	public bool IsExchangeInActiveTrade(TradeExchange tradeExchange)
	{
		return false;
	}

	[Token(Token = "0x6007E19")]
	[Address(RVA = "0x11D6310", Offset = "0x11D5110", Length = "0x600")]
	public void AddTrust(int trustChange)
	{
	}

	[Token(Token = "0x6007E1A")]
	[Address(RVA = "0x11D6920", Offset = "0x11D5720", Length = "0x294")]
	public void UnlockExchange(AssetReferenceTradeExchange tradeExchangeReference)
	{
	}

	[Token(Token = "0x6007E1B")]
	[Address(RVA = "0x11D6BC0", Offset = "0x11D59C0", Length = "0x3CB")]
	public void UnlockImprovement(TraderImprovement improvement)
	{
	}

	[Token(Token = "0x6007E1C")]
	[Address(RVA = "0x11D6F90", Offset = "0x11D5D90", Length = "0x390")]
	private void UnlockConversation(AssetReferenceTraderConversation traderConversationReference, int trustThreshold)
	{
	}

	[Token(Token = "0x6007E1D")]
	[Address(RVA = "0x1A05630", Offset = "0x1A04430", Length = "0x1E7")]
	private string GetUnlockNameFromReference<T>(AssetReferenceT<T> reference) where T : ScriptableObject
	{
		return null;
	}

	[Token(Token = "0x6007E1E")]
	[Address(RVA = "0x11D7330", Offset = "0x11D6130", Length = "0x273")]
	private ExchangeBox GetActiveExchangeBox()
	{
		return null;
	}

	[Token(Token = "0x6007E1F")]
	[Address(RVA = "0x11D75B0", Offset = "0x11D63B0", Length = "0xD3")]
	public void SetSpecialRequest(string specialRequestHeaderLocID, string specialRequestDescriptionLocID)
	{
	}

	[Token(Token = "0x6007E20")]
	[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
	public TraderState Serialize()
	{
		return null;
	}

	[Token(Token = "0x6007E21")]
	[Address(RVA = "0x11D7690", Offset = "0x11D6490", Length = "0x1E7")]
	public void Deserialize(TraderState state)
	{
	}

	[Token(Token = "0x6007E22")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TraderManager()
	{
	}
}
