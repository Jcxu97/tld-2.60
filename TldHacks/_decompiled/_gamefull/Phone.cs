using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200059A")]
public class Phone : MonoBehaviour
{
	[Token(Token = "0x200059B")]
	public class PhoneSaveData
	{
		[Token(Token = "0x40033CB")]
		[FieldOffset(Offset = "0x10")]
		public string m_MissionId;

		[Token(Token = "0x40033CC")]
		[FieldOffset(Offset = "0x18")]
		public bool m_HasStartedRinging;

		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PhoneSaveData()
		{
		}
	}

	[Token(Token = "0x200059C")]
	private enum RingingState
	{
		[Token(Token = "0x40033CE")]
		NotRinging,
		[Token(Token = "0x40033CF")]
		SingleRing,
		[Token(Token = "0x40033D0")]
		ShortPause,
		[Token(Token = "0x40033D1")]
		WaitingNextCall,
		[Token(Token = "0x40033D2")]
		RingingLoop
	}

	[Token(Token = "0x40033AE")]
	[FieldOffset(Offset = "0x20")]
	public string m_PickUpReceiverAudio;

	[Token(Token = "0x40033AF")]
	[FieldOffset(Offset = "0x28")]
	public string m_RingingAudio;

	[Token(Token = "0x40033B0")]
	[FieldOffset(Offset = "0x30")]
	public string m_RingingClosedCaptionID;

	[Token(Token = "0x40033B1")]
	[FieldOffset(Offset = "0x38")]
	public float m_MinDistanceToPlayerForCaptions;

	[Token(Token = "0x40033B2")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_LoopAudio;

	[Token(Token = "0x40033B3")]
	[FieldOffset(Offset = "0x40")]
	public int m_RingCountMin;

	[Token(Token = "0x40033B4")]
	[FieldOffset(Offset = "0x44")]
	public int m_RingCountMax;

	[Token(Token = "0x40033B5")]
	[FieldOffset(Offset = "0x48")]
	public float m_ShortPauseDurationSeconds;

	[Token(Token = "0x40033B6")]
	[FieldOffset(Offset = "0x4C")]
	public float m_NextCallDurationSeconds;

	[Token(Token = "0x40033B7")]
	[FieldOffset(Offset = "0x50")]
	public DTContainer m_DTContainer;

	[Token(Token = "0x40033B8")]
	[FieldOffset(Offset = "0x58")]
	public DialogueModeRigFP m_DialogueMode;

	[Token(Token = "0x40033B9")]
	[FieldOffset(Offset = "0x60")]
	public AnimatedInteraction m_PickupAnimatedInteraction;

	[Token(Token = "0x40033BA")]
	[FieldOffset(Offset = "0x68")]
	public AnimatedInteraction m_HangupAnimatedInteraction;

	[Token(Token = "0x40033BB")]
	[FieldOffset(Offset = "0x70")]
	public string m_TimelinePhoneTrackName;

	[Header("NPC Voice")]
	[Token(Token = "0x40033BC")]
	[FieldOffset(Offset = "0x78")]
	public NPCVoice m_NPCVoice;

	[Token(Token = "0x40033BD")]
	[FieldOffset(Offset = "0x80")]
	public string m_NPCVoiceTrackName;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40033BE")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40033BF")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x40033C0")]
	[FieldOffset(Offset = "0x98")]
	private uint m_RingingAudioInstance;

	[Token(Token = "0x40033C1")]
	[FieldOffset(Offset = "0x9C")]
	private int m_RolledRingCount;

	[Token(Token = "0x40033C2")]
	[FieldOffset(Offset = "0xA0")]
	private MissionObjectIdentifier m_MissionObjectIdentifier;

	[Token(Token = "0x40033C3")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_HasStartedRinging;

	[Token(Token = "0x40033C4")]
	[FieldOffset(Offset = "0xAC")]
	private RingingState m_RingingState;

	[Token(Token = "0x40033C5")]
	private static float s_CurrentPhoneRingDurationRealtimeSeconds;

	[Token(Token = "0x40033C6")]
	[FieldOffset(Offset = "0xB0")]
	private float m_TimeElapsed;

	[Token(Token = "0x40033C7")]
	[FieldOffset(Offset = "0xB4")]
	private int m_CurrentRingIndex;

	[Token(Token = "0x40033C8")]
	[FieldOffset(Offset = "0xB8")]
	private int m_RingCycleCount;

	[Token(Token = "0x40033C9")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_IsShowingClosedCaptions;

	[AutoComponent(ComponentRequirement.Optional)]
	[SerializeField]
	[Token(Token = "0x40033CA")]
	[FieldOffset(Offset = "0xC0")]
	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	[Token(Token = "0x6002B4B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002B4C")]
	[Address(RVA = "0x917E40", Offset = "0x916C40", Length = "0xDA")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002B4D")]
	[Address(RVA = "0x917F20", Offset = "0x916D20", Length = "0x112")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B4E")]
	[Address(RVA = "0x918040", Offset = "0x916E40", Length = "0x13B")]
	private void Update()
	{
	}

	[Token(Token = "0x6002B4F")]
	[Address(RVA = "0x918180", Offset = "0x916F80", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002B50")]
	[Address(RVA = "0x918240", Offset = "0x917040", Length = "0xEF")]
	public string GetMissionObjectId()
	{
		return null;
	}

	[Token(Token = "0x6002B51")]
	[Address(RVA = "0x918330", Offset = "0x917130", Length = "0x370")]
	private void StartSingleRing()
	{
	}

	[Token(Token = "0x6002B52")]
	[Address(RVA = "0x9186B0", Offset = "0x9174B0", Length = "0x93")]
	private void HideClosedCaptions()
	{
	}

	[Token(Token = "0x6002B53")]
	[Address(RVA = "0x918750", Offset = "0x917550", Length = "0x5A9")]
	private void MaybeAssignDTController()
	{
	}

	[Token(Token = "0x6002B54")]
	[Address(RVA = "0x918D00", Offset = "0x917B00", Length = "0x226")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6002B55")]
	[Address(RVA = "0x918F30", Offset = "0x917D30", Length = "0x11D")]
	public void StartRinging()
	{
	}

	[Token(Token = "0x6002B56")]
	[Address(RVA = "0x919050", Offset = "0x917E50", Length = "0xC1")]
	public void StopRinging()
	{
	}

	[Token(Token = "0x6002B57")]
	[Address(RVA = "0x919120", Offset = "0x917F20", Length = "0x6A")]
	private void StopPhoneRingAudio()
	{
	}

	[Token(Token = "0x6002B58")]
	[Address(RVA = "0x919190", Offset = "0x917F90", Length = "0x26")]
	public bool IsRinging()
	{
		return false;
	}

	[Token(Token = "0x6002B59")]
	[Address(RVA = "0x9191C0", Offset = "0x917FC0", Length = "0x219")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002B5A")]
	[Address(RVA = "0x9193E0", Offset = "0x9181E0", Length = "0x111")]
	public bool IsInConversation()
	{
		return false;
	}

	[Token(Token = "0x6002B5B")]
	[Address(RVA = "0x919500", Offset = "0x918300", Length = "0xAD")]
	public int GetRingCycleCount()
	{
		return 0;
	}

	[Token(Token = "0x6002B5C")]
	[Address(RVA = "0x9195B0", Offset = "0x9183B0", Length = "0x16D")]
	private void OnPhonePickup()
	{
	}

	[Token(Token = "0x6002B5D")]
	[Address(RVA = "0x919720", Offset = "0x918520", Length = "0x1D6")]
	private void OnPhonePickupComplete()
	{
	}

	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x919900", Offset = "0x918700", Length = "0x15A")]
	private void OnPhoneHangup()
	{
	}

	[Token(Token = "0x6002B5F")]
	[Address(RVA = "0x919A60", Offset = "0x918860", Length = "0x1A3")]
	private void OnPhoneHangupComplete()
	{
	}

	[Token(Token = "0x6002B60")]
	[Address(RVA = "0x919C10", Offset = "0x918A10", Length = "0x7E")]
	private void StartShortPause()
	{
	}

	[Token(Token = "0x6002B61")]
	[Address(RVA = "0x919C90", Offset = "0x918A90", Length = "0xC8")]
	private void UpdateRinging()
	{
	}

	[Token(Token = "0x6002B62")]
	[Address(RVA = "0x919D60", Offset = "0x918B60", Length = "0x5C")]
	private int RollRingCount()
	{
		return 0;
	}

	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x919DC0", Offset = "0x918BC0", Length = "0x10F")]
	private void UpdateShortPause()
	{
	}

	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x919ED0", Offset = "0x918CD0", Length = "0xDF")]
	private void StartWaitingNextCall()
	{
	}

	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x919FB0", Offset = "0x918DB0", Length = "0xD5")]
	private void UpdateWaitingNextCall()
	{
	}

	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x91A090", Offset = "0x918E90", Length = "0x313")]
	private void UpdateAudio()
	{
	}

	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x91A3B0", Offset = "0x9191B0", Length = "0xAF")]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x91A460", Offset = "0x919260", Length = "0x152")]
	public static Phone GetPhone(string missionId)
	{
		return null;
	}

	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x91A5C0", Offset = "0x9193C0", Length = "0x15A")]
	public static void StartPhoneRinging(string missionId)
	{
	}

	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x91A720", Offset = "0x919520", Length = "0x153")]
	public static void StopPhoneRinging(string missionId)
	{
	}

	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x91A880", Offset = "0x919680", Length = "0x2EE")]
	private void AssignBindingOverrides()
	{
	}

	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x91AB70", Offset = "0x919970", Length = "0x266")]
	private void AssignBindingInfo(AnimatedInteraction animatedInteraction, Animator animator)
	{
	}

	[Token(Token = "0x6002B6D")]
	[Address(RVA = "0x91ADE0", Offset = "0x919BE0", Length = "0x63")]
	public Phone()
	{
	}
}
