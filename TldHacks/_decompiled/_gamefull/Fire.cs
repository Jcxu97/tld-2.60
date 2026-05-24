using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(EffectsControllerFire))]
[Token(Token = "0x200041F")]
public class Fire : MonoBehaviour, CraftingLocationInterface
{
	[Token(Token = "0x4002516")]
	[FieldOffset(Offset = "0x20")]
	public EffectsControllerFire m_FX;

	[Token(Token = "0x4002517")]
	[FieldOffset(Offset = "0x28")]
	public bool m_StartLit;

	[Token(Token = "0x4002518")]
	[FieldOffset(Offset = "0x29")]
	public bool m_IsPerpetual;

	[Token(Token = "0x4002519")]
	[FieldOffset(Offset = "0x30")]
	public FuelSourceItem m_FuelPrefabIfLit;

	[Token(Token = "0x400251A")]
	[FieldOffset(Offset = "0x38")]
	public float m_BurnMinutesIfLit;

	[Token(Token = "0x400251B")]
	[FieldOffset(Offset = "0x3C")]
	public int m_NumStartingCharcoalPieces;

	[Token(Token = "0x400251C")]
	[FieldOffset(Offset = "0x40")]
	public float m_NumCharcoalPiecesGeneratedPerHour;

	[Token(Token = "0x400251D")]
	[FieldOffset(Offset = "0x44")]
	public int m_MaxNumCharcoal;

	[Token(Token = "0x400251E")]
	[FieldOffset(Offset = "0x48")]
	public string m_FireAudioString;

	[Tooltip("Apply temperature settings to this object's HeatSource component when this fire is turned on.")]
	[Token(Token = "0x400251F")]
	[FieldOffset(Offset = "0x50")]
	public bool m_ApplyToHeatSource;

	[Range(0f, 2f)]
	[Token(Token = "0x4002520")]
	[FieldOffset(Offset = "0x54")]
	public float m_LightIntensityMultiplier;

	[Header("Breakdown")]
	[Token(Token = "0x4002521")]
	[FieldOffset(Offset = "0x58")]
	public bool m_BreakdownEnabled;

	[Range(0f, 15f)]
	[Token(Token = "0x4002522")]
	[FieldOffset(Offset = "0x5C")]
	public float m_BreakdownRealSecondsElapsed;

	[Range(0f, 15f)]
	[Token(Token = "0x4002523")]
	[FieldOffset(Offset = "0x60")]
	public float m_BreakdownGameMinutes;

	[Token(Token = "0x4002524")]
	[FieldOffset(Offset = "0x68")]
	public string m_BreakdownAudio;

	[Header("Chimney")]
	[SerializeField]
	[Token(Token = "0x4002525")]
	[FieldOffset(Offset = "0x70")]
	private bool m_ChimneyExpected;

	[Token(Token = "0x4002526")]
	[FieldOffset(Offset = "0x78")]
	public string m_ChimneyGuid;

	[Token(Token = "0x4002527")]
	[FieldOffset(Offset = "0x80")]
	public bool m_UseClosestChimney;

	[HideInInspector]
	[Token(Token = "0x4002528")]
	[FieldOffset(Offset = "0x88")]
	public HeatSource m_HeatSource;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002529")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[Token(Token = "0x400252B")]
	[FieldOffset(Offset = "0xA0")]
	private FireState m_FireState;

	[Token(Token = "0x400252C")]
	[FieldOffset(Offset = "0xA4")]
	private FireStartingState m_FireStartingState;

	[Token(Token = "0x400252D")]
	[FieldOffset(Offset = "0xA8")]
	private float m_FireStageDurationSeconds;

	[Token(Token = "0x400252E")]
	[FieldOffset(Offset = "0xAC")]
	private float m_FireStarterUseSeconds;

	[Token(Token = "0x400252F")]
	[FieldOffset(Offset = "0xB0")]
	private float m_TinderSmolderSeconds;

	[Token(Token = "0x4002530")]
	[FieldOffset(Offset = "0xB4")]
	private float m_TinderSmallFlameSeconds;

	[Token(Token = "0x4002531")]
	[FieldOffset(Offset = "0xB8")]
	private float m_TinderMediumBurnSeconds;

	[Token(Token = "0x4002532")]
	[FieldOffset(Offset = "0xBC")]
	private float m_DurationSecondsToReduceToEmbers;

	[Token(Token = "0x4002533")]
	[FieldOffset(Offset = "0xC0")]
	private float m_EmberDurationSecondsTOD;

	[Token(Token = "0x4002534")]
	[FieldOffset(Offset = "0xC4")]
	private float m_EmberTimer;

	[Token(Token = "0x4002535")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_UseEmbers;

	[Token(Token = "0x4002536")]
	[FieldOffset(Offset = "0xCC")]
	private float m_ElapsedOnTODSeconds;

	[Token(Token = "0x4002537")]
	[FieldOffset(Offset = "0xD0")]
	private float m_ElapsedOnTODSecondsUnmodified;

	[Token(Token = "0x4002538")]
	[FieldOffset(Offset = "0xD4")]
	private float m_MaxOnTODSeconds;

	[Token(Token = "0x4002539")]
	[FieldOffset(Offset = "0xD8")]
	private uint m_FireStarterLoop;

	[Token(Token = "0x400253A")]
	[FieldOffset(Offset = "0xDC")]
	private uint m_FireLoop;

	[Token(Token = "0x400253B")]
	[FieldOffset(Offset = "0xE0")]
	private float m_FuelHeatIncrease;

	[Token(Token = "0x400253C")]
	[FieldOffset(Offset = "0xE8")]
	private DamageTrigger m_DamageTrigger;

	[Token(Token = "0x400253D")]
	[FieldOffset(Offset = "0xF0")]
	private Campfire m_Campfire;

	[Token(Token = "0x400253E")]
	[FieldOffset(Offset = "0xF8")]
	private NavMeshObstacle m_NavMeshObstacle;

	[Token(Token = "0x400253F")]
	[FieldOffset(Offset = "0x100")]
	private FuelSourceItem m_FuelUsedToStart;

	[Token(Token = "0x4002540")]
	[FieldOffset(Offset = "0x108")]
	private bool m_FullBurnTriggered;

	[Token(Token = "0x4002541")]
	[FieldOffset(Offset = "0x109")]
	private bool m_StartedByPlayer;

	[Token(Token = "0x4002542")]
	[FieldOffset(Offset = "0x10C")]
	private float m_TimeOffSeconds;

	[Token(Token = "0x4002543")]
	[FieldOffset(Offset = "0x110")]
	private SmokeTrail m_SmokeTrail;

	[Token(Token = "0x4002544")]
	[FieldOffset(Offset = "0x118")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002545")]
	private static FireSaveDataProxy m_FireSaveDataProxy;

	[Token(Token = "0x4002546")]
	[FieldOffset(Offset = "0x11C")]
	private int m_NumGeneratedCharcoalPieces;

	[Token(Token = "0x4002547")]
	[FieldOffset(Offset = "0x120")]
	private bool m_HasCollectedCharcoal;

	[Token(Token = "0x4002548")]
	[FieldOffset(Offset = "0x128")]
	private List<string> m_TrackedBurntItems;

	[Token(Token = "0x4002549")]
	[FieldOffset(Offset = "0x130")]
	private float m_BurningTimeTODHours;

	[Token(Token = "0x400254A")]
	private static bool m_IsStartingFireUIInProgress;

	[Token(Token = "0x400254B")]
	[FieldOffset(Offset = "0x134")]
	private bool m_TriggerStageRequested;

	[Token(Token = "0x400254C")]
	[FieldOffset(Offset = "0x138")]
	private Action<bool> m_OnDoneStartingFire;

	[Token(Token = "0x400254D")]
	private static Collider[] s_CookableColliderCandidates;

	[Token(Token = "0x1700020E")]
	[field: Token(Token = "0x400252A")]
	[field: FieldOffset(Offset = "0x98")]
	public string PrefabAddress
	{
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x4B3EA0", Offset = "0x4B2CA0", Length = "0x8")]
		get;
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x760E50", Offset = "0x75FC50", Length = "0x52")]
		set;
	}

	[Token(Token = "0x1700020F")]
	public bool ChimneyExpected
	{
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x664EB0", Offset = "0x663CB0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x7D16B0", Offset = "0x7D04B0", Length = "0x7FE")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x7D1EB0", Offset = "0x7D0CB0", Length = "0xBC4")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x7D2A80", Offset = "0x7D1880", Length = "0x199")]
	private float GetWeatherAdjustedElapsedDuration(float realtimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0x7D2C20", Offset = "0x7D1A20", Length = "0x41A")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x7D3040", Offset = "0x7D1E40", Length = "0x28")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0x7D3070", Offset = "0x7D1E70", Length = "0x87")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x7D3100", Offset = "0x7D1F00", Length = "0x55")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x7D3160", Offset = "0x7D1F60", Length = "0x439")]
	private void Update()
	{
	}

	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x7D35A0", Offset = "0x7D23A0", Length = "0x18F")]
	private void MaybeUpdateLongestBurningFireStat(float burnTimeInHours)
	{
	}

	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x6E1830", Offset = "0x6E0630", Length = "0x7")]
	public FireState GetFireState()
	{
		return default(FireState);
	}

	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x7D3730", Offset = "0x7D2530", Length = "0x1BF")]
	public void OnFuelBurnt(GearItem fuel)
	{
	}

	[Token(Token = "0x6001F04")]
	[Address(RVA = "0x7D38F0", Offset = "0x7D26F0", Length = "0x5DE")]
	public void AddFuel(GearItem fuel, bool inForge)
	{
	}

	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x7D3ED0", Offset = "0x7D2CD0", Length = "0x54")]
	public float GetRemainingLifeTimeSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6001F06")]
	[Address(RVA = "0x7D3F30", Offset = "0x7D2D30", Length = "0x84")]
	public float GetRemainingLifeTimeHours()
	{
		return 0f;
	}

	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x7D3FC0", Offset = "0x7D2DC0", Length = "0xDC")]
	public float GetIgnitionTotalGameTimeSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x7D40A0", Offset = "0x7D2EA0", Length = "0x455")]
	public void PlayerBeginCreate(bool attemptSuccessful, float startTimeSeconds, FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant, Action<bool> onDoneStartingFire)
	{
	}

	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x7D4500", Offset = "0x7D3300", Length = "0xCC3")]
	private void ExitFireStarting(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x7D51D0", Offset = "0x7D3FD0", Length = "0xB")]
	public bool CanFeedFire()
	{
		return false;
	}

	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x7D51E0", Offset = "0x7D3FE0", Length = "0xB")]
	public bool IsBurning()
	{
		return false;
	}

	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x7D51F0", Offset = "0x7D3FF0", Length = "0x11")]
	public float GetMinutesBurning()
	{
		return 0f;
	}

	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x7D5210", Offset = "0x7D4010", Length = "0x11")]
	public float GetUnmodifiedMinutesBurning()
	{
		return 0f;
	}

	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x74C170", Offset = "0x74AF70", Length = "0x9")]
	public float GetBurningTimeTODHours()
	{
		return 0f;
	}

	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x7D5230", Offset = "0x7D4030", Length = "0x20")]
	public bool IsEmbers()
	{
		return false;
	}

	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x7D5250", Offset = "0x7D4050", Length = "0x4CB")]
	public void FireStateSet(FireState stage)
	{
	}

	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x7D5720", Offset = "0x7D4520", Length = "0x10B")]
	public void PlayFireLoop(float blend)
	{
	}

	[Token(Token = "0x6001F12")]
	[Address(RVA = "0x7D5830", Offset = "0x7D4630", Length = "0x58")]
	public void StopFireLoop()
	{
	}

	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x7D3100", Offset = "0x7D1F00", Length = "0x55")]
	public void StopFireLoopImmediate()
	{
	}

	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x7D5890", Offset = "0x7D4690", Length = "0x336")]
	public void TurnOn(FuelSourceItem fuel, bool maskTempIncrease)
	{
	}

	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x7D5BD0", Offset = "0x7D49D0", Length = "0x17A")]
	public void TurnOff()
	{
	}

	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x7D5D50", Offset = "0x7D4B50", Length = "0x146")]
	public void TurnOffImmediate()
	{
	}

	[Token(Token = "0x6001F17")]
	[Address(RVA = "0x7D5EA0", Offset = "0x7D4CA0", Length = "0x11")]
	public void ReduceDurationByTODSeconds(float seconds)
	{
	}

	[Token(Token = "0x6001F18")]
	[Address(RVA = "0x7D5EC0", Offset = "0x7D4CC0", Length = "0x56")]
	public void ReduceHeatByDegrees(float degreesCelsius)
	{
	}

	[Token(Token = "0x6001F19")]
	[Address(RVA = "0x7D5F20", Offset = "0x7D4D20", Length = "0x1F")]
	public float GetCurrentTempIncrease()
	{
		return 0f;
	}

	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x7D5F40", Offset = "0x7D4D40", Length = "0x39")]
	public string GetHeatIncreaseText(bool includeSign = true)
	{
		return null;
	}

	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x7D5F80", Offset = "0x7D4D80", Length = "0x254")]
	public string GetHeatIncreaseText(string lastString, ref int warmth, bool includeSign)
	{
		return null;
	}

	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x7D61E0", Offset = "0x7D4FE0", Length = "0x11")]
	public void ForceBurnTimeInMinutes(float minutes)
	{
	}

	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x7D6200", Offset = "0x7D5000", Length = "0x18C")]
	public void SetSmokeTrail(SmokeTrail st)
	{
	}

	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x7D6390", Offset = "0x7D5190", Length = "0x25A")]
	public bool FireShouldBlowOutFromWind()
	{
		return false;
	}

	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x7D65F0", Offset = "0x7D53F0", Length = "0x8")]
	public bool StartedByPlayer()
	{
		return false;
	}

	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x7D6600", Offset = "0x7D5400", Length = "0x3B")]
	public bool CanBreakdownFire(bool isCustomizing = false)
	{
		return false;
	}

	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x7D6640", Offset = "0x7D5440", Length = "0xD4")]
	public bool CanTakeTorch()
	{
		return false;
	}

	[Token(Token = "0x6001F22")]
	[Address(RVA = "0x7D6720", Offset = "0x7D5520", Length = "0x69")]
	public int GetAvailableCharcoalPieces()
	{
		return 0;
	}

	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x7D6790", Offset = "0x7D5590", Length = "0x13")]
	public void RemoveAllCharcoal()
	{
	}

	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x7D67B0", Offset = "0x7D55B0", Length = "0x54")]
	public bool HasBurntItem(string itemName)
	{
		return false;
	}

	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x7D6810", Offset = "0x7D5610", Length = "0x54")]
	public static bool IsStartingFireUIInProgress()
	{
		return false;
	}

	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x7D6870", Offset = "0x7D5670", Length = "0x54")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x7D68D0", Offset = "0x7D56D0", Length = "0x2D")]
	private void CalculateStageDurations(float fireStarterUseTimeSeconds, float fireStartTimeSeconds)
	{
	}

	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x7D6900", Offset = "0x7D5700", Length = "0x238")]
	private void UpdateFireStage()
	{
	}

	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x7D6B40", Offset = "0x7D5940", Length = "0x1C7")]
	private void MaybeBlowOutFromWind()
	{
	}

	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x7D6D10", Offset = "0x7D5B10", Length = "0x23A")]
	private void UpdateFireAudio()
	{
	}

	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x7D6F50", Offset = "0x7D5D50", Length = "0x8D")]
	private float GetFireOuterRadiusScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x7D6FE0", Offset = "0x7D5DE0", Length = "0x209")]
	private void StartFireLit()
	{
	}

	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x7D71F0", Offset = "0x7D5FF0", Length = "0x240")]
	private void PlayStartingFireVoiceEvent(bool successful)
	{
	}

	[Token(Token = "0x6001F2E")]
	[Address(RVA = "0x7D7440", Offset = "0x7D6240", Length = "0xFE")]
	private uint GetStartFireUrgencySwitch()
	{
		return 0u;
	}

	[Token(Token = "0x6001F2F")]
	[Address(RVA = "0x7D7540", Offset = "0x7D6340", Length = "0x7D0")]
	private void AttachToNearbyCookables()
	{
	}

	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x7D7D20", Offset = "0x7D6B20", Length = "0x6F6")]
	private bool HasAttachedCookables()
	{
		return false;
	}

	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x7D8420", Offset = "0x7D7220", Length = "0x80")]
	private int RoundOutput(float heatToRound)
	{
		return 0;
	}

	[Token(Token = "0x6001F32")]
	[Address(RVA = "0x7D84A0", Offset = "0x7D72A0", Length = "0x6")]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[Token(Token = "0x6001F33")]
	[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x7D84B0", Offset = "0x7D72B0", Length = "0xE9")]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyToCraft()
	{
		return false;
	}

	[Token(Token = "0x6001F36")]
	[Address(RVA = "0x7D85A0", Offset = "0x7D73A0", Length = "0xAA")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Token(Token = "0x6001F37")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool HoldsCraftingResult()
	{
		return false;
	}

	[Token(Token = "0x6001F38")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void AddCraftingResult(ICraftingResult result)
	{
	}

	[Token(Token = "0x6001F39")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public Container GetContainer()
	{
		return null;
	}

	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x7D8650", Offset = "0x7D7450", Length = "0x124")]
	public Fire()
	{
	}
}
