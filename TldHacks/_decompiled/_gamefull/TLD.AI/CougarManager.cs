using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Logging;
using TLD.Scenes;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x2001501")]
public class CougarManager : MonoBehaviour
{
	[Token(Token = "0x2001502")]
	public enum CougarState
	{
		[Token(Token = "0x40097F9")]
		Start,
		[Token(Token = "0x40097FA")]
		WaitingForArrival,
		[Token(Token = "0x40097FB")]
		WaitingForTransition,
		[Token(Token = "0x40097FC")]
		HasArrivedAfterTransition,
		[Token(Token = "0x40097FD")]
		PlayingIntroTimeline,
		[Token(Token = "0x40097FE")]
		HasArrived
	}

	[Serializable]
	[Token(Token = "0x2001503")]
	public class Territory
	{
		[Token(Token = "0x40097FF")]
		[FieldOffset(Offset = "0x10")]
		public LocalizedString m_Name;

		[SerializeField]
		[Token(Token = "0x4009800")]
		[FieldOffset(Offset = "0x18")]
		private List<AssetReferenceSceneSet> m_RegionSceneSetReferences;

		[NonSerialized]
		[Token(Token = "0x4009801")]
		[FieldOffset(Offset = "0x20")]
		public CougarState m_CougarState;

		[NonSerialized]
		[Token(Token = "0x4009802")]
		[FieldOffset(Offset = "0x24")]
		public bool m_HasTriggeredArrivalCinematic;

		[NonSerialized]
		[Token(Token = "0x4009803")]
		[FieldOffset(Offset = "0x28")]
		public float m_NextDaysPlayedCheck;

		[Token(Token = "0x4009804")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<string> m_RegionNames;

		[Token(Token = "0x60084F2")]
		[Address(RVA = "0x126D450", Offset = "0x126C250", Length = "0x3DE")]
		public List<string> GetRegionNames()
		{
			return null;
		}

		[Token(Token = "0x60084F3")]
		[Address(RVA = "0x126D830", Offset = "0x126C630", Length = "0xAD")]
		public Territory()
		{
		}
	}

	[Token(Token = "0x40097C9")]
	public static readonly LogFilter s_LogFilter;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40097CA")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40097CB")]
	public static bool s_EnableInNewGame;

	[Token(Token = "0x40097CC")]
	public static bool s_ToggleInExistingGame;

	[Token(Token = "0x40097CD")]
	public static bool s_ShowOnScreenDebug;

	[Token(Token = "0x40097CE")]
	public static bool s_DebugPassingAttack;

	[SerializeField]
	[Token(Token = "0x40097D0")]
	[FieldOffset(Offset = "0x30")]
	private List<Territory> m_CougarTerritories;

	[SerializeField]
	[Token(Token = "0x40097D1")]
	[FieldOffset(Offset = "0x38")]
	private int m_MaxThreatLevels;

	[Tooltip("Prevent multiple events from increasing threat level in a short period of time")]
	[SerializeField]
	[Token(Token = "0x40097D2")]
	[FieldOffset(Offset = "0x3C")]
	private float m_ThreatIncreaseCooldownMinutes;

	[SerializeField]
	[Token(Token = "0x40097D3")]
	[FieldOffset(Offset = "0x40")]
	private float m_MaxNearMissDistance;

	[SerializeField]
	[Range(0f, 90f)]
	[Token(Token = "0x40097D4")]
	[FieldOffset(Offset = "0x44")]
	private float m_MaxNearMissAngleDegrees;

	[Header("Audio Events")]
	[SerializeField]
	[Token(Token = "0x40097D5")]
	[FieldOffset(Offset = "0x48")]
	private AK.Wwise.Event m_Cougar_TerritoryZone_Enter;

	[SerializeField]
	[Token(Token = "0x40097D6")]
	[FieldOffset(Offset = "0x50")]
	private AK.Wwise.Event m_Cougar_TerritoryZone_Exit;

	[SerializeField]
	[Token(Token = "0x40097D7")]
	[FieldOffset(Offset = "0x58")]
	private AK.Wwise.Event m_Cougar_NearbyOutside;

	[SerializeField]
	[Token(Token = "0x40097D8")]
	[FieldOffset(Offset = "0x60")]
	private float m_MaxNearbyAudioDistance;

	[Header("Audio States")]
	[SerializeField]
	[Token(Token = "0x40097D9")]
	[FieldOffset(Offset = "0x68")]
	private State m_CougarTerritory_ZoneThreatLevel_ctztl_0;

	[SerializeField]
	[Token(Token = "0x40097DA")]
	[FieldOffset(Offset = "0x70")]
	private State m_CougarTerritory_ZoneThreatLevel_ctztl_1;

	[SerializeField]
	[Token(Token = "0x40097DB")]
	[FieldOffset(Offset = "0x78")]
	private State m_CougarTerritory_ZoneThreatLevel_ctztl_2;

	[SerializeField]
	[Token(Token = "0x40097DC")]
	[FieldOffset(Offset = "0x80")]
	private State m_CougarTerritory_ZoneThreatLevel_ctztl_3;

	[Token(Token = "0x40097DD")]
	private static List<CougarTerritoryZoneTrigger> s_SceneTerritoryZones;

	[Token(Token = "0x40097DE")]
	private static List<CougarIntroCinematic> s_CougarIntroCinematics;

	[Token(Token = "0x40097DF")]
	private static List<CougarIntroScene> s_CougarIntroScenes;

	[Token(Token = "0x40097E0")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<string, int> m_CurrentThreatLevelByRegion;

	[Token(Token = "0x40097E1")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<string, float> m_CurrentThreatCooldownByRegion;

	[Token(Token = "0x40097E2")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<string, float> m_CurrentNearbyCougarAudioByRegion;

	[Token(Token = "0x40097E3")]
	[FieldOffset(Offset = "0xA0")]
	private string m_ActiveRegionName;

	[Token(Token = "0x40097E4")]
	[FieldOffset(Offset = "0xA8")]
	private string m_PreviousRegionName;

	[Token(Token = "0x40097E5")]
	[FieldOffset(Offset = "0xB0")]
	private Territory m_ActiveTerritory;

	[Token(Token = "0x40097E6")]
	[FieldOffset(Offset = "0xB8")]
	private List<CougarTerritoryZoneTrigger> m_TerritoryZonesEntered;

	[Token(Token = "0x40097E7")]
	private static string s_OnScreenDebugText;

	[Token(Token = "0x40097E8")]
	private static string s_AdditionalOnScreenDebugText;

	[Token(Token = "0x40097E9")]
	private static bool s_CougarSettingsOverride;

	[Token(Token = "0x40097EA")]
	[FieldOffset(Offset = "0xC0")]
	private uint m_Cougar_TerritoryZone_EnterID;

	[Token(Token = "0x40097EB")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_Cougar_TerritoryZone_ExitID;

	[Token(Token = "0x40097EC")]
	[FieldOffset(Offset = "0xC8")]
	private uint m_Cougar_NearbyOutsideID;

	[Token(Token = "0x40097ED")]
	private static int s_DebugCinematicIndex;

	[Token(Token = "0x40097EE")]
	private static bool s_DebugWaitingForComponentRegistration;

	[Token(Token = "0x40097EF")]
	private static int s_SceneTerritoryZonesCount;

	[Token(Token = "0x40097F0")]
	private static int s_CougarIntroCinematicsCount;

	[Token(Token = "0x40097F1")]
	private static int s_CougarIntroScenesCount;

	[Token(Token = "0x40097F2")]
	[FieldOffset(Offset = "0xCC")]
	private float m_DaysPlayedNotPausedAtStart;

	[Token(Token = "0x40097F3")]
	[FieldOffset(Offset = "0xD0")]
	private float m_ThreatIncreaseCooldownHours;

	[Token(Token = "0x40097F4")]
	[FieldOffset(Offset = "0xD4")]
	private int m_Version;

	[Token(Token = "0x40097F5")]
	[FieldOffset(Offset = "0xD8")]
	private HudDisplayMode m_PreviousHudMode;

	[Token(Token = "0x40097F6")]
	private static bool s_PerformingRespawn;

	[Token(Token = "0x40097F7")]
	private static bool s_PlayingCinematic;

	[Token(Token = "0x17000B78")]
	[field: Token(Token = "0x40097CF")]
	[field: FieldOffset(Offset = "0x28")]
	public bool IsEnabled
	{
		[Token(Token = "0x60084B5")]
		[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
		get;
		[Token(Token = "0x60084B6")]
		[Address(RVA = "0xE3CD40", Offset = "0xE3BB40", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x60084B7")]
	[Address(RVA = "0x12668E0", Offset = "0x12656E0", Length = "0x77")]
	public static string GetOnScreenDebugText()
	{
		return null;
	}

	[Token(Token = "0x60084B8")]
	[Address(RVA = "0x1266960", Offset = "0x1265760", Length = "0x12E")]
	public static void SetPlayerDistanceToSpawner(float distance)
	{
	}

	[Token(Token = "0x60084B9")]
	[Address(RVA = "0x1266A90", Offset = "0x1265890", Length = "0x5F")]
	public static void Debug_SetThreatLevel(int threatLevel)
	{
	}

	[Token(Token = "0x60084BA")]
	[Address(RVA = "0x1266AF0", Offset = "0x12658F0", Length = "0x8A")]
	public static int Debug_GetThreatLevel()
	{
		return 0;
	}

	[Token(Token = "0x60084BB")]
	[Address(RVA = "0x1266B80", Offset = "0x1265980", Length = "0xED")]
	public static void Debug_UpdateZoneCarcassSites()
	{
	}

	[Token(Token = "0x60084BC")]
	[Address(RVA = "0x1266C70", Offset = "0x1265A70", Length = "0x12B")]
	public static void Debug_ForceCougarArrival(bool onTransition, int index)
	{
	}

	[Token(Token = "0x60084BD")]
	[Address(RVA = "0x1266DA0", Offset = "0x1265BA0", Length = "0x54")]
	public static bool IsPlayingCinematic()
	{
		return false;
	}

	[Token(Token = "0x60084BE")]
	[Address(RVA = "0x1266E00", Offset = "0x1265C00", Length = "0x108")]
	public static void HandleLifeAfterDeathRespawn(string respawnSceneName)
	{
	}

	[Token(Token = "0x60084BF")]
	[Address(RVA = "0x1266F10", Offset = "0x1265D10", Length = "0xCE")]
	public static void RegisterTerritoryZone(CougarTerritoryZoneTrigger zone)
	{
	}

	[Token(Token = "0x60084C0")]
	[Address(RVA = "0x1266FE0", Offset = "0x1265DE0", Length = "0x83")]
	public static void UnregisterTerritoryZone(CougarTerritoryZoneTrigger zone)
	{
	}

	[Token(Token = "0x60084C1")]
	[Address(RVA = "0x1267070", Offset = "0x1265E70", Length = "0x14F")]
	public static void RegisterCougarIntroScene(CougarIntroScene scene)
	{
	}

	[Token(Token = "0x60084C2")]
	[Address(RVA = "0x12671C0", Offset = "0x1265FC0", Length = "0x83")]
	public static void UnregisterCougarIntroScene(CougarIntroScene scene)
	{
	}

	[Token(Token = "0x60084C3")]
	[Address(RVA = "0x1267250", Offset = "0x1266050", Length = "0x14F")]
	public static void RegisterCougarIntro(CougarIntroCinematic intro)
	{
	}

	[Token(Token = "0x60084C4")]
	[Address(RVA = "0x12673A0", Offset = "0x12661A0", Length = "0x83")]
	public static void UnregisterCougarIntro(CougarIntroCinematic intro)
	{
	}

	[Token(Token = "0x60084C5")]
	[Address(RVA = "0x1267430", Offset = "0x1266230", Length = "0x236")]
	private void OnBaseAiAddedToWorld(BaseAi baseAi)
	{
	}

	[Token(Token = "0x60084C6")]
	[Address(RVA = "0x1267670", Offset = "0x1266470", Length = "0x158")]
	public void OnEnterTerritoryZone(CougarTerritoryZoneTrigger zone)
	{
	}

	[Token(Token = "0x60084C7")]
	[Address(RVA = "0x12677D0", Offset = "0x12665D0", Length = "0x14F")]
	public void OnExitTerritoryZone(CougarTerritoryZoneTrigger zone)
	{
	}

	[Token(Token = "0x60084C8")]
	[Address(RVA = "0x1267920", Offset = "0x1266720", Length = "0xBB")]
	public void MaybeIncreaseThreatLevel()
	{
	}

	[Token(Token = "0x60084C9")]
	[Address(RVA = "0x12679E0", Offset = "0x12667E0", Length = "0x492")]
	public void MaybeAimNearMiss(Vector3 forward)
	{
	}

	[Token(Token = "0x60084CA")]
	[Address(RVA = "0x1267E80", Offset = "0x1266C80", Length = "0x337")]
	public void OnCougarDeath(SpawnRegion spawnRegion)
	{
	}

	[Token(Token = "0x60084CB")]
	[Address(RVA = "0x12681C0", Offset = "0x1266FC0", Length = "0x73")]
	public static void MaybeCougarArrivesAfterSleep()
	{
	}

	[Token(Token = "0x60084CC")]
	[Address(RVA = "0x1268240", Offset = "0x1267040", Length = "0x148")]
	private static float MaybeGetRespawnCooldownDay()
	{
		return 0f;
	}

	[Token(Token = "0x60084CD")]
	[Address(RVA = "0x1268390", Offset = "0x1267190", Length = "0x8E4")]
	public CougarManagerData Serialize()
	{
		return null;
	}

	[Token(Token = "0x60084CE")]
	[Address(RVA = "0x1268DD0", Offset = "0x1267BD0", Length = "0x735")]
	public void Deserialize(CougarManagerData dataProxy)
	{
	}

	[Token(Token = "0x60084CF")]
	[Address(RVA = "0x1269510", Offset = "0x1268310", Length = "0x3BF")]
	private void MaybeUpdateCougarsNearbyOnTransition()
	{
	}

	[Token(Token = "0x60084D0")]
	[Address(RVA = "0x12698D0", Offset = "0x12686D0", Length = "0x19C")]
	private Territory FindTerritory(string locID)
	{
		return null;
	}

	[Token(Token = "0x60084D1")]
	[Address(RVA = "0x1269A70", Offset = "0x1268870", Length = "0x39A")]
	private void Start()
	{
	}

	[Token(Token = "0x60084D2")]
	[Address(RVA = "0x1269E10", Offset = "0x1268C10", Length = "0x10")]
	private void InitAudio()
	{
	}

	[Token(Token = "0x60084D3")]
	[Address(RVA = "0x1269E20", Offset = "0x1268C20", Length = "0x63C")]
	private void Update()
	{
	}

	[Token(Token = "0x60084D4")]
	[Address(RVA = "0x126A480", Offset = "0x1269280", Length = "0x6B")]
	private void OnStart(Territory territory)
	{
	}

	[Token(Token = "0x60084D5")]
	[Address(RVA = "0x126A4F0", Offset = "0x12692F0", Length = "0x1A4")]
	private void MaybePlayStalkingAudio()
	{
	}

	[Token(Token = "0x60084D6")]
	[Address(RVA = "0x126A6A0", Offset = "0x12694A0", Length = "0x80")]
	private float GetDaysPlayedNotPaused()
	{
		return 0f;
	}

	[Token(Token = "0x60084D7")]
	[Address(RVA = "0x126A730", Offset = "0x1269530", Length = "0x1C5")]
	private static void MaybeHideIntroScene(bool hide)
	{
	}

	[Token(Token = "0x60084D8")]
	[Address(RVA = "0x126A900", Offset = "0x1269700", Length = "0xCC")]
	private void SetAudioState(State state)
	{
	}

	[Token(Token = "0x60084D9")]
	[Address(RVA = "0x126A9D0", Offset = "0x12697D0", Length = "0x86")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60084DA")]
	[Address(RVA = "0x126A9D0", Offset = "0x12697D0", Length = "0x86")]
	private void StopPlayingAudio()
	{
	}

	[Token(Token = "0x60084DB")]
	[Address(RVA = "0x126AA60", Offset = "0x1269860", Length = "0x14D")]
	private void SetCougarArrived(Territory territory)
	{
	}

	[Token(Token = "0x60084DC")]
	[Address(RVA = "0x126ABB0", Offset = "0x12699B0", Length = "0xB7")]
	private void DebugLog(string output)
	{
	}

	[Token(Token = "0x60084DD")]
	[Address(RVA = "0x126AC70", Offset = "0x1269A70", Length = "0x275")]
	private void MaybeSetThreatLevel(int level)
	{
	}

	[Token(Token = "0x60084DE")]
	[Address(RVA = "0x126AEF0", Offset = "0x1269CF0", Length = "0xD7")]
	private void SetRegionThreatCooldownDays(string regionName)
	{
	}

	[Token(Token = "0x60084DF")]
	[Address(RVA = "0x126AFD0", Offset = "0x1269DD0", Length = "0xAC")]
	private float GetRegionThreatCooldownDays(string regionName)
	{
		return 0f;
	}

	[Token(Token = "0x60084E0")]
	[Address(RVA = "0x126B080", Offset = "0x1269E80", Length = "0x86")]
	private void SetRegionThreatLevel(string regionName, int level)
	{
	}

	[Token(Token = "0x60084E1")]
	[Address(RVA = "0x126B110", Offset = "0x1269F10", Length = "0xA0")]
	private int GetRegionThreatLevel(string regionName)
	{
		return 0;
	}

	[Token(Token = "0x60084E2")]
	[Address(RVA = "0x126B1C0", Offset = "0x1269FC0", Length = "0x42")]
	private int GetThreatLevel()
	{
		return 0;
	}

	[Token(Token = "0x60084E3")]
	[Address(RVA = "0x126B210", Offset = "0x126A010", Length = "0x48")]
	private bool IsPlayerInTerritoryZone()
	{
		return false;
	}

	[Token(Token = "0x60084E4")]
	[Address(RVA = "0x126B260", Offset = "0x126A060", Length = "0x1CB")]
	private void MaybeUpdateSceneTerritoryZoneVolumes(int threatLevel)
	{
	}

	[Token(Token = "0x60084E5")]
	[Address(RVA = "0x126B430", Offset = "0x126A230", Length = "0x330")]
	private Territory MaybeGetCurrentTerritory(string activeRegionName = null)
	{
		return null;
	}

	[Token(Token = "0x60084E6")]
	[Address(RVA = "0x126B770", Offset = "0x126A570", Length = "0x1BB")]
	private string MaybeGetCurrentRegionName()
	{
		return null;
	}

	[Token(Token = "0x60084E7")]
	[Address(RVA = "0x126B930", Offset = "0x126A730", Length = "0x4B4")]
	private void UpdateWaitingForArrival(Territory territory, float daysPlayed)
	{
	}

	[Token(Token = "0x60084E8")]
	[Address(RVA = "0x126BDF0", Offset = "0x126ABF0", Length = "0x101")]
	private void SetCougarArrivingSoon(Territory territory)
	{
	}

	[Token(Token = "0x60084E9")]
	[Address(RVA = "0x126BF00", Offset = "0x126AD00", Length = "0xD1")]
	private void StaggerOtherTerritoryArrivalTimes(Territory territory, float arrivalTimeStaggeredDays)
	{
	}

	[Token(Token = "0x60084EA")]
	[Address(RVA = "0x126BFE0", Offset = "0x126ADE0", Length = "0x290")]
	private bool MaybePlayArrivalCinematic(Territory territory)
	{
		return false;
	}

	[Token(Token = "0x60084EB")]
	[Address(RVA = "0x126C280", Offset = "0x126B080", Length = "0x129")]
	private void OnIntroFinished()
	{
	}

	[Token(Token = "0x60084EC")]
	[Address(RVA = "0x126C3B0", Offset = "0x126B1B0", Length = "0x1FE")]
	private static CougarIntroCinematic PickCougarIntroCinematic()
	{
		return null;
	}

	[Token(Token = "0x60084ED")]
	[Address(RVA = "0x126C5B0", Offset = "0x126B3B0", Length = "0x1E3")]
	private void UpdateHasArrived(float daysPlayed)
	{
	}

	[Token(Token = "0x60084EE")]
	[Address(RVA = "0x126C7A0", Offset = "0x126B5A0", Length = "0x46B")]
	private bool CanPlayCinematic()
	{
		return false;
	}

	[Token(Token = "0x60084EF")]
	[Address(RVA = "0x126CC10", Offset = "0x126BA10", Length = "0x209")]
	private static CougarSettings GetCougarSettings(bool assumeCustomModeOverride = false)
	{
		return null;
	}

	[Token(Token = "0x60084F0")]
	[Address(RVA = "0x126CE20", Offset = "0x126BC20", Length = "0x2BB")]
	public CougarManager()
	{
	}
}
