using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x2000999")]
public class TLD_CameraAnimationTrack : AnimationTrack, TLD_ITrack, TLD_IDynamicBindableTrack, TLD_IFPAnchoredTrack
{
	[Token(Token = "0x4006299")]
	[FieldOffset(Offset = "0x130")]
	public float m_FieldOfView;

	[Token(Token = "0x400629A")]
	[FieldOffset(Offset = "0x134")]
	public bool m_OverrideClipPlanes;

	[Token(Token = "0x400629B")]
	[FieldOffset(Offset = "0x138")]
	public float m_NearClipPlane;

	[Token(Token = "0x400629C")]
	[FieldOffset(Offset = "0x13C")]
	public float m_FarClipPlane;

	[Token(Token = "0x400629D")]
	[FieldOffset(Offset = "0x140")]
	public bool m_HoldLastFPFrame;

	[Token(Token = "0x400629E")]
	[FieldOffset(Offset = "0x141")]
	public bool m_ReplaceDialogueExit;

	[Token(Token = "0x400629F")]
	[FieldOffset(Offset = "0x144")]
	public float m_InTransitionDurationSeconds;

	[Token(Token = "0x40062A0")]
	[FieldOffset(Offset = "0x148")]
	public float m_OutTransitionDurationSeconds;

	[Token(Token = "0x40062A1")]
	[FieldOffset(Offset = "0x14C")]
	public bool m_HoldPlayerOverrideForNextTimeline;

	[Token(Token = "0x40062A2")]
	[FieldOffset(Offset = "0x14D")]
	public bool m_SuppressBreathFX;

	[Token(Token = "0x40062A3")]
	[FieldOffset(Offset = "0x14E")]
	public bool m_UseRelativeCameraAnimation;

	[Token(Token = "0x40062A4")]
	[FieldOffset(Offset = "0x14F")]
	public bool m_AllowFreeCameraMovement;

	[Token(Token = "0x40062A5")]
	[FieldOffset(Offset = "0x150")]
	public bool m_RetainCameraFieldOfView;

	[Token(Token = "0x40062A6")]
	[FieldOffset(Offset = "0x158")]
	private CameraGlobalRT m_GlobalCamera;

	[Token(Token = "0x40062A7")]
	[FieldOffset(Offset = "0x160")]
	private PlayerControlMode m_RestorePlayerControlMode;

	[Token(Token = "0x40062A8")]
	private static Camera s_AnimatedCamera;

	[Token(Token = "0x40062A9")]
	private static GameObject s_AnimatedCameraAnimatorObject;

	[Token(Token = "0x40062AA")]
	private static GameObject s_AnimatedCameraRootObject;

	[Token(Token = "0x40062AB")]
	private static GameObject s_AnimatedCameraHeadObject;

	[Token(Token = "0x40062AC")]
	private static GameObject s_AnimatedCameraFeetObject;

	[Token(Token = "0x40062AD")]
	private static int s_CountPlaying;

	[Token(Token = "0x40062AE")]
	[FieldOffset(Offset = "0x164")]
	private bool m_IsPlaying;

	[Token(Token = "0x40062AF")]
	[FieldOffset(Offset = "0x168")]
	private Transform m_FPAnchor;

	[Token(Token = "0x40062B0")]
	[FieldOffset(Offset = "0x170")]
	private bool m_HasStartedOverride;

	[Token(Token = "0x40062B1")]
	[FieldOffset(Offset = "0x174")]
	private Vector3 m_OriginalFPPosition;

	[Token(Token = "0x40062B2")]
	[FieldOffset(Offset = "0x180")]
	private Quaternion m_OriginalFPRotation;

	[Token(Token = "0x40062B3")]
	[FieldOffset(Offset = "0x190")]
	private Quaternion m_OriginalCameraLocalRotation;

	[Token(Token = "0x40062B4")]
	[FieldOffset(Offset = "0x1A0")]
	private bool m_HasUpdatedForAnchor;

	[Token(Token = "0x40062B5")]
	[FieldOffset(Offset = "0x1A4")]
	private float m_AppliedNearClipPlane;

	[Token(Token = "0x40062B6")]
	[FieldOffset(Offset = "0x1A8")]
	private float m_AppliedFarClipPlane;

	[Token(Token = "0x40062B7")]
	[FieldOffset(Offset = "0x1AC")]
	private bool m_FPSCameraDisabled;

	[Token(Token = "0x40062B8")]
	[FieldOffset(Offset = "0x1AD")]
	private bool m_TimelineHasFPAnchor;

	[Token(Token = "0x40062B9")]
	[FieldOffset(Offset = "0x1AE")]
	private bool m_HasInitializedExitValues;

	[Token(Token = "0x40062BA")]
	[FieldOffset(Offset = "0x1B0")]
	private Quaternion m_ExitStartCameraRootOriginalRotation;

	[Token(Token = "0x40062BB")]
	[FieldOffset(Offset = "0x1C0")]
	private TLD_TimelineDirector m_Director;

	[Token(Token = "0x40062BC")]
	[FieldOffset(Offset = "0x1C8")]
	private Vector3 m_OriginalPosition;

	[Token(Token = "0x40062BD")]
	[FieldOffset(Offset = "0x1D4")]
	private Vector3 m_OriginalLocalPosition;

	[Token(Token = "0x40062BE")]
	[FieldOffset(Offset = "0x1E0")]
	private Quaternion m_OriginalRotation;

	[Token(Token = "0x40062BF")]
	[FieldOffset(Offset = "0x1F0")]
	private float m_OriginalFieldOfView;

	[Token(Token = "0x40062C0")]
	[FieldOffset(Offset = "0x1F4")]
	private float m_OriginalNearClipPlane;

	[Token(Token = "0x40062C1")]
	[FieldOffset(Offset = "0x1F8")]
	private float m_OriginalFarClipPlane;

	[Token(Token = "0x40062C2")]
	private static bool s_IsHoldingCameraDisabledForNextTimeline;

	[Token(Token = "0x40062C3")]
	private static bool s_IsHoldingFovForNextTimeline;

	[Token(Token = "0x40062C4")]
	private static float s_OriginalFovForNextTimeline;

	[Token(Token = "0x60055A8")]
	[Address(RVA = "0xEA0DB0", Offset = "0xE9FBB0", Length = "0x81F")]
	private void StartCameraOverride()
	{
	}

	[Token(Token = "0x60055A9")]
	[Address(RVA = "0xEA15D0", Offset = "0xEA03D0", Length = "0x3F2")]
	public void Play()
	{
	}

	[Token(Token = "0x60055AA")]
	[Address(RVA = "0xEA19D0", Offset = "0xEA07D0", Length = "0x8")]
	public bool ShouldSupressBreathFX()
	{
		return false;
	}

	[Token(Token = "0x60055AB")]
	[Address(RVA = "0xEA19E0", Offset = "0xEA07E0", Length = "0x19F")]
	public float GetNextEndTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x60055AC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdatePlay()
	{
	}

	[Token(Token = "0x60055AD")]
	[Address(RVA = "0xEA1B80", Offset = "0xEA0980", Length = "0x6E8")]
	public void LateUpdatePlay()
	{
	}

	[Token(Token = "0x60055AE")]
	[Address(RVA = "0xEA2270", Offset = "0xEA1070", Length = "0xD96")]
	public void Stop()
	{
	}

	[Token(Token = "0x60055AF")]
	[Address(RVA = "0xEA3010", Offset = "0xEA1E10", Length = "0x2D2")]
	public static void ResetAllTransforms(Transform t)
	{
	}

	[Token(Token = "0x60055B0")]
	[Address(RVA = "0xEA32F0", Offset = "0xEA20F0", Length = "0x1B6")]
	public static void ResetCamera()
	{
	}

	[Token(Token = "0x60055B1")]
	[Address(RVA = "0xEA34B0", Offset = "0xEA22B0", Length = "0x348")]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[Token(Token = "0x60055B2")]
	[Address(RVA = "0xEA3800", Offset = "0xEA2600", Length = "0x2CE")]
	public Transform GetFeetTransform()
	{
		return null;
	}

	[Token(Token = "0x60055B3")]
	[Address(RVA = "0xEA3AD0", Offset = "0xEA28D0", Length = "0x1A9")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x60055B4")]
	[Address(RVA = "0xEA3C80", Offset = "0xEA2A80", Length = "0x109A")]
	private GameObject GetCamera()
	{
		return null;
	}

	[Token(Token = "0x60055B5")]
	[Address(RVA = "0xEA4D20", Offset = "0xEA3B20", Length = "0x15A")]
	private void CreateAnimatedCamera()
	{
	}

	[Token(Token = "0x60055B6")]
	[Address(RVA = "0xEA4E80", Offset = "0xEA3C80", Length = "0x6C")]
	private void MaybeSetAnimatedCameraFOV(float fov)
	{
	}

	[Token(Token = "0x60055B7")]
	[Address(RVA = "0xEA4EF0", Offset = "0xEA3CF0", Length = "0xD09")]
	private void UpdateCamera(float progress, Vector3 desiredPosition, Quaternion desiredRotation)
	{
	}

	[Token(Token = "0x60055B8")]
	[Address(RVA = "0xEA5C00", Offset = "0xEA4A00", Length = "0x50B")]
	private void UpdateCameraExit(float progress)
	{
	}

	[Token(Token = "0x60055B9")]
	[Address(RVA = "0xEA6110", Offset = "0xEA4F10", Length = "0x6C")]
	public TLD_CameraAnimationTrack()
	{
	}
}
