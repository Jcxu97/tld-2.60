using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.BigCarry;
using TLD.GameplayTags;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20008CB")]
public class PlayerStruggle : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20008CC")]
	public class DamageEventTableOverride
	{
		[Token(Token = "0x4005C0D")]
		[FieldOffset(Offset = "0x10")]
		public DamageEventTable_WildlifeType m_WildlifeType;

		[Token(Token = "0x4005C0E")]
		[FieldOffset(Offset = "0x18")]
		public GameplayTag m_DamageEventTableTag;

		[Token(Token = "0x6005101")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DamageEventTableOverride()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20008CD")]
	public class SynchronizedAnimationInfo
	{
		[Token(Token = "0x4005C0F")]
		[FieldOffset(Offset = "0x10")]
		public string m_AIStateName;

		[NonSerialized]
		[Token(Token = "0x4005C10")]
		[FieldOffset(Offset = "0x18")]
		public int m_AIStateHash;

		[Token(Token = "0x4005C11")]
		[FieldOffset(Offset = "0x20")]
		public string m_FPStateName;

		[NonSerialized]
		[Token(Token = "0x4005C12")]
		[FieldOffset(Offset = "0x28")]
		public int m_FPStateHash;

		[Token(Token = "0x6005102")]
		[Address(RVA = "0xE1BFE0", Offset = "0xE1ADE0", Length = "0x2B")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6005103")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SynchronizedAnimationInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20008CE")]
	public class WeaponPicker
	{
		[Token(Token = "0x4005C13")]
		[FieldOffset(Offset = "0x10")]
		public float m_LaunchWeaponSelectionDelaySeconds;

		[Token(Token = "0x4005C14")]
		[FieldOffset(Offset = "0x14")]
		public float m_WeaponSelectionTimeScale;

		[Token(Token = "0x4005C15")]
		[FieldOffset(Offset = "0x18")]
		public float m_WeaponSelectionTimeSeconds;

		[Token(Token = "0x4005C16")]
		[FieldOffset(Offset = "0x1C")]
		public float m_WeaponSelectionTimeScaleTransitionDuration;

		[Token(Token = "0x4005C17")]
		[FieldOffset(Offset = "0x20")]
		public string m_WeaponSelectionSlowdownAudio;

		[Token(Token = "0x4005C18")]
		[FieldOffset(Offset = "0x28")]
		public string m_ExitAudio;

		[Token(Token = "0x6005104")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public WeaponPicker()
		{
		}
	}

	[Token(Token = "0x4005B83")]
	[FieldOffset(Offset = "0x20")]
	public float m_NearClip;

	[Range(0f, 10f)]
	[Token(Token = "0x4005B84")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxBlurSize;

	[Token(Token = "0x4005B85")]
	[FieldOffset(Offset = "0x28")]
	public float m_TapIncrement;

	[Token(Token = "0x4005B86")]
	[FieldOffset(Offset = "0x2C")]
	public float m_TapIncrementThatScalesWithFatigue;

	[Token(Token = "0x4005B87")]
	[FieldOffset(Offset = "0x30")]
	public float m_TapDecreasePerSecond;

	[Token(Token = "0x4005B88")]
	[FieldOffset(Offset = "0x34")]
	public float m_AccessibleStruggleTapsPerSecond;

	[Range(0f, 100f)]
	[Token(Token = "0x4005B89")]
	[FieldOffset(Offset = "0x38")]
	public float m_PlayerConditionLossPercentAfterBearAttack;

	[Range(0f, 100f)]
	[Token(Token = "0x4005B8A")]
	[FieldOffset(Offset = "0x3C")]
	public float m_PlayerConditionLossPercentAfterMooseAttack;

	[Range(0f, 100f)]
	[Token(Token = "0x4005B8B")]
	[FieldOffset(Offset = "0x40")]
	public float m_WolfConditionLossPercentTap;

	[Token(Token = "0x4005B8C")]
	[FieldOffset(Offset = "0x44")]
	public float m_BearDamageAfflictionDelaySeconds;

	[Token(Token = "0x4005B8D")]
	[FieldOffset(Offset = "0x48")]
	public float m_CougarDamageAfflictionDelaySeconds;

	[Token(Token = "0x4005B8E")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FleeAtConditionThreshold;

	[Token(Token = "0x4005B8F")]
	[FieldOffset(Offset = "0x50")]
	public float m_LayStunnedAfterBearAttackSeconds;

	[Token(Token = "0x4005B90")]
	[FieldOffset(Offset = "0x54")]
	public float m_LayStunnedAfterWolfAttackSeconds;

	[Token(Token = "0x4005B91")]
	[FieldOffset(Offset = "0x58")]
	public float m_ReturnCameraToStartTimeSeconds;

	[Token(Token = "0x4005B92")]
	[FieldOffset(Offset = "0x5C")]
	public float m_BlendToAnimatedCameraTimeSeconds;

	[Token(Token = "0x4005B93")]
	[FieldOffset(Offset = "0x60")]
	public float m_StartDamageAfterSecondsWolf;

	[Token(Token = "0x4005B94")]
	[FieldOffset(Offset = "0x68")]
	public string m_StruggleWithWolfAudio;

	[Token(Token = "0x4005B95")]
	[FieldOffset(Offset = "0x70")]
	public string m_StruggleWithBearAudio;

	[Token(Token = "0x4005B96")]
	[FieldOffset(Offset = "0x78")]
	public string m_StruggleWithMooseAudio;

	[Token(Token = "0x4005B97")]
	[FieldOffset(Offset = "0x80")]
	public string m_BodyFallAudio;

	[Token(Token = "0x4005B98")]
	[FieldOffset(Offset = "0x88")]
	public string m_AtlasIconUnarmed;

	[Header("Wolf damage per second")]
	[Token(Token = "0x4005B99")]
	[FieldOffset(Offset = "0x90")]
	public float m_WolfDamagePerSecondToPlayer;

	[Token(Token = "0x4005B9A")]
	[FieldOffset(Offset = "0x94")]
	public float m_WolfClothingDamagePerSecondMin;

	[Token(Token = "0x4005B9B")]
	[FieldOffset(Offset = "0x98")]
	public float m_WolfClothingDamagePerSecondMax;

	[Header("Bear damage per second")]
	[Token(Token = "0x4005B9C")]
	[FieldOffset(Offset = "0x9C")]
	public float m_BearClothingDamagePerSecondMin;

	[Token(Token = "0x4005B9D")]
	[FieldOffset(Offset = "0xA0")]
	public float m_BearClothingDamagePerSecondMax;

	[Header("Cougar damage per second")]
	[Token(Token = "0x4005B9E")]
	[FieldOffset(Offset = "0xA4")]
	public float m_CougarDamagePerSecondToPlayer;

	[Token(Token = "0x4005B9F")]
	[FieldOffset(Offset = "0xA8")]
	public float m_CougarClothingDamagePerSecondMin;

	[Token(Token = "0x4005BA0")]
	[FieldOffset(Offset = "0xAC")]
	public float m_CougarClothingDamagePerSecondMax;

	[Range(0f, 100f)]
	[Token(Token = "0x4005BA1")]
	[FieldOffset(Offset = "0xB0")]
	public float m_FleeChanceOnHit;

	[Range(0f, 100f)]
	[Token(Token = "0x4005BA2")]
	[FieldOffset(Offset = "0xB4")]
	public float m_FleeChanceOnRevolverShot;

	[Range(0f, 60f)]
	[Token(Token = "0x4005BA3")]
	[FieldOffset(Offset = "0xB8")]
	public float m_GracePeriodAfterStruggleInSeconds;

	[Token(Token = "0x4005BA4")]
	[FieldOffset(Offset = "0xBC")]
	public float m_DegradeOnUseFrequencySeconds;

	[Token(Token = "0x4005BA5")]
	[FieldOffset(Offset = "0xC0")]
	public string m_PlayMauledMuffleAudioId;

	[Token(Token = "0x4005BA6")]
	[FieldOffset(Offset = "0xC8")]
	public string m_StopMauledMuffleAudioId;

	[HideInInspector]
	[Token(Token = "0x4005BA7")]
	[FieldOffset(Offset = "0xD0")]
	public bool m_ShowDebugText;

	[HideInInspector]
	[Token(Token = "0x4005BA8")]
	[FieldOffset(Offset = "0xD4")]
	public float m_SecondsSinceLastStruggle;

	[HideInInspector]
	[Token(Token = "0x4005BA9")]
	[FieldOffset(Offset = "0xD8")]
	public int m_AnimParameter_Dead;

	[HideInInspector]
	[Token(Token = "0x4005BAA")]
	[FieldOffset(Offset = "0xDC")]
	public int m_AnimParameter_KnockedOut;

	[HideInInspector]
	[Token(Token = "0x4005BAB")]
	[FieldOffset(Offset = "0xE0")]
	public int m_AnimParameter_GetUp;

	[HideInInspector]
	[Token(Token = "0x4005BAC")]
	[FieldOffset(Offset = "0xE4")]
	public int m_AnimParameter_SkipGetUp;

	[HideInInspector]
	[Token(Token = "0x4005BAD")]
	[FieldOffset(Offset = "0xE8")]
	public int m_AnimParameter_IsDragging;

	[HideInInspector]
	[Token(Token = "0x4005BAE")]
	[FieldOffset(Offset = "0xEC")]
	public int m_AnimParameter_StruggleHeight;

	[Token(Token = "0x4005BAF")]
	[FieldOffset(Offset = "0xF0")]
	private int m_AnimParameter_SpearExhaustedGetUp;

	[Token(Token = "0x4005BB0")]
	[FieldOffset(Offset = "0xF8")]
	public BaseAi m_PartnerBaseAi;

	[Token(Token = "0x4005BB1")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_PartnerCameraBone;

	[Token(Token = "0x4005BB2")]
	[FieldOffset(Offset = "0x108")]
	private GameObject m_PartnerEffectsBone;

	[Token(Token = "0x4005BB3")]
	[FieldOffset(Offset = "0x110")]
	private GameObject m_OverrideOrigin;

	[Token(Token = "0x4005BB4")]
	[FieldOffset(Offset = "0x118")]
	private Animator m_OverrideAnimator;

	[Token(Token = "0x4005BB5")]
	[FieldOffset(Offset = "0x120")]
	private GameObject m_OverrideGameCamera;

	[Token(Token = "0x4005BB6")]
	[FieldOffset(Offset = "0x128")]
	private GameObject m_OverrideEffectsBone;

	[Token(Token = "0x4005BB7")]
	[FieldOffset(Offset = "0x130")]
	private bool m_KnockedOut;

	[Token(Token = "0x4005BB8")]
	[FieldOffset(Offset = "0x131")]
	private bool m_Active;

	[Token(Token = "0x4005BB9")]
	[FieldOffset(Offset = "0x132")]
	private bool m_SystemEnabled;

	[Token(Token = "0x4005BBA")]
	[FieldOffset(Offset = "0x134")]
	private float m_AttachTimeSeconds;

	[Token(Token = "0x4005BBB")]
	[FieldOffset(Offset = "0x138")]
	private float m_DetatchTimeSeconds;

	[Token(Token = "0x4005BBC")]
	[FieldOffset(Offset = "0x13C")]
	private float m_LayingStunnedSeconds;

	[Token(Token = "0x4005BBD")]
	[FieldOffset(Offset = "0x140")]
	private float m_StartCameraFOV;

	[Token(Token = "0x4005BBE")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 m_StartCameraPos;

	[Token(Token = "0x4005BBF")]
	[FieldOffset(Offset = "0x150")]
	private Quaternion m_StartCameraRotation;

	[Token(Token = "0x4005BC0")]
	[FieldOffset(Offset = "0x160")]
	private Vector3 m_OriginalCameraPos;

	[Token(Token = "0x4005BC1")]
	[FieldOffset(Offset = "0x16C")]
	private Vector3 m_OriginalPlayerPos;

	[Token(Token = "0x4005BC2")]
	[FieldOffset(Offset = "0x178")]
	private Quaternion m_OriginalPlayerRotation;

	[Token(Token = "0x4005BC3")]
	[FieldOffset(Offset = "0x188")]
	private Quaternion m_OriginalCameraRotation;

	[Token(Token = "0x4005BC4")]
	[FieldOffset(Offset = "0x198")]
	private float m_StruggleEndCameraFOV;

	[Token(Token = "0x4005BC5")]
	[FieldOffset(Offset = "0x19C")]
	private Vector3 m_StruggleEndCameraPos;

	[Token(Token = "0x4005BC6")]
	[FieldOffset(Offset = "0x1A8")]
	private Quaternion m_StruggleEndCameraRotation;

	[Token(Token = "0x4005BC7")]
	[FieldOffset(Offset = "0x1B8")]
	private StruggleCameraMode m_StruggleCameraMode;

	[Token(Token = "0x4005BC8")]
	[FieldOffset(Offset = "0x1BC")]
	private uint m_StrugglePredatorAudioId;

	[Token(Token = "0x4005BC9")]
	[FieldOffset(Offset = "0x1C0")]
	private float m_StruggleTimeSeconds;

	[Token(Token = "0x4005BCA")]
	[FieldOffset(Offset = "0x1C4")]
	private float m_DegradeTimeSeconds;

	[Token(Token = "0x4005BCB")]
	[FieldOffset(Offset = "0x1C8")]
	private bool m_PartnerWillFightUntilDead;

	[Token(Token = "0x4005BCC")]
	[FieldOffset(Offset = "0x1CC")]
	private float m_SavedNearClip;

	[Token(Token = "0x4005BCD")]
	[FieldOffset(Offset = "0x1D0")]
	private GearItem m_WeaponUsed;

	[Token(Token = "0x4005BCE")]
	[FieldOffset(Offset = "0x1D8")]
	private float m_WolfClothingDamagePerSecond;

	[Token(Token = "0x4005BCF")]
	[FieldOffset(Offset = "0x1DC")]
	private float m_BearClothingDamagePerSecond;

	[Token(Token = "0x4005BD0")]
	[FieldOffset(Offset = "0x1E0")]
	private float m_CougarClothingDamagePerSecond;

	[Token(Token = "0x4005BD1")]
	[FieldOffset(Offset = "0x1E4")]
	private uint m_ClothesTearingAudioId;

	[Token(Token = "0x4005BD2")]
	[FieldOffset(Offset = "0x1E8")]
	private float m_VoiceVolumeToRestore;

	[Token(Token = "0x4005BD3")]
	[FieldOffset(Offset = "0x1EC")]
	private float m_HPBeforeStruggle;

	[Token(Token = "0x4005BD4")]
	[FieldOffset(Offset = "0x1F0")]
	private float m_TapBarNormalized;

	[Token(Token = "0x4005BD5")]
	[FieldOffset(Offset = "0x1F8")]
	private UILabel m_DebugTextLabel;

	[Token(Token = "0x4005BD6")]
	[FieldOffset(Offset = "0x200")]
	public float m_SecondsPerAttackMin;

	[Token(Token = "0x4005BD7")]
	[FieldOffset(Offset = "0x204")]
	public float m_SecondsPerAttackMax;

	[Token(Token = "0x4005BD8")]
	[FieldOffset(Offset = "0x208")]
	private float m_NextAttackTime;

	[Token(Token = "0x4005BD9")]
	[FieldOffset(Offset = "0x20C")]
	public int m_DazedDropItemsMin;

	[Token(Token = "0x4005BDA")]
	[FieldOffset(Offset = "0x210")]
	public int m_DazedDropItemsMax;

	[Token(Token = "0x4005BDB")]
	[FieldOffset(Offset = "0x214")]
	public float m_DazedDropItemsRadiusMin;

	[Token(Token = "0x4005BDC")]
	[FieldOffset(Offset = "0x218")]
	public float m_DazedDropItemsRadiusMax;

	[Range(0f, 100f)]
	[Token(Token = "0x4005BDD")]
	[FieldOffset(Offset = "0x21C")]
	public int m_NormalizedPlayerConditionForDeathOnFirstAttack;

	[Token(Token = "0x4005BDE")]
	[FieldOffset(Offset = "0x220")]
	public List<SynchronizedAnimationInfo> m_WolfStruggleSynchronizedAnimationInfoList;

	[Token(Token = "0x4005BDF")]
	[FieldOffset(Offset = "0x228")]
	private float m_HPNormalizedBeforeStruggle;

	[Token(Token = "0x4005BE0")]
	[FieldOffset(Offset = "0x22C")]
	private int m_Struggle_Button_Key_Sprite_OriginalWidth;

	[Token(Token = "0x4005BE1")]
	[FieldOffset(Offset = "0x230")]
	private int m_Struggle_Button_Key_Feedback_OriginalWidth;

	[Token(Token = "0x4005BE2")]
	[FieldOffset(Offset = "0x234")]
	public float m_WolfStruggleLengthMax;

	[Token(Token = "0x4005BE3")]
	[FieldOffset(Offset = "0x238")]
	public float m_WolfBleedoutMinutes;

	[Token(Token = "0x4005BE4")]
	[FieldOffset(Offset = "0x23C")]
	private int m_TapCount;

	[Token(Token = "0x4005BE5")]
	[FieldOffset(Offset = "0x240")]
	private GearItem m_ItemInHandsAtStruggleStart;

	[Token(Token = "0x4005BE6")]
	[FieldOffset(Offset = "0x248")]
	private BigCarryItem m_DroppedBigCarryItem;

	[Token(Token = "0x4005BE7")]
	[FieldOffset(Offset = "0x250")]
	public float m_CougarStruggleLengthMax;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4005BE8")]
	[FieldOffset(Offset = "0x258")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4005BE9")]
	[FieldOffset(Offset = "0x260")]
	private PanelReference<Panel_WeaponPicker> m_WeaponPickerPanel;

	[SerializeField]
	[Token(Token = "0x4005BEA")]
	[FieldOffset(Offset = "0x268")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[Token(Token = "0x4005BEB")]
	[FieldOffset(Offset = "0x270")]
	public List<DamageEventTableOverride> m_DamageEventOverrides;

	[Token(Token = "0x4005BEC")]
	[FieldOffset(Offset = "0x278")]
	private List<uint> m_StruggleAudioIds;

	[Token(Token = "0x4005BED")]
	[FieldOffset(Offset = "0x280")]
	private bool m_CrouchDisabled;

	[Token(Token = "0x4005BEE")]
	[FieldOffset(Offset = "0x284")]
	private PlayerAnimation.CameraLayer m_CameraLayerBeforeStruggle;

	[Token(Token = "0x4005BEF")]
	[FieldOffset(Offset = "0x288")]
	private BearSpearItem m_BearSpearItem;

	[Token(Token = "0x4005BF0")]
	[FieldOffset(Offset = "0x290")]
	private bool m_IsInSpearStruggle;

	[Token(Token = "0x4005BF1")]
	[FieldOffset(Offset = "0x291")]
	private bool m_HasStartedAcceleratingTimeWhileStunned;

	[Token(Token = "0x4005BF2")]
	[FieldOffset(Offset = "0x294")]
	private BearSpearStruggleOutcome m_BearSpearStruggleOutcome;

	[Token(Token = "0x4005BF3")]
	[FieldOffset(Offset = "0x298")]
	private bool m_HasDisengagedSpearStruggle;

	[Token(Token = "0x4005BF4")]
	[FieldOffset(Offset = "0x2A0")]
	private BearHuntReduxSettings m_BearHuntReduxSettings;

	[Token(Token = "0x4005BF5")]
	[FieldOffset(Offset = "0x2A8")]
	private bool m_CanDropItems;

	[Token(Token = "0x4005BF6")]
	[FieldOffset(Offset = "0x2AC")]
	private float m_PressHoldStoredTimeSeconds;

	[Range(0f, 1f)]
	[Token(Token = "0x4005BF7")]
	[FieldOffset(Offset = "0x2B0")]
	public float m_RevolverEquippedFirePercent;

	[Range(0f, 1f)]
	[Token(Token = "0x4005BF8")]
	[FieldOffset(Offset = "0x2B4")]
	public float m_RevolverWeaponSwitchFirePercent;

	[Token(Token = "0x4005BF9")]
	[FieldOffset(Offset = "0x2B8")]
	private float m_AllowedToFirePercent;

	[Token(Token = "0x4005BFA")]
	[FieldOffset(Offset = "0x2BC")]
	private bool m_AllowedToFire;

	[Token(Token = "0x4005BFB")]
	[FieldOffset(Offset = "0x2C0")]
	public GameObject m_RevolverMuzzleFlash;

	[Token(Token = "0x4005BFC")]
	[FieldOffset(Offset = "0x2C8")]
	private bool m_IsHunted2Dragging;

	[Token(Token = "0x4005BFD")]
	[FieldOffset(Offset = "0x2C9")]
	private bool m_SynchronizeAnimationRequested;

	[Token(Token = "0x4005BFE")]
	[FieldOffset(Offset = "0x2CC")]
	private float m_BearDamageAfflictionDelayTimer;

	[Token(Token = "0x4005BFF")]
	[FieldOffset(Offset = "0x2D0")]
	private float m_CougarDamageAfflictionDelayTimer;

	[Token(Token = "0x4005C00")]
	[FieldOffset(Offset = "0x2D8")]
	public WeaponPicker m_WeaponPicker;

	[Token(Token = "0x4005C01")]
	[FieldOffset(Offset = "0x2E0")]
	private float m_ShowPickerTimer;

	[Token(Token = "0x4005C02")]
	[FieldOffset(Offset = "0x2E4")]
	private float m_PreviousTimeScaleFactor;

	[Token(Token = "0x4005C03")]
	[FieldOffset(Offset = "0x2E8")]
	private float m_TimeScalingFadingTimer;

	[Token(Token = "0x4005C04")]
	[FieldOffset(Offset = "0x2EC")]
	private float m_TimeScaledDownTimer;

	[Token(Token = "0x4005C05")]
	[FieldOffset(Offset = "0x2F0")]
	private float m_StruggleTimeScaleFactor;

	[Token(Token = "0x4005C06")]
	[FieldOffset(Offset = "0x2F4")]
	private uint m_WeaponSelectionSlowdownAudioId;

	[Token(Token = "0x4005C07")]
	[FieldOffset(Offset = "0x2F8")]
	private bool m_ShowPickerRequested;

	[Token(Token = "0x4005C08")]
	[FieldOffset(Offset = "0x2F9")]
	private bool m_ChangeWeaponRequested;

	[Token(Token = "0x4005C09")]
	[FieldOffset(Offset = "0x2FA")]
	private bool m_TimeScalingFadeOutRequested;

	[Token(Token = "0x4005C0A")]
	[FieldOffset(Offset = "0x2FB")]
	private bool m_WeaponPickerBackgroundRequested;

	[Token(Token = "0x4005C0B")]
	[FieldOffset(Offset = "0x300")]
	private List<GearItem> m_ListItems;

	[Token(Token = "0x4005C0C")]
	[FieldOffset(Offset = "0x308")]
	private GearItem m_WeaponPicked;

	[Token(Token = "0x6005084")]
	[Address(RVA = "0xE07CF0", Offset = "0xE06AF0", Length = "0x644")]
	public void Start()
	{
	}

	[Token(Token = "0x6005085")]
	[Address(RVA = "0xE08340", Offset = "0xE07140", Length = "0x112")]
	private void DegradeToolOnUse()
	{
	}

	[Token(Token = "0x6005086")]
	[Address(RVA = "0xE08460", Offset = "0xE07260", Length = "0x39")]
	public void OnMooseButtHeadAttackComplete()
	{
	}

	[Token(Token = "0x6005087")]
	[Address(RVA = "0xE084A0", Offset = "0xE072A0", Length = "0xD68")]
	public void Update()
	{
	}

	[Token(Token = "0x6005088")]
	[Address(RVA = "0xE09210", Offset = "0xE08010", Length = "0x49")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6005089")]
	[Address(RVA = "0x54AF10", Offset = "0x549D10", Length = "0x7")]
	public void SetCanDropItems(bool canDropItems)
	{
	}

	[Token(Token = "0x600508A")]
	[Address(RVA = "0xE09260", Offset = "0xE08060", Length = "0x125")]
	private void OnBearSpearDisengage()
	{
	}

	[Token(Token = "0x600508B")]
	[Address(RVA = "0xE09390", Offset = "0xE08190", Length = "0x16F")]
	private void UpdateSpear(Panel_HUD hud)
	{
	}

	[Token(Token = "0x600508C")]
	[Address(RVA = "0xE09500", Offset = "0xE08300", Length = "0x277")]
	private void UpdateTapInput(Action tapAction)
	{
	}

	[Token(Token = "0x600508D")]
	[Address(RVA = "0xE09780", Offset = "0xE08580", Length = "0x2D7")]
	private void OnPlayerDeath(Panel_HUD hud)
	{
	}

	[Token(Token = "0x600508E")]
	[Address(RVA = "0xE09A60", Offset = "0xE08860", Length = "0x564")]
	public void UpdateKeyBindingLabels()
	{
	}

	[Token(Token = "0x600508F")]
	[Address(RVA = "0xE09FD0", Offset = "0xE08DD0", Length = "0x25A")]
	private void UpdateWolf(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6005090")]
	[Address(RVA = "0xE0A230", Offset = "0xE09030", Length = "0x190")]
	private void UpdateCougar()
	{
	}

	[Token(Token = "0x6005091")]
	[Address(RVA = "0xE0A3D0", Offset = "0xE091D0", Length = "0xE5")]
	private void UpdateBear()
	{
	}

	[Token(Token = "0x6005092")]
	[Address(RVA = "0xE0A4C0", Offset = "0xE092C0", Length = "0x153")]
	private void CougarStruggleTimeOut()
	{
	}

	[Token(Token = "0x6005093")]
	[Address(RVA = "0xE0A620", Offset = "0xE09420", Length = "0x12C")]
	private void WolfStruggleTimedOut()
	{
	}

	[Token(Token = "0x6005094")]
	[Address(RVA = "0xE0A750", Offset = "0xE09550", Length = "0x33")]
	private void BearSpearStruggleTimedOut(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6005095")]
	[Address(RVA = "0xE0A790", Offset = "0xE09590", Length = "0x48")]
	private void BearSpearStruggleSuccess(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6005096")]
	[Address(RVA = "0xE0A7E0", Offset = "0xE095E0", Length = "0x7")]
	public BearSpearStruggleOutcome GetBearSpearStruggleOutcome()
	{
		return default(BearSpearStruggleOutcome);
	}

	[Token(Token = "0x6005097")]
	[Address(RVA = "0xE0A7F0", Offset = "0xE095F0", Length = "0x7")]
	public void EnableSystem(bool enable)
	{
	}

	[Token(Token = "0x6005098")]
	[Address(RVA = "0xE0A800", Offset = "0xE09600", Length = "0x8")]
	public bool IsSystemEnabled()
	{
		return false;
	}

	[Token(Token = "0x6005099")]
	[Address(RVA = "0xE0A810", Offset = "0xE09610", Length = "0x94")]
	public bool CanStruggle()
	{
		return false;
	}

	[Token(Token = "0x600509A")]
	[Address(RVA = "0xE0A8B0", Offset = "0xE096B0", Length = "0xFFE")]
	public void Begin(GameObject partner)
	{
	}

	[Token(Token = "0x600509B")]
	[Address(RVA = "0xE0B8B0", Offset = "0xE0A6B0", Length = "0x59A")]
	private void InitializeStruggle(GameObject partner)
	{
	}

	[Token(Token = "0x600509C")]
	[Address(RVA = "0xE0BE50", Offset = "0xE0AC50", Length = "0xDF5")]
	private void InitStruggleForPartner(GameObject partner)
	{
	}

	[Token(Token = "0x600509D")]
	[Address(RVA = "0xE0CC50", Offset = "0xE0BA50", Length = "0x71D")]
	private void PrepareStruggle(GameObject partner)
	{
	}

	[Token(Token = "0x600509E")]
	[Address(RVA = "0xE0D370", Offset = "0xE0C170", Length = "0x568")]
	public void BeginSpearStruggle(GameObject partner, bool isFatal)
	{
	}

	[Token(Token = "0x600509F")]
	[Address(RVA = "0xE0D8E0", Offset = "0xE0C6E0", Length = "0xB")]
	public bool IsControllingCamera()
	{
		return false;
	}

	[Token(Token = "0x60050A0")]
	[Address(RVA = "0xE0D8F0", Offset = "0xE0C6F0", Length = "0x829")]
	private void DoTap()
	{
	}

	[Token(Token = "0x60050A1")]
	[Address(RVA = "0xE0E120", Offset = "0xE0CF20", Length = "0xF")]
	private bool WaitingToRecover()
	{
		return false;
	}

	[Token(Token = "0x60050A2")]
	[Address(RVA = "0xE0E130", Offset = "0xE0CF30", Length = "0x34C")]
	public void WolfTap()
	{
	}

	[Token(Token = "0x60050A3")]
	[Address(RVA = "0xE0E480", Offset = "0xE0D280", Length = "0x106")]
	private void SpearTap()
	{
	}

	[Token(Token = "0x60050A4")]
	[Address(RVA = "0xE0E590", Offset = "0xE0D390", Length = "0x1E5")]
	public void OnTweenComplete()
	{
	}

	[Token(Token = "0x60050A5")]
	[Address(RVA = "0xE0E780", Offset = "0xE0D580", Length = "0xDB")]
	public bool InStruggle()
	{
		return false;
	}

	[Token(Token = "0x60050A6")]
	[Address(RVA = "0xE0E860", Offset = "0xE0D660", Length = "0x14")]
	public bool IsInBearSpearStruggle()
	{
		return false;
	}

	[Token(Token = "0x60050A7")]
	[Address(RVA = "0xE0E880", Offset = "0xE0D680", Length = "0x180")]
	public bool InStruggleWithMoose()
	{
		return false;
	}

	[Token(Token = "0x60050A8")]
	[Address(RVA = "0xE0EA10", Offset = "0xE0D810", Length = "0x180")]
	public bool InStruggleWIthBear()
	{
		return false;
	}

	[Token(Token = "0x60050A9")]
	[Address(RVA = "0xE0EBA0", Offset = "0xE0D9A0", Length = "0x1E4")]
	public bool InFinalAmbushStruggleWIthBear()
	{
		return false;
	}

	[Token(Token = "0x60050AA")]
	[Address(RVA = "0xE0ED90", Offset = "0xE0DB90", Length = "0x7")]
	public bool CanUseSelectedWeapon()
	{
		return false;
	}

	[Token(Token = "0x60050AB")]
	[Address(RVA = "0xE0EDA0", Offset = "0xE0DBA0", Length = "0x179")]
	public bool InStruggleWIthWolf()
	{
		return false;
	}

	[Token(Token = "0x60050AC")]
	[Address(RVA = "0xE0EF20", Offset = "0xE0DD20", Length = "0x179")]
	public bool InStruggleWithCougar()
	{
		return false;
	}

	[Token(Token = "0x60050AD")]
	[Address(RVA = "0xE0F0A0", Offset = "0xE0DEA0", Length = "0x423")]
	public void MakePartnerFlee()
	{
	}

	[Token(Token = "0x60050AE")]
	[Address(RVA = "0xE0F4D0", Offset = "0xE0E2D0", Length = "0x2E7")]
	public void OnPlayerDazed()
	{
	}

	[Token(Token = "0x60050AF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LogEvent(string eventString)
	{
	}

	[Token(Token = "0x60050B0")]
	[Address(RVA = "0xE0F7C0", Offset = "0xE0E5C0", Length = "0xDB")]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[Token(Token = "0x60050B1")]
	[Address(RVA = "0xE0F8A0", Offset = "0xE0E6A0", Length = "0x8B")]
	public void PlayStruggleAudioOneShot(string audioEventName)
	{
	}

	[Token(Token = "0x60050B2")]
	[Address(RVA = "0xE0F930", Offset = "0xE0E730", Length = "0x76")]
	public bool IsBlackedOutAfterStruggle()
	{
		return false;
	}

	[Token(Token = "0x60050B3")]
	[Address(RVA = "0xE0F9B0", Offset = "0xE0E7B0", Length = "0x74D")]
	public void GetUpAnimationComplete()
	{
	}

	[Token(Token = "0x60050B4")]
	[Address(RVA = "0xE10100", Offset = "0xE0EF00", Length = "0x2D5")]
	public float GetStunnedDurationFromParter()
	{
		return 0f;
	}

	[Token(Token = "0x60050B5")]
	[Address(RVA = "0xE103E0", Offset = "0xE0F1E0", Length = "0x242")]
	public void PlayMauledMuffle()
	{
	}

	[Token(Token = "0x60050B6")]
	[Address(RVA = "0xE10630", Offset = "0xE0F430", Length = "0x242")]
	public void StopMauledMuffle()
	{
	}

	[Token(Token = "0x60050B7")]
	[Address(RVA = "0xE10880", Offset = "0xE0F680", Length = "0x57")]
	public void StopWeaponSlowdownAudio()
	{
	}

	[Token(Token = "0x60050B8")]
	[Address(RVA = "0xE108E0", Offset = "0xE0F6E0", Length = "0x280")]
	private void StopAllAudio()
	{
	}

	[Token(Token = "0x60050B9")]
	[Address(RVA = "0xE10B70", Offset = "0xE0F970", Length = "0x263")]
	private void UpdateVoiceVolume()
	{
	}

	[Token(Token = "0x60050BA")]
	[Address(RVA = "0xE10DE0", Offset = "0xE0FBE0", Length = "0x2B6")]
	private void UpdateFadeAndBlur(GameObject EffectsBone)
	{
	}

	[Token(Token = "0x60050BB")]
	[Address(RVA = "0xE110A0", Offset = "0xE0FEA0", Length = "0x91")]
	private float GetAttachBlendTime()
	{
		return 0f;
	}

	[Token(Token = "0x60050BC")]
	[Address(RVA = "0xE11140", Offset = "0xE0FF40", Length = "0x24")]
	public bool IsAttachedToPartner()
	{
		return false;
	}

	[Token(Token = "0x60050BD")]
	[Address(RVA = "0xE11170", Offset = "0xE0FF70", Length = "0x96A")]
	private void BashCameraInterpolateToPartner()
	{
	}

	[Token(Token = "0x60050BE")]
	[Address(RVA = "0xE11AE0", Offset = "0xE108E0", Length = "0x34A")]
	private Vector3 GetOverrideGameCameraPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60050BF")]
	[Address(RVA = "0xE11E30", Offset = "0xE10C30", Length = "0x1B3")]
	private bool ShouldUseSpearExhaustedGetUp()
	{
		return false;
	}

	[Token(Token = "0x60050C0")]
	[Address(RVA = "0xE11FF0", Offset = "0xE10DF0", Length = "0x6EE")]
	private void BeginReturnToStart(BaseAi bai)
	{
	}

	[Token(Token = "0x60050C1")]
	[Address(RVA = "0xE126E0", Offset = "0xE114E0", Length = "0x621")]
	private void UpdatePlayerTransformForHunted2Dragging()
	{
	}

	[Token(Token = "0x60050C2")]
	[Address(RVA = "0xE12D10", Offset = "0xE11B10", Length = "0x17A")]
	private bool CanBeStunned()
	{
		return false;
	}

	[Token(Token = "0x60050C3")]
	[Address(RVA = "0xE12E90", Offset = "0xE11C90", Length = "0x7E9")]
	private void BashGetupDelayCamera()
	{
	}

	[Token(Token = "0x60050C4")]
	[Address(RVA = "0xE13680", Offset = "0xE12480", Length = "0x876")]
	private void BashCameraReturnToStart()
	{
	}

	[Token(Token = "0x60050C5")]
	[Address(RVA = "0xE13F00", Offset = "0xE12D00", Length = "0x7B")]
	private void BashCamera()
	{
	}

	[Token(Token = "0x60050C6")]
	[Address(RVA = "0xE13F80", Offset = "0xE12D80", Length = "0x2A6")]
	private void UpdateTapBar(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60050C7")]
	[Address(RVA = "0xE14230", Offset = "0xE13030", Length = "0xAA")]
	private bool HasFilledStruggleTapBar()
	{
		return false;
	}

	[Token(Token = "0x60050C8")]
	[Address(RVA = "0xE142E0", Offset = "0xE130E0", Length = "0x120")]
	private bool ShouldBreakStruggle()
	{
		return false;
	}

	[Token(Token = "0x60050C9")]
	[Address(RVA = "0xE14410", Offset = "0xE13210", Length = "0x352")]
	private void MaybeBreakStruggle()
	{
	}

	[Token(Token = "0x60050CA")]
	[Address(RVA = "0xE14770", Offset = "0xE13570", Length = "0xD1")]
	private bool GetCustomFireInput()
	{
		return false;
	}

	[Token(Token = "0x60050CB")]
	[Address(RVA = "0xE14850", Offset = "0xE13650", Length = "0x4ED")]
	private void MaybeShootRevolver()
	{
	}

	[Token(Token = "0x60050CC")]
	[Address(RVA = "0xE14D40", Offset = "0xE13B40", Length = "0x26D")]
	private void OnRevolverFired()
	{
	}

	[Token(Token = "0x60050CD")]
	[Address(RVA = "0xE14FB0", Offset = "0xE13DB0", Length = "0x7")]
	private void OnRevolverFiredComplete()
	{
	}

	[Token(Token = "0x60050CE")]
	[Address(RVA = "0xE14FC0", Offset = "0xE13DC0", Length = "0x1B8")]
	private void SetStartCameraRotationToLookAtPartner()
	{
	}

	[Token(Token = "0x60050CF")]
	[Address(RVA = "0xE15180", Offset = "0xE13F80", Length = "0x1A4")]
	public float GetHeightOffset()
	{
		return 0f;
	}

	[Token(Token = "0x60050D0")]
	[Address(RVA = "0xE15330", Offset = "0xE14130", Length = "0xD75")]
	public void BreakStruggle()
	{
	}

	[Token(Token = "0x60050D1")]
	[Address(RVA = "0xE160B0", Offset = "0xE14EB0", Length = "0x13F")]
	public void SpearDisengageReady()
	{
	}

	[Token(Token = "0x60050D2")]
	[Address(RVA = "0xE161F0", Offset = "0xE14FF0", Length = "0x208")]
	public void WinHunted2Challenge()
	{
	}

	[Token(Token = "0x60050D3")]
	[Address(RVA = "0xE16400", Offset = "0xE15200", Length = "0x142")]
	private void ApplyBearDamageAfflictions()
	{
	}

	[Token(Token = "0x60050D4")]
	[Address(RVA = "0xE16550", Offset = "0xE15350", Length = "0xA1")]
	private void ApplyCougarDamageAfflictions()
	{
	}

	[Token(Token = "0x60050D5")]
	[Address(RVA = "0xE16600", Offset = "0xE15400", Length = "0x345")]
	private void SetWeaponIcon(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60050D6")]
	[Address(RVA = "0xE16950", Offset = "0xE15750", Length = "0x2D8")]
	private void ApplyPlayerDamagePerSecond(float damagePerSecond, DamageSource damageCause)
	{
	}

	[Token(Token = "0x60050D7")]
	[Address(RVA = "0xE16C30", Offset = "0xE15A30", Length = "0x2B7")]
	private void ApplyClothingDamagePerSecond(float damagePerSecond)
	{
	}

	[Token(Token = "0x60050D8")]
	[Address(RVA = "0xE16EF0", Offset = "0xE15CF0", Length = "0x2F5")]
	private void ApplyDamageAfterMooseAttack(string causeLocId)
	{
	}

	[Token(Token = "0x60050D9")]
	[Address(RVA = "0xE171F0", Offset = "0xE15FF0", Length = "0x41")]
	private void ApplyMooseDamageAfterStruggleEnds()
	{
	}

	[Token(Token = "0x60050DA")]
	[Address(RVA = "0xE17240", Offset = "0xE16040", Length = "0x55B")]
	private void ApplyBearDamageAfterStruggleEnds()
	{
	}

	[Token(Token = "0x60050DB")]
	[Address(RVA = "0xE177A0", Offset = "0xE165A0", Length = "0x74")]
	private void ApplyCougarDamageAfterStruggleEnds()
	{
	}

	[Token(Token = "0x60050DC")]
	[Address(RVA = "0xE17820", Offset = "0xE16620", Length = "0x1C7")]
	private void ResetGameSettingsToNormal()
	{
	}

	[Token(Token = "0x60050DD")]
	[Address(RVA = "0xE179F0", Offset = "0xE167F0", Length = "0x14F")]
	private void UpdateDebugText()
	{
	}

	[Token(Token = "0x60050DE")]
	[Address(RVA = "0xE17B40", Offset = "0xE16940", Length = "0x4D8")]
	private float GetNextAttackTime()
	{
		return 0f;
	}

	[Token(Token = "0x60050DF")]
	[Address(RVA = "0xE18020", Offset = "0xE16E20", Length = "0x2E5")]
	private void MaybeReceiveAIAttack()
	{
	}

	[Token(Token = "0x60050E0")]
	[Address(RVA = "0xE18310", Offset = "0xE17110", Length = "0x251")]
	private DamageEventTable GetDamageEventTable(GameplayTag tag)
	{
		return null;
	}

	[Token(Token = "0x60050E1")]
	[Address(RVA = "0xE18570", Offset = "0xE17370", Length = "0x331")]
	private void ResetDamageEvents()
	{
	}

	[Token(Token = "0x60050E2")]
	[Address(RVA = "0xE188B0", Offset = "0xE176B0", Length = "0x306")]
	private void DamageEventsInitialize()
	{
	}

	[Token(Token = "0x60050E3")]
	[Address(RVA = "0xE18BC0", Offset = "0xE179C0", Length = "0x478")]
	private DamageEventTable GetActiveDamageEventTable()
	{
		return null;
	}

	[Token(Token = "0x60050E4")]
	[Address(RVA = "0xE19040", Offset = "0xE17E40", Length = "0xC8")]
	private bool ReceiveAIAttack()
	{
		return false;
	}

	[Token(Token = "0x60050E5")]
	[Address(RVA = "0xE19110", Offset = "0xE17F10", Length = "0x1EC")]
	private bool ShouldPlayDraggingAnimation(BaseAi bai, ref Quaternion overrideRotation)
	{
		return false;
	}

	[Token(Token = "0x60050E6")]
	[Address(RVA = "0xE19300", Offset = "0xE18100", Length = "0x95")]
	private bool IsHuntedBear2ChallengeEnd()
	{
		return false;
	}

	[Token(Token = "0x60050E7")]
	[Address(RVA = "0xE193A0", Offset = "0xE181A0", Length = "0x2C0")]
	private float GetFleeChanceOnHitPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60050E8")]
	[Address(RVA = "0xE19670", Offset = "0xE18470", Length = "0x21D")]
	public float GetFleeChanceOnRevolverShotPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60050E9")]
	[Address(RVA = "0xE19890", Offset = "0xE18690", Length = "0x13")]
	private bool IsBearSpearOutcomeSuccess()
	{
		return false;
	}

	[Token(Token = "0x60050EA")]
	[Address(RVA = "0xE198B0", Offset = "0xE186B0", Length = "0x18D")]
	private BearHuntReduxSettings RetrieveBearHuntReduxSettings()
	{
		return null;
	}

	[Token(Token = "0x60050EB")]
	[Address(RVA = "0xE19A40", Offset = "0xE18840", Length = "0x11")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60050EC")]
	[Address(RVA = "0xE19A60", Offset = "0xE18860", Length = "0x10B")]
	private void MaybeApplyStaminaCost(float staminaCost)
	{
	}

	[Token(Token = "0x60050ED")]
	[Address(RVA = "0xE19B70", Offset = "0xE18970", Length = "0xEF")]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[Token(Token = "0x60050EE")]
	[Address(RVA = "0xE19C60", Offset = "0xE18A60", Length = "0xEF")]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[Token(Token = "0x60050EF")]
	[Address(RVA = "0xE19D50", Offset = "0xE18B50", Length = "0x35A")]
	private void SynchronizePartnerAnimation()
	{
	}

	[Token(Token = "0x60050F0")]
	[Address(RVA = "0xE1A0B0", Offset = "0xE18EB0", Length = "0xA2")]
	private void SynchronizeAnimationState(AnimatorStateInfo partnerAnimatorStateInfo, AnimatorStateInfo fpAnimatorStateInfo, int partnerHash, int fpHash)
	{
	}

	[Token(Token = "0x60050F1")]
	[Address(RVA = "0xE1A160", Offset = "0xE18F60", Length = "0x8B")]
	private bool IsPlayerDeadOrDying()
	{
		return false;
	}

	[Token(Token = "0x60050F2")]
	[Address(RVA = "0xE1A1F0", Offset = "0xE18FF0", Length = "0x52")]
	public void OnWeaponPicked(GearItem gearItem)
	{
	}

	[Token(Token = "0x60050F3")]
	[Address(RVA = "0xE1A250", Offset = "0xE19050", Length = "0xB")]
	private void InitWeaponPicker()
	{
	}

	[Token(Token = "0x60050F4")]
	[Address(RVA = "0xE1A260", Offset = "0xE19060", Length = "0x6C")]
	private void ResetWeaponPicker()
	{
	}

	[Token(Token = "0x60050F5")]
	[Address(RVA = "0xE1A2D0", Offset = "0xE190D0", Length = "0x199")]
	private void UpdateWeaponSelection()
	{
	}

	[Token(Token = "0x60050F6")]
	[Address(RVA = "0xE1A470", Offset = "0xE19270", Length = "0x539")]
	private bool WeaponPickerBegin()
	{
		return false;
	}

	[Token(Token = "0x60050F7")]
	[Address(RVA = "0xE1A9B0", Offset = "0xE197B0", Length = "0x280")]
	private void HandleShowPickerRequested()
	{
	}

	[Token(Token = "0x60050F8")]
	[Address(RVA = "0xE1AC40", Offset = "0xE19A40", Length = "0x1C9")]
	private void PlayPickerExitAudio()
	{
	}

	[Token(Token = "0x60050F9")]
	[Address(RVA = "0xE1AE10", Offset = "0xE19C10", Length = "0x133")]
	private void OnShowPickerEnded(bool isPickerEnabled)
	{
	}

	[Token(Token = "0x60050FA")]
	[Address(RVA = "0xE1AF50", Offset = "0xE19D50", Length = "0x2E8")]
	private void HandleTimeSlowdownFadeout()
	{
	}

	[Token(Token = "0x60050FB")]
	[Address(RVA = "0xE1B240", Offset = "0xE1A040", Length = "0x159")]
	private void HandleChangeWeaponFadein()
	{
	}

	[Token(Token = "0x60050FC")]
	[Address(RVA = "0xE1B3A0", Offset = "0xE1A1A0", Length = "0x158")]
	private void MaybeInterruptPicker()
	{
	}

	[Token(Token = "0x60050FD")]
	[Address(RVA = "0xE1B500", Offset = "0xE1A300", Length = "0x683")]
	private void DoChangeWeapon()
	{
	}

	[Token(Token = "0x60050FE")]
	[Address(RVA = "0xE1BB90", Offset = "0xE1A990", Length = "0x161")]
	private void ShowPicker()
	{
	}

	[Token(Token = "0x60050FF")]
	[Address(RVA = "0xE1BD00", Offset = "0xE1AB00", Length = "0x21")]
	private bool IsWeaponPickerSelectionPending()
	{
		return false;
	}

	[Token(Token = "0x6005100")]
	[Address(RVA = "0xE1BD30", Offset = "0xE1AB30", Length = "0x2A2")]
	public PlayerStruggle()
	{
	}
}
