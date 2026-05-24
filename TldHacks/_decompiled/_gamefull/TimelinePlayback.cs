using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

[Token(Token = "0x20005B9")]
public class TimelinePlayback : MonoBehaviour
{
	[Token(Token = "0x20005BA")]
	public class TimelineCallbacks
	{
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0x10")]
		public Action m_OnPlaying;

		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0x18")]
		public Action m_OnComplete;

		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0x20")]
		public Action m_OnInterrupted;

		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x934910", Offset = "0x933710", Length = "0x471")]
		public void Append(TimelineCallbacks other)
		{
		}

		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x934D90", Offset = "0x933B90", Length = "0x593")]
		public void Append(UnityEvent onPlaying, UnityEvent onComplete, UnityEvent onInterrupted)
		{
		}

		[Token(Token = "0x6002C64")]
		[Address(RVA = "0x935330", Offset = "0x934130", Length = "0xFA")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002C65")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public TimelineCallbacks()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20005BB")]
	public class PlayerCameraControlRotationSettings
	{
		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0x10")]
		public bool m_AllowPlayerFreeCameraLook;

		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0x11")]
		public bool m_HoldPlayerFreeCameraLookForNextTimeline;

		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 m_PitchLimit;

		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 m_YawLimit;

		[Token(Token = "0x6002C66")]
		[Address(RVA = "0x935430", Offset = "0x934230", Length = "0x96")]
		public PlayerCameraControlRotationSettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20005BC")]
	public class TimelineInfo
	{
		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0x10")]
		public AssetReferenceTimeline m_TimelineReference;

		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0x18")]
		public bool m_SkipDisableCrouch;

		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0x20")]
		public Animator m_BindingAnimator;

		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x28")]
		public string m_BindingTrackName;

		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_SyncBone;

		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x38")]
		public DirectorWrapMode m_WrapMode;

		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x3C")]
		public float m_TimeToSyncPlayerToSyncBone;

		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x40")]
		public float m_TimeToTransitionOut;

		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0x44")]
		public float m_DesiredFov;

		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x48")]
		public bool m_UnloadAfterPlay;

		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x4C")]
		public TLD_TimelineDirector.PlayerTimelineFlags m_PlayerTimelineFlags;

		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x50")]
		public PlayerCameraControlRotationSettings m_OptionalPlayerCameraRotation;

		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x58")]
		public vp_FPSPlayer.UnCrouchOptions m_UnCrouchOptions;

		[Token(Token = "0x6002C67")]
		[Address(RVA = "0x9354D0", Offset = "0x9342D0", Length = "0x7F")]
		public TimelineInfo()
		{
		}
	}

	[Token(Token = "0x20005BD")]
	public enum State
	{
		[Token(Token = "0x4003509")]
		Inactive,
		[Token(Token = "0x400350A")]
		Loading,
		[Token(Token = "0x400350B")]
		Playing,
		[Token(Token = "0x400350C")]
		TransitionOut
	}

	[Header("Playback Components")]
	[AutoComponent(ComponentRequirement.Optional)]
	[SerializeField]
	[FormerlySerializedAs("m_AnimatorOnCurrentObject")]
	[Token(Token = "0x40034DD")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[AutoComponent(ComponentRequirement.Optional)]
	[SerializeField]
	[FormerlySerializedAs("m_DirectorOnCurrentObject")]
	[Token(Token = "0x40034DE")]
	[FieldOffset(Offset = "0x28")]
	private TLD_TimelineDirector m_TimelineDirector;

	[Header("Bindings")]
	[Token(Token = "0x40034DF")]
	[FieldOffset(Offset = "0x30")]
	public List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	[Header("Immediate Playback Override")]
	[SerializeField]
	[Token(Token = "0x40034E0")]
	[FieldOffset(Offset = "0x38")]
	private TimelineInfo m_OptionalPlayTimelineOnStart;

	[SerializeField]
	[Token(Token = "0x40034E1")]
	[FieldOffset(Offset = "0x40")]
	private UnityEvent m_OnPlaying;

	[SerializeField]
	[Token(Token = "0x40034E2")]
	[FieldOffset(Offset = "0x48")]
	private UnityEvent m_OnComplete;

	[SerializeField]
	[Token(Token = "0x40034E3")]
	[FieldOffset(Offset = "0x50")]
	private UnityEvent m_OnInterrupted;

	[Token(Token = "0x40034E4")]
	[FieldOffset(Offset = "0x58")]
	private State m_CurrentState;

	[Token(Token = "0x40034E5")]
	[FieldOffset(Offset = "0x60")]
	private TLD_TimelineDirector m_TimelineDirectorToPlayOn;

	[Token(Token = "0x40034E6")]
	[FieldOffset(Offset = "0x68")]
	private TimelineInfo m_TimelineToPlay;

	[Token(Token = "0x40034E7")]
	[FieldOffset(Offset = "0x70")]
	private TimelineCallbacks m_Callbacks;

	[Token(Token = "0x40034E8")]
	[FieldOffset(Offset = "0x78")]
	private PlayerControlMode m_PlayerControlMode;

	[Token(Token = "0x40034E9")]
	[FieldOffset(Offset = "0x7C")]
	private PlayerControlMode m_PreviousPlayerControlMode;

	[Token(Token = "0x40034EA")]
	[FieldOffset(Offset = "0x80")]
	private bool m_TimelineBeingPlayedOnPlayer;

	[Token(Token = "0x40034EB")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 m_PlayerSyncStartPosition;

	[Token(Token = "0x40034EC")]
	[FieldOffset(Offset = "0x90")]
	private Quaternion m_PlayerSyncStartRotation;

	[Token(Token = "0x40034ED")]
	[FieldOffset(Offset = "0xA0")]
	private float m_OriginalPlayerFov;

	[Token(Token = "0x40034EE")]
	[FieldOffset(Offset = "0xA4")]
	private float m_FovBeforeTransition;

	[Token(Token = "0x40034EF")]
	[FieldOffset(Offset = "0xA8")]
	private float m_TimeLeftToSyncPlayer;

	[Token(Token = "0x40034F0")]
	[FieldOffset(Offset = "0xAC")]
	private float m_CurrentFov;

	[Token(Token = "0x40034F1")]
	[FieldOffset(Offset = "0xB0")]
	private Quaternion m_OriginalCameraRotation;

	[Token(Token = "0x40034F2")]
	[FieldOffset(Offset = "0xC0")]
	private Vector2 m_OriginalCameraPitchLimit;

	[Token(Token = "0x40034F3")]
	[FieldOffset(Offset = "0xC8")]
	private Vector2 m_OriginalCameraYawLimit;

	[Token(Token = "0x6002C43")]
	[Address(RVA = "0x930B10", Offset = "0x92F910", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C44")]
	[Address(RVA = "0x930B20", Offset = "0x92F920", Length = "0x54")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C45")]
	[Address(RVA = "0x930B10", Offset = "0x92F910", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002C46")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002C47")]
	[Address(RVA = "0x930B80", Offset = "0x92F980", Length = "0x1E8")]
	public void PlayTimelineOnPlayer(TimelineInfo timeline, TimelineCallbacks callbacks, bool shouldStowItemInHands, PlayerControlMode controlMode = PlayerControlMode.Normal)
	{
	}

	[Token(Token = "0x6002C48")]
	[Address(RVA = "0x930D70", Offset = "0x92FB70", Length = "0x370")]
	public void PlayTimelineOnSelf(TimelineInfo timeline, TimelineCallbacks callbacks)
	{
	}

	[Token(Token = "0x6002C49")]
	[Address(RVA = "0x9310F0", Offset = "0x92FEF0", Length = "0x330")]
	public void PlayTimeline(TimelineInfo timeline, TLD_TimelineDirector targetDirector, TimelineCallbacks callbacks)
	{
	}

	[Token(Token = "0x6002C4A")]
	[Address(RVA = "0x931430", Offset = "0x930230", Length = "0x1DB")]
	public void LoadTimelineOnSelf(TimelineInfo timelineInfo)
	{
	}

	[Token(Token = "0x6002C4B")]
	[Address(RVA = "0x931610", Offset = "0x930410", Length = "0x130")]
	public void LoadTimeline(TimelineInfo timelineInfo)
	{
	}

	[Token(Token = "0x6002C4C")]
	[Address(RVA = "0x931750", Offset = "0x930550", Length = "0x39")]
	private void OnTimelineLoaded(AssetReferenceTimeline timeline)
	{
	}

	[Token(Token = "0x6002C4D")]
	[Address(RVA = "0x931790", Offset = "0x930590", Length = "0xF8")]
	public bool StopCurrentTimeline()
	{
		return false;
	}

	[Token(Token = "0x6002C4E")]
	[Address(RVA = "0x931890", Offset = "0x930690", Length = "0x8")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002C4F")]
	[Address(RVA = "0x9318A0", Offset = "0x9306A0", Length = "0x8")]
	public bool IsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6002C50")]
	[Address(RVA = "0x9318B0", Offset = "0x9306B0", Length = "0x267")]
	public void SetSpeed(float speed)
	{
	}

	[Token(Token = "0x6002C51")]
	[Address(RVA = "0x931B20", Offset = "0x930920", Length = "0x11C")]
	public double GetCurrentTimelineDuration()
	{
		return 0.0;
	}

	[Token(Token = "0x6002C52")]
	[Address(RVA = "0x931C40", Offset = "0x930A40", Length = "0x146")]
	public double GetCurrentTimelineTimeRemaining()
	{
		return 0.0;
	}

	[Token(Token = "0x6002C53")]
	[Address(RVA = "0x931D90", Offset = "0x930B90", Length = "0x157")]
	public double GetCurrentTimelineNormalizedProgress()
	{
		return 0.0;
	}

	[Token(Token = "0x6002C54")]
	[Address(RVA = "0x931EF0", Offset = "0x930CF0", Length = "0x476")]
	private void StartPlayerSyncingToSyncBone()
	{
	}

	[Token(Token = "0x6002C55")]
	[Address(RVA = "0x932370", Offset = "0x931170", Length = "0x104")]
	private void StartPlayerTransitionOut()
	{
	}

	[Token(Token = "0x6002C56")]
	[Address(RVA = "0x932480", Offset = "0x931280", Length = "0x571")]
	private void EnablePlayerFreeCameraMovement()
	{
	}

	[Token(Token = "0x6002C57")]
	[Address(RVA = "0x932A00", Offset = "0x931800", Length = "0x42C")]
	private void DisablePlayerFreeCameraMovement()
	{
	}

	[Token(Token = "0x6002C58")]
	[Address(RVA = "0x932E30", Offset = "0x931C30", Length = "0x1D1")]
	private void SetupSyncNodeBinding()
	{
	}

	[Token(Token = "0x6002C59")]
	[Address(RVA = "0x933010", Offset = "0x931E10", Length = "0x23F")]
	private void SetupTrackBinding()
	{
	}

	[Token(Token = "0x6002C5A")]
	[Address(RVA = "0x933250", Offset = "0x932050", Length = "0x1F")]
	private void SetupBinding()
	{
	}

	[Token(Token = "0x6002C5B")]
	[Address(RVA = "0x933270", Offset = "0x932070", Length = "0x25C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x9334D0", Offset = "0x9322D0", Length = "0x98C")]
	private void UpdateSyncPlayerToSyncBone()
	{
	}

	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x933E60", Offset = "0x932C60", Length = "0x24E")]
	private void UpdateTransitionOut()
	{
	}

	[Token(Token = "0x6002C5E")]
	[Address(RVA = "0x9340B0", Offset = "0x932EB0", Length = "0x13D")]
	private void OnTimelineComplete()
	{
	}

	[Token(Token = "0x6002C5F")]
	[Address(RVA = "0x9341F0", Offset = "0x932FF0", Length = "0xB9")]
	private void Finish()
	{
	}

	[Token(Token = "0x6002C60")]
	[Address(RVA = "0x9342B0", Offset = "0x9330B0", Length = "0x311")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x6002C61")]
	[Address(RVA = "0x9345D0", Offset = "0x9333D0", Length = "0x331")]
	public TimelinePlayback()
	{
	}
}
