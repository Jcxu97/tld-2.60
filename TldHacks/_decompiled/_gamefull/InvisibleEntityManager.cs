using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SpecialEvents;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000774")]
public class InvisibleEntityManager : MonoBehaviour
{
	[Token(Token = "0x2000775")]
	public enum Behavior
	{
		[Token(Token = "0x400503D")]
		Attack,
		[Token(Token = "0x400503E")]
		Countdown,
		[Token(Token = "0x400503F")]
		CountdownCompleted,
		[Token(Token = "0x4005040")]
		Done,
		[Token(Token = "0x4005041")]
		Init,
		[Token(Token = "0x4005042")]
		Load,
		[Token(Token = "0x4005043")]
		Move,
		[Token(Token = "0x4005044")]
		Ward,
		[Token(Token = "0x4005045")]
		Inactive
	}

	[Serializable]
	[Token(Token = "0x2000776")]
	public class BehaviorRange
	{
		[Token(Token = "0x4005046")]
		[FieldOffset(Offset = "0x10")]
		public LocalizedString m_DisplayName;

		[Token(Token = "0x4005047")]
		[FieldOffset(Offset = "0x18")]
		public AfflictionType m_Affliction;

		[Token(Token = "0x4005048")]
		[FieldOffset(Offset = "0x1C")]
		public float m_MinRadius;

		[Token(Token = "0x4005049")]
		[FieldOffset(Offset = "0x20")]
		public float m_MaxRadius;

		[Token(Token = "0x600462A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BehaviorRange()
		{
		}
	}

	[Token(Token = "0x2000777")]
	private enum TargetType
	{
		[Token(Token = "0x400504B")]
		Lure,
		[Token(Token = "0x400504C")]
		Player
	}

	[Token(Token = "0x2000778")]
	private struct WardData
	{
		[Token(Token = "0x400504D")]
		[FieldOffset(Offset = "0x0")]
		public string m_Guid;

		[Token(Token = "0x400504E")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 m_Position;

		[Token(Token = "0x400504F")]
		[FieldOffset(Offset = "0x14")]
		public float m_Radius;
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004FEA")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4004FEB")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Header("Movement")]
	[Token(Token = "0x4004FEC")]
	[FieldOffset(Offset = "0x30")]
	public float m_MovementSpeedMin;

	[Token(Token = "0x4004FED")]
	[FieldOffset(Offset = "0x34")]
	public float m_MovementSpeedMax;

	[Token(Token = "0x4004FEE")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve m_MovementSpeedCurve;

	[Token(Token = "0x4004FEF")]
	[FieldOffset(Offset = "0x40")]
	public float m_MaxMovementSpeedTimeMinutes;

	[Token(Token = "0x4004FF0")]
	[FieldOffset(Offset = "0x48")]
	public List<BehaviorRange> m_BehaviorRanges;

	[Token(Token = "0x4004FF1")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_WorldEntityPrefab;

	[Range(0f, 60f)]
	[Token(Token = "0x4004FF2")]
	[FieldOffset(Offset = "0x58")]
	public float m_StartMovementDelayTimerMinutes;

	[Tooltip("Scales how fast the accelerated time applies to movement. Values above 1 speed up the movement, values below slow it down, while passing time.")]
	[Range(0.01f, 10f)]
	[Token(Token = "0x4004FF3")]
	[FieldOffset(Offset = "0x5C")]
	public float m_TimePassingScalar;

	[Range(0f, 500f)]
	[Token(Token = "0x4004FF4")]
	[FieldOffset(Offset = "0x60")]
	public float m_WildlifeFleeRange;

	[Header("Footsteps")]
	[Token(Token = "0x4004FF5")]
	[FieldOffset(Offset = "0x64")]
	public SnowImprintType m_SnowImprintType;

	[Token(Token = "0x4004FF6")]
	[FieldOffset(Offset = "0x68")]
	public float m_FootstepDistance;

	[Header("Attack")]
	[Token(Token = "0x4004FF7")]
	[FieldOffset(Offset = "0x6C")]
	public float m_AttackCountdownTime;

	[Token(Token = "0x4004FF8")]
	[FieldOffset(Offset = "0x70")]
	public float m_AttackRadius;

	[Header("Spawn")]
	[Token(Token = "0x4004FF9")]
	[FieldOffset(Offset = "0x74")]
	public float m_SpawnDistanceFromPlayer;

	[Header("Ward")]
	[Tooltip("How fast the entity rotates around the ward radius when hovering. This is in degrees per second.")]
	[Token(Token = "0x4004FFA")]
	[FieldOffset(Offset = "0x78")]
	public float m_HoverRotationSpeedDegrees;

	[Token(Token = "0x4004FFB")]
	[FieldOffset(Offset = "0x7C")]
	public float m_SprayWardRadius;

	[Tooltip("This value gets added to a ward's radius to figure how close the entity needs to be to start circling.")]
	[Token(Token = "0x4004FFC")]
	[FieldOffset(Offset = "0x80")]
	public float m_WardHoverAddedRadius;

	[Tooltip("The radius in which if a ward is placed this close to a transition area, that area will be considered protected.")]
	[Token(Token = "0x4004FFD")]
	[FieldOffset(Offset = "0x84")]
	public float m_WardTransitionAreaRadius;

	[Header("Distance Indicator")]
	[Token(Token = "0x4004FFE")]
	[FieldOffset(Offset = "0x88")]
	public float m_IndicatorMinDistanceMeters;

	[Token(Token = "0x4004FFF")]
	[FieldOffset(Offset = "0x8C")]
	public float m_IndicatorMaxDistanceMeters;

	[Header("Audio")]
	[Range(0f, 1f)]
	[Token(Token = "0x4005000")]
	[FieldOffset(Offset = "0x90")]
	public float m_AudioIntesity;

	[Token(Token = "0x4005001")]
	[FieldOffset(Offset = "0x98")]
	public string m_AttackFailureEvent;

	[Token(Token = "0x4005002")]
	[FieldOffset(Offset = "0xA0")]
	public string m_AttackStartEvent;

	[Token(Token = "0x4005003")]
	[FieldOffset(Offset = "0xA8")]
	public string m_AttackSuccessEvent;

	[Token(Token = "0x4005004")]
	[FieldOffset(Offset = "0xB0")]
	public string m_AttackWindupEvent;

	[Token(Token = "0x4005005")]
	[FieldOffset(Offset = "0xB8")]
	public string m_FootstepEvent;

	[Token(Token = "0x4005006")]
	[FieldOffset(Offset = "0xC0")]
	public string m_LureDestroyedEvent;

	[Range(0f, 10f)]
	[Token(Token = "0x4005007")]
	[FieldOffset(Offset = "0xC8")]
	public float m_AttackWindupTime;

	[Token(Token = "0x4005008")]
	[FieldOffset(Offset = "0xD0")]
	public string m_CountdownAudioEvent;

	[Token(Token = "0x4005009")]
	[FieldOffset(Offset = "0xD8")]
	public float m_DelayBetweenCaptions;

	[Token(Token = "0x400500A")]
	[FieldOffset(Offset = "0xDC")]
	public float m_CaptionDisplayTime;

	[Range(0f, 500f)]
	[Token(Token = "0x400500B")]
	[FieldOffset(Offset = "0xE0")]
	public float m_SuppressPlayerVoiceAtDistance;

	[Tooltip("Used for indoor entity footsteps, to force the indoor surface type if a surface cannot be found.")]
	[Token(Token = "0x400500C")]
	[FieldOffset(Offset = "0xE8")]
	public string m_IndoorFootstepDefaultSurfaceTag;

	[Header("Death Animation")]
	[Token(Token = "0x400500D")]
	[FieldOffset(Offset = "0xF0")]
	public float m_DarkWalkerDeathAnimationSafeDistance;

	[Token(Token = "0x400500E")]
	[FieldOffset(Offset = "0xF4")]
	public float m_DarkWalkerDeathAnimationSafeRadius;

	[Token(Token = "0x400500F")]
	[FieldOffset(Offset = "0xF8")]
	public List<string> m_AudioStartEvents;

	[Token(Token = "0x4005010")]
	[FieldOffset(Offset = "0x100")]
	public List<string> m_AudioStopEvents;

	[Token(Token = "0x4005011")]
	public static bool s_IsPaused;

	[Token(Token = "0x4005012")]
	public static bool s_DebugEnable;

	[Token(Token = "0x4005013")]
	private const int INVALID_INDEX = -1;

	[Token(Token = "0x4005014")]
	[FieldOffset(Offset = "0x108")]
	private DarkWalker m_DarkWalker;

	[Token(Token = "0x4005015")]
	[FieldOffset(Offset = "0x110")]
	private float m_AttackMovementSpeed;

	[Token(Token = "0x4005016")]
	[FieldOffset(Offset = "0x114")]
	private float m_AttackTime;

	[Token(Token = "0x4005017")]
	[FieldOffset(Offset = "0x118")]
	private Behavior m_BehaviorState;

	[Token(Token = "0x4005018")]
	[FieldOffset(Offset = "0x11C")]
	private int m_BehaviorIndex;

	[Token(Token = "0x4005019")]
	[FieldOffset(Offset = "0x120")]
	private uint m_CountdownAudioID;

	[Token(Token = "0x400501A")]
	[FieldOffset(Offset = "0x124")]
	private float m_DistanceToTarget;

	[Token(Token = "0x400501B")]
	[FieldOffset(Offset = "0x128")]
	private float m_DistanceToPlayer;

	[Token(Token = "0x400501C")]
	[FieldOffset(Offset = "0x130")]
	private string m_LastFootstepTag;

	[Token(Token = "0x400501D")]
	[FieldOffset(Offset = "0x138")]
	private float m_MovementSpeedScalar;

	[Token(Token = "0x400501E")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 m_TargetLocation;

	[Token(Token = "0x400501F")]
	[FieldOffset(Offset = "0x148")]
	private TargetType m_TargetType;

	[Token(Token = "0x4005020")]
	[FieldOffset(Offset = "0x150")]
	private GameObject m_WorldEntityInstance;

	[Token(Token = "0x4005021")]
	[FieldOffset(Offset = "0x158")]
	private Vector3 m_WorldPosition;

	[Token(Token = "0x4005022")]
	[FieldOffset(Offset = "0x164")]
	private Vector3 m_WorldPositionPrevious;

	[Token(Token = "0x4005023")]
	[FieldOffset(Offset = "0x170")]
	private float m_DistanceSinceLastFootstep;

	[Token(Token = "0x4005024")]
	[FieldOffset(Offset = "0x174")]
	private bool m_IsLeftFoot;

	[Token(Token = "0x4005025")]
	[FieldOffset(Offset = "0x178")]
	private FootstepTrail m_FootstepTrail;

	[Token(Token = "0x4005026")]
	[FieldOffset(Offset = "0x180")]
	private BehaviorRange m_CurrentRange;

	[Token(Token = "0x4005027")]
	[FieldOffset(Offset = "0x188")]
	private Vector3 m_EntityToPlayerPosition;

	[Token(Token = "0x4005028")]
	[FieldOffset(Offset = "0x194")]
	public float m_EntityToPlayerOrientation;

	[Token(Token = "0x4005029")]
	[FieldOffset(Offset = "0x198")]
	private float m_LastMovementSpeed;

	[Token(Token = "0x400502A")]
	[FieldOffset(Offset = "0x19C")]
	private float m_FearMaxRange;

	[Token(Token = "0x400502B")]
	[FieldOffset(Offset = "0x1A0")]
	private float m_AnxietyMaxRange;

	[Token(Token = "0x400502C")]
	[FieldOffset(Offset = "0x1A4")]
	private float m_FearAlpha;

	[Token(Token = "0x400502D")]
	[FieldOffset(Offset = "0x1A8")]
	private float m_AnxietyAlpha;

	[Token(Token = "0x400502E")]
	[FieldOffset(Offset = "0x1AC")]
	private float m_StartMovementDelayTimeSeconds;

	[Token(Token = "0x400502F")]
	[FieldOffset(Offset = "0x1B0")]
	private float m_AccumulatedTimeSeconds;

	[Token(Token = "0x4005030")]
	[FieldOffset(Offset = "0x1B4")]
	private float m_AccumulatedRealTimeSeconds;

	[Token(Token = "0x4005031")]
	[FieldOffset(Offset = "0x1B8")]
	private List<WardData> m_Wards;

	[Token(Token = "0x4005032")]
	[FieldOffset(Offset = "0x1C0")]
	private List<IndoorWardData> m_IndoorWardLocations;

	[Token(Token = "0x4005033")]
	[FieldOffset(Offset = "0x1C8")]
	private List<string> m_RemoveGuids;

	[Token(Token = "0x4005034")]
	[FieldOffset(Offset = "0x1D0")]
	private int m_ActiveWard;

	[Token(Token = "0x4005035")]
	[FieldOffset(Offset = "0x1D4")]
	private float m_HoverRotationDirection;

	[Token(Token = "0x4005036")]
	[FieldOffset(Offset = "0x1D8")]
	private List<DecalProjectorInstance> m_PlacedGlyphsDeserialize;

	[Token(Token = "0x4005037")]
	[FieldOffset(Offset = "0x1E0")]
	private int m_PlayerInsideWard;

	[Token(Token = "0x4005038")]
	[FieldOffset(Offset = "0x1E8")]
	private SphereCollider m_BanishmentAreaCollider;

	[Token(Token = "0x4005039")]
	private static Collider[] s_transitionAreaColliders;

	[Token(Token = "0x400503A")]
	[FieldOffset(Offset = "0x1F0")]
	private float m_MovementSpeedOverride;

	[Token(Token = "0x400503B")]
	[FieldOffset(Offset = "0x1F4")]
	private float m_NextCaptionDisplayTime;

	[Token(Token = "0x60045DD")]
	[Address(RVA = "0xC94680", Offset = "0xC93480", Length = "0x8A")]
	public NowhereToHide.GlyphTypes GetActiveGlyph()
	{
		return default(NowhereToHide.GlyphTypes);
	}

	[Token(Token = "0x60045DE")]
	[Address(RVA = "0xC94710", Offset = "0xC93510", Length = "0xA7")]
	public void AddWardIncludingForNearbyTransitions(DecalProjectorInstance instance, float radius)
	{
	}

	[Token(Token = "0x60045DF")]
	[Address(RVA = "0xC947C0", Offset = "0xC935C0", Length = "0x2E6")]
	public void AddWard(string guid, Vector3 position, float radius)
	{
	}

	[Token(Token = "0x60045E0")]
	[Address(RVA = "0xC94AB0", Offset = "0xC938B0", Length = "0x92")]
	public string GetPlayerInsideWardGuid()
	{
		return null;
	}

	[Token(Token = "0x60045E1")]
	[Address(RVA = "0xC94B50", Offset = "0xC93950", Length = "0x9B")]
	public string GetActiveWardGuid()
	{
		return null;
	}

	[Token(Token = "0x60045E2")]
	[Address(RVA = "0xC94BF0", Offset = "0xC939F0", Length = "0x76")]
	public bool DoesWardGlyphExist()
	{
		return false;
	}

	[Token(Token = "0x60045E3")]
	[Address(RVA = "0xC94C70", Offset = "0xC93A70", Length = "0xB")]
	public bool IsPlayerInsideWard()
	{
		return false;
	}

	[Token(Token = "0x60045E4")]
	[Address(RVA = "0xC94C80", Offset = "0xC93A80", Length = "0xB")]
	public bool IsWardActive()
	{
		return false;
	}

	[Token(Token = "0x60045E5")]
	[Address(RVA = "0xC94C90", Offset = "0xC93A90", Length = "0x8E")]
	public bool IsLureActive()
	{
		return false;
	}

	[Token(Token = "0x60045E6")]
	[Address(RVA = "0xC94D20", Offset = "0xC93B20", Length = "0x7")]
	public Behavior GetBehaviorState()
	{
		return default(Behavior);
	}

	[Token(Token = "0x60045E7")]
	[Address(RVA = "0xC94D30", Offset = "0xC93B30", Length = "0x9")]
	public float GetStartMovementDelayTime()
	{
		return 0f;
	}

	[Token(Token = "0x60045E8")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x60045E9")]
	[Address(RVA = "0xC94D40", Offset = "0xC93B40", Length = "0x9")]
	public float GetDistanceToPlayer()
	{
		return 0f;
	}

	[Token(Token = "0x60045EA")]
	[Address(RVA = "0xC94D50", Offset = "0xC93B50", Length = "0x5A")]
	public void PlaceGlyphDeserialize(DecalProjectorInstance instance)
	{
	}

	[Token(Token = "0x60045EB")]
	[Address(RVA = "0xC94DB0", Offset = "0xC93BB0", Length = "0x121")]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[Token(Token = "0x60045EC")]
	[Address(RVA = "0xC94EE0", Offset = "0xC93CE0", Length = "0x21F")]
	public void RemoveGlyph(DecalProjectorInstance instance)
	{
	}

	[Token(Token = "0x60045ED")]
	[Address(RVA = "0xC95100", Offset = "0xC93F00", Length = "0x435")]
	public void Reset(bool forceDone = false)
	{
	}

	[Token(Token = "0x60045EE")]
	[Address(RVA = "0xC95540", Offset = "0xC94340", Length = "0xFF")]
	public void Move(float distance)
	{
	}

	[Token(Token = "0x60045EF")]
	[Address(RVA = "0xC95640", Offset = "0xC94440", Length = "0x11")]
	public float GetRealTimeHoursPlayedUnpaused()
	{
		return 0f;
	}

	[Token(Token = "0x60045F0")]
	[Address(RVA = "0xC95660", Offset = "0xC94460", Length = "0x4F")]
	public bool IsInAreaOfSceneTransition(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x60045F1")]
	[Address(RVA = "0xC956B0", Offset = "0xC944B0", Length = "0x13C")]
	public void SetBanishmentArea(NowhereToHide_BanishmentArea banishmentArea)
	{
	}

	[Token(Token = "0x60045F2")]
	[Address(RVA = "0xC957F0", Offset = "0xC945F0", Length = "0x9")]
	public void SetMovementSpeedOverride(float speed)
	{
	}

	[Token(Token = "0x60045F3")]
	[Address(RVA = "0xC95800", Offset = "0xC94600", Length = "0x208")]
	public bool IsInsideBanishmentArea(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x60045F4")]
	[Address(RVA = "0xC95A10", Offset = "0xC94810", Length = "0x1C1")]
	public bool IsEntityInBanishmentArea()
	{
		return false;
	}

	[Token(Token = "0x60045F5")]
	[Address(RVA = "0xC95BE0", Offset = "0xC949E0", Length = "0x2A9")]
	public float GetWardTimeRemainingScale(string guid)
	{
		return 0f;
	}

	[Token(Token = "0x60045F6")]
	[Address(RVA = "0xC95E90", Offset = "0xC94C90", Length = "0x499")]
	private IndoorWardData FindNearestSceneTransition(Vector3 position)
	{
		return default(IndoorWardData);
	}

	[Token(Token = "0x60045F7")]
	[Address(RVA = "0xC96330", Offset = "0xC95130", Length = "0x36A")]
	private void AttemptToPlaceIndoorLocationWard(Vector3 position, string guid, float radius, float lifetimeHours, float hoursAtCreateTime)
	{
	}

	[Token(Token = "0x60045F8")]
	[Address(RVA = "0xC966A0", Offset = "0xC954A0", Length = "0x16E")]
	private bool IsIndoorWardLocationForCurrentScene(IndoorWardData wardData)
	{
		return false;
	}

	[Token(Token = "0x60045F9")]
	[Address(RVA = "0xC96810", Offset = "0xC95610", Length = "0x1AB")]
	public bool HasIndoorWardProtectionForCurrentScene()
	{
		return false;
	}

	[Token(Token = "0x60045FA")]
	[Address(RVA = "0xC969C0", Offset = "0xC957C0", Length = "0x288")]
	private void MaybeApplyIndoorWardProtection()
	{
	}

	[Token(Token = "0x60045FB")]
	[Address(RVA = "0xC96C50", Offset = "0xC95A50", Length = "0x8B")]
	private float DetermineDistanceToPlayer()
	{
		return 0f;
	}

	[Token(Token = "0x60045FC")]
	[Address(RVA = "0xC96CE0", Offset = "0xC95AE0", Length = "0x29B")]
	private void Start()
	{
	}

	[Token(Token = "0x60045FD")]
	[Address(RVA = "0xC96F80", Offset = "0xC95D80", Length = "0x240")]
	private void Update()
	{
	}

	[Token(Token = "0x60045FE")]
	[Address(RVA = "0xC97550", Offset = "0xC96350", Length = "0x499")]
	private void MaybeMakeWildlifeFlee()
	{
	}

	[Token(Token = "0x60045FF")]
	[Address(RVA = "0xC979F0", Offset = "0xC967F0", Length = "0x128")]
	private float DetermineMovementSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6004600")]
	[Address(RVA = "0xC97B20", Offset = "0xC96920", Length = "0x1C2")]
	private float DetermineScaledDeltaTime()
	{
		return 0f;
	}

	[Token(Token = "0x6004601")]
	[Address(RVA = "0xC97CF0", Offset = "0xC96AF0", Length = "0x91")]
	private bool DeterminePlayerActiveWard()
	{
		return false;
	}

	[Token(Token = "0x6004602")]
	[Address(RVA = "0xC97D90", Offset = "0xC96B90", Length = "0x13A")]
	private Vector3 DeterminePlayerPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004603")]
	[Address(RVA = "0xC97ED0", Offset = "0xC96CD0", Length = "0x54")]
	private Vector3 DetermineTargetPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004604")]
	[Address(RVA = "0xC97F30", Offset = "0xC96D30", Length = "0x59")]
	private bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6004605")]
	[Address(RVA = "0xC97F90", Offset = "0xC96D90", Length = "0x18B")]
	private int FindWardThatOverlapsPosition(Vector3 pos)
	{
		return 0;
	}

	[Token(Token = "0x6004606")]
	[Address(RVA = "0xC98120", Offset = "0xC96F20", Length = "0x8A")]
	private BehaviorRange GetCurrentRange()
	{
		return null;
	}

	[Token(Token = "0x6004607")]
	[Address(RVA = "0xC981B0", Offset = "0xC96FB0", Length = "0x9")]
	public float GetMovementSpeedScalar()
	{
		return 0f;
	}

	[Token(Token = "0x6004608")]
	[Address(RVA = "0xC981C0", Offset = "0xC96FC0", Length = "0x22A")]
	private void MoveAwayFromTarget(float speed)
	{
	}

	[Token(Token = "0x6004609")]
	[Address(RVA = "0xC983F0", Offset = "0xC971F0", Length = "0x22F")]
	private void MoveTowardsTarget(float speed)
	{
	}

	[Token(Token = "0x600460A")]
	[Address(RVA = "0xC98620", Offset = "0xC97420", Length = "0x9C")]
	private void HandleFootprintsForDespawn()
	{
	}

	[Token(Token = "0x600460B")]
	[Address(RVA = "0xC986C0", Offset = "0xC974C0", Length = "0x3D")]
	private bool IsEntityWithinCurrentRange()
	{
		return false;
	}

	[Token(Token = "0x600460C")]
	[Address(RVA = "0xC98700", Offset = "0xC97500", Length = "0x677")]
	private void MaybePlaceFootstep()
	{
	}

	[Token(Token = "0x600460D")]
	[Address(RVA = "0xC98D80", Offset = "0xC97B80", Length = "0xDE8")]
	private void PlaceFootstep(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x600460E")]
	[Address(RVA = "0xC99B90", Offset = "0xC98990", Length = "0x445")]
	private static HeavyFootstepEffectType GetHeavyFootstepEffectTypeBasedOnMaterial(string tag)
	{
		return default(HeavyFootstepEffectType);
	}

	[Token(Token = "0x600460F")]
	[Address(RVA = "0xC99FE0", Offset = "0xC98DE0", Length = "0x237")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6004610")]
	[Address(RVA = "0xC9A220", Offset = "0xC99020", Length = "0x1DE")]
	private void PlayAudioEvent(string evt)
	{
	}

	[Token(Token = "0x6004611")]
	[Address(RVA = "0xC9A400", Offset = "0xC99200", Length = "0x14F")]
	private void PlayStartAudio()
	{
	}

	[Token(Token = "0x6004612")]
	[Address(RVA = "0xC9A550", Offset = "0xC99350", Length = "0x24A")]
	private void PlayStopAudio()
	{
	}

	[Token(Token = "0x6004613")]
	[Address(RVA = "0xC9A7A0", Offset = "0xC995A0", Length = "0x1F7")]
	private void SetBehaviour(Behavior newBehaviour)
	{
	}

	[Token(Token = "0x6004614")]
	[Address(RVA = "0xC9A9A0", Offset = "0xC997A0", Length = "0x1DE")]
	public void RemoveWardByGuid(string guid)
	{
	}

	[Token(Token = "0x6004615")]
	[Address(RVA = "0xC9AB80", Offset = "0xC99980", Length = "0x38C")]
	public void Spawn()
	{
	}

	[Token(Token = "0x6004616")]
	[Address(RVA = "0xC9AF10", Offset = "0xC99D10", Length = "0x10")]
	public void SetMovementSpeedScalar(float scalar)
	{
	}

	[Token(Token = "0x6004617")]
	[Address(RVA = "0xC9AF20", Offset = "0xC99D20", Length = "0x9")]
	public void SetStartMovementDelayTime(float delayTimeSeconds)
	{
	}

	[Token(Token = "0x6004618")]
	[Address(RVA = "0xC9AF30", Offset = "0xC99D30", Length = "0x408")]
	public void SetRange(bool isNear)
	{
	}

	[Token(Token = "0x6004619")]
	[Address(RVA = "0xC9B340", Offset = "0xC9A140", Length = "0x427")]
	private void UpdateAttack()
	{
	}

	[Token(Token = "0x600461A")]
	[Address(RVA = "0xC9B770", Offset = "0xC9A570", Length = "0x24A")]
	private void UpdateAudio()
	{
	}

	[Token(Token = "0x600461B")]
	[Address(RVA = "0xC9B9C0", Offset = "0xC9A7C0", Length = "0x163")]
	private void UpdateCountdown()
	{
	}

	[Token(Token = "0x600461C")]
	[Address(RVA = "0xC9BB30", Offset = "0xC9A930", Length = "0x2DB")]
	private void UpdateCountdownCompleted()
	{
	}

	[Token(Token = "0x600461D")]
	[Address(RVA = "0xC9BE10", Offset = "0xC9AC10", Length = "0x93")]
	private void UpdateInit()
	{
	}

	[Token(Token = "0x600461E")]
	[Address(RVA = "0xC9BEB0", Offset = "0xC9ACB0", Length = "0x841")]
	private void UpdateLoad()
	{
	}

	[Token(Token = "0x600461F")]
	[Address(RVA = "0xC9C700", Offset = "0xC9B500", Length = "0x3F0")]
	private void UpdateMovement()
	{
	}

	[Token(Token = "0x6004620")]
	[Address(RVA = "0xC9CB00", Offset = "0xC9B900", Length = "0x95")]
	private void RemoveDecal(ProjectileType projectileType)
	{
	}

	[Token(Token = "0x6004621")]
	[Address(RVA = "0xC9CBA0", Offset = "0xC9B9A0", Length = "0x44A")]
	private void UpdateIndoorWardLifetime()
	{
	}

	[Token(Token = "0x6004622")]
	[Address(RVA = "0xC9CFF0", Offset = "0xC9BDF0", Length = "0x67E")]
	private void UpdateWard()
	{
	}

	[Token(Token = "0x6004623")]
	[Address(RVA = "0xC9D670", Offset = "0xC9C470", Length = "0x312")]
	private void UpdateAfflictionUI()
	{
	}

	[Token(Token = "0x6004624")]
	[Address(RVA = "0xC9D990", Offset = "0xC9C790", Length = "0xF0")]
	private void CalculateAfflictionRanges()
	{
	}

	[Token(Token = "0x6004625")]
	[Address(RVA = "0xC9DA90", Offset = "0xC9C890", Length = "0x365")]
	public string SerializeGlobal()
	{
		return null;
	}

	[Token(Token = "0x6004626")]
	[Address(RVA = "0xC9DE00", Offset = "0xC9CC00", Length = "0x1D3")]
	public void DeserializeGlobal(string serialized)
	{
	}

	[Token(Token = "0x6004627")]
	[Address(RVA = "0xC9DFE0", Offset = "0xC9CDE0", Length = "0x2A9")]
	public bool CanPlayDarkWalkerDeathAnimation()
	{
		return false;
	}

	[Token(Token = "0x6004628")]
	[Address(RVA = "0xC9E290", Offset = "0xC9D090", Length = "0x52B")]
	public InvisibleEntityManager()
	{
	}
}
