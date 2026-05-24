using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.Scenes;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013BA")]
public class TraderRadio : TimedHoldInteraction
{
	[Token(Token = "0x20013BB")]
	private enum RadioState
	{
		[Token(Token = "0x40090AF")]
		Off,
		[Token(Token = "0x40090B0")]
		PlayingTimeline,
		[Token(Token = "0x40090B1")]
		Trading,
		[Token(Token = "0x40090B2")]
		ShowingMain,
		[Token(Token = "0x40090B3")]
		ShowingConversations,
		[Token(Token = "0x40090B4")]
		ShowingCancel,
		[Token(Token = "0x40090B5")]
		PlayingVoiceLine,
		[Token(Token = "0x40090B6")]
		HangingUp
	}

	[SerializeField]
	[Token(Token = "0x4009078")]
	[FieldOffset(Offset = "0x68")]
	private NPCVoice m_TraderVoice;

	[Header("Trade")]
	[SerializeField]
	[Token(Token = "0x4009079")]
	[FieldOffset(Offset = "0x70")]
	private List<SceneSet> m_ExchangeBoxScenes;

	[Header("Timelines")]
	[SerializeField]
	[Token(Token = "0x400907A")]
	[FieldOffset(Offset = "0x78")]
	private TimelinePlayback.TimelineInfo m_PickupRadioTimeline;

	[SerializeField]
	[Token(Token = "0x400907B")]
	[FieldOffset(Offset = "0x80")]
	private TimelinePlayback.TimelineInfo m_PutdownRadioTimeline;

	[Header("Dialogue Settings")]
	[SerializeField]
	[Token(Token = "0x400907C")]
	[FieldOffset(Offset = "0x88")]
	private float m_InteractionConeAngle;

	[SerializeField]
	[Token(Token = "0x400907D")]
	[FieldOffset(Offset = "0x8C")]
	private float m_FOV;

	[SerializeField]
	[Token(Token = "0x400907E")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 m_PitchLimitDegrees;

	[SerializeField]
	[Token(Token = "0x400907F")]
	[FieldOffset(Offset = "0x98")]
	private Vector2 m_YawLimitDegrees;

	[Header("Dialogue Choices")]
	[SerializeField]
	[Token(Token = "0x4009080")]
	[FieldOffset(Offset = "0xA0")]
	private TraderDialogueChoice m_TradeChoice;

	[SerializeField]
	[Token(Token = "0x4009081")]
	[FieldOffset(Offset = "0xA8")]
	private TraderDialogueChoice m_BackChoice;

	[SerializeField]
	[Token(Token = "0x4009082")]
	[FieldOffset(Offset = "0xB0")]
	private TraderDialogueChoice m_TopConversationChoice;

	[SerializeField]
	[Token(Token = "0x4009083")]
	[FieldOffset(Offset = "0xB8")]
	private TraderDialogueChoice m_MiddleConversationChoice;

	[SerializeField]
	[Token(Token = "0x4009084")]
	[FieldOffset(Offset = "0xC0")]
	private TraderDialogueChoice m_BottomConversationChoice;

	[Header("Dialogue Localization")]
	[SerializeField]
	[Token(Token = "0x4009085")]
	[FieldOffset(Offset = "0xC8")]
	private LocalizedString m_BackText;

	[SerializeField]
	[Token(Token = "0x4009086")]
	[FieldOffset(Offset = "0xD0")]
	private LocalizedString m_HangupText;

	[SerializeField]
	[Token(Token = "0x4009087")]
	[FieldOffset(Offset = "0xD8")]
	private LocalizedString m_TradeText;

	[SerializeField]
	[Token(Token = "0x4009088")]
	[FieldOffset(Offset = "0xE0")]
	private LocalizedString m_CancelTradeText;

	[SerializeField]
	[Token(Token = "0x4009089")]
	[FieldOffset(Offset = "0xE8")]
	private LocalizedString m_CompleteTradeText;

	[SerializeField]
	[Token(Token = "0x400908A")]
	[FieldOffset(Offset = "0xF0")]
	private LocalizedString m_ConversationsText;

	[SerializeField]
	[Token(Token = "0x400908B")]
	[FieldOffset(Offset = "0xF8")]
	private LocalizedString m_ConfirmCancelText;

	[SerializeField]
	[Token(Token = "0x400908C")]
	[FieldOffset(Offset = "0x100")]
	private LocalizedString m_TraderUnavailableText;

	[SerializeField]
	[Token(Token = "0x400908D")]
	[FieldOffset(Offset = "0x108")]
	private LocalizedString m_TraderOutForTradeText;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x400908E")]
	[FieldOffset(Offset = "0x110")]
	private State m_TraderAvailableOn;

	[SerializeField]
	[Token(Token = "0x400908F")]
	[FieldOffset(Offset = "0x118")]
	private State m_TraderAvailableOff;

	[SerializeField]
	[Token(Token = "0x4009090")]
	[FieldOffset(Offset = "0x120")]
	private State m_HaveContactedTraderOn;

	[SerializeField]
	[Token(Token = "0x4009091")]
	[FieldOffset(Offset = "0x128")]
	private State m_HaveContactedTraderOff;

	[SerializeField]
	[Token(Token = "0x4009092")]
	[FieldOffset(Offset = "0x130")]
	private RTPC m_TrustLevelRTPC;

	[SerializeField]
	[Token(Token = "0x4009093")]
	[FieldOffset(Offset = "0x138")]
	private AK.Wwise.Event m_GreetingEvent;

	[SerializeField]
	[Token(Token = "0x4009094")]
	[FieldOffset(Offset = "0x140")]
	private AK.Wwise.Event m_GoodbyeEvent;

	[SerializeField]
	[Token(Token = "0x4009095")]
	[FieldOffset(Offset = "0x148")]
	private AK.Wwise.Event m_CancelTradeEvent;

	[SerializeField]
	[Token(Token = "0x4009096")]
	[FieldOffset(Offset = "0x150")]
	private AK.Wwise.Event m_CompleteTradeEvent;

	[SerializeField]
	[Token(Token = "0x4009097")]
	[FieldOffset(Offset = "0x158")]
	private AK.Wwise.Event m_InitiateTradeEvent;

	[SerializeField]
	[Token(Token = "0x4009098")]
	[FieldOffset(Offset = "0x160")]
	private AK.Wwise.Event m_ConversationIntroEvent;

	[SerializeField]
	[Token(Token = "0x4009099")]
	[FieldOffset(Offset = "0x168")]
	private AK.Wwise.Event m_WakeupPlayerEvent;

	[Header("Radio Unavailable Audio")]
	[SerializeField]
	[Token(Token = "0x400909A")]
	[FieldOffset(Offset = "0x170")]
	private AK.Wwise.Event m_RadioUnavailableEvent;

	[SerializeField]
	[Token(Token = "0x400909B")]
	[FieldOffset(Offset = "0x178")]
	private float m_RadioUnavailableMinInterval;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400909C")]
	[FieldOffset(Offset = "0x180")]
	private PanelReference<Panel_TradeSelection> m_TradeSelectionReference;

	[SerializeField]
	[Token(Token = "0x400909D")]
	[FieldOffset(Offset = "0x188")]
	private PanelReference<Panel_Confirmation> m_ConfirmationReference;

	[Token(Token = "0x400909E")]
	private static readonly Vector2 s_ViewportCenter;

	[Token(Token = "0x400909F")]
	[FieldOffset(Offset = "0x190")]
	private readonly List<TraderDialogueChoice> m_ActiveDialogueChoices;

	[Token(Token = "0x40090A0")]
	[FieldOffset(Offset = "0x198")]
	private readonly List<TraderConversation> m_AvailableConversations;

	[Token(Token = "0x40090A1")]
	[FieldOffset(Offset = "0x1A0")]
	private float m_StartFOV;

	[Token(Token = "0x40090A2")]
	[FieldOffset(Offset = "0x1A4")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x40090A3")]
	[FieldOffset(Offset = "0x1AC")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x40090A4")]
	[FieldOffset(Offset = "0x1B4")]
	private RadioState m_CurrentState;

	[Token(Token = "0x40090A5")]
	[FieldOffset(Offset = "0x1B8")]
	private RadioState? m_PendingState;

	[Token(Token = "0x40090A6")]
	[FieldOffset(Offset = "0x1C0")]
	private TimelinePlayback m_TimelinePlayback;

	[Token(Token = "0x40090A7")]
	[FieldOffset(Offset = "0x1C8")]
	private uint m_ActiveTraderVoiceLine;

	[Token(Token = "0x40090A8")]
	[FieldOffset(Offset = "0x1CC")]
	private bool m_HasActiveTraderVoiceLineBeenHeard;

	[Token(Token = "0x40090A9")]
	[FieldOffset(Offset = "0x1D0")]
	private float m_RadioOffEventTimer;

	[Token(Token = "0x40090AA")]
	[FieldOffset(Offset = "0x1D8")]
	private TraderConversation m_PendingInitialConversation;

	[Token(Token = "0x40090AB")]
	[FieldOffset(Offset = "0x1E0")]
	private bool m_HasInitialized;

	[Token(Token = "0x40090AC")]
	[FieldOffset(Offset = "0x1E1")]
	private bool m_TraderIsSetAvailable;

	[Token(Token = "0x40090AD")]
	public static bool s_IsOnRadio;

	[Token(Token = "0x17000AC3")]
	public override bool CanInteract
	{
		[Token(Token = "0x6007E27")]
		[Address(RVA = "0x11D7AC0", Offset = "0x11D68C0", Length = "0x58")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007E28")]
	[Address(RVA = "0x11D7B20", Offset = "0x11D6920", Length = "0x14")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007E29")]
	[Address(RVA = "0x11D7B40", Offset = "0x11D6940", Length = "0x166")]
	private void InitializeTraderRadio()
	{
	}

	[Token(Token = "0x6007E2A")]
	[Address(RVA = "0x11D7CB0", Offset = "0x11D6AB0", Length = "0xEF")]
	protected override void BeginHold()
	{
	}

	[Token(Token = "0x6007E2B")]
	[Address(RVA = "0x11D7DA0", Offset = "0x11D6BA0", Length = "0x13A")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6007E2C")]
	[Address(RVA = "0x11D7EE0", Offset = "0x11D6CE0", Length = "0x250")]
	private float CalculatePlayerAngle()
	{
		return 0f;
	}

	[Token(Token = "0x6007E2D")]
	[Address(RVA = "0x11D8140", Offset = "0x11D6F40", Length = "0x225")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6007E2E")]
	[Address(RVA = "0x11D8370", Offset = "0x11D7170", Length = "0x5F0")]
	private void EnterTraderDialogue()
	{
	}

	[Token(Token = "0x6007E2F")]
	[Address(RVA = "0x11D8970", Offset = "0x11D7770", Length = "0x19F")]
	private void MaybeHandleItemInHands()
	{
	}

	[Token(Token = "0x6007E30")]
	[Address(RVA = "0x11D8B10", Offset = "0x11D7910", Length = "0xE4")]
	private void ExitTraderDialogue()
	{
	}

	[Token(Token = "0x6007E31")]
	[Address(RVA = "0x11D8C00", Offset = "0x11D7A00", Length = "0x1A5")]
	private void OnDonePlayingExitTimeline()
	{
	}

	[Token(Token = "0x6007E32")]
	[Address(RVA = "0x11D8DB0", Offset = "0x11D7BB0", Length = "0xE4")]
	public string DrawRandomExchangeBoxScene()
	{
		return null;
	}

	[Token(Token = "0x6007E33")]
	[Address(RVA = "0x11D8EA0", Offset = "0x11D7CA0", Length = "0x78C")]
	private void EnterRadioState(RadioState radioState)
	{
	}

	[Token(Token = "0x6007E34")]
	[Address(RVA = "0x11D9650", Offset = "0x11D8450", Length = "0x76")]
	private void OnConfirmTradeCancelled()
	{
	}

	[Token(Token = "0x6007E35")]
	[Address(RVA = "0x11D96D0", Offset = "0x11D84D0", Length = "0x11")]
	private void OnCancelTradeCancelled(bool hasCancelled)
	{
	}

	[Token(Token = "0x6007E36")]
	[Address(RVA = "0x11D96F0", Offset = "0x11D84F0", Length = "0x114")]
	private void ShowMain()
	{
	}

	[Token(Token = "0x6007E37")]
	[Address(RVA = "0x11D9810", Offset = "0x11D8610", Length = "0x238")]
	private void ShowConversations()
	{
	}

	[Token(Token = "0x6007E38")]
	[Address(RVA = "0x11D9A50", Offset = "0x11D8850", Length = "0x1C7")]
	private void AddDialogueChoice(TraderDialogueChoice dialogueChoice, LocalizedString localizedString, bool isSpecialRequest = false)
	{
	}

	[Token(Token = "0x6007E39")]
	[Address(RVA = "0x11D9C20", Offset = "0x11D8A20", Length = "0x577")]
	private void Update()
	{
	}

	[Token(Token = "0x6007E3A")]
	[Address(RVA = "0x11DA1A0", Offset = "0x11D8FA0", Length = "0x9CB")]
	private void UpdateHoveredDialogueChoice()
	{
	}

	[Token(Token = "0x6007E3B")]
	[Address(RVA = "0x11DAB70", Offset = "0x11D9970", Length = "0x814")]
	private void SelectDialogueChoice(TraderDialogueChoice dialogueChoice)
	{
	}

	[Token(Token = "0x6007E3C")]
	[Address(RVA = "0x11DB390", Offset = "0x11DA190", Length = "0xFA")]
	private void PlayTraderConversation(TraderConversation traderConversation)
	{
	}

	[Token(Token = "0x6007E3D")]
	[Address(RVA = "0x11DB490", Offset = "0x11DA290", Length = "0x57")]
	private bool HaveHadAllIntroductionConversations()
	{
		return false;
	}

	[Token(Token = "0x6007E3E")]
	[Address(RVA = "0x11DB4F0", Offset = "0x11DA2F0", Length = "0x3AD")]
	private void PlayTraderVoiceLineAndTransition(AK.Wwise.Event voiceLine, RadioState newState)
	{
	}

	[Token(Token = "0x6007E3F")]
	[Address(RVA = "0x11DB8A0", Offset = "0x11DA6A0", Length = "0x64")]
	private void OnTraderVoiceLineFinished()
	{
	}

	[Token(Token = "0x6007E40")]
	[Address(RVA = "0x11DB910", Offset = "0x11DA710", Length = "0x260")]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timeline, Action onComplete)
	{
	}

	[Token(Token = "0x6007E41")]
	[Address(RVA = "0x11DBB80", Offset = "0x11DA980", Length = "0x40")]
	private void UpdateTraderIsAvailable()
	{
	}

	[Token(Token = "0x6007E42")]
	[Address(RVA = "0x11DBBD0", Offset = "0x11DA9D0", Length = "0x10B")]
	private bool IsTraderAvailable()
	{
		return false;
	}

	[Token(Token = "0x6007E43")]
	[Address(RVA = "0x11DBCE0", Offset = "0x11DAAE0", Length = "0x94")]
	private bool CanContactTrader()
	{
		return false;
	}

	[Token(Token = "0x6007E44")]
	[Address(RVA = "0x11DBD80", Offset = "0x11DAB80", Length = "0x8")]
	private bool CanSkipCurrentDialogue()
	{
		return false;
	}

	[Token(Token = "0x6007E45")]
	[Address(RVA = "0x11DBD90", Offset = "0x11DAB90", Length = "0x194")]
	public TraderRadio()
	{
	}
}
