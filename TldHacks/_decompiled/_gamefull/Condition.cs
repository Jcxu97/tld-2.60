using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

[Token(Token = "0x20001D8")]
public class Condition : MonoBehaviour
{
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentHP;

	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxHP;

	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x28")]
	public float m_CriticalHP;

	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x2C")]
	public float m_TimeToDisplayConditionWhenChanged;

	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x30")]
	public float m_TimeToDisplayConditionDelta;

	[Tooltip("This only affects the player while awake to not mess with the tuning of Rest HP increase")]
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x34")]
	public float m_HPIncreasePerDayWhileHealthy;

	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x38")]
	public float m_HPDecreasePerDayFromStarving;

	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x3C")]
	public float m_HPDecreasePerDayFromDehydration;

	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x40")]
	public float m_HPDecreasePerDayFromExhaustion;

	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x44")]
	public float m_HPDecreasePerDayFromFreezing;

	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x48")]
	public float m_SlightlyInjuredThreshold;

	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x4C")]
	public float m_InjuredThreshold;

	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x50")]
	public float m_VeryInjuredThreshold;

	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x54")]
	public float m_NearDeathThreshold;

	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x58")]
	public float m_HeartbeatThreshold;

	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x60")]
	public LocalizedString m_DeathByCougarAttackLocString;

	[SerializeField]
	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x68")]
	private AK.Wwise.Event m_SlightlyInjuredAudio;

	[SerializeField]
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x70")]
	private AK.Wwise.Event m_InjuredAudio;

	[SerializeField]
	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x78")]
	private AK.Wwise.Event m_VeryInjuredAudio;

	[SerializeField]
	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x80")]
	private AK.Wwise.Event m_NearDeathAudio;

	[SerializeField]
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x88")]
	private AK.Wwise.Event m_DieAudio;

	[SerializeField]
	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x90")]
	private AK.Wwise.Event m_DieFromWolfAudio;

	[SerializeField]
	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x98")]
	private AK.Wwise.Event m_NearDeathMusic;

	[SerializeField]
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0xA0")]
	private AK.Wwise.Event m_DeathMusic;

	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0xA8")]
	public float m_MinSecondsBetweenVoiceOverVariations;

	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0xAC")]
	public float m_MinSecondsBetweenVoiceOverVariationsWhileBleeding;

	[Range(0f, 100f)]
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0xB0")]
	public float m_HPToStartBlur;

	[Range(0f, 100f)]
	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0xB4")]
	public float m_HPForMaxBlur;

	[Tooltip("0.92 is the maximum possible motion blur as defined by the Unity script")]
	[Range(0f, 0.92f)]
	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0xB8")]
	public float m_BlurStartVal;

	[Tooltip("0.92 is the maximum possible motion blur as defined by the Unity script")]
	[Range(0f, 0.92f)]
	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0xBC")]
	public float m_BlurMaxVal;

	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0xC0")]
	public float m_EarRingingLengthIndoors;

	[Tooltip("After loud noise, the ear ringing starts fading in after this many seconds")]
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0xC4")]
	public float m_EarRingingDelay;

	[Tooltip("After loud noise and delay, the ear ringing fades in over the course of this many seconds")]
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0xC8")]
	public float m_EarRingingFadeInTime;

	[Tooltip("After loud noise, the sound muffling starts fading in after this many seconds")]
	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0xCC")]
	public float m_EarRingingMuffleDelay;

	[Tooltip("After loud noise and delay, the sound muffling fades in over the course of this many seconds")]
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0xD0")]
	public float m_EarRingingMuffleFadeInTime;

	[Range(0f, 100f)]
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0xD4")]
	public float m_SoundMufflingMaxValue;

	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0xD8")]
	public bool m_NeverDie;

	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0xD9")]
	public bool m_Invulnerable;

	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0xDA")]
	public bool m_HideDamageEvents;

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0xDB")]
	public bool m_ForceUncrouched;

	[HideInInspector]
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0xDC")]
	public int m_OverrideBlurLevel;

	[Header("Low Health Effects")]
	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0xE0")]
	public float m_ConditionBlurNoiseStepMin;

	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0xE4")]
	public float m_ConditionBlurNoiseStepMax;

	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0xE8")]
	public float m_ConditionBlurMinOffsetRange;

	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0xEC")]
	public float m_ConditionBlurMaxOffsetRange;

	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0xF0")]
	public float m_ConditionMinScreenFadeAmount;

	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0xF4")]
	public float m_ConditionMaxScreenFadeAmount;

	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0xF8")]
	public float m_ConditionBlur2Min;

	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0xFC")]
	public float m_ConditionBlur2Max;

	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x100")]
	public float m_StaggerNoiseStepMin;

	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x104")]
	public float m_StaggerNoiseStepMax;

	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x108")]
	public float m_StaggerForward;

	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x10C")]
	public float m_StaggerSide;

	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x110")]
	public float m_StaggerRoll;

	[Range(0f, 1f)]
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x114")]
	public float m_StaggerForwardMotionFrac;

	[Range(0f, 1f)]
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x118")]
	public float m_StaggerSideMotionFrac;

	[Range(0f, 1f)]
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x11C")]
	public float m_StaggerRollMotionFrac;

	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x120")]
	public float m_RestingPitchMin;

	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x124")]
	public float m_RestingPitchMax;

	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x128")]
	public float m_RestingRollMin;

	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x12C")]
	public float m_RestingRollMax;

	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x130")]
	public float m_MaxVelocityForSpeedFracCalc;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x134")]
	public float m_StaggerForceScalar;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x138")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4001053")]
	private static Vector2 m_NoiseStep;

	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x140")]
	private Vector2 m_ConditionBlurNoisePos;

	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x148")]
	private Vector2 m_StaggerNoisePos;

	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x150")]
	private float m_BasePitch;

	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x154")]
	private float m_BaseRoll;

	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x158")]
	private float m_RestingRollDirection;

	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x15C")]
	private ConditionLevel m_ConditionLevelForPreviousVoiceOver;

	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x160")]
	private float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x164")]
	private float m_TimeDisableConditionOnHUD;

	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x168")]
	private float m_HealthDelta;

	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x16C")]
	private float m_TimeStopDisplayHealthDelta;

	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x170")]
	private DamageSource m_CauseOfDeath;

	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x174")]
	private bool m_SleepingWhenKilled;

	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x178")]
	private uint m_HeartbeatAudioId;

	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x17C")]
	private uint m_EarRingingAudioId;

	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x180")]
	private float m_EarRingingAudioParam;

	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x184")]
	private float m_TimeToDelayEarRinging;

	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x188")]
	private float m_TimeToFadeEarRinging;

	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x18C")]
	private float m_TimeToDelaySoundMuffling;

	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x190")]
	private float m_TimeToFadeSoundMuffling;

	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x194")]
	private float m_LastBurnDamageEffectTime;

	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x198")]
	private float m_LastElectricalEffectTime;

	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x19C")]
	private float m_LastHeartBeatRTPCSent;

	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x1A0")]
	private float m_LastMuffleRTPCSent;

	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x1A8")]
	private MotionBlur[] m_BlurEffects;

	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x1B0")]
	private bool m_CanPlayNearDeathMusic;

	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x1B1")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400106E")]
	[FieldOffset(Offset = "0x1B2")]
	private bool m_SuppressVoiceOver;

	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0x1B4")]
	private float m_DeltaTimeAccumulator;

	[Token(Token = "0x4001070")]
	private static readonly ConditionSaveDataProxy m_ConditionSaveDataProxy;

	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x62BE00", Offset = "0x62AC00", Length = "0x278")]
	public void Start()
	{
	}

	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x62C080", Offset = "0x62AE80", Length = "0x21")]
	public bool HasLowHealthEffect()
	{
		return false;
	}

	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x62C0B0", Offset = "0x62AEB0", Length = "0xA59")]
	public void Update()
	{
	}

	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x62CB10", Offset = "0x62B910", Length = "0x207")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x62CD20", Offset = "0x62BB20", Length = "0x15B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x4AA2A0", Offset = "0x4A90A0", Length = "0x8")]
	public void ForceKill()
	{
	}

	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x62CE80", Offset = "0x62BC80", Length = "0x1D")]
	public void KillPlayer(DamageSource damageSource, string overrideCauseOfDeath = null)
	{
	}

	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x62CEA0", Offset = "0x62BCA0", Length = "0xB")]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x62CEB0", Offset = "0x62BCB0", Length = "0xB")]
	public bool IsConsideredDead()
	{
		return false;
	}

	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x62CEC0", Offset = "0x62BCC0", Length = "0xEF")]
	public void MaybeShowPainEffect(float damage)
	{
	}

	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x62CFB0", Offset = "0x62BDB0", Length = "0x13C")]
	public void ShowPainEffect(float intensity, float intervalSeconds)
	{
	}

	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x62D0F0", Offset = "0x62BEF0", Length = "0x142")]
	public void ShowElectricalEffect(float intensity, float intervalSeconds)
	{
	}

	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x62D240", Offset = "0x62C040", Length = "0x1A")]
	public void AddHealthWithNoHudNotification(float hp, DamageSource damageSource)
	{
	}

	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x62D260", Offset = "0x62C060", Length = "0x1A")]
	public void AddHealth(float hp, DamageSource cause)
	{
	}

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x62D280", Offset = "0x62C080", Length = "0x23")]
	public float GetAdjustedMaxHP()
	{
		return 0f;
	}

	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x62D2B0", Offset = "0x62C0B0", Length = "0xD6")]
	public float GetAdjustedMaxHPModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x62D390", Offset = "0x62C190", Length = "0x4B2")]
	private float GetMaxHPModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x62D850", Offset = "0x62C650", Length = "0x9C")]
	public float GetCheatDeathHPModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x62D8F0", Offset = "0x62C6F0", Length = "0x91")]
	public float GetMaxHPCap()
	{
		return 0f;
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x62D990", Offset = "0x62C790", Length = "0xBD")]
	public void DisplayConditionOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x62DA50", Offset = "0x62C850", Length = "0x14D")]
	public bool IsDegrading()
	{
		return false;
	}

	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x62DBA0", Offset = "0x62C9A0", Length = "0x402")]
	public bool HasNonRiskAffliction(bool ignorePermanentAfflictions = false)
	{
		return false;
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x62DFB0", Offset = "0x62CDB0", Length = "0x1F7")]
	public bool HasRiskAffliction()
	{
		return false;
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x62E1B0", Offset = "0x62CFB0", Length = "0x5A3")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x62E760", Offset = "0x62D560", Length = "0x40")]
	public bool HasSpecificAffliction(AfflictionType afflictionType)
	{
		return false;
	}

	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x62F190", Offset = "0x62DF90", Length = "0xD5")]
	public bool HasBuff()
	{
		return false;
	}

	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x62F270", Offset = "0x62E070", Length = "0x8B")]
	public void StartEarRinging(bool allowOutdoors = false)
	{
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x62F300", Offset = "0x62E100", Length = "0x19")]
	public void ForceStartEarRinging()
	{
	}

	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x62F320", Offset = "0x62E120", Length = "0x10")]
	public void SetCauseOfDeath(DamageSource cause)
	{
	}

	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x62F330", Offset = "0x62E130", Length = "0x3C5")]
	public string GetCauseOfDeathStringUntranslated()
	{
		return null;
	}

	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x62F700", Offset = "0x62E500", Length = "0x7")]
	public DamageSource GetCauseOfDeath()
	{
		return default(DamageSource);
	}

	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x62F710", Offset = "0x62E510", Length = "0x5B")]
	public string GetCauseOfDeathString()
	{
		return null;
	}

	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x62F770", Offset = "0x62E570", Length = "0xE1")]
	public int GetConditionValueForInterfaceDisplay()
	{
		return 0;
	}

	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x62F860", Offset = "0x62E660", Length = "0x1D")]
	public void DoFallThroughIceDeath()
	{
	}

	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x62F880", Offset = "0x62E680", Length = "0x172")]
	public bool IsPlayerVulnerable()
	{
		return false;
	}

	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x62FA00", Offset = "0x62E800", Length = "0x7")]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x62FA10", Offset = "0x62E810", Length = "0x3B9")]
	private string GetDeathFromAfflictionsUnlocalized()
	{
		return null;
	}

	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x62FDD0", Offset = "0x62EBD0", Length = "0x169")]
	private void PlayPlayerDeathAudio()
	{
	}

	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x62FF40", Offset = "0x62ED40", Length = "0x7D")]
	private void PlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x62FFC0", Offset = "0x62EDC0", Length = "0x120")]
	private void MaybeIncreaseConditionFromWillpower()
	{
	}

	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x6300F0", Offset = "0x62EEF0", Length = "0xE4")]
	private bool ShouldPlayInjuredVoiceOver()
	{
		return false;
	}

	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x6301E0", Offset = "0x62EFE0", Length = "0x3A9")]
	private void MaybePlayPlayerInjuredVoiceOver()
	{
	}

	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x630590", Offset = "0x62F390", Length = "0xEA")]
	private uint GetAfflictionSwitch()
	{
		return 0u;
	}

	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x630680", Offset = "0x62F480", Length = "0x50")]
	private ConditionLevel GetConditionLevel()
	{
		return default(ConditionLevel);
	}

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x6306D0", Offset = "0x62F4D0", Length = "0x5AC")]
	private void UpdateConditionOnHUD()
	{
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x630C80", Offset = "0x62FA80", Length = "0x27B")]
	private void UpdateHeartbeatSound()
	{
	}

	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x630F00", Offset = "0x62FD00", Length = "0x2A7")]
	private void UpdateEarRingingSound()
	{
	}

	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x6311B0", Offset = "0x62FFB0", Length = "0x1AD")]
	private void UpdateMuffleSound()
	{
	}

	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x631360", Offset = "0x630160", Length = "0xAC7")]
	private void UpdateBlurEffect(float percentCondition, bool lowHealthStagger)
	{
	}

	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x631E30", Offset = "0x630C30", Length = "0x610")]
	private void ApplyLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x632450", Offset = "0x631250", Length = "0x215")]
	private void DisableLowHealthEffects()
	{
	}

	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x632670", Offset = "0x631470", Length = "0x7B")]
	public void ResetLowHealthPitchAndRoll()
	{
	}

	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x6326F0", Offset = "0x6314F0", Length = "0x108")]
	public void PlayDeathMusic()
	{
	}

	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x632800", Offset = "0x631600", Length = "0x15B")]
	private void MaybePlayNearDeathMusic()
	{
	}

	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x632960", Offset = "0x631760", Length = "0x5A1")]
	private void AddHealth(float hp, DamageSource cause, bool showHPonHUD)
	{
	}

	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x632F10", Offset = "0x631D10", Length = "0x18")]
	private bool IsDamageSourceBlockedByClothing(DamageSource cause)
	{
		return false;
	}

	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x632F30", Offset = "0x631D30", Length = "0xB6")]
	private float GetDamageReductionForCause(DamageSource cause)
	{
		return 0f;
	}

	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x632FF0", Offset = "0x631DF0", Length = "0xDD")]
	private void SendMuffleRTPC(float audioParam)
	{
	}

	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x6330D0", Offset = "0x631ED0", Length = "0xC6")]
	private void ResetAudio()
	{
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x6331A0", Offset = "0x631FA0", Length = "0x286")]
	public static bool CanPlayConditionVO()
	{
		return false;
	}

	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x633430", Offset = "0x632230", Length = "0x7")]
	public static bool ShouldPlayFx(AfflictionOptions options)
	{
		return false;
	}

	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x633440", Offset = "0x632240", Length = "0x7")]
	public static bool ShouldDoAutoSave(AfflictionOptions options)
	{
		return false;
	}

	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x633450", Offset = "0x632250", Length = "0x169")]
	public Condition()
	{
	}
}
