using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200089F")]
public class PlayerAnimation : MonoBehaviour
{
	[Token(Token = "0x20008A0")]
	public class SerializedParams
	{
		[Token(Token = "0x40059BA")]
		[FieldOffset(Offset = "0x10")]
		public bool m_EnableFirstPersonHands;

		[Token(Token = "0x40059BB")]
		[FieldOffset(Offset = "0x18")]
		public string m_HandMeshState;

		[Token(Token = "0x40059BC")]
		[FieldOffset(Offset = "0x20")]
		public bool m_FirstPersonHandsHidden;

		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SerializedParams()
		{
		}
	}

	[Flags]
	[Token(Token = "0x20008A1")]
	public enum AnimationLayerFlags
	{
		[Token(Token = "0x40059BE")]
		Hip = 1,
		[Token(Token = "0x40059BF")]
		Shoulder = 2
	}

	[Token(Token = "0x20008A2")]
	public delegate void OnAnimationEvent();

	[Token(Token = "0x20008A3")]
	public enum CameraLayer
	{
		[Token(Token = "0x40059C1")]
		Weapon,
		[Token(Token = "0x40059C2")]
		World
	}

	[Token(Token = "0x20008A4")]
	public enum CameraBasedHandPositioningMode
	{
		[Token(Token = "0x40059C4")]
		Standard,
		[Token(Token = "0x40059C5")]
		Aiming,
		[Token(Token = "0x40059C6")]
		Frozen,
		[Token(Token = "0x40059C7")]
		None,
		[Token(Token = "0x40059C8")]
		Timeline
	}

	[Token(Token = "0x20008A5")]
	public enum State
	{
		[Token(Token = "0x40059CA")]
		Hidden,
		[Token(Token = "0x40059CB")]
		ToAiming,
		[Token(Token = "0x40059CC")]
		Aiming,
		[Token(Token = "0x40059CD")]
		FromAiming,
		[Token(Token = "0x40059CE")]
		Equipping,
		[Token(Token = "0x40059CF")]
		Showing,
		[Token(Token = "0x40059D0")]
		Dequipping,
		[Token(Token = "0x40059D1")]
		Brandishing,
		[Token(Token = "0x40059D2")]
		Igniting,
		[Token(Token = "0x40059D3")]
		Stowing,
		[Token(Token = "0x40059D4")]
		Stowed,
		[Token(Token = "0x40059D5")]
		Unstowing,
		[Token(Token = "0x40059D6")]
		Extinguishing,
		[Token(Token = "0x40059D7")]
		PickingUp,
		[Token(Token = "0x40059D8")]
		Placing,
		[Token(Token = "0x40059D9")]
		Firing,
		[Token(Token = "0x40059DA")]
		Reloading,
		[Token(Token = "0x40059DB")]
		Using,
		[Token(Token = "0x40059DC")]
		LookAround,
		[Token(Token = "0x40059DD")]
		AnimatedInteraction,
		[Token(Token = "0x40059DE")]
		Throwing,
		[Token(Token = "0x40059DF")]
		Killing,
		[Token(Token = "0x40059E0")]
		Spray,
		[Token(Token = "0x40059E1")]
		Explode
	}

	[Flags]
	[Token(Token = "0x20008A6")]
	public enum StateFlags
	{
		[Token(Token = "0x40059E3")]
		Hidden = 1,
		[Token(Token = "0x40059E4")]
		ToAiming = 2,
		[Token(Token = "0x40059E5")]
		Aiming = 4,
		[Token(Token = "0x40059E6")]
		FromAiming = 8,
		[Token(Token = "0x40059E7")]
		Equipping = 0x10,
		[Token(Token = "0x40059E8")]
		Showing = 0x20,
		[Token(Token = "0x40059E9")]
		Dequipping = 0x40,
		[Token(Token = "0x40059EA")]
		Brandishing = 0x80,
		[Token(Token = "0x40059EB")]
		Igniting = 0x100,
		[Token(Token = "0x40059EC")]
		Stowing = 0x200,
		[Token(Token = "0x40059ED")]
		Stowed = 0x400,
		[Token(Token = "0x40059EE")]
		Unstowing = 0x800,
		[Token(Token = "0x40059EF")]
		Extinguishing = 0x1000,
		[Token(Token = "0x40059F0")]
		PickingUp = 0x2000,
		[Token(Token = "0x40059F1")]
		Placing = 0x4000,
		[Token(Token = "0x40059F2")]
		Firing = 0x8000,
		[Token(Token = "0x40059F3")]
		Reloading = 0x10000,
		[Token(Token = "0x40059F4")]
		Using = 0x20000,
		[Token(Token = "0x40059F5")]
		LookAround = 0x40000,
		[Token(Token = "0x40059F6")]
		AnimatedInteraction = 0x80000,
		[Token(Token = "0x40059F7")]
		Throwing = 0x100000,
		[Token(Token = "0x40059F8")]
		Killing = 0x200000,
		[Token(Token = "0x40059F9")]
		Spray = 0x400000,
		[Token(Token = "0x40059FA")]
		Explode = 0x800000
	}

	[Token(Token = "0x20008A7")]
	public enum AnimationCallbackEvent
	{
		[Token(Token = "0x40059FC")]
		DoNothing,
		[Token(Token = "0x40059FD")]
		AnimatedInteractionComplete,
		[Token(Token = "0x40059FE")]
		Brandish_Begin,
		[Token(Token = "0x40059FF")]
		Brandish_Complete,
		[Token(Token = "0x4005A00")]
		Brandish_MidSwing,
		[Token(Token = "0x4005A01")]
		Generic_Aim_Complete,
		[Token(Token = "0x4005A02")]
		Generic_Aim_Cancel_Complete,
		[Token(Token = "0x4005A03")]
		Generic_Equip_ShowItem,
		[Token(Token = "0x4005A04")]
		Generic_Equipped_Complete,
		[Token(Token = "0x4005A05")]
		Generic_Fire_FX,
		[Token(Token = "0x4005A06")]
		Generic_Fire_Complete,
		[Token(Token = "0x4005A07")]
		Generic_Hidden,
		[Token(Token = "0x4005A08")]
		Generic_Hidden_Complete,
		[Token(Token = "0x4005A09")]
		Generic_Stow_Complete,
		[Token(Token = "0x4005A0A")]
		Generic_Unstow_Complete,
		[Token(Token = "0x4005A0B")]
		Generic_Ignite_FX,
		[Token(Token = "0x4005A0C")]
		Generic_Ignite_Complete,
		[Token(Token = "0x4005A0D")]
		Generic_Extinguish_FX,
		[Token(Token = "0x4005A0E")]
		Generic_Extinguish_Complete,
		[Token(Token = "0x4005A0F")]
		Generic_LookAround_Complete,
		[Token(Token = "0x4005A10")]
		Generic_PlacementMode_PlaceItem_SpawnItemInWorld,
		[Token(Token = "0x4005A11")]
		Generic_PlacementMode_PlaceItem_HideItemInHands,
		[Token(Token = "0x4005A12")]
		Generic_PlacementMode_PlaceItem_Complete,
		[Token(Token = "0x4005A13")]
		Generic_Reload_RoundLoaded,
		[Token(Token = "0x4005A14")]
		Generic_Reload_ClipLoaded,
		[Token(Token = "0x4005A15")]
		Generic_Reload_Complete,
		[Token(Token = "0x4005A16")]
		Generic_Throw_ReleaseItem,
		[Token(Token = "0x4005A17")]
		Generic_Use_Now,
		[Token(Token = "0x4005A18")]
		Generic_Use_Complete,
		[Token(Token = "0x4005A19")]
		Struggle_GetUp_Complete,
		[Token(Token = "0x4005A1A")]
		Struggle_Play_MauledMuffled,
		[Token(Token = "0x4005A1B")]
		Struggle_Stop_MauledMuffled,
		[Token(Token = "0x4005A1C")]
		PlayerStunned_Begin,
		[Token(Token = "0x4005A1D")]
		StartResumingFov,
		[Token(Token = "0x4005A1E")]
		Generic_Reload_RoundsUnloaded,
		[Token(Token = "0x4005A1F")]
		Generic_Reload_ShowReloadBulletInstance,
		[Token(Token = "0x4005A20")]
		Struggle_Revolver_Fire,
		[Token(Token = "0x4005A21")]
		Struggle_Revolver_Fire_Complete,
		[Token(Token = "0x4005A22")]
		Discharge_Shell_Event,
		[Token(Token = "0x4005A23")]
		Spray_Complete,
		[Token(Token = "0x4005A24")]
		Erase_Paint_Complete,
		[Token(Token = "0x4005A25")]
		NoiseMaker_Explode_In_Hand_Complete
	}

	[Token(Token = "0x20008A8")]
	private class AnimationCallbackDictionary<T> : Dictionary<AnimationCallbackEvent, T>
	{
		[Token(Token = "0x20008A9")]
		private class AnimationCallbackEventComparer : IEqualityComparer<AnimationCallbackEvent>
		{
			[Token(Token = "0x4005A26")]
			public static readonly AnimationCallbackEventComparer s_Comparer;

			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			private AnimationCallbackEventComparer()
			{
			}

			[Token(Token = "0x6004FD0")]
			[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return false;
			}

			[Token(Token = "0x6004FD1")]
			[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
			public int GetHashCode(AnimationCallbackEvent animationCallbackEvent)
			{
				return 0;
			}
		}

		[Token(Token = "0x6004FCE")]
		[Address(RVA = "0x25BBBB0", Offset = "0x25BA9B0", Length = "0x8C")]
		public AnimationCallbackDictionary()
		{
		}
	}

	[Token(Token = "0x20008AA")]
	private class AnimatorParametersCache
	{
		[Token(Token = "0x4005A27")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Animator, Dictionary<int, bool>> m_ParametersCache;

		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0xDD3230", Offset = "0xDD2030", Length = "0x201")]
		public Dictionary<int, bool> RefreshCache(Animator animator)
		{
			return null;
		}

		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0xDD3440", Offset = "0xDD2240", Length = "0x49")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0xDD3490", Offset = "0xDD2290", Length = "0x104")]
		public bool DoesParameterExists(Animator animator, int paramHash)
		{
			return false;
		}

		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0xDD35A0", Offset = "0xDD23A0", Length = "0xAD")]
		public AnimatorParametersCache()
		{
		}
	}

	[Token(Token = "0x40058EB")]
	[FieldOffset(Offset = "0x20")]
	public bool m_EnableAnimationDrivenViewBob;

	[Token(Token = "0x40058EC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_Root;

	[Token(Token = "0x40058ED")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_WorldSpaceView;

	[Token(Token = "0x40058EE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_WeaponSpaceView;

	[Token(Token = "0x40058EF")]
	[FieldOffset(Offset = "0x40")]
	public ClothingSpawner m_ClothingSpawner;

	[Token(Token = "0x40058F0")]
	[FieldOffset(Offset = "0x48")]
	public SerializedParams m_SerializedParams;

	[Token(Token = "0x40058F1")]
	[FieldOffset(Offset = "0x50")]
	public Camera m_WeaponCamera;

	[Token(Token = "0x40058F2")]
	[FieldOffset(Offset = "0x58")]
	public Camera m_InspectCamera;

	[Token(Token = "0x40058F3")]
	[FieldOffset(Offset = "0x60")]
	public float m_WeaponCameraFOV;

	[Token(Token = "0x40058F4")]
	[FieldOffset(Offset = "0x64")]
	public float m_InspectCameraFOV;

	[Token(Token = "0x40058F5")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_CameraSpaceObject;

	[Token(Token = "0x40058F6")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_CameraBone;

	[Token(Token = "0x40058F7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_CameraFOV;

	[Token(Token = "0x40058F8")]
	[FieldOffset(Offset = "0x80")]
	public bool m_DebugOverrideCameraFov;

	[Token(Token = "0x40058F9")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 m_OverrideCameraFOV;

	[Range(0f, 10f)]
	[Token(Token = "0x40058FA")]
	[FieldOffset(Offset = "0x90")]
	public float m_MaxBlurSize;

	[Token(Token = "0x40058FB")]
	[FieldOffset(Offset = "0x98")]
	public Animator m_Animator;

	[Token(Token = "0x40058FC")]
	[FieldOffset(Offset = "0xA0")]
	public StruggleMeshTable m_StruggleMeshTable;

	[Token(Token = "0x40058FD")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_FPMesh_MaleHands;

	[Token(Token = "0x40058FE")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_FPMesh_FemaleHands;

	[Token(Token = "0x40058FF")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject[] m_ClothingItems;

	[Token(Token = "0x4005900")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject[] m_ActiveTorsoClothing;

	[Token(Token = "0x4005901")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject[] m_ActiveHandsClothing;

	[Token(Token = "0x4005902")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject[] m_ActiveStoryTorsoClothing;

	[Token(Token = "0x4005903")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject[] m_ActiveStoryHandsClothing;

	[Token(Token = "0x4005904")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_RightPropPoint;

	[Token(Token = "0x4005905")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_LeftPropPoint;

	[Token(Token = "0x4005906")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_ShoulderPropPoint;

	[Token(Token = "0x4005907")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_ArrowSpawnPropPoint;

	[Token(Token = "0x4005908")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_ArrowFirePropPoint;

	[Token(Token = "0x4005909")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_ShoulderJoint;

	[Token(Token = "0x400590A")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_CameraWeaponOffset;

	[Token(Token = "0x400590B")]
	[FieldOffset(Offset = "0x118")]
	public GameObject m_GAMEDATA;

	[Token(Token = "0x400590C")]
	[FieldOffset(Offset = "0x120")]
	public float m_LookDegreesPerSecond;

	[Token(Token = "0x400590D")]
	[FieldOffset(Offset = "0x124")]
	public CameraBasedHandPositioningMode m_CameraBasedHandPositioningMode;

	[Token(Token = "0x400590E")]
	[FieldOffset(Offset = "0x128")]
	public bool m_DisableCameraTracking;

	[Token(Token = "0x400590F")]
	[FieldOffset(Offset = "0x130")]
	public CameraBasedJointPositioning m_CameraTracking_Standard;

	[Token(Token = "0x4005910")]
	[FieldOffset(Offset = "0x138")]
	public CameraBasedJointPositioning m_CameraTracking_Aiming;

	[Token(Token = "0x4005911")]
	[FieldOffset(Offset = "0x140")]
	public CameraBasedJointPositioning m_CameraTracking_None;

	[Token(Token = "0x4005912")]
	[FieldOffset(Offset = "0x148")]
	public CameraBasedJointPositioning m_CameraTracking_Timeline;

	[Range(0f, 3f)]
	[Token(Token = "0x4005913")]
	[FieldOffset(Offset = "0x150")]
	public float m_DampedVelocitySeconds;

	[Range(0f, 3f)]
	[Token(Token = "0x4005914")]
	[FieldOffset(Offset = "0x154")]
	public float m_CameraMoveDampSpeed;

	[Token(Token = "0x4005915")]
	[FieldOffset(Offset = "0x158")]
	public HeldItemInPlacementZone m_PlayerHeldItemPlacementZone;

	[Header("Cougar Path Points")]
	[Token(Token = "0x4005916")]
	[FieldOffset(Offset = "0x160")]
	public GameObject m_CougarPathStartPoint;

	[Token(Token = "0x4005917")]
	[FieldOffset(Offset = "0x168")]
	public GameObject m_CougarPathEndPoint;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4005918")]
	[FieldOffset(Offset = "0x170")]
	private PanelReference<Panel_HUD> m_HUD;

	[NonSerialized]
	[Token(Token = "0x4005919")]
	[FieldOffset(Offset = "0x178")]
	public bool m_CameraRelativeToHands;

	[Token(Token = "0x400591A")]
	[FieldOffset(Offset = "0x17C")]
	private int m_FingersLayerIndex;

	[Token(Token = "0x400591B")]
	[FieldOffset(Offset = "0x180")]
	private int m_HipLayerIndex;

	[Token(Token = "0x400591C")]
	[FieldOffset(Offset = "0x184")]
	private int m_ShoulderOffsetLayerIndex;

	[Token(Token = "0x400591D")]
	[FieldOffset(Offset = "0x188")]
	private bool m_ItemEquippedByPlayer;

	[Token(Token = "0x400591E")]
	public const AnimationLayerFlags DEFAULT_INTERACT_DISABLED_LAYERS = AnimationLayerFlags.Hip | AnimationLayerFlags.Shoulder;

	[Token(Token = "0x400591F")]
	public static readonly int NumStates;

	[Token(Token = "0x4005920")]
	[FieldOffset(Offset = "0x190")]
	private PlayerStateTransitions m_PlayerStateTransitions;

	[Token(Token = "0x4005921")]
	[FieldOffset(Offset = "0x198")]
	private GameObject m_HandsMesh;

	[Token(Token = "0x4005922")]
	[FieldOffset(Offset = "0x1A0")]
	private GameObject m_EnabledWeapon;

	[Token(Token = "0x4005923")]
	[FieldOffset(Offset = "0x1A8")]
	private List<Animator> m_GlobalAnimators;

	[Token(Token = "0x4005924")]
	[FieldOffset(Offset = "0x1B0")]
	private readonly AnimationCallbackDictionary<OnAnimationEvent> m_AnimationEventDictionary;

	[Token(Token = "0x4005925")]
	[FieldOffset(Offset = "0x1B8")]
	private FirstPersonWeapon m_EquippedFirstPersonWeaponRightHand;

	[Token(Token = "0x4005926")]
	[FieldOffset(Offset = "0x1C0")]
	private FirstPersonWeapon m_EquippedFirstPersonWeaponLeftHand;

	[Token(Token = "0x4005927")]
	[FieldOffset(Offset = "0x1C8")]
	private FirstPersonWeapon m_EquippedFirstPersonWeaponShoulder;

	[Token(Token = "0x4005928")]
	[FieldOffset(Offset = "0x1D0")]
	private Vector3 m_LookAtTarget;

	[Token(Token = "0x4005929")]
	[FieldOffset(Offset = "0x1DC")]
	private Vector2 m_StartCameraAngles;

	[Token(Token = "0x400592A")]
	[FieldOffset(Offset = "0x1E4")]
	private bool m_LookAtActive;

	[Token(Token = "0x400592B")]
	[FieldOffset(Offset = "0x1E5")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400592C")]
	[FieldOffset(Offset = "0x1E8")]
	private State m_State;

	[Token(Token = "0x400592D")]
	[FieldOffset(Offset = "0x1EC")]
	private State m_PriorState;

	[Token(Token = "0x400592E")]
	[FieldOffset(Offset = "0x1F0")]
	private Vector3[] m_LastVelocities;

	[Token(Token = "0x400592F")]
	[FieldOffset(Offset = "0x1F8")]
	private float[] m_LastVelocitiesTimestamps;

	[Token(Token = "0x4005930")]
	[FieldOffset(Offset = "0x200")]
	private int m_DampedVelocityIndex;

	[Token(Token = "0x4005931")]
	[FieldOffset(Offset = "0x208")]
	private OnAnimationEvent m_AnimationEvent_Generic_Aim_Complete;

	[Token(Token = "0x4005932")]
	[FieldOffset(Offset = "0x210")]
	private OnAnimationEvent m_AnimationEvent_Generic_Aim_Cancel_Complete;

	[Token(Token = "0x4005933")]
	[FieldOffset(Offset = "0x218")]
	private OnAnimationEvent m_AnimationEvent_Generic_AnimatedInteractionComplete;

	[Token(Token = "0x4005934")]
	[FieldOffset(Offset = "0x220")]
	private OnAnimationEvent m_AnimationEvent_Generic_BrandishBegin;

	[Token(Token = "0x4005935")]
	[FieldOffset(Offset = "0x228")]
	private OnAnimationEvent m_AnimationEvent_Generic_BrandishMidSwing;

	[Token(Token = "0x4005936")]
	[FieldOffset(Offset = "0x230")]
	private OnAnimationEvent m_AnimationEvent_Generic_Ignite;

	[Token(Token = "0x4005937")]
	[FieldOffset(Offset = "0x238")]
	private OnAnimationEvent m_AnimationEvent_Generic_IgniteComplete;

	[Token(Token = "0x4005938")]
	[FieldOffset(Offset = "0x240")]
	private OnAnimationEvent m_AnimationEvent_Generic_Equip_ShowItem;

	[Token(Token = "0x4005939")]
	[FieldOffset(Offset = "0x248")]
	private OnAnimationEvent m_AnimationEvent_Generic_Equip_Complete;

	[Token(Token = "0x400593A")]
	[FieldOffset(Offset = "0x250")]
	private OnAnimationEvent m_AnimationEvent_Generic_Fire_FX;

	[Token(Token = "0x400593B")]
	[FieldOffset(Offset = "0x258")]
	private OnAnimationEvent m_AnimationEvent_Generic_Fire_Complete;

	[Token(Token = "0x400593C")]
	[FieldOffset(Offset = "0x260")]
	private OnAnimationEvent m_AnimationEvent_Generic_Hidden;

	[Token(Token = "0x400593D")]
	[FieldOffset(Offset = "0x268")]
	private OnAnimationEvent m_AnimationEvent_Generic_HiddenComplete;

	[Token(Token = "0x400593E")]
	[FieldOffset(Offset = "0x270")]
	private OnAnimationEvent m_AnimationEvent_Generic_ExtinguishFX;

	[Token(Token = "0x400593F")]
	[FieldOffset(Offset = "0x278")]
	private OnAnimationEvent m_AnimationEvent_Generic_PlacementMode_PlaceItem;

	[Token(Token = "0x4005940")]
	[FieldOffset(Offset = "0x280")]
	private OnAnimationEvent m_AnimationEvent_Generic_PlacementMode_PlaceComplete;

	[Token(Token = "0x4005941")]
	[FieldOffset(Offset = "0x288")]
	private OnAnimationEvent m_AnimationEvent_Generic_RoundLoaded;

	[Token(Token = "0x4005942")]
	[FieldOffset(Offset = "0x290")]
	private OnAnimationEvent m_AnimationEvent_Generic_ClipLoaded;

	[Token(Token = "0x4005943")]
	[FieldOffset(Offset = "0x298")]
	private OnAnimationEvent m_AnimationEvent_Generic_RoundsUnloaded;

	[Token(Token = "0x4005944")]
	[FieldOffset(Offset = "0x2A0")]
	private OnAnimationEvent m_AnimationEvent_Generic_ReloadComplete;

	[Token(Token = "0x4005945")]
	[FieldOffset(Offset = "0x2A8")]
	private OnAnimationEvent m_AnimationEvent_Generic_Throw_ReleaseItem;

	[Token(Token = "0x4005946")]
	[FieldOffset(Offset = "0x2B0")]
	private OnAnimationEvent m_AnimationEvent_Generic_UseNow;

	[Token(Token = "0x4005947")]
	[FieldOffset(Offset = "0x2B8")]
	private OnAnimationEvent m_AnimationEvent_Generic_UseComplete;

	[Token(Token = "0x4005948")]
	[FieldOffset(Offset = "0x2C0")]
	private OnAnimationEvent m_AnimationEvent_Generic_StruggleRevolverFired;

	[Token(Token = "0x4005949")]
	[FieldOffset(Offset = "0x2C8")]
	private OnAnimationEvent m_AnimationEvent_Generic_StruggleRevolverFiredComplete;

	[Token(Token = "0x400594A")]
	[FieldOffset(Offset = "0x2D0")]
	private OnAnimationEvent m_AnimationEvent_Spray_Complete;

	[Token(Token = "0x400594B")]
	[FieldOffset(Offset = "0x2D8")]
	private OnAnimationEvent m_AnimationEvent_Erase_Paint_Complete;

	[Token(Token = "0x400594C")]
	[FieldOffset(Offset = "0x2E0")]
	private OnAnimationEvent m_AnimationEvent_NoiseMaker_Explode_In_Hand_Complete;

	[Token(Token = "0x400594D")]
	[FieldOffset(Offset = "0x2E8")]
	private int m_AnimParameter_CameraPitch;

	[Token(Token = "0x400594E")]
	[FieldOffset(Offset = "0x2EC")]
	private int m_AnimParameter_HasUnloadedAmmo;

	[Token(Token = "0x400594F")]
	[FieldOffset(Offset = "0x2F0")]
	private int m_AnimParameter_IsAiming;

	[Token(Token = "0x4005950")]
	[FieldOffset(Offset = "0x2F4")]
	private int m_AnimParameter_IsBurnedOut;

	[Token(Token = "0x4005951")]
	[FieldOffset(Offset = "0x2F8")]
	private int m_AnimParameter_IsEquipped;

	[Token(Token = "0x4005952")]
	[FieldOffset(Offset = "0x2FC")]
	private int m_AnimParameter_IsJammed;

	[Token(Token = "0x4005953")]
	[FieldOffset(Offset = "0x300")]
	private int m_AnimParameter_IsLightSource;

	[Token(Token = "0x4005954")]
	[FieldOffset(Offset = "0x304")]
	private int m_AnimParameter_Is_Limping_Left;

	[Token(Token = "0x4005955")]
	[FieldOffset(Offset = "0x308")]
	private int m_AnimParameter_Is_Limping_Right;

	[Token(Token = "0x4005956")]
	[FieldOffset(Offset = "0x30C")]
	private int m_AnimParameter_Is_Climbing;

	[Token(Token = "0x4005957")]
	[FieldOffset(Offset = "0x310")]
	private int m_AnimParameter_IsLoaded;

	[Token(Token = "0x4005958")]
	[FieldOffset(Offset = "0x314")]
	private int m_AnimParameter_IsTravois;

	[Token(Token = "0x4005959")]
	[FieldOffset(Offset = "0x318")]
	private int m_AnimParameter_IsWeapon;

	[Token(Token = "0x400595A")]
	[FieldOffset(Offset = "0x31C")]
	private int m_AnimParameter_Lightsource_IgniterIsFire;

	[Token(Token = "0x400595B")]
	[FieldOffset(Offset = "0x320")]
	private int m_AnimParameter_Lightsource_Lit;

	[Token(Token = "0x400595C")]
	[FieldOffset(Offset = "0x324")]
	private int m_AnimParameter_MovementForward;

	[Token(Token = "0x400595D")]
	[FieldOffset(Offset = "0x328")]
	private int m_AnimParameter_MovementForwardDamped;

	[Token(Token = "0x400595E")]
	[FieldOffset(Offset = "0x32C")]
	private int m_AnimParameter_MovementSideways;

	[Token(Token = "0x400595F")]
	[FieldOffset(Offset = "0x330")]
	private int m_AnimParameter_MovementSidewaysDamped;

	[Token(Token = "0x4005960")]
	[FieldOffset(Offset = "0x334")]
	private int m_AnimParameter_MovementSpeed;

	[Token(Token = "0x4005961")]
	[FieldOffset(Offset = "0x338")]
	private int m_AnimParameter_MovementInput;

	[Token(Token = "0x4005962")]
	[FieldOffset(Offset = "0x33C")]
	private int m_AnimParameter_ReloadCount;

	[Token(Token = "0x4005963")]
	[FieldOffset(Offset = "0x340")]
	private int m_AnimParameter_RoundsLoaded;

	[Token(Token = "0x4005964")]
	[FieldOffset(Offset = "0x344")]
	private int m_AnimParameter_SprintInput;

	[Token(Token = "0x4005965")]
	[FieldOffset(Offset = "0x348")]
	private int m_AnimParameter_Stamina;

	[Token(Token = "0x4005966")]
	[FieldOffset(Offset = "0x34C")]
	private int m_AnimParameter_StumbleId;

	[Token(Token = "0x4005967")]
	[FieldOffset(Offset = "0x350")]
	private int m_AnimParameter_Trigger_Breakdown_Intro;

	[Token(Token = "0x4005968")]
	[FieldOffset(Offset = "0x354")]
	private int m_AnimParameter_Trigger_Breakdown_Cancel;

	[Token(Token = "0x4005969")]
	[FieldOffset(Offset = "0x358")]
	private int m_AnimParameter_Trigger_Breakdown_StartLoop;

	[Token(Token = "0x400596A")]
	[FieldOffset(Offset = "0x35C")]
	private int m_AnimParameter_Trigger_Breakdown_ExitLoop;

	[Token(Token = "0x400596B")]
	[FieldOffset(Offset = "0x360")]
	private int m_AnimParameter_Trigger_Generic_Aim;

	[Token(Token = "0x400596C")]
	[FieldOffset(Offset = "0x364")]
	private int m_AnimParameter_Trigger_Generic_Aim_Cancel;

	[Token(Token = "0x400596D")]
	[FieldOffset(Offset = "0x368")]
	private int m_AnimParameter_Trigger_Generic_Brandish;

	[Token(Token = "0x400596E")]
	[FieldOffset(Offset = "0x36C")]
	private int m_AnimParameter_Trigger_Generic_Equip;

	[Token(Token = "0x400596F")]
	[FieldOffset(Offset = "0x370")]
	private int m_AnimParameter_Trigger_Generic_Equip_Immediate;

	[Token(Token = "0x4005970")]
	[FieldOffset(Offset = "0x374")]
	private int m_AnimParameter_Trigger_Generic_Extinguish;

	[Token(Token = "0x4005971")]
	[FieldOffset(Offset = "0x378")]
	private int m_AnimParameter_Trigger_Generic_Extinguish_Cancel;

	[Token(Token = "0x4005972")]
	[FieldOffset(Offset = "0x37C")]
	private int m_AnimParameter_Trigger_Generic_Fire;

	[Token(Token = "0x4005973")]
	[FieldOffset(Offset = "0x380")]
	private int m_AnimParameter_Trigger_Generic_Hip_Fire;

	[Token(Token = "0x4005974")]
	[FieldOffset(Offset = "0x384")]
	private int m_AnimParameter_Trigger_Generic_Ignite;

	[Token(Token = "0x4005975")]
	[FieldOffset(Offset = "0x388")]
	private int m_AnimParameter_Trigger_Generic_Ignite_Confirm;

	[Token(Token = "0x4005976")]
	[FieldOffset(Offset = "0x38C")]
	private int m_AnimParameter_Trigger_Generic_Ignite_Cancel;

	[Token(Token = "0x4005977")]
	[FieldOffset(Offset = "0x390")]
	private int m_AnimParameter_Trigger_Generic_Kill;

	[Token(Token = "0x4005978")]
	[FieldOffset(Offset = "0x394")]
	private int m_AnimParameter_Trigger_Generic_PlacementMode_Pickup;

	[Token(Token = "0x4005979")]
	[FieldOffset(Offset = "0x398")]
	private int m_AnimParameter_Trigger_Generic_PlacementMode_Place;

	[Token(Token = "0x400597A")]
	[FieldOffset(Offset = "0x39C")]
	private int m_AnimParameter_Trigger_Generic_Reload_Single;

	[Token(Token = "0x400597B")]
	[FieldOffset(Offset = "0x3A0")]
	private int m_AnimParameter_Trigger_Generic_Stow;

	[Token(Token = "0x400597C")]
	[FieldOffset(Offset = "0x3A4")]
	private int m_AnimParameter_Trigger_Generic_Throw;

	[Token(Token = "0x400597D")]
	[FieldOffset(Offset = "0x3A8")]
	private int m_AnimParameter_Trigger_Generic_Unstow;

	[Token(Token = "0x400597E")]
	[FieldOffset(Offset = "0x3AC")]
	private int m_AnimParameter_Trigger_Generic_Unequip;

	[Token(Token = "0x400597F")]
	[FieldOffset(Offset = "0x3B0")]
	private int m_AnimParameter_Trigger_Limp;

	[Token(Token = "0x4005980")]
	[FieldOffset(Offset = "0x3B4")]
	private int m_AnimParameter_Trigger_Struggle_Start;

	[Token(Token = "0x4005981")]
	[FieldOffset(Offset = "0x3B8")]
	private int m_AnimParameter_Trigger_Struggle_End;

	[Token(Token = "0x4005982")]
	[FieldOffset(Offset = "0x3BC")]
	private int m_AnimParameter_Trigger_Stumble;

	[Token(Token = "0x4005983")]
	[FieldOffset(Offset = "0x3C0")]
	private int m_AnimParameter_Trigger_Generic_Use;

	[Token(Token = "0x4005984")]
	[FieldOffset(Offset = "0x3C4")]
	private int m_AnimParameter_WeaponId;

	[Token(Token = "0x4005985")]
	[FieldOffset(Offset = "0x3C8")]
	private int m_AnimParameter_WeaponId_Float;

	[Token(Token = "0x4005986")]
	[FieldOffset(Offset = "0x3CC")]
	private int m_AnimParameter_WeaponFatigue;

	[Token(Token = "0x4005987")]
	[FieldOffset(Offset = "0x3D0")]
	private int m_AnimParameter_WildlifeId;

	[Token(Token = "0x4005988")]
	[FieldOffset(Offset = "0x3D4")]
	private int m_AnimParameter_SetSpearMultiplier;

	[Token(Token = "0x4005989")]
	[FieldOffset(Offset = "0x3D8")]
	private int m_AnimParameter_RecoverSpearMultiplier;

	[Token(Token = "0x400598A")]
	[FieldOffset(Offset = "0x3DC")]
	private int m_AnimParameter_PlaybackSpeedMultiplier;

	[Token(Token = "0x400598B")]
	[FieldOffset(Offset = "0x3E0")]
	private int m_AnimParameter_BowEquipSpeedMultiplier;

	[Token(Token = "0x400598C")]
	[FieldOffset(Offset = "0x3E4")]
	private int m_AnimParameter_AimStaminaDepleted;

	[Token(Token = "0x400598D")]
	[FieldOffset(Offset = "0x3E8")]
	private float m_DefaultPlaybackSpeedMultiplier;

	[Token(Token = "0x400598E")]
	[FieldOffset(Offset = "0x3EC")]
	private int m_AnimParameter_Trigger_Spear_Struggle_Entry;

	[Token(Token = "0x400598F")]
	[FieldOffset(Offset = "0x3F0")]
	private int m_AnimParameter_Trigger_Spear_Exit_Success;

	[Token(Token = "0x4005990")]
	[FieldOffset(Offset = "0x3F4")]
	private int m_AnimParameter_Trigger_Spear_Exit_Fail;

	[Token(Token = "0x4005991")]
	[FieldOffset(Offset = "0x3F8")]
	private int m_AnimParameter_Trigger_Spear_Exit_Success_Death;

	[Token(Token = "0x4005992")]
	[FieldOffset(Offset = "0x3FC")]
	private int m_AnimParameter_Struggle_Revolver_Available;

	[Token(Token = "0x4005993")]
	[FieldOffset(Offset = "0x400")]
	private int m_AnimParameter_Struggle_Fire_Revolver;

	[Token(Token = "0x4005994")]
	[FieldOffset(Offset = "0x404")]
	private int m_AnimParameter_Trigger_WolfPassBite;

	[Token(Token = "0x4005995")]
	[FieldOffset(Offset = "0x408")]
	private int m_AnimParameter_Spray;

	[Token(Token = "0x4005996")]
	[FieldOffset(Offset = "0x40C")]
	private int m_AnimParameter_Erase_Paint;

	[Token(Token = "0x4005997")]
	[FieldOffset(Offset = "0x410")]
	private int m_AnimParameter_NoiseMaker_Explode_In_Hand;

	[Token(Token = "0x4005998")]
	[FieldOffset(Offset = "0x414")]
	private int m_AnimParameter_CameraLookPitch;

	[Token(Token = "0x4005999")]
	[FieldOffset(Offset = "0x418")]
	private int m_AnimParameter_CameraLookYaw;

	[Token(Token = "0x400599A")]
	[FieldOffset(Offset = "0x41C")]
	private int m_AnimParameter_Trigger_Free_Look;

	[Token(Token = "0x400599B")]
	[FieldOffset(Offset = "0x420")]
	private int m_AnimParameter_Trigger_Free_Look_End;

	[Token(Token = "0x400599C")]
	[FieldOffset(Offset = "0x424")]
	private int m_AnimState_Idle;

	[Token(Token = "0x400599D")]
	[FieldOffset(Offset = "0x428")]
	private int m_AnimState_FreeLook;

	[Token(Token = "0x400599E")]
	[FieldOffset(Offset = "0x42C")]
	private int m_AnimParameter_CameraMovementX;

	[Token(Token = "0x400599F")]
	[FieldOffset(Offset = "0x430")]
	private int m_AnimParameter_CameraMovementY;

	[Token(Token = "0x40059A0")]
	[FieldOffset(Offset = "0x434")]
	private int m_AnimParameter_CameraMovementDampedX;

	[Token(Token = "0x40059A1")]
	[FieldOffset(Offset = "0x438")]
	private int m_AnimParameter_CameraMovementDampedY;

	[Token(Token = "0x40059A2")]
	[FieldOffset(Offset = "0x43C")]
	private readonly int m_AnimParameter_TravoisCameraYaw;

	[Token(Token = "0x40059A3")]
	[FieldOffset(Offset = "0x440")]
	private readonly int m_AnimParameter_TravoisTurnDampened;

	[Token(Token = "0x40059A4")]
	[FieldOffset(Offset = "0x444")]
	private float m_FadeAudioCinematicGoal;

	[Token(Token = "0x40059A5")]
	[FieldOffset(Offset = "0x448")]
	private CameraLayer m_CameraLayer;

	[Token(Token = "0x40059A6")]
	[FieldOffset(Offset = "0x44C")]
	private int m_HipAndShoulderOffsetLayerDisableCount;

	[Token(Token = "0x40059A7")]
	[FieldOffset(Offset = "0x450")]
	private float m_HipAndShoulderOffsetLayerTimer;

	[Token(Token = "0x40059A8")]
	[FieldOffset(Offset = "0x454")]
	private bool m_HipAndShoulderOffsetLayerFadeOutRequested;

	[Token(Token = "0x40059A9")]
	[FieldOffset(Offset = "0x455")]
	private bool m_HipAndShoulderOffsetLayerOverride;

	[Token(Token = "0x40059AA")]
	[FieldOffset(Offset = "0x458")]
	private AnimatorParametersCache m_AnimatorParametersCache;

	[Token(Token = "0x40059AB")]
	[FieldOffset(Offset = "0x460")]
	private CinematicManager m_FPCinematicManager;

	[Token(Token = "0x40059AC")]
	[FieldOffset(Offset = "0x468")]
	private bool m_CinematicRefPotsitionInitialized;

	[Token(Token = "0x40059AD")]
	[FieldOffset(Offset = "0x46C")]
	private Vector3 m_WorldSpaceViewRefPosition;

	[Token(Token = "0x40059AE")]
	[FieldOffset(Offset = "0x478")]
	private Quaternion m_WorldSpaceViewRefRotation;

	[Token(Token = "0x40059AF")]
	[FieldOffset(Offset = "0x488")]
	private bool m_EnableMotionFromRef;

	[Token(Token = "0x40059B0")]
	[FieldOffset(Offset = "0x48C")]
	private AnimationLayerFlags m_AnimatedInteractionLayersDisabled;

	[Token(Token = "0x40059B1")]
	[FieldOffset(Offset = "0x490")]
	private Vector2 m_FreeLookCameraYawLimit;

	[Token(Token = "0x40059B2")]
	[FieldOffset(Offset = "0x498")]
	private Vector2 m_FreeLookCameraPitchLimit;

	[Token(Token = "0x40059B3")]
	[FieldOffset(Offset = "0x4A0")]
	private float m_FreeLookCameraYaw;

	[Token(Token = "0x40059B4")]
	[FieldOffset(Offset = "0x4A4")]
	private float m_FreeLookCameraPitch;

	[Token(Token = "0x40059B5")]
	[FieldOffset(Offset = "0x4A8")]
	private Vector3 m_FrozenPosition;

	[Token(Token = "0x40059B6")]
	[FieldOffset(Offset = "0x4B4")]
	private Quaternion m_FrozenRotation;

	[Token(Token = "0x40059B7")]
	[FieldOffset(Offset = "0x4C4")]
	private Vector2 m_LastCameraAngle;

	[Token(Token = "0x40059B8")]
	[FieldOffset(Offset = "0x4CC")]
	private Vector2 m_CameraMoveDamped;

	[Token(Token = "0x40059B9")]
	[FieldOffset(Offset = "0x4D4")]
	private Vector2 m_CameraMoveVelocity;

	[Token(Token = "0x6004EFB")]
	[Address(RVA = "0xDBDDE0", Offset = "0xDBCBE0", Length = "0x188")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004EFC")]
	[Address(RVA = "0xDBDF70", Offset = "0xDBCD70", Length = "0x188")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004EFD")]
	[Address(RVA = "0xDBE100", Offset = "0xDBCF00", Length = "0x192")]
	private void OnEnvironmentChanged(bool isIndoor)
	{
	}

	[Token(Token = "0x6004EFE")]
	[Address(RVA = "0xDBE2A0", Offset = "0xDBD0A0", Length = "0x1664")]
	public void Start()
	{
	}

	[Token(Token = "0x6004EFF")]
	[Address(RVA = "0xDBF910", Offset = "0xDBE710", Length = "0x88")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004F00")]
	[Address(RVA = "0xDBF9A0", Offset = "0xDBE7A0", Length = "0xFE")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004F01")]
	[Address(RVA = "0xDBFAA0", Offset = "0xDBE8A0", Length = "0x28")]
	public void RequestMotionFromRef(Vector3 refPosition, Quaternion refRotation)
	{
	}

	[Token(Token = "0x6004F02")]
	[Address(RVA = "0xDBFAD0", Offset = "0xDBE8D0", Length = "0x8")]
	public bool IsMotionFromRefEnabled()
	{
		return false;
	}

	[Token(Token = "0x6004F03")]
	[Address(RVA = "0xDBFAE0", Offset = "0xDBE8E0", Length = "0xB")]
	private bool IsHipShoulderLayerDisabledPending()
	{
		return false;
	}

	[Token(Token = "0x6004F04")]
	[Address(RVA = "0xDBFAF0", Offset = "0xDBE8F0", Length = "0x7")]
	public void EnableHipAndShoulderOffsetLayerOverride(bool enable)
	{
	}

	[Token(Token = "0x6004F05")]
	[Address(RVA = "0xDBFB00", Offset = "0xDBE900", Length = "0x2ED")]
	private void MaybeFadeoutHipShoulder(Vector3 localVelocity)
	{
	}

	[Token(Token = "0x6004F06")]
	[Address(RVA = "0xDBFDF0", Offset = "0xDBEBF0", Length = "0x1060")]
	public void Update()
	{
	}

	[Token(Token = "0x6004F07")]
	[Address(RVA = "0xDC0E60", Offset = "0xDBFC60", Length = "0xF")]
	public void SetFreeCameraLookLimits(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[Token(Token = "0x6004F08")]
	[Address(RVA = "0xDC0E70", Offset = "0xDBFC70", Length = "0xCC")]
	public void UpdateFreeCameraLook(Vector2 delta)
	{
	}

	[Token(Token = "0x6004F09")]
	[Address(RVA = "0xDC0F40", Offset = "0xDBFD40", Length = "0x868")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x6004F0A")]
	[Address(RVA = "0xDC17B0", Offset = "0xDC05B0", Length = "0x8")]
	public void DisableMotionFromRef()
	{
	}

	[Token(Token = "0x6004F0B")]
	[Address(RVA = "0xDC17C0", Offset = "0xDC05C0", Length = "0x417")]
	public void Reset()
	{
	}

	[Token(Token = "0x6004F0C")]
	[Address(RVA = "0xDC1BE0", Offset = "0xDC09E0", Length = "0x4E")]
	private void ResetBoolIfExists(int hash)
	{
	}

	[Token(Token = "0x6004F0D")]
	[Address(RVA = "0xDC1C30", Offset = "0xDC0A30", Length = "0x90")]
	private void ResetWeaponParams()
	{
	}

	[Token(Token = "0x6004F0E")]
	[Address(RVA = "0xDC1CD0", Offset = "0xDC0AD0", Length = "0x41B")]
	private void ResetParams()
	{
	}

	[Token(Token = "0x6004F0F")]
	[Address(RVA = "0xDC20F0", Offset = "0xDC0EF0", Length = "0x2D")]
	public void ResetStruggleStartEnd()
	{
	}

	[Token(Token = "0x6004F10")]
	[Address(RVA = "0xDC2120", Offset = "0xDC0F20", Length = "0xF6")]
	public bool FirstPersonHandsEnabled(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6004F11")]
	[Address(RVA = "0xDC2220", Offset = "0xDC1020", Length = "0x12C")]
	public bool FirstPersonHandsEnabled(FPSItem itemData)
	{
		return false;
	}

	[Token(Token = "0x6004F12")]
	[Address(RVA = "0xDC2350", Offset = "0xDC1150", Length = "0x52")]
	public void ClearParametersCache()
	{
	}

	[Token(Token = "0x6004F13")]
	[Address(RVA = "0xDC23B0", Offset = "0xDC11B0", Length = "0x6B6")]
	private bool MaybeSetState(State state)
	{
		return false;
	}

	[Token(Token = "0x6004F14")]
	[Address(RVA = "0xDC2A70", Offset = "0xDC1870", Length = "0x7")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6004F15")]
	[Address(RVA = "0xDC2A80", Offset = "0xDC1880", Length = "0x44")]
	public bool GetAnimatorIsIdle()
	{
		return false;
	}

	[Token(Token = "0x6004F16")]
	[Address(RVA = "0xDC2AD0", Offset = "0xDC18D0", Length = "0x40")]
	public bool IsCurrentState(int fullPathHash)
	{
		return false;
	}

	[Token(Token = "0x6004F17")]
	[Address(RVA = "0xDC2B20", Offset = "0xDC1920", Length = "0x2D7")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return false;
	}

	[Token(Token = "0x6004F18")]
	[Address(RVA = "0xDC2E00", Offset = "0xDC1C00", Length = "0x8D")]
	public bool GetFirstPersonWeaponCanSwitch()
	{
		return false;
	}

	[Token(Token = "0x6004F19")]
	[Address(RVA = "0xDC2E90", Offset = "0xDC1C90", Length = "0x1BC")]
	public void SaveCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[Token(Token = "0x6004F1A")]
	[Address(RVA = "0xDC3050", Offset = "0xDC1E50", Length = "0x1BC")]
	public void LoadCameraBasedHandPositioning(RuntimeAnimatorController controller)
	{
	}

	[Token(Token = "0x6004F1B")]
	[Address(RVA = "0xDC3210", Offset = "0xDC2010", Length = "0x39")]
	public void RestoreCameraBasedHandPositioning()
	{
	}

	[Token(Token = "0x6004F1C")]
	[Address(RVA = "0xDC3250", Offset = "0xDC2050", Length = "0x4C4")]
	public void UpdateShoulderRotation()
	{
	}

	[Token(Token = "0x6004F1D")]
	[Address(RVA = "0xDC3720", Offset = "0xDC2520", Length = "0x213")]
	private void UpdateActiveJointPositioning()
	{
	}

	[Token(Token = "0x6004F1E")]
	[Address(RVA = "0xDC2AD0", Offset = "0xDC18D0", Length = "0x40")]
	public bool AnimIsPlaying(int id)
	{
		return false;
	}

	[Token(Token = "0x6004F1F")]
	[Address(RVA = "0xDC3940", Offset = "0xDC2740", Length = "0x33")]
	public void CancelReload()
	{
	}

	[Token(Token = "0x6004F20")]
	[Address(RVA = "0xDC3980", Offset = "0xDC2780", Length = "0x85")]
	public void Trigger_Struggle_Start(StruggleBonus.StruggleWeaponType weaponType, WildlifeType wildlifeType)
	{
	}

	[Token(Token = "0x6004F21")]
	[Address(RVA = "0xDC3A10", Offset = "0xDC2810", Length = "0x43")]
	public void Trigger_Spear_Struggle_Start()
	{
	}

	[Token(Token = "0x6004F22")]
	[Address(RVA = "0xDC3A60", Offset = "0xDC2860", Length = "0x2D")]
	public void SetParameterSetSpearMultiplier(float multiplier)
	{
	}

	[Token(Token = "0x6004F23")]
	[Address(RVA = "0xDC3A90", Offset = "0xDC2890", Length = "0x2D")]
	public void SetParameterRecoverSpearMultiplier(float multiplier)
	{
	}

	[Token(Token = "0x6004F24")]
	[Address(RVA = "0xDC3AC0", Offset = "0xDC28C0", Length = "0x2D")]
	public void SetParameterBowSpeedModifier(float multiplier)
	{
	}

	[Token(Token = "0x6004F25")]
	[Address(RVA = "0xDC3AF0", Offset = "0xDC28F0", Length = "0x4E")]
	public void Trigger_Struggle_End()
	{
	}

	[Token(Token = "0x6004F26")]
	[Address(RVA = "0xDC3B40", Offset = "0xDC2940", Length = "0x1E3")]
	public bool Trigger_Brandish(OnAnimationEvent brandishBegin, OnAnimationEvent midSwingEvent)
	{
		return false;
	}

	[Token(Token = "0x6004F27")]
	[Address(RVA = "0xDC3D30", Offset = "0xDC2B30", Length = "0x68")]
	private void OnAnimationEvent_BrandishMidSwing()
	{
	}

	[Token(Token = "0x6004F28")]
	[Address(RVA = "0xDC3DA0", Offset = "0xDC2BA0", Length = "0xC")]
	private void OnAnimationEvent_BrandishComplete()
	{
	}

	[Token(Token = "0x6004F29")]
	[Address(RVA = "0xDC3DB0", Offset = "0xDC2BB0", Length = "0x68")]
	private void OnAnimationEvent_BrandishBegin()
	{
	}

	[Token(Token = "0x6004F2A")]
	[Address(RVA = "0xDC3E20", Offset = "0xDC2C20", Length = "0xB")]
	public bool BrandishIsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6004F2B")]
	[Address(RVA = "0xDC3E30", Offset = "0xDC2C30", Length = "0x4F")]
	public void Trigger_AnimatedInteraction(string trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersEnabled)
	{
	}

	[Token(Token = "0x6004F2C")]
	[Address(RVA = "0xDC3E80", Offset = "0xDC2C80", Length = "0x241")]
	public void Trigger_AnimatedInteraction(int trigger, bool weaponSpace, OnAnimationEvent onCompleteCallback, AnimationLayerFlags layersDisabled)
	{
	}

	[Token(Token = "0x6004F2D")]
	[Address(RVA = "0xDC40D0", Offset = "0xDC2ED0", Length = "0x11")]
	public void DisableHipAndShoulderOffsetLayer()
	{
	}

	[Token(Token = "0x6004F2E")]
	[Address(RVA = "0xDC40F0", Offset = "0xDC2EF0", Length = "0x34")]
	public void ResetHipAndShoulderOffsetLayer()
	{
	}

	[Token(Token = "0x6004F2F")]
	[Address(RVA = "0xDC4130", Offset = "0xDC2F30", Length = "0xF")]
	public void ForceHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[Token(Token = "0x6004F30")]
	[Address(RVA = "0xDC4140", Offset = "0xDC2F40", Length = "0x9B")]
	private void UpdateHipAndShoulderOffsetLayerWeigth(float weigth)
	{
	}

	[Token(Token = "0x6004F31")]
	[Address(RVA = "0xDC41E0", Offset = "0xDC2FE0", Length = "0x1F")]
	private void UpdateHipAndShoulderOffsetLayer(bool enabled)
	{
	}

	[Token(Token = "0x6004F32")]
	[Address(RVA = "0xDC4200", Offset = "0xDC3000", Length = "0x203")]
	private void OnAnimationEvent_AnimatedInteractionComplete()
	{
	}

	[Token(Token = "0x6004F33")]
	[Address(RVA = "0xDC4410", Offset = "0xDC3210", Length = "0x112")]
	public void Trigger_Breakdown_Intro(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[Token(Token = "0x6004F34")]
	[Address(RVA = "0xDC4530", Offset = "0xDC3330", Length = "0xEC")]
	public void Trigger_Breakdown_StartLoop()
	{
	}

	[Token(Token = "0x6004F35")]
	[Address(RVA = "0xDC4620", Offset = "0xDC3420", Length = "0xEC")]
	public void Trigger_Breakdown_Cancel()
	{
	}

	[Token(Token = "0x6004F36")]
	[Address(RVA = "0xDC4710", Offset = "0xDC3510", Length = "0xEC")]
	public void Trigger_Breakdown_ExitLoop()
	{
	}

	[Token(Token = "0x6004F37")]
	[Address(RVA = "0xDC4800", Offset = "0xDC3600", Length = "0xEC")]
	public void Trigger_Limp()
	{
	}

	[Token(Token = "0x6004F38")]
	[Address(RVA = "0xDC48F0", Offset = "0xDC36F0", Length = "0x115")]
	public void Trigger_Stumble(int stumbleId)
	{
	}

	[Token(Token = "0x6004F39")]
	[Address(RVA = "0xDC4A10", Offset = "0xDC3810", Length = "0xD0C")]
	public void Trigger_Generic_Equip(GearItem gearItem, bool immediate, OnAnimationEvent showItemEventCallback, OnAnimationEvent equepCompleteEventCallback)
	{
	}

	[Token(Token = "0x6004F3A")]
	[Address(RVA = "0xDC5720", Offset = "0xDC4520", Length = "0x77")]
	private void OnAnimationEvent_Generic_Equip_ShowItem()
	{
	}

	[Token(Token = "0x6004F3B")]
	[Address(RVA = "0xDC57A0", Offset = "0xDC45A0", Length = "0x15D")]
	private void OnAnimationEvent_Generic_Equip_Complete()
	{
	}

	[Token(Token = "0x6004F3C")]
	[Address(RVA = "0xDC5900", Offset = "0xDC4700", Length = "0x1A9")]
	public bool Trigger_Generic_Unequip(OnAnimationEvent extinguishFxCallback, OnAnimationEvent hideCallback, OnAnimationEvent completeCallback)
	{
		return false;
	}

	[Token(Token = "0x6004F3D")]
	[Address(RVA = "0xDC5AB0", Offset = "0xDC48B0", Length = "0x2D")]
	public void OnMatchBurntOut()
	{
	}

	[Token(Token = "0x6004F3E")]
	[Address(RVA = "0xDC5AE0", Offset = "0xDC48E0", Length = "0x329")]
	public void DropCurrentItemInHand()
	{
	}

	[Token(Token = "0x6004F3F")]
	[Address(RVA = "0xDC5E10", Offset = "0xDC4C10", Length = "0x17C")]
	public void OnAnimationEvent_Generic_Hidden()
	{
	}

	[Token(Token = "0x6004F40")]
	[Address(RVA = "0xDC5F90", Offset = "0xDC4D90", Length = "0x355")]
	private void OnAnimationEvent_Generic_HiddenComplete()
	{
	}

	[Token(Token = "0x6004F41")]
	[Address(RVA = "0xDC62F0", Offset = "0xDC50F0", Length = "0x3F")]
	public void Trigger_Generic_Stow()
	{
	}

	[Token(Token = "0x6004F42")]
	[Address(RVA = "0xDC6330", Offset = "0xDC5130", Length = "0xC")]
	private void OnAnimationEvent_Generic_Stow()
	{
	}

	[Token(Token = "0x6004F43")]
	[Address(RVA = "0xDC6340", Offset = "0xDC5140", Length = "0x3F")]
	public void Trigger_Generic_Unstow()
	{
	}

	[Token(Token = "0x6004F44")]
	[Address(RVA = "0xDC6380", Offset = "0xDC5180", Length = "0x3A")]
	public void Trigger_BearSpearStruggleAnimation(BearSpearStruggleOutcome outcome)
	{
	}

	[Token(Token = "0x6004F45")]
	[Address(RVA = "0xDC63C0", Offset = "0xDC51C0", Length = "0xE")]
	public void Trigger_WolfPassBite()
	{
	}

	[Token(Token = "0x6004F46")]
	[Address(RVA = "0xDC63D0", Offset = "0xDC51D0", Length = "0xB1")]
	public void Trigger_Spray(OnAnimationEvent sprayCompleteCallback)
	{
	}

	[Token(Token = "0x6004F47")]
	[Address(RVA = "0xDC6490", Offset = "0xDC5290", Length = "0xB1")]
	public void Trigger_Erase_Paint(OnAnimationEvent erasePaintCompleteCallback)
	{
	}

	[Token(Token = "0x6004F48")]
	[Address(RVA = "0xDC6550", Offset = "0xDC5350", Length = "0xB1")]
	public void Trigger_NoiseMaker_Explode_In_Hand(OnAnimationEvent completeCallback)
	{
	}

	[Token(Token = "0x6004F49")]
	[Address(RVA = "0xDC6610", Offset = "0xDC5410", Length = "0xE")]
	public void Trigger_Free_Look()
	{
	}

	[Token(Token = "0x6004F4A")]
	[Address(RVA = "0xDC6620", Offset = "0xDC5420", Length = "0xE")]
	public void Trigger_Free_Look_End()
	{
	}

	[Token(Token = "0x6004F4B")]
	[Address(RVA = "0xDC6630", Offset = "0xDC5430", Length = "0x12")]
	public void SetStruggleRevolverAvailableToFire(bool isAvailable)
	{
	}

	[Token(Token = "0x6004F4C")]
	[Address(RVA = "0xDC6650", Offset = "0xDC5450", Length = "0xFE")]
	public void SetStruggleRevolverFired(bool hasFired, OnAnimationEvent onRevolverFired, OnAnimationEvent onRevolverFiredComplete)
	{
	}

	[Token(Token = "0x6004F4D")]
	[Address(RVA = "0xDC3DA0", Offset = "0xDC2BA0", Length = "0xC")]
	private void OnAnimationEvent_Generic_Unstow_Complete()
	{
	}

	[Token(Token = "0x6004F4E")]
	[Address(RVA = "0xDC6750", Offset = "0xDC5550", Length = "0x167")]
	public void Trigger_Generic_Ignite(bool isFire)
	{
	}

	[Token(Token = "0x6004F4F")]
	[Address(RVA = "0xDC68C0", Offset = "0xDC56C0", Length = "0xF9")]
	public void Trigger_Generic_Ignite_Confirm(OnAnimationEvent ignite_FX_Callback, OnAnimationEvent ignite_Complete_Callback)
	{
	}

	[Token(Token = "0x6004F50")]
	[Address(RVA = "0xDC69C0", Offset = "0xDC57C0", Length = "0x110")]
	public void Trigger_Generic_Ignite_Cancel()
	{
	}

	[Token(Token = "0x6004F51")]
	[Address(RVA = "0xDC6AE0", Offset = "0xDC58E0", Length = "0x68")]
	private void OnAnimationEvent_Generic_Ignite()
	{
	}

	[Token(Token = "0x6004F52")]
	[Address(RVA = "0xDC6B50", Offset = "0xDC5950", Length = "0x87")]
	private void OnAnimationEvent_Generic_IgniteComplete()
	{
	}

	[Token(Token = "0x6004F53")]
	[Address(RVA = "0xDC6BE0", Offset = "0xDC59E0", Length = "0x19A")]
	public bool Trigger_Generic_Extinguish(OnAnimationEvent animationEventCallback)
	{
		return false;
	}

	[Token(Token = "0x6004F54")]
	[Address(RVA = "0xDC6D80", Offset = "0xDC5B80", Length = "0x3F")]
	public void Trigger_Generic_Extinguish_Cancel()
	{
	}

	[Token(Token = "0x6004F55")]
	[Address(RVA = "0xDC6DC0", Offset = "0xDC5BC0", Length = "0x2DF")]
	private void OnAnimationEvent_Generic_Extinguish_FX()
	{
	}

	[Token(Token = "0x6004F56")]
	[Address(RVA = "0xDC3DA0", Offset = "0xDC2BA0", Length = "0xC")]
	private void OnAnimationEvent_Generic_Extinguish_Complete()
	{
	}

	[Token(Token = "0x6004F57")]
	[Address(RVA = "0xDC70A0", Offset = "0xDC5EA0", Length = "0x207")]
	public void Trigger_Generic_PlacementMode_Place(GearItem gearItem, OnAnimationEvent placementPlaceAnimationEventCallback, OnAnimationEvent placementCompleteAnimationEventCallback)
	{
	}

	[Token(Token = "0x6004F58")]
	[Address(RVA = "0xDC72B0", Offset = "0xDC60B0", Length = "0xA")]
	private void OnAnimationEvent_Generic_PlacementMode_HideItemInHands()
	{
	}

	[Token(Token = "0x6004F59")]
	[Address(RVA = "0xDC72C0", Offset = "0xDC60C0", Length = "0x68")]
	private void OnAnimationEvent_Generic_PlacementMode_SpawnItemInWorld()
	{
	}

	[Token(Token = "0x6004F5A")]
	[Address(RVA = "0xDC7330", Offset = "0xDC6130", Length = "0x1FE")]
	private void OnAnimationEvent_Generic_PlacementMode_PlaceItem_Complete()
	{
	}

	[Token(Token = "0x6004F5B")]
	[Address(RVA = "0xDC7530", Offset = "0xDC6330", Length = "0x534")]
	public void Update_Lightsource_Lit(bool lit, bool isFresh)
	{
	}

	[Token(Token = "0x6004F5C")]
	[Address(RVA = "0xDC7A70", Offset = "0xDC6870", Length = "0x33A")]
	public void Trigger_Generic_Fire(int roundsInClip, bool willJam, OnAnimationEvent fxEventCallback, OnAnimationEvent completeEventCallback)
	{
	}

	[Token(Token = "0x6004F5D")]
	[Address(RVA = "0xDC7DB0", Offset = "0xDC6BB0", Length = "0x68")]
	private void OnAnimationEvent_Generic_Fire_FX()
	{
	}

	[Token(Token = "0x6004F5E")]
	[Address(RVA = "0xDC7E20", Offset = "0xDC6C20", Length = "0x316")]
	private void OnAnimationEvent_Generic_Fire_Complete()
	{
	}

	[Token(Token = "0x6004F5F")]
	[Address(RVA = "0xDC8140", Offset = "0xDC6F40", Length = "0x233")]
	public void Trigger_Generic_Reload(int bulletsToReload, int roundsLoaded, bool willJam, OnAnimationEvent roundLoadedEventCallback, OnAnimationEvent clipLoadedEventCallback, OnAnimationEvent reloadCompleteEventCallback, OnAnimationEvent roundsUnloadedEventCallback)
	{
	}

	[Token(Token = "0x6004F60")]
	[Address(RVA = "0xDC8380", Offset = "0xDC7180", Length = "0x19")]
	private void OnAnimationEvent_Generic_Round_Loaded()
	{
	}

	[Token(Token = "0x6004F61")]
	[Address(RVA = "0xDC83A0", Offset = "0xDC71A0", Length = "0x19")]
	private void OnAnimationEvent_Generic_Clip_Loaded()
	{
	}

	[Token(Token = "0x6004F62")]
	[Address(RVA = "0xDC83C0", Offset = "0xDC71C0", Length = "0x19")]
	private void OnAnimationEvent_Generic_Rounds_Unloaded()
	{
	}

	[Token(Token = "0x6004F63")]
	[Address(RVA = "0xDC83E0", Offset = "0xDC71E0", Length = "0x10E")]
	private void OnAnimationEvent_Generic_ShowReloadBulletInstance()
	{
	}

	[Token(Token = "0x6004F64")]
	[Address(RVA = "0xDC84F0", Offset = "0xDC72F0", Length = "0x68")]
	private void OnAnimationEvent_Struggle_Revolver_Fire()
	{
	}

	[Token(Token = "0x6004F65")]
	[Address(RVA = "0xDC8560", Offset = "0xDC7360", Length = "0x68")]
	private void OnAnimationEvent_Struggle_Revolver_Fire_Complete()
	{
	}

	[Token(Token = "0x6004F66")]
	[Address(RVA = "0xDC85D0", Offset = "0xDC73D0", Length = "0x2D6")]
	private void OnAnimationEvent_Discharge_Shell_Event()
	{
	}

	[Token(Token = "0x6004F67")]
	[Address(RVA = "0xDC88B0", Offset = "0xDC76B0", Length = "0x1AB")]
	private void OnAnimationEvent_Spray_Complete()
	{
	}

	[Token(Token = "0x6004F68")]
	[Address(RVA = "0xDC8A60", Offset = "0xDC7860", Length = "0x87")]
	private void OnAnimationEvent_Erase_Paint_Complete()
	{
	}

	[Token(Token = "0x6004F69")]
	[Address(RVA = "0xDC8AF0", Offset = "0xDC78F0", Length = "0x68")]
	private void OnAnimationEvent_Explode_In_Hand_Complete()
	{
	}

	[Token(Token = "0x6004F6A")]
	[Address(RVA = "0xDC8B60", Offset = "0xDC7960", Length = "0x194")]
	private void OnAnimationEvent_Generic_Reload_Complete()
	{
	}

	[Token(Token = "0x6004F6B")]
	[Address(RVA = "0xDC8D00", Offset = "0xDC7B00", Length = "0x99")]
	public void UpdateReloadCount(int bulletsToReload, int roundsLoaded, bool willJam)
	{
	}

	[Token(Token = "0x6004F6C")]
	[Address(RVA = "0xDC8DA0", Offset = "0xDC7BA0", Length = "0x12")]
	public void UpdateJamParameters(bool willJam)
	{
	}

	[Token(Token = "0x6004F6D")]
	[Address(RVA = "0xDC8DC0", Offset = "0xDC7BC0", Length = "0xD2")]
	public void Trigger_Generic_Aim(OnAnimationEvent onAnimationComplete)
	{
	}

	[Token(Token = "0x6004F6E")]
	[Address(RVA = "0xDC8EA0", Offset = "0xDC7CA0", Length = "0x97")]
	public void OnAnimationEvent_Generic_Aim_Complete()
	{
	}

	[Token(Token = "0x6004F6F")]
	[Address(RVA = "0xDC8F40", Offset = "0xDC7D40", Length = "0x11F")]
	public void Trigger_Generic_Aim_Cancel(OnAnimationEvent onAnimationComplete, bool exhausted)
	{
	}

	[Token(Token = "0x6004F70")]
	[Address(RVA = "0xDC9060", Offset = "0xDC7E60", Length = "0x17E")]
	public void Trigger_Generic_BowAim_Cancel(OnAnimationEvent onAnimationComplete)
	{
	}

	[Token(Token = "0x6004F71")]
	[Address(RVA = "0xDC91E0", Offset = "0xDC7FE0", Length = "0x97")]
	public void OnAnimationEvent_Generic_Aim_Cancel_Complete()
	{
	}

	[Token(Token = "0x6004F72")]
	[Address(RVA = "0xDC9280", Offset = "0xDC8080", Length = "0x109")]
	public void Trigger_Generic_Use(OnAnimationEvent useNowEventCallback, OnAnimationEvent useCompleteEventCallback)
	{
	}

	[Token(Token = "0x6004F73")]
	[Address(RVA = "0xDC9390", Offset = "0xDC8190", Length = "0x7B")]
	private void OnAnimationEvent_Generic_Use_Now()
	{
	}

	[Token(Token = "0x6004F74")]
	[Address(RVA = "0xDC9410", Offset = "0xDC8210", Length = "0x168")]
	private void OnAnimationEvent_Generic_Use_Complete()
	{
	}

	[Token(Token = "0x6004F75")]
	[Address(RVA = "0xDC3DA0", Offset = "0xDC2BA0", Length = "0xC")]
	private void OnAnimationEvent_Generic_LookAround_Complete()
	{
	}

	[Token(Token = "0x6004F76")]
	[Address(RVA = "0xDC9580", Offset = "0xDC8380", Length = "0x57")]
	private void OnAnimationEvent_Struggle_GetUp_Complete()
	{
	}

	[Token(Token = "0x6004F77")]
	[Address(RVA = "0xDC95E0", Offset = "0xDC83E0", Length = "0x57")]
	private void OnAnimationEvent_Struggle_Play_MauledMuffle()
	{
	}

	[Token(Token = "0x6004F78")]
	[Address(RVA = "0xDC9640", Offset = "0xDC8440", Length = "0x57")]
	private void OnAnimationEvent_Struggle_Stop_MauledMuffle()
	{
	}

	[Token(Token = "0x6004F79")]
	[Address(RVA = "0xDC96A0", Offset = "0xDC84A0", Length = "0xC7")]
	private void OnAnimationEvent_PlayerStunned_Begin()
	{
	}

	[Token(Token = "0x6004F7A")]
	[Address(RVA = "0xDC9770", Offset = "0xDC8570", Length = "0x94")]
	private void OnAnimationEvent_StartResumingFov()
	{
	}

	[Token(Token = "0x6004F7B")]
	[Address(RVA = "0xDC9810", Offset = "0xDC8610", Length = "0xFC")]
	public bool Trigger_Generic_Throw(OnAnimationEvent releaseItemCallback, OnAnimationEvent throwCompleteCallback)
	{
		return false;
	}

	[Token(Token = "0x6004F7C")]
	[Address(RVA = "0xDC9910", Offset = "0xDC8710", Length = "0x92")]
	private void OnAnimationEvent_Generic_Throw_ReleaseItem()
	{
	}

	[Token(Token = "0x6004F7D")]
	[Address(RVA = "0xDC99B0", Offset = "0xDC87B0", Length = "0x8E")]
	public void Trigger_Generic_Kill(OnAnimationEvent killCompleteCallback)
	{
	}

	[Token(Token = "0x6004F7E")]
	[Address(RVA = "0xDC9A40", Offset = "0xDC8840", Length = "0x1BF")]
	public void Update_Aiming(bool aiming)
	{
	}

	[Token(Token = "0x6004F7F")]
	[Address(RVA = "0xDC9C00", Offset = "0xDC8A00", Length = "0x51A")]
	public void Update_HasUnloadedAmmo()
	{
	}

	[Token(Token = "0x6004F80")]
	[Address(RVA = "0xDCA120", Offset = "0xDC8F20", Length = "0x12")]
	public void Update_IsLoaded(bool isLoaded)
	{
	}

	[Token(Token = "0x6004F81")]
	[Address(RVA = "0xDCA140", Offset = "0xDC8F40", Length = "0x358")]
	public void Update_WeaponFatigue(float fatigue)
	{
	}

	[Token(Token = "0x6004F82")]
	[Address(RVA = "0xDCA4A0", Offset = "0xDC92A0", Length = "0x31E")]
	public void ShowHands()
	{
	}

	[Token(Token = "0x6004F83")]
	[Address(RVA = "0xDCA7C0", Offset = "0xDC95C0", Length = "0x1C3")]
	public void HideHands()
	{
	}

	[Token(Token = "0x6004F84")]
	[Address(RVA = "0xDCA990", Offset = "0xDC9790", Length = "0x11E")]
	public void SetEquippedWeaponLeftHandVisible(bool visible)
	{
	}

	[Token(Token = "0x6004F85")]
	[Address(RVA = "0xDCAAB0", Offset = "0xDC98B0", Length = "0x11E")]
	public void SetEquippedWeaponRightHandVisible(bool visible)
	{
	}

	[Token(Token = "0x6004F86")]
	[Address(RVA = "0xDCABD0", Offset = "0xDC99D0", Length = "0x11E")]
	public void SetEquippedWeaponShoulderVisible(bool visible)
	{
	}

	[Token(Token = "0x6004F87")]
	[Address(RVA = "0xDCACF0", Offset = "0xDC9AF0", Length = "0x136")]
	public void SetHandMeshState(string name)
	{
	}

	[Token(Token = "0x6004F88")]
	[Address(RVA = "0xDCAE30", Offset = "0xDC9C30", Length = "0x163")]
	public void DisableAllClothing()
	{
	}

	[Token(Token = "0x6004F89")]
	[Address(RVA = "0xDCAFA0", Offset = "0xDC9DA0", Length = "0x293")]
	private bool GetParamExists(Animator animator, int paramHash)
	{
		return false;
	}

	[Token(Token = "0x6004F8A")]
	[Address(RVA = "0xDCB240", Offset = "0xDCA040", Length = "0x50F")]
	private void SetTrigger(int trigger)
	{
	}

	[Token(Token = "0x6004F8B")]
	[Address(RVA = "0xDCB750", Offset = "0xDCA550", Length = "0x52D")]
	private void SetBool(int boolVar, bool boolVal)
	{
	}

	[Token(Token = "0x6004F8C")]
	[Address(RVA = "0xDCBC80", Offset = "0xDCAA80", Length = "0x528")]
	private void SetInt(int intVar, int intVal)
	{
	}

	[Token(Token = "0x6004F8D")]
	[Address(RVA = "0xDCC1B0", Offset = "0xDCAFB0", Length = "0x528")]
	private void SetFloat(int floatVar, float floatVal)
	{
	}

	[Token(Token = "0x6004F8E")]
	[Address(RVA = "0xDCC6E0", Offset = "0xDCB4E0", Length = "0x50F")]
	private void ResetTrigger(int trigger)
	{
	}

	[Token(Token = "0x6004F8F")]
	[Address(RVA = "0xDCCBF0", Offset = "0xDCB9F0", Length = "0x674")]
	private void EnableEquipped(bool active)
	{
	}

	[Token(Token = "0x6004F90")]
	[Address(RVA = "0xDCD270", Offset = "0xDCC070", Length = "0x2A9")]
	public void EnableActiveClothing()
	{
	}

	[Token(Token = "0x6004F91")]
	[Address(RVA = "0xDCD520", Offset = "0xDCC320", Length = "0x3D4")]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[Token(Token = "0x6004F92")]
	[Address(RVA = "0xDCD900", Offset = "0xDCC700", Length = "0x1A9")]
	public GameObject GetRevolverMuzzleFlashGO(StruggleBonus.StruggleWeaponType weaponType)
	{
		return null;
	}

	[Token(Token = "0x6004F93")]
	[Address(RVA = "0xDCDAB0", Offset = "0xDCC8B0", Length = "0x13F")]
	public void DisableWeapon()
	{
	}

	[Token(Token = "0x6004F94")]
	[Address(RVA = "0xDCDBF0", Offset = "0xDCC9F0", Length = "0x33E")]
	public static void SetLayerOnObjectRecursively(GameObject gameObject, int layer)
	{
	}

	[Token(Token = "0x6004F95")]
	[Address(RVA = "0xDCDF30", Offset = "0xDCCD30", Length = "0x7")]
	public CameraLayer GetCameraLayer()
	{
		return default(CameraLayer);
	}

	[Token(Token = "0x6004F96")]
	[Address(RVA = "0xDCDF40", Offset = "0xDCCD40", Length = "0x11")]
	public int GetCameraLayerAsGameObjectLayer()
	{
		return 0;
	}

	[Token(Token = "0x6004F97")]
	[Address(RVA = "0xDCDF60", Offset = "0xDCCD60", Length = "0x608")]
	public void SetCameraLayer(CameraLayer cameraLayer)
	{
	}

	[Token(Token = "0x6004F98")]
	[Address(RVA = "0xDCE570", Offset = "0xDCD370", Length = "0x1BB")]
	public void SetCameraBasedHandPositioningMode(CameraBasedHandPositioningMode mode)
	{
	}

	[Token(Token = "0x6004F99")]
	[Address(RVA = "0xDCE730", Offset = "0xDCD530", Length = "0x7")]
	public CameraBasedHandPositioningMode GetCameraBasedPositioningMode()
	{
		return default(CameraBasedHandPositioningMode);
	}

	[Token(Token = "0x6004F9A")]
	[Address(RVA = "0xDCE740", Offset = "0xDCD540", Length = "0x6EA")]
	public void ClearOutstandingCallbacks()
	{
	}

	[Token(Token = "0x6004F9B")]
	[Address(RVA = "0xDCEE30", Offset = "0xDCDC30", Length = "0xF7")]
	public void ShowPlayer(bool show)
	{
	}

	[Token(Token = "0x6004F9C")]
	[Address(RVA = "0xDCEF30", Offset = "0xDCDD30", Length = "0x90")]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return false;
	}

	[Token(Token = "0x6004F9D")]
	[Address(RVA = "0xDCEFD0", Offset = "0xDCDDD0", Length = "0x57")]
	public void DraggingAnimationEnd()
	{
	}

	[Token(Token = "0x6004F9E")]
	[Address(RVA = "0xDCF030", Offset = "0xDCDE30", Length = "0x2B8")]
	public void MaybeDropAndResetCurrentWeapon()
	{
	}

	[Token(Token = "0x6004F9F")]
	[Address(RVA = "0xDCF2F0", Offset = "0xDCE0F0", Length = "0x8")]
	public bool IsLooking()
	{
		return false;
	}

	[Token(Token = "0x6004FA0")]
	[Address(RVA = "0xDCF300", Offset = "0xDCE100", Length = "0x1D")]
	public void LookAt(Vector3 target)
	{
	}

	[Token(Token = "0x6004FA1")]
	[Address(RVA = "0xDCF320", Offset = "0xDCE120", Length = "0x8")]
	public void CancelLookAt()
	{
	}

	[Token(Token = "0x6004FA2")]
	[Address(RVA = "0xDCF330", Offset = "0xDCE130", Length = "0x5ED")]
	private void UpdateLookAtTarget()
	{
	}

	[Token(Token = "0x6004FA3")]
	[Address(RVA = "0xDCF920", Offset = "0xDCE720", Length = "0x223")]
	public bool GetCinematicBlurValue(out float value)
	{
		value = default(float);
		return false;
	}

	[Token(Token = "0x6004FA4")]
	[Address(RVA = "0xDCFB50", Offset = "0xDCE950", Length = "0x368")]
	private void MaybeUpdateCinematicFade()
	{
	}

	[Token(Token = "0x6004FA5")]
	[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
	public bool IsAnimationDrivenViewBobEnabled()
	{
		return false;
	}

	[Token(Token = "0x6004FA6")]
	[Address(RVA = "0xDCFEC0", Offset = "0xDCECC0", Length = "0xF0")]
	public float GetAimingZoomBlend()
	{
		return 0f;
	}

	[Token(Token = "0x6004FA7")]
	[Address(RVA = "0xDCFFC0", Offset = "0xDCEDC0", Length = "0x1F")]
	public bool CanInteract()
	{
		return false;
	}

	[Token(Token = "0x6004FA8")]
	[Address(RVA = "0xDCFFE0", Offset = "0xDCEDE0", Length = "0x1F")]
	public bool IsDequipping()
	{
		return false;
	}

	[Token(Token = "0x6004FA9")]
	[Address(RVA = "0xDD0000", Offset = "0xDCEE00", Length = "0xB")]
	public bool IsUnstowing()
	{
		return false;
	}

	[Token(Token = "0x6004FAA")]
	[Address(RVA = "0xDD0010", Offset = "0xDCEE10", Length = "0xB")]
	public bool IsStowed()
	{
		return false;
	}

	[Token(Token = "0x6004FAB")]
	[Address(RVA = "0xDD0020", Offset = "0xDCEE20", Length = "0x18")]
	public bool IsAiming()
	{
		return false;
	}

	[Token(Token = "0x6004FAC")]
	[Address(RVA = "0xDD0040", Offset = "0xDCEE40", Length = "0xB")]
	public bool IsEnteringAiming()
	{
		return false;
	}

	[Token(Token = "0x6004FAD")]
	[Address(RVA = "0xDD0050", Offset = "0xDCEE50", Length = "0xB")]
	public bool IsAimingDownSight()
	{
		return false;
	}

	[Token(Token = "0x6004FAE")]
	[Address(RVA = "0xDD0060", Offset = "0xDCEE60", Length = "0xB")]
	public bool IsReloading()
	{
		return false;
	}

	[Token(Token = "0x6004FAF")]
	[Address(RVA = "0xDD0070", Offset = "0xDCEE70", Length = "0x18B")]
	public bool IsBowAllowedToFire()
	{
		return false;
	}

	[Token(Token = "0x6004FB0")]
	[Address(RVA = "0xDD0200", Offset = "0xDCF000", Length = "0x29")]
	public bool IsInteractionAllowed()
	{
		return false;
	}

	[Token(Token = "0x6004FB1")]
	[Address(RVA = "0xDD0230", Offset = "0xDCF030", Length = "0xB")]
	public bool IsShowing()
	{
		return false;
	}

	[Token(Token = "0x6004FB2")]
	[Address(RVA = "0xDD0240", Offset = "0xDCF040", Length = "0x1B7")]
	public bool IsAllowedToFire(bool allowHipFire)
	{
		return false;
	}

	[Token(Token = "0x6004FB3")]
	[Address(RVA = "0xDD0400", Offset = "0xDCF200", Length = "0xC")]
	public bool IsAllowedToAim()
	{
		return false;
	}

	[Token(Token = "0x6004FB4")]
	[Address(RVA = "0xDD0410", Offset = "0xDCF210", Length = "0x12E")]
	public bool CanTransitionToState(State state)
	{
		return false;
	}

	[Token(Token = "0x6004FB5")]
	[Address(RVA = "0xDD0540", Offset = "0xDCF340", Length = "0x313")]
	private Vector3 ComputeDampedVelocity(Vector3 newVelocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004FB6")]
	[Address(RVA = "0xDD0860", Offset = "0xDCF660", Length = "0x1A9")]
	public void Trigger_Knockdown()
	{
	}

	[Token(Token = "0x6004FB7")]
	[Address(RVA = "0xDD0A10", Offset = "0xDCF810", Length = "0x8")]
	public List<Animator> GetGlobalAnimationList()
	{
		return null;
	}

	[Token(Token = "0x6004FB8")]
	[Address(RVA = "0xDD0A20", Offset = "0xDCF820", Length = "0x7E")]
	public void RegisterAnimator(Animator animator)
	{
	}

	[Token(Token = "0x6004FB9")]
	[Address(RVA = "0xDD0AA0", Offset = "0xDCF8A0", Length = "0x85")]
	public void UnregisterAnimator(Animator animator)
	{
	}

	[Token(Token = "0x6004FBA")]
	[Address(RVA = "0xDD0B30", Offset = "0xDCF930", Length = "0x459")]
	public void ResetLightSources()
	{
	}

	[Token(Token = "0x6004FBB")]
	[Address(RVA = "0xDD0F90", Offset = "0xDCFD90", Length = "0x462")]
	public void TurnOffEffects()
	{
	}

	[Token(Token = "0x6004FBC")]
	[Address(RVA = "0xDD1400", Offset = "0xDD0200", Length = "0x459")]
	public void TurnOnEffects()
	{
	}

	[Token(Token = "0x6004FBD")]
	[Address(RVA = "0xDD1860", Offset = "0xDD0660", Length = "0x7")]
	public void SetItemEquippedByPlayer(bool equippedByPlayer)
	{
	}

	[Token(Token = "0x6004FBE")]
	[Address(RVA = "0xDD1870", Offset = "0xDD0670", Length = "0x42")]
	public void SetLimp(bool islimpingleft, bool islimpingright)
	{
	}

	[Token(Token = "0x6004FBF")]
	[Address(RVA = "0xDD18C0", Offset = "0xDD06C0", Length = "0x12")]
	public void SetClimbing(bool value)
	{
	}

	[Token(Token = "0x6004FC0")]
	[Address(RVA = "0xDD18E0", Offset = "0xDD06E0", Length = "0x7")]
	public int GetHipLayerIndex()
	{
		return 0;
	}

	[Token(Token = "0x6004FC1")]
	[Address(RVA = "0xDD18F0", Offset = "0xDD06F0", Length = "0x21D")]
	public CinematicManager GetFPCinematicManager()
	{
		return null;
	}

	[Token(Token = "0x6004FC2")]
	[Address(RVA = "0xDD1B10", Offset = "0xDD0910", Length = "0x23E")]
	private void UpdateAnimatorSpeed()
	{
	}

	[Token(Token = "0x6004FC3")]
	[Address(RVA = "0xDD1D50", Offset = "0xDD0B50", Length = "0x20")]
	public void ResetStandardAimingMode()
	{
	}

	[Token(Token = "0x6004FC4")]
	[Address(RVA = "0xDD1D80", Offset = "0xDD0B80", Length = "0x39")]
	public void FullResetAimingModes()
	{
	}

	[Token(Token = "0x6004FC5")]
	[Address(RVA = "0xDD1DC0", Offset = "0xDD0BC0", Length = "0xC0")]
	public void ResetAimingModesForStruggle()
	{
	}

	[Token(Token = "0x6004FC6")]
	[Address(RVA = "0xDD1E90", Offset = "0xDD0C90", Length = "0x40")]
	public void SetTravoisValues(float travoisCameraYaw, float travoisTurnDampened)
	{
	}

	[Token(Token = "0x6004FC7")]
	[Address(RVA = "0xDD1ED0", Offset = "0xDD0CD0", Length = "0x1216")]
	public PlayerAnimation()
	{
	}
}
