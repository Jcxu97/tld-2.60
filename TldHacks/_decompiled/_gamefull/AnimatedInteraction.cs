using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200053F")]
public class AnimatedInteraction : MonoBehaviour
{
	[Token(Token = "0x2000540")]
	public enum CompletionAction
	{
		[Token(Token = "0x4003084")]
		DoNothing,
		[Token(Token = "0x4003085")]
		BodyHarvest
	}

	[Token(Token = "0x2000541")]
	private enum State
	{
		[Token(Token = "0x4003087")]
		Ready,
		[Token(Token = "0x4003088")]
		LoadAnimation,
		[Token(Token = "0x4003089")]
		PlayAnimation,
		[Token(Token = "0x400308A")]
		AnimationRequested,
		[Token(Token = "0x400308B")]
		TransitionOut,
		[Token(Token = "0x400308C")]
		LoadTimeline
	}

	[Token(Token = "0x2000542")]
	public struct SaveData
	{
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0x0")]
		public string m_Guid;

		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0x8")]
		public int m_InteractionCount;
	}

	[Token(Token = "0x4003041")]
	[FieldOffset(Offset = "0x20")]
	public PlayerControlMode m_ControlMode;

	[Token(Token = "0x4003042")]
	[FieldOffset(Offset = "0x28")]
	public string m_Trigger;

	[Token(Token = "0x4003043")]
	[FieldOffset(Offset = "0x30")]
	public float m_ApproachAngle;

	[Token(Token = "0x4003044")]
	[FieldOffset(Offset = "0x34")]
	public float m_ApproachAngleAcceptableOffset;

	[Token(Token = "0x4003045")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_SyncBone;

	[Token(Token = "0x4003046")]
	[FieldOffset(Offset = "0x40")]
	public float m_Fov;

	[Token(Token = "0x4003047")]
	[FieldOffset(Offset = "0x44")]
	public float m_SecondsToSync;

	[Token(Token = "0x4003048")]
	[FieldOffset(Offset = "0x48")]
	public float m_FovSecondsToSync;

	[Token(Token = "0x4003049")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_SyncPosition;

	[Token(Token = "0x400304A")]
	[FieldOffset(Offset = "0x4D")]
	public bool m_SyncOrientation;

	[Token(Token = "0x400304B")]
	[FieldOffset(Offset = "0x4E")]
	public bool m_SyncPitchFromSyncBone;

	[Token(Token = "0x400304C")]
	[FieldOffset(Offset = "0x4F")]
	public bool m_StartAnimationAfterSync;

	[Token(Token = "0x400304D")]
	[FieldOffset(Offset = "0x50")]
	public bool m_ApplyRootOrientation;

	[Token(Token = "0x400304E")]
	[FieldOffset(Offset = "0x51")]
	public bool m_InfiniteInteractions;

	[Token(Token = "0x400304F")]
	[FieldOffset(Offset = "0x54")]
	public int m_MaxInteractionCount;

	[Token(Token = "0x4003050")]
	[FieldOffset(Offset = "0x58")]
	public bool m_HandsInWeaponSpace;

	[Token(Token = "0x4003051")]
	[FieldOffset(Offset = "0x59")]
	public bool m_PropInWeaponSpace;

	[Token(Token = "0x4003052")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_SpawnedPropPrefab;

	[Token(Token = "0x4003053")]
	[FieldOffset(Offset = "0x68")]
	public bool m_AddPropToInventoryOnComplete;

	[Token(Token = "0x4003054")]
	[FieldOffset(Offset = "0x70")]
	public GameObject[] m_AnimatedProps;

	[Token(Token = "0x4003055")]
	[FieldOffset(Offset = "0x78")]
	public LocalizedString m_LocID_Interactable;

	[Token(Token = "0x4003056")]
	[FieldOffset(Offset = "0x80")]
	public LocalizedString m_LocID_NonInteractable;

	[SerializeField]
	[EnumFlags]
	[Token(Token = "0x4003057")]
	[FieldOffset(Offset = "0x88")]
	private PlayerAnimation.AnimationLayerFlags m_AnimationLayersDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x4003058")]
	[FieldOffset(Offset = "0x8C")]
	public float m_HipAndShoulderWeight;

	[Tooltip("Use the custom Hover Text Lock/Unlock colors")]
	[Token(Token = "0x4003059")]
	[FieldOffset(Offset = "0x90")]
	public bool m_UseHoverTextColor;

	[Tooltip("Specifies if this animation can be interrupted mid-progress by other interactions e.g. being attacked")]
	[Token(Token = "0x400305A")]
	[FieldOffset(Offset = "0x91")]
	public bool m_CanBeInterrupted;

	[Token(Token = "0x400305B")]
	[FieldOffset(Offset = "0x92")]
	public bool m_OverrideNearPlane;

	[Token(Token = "0x400305C")]
	[FieldOffset(Offset = "0x94")]
	public float m_NearPlane;

	[Token(Token = "0x400305D")]
	[FieldOffset(Offset = "0x98")]
	public CompletionAction m_CompletionAction;

	[Token(Token = "0x400305E")]
	[FieldOffset(Offset = "0xA0")]
	public BodyHarvest m_BodyHarvest;

	[Token(Token = "0x400305F")]
	[FieldOffset(Offset = "0xA8")]
	public bool m_InteractionConstrained;

	[Token(Token = "0x4003060")]
	[FieldOffset(Offset = "0xAC")]
	public float m_InteractionConstrainedAngleDegrees;

	[Token(Token = "0x4003061")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_UnequipImmediate;

	[Header("Load animation")]
	[Tooltip("Enabled controller load/swap and uses FPAnimationState.")]
	[Token(Token = "0x4003062")]
	[FieldOffset(Offset = "0xB1")]
	public bool m_LoadAnimation;

	[Tooltip("Requires LoadAnimation true.")]
	[Token(Token = "0x4003063")]
	[FieldOffset(Offset = "0xB8")]
	public FPAnimationState m_FPAnimationState;

	[Header("Disable Interactions For Player State")]
	[Token(Token = "0x4003064")]
	[FieldOffset(Offset = "0xC0")]
	public float m_FatigueCost;

	[Token(Token = "0x4003065")]
	[FieldOffset(Offset = "0xC8")]
	public LocalizedString m_LocID_LowFatigueMessage;

	[Token(Token = "0x4003066")]
	[FieldOffset(Offset = "0xD0")]
	public float m_StaminaCost;

	[Token(Token = "0x4003067")]
	[FieldOffset(Offset = "0xD8")]
	public LocalizedString m_LocID_LowStaminaMessage;

	[Token(Token = "0x4003068")]
	[FieldOffset(Offset = "0xE0")]
	public AssetReferenceTimeline m_TimelineRef;

	[Token(Token = "0x4003069")]
	[FieldOffset(Offset = "0xE8")]
	public bool m_UseSyncNodeAsTimelineFPAnchor;

	[Token(Token = "0x400306A")]
	[FieldOffset(Offset = "0xF0")]
	public List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	[Tooltip("Set this string to prevent the player from interacting with this object if they have a sprained wrist")]
	[Token(Token = "0x400306B")]
	[FieldOffset(Offset = "0xF8")]
	public LocalizedString m_LocID_SprainedWristMessage;

	[Tooltip("Set this string to prevent the player from interacting with this object if they have a sprained ankle")]
	[Token(Token = "0x400306C")]
	[FieldOffset(Offset = "0x100")]
	public LocalizedString m_LocID_SprainedAnkleMessage;

	[Header("Legacy Support")]
	[Tooltip("Support for legacy animations")]
	[Token(Token = "0x400306D")]
	[FieldOffset(Offset = "0x108")]
	public bool m_UseLegacyCameraOffset;

	[Header("Radial Synchronization")]
	[Token(Token = "0x400306E")]
	[FieldOffset(Offset = "0x109")]
	public bool m_RadialSync;

	[Token(Token = "0x400306F")]
	[FieldOffset(Offset = "0x10C")]
	public float m_RadialSyncRadius;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003070")]
	[FieldOffset(Offset = "0x110")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x4003071")]
	[FieldOffset(Offset = "0x118")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvestPanel;

	[Token(Token = "0x4003072")]
	[FieldOffset(Offset = "0x120")]
	private GameObject m_SpawnedProp;

	[Token(Token = "0x4003073")]
	[FieldOffset(Offset = "0x128")]
	private int m_InteractionCount;

	[Token(Token = "0x4003074")]
	[FieldOffset(Offset = "0x12C")]
	private float m_SecondsLeftToSync;

	[Token(Token = "0x4003075")]
	[FieldOffset(Offset = "0x130")]
	private float m_SecondsLeftToTransitionOut;

	[Token(Token = "0x4003076")]
	[FieldOffset(Offset = "0x134")]
	private Vector3 m_StartPosition;

	[Token(Token = "0x4003077")]
	[FieldOffset(Offset = "0x140")]
	private float m_OriginalFov;

	[Token(Token = "0x4003078")]
	[FieldOffset(Offset = "0x144")]
	private Quaternion m_StartRotation;

	[Token(Token = "0x4003079")]
	[FieldOffset(Offset = "0x154")]
	private Quaternion m_StartCamRotation;

	[Token(Token = "0x400307A")]
	[FieldOffset(Offset = "0x168")]
	private Action m_OnAnimationCompleted;

	[Token(Token = "0x400307B")]
	[FieldOffset(Offset = "0x170")]
	private Action m_OnAnimationInterrupted;

	[Token(Token = "0x400307C")]
	[FieldOffset(Offset = "0x178")]
	private State m_State;

	[Token(Token = "0x400307D")]
	[FieldOffset(Offset = "0x17C")]
	private float m_DesiredFov;

	[Token(Token = "0x400307E")]
	[FieldOffset(Offset = "0x180")]
	private bool m_HasStartedResumingFOV;

	[Token(Token = "0x400307F")]
	private static bool s_ControlFOV;

	[Token(Token = "0x4003080")]
	private static bool s_StartResumingFOVRequested;

	[Token(Token = "0x4003081")]
	private static List<AnimatedInteraction> s_AnimatedInteractionList;

	[Token(Token = "0x4003082")]
	[FieldOffset(Offset = "0x184")]
	private Vector3 m_SyncNodeOriginalPosition;

	[Token(Token = "0x6002824")]
	[Address(RVA = "0x8BEA70", Offset = "0x8BD870", Length = "0x2B1")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0x8BED30", Offset = "0x8BDB30", Length = "0x163")]
	private void Start()
	{
	}

	[Token(Token = "0x6002826")]
	[Address(RVA = "0x8BEEA0", Offset = "0x8BDCA0", Length = "0x8A")]
	public bool CheckCompletionActionPossible()
	{
		return false;
	}

	[Token(Token = "0x6002827")]
	[Address(RVA = "0x8BEF30", Offset = "0x8BDD30", Length = "0x1EC")]
	public bool StartAnimatedInteraction(Action onAnimationCompleted, bool forceInteraction, bool shouldStowItemInHands, Action onAnimationInterrupted = null)
	{
		return false;
	}

	[Token(Token = "0x6002828")]
	[Address(RVA = "0x8BF120", Offset = "0x8BDF20", Length = "0x83")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002829")]
	[Address(RVA = "0x8BF1B0", Offset = "0x8BDFB0", Length = "0x36")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x600282A")]
	[Address(RVA = "0x8BF1F0", Offset = "0x8BDFF0", Length = "0x30F")]
	private bool CanInteract()
	{
		return false;
	}

	[Token(Token = "0x600282B")]
	[Address(RVA = "0x8BF500", Offset = "0x8BE300", Length = "0x7")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x600282C")]
	[Address(RVA = "0x8BF510", Offset = "0x8BE310", Length = "0x423")]
	private bool TryPerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x600282D")]
	[Address(RVA = "0x8BF940", Offset = "0x8BE740", Length = "0x2B3")]
	private void DoInteraction(bool shouldStowItemInHands)
	{
	}

	[Token(Token = "0x600282E")]
	[Address(RVA = "0x8BFC00", Offset = "0x8BEA00", Length = "0xD9")]
	private void Update()
	{
	}

	[Token(Token = "0x600282F")]
	[Address(RVA = "0x8BFCE0", Offset = "0x8BEAE0", Length = "0x236")]
	private void OnPlayInteractAnimation()
	{
	}

	[Token(Token = "0x6002830")]
	[Address(RVA = "0x8BFF20", Offset = "0x8BED20", Length = "0x4A2")]
	private void MaybeMoveSyncBoneToRadius()
	{
	}

	[Token(Token = "0x6002831")]
	[Address(RVA = "0x8C03D0", Offset = "0x8BF1D0", Length = "0x102")]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[Token(Token = "0x6002832")]
	[Address(RVA = "0x8C04E0", Offset = "0x8BF2E0", Length = "0x102")]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[Token(Token = "0x6002833")]
	[Address(RVA = "0x8C05F0", Offset = "0x8BF3F0", Length = "0x10E")]
	private void MaybeOverrideNearPlane()
	{
	}

	[Token(Token = "0x6002834")]
	[Address(RVA = "0x8C0700", Offset = "0x8BF500", Length = "0x107")]
	private void MaybeResetNearPlane()
	{
	}

	[Token(Token = "0x6002835")]
	[Address(RVA = "0x8C0810", Offset = "0x8BF610", Length = "0x756")]
	private void MaybePopToSync()
	{
	}

	[Token(Token = "0x6002836")]
	[Address(RVA = "0x8C0F70", Offset = "0x8BFD70", Length = "0x190")]
	private void UpdateTransitionOut()
	{
	}

	[Token(Token = "0x6002837")]
	[Address(RVA = "0x8C1110", Offset = "0x8BFF10", Length = "0xED")]
	private void MaybeSetCameraFov()
	{
	}

	[Token(Token = "0x6002838")]
	[Address(RVA = "0x8C1200", Offset = "0x8C0000", Length = "0x208")]
	private void MaybeResumeFov()
	{
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x8C1410", Offset = "0x8C0210", Length = "0x752")]
	private void MaybeBlendToSyncBone()
	{
	}

	[Token(Token = "0x600283A")]
	[Address(RVA = "0x8C1B70", Offset = "0x8C0970", Length = "0x685")]
	private void MaybeSpawnProp()
	{
	}

	[Token(Token = "0x600283B")]
	[Address(RVA = "0x8C2200", Offset = "0x8C1000", Length = "0x17F")]
	private void OnTimelineLoaded(AssetReferenceTimeline result)
	{
	}

	[Token(Token = "0x600283C")]
	[Address(RVA = "0x8C2380", Offset = "0x8C1180", Length = "0x169")]
	private void Interrupt()
	{
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0x8C24F0", Offset = "0x8C12F0", Length = "0x67")]
	private void StopTimeline()
	{
	}

	[Token(Token = "0x600283E")]
	[Address(RVA = "0x8C2560", Offset = "0x8C1360", Length = "0x245")]
	private void MaybeTriggerAnimation()
	{
	}

	[Token(Token = "0x600283F")]
	[Address(RVA = "0x8C27B0", Offset = "0x8C15B0", Length = "0x9C")]
	private void OnEnterPlaying(bool success)
	{
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0x8C2850", Offset = "0x8C1650", Length = "0x501")]
	private void DoTriggerAnimation()
	{
	}

	[Token(Token = "0x6002841")]
	[Address(RVA = "0x8C2D60", Offset = "0x8C1B60", Length = "0x1AF")]
	public Animator GetAnimator(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x6002842")]
	[Address(RVA = "0x8C2F10", Offset = "0x8C1D10", Length = "0x68A")]
	private void MaybeAddSpawnedPropToInventory()
	{
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0x8C35A0", Offset = "0x8C23A0", Length = "0x17")]
	private float GetFovTransitionDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0x8C35C0", Offset = "0x8C23C0", Length = "0xFD")]
	private void OnInteractionComplete()
	{
	}

	[Token(Token = "0x6002845")]
	[Address(RVA = "0x8C36C0", Offset = "0x8C24C0", Length = "0x80A")]
	private void DoOnInteractionComplete()
	{
	}

	[Token(Token = "0x6002846")]
	[Address(RVA = "0x8C3ED0", Offset = "0x8C2CD0", Length = "0x284")]
	public bool RespectContrainsts()
	{
		return false;
	}

	[Token(Token = "0x6002847")]
	[Address(RVA = "0x8C4160", Offset = "0x8C2F60", Length = "0x10D")]
	private void MaybePerformCompletionAction()
	{
	}

	[Token(Token = "0x6002848")]
	[Address(RVA = "0x8C4270", Offset = "0x8C3070", Length = "0xFF")]
	private void DoBodyHarvest()
	{
	}

	[Token(Token = "0x6002849")]
	[Address(RVA = "0x8C4370", Offset = "0x8C3170", Length = "0x111")]
	private void AddSyncNodeTimelineOverride()
	{
	}

	[Token(Token = "0x600284A")]
	[Address(RVA = "0x8C4490", Offset = "0x8C3290", Length = "0x53")]
	public static bool IsFovControlled()
	{
		return false;
	}

	[Token(Token = "0x600284B")]
	[Address(RVA = "0x8C44F0", Offset = "0x8C32F0", Length = "0x54")]
	public static void StartResumingFov()
	{
	}

	[Token(Token = "0x600284C")]
	[Address(RVA = "0x8C4550", Offset = "0x8C3350", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600284D")]
	[Address(RVA = "0x8C45F0", Offset = "0x8C33F0", Length = "0x227")]
	public static bool InProgress()
	{
		return false;
	}

	[Token(Token = "0x600284E")]
	[Address(RVA = "0x8C4820", Offset = "0x8C3620", Length = "0x234")]
	public static bool IsPlayingNonInterruptableAnimation()
	{
		return false;
	}

	[Token(Token = "0x600284F")]
	[Address(RVA = "0x8C4A60", Offset = "0x8C3860", Length = "0x23F")]
	public static bool InterruptAnyInProgressAnimations()
	{
		return false;
	}

	[Token(Token = "0x6002850")]
	[Address(RVA = "0x8C4CA0", Offset = "0x8C3AA0", Length = "0x2E0")]
	public static void DeserializeAll(string serialized)
	{
	}

	[Token(Token = "0x6002851")]
	[Address(RVA = "0x8C4F90", Offset = "0x8C3D90", Length = "0x3D3")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002852")]
	[Address(RVA = "0x8C5370", Offset = "0x8C4170", Length = "0x10E")]
	public AnimatedInteraction()
	{
	}
}
