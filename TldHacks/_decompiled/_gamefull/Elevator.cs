using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using Unity.Collections;
using UnityEngine;

[Token(Token = "0x200057B")]
public class Elevator : MonoBehaviour
{
	[Token(Token = "0x200057C")]
	public enum EntranceSide
	{
		[Token(Token = "0x40032AB")]
		Left,
		[Token(Token = "0x40032AC")]
		Right
	}

	[Serializable]
	[Token(Token = "0x200057D")]
	public class FloorData
	{
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x10")]
		public int m_RevsFromPrevFloor;

		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x14")]
		public int m_FinalRev;

		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x18")]
		public EntranceSide m_EntranceSide;

		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public FloorData()
		{
		}
	}

	[Token(Token = "0x200057E")]
	private enum State
	{
		[Token(Token = "0x40032B1")]
		WaitingForPlayer,
		[Token(Token = "0x40032B2")]
		Entering,
		[Token(Token = "0x40032B3")]
		IdleDockedAtFloor,
		[Token(Token = "0x40032B4")]
		IdleMidProgress,
		[Token(Token = "0x40032B5")]
		MovingUp,
		[Token(Token = "0x40032B6")]
		MovingDown,
		[Token(Token = "0x40032B7")]
		CrashingDown,
		[Token(Token = "0x40032B8")]
		Exiting
	}

	[Token(Token = "0x4003266")]
	public static bool s_ElevatorDebug;

	[AutoComponent(ComponentRequirement.Optional)]
	[SerializeField]
	[Token(Token = "0x4003267")]
	[FieldOffset(Offset = "0x20")]
	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	[Header("Floors")]
	[Token(Token = "0x4003268")]
	[FieldOffset(Offset = "0x28")]
	public EntranceSide m_BaseFloorEntranceSide;

	[Token(Token = "0x4003269")]
	[FieldOffset(Offset = "0x30")]
	public List<FloorData> m_FloorsUp;

	[Token(Token = "0x400326A")]
	[FieldOffset(Offset = "0x38")]
	public List<FloorData> m_FloorsDown;

	[Header("Doors")]
	[Token(Token = "0x400326B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_LeftDoorInteractionCollider;

	[Token(Token = "0x400326C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_RightDoorInteractionCollider;

	[Header("Stamina")]
	[Token(Token = "0x400326D")]
	[FieldOffset(Offset = "0x50")]
	public float m_StaminaCostToMove;

	[Token(Token = "0x400326E")]
	[FieldOffset(Offset = "0x54")]
	public bool m_OnlyAllowMoveIfHasRequiredStamina;

	[Token(Token = "0x400326F")]
	[FieldOffset(Offset = "0x58")]
	public float m_StaminaRequiredForFullSpeed;

	[Token(Token = "0x4003270")]
	[FieldOffset(Offset = "0x5C")]
	public float m_StaminaThresholdForPotentialDrop;

	[Token(Token = "0x4003271")]
	[FieldOffset(Offset = "0x60")]
	public float m_StaminaDropChanceBelowThreshold;

	[Token(Token = "0x4003272")]
	[FieldOffset(Offset = "0x64")]
	public float m_LowStaminaAnimationSpeed;

	[Token(Token = "0x4003273")]
	[FieldOffset(Offset = "0x68")]
	public float m_MovingProgressBeforePotentialDrop;

	[Header("Crash Down (Drop)")]
	[Token(Token = "0x4003274")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve m_CrashDownCurve;

	[Token(Token = "0x4003275")]
	[FieldOffset(Offset = "0x78")]
	public float m_MinDamageHeightDrop;

	[Token(Token = "0x4003276")]
	[FieldOffset(Offset = "0x7C")]
	public float m_MinDamageAmount;

	[Token(Token = "0x4003277")]
	[FieldOffset(Offset = "0x80")]
	public float m_MaxDamageHeightDrop;

	[Token(Token = "0x4003278")]
	[FieldOffset(Offset = "0x84")]
	public float m_MaxDamageAmount;

	[Token(Token = "0x4003279")]
	[FieldOffset(Offset = "0x88")]
	public float m_CrashDownDuration;

	[Header("Interaction Prompts")]
	[Token(Token = "0x400327A")]
	[FieldOffset(Offset = "0x90")]
	public LocalizedString m_ExitText;

	[Token(Token = "0x400327B")]
	[FieldOffset(Offset = "0x98")]
	public LocalizedString m_GoUpText;

	[Token(Token = "0x400327C")]
	[FieldOffset(Offset = "0xA0")]
	public LocalizedString m_GoDownText;

	[Header("Crank")]
	[Token(Token = "0x400327D")]
	[FieldOffset(Offset = "0xA8")]
	public string[] m_ValidCrankGearItems;

	[Token(Token = "0x400327E")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_ElevatorHasCrank;

	[Token(Token = "0x400327F")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_CrankObject;

	[Header("Timeline Animations")]
	[ReadOnly]
	[AutoComponent(ComponentRequirement.Required)]
	[Token(Token = "0x4003280")]
	[FieldOffset(Offset = "0xC0")]
	public TimelinePlayback m_TimelinePlayback;

	[SerializeField]
	[Token(Token = "0x4003281")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 m_CrankAnimationDisplacement;

	[SerializeField]
	[Token(Token = "0x4003282")]
	[FieldOffset(Offset = "0xD8")]
	private TimelinePlayback.TimelineInfo m_EnterTimeline;

	[SerializeField]
	[Token(Token = "0x4003283")]
	[FieldOffset(Offset = "0xE0")]
	private TimelinePlayback.TimelineInfo m_EnterRightTimeline;

	[SerializeField]
	[Token(Token = "0x4003284")]
	[FieldOffset(Offset = "0xE8")]
	private TimelinePlayback.TimelineInfo m_EnterNoCrankTimeline;

	[SerializeField]
	[Token(Token = "0x4003285")]
	[FieldOffset(Offset = "0xF0")]
	private TimelinePlayback.TimelineInfo m_EnterRightNoCrankTimeline;

	[SerializeField]
	[Token(Token = "0x4003286")]
	[FieldOffset(Offset = "0xF8")]
	private TimelinePlayback.TimelineInfo m_WaitAtFloorLoopTimeline;

	[SerializeField]
	[Token(Token = "0x4003287")]
	[FieldOffset(Offset = "0x100")]
	private TimelinePlayback.TimelineInfo m_WaitMidProgressLoopTimeline;

	[SerializeField]
	[Token(Token = "0x4003288")]
	[FieldOffset(Offset = "0x108")]
	private TimelinePlayback.TimelineInfo m_LoopUpTimeline;

	[SerializeField]
	[Token(Token = "0x4003289")]
	[FieldOffset(Offset = "0x110")]
	private TimelinePlayback.TimelineInfo m_FinalLoopUpTimeline;

	[SerializeField]
	[Token(Token = "0x400328A")]
	[FieldOffset(Offset = "0x118")]
	private TimelinePlayback.TimelineInfo m_LoopDownTimeline;

	[SerializeField]
	[Token(Token = "0x400328B")]
	[FieldOffset(Offset = "0x120")]
	private TimelinePlayback.TimelineInfo m_FinalLoopDownTimeline;

	[SerializeField]
	[Token(Token = "0x400328C")]
	[FieldOffset(Offset = "0x128")]
	private TimelinePlayback.TimelineInfo m_CrashDownTimeline;

	[SerializeField]
	[Token(Token = "0x400328D")]
	[FieldOffset(Offset = "0x130")]
	private TimelinePlayback.TimelineInfo m_ExitTimeline;

	[SerializeField]
	[Token(Token = "0x400328E")]
	[FieldOffset(Offset = "0x138")]
	private TimelinePlayback.TimelineInfo m_ExitRightTimeline;

	[SerializeField]
	[Token(Token = "0x400328F")]
	[FieldOffset(Offset = "0x140")]
	private TimelinePlayback.TimelineInfo m_ExitNoCrankTimeline;

	[SerializeField]
	[Token(Token = "0x4003290")]
	[FieldOffset(Offset = "0x148")]
	private TimelinePlayback.TimelineInfo m_ExitRightNoCrankTimeline;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4003291")]
	[FieldOffset(Offset = "0x150")]
	private AK.Wwise.Event m_ArriveAtFloorAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003292")]
	[FieldOffset(Offset = "0x158")]
	private AK.Wwise.Event m_DepartFromFloorAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003293")]
	[FieldOffset(Offset = "0x160")]
	private AK.Wwise.Event m_EnteredCrashDownThresholdAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003294")]
	[FieldOffset(Offset = "0x168")]
	private AK.Wwise.Event m_ExitedCrashDownThresholdAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003295")]
	[FieldOffset(Offset = "0x170")]
	private AK.Wwise.Event m_CrashDownStartAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003296")]
	[FieldOffset(Offset = "0x178")]
	private AK.Wwise.Event m_CrashDownEndAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003297")]
	[FieldOffset(Offset = "0x180")]
	private AK.Wwise.Event m_CrashAudioEvent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003298")]
	[FieldOffset(Offset = "0x188")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4003299")]
	[FieldOffset(Offset = "0x190")]
	private State m_StateInternal;

	[Token(Token = "0x400329A")]
	[FieldOffset(Offset = "0x194")]
	private int m_LastFloorIndex;

	[Token(Token = "0x400329B")]
	[FieldOffset(Offset = "0x198")]
	private int m_NextFloorIndex;

	[Token(Token = "0x400329C")]
	[FieldOffset(Offset = "0x19C")]
	private int m_RevsSinceLastFloor;

	[Token(Token = "0x400329D")]
	[FieldOffset(Offset = "0x1A0")]
	private Vector3 m_PositionOnEntry;

	[Token(Token = "0x400329E")]
	[FieldOffset(Offset = "0x1AC")]
	private Vector3 m_PositionOnExit;

	[Token(Token = "0x400329F")]
	[FieldOffset(Offset = "0x1B8")]
	public Transform m_AnimatedObject;

	[Token(Token = "0x40032A0")]
	[FieldOffset(Offset = "0x1C0")]
	private float m_MoveAxisThreshold;

	[Token(Token = "0x40032A1")]
	[FieldOffset(Offset = "0x1C4")]
	private bool m_RolledForStaminaDrop;

	[Token(Token = "0x40032A2")]
	[FieldOffset(Offset = "0x1C8")]
	private float m_TimeSpentInCrashDown;

	[Token(Token = "0x40032A3")]
	[FieldOffset(Offset = "0x1CC")]
	private Vector3 m_InitialPosBeforeCrashDown;

	[Token(Token = "0x40032A4")]
	[FieldOffset(Offset = "0x1D8")]
	private Vector3 m_CrashDownTargetPosition;

	[Token(Token = "0x40032A5")]
	[FieldOffset(Offset = "0x1E4")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x40032A6")]
	[FieldOffset(Offset = "0x1EC")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x40032A7")]
	[FieldOffset(Offset = "0x1F4")]
	private bool m_CurrentlyUnderStaminaThreshold;

	[Token(Token = "0x40032A8")]
	private static List<Elevator> s_StaticElevators;

	[Token(Token = "0x40032A9")]
	private static ElevatorSaveDataProxy m_ElevatorSaveDataProxy;

	[Token(Token = "0x170002BF")]
	private State m_State
	{
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x8FB9C0", Offset = "0x8FA7C0", Length = "0x7")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x8FB9D0", Offset = "0x8FA7D0", Length = "0x28")]
		set
		{
		}
	}

	[Token(Token = "0x6002A27")]
	[Address(RVA = "0x8FBAF0", Offset = "0x8FA8F0", Length = "0x36")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002A28")]
	[Address(RVA = "0x8FBB30", Offset = "0x8FA930", Length = "0x214")]
	private bool CanInteract()
	{
		return false;
	}

	[Token(Token = "0x6002A29")]
	[Address(RVA = "0x8FBD50", Offset = "0x8FAB50", Length = "0x339")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002A2A")]
	[Address(RVA = "0x8FC090", Offset = "0x8FAE90", Length = "0x177")]
	private bool HasValidCrankItem()
	{
		return false;
	}

	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0x8FC210", Offset = "0x8FB010", Length = "0xEC")]
	public bool IsMoving()
	{
		return false;
	}

	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0x8FC300", Offset = "0x8FB100", Length = "0x15")]
	public bool IsWaitingForPlayerInput()
	{
		return false;
	}

	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0x8FC320", Offset = "0x8FB120", Length = "0x200")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x8FC530", Offset = "0x8FB330", Length = "0x83")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x8FC5C0", Offset = "0x8FB3C0", Length = "0x2E8")]
	public static void ResetElevatorWhenPlayerDies()
	{
	}

	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x8FC8B0", Offset = "0x8FB6B0", Length = "0x94")]
	public static void ResetAll()
	{
	}

	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x8FC950", Offset = "0x8FB750", Length = "0x503")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x8FCE60", Offset = "0x8FBC60", Length = "0x198")]
	private string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x8FD000", Offset = "0x8FBE00", Length = "0x1B9")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x8FD1C0", Offset = "0x8FBFC0", Length = "0x1B4")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002A35")]
	[Address(RVA = "0x8FD380", Offset = "0x8FC180", Length = "0x12A")]
	private static Elevator FindElevatorByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002A36")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002A37")]
	[Address(RVA = "0x8FD4B0", Offset = "0x8FC2B0", Length = "0x22B")]
	private void Update()
	{
	}

	[Token(Token = "0x6002A38")]
	[Address(RVA = "0x8FD6E0", Offset = "0x8FC4E0", Length = "0x18F")]
	private void HandleLowStaminaAudio()
	{
	}

	[Token(Token = "0x6002A39")]
	[Address(RVA = "0x8FD870", Offset = "0x8FC670", Length = "0x4BE")]
	private GameObject GetInteractedDoor()
	{
		return null;
	}

	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0x8FDD30", Offset = "0x8FCB30", Length = "0x2F4")]
	private void Move(State direction)
	{
	}

	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0x8FE030", Offset = "0x8FCE30", Length = "0x324")]
	private void StartCrashDownSequence()
	{
	}

	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x8FE360", Offset = "0x8FD160", Length = "0x71")]
	private void UpdateIdleDockedAtFloor()
	{
	}

	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x8FE3E0", Offset = "0x8FD1E0", Length = "0x186")]
	private bool UpdateWaitForPlayerMovement()
	{
		return false;
	}

	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x8FE570", Offset = "0x8FD370", Length = "0xCE")]
	private void GetRevsRequiredToNextFloor(State direction, ref int revsRequiredToNextFloor, ref int finalRevs)
	{
	}

	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0x8FE640", Offset = "0x8FD440", Length = "0x2E")]
	private EntranceSide GetEntranceUsedForCurrentFloor()
	{
		return default(EntranceSide);
	}

	[Token(Token = "0x6002A40")]
	[Address(RVA = "0x8FE670", Offset = "0x8FD470", Length = "0xE4")]
	private FloorData GetFloorIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6002A41")]
	[Address(RVA = "0x8FE760", Offset = "0x8FD560", Length = "0x3B")]
	private bool CanGoUp()
	{
		return false;
	}

	[Token(Token = "0x6002A42")]
	[Address(RVA = "0x8FE7A0", Offset = "0x8FD5A0", Length = "0x3B")]
	private bool CanGoDown()
	{
		return false;
	}

	[Token(Token = "0x6002A43")]
	[Address(RVA = "0x8FE7E0", Offset = "0x8FD5E0", Length = "0x336")]
	private void UpdateMoving()
	{
	}

	[Token(Token = "0x6002A44")]
	[Address(RVA = "0x8FEB20", Offset = "0x8FD920", Length = "0x1FB")]
	private bool ShouldRollForDrop(float stamina)
	{
		return false;
	}

	[Token(Token = "0x6002A45")]
	[Address(RVA = "0x8FED20", Offset = "0x8FDB20", Length = "0x177")]
	private int GetNumCranksFromMiddleFloor()
	{
		return 0;
	}

	[Token(Token = "0x6002A46")]
	[Address(RVA = "0x8FEEA0", Offset = "0x8FDCA0", Length = "0xF0")]
	private int GetNumCranksFromBottomFloor()
	{
		return 0;
	}

	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x8FEFA0", Offset = "0x8FDDA0", Length = "0x59")]
	private Vector3 GetDistanceForNumberOfCranks(int numCranks)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x8FF000", Offset = "0x8FDE00", Length = "0x6E3")]
	private void UpdateCrashingDown()
	{
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x8FF6F0", Offset = "0x8FE4F0", Length = "0x114")]
	private float GetFallDamageToIssue()
	{
		return 0f;
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x8FF810", Offset = "0x8FE610", Length = "0x3CE")]
	private void EnterPlayer()
	{
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x8FFBE0", Offset = "0x8FE9E0", Length = "0x218")]
	private void CommenceExitPlayer()
	{
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x8FFE00", Offset = "0x8FEC00", Length = "0x11E")]
	private void ExitPlayer()
	{
	}

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x8FFF20", Offset = "0x8FED20", Length = "0x14F")]
	public void ResetElevator()
	{
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x900070", Offset = "0x8FEE70", Length = "0x14D")]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timeline, Action onTimelineComplete, Action onTimelineInterrupted = null)
	{
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x9001C0", Offset = "0x8FEFC0", Length = "0x32")]
	private void LoadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x900200", Offset = "0x8FF000", Length = "0x20")]
	private void UnloadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[Token(Token = "0x6002A51")]
	[Address(RVA = "0x900220", Offset = "0x8FF020", Length = "0x16C")]
	private void OnEnterAnimationComplete()
	{
	}

	[Token(Token = "0x6002A52")]
	[Address(RVA = "0x900390", Offset = "0x8FF190", Length = "0x127")]
	private void OnExitAnimationComplete()
	{
	}

	[Token(Token = "0x6002A53")]
	[Address(RVA = "0x9004C0", Offset = "0x8FF2C0", Length = "0x1BE")]
	private void OnMoved()
	{
	}

	[Token(Token = "0x6002A54")]
	[Address(RVA = "0x900680", Offset = "0x8FF480", Length = "0x248")]
	private void ApplyPositionFromAnimation()
	{
	}

	[Token(Token = "0x6002A55")]
	[Address(RVA = "0x9008D0", Offset = "0x8FF6D0", Length = "0x1F2")]
	private void UpdatePlacementZoneParent()
	{
	}

	[Token(Token = "0x6002A56")]
	[Address(RVA = "0x900AD0", Offset = "0x8FF8D0", Length = "0x227")]
	private Vector3 GetRealPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002A57")]
	[Address(RVA = "0x900D00", Offset = "0x8FFB00", Length = "0xB")]
	private bool IsCurrentlyAtAFloor()
	{
		return false;
	}

	[Token(Token = "0x6002A58")]
	[Address(RVA = "0x900D10", Offset = "0x8FFB10", Length = "0x41E")]
	private void UpdateButtonPrompts(bool isGamepadActive)
	{
	}

	[Token(Token = "0x6002A59")]
	[Address(RVA = "0x901130", Offset = "0x8FFF30", Length = "0x165")]
	private void LoadElevatorTimelines()
	{
	}

	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0x9012A0", Offset = "0x9000A0", Length = "0x13D")]
	private void UnloadElevatorTimelines()
	{
	}

	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0x9013E0", Offset = "0x9001E0", Length = "0x8F1")]
	public Elevator()
	{
	}
}
