using System;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Utility;
using UnityEngine;

[Token(Token = "0x2000452")]
public class ArrowItem : MonoBehaviour
{
	[Token(Token = "0x2000453")]
	internal struct SurfaceResponseInfo
	{
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x0")]
		internal float surfaceHardness;

		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x4")]
		internal float deflectScalar;

		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x8")]
		internal Vector2 impactVelocityScalars;

		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x10")]
		internal ArrowImpactEffectType impactEffect;
	}

	[Token(Token = "0x4002714")]
	private const float ARROW_LENGTH = 0.76f;

	[Token(Token = "0x4002715")]
	private const float CENTER_OF_MASS_FRAC = 0.23f;

	[Token(Token = "0x4002716")]
	private const float MAX_EMBED_FRAC = 0.5f;

	[Token(Token = "0x4002717")]
	private const float MIN_PIERCE_VEL_BY_SURFACE_SCALE = 0.95f;

	[Token(Token = "0x4002718")]
	private const float MAX_FALL_OUT_TIME = 1f;

	[Token(Token = "0x4002719")]
	private const float MIN_STICK_IN_DEPTH = 0.015f;

	[Token(Token = "0x400271A")]
	private const float MIN_STICK_IN_RANDOM_COMPONENT = 0.01f;

	[Token(Token = "0x400271B")]
	private const float SOFTEST_DEFLECT_ANGLE = 75f;

	[Token(Token = "0x400271C")]
	private const float HARDEST_DEFLECT_ANGLE = 0f;

	[Token(Token = "0x400271D")]
	private const float MIN_TIME_BETWEEN_HIT_EFFECTS = 0.1f;

	[Token(Token = "0x400271E")]
	private const float MIN_VELOCITY_FOR_HIT_EFFECT_SQR = 2f;

	[Token(Token = "0x400271F")]
	private const float MAX_SINGLE_IMPACT_DAMAGE = 50f;

	[Token(Token = "0x4002720")]
	private const float STICK_IN_DAMAGE_SCALAR = 0.75f;

	[Token(Token = "0x4002721")]
	private const float DEFLECTION_DAMAGE_SCALAR = 1.5f;

	[Token(Token = "0x4002722")]
	private const float ARROW_BOUNDING_RADIUS = 0.5f;

	[Token(Token = "0x4002723")]
	private const float ANTI_COLLISION_FUDGE_FACTOR = 0.1f;

	[Token(Token = "0x4002724")]
	private const float INTERIOR_CORRECTION_TEST_DIST = 8f;

	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x20")]
	public WeaponSource m_ArrowType;

	[Token(Token = "0x4002726")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_ArrowMesh;

	[Token(Token = "0x4002727")]
	[FieldOffset(Offset = "0x30")]
	public LineRenderer m_LineRenderer;

	[Token(Token = "0x4002728")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_PlacementHelper;

	[Token(Token = "0x4002729")]
	[FieldOffset(Offset = "0x40")]
	public bool m_CapsuleCollisionDebug;

	[Token(Token = "0x400272A")]
	public const int MAX_LINE_POINTS = 50;

	[Token(Token = "0x400272B")]
	public const float LINE_INTENSITY = 0.7f;

	[Token(Token = "0x400272C")]
	public const float LINE_FADE_OUT_TIME = 0.5f;

	[Token(Token = "0x400272D")]
	public const float MIN_TRAIL_STEP_SQR = 4f;

	[Token(Token = "0x400272E")]
	[FieldOffset(Offset = "0x48")]
	private Vector3[] m_LinePoints;

	[Token(Token = "0x400272F")]
	[FieldOffset(Offset = "0x50")]
	private int m_LineBase;

	[Token(Token = "0x4002730")]
	[FieldOffset(Offset = "0x54")]
	private int m_LineNumPts;

	[Token(Token = "0x4002731")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_FirstContact;

	[Token(Token = "0x4002732")]
	[FieldOffset(Offset = "0x64")]
	private float m_FirstContactTime;

	[Header("Fire, Flight & Damage")]
	[Range(30f, 120f)]
	[Token(Token = "0x4002733")]
	[FieldOffset(Offset = "0x68")]
	public float m_ReleaseVelocity;

	[Range(0.01f, 0.5f)]
	[Token(Token = "0x4002734")]
	[FieldOffset(Offset = "0x6C")]
	public float m_ReleaseDrag;

	[Range(1f, 100f)]
	[Token(Token = "0x4002735")]
	[FieldOffset(Offset = "0x70")]
	public float m_VictimDamage;

	[Token(Token = "0x4002736")]
	[FieldOffset(Offset = "0x74")]
	public float m_XZDampeningScalar;

	[Token(Token = "0x4002737")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 m_XZDampeningRange;

	[Token(Token = "0x4002738")]
	[FieldOffset(Offset = "0x80")]
	public float m_ImpactVelocityScalar;

	[Range(0f, 1f)]
	[Token(Token = "0x4002739")]
	[FieldOffset(Offset = "0x84")]
	public float m_BowDegradeModifier;

	[Header("Impact Effects")]
	[Token(Token = "0x400273A")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BrokenArrow;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x400273B")]
	[FieldOffset(Offset = "0x90")]
	private AK.Wwise.Event m_FlightAudioEvent;

	[SerializeField]
	[Token(Token = "0x400273C")]
	[FieldOffset(Offset = "0x98")]
	private AK.Wwise.Event m_ImpactAudioEvent;

	[SerializeField]
	[Token(Token = "0x400273D")]
	[FieldOffset(Offset = "0xA0")]
	private AK.Wwise.Event m_BreakAudioEvent;

	[Token(Token = "0x400273E")]
	[FieldOffset(Offset = "0xA8")]
	public float m_ImpactAudioCooldown;

	[Header("UI")]
	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0xB0")]
	private string m_AmmoIconSpriteName;

	[Header("Gear Impact Forces")]
	[Token(Token = "0x4002740")]
	[FieldOffset(Offset = "0xB8")]
	public float m_GearImpactForce;

	[Token(Token = "0x4002741")]
	[FieldOffset(Offset = "0xBC")]
	public float m_GearImpactUpwardForce;

	[Token(Token = "0x4002742")]
	[FieldOffset(Offset = "0xC0")]
	public float m_GearImpactTorqueForce;

	[Header("Skill Rewards")]
	[SerializeField]
	[Token(Token = "0x4002743")]
	[FieldOffset(Offset = "0xC4")]
	private int m_CraftingSkillPoints;

	[NonSerialized]
	[Token(Token = "0x4002744")]
	[FieldOffset(Offset = "0xC8")]
	public GearItem m_GearItem;

	[Token(Token = "0x4002745")]
	[FieldOffset(Offset = "0xD0")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x4002746")]
	[FieldOffset(Offset = "0xD8")]
	private int m_ContactCount;

	[Token(Token = "0x4002747")]
	[FieldOffset(Offset = "0xDC")]
	private float m_EmbeddedDepth;

	[Token(Token = "0x4002748")]
	[FieldOffset(Offset = "0xE0")]
	private BaseAi m_EmbeddedInAi;

	[Token(Token = "0x4002749")]
	[FieldOffset(Offset = "0xE8")]
	private float m_EmbeddedInAiDeadTime;

	[Token(Token = "0x400274A")]
	[FieldOffset(Offset = "0xEC")]
	private float m_FallOutTimer;

	[Token(Token = "0x400274B")]
	[FieldOffset(Offset = "0xF0")]
	private float m_ReleaseTime;

	[Token(Token = "0x400274C")]
	[FieldOffset(Offset = "0xF4")]
	private float m_LastEffectTime;

	[Token(Token = "0x400274D")]
	[FieldOffset(Offset = "0xF8")]
	private uint m_FlightAudioId;

	[Token(Token = "0x400274E")]
	[FieldOffset(Offset = "0xFC")]
	private bool m_Initialized;

	[Token(Token = "0x400274F")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x4002750")]
	[FieldOffset(Offset = "0x10C")]
	private Vector3 m_LastVelocity;

	[Token(Token = "0x4002751")]
	[FieldOffset(Offset = "0x118")]
	private ArrowSaveData m_DeferredSaveData;

	[Token(Token = "0x4002752")]
	[FieldOffset(Offset = "0x120")]
	private int m_DeferredSaveRetryCounter;

	[Token(Token = "0x4002753")]
	[FieldOffset(Offset = "0x124")]
	private Vector3 m_LastCollisionPoint;

	[Token(Token = "0x4002754")]
	[FieldOffset(Offset = "0x130")]
	private float m_BlockImpactAudioUntil;

	[Token(Token = "0x4002755")]
	[FieldOffset(Offset = "0x134")]
	private float m_BowDamageMultiplier;

	[Token(Token = "0x4002756")]
	[FieldOffset(Offset = "0x138")]
	private bool m_FellThroughWorld;

	[Token(Token = "0x1700021A")]
	public string AmmoIconSpriteName
	{
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x502310", Offset = "0x501110", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021B")]
	public int CraftingSkillPoints
	{
		[Token(Token = "0x6002085")]
		[Address(RVA = "0x7F92F0", Offset = "0x7F80F0", Length = "0x7")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6002086")]
	[Address(RVA = "0x7F9300", Offset = "0x7F8100", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0x7F9310", Offset = "0x7F8110", Length = "0xFC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002088")]
	[Address(RVA = "0x7F9410", Offset = "0x7F8210", Length = "0x12")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002089")]
	[Address(RVA = "0x7F9430", Offset = "0x7F8230", Length = "0xE7F")]
	public ArrowSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x600208A")]
	[Address(RVA = "0x7FA2B0", Offset = "0x7F90B0", Length = "0x448")]
	public void Deserialize(ArrowSaveData asd)
	{
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x7FA700", Offset = "0x7F9500", Length = "0x208")]
	private void ApplyForcesToGear(GearItem gi, Vector3 normal)
	{
	}

	[Token(Token = "0x600208C")]
	[Address(RVA = "0x7FA910", Offset = "0x7F9710", Length = "0x4A9")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600208D")]
	[Address(RVA = "0x7FADC0", Offset = "0x7F9BC0", Length = "0xB67")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600208E")]
	[Address(RVA = "0x7FB930", Offset = "0x7FA730", Length = "0x85C")]
	public void Fire(float bowDamageMultiplier)
	{
	}

	[Token(Token = "0x600208F")]
	[Address(RVA = "0x7FC190", Offset = "0x7FAF90", Length = "0x75")]
	private void MaybeCheckWithCougar(Vector3 forward)
	{
	}

	[Token(Token = "0x6002090")]
	[Address(RVA = "0x7FC210", Offset = "0x7FB010", Length = "0x1AD")]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return false;
	}

	[Token(Token = "0x6002091")]
	[Address(RVA = "0x7FC3C0", Offset = "0x7FB1C0", Length = "0xEF")]
	public bool BelongsToPlayer()
	{
		return false;
	}

	[Token(Token = "0x6002092")]
	[Address(RVA = "0x7FC4B0", Offset = "0x7FB2B0", Length = "0xBD6")]
	public void DetachIntoWorld()
	{
	}

	[Token(Token = "0x6002093")]
	[Address(RVA = "0x7FD090", Offset = "0x7FBE90", Length = "0x110")]
	public void SetPlacementHelperEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6002094")]
	[Address(RVA = "0x7FD1A0", Offset = "0x7FBFA0", Length = "0x78F")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002095")]
	[Address(RVA = "0x7FD930", Offset = "0x7FC730", Length = "0x9D1")]
	private void StopArrow()
	{
	}

	[Token(Token = "0x6002096")]
	[Address(RVA = "0x7FE310", Offset = "0x7FD110", Length = "0x111")]
	private LocalizedDamage GetDamageParameters(GameObject victim, out float partDamageScalar, out float bleedOutMinutes)
	{
		partDamageScalar = default(float);
		bleedOutMinutes = default(float);
		return null;
	}

	[Token(Token = "0x6002097")]
	[Address(RVA = "0x7FE430", Offset = "0x7FD230", Length = "0x4AC")]
	private void MaybeSpawnImpactEffects(GameObject victim, Vector3 collisionPoint, Vector3 collisionNormal, SurfaceResponseInfo sri)
	{
	}

	[Token(Token = "0x6002098")]
	[Address(RVA = "0x7FE910", Offset = "0x7FD710", Length = "0x160D")]
	private void HandleCollisionWithObject(GameObject collider, Vector3 collisionPoint, Vector3 collisionNormal)
	{
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x7FFF20", Offset = "0x7FED20", Length = "0x6AC")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x8005D0", Offset = "0x7FF3D0", Length = "0x656")]
	private void ParentToObject(Transform t)
	{
	}

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x800C30", Offset = "0x7FFA30", Length = "0x133")]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[Token(Token = "0x600209C")]
	[Address(RVA = "0x800D70", Offset = "0x7FFB70", Length = "0x72F")]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag, bool isSecondaryHit)
	{
		return default(SurfaceResponseInfo);
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x8014A0", Offset = "0x8002A0", Length = "0x484")]
	private void FallFree()
	{
	}

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x801930", Offset = "0x800730", Length = "0x5DA")]
	private void Break()
	{
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x801F10", Offset = "0x800D10", Length = "0x53D")]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider, Vector3 collisionPoint)
	{
		return null;
	}

	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x802450", Offset = "0x801250", Length = "0x1DB")]
	private void MaybeScareWildlife()
	{
	}

	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x802630", Offset = "0x801430", Length = "0x3BA")]
	private void RefreshLineRenderer()
	{
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x8029F0", Offset = "0x8017F0", Length = "0x3EF")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x802DE0", Offset = "0x801BE0", Length = "0xC4")]
	public ArrowItem()
	{
	}
}
