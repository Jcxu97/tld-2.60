using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000485")]
public class FlareGunRoundItem : MonoBehaviour
{
	[Token(Token = "0x2000486")]
	public enum FlightStatus
	{
		[Token(Token = "0x4002937")]
		None,
		[Token(Token = "0x4002938")]
		InFlight,
		[Token(Token = "0x4002939")]
		FlightCompleted
	}

	[Token(Token = "0x2000487")]
	internal struct SurfaceResponseInfo
	{
		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0x0")]
		internal float surfaceHardness;

		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0x4")]
		internal float deflectScalar;

		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x8")]
		internal Vector2 impactVelocityScalars;

		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x10")]
		internal GameObject impactPrefab;
	}

	[Token(Token = "0x40028F9")]
	public const float ROUND_LENGTH = 0.05f;

	[Token(Token = "0x40028FA")]
	public const float CENTER_OF_MASS_FRAC = 0.23f;

	[Token(Token = "0x40028FB")]
	public const float MAX_EMBED_FRAC = 0.7f;

	[Token(Token = "0x40028FC")]
	public const float MIN_PIERCE_VEL_BY_SURFACE_SCALE = 0.65f;

	[Token(Token = "0x40028FD")]
	public const float MAX_FALL_OUT_TIME = 1f;

	[Token(Token = "0x40028FE")]
	public const float MIN_STICK_IN_DEPTH = 0.001f;

	[Token(Token = "0x40028FF")]
	public const float MIN_STICK_IN_RANDOM_COMPONENT = 0.01f;

	[Token(Token = "0x4002900")]
	public const float SOFTEST_DEFLECT_ANGLE = 75f;

	[Token(Token = "0x4002901")]
	public const float HARDEST_DEFLECT_ANGLE = 0f;

	[Token(Token = "0x4002902")]
	public const string ROUND_COLLISION_LAYER = "Gear";

	[Token(Token = "0x4002903")]
	public const float MIN_TIME_BETWEEN_HIT_EFFECTS = 0.1f;

	[Token(Token = "0x4002904")]
	public const float MIN_VELOCITY_FOR_HIT_EFFECT_SQR = 2f;

	[Token(Token = "0x4002905")]
	public const float MAX_SINGLE_IMPACT_DAMAGE = 50f;

	[Token(Token = "0x4002906")]
	public const float STICK_IN_DAMAGE_SCALAR = 0.25f;

	[Token(Token = "0x4002907")]
	public const float DEFLECTION_DAMAGE_SCALAR = 1.5f;

	[Token(Token = "0x4002908")]
	public const float SMOKE_CLEAR_TIME = 5f;

	[Header("Fire, Flight & Damage")]
	[Range(30f, 70f)]
	[Token(Token = "0x4002909")]
	[FieldOffset(Offset = "0x20")]
	public float m_ReleaseVelocity;

	[Range(0.01f, 0.5f)]
	[Token(Token = "0x400290A")]
	[FieldOffset(Offset = "0x24")]
	public float m_ReleaseDrag;

	[Range(1f, 100f)]
	[Token(Token = "0x400290B")]
	[FieldOffset(Offset = "0x28")]
	public float m_VictimDamage;

	[Token(Token = "0x400290C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_XZDampeningScalar;

	[Token(Token = "0x400290D")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_XZDampeningRange;

	[Token(Token = "0x400290E")]
	[FieldOffset(Offset = "0x38")]
	public float m_BurnTime;

	[Token(Token = "0x400290F")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MaxBurnTimeOnWildlife;

	[Tooltip("Gravity adjustment for flight of the FlareGun round. Negative y will fall to the ground faster; positive y will fly for longer")]
	[Token(Token = "0x4002910")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_AdditionalGravity;

	[Header("Impact Effects")]
	[Token(Token = "0x4002911")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ImpactDirtPrefab;

	[Token(Token = "0x4002912")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_ImpactConcretePrefab;

	[Token(Token = "0x4002913")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_ImpactFabricPrefab;

	[Token(Token = "0x4002914")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_ImpactFleshPrefab;

	[Token(Token = "0x4002915")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_ImpactGlassPrefab;

	[Token(Token = "0x4002916")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_ImpactIcePrefab;

	[Token(Token = "0x4002917")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_ImpactMetalPrefab;

	[Token(Token = "0x4002918")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_ImpactSnowPrefab;

	[Token(Token = "0x4002919")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_ImpactWoodPrefab;

	[Header("Audio")]
	[Token(Token = "0x400291A")]
	[FieldOffset(Offset = "0x98")]
	public string m_OnFireAudio;

	[Token(Token = "0x400291B")]
	[FieldOffset(Offset = "0xA0")]
	public string m_BurningAudio;

	[Token(Token = "0x400291C")]
	[FieldOffset(Offset = "0xA8")]
	public string m_OnImpactAudio;

	[Token(Token = "0x400291D")]
	[FieldOffset(Offset = "0xB0")]
	public string m_BurnOutAudio;

	[Header("Effects")]
	[Token(Token = "0x400291E")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_FXGameObject;

	[Token(Token = "0x400291F")]
	[FieldOffset(Offset = "0xC0")]
	public ParticleSystem m_SmokeParticleSystem;

	[Token(Token = "0x4002920")]
	[FieldOffset(Offset = "0xC8")]
	public ParticleSystem m_SmokeCoreParticleSystem;

	[Token(Token = "0x4002921")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_FlareEffectInFlight;

	[Token(Token = "0x4002922")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_FlareEffectAfterLanding;

	[Token(Token = "0x4002923")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_Light;

	[Token(Token = "0x4002924")]
	[FieldOffset(Offset = "0xE8")]
	public float m_ParticleRestEmission;

	[Token(Token = "0x4002925")]
	[FieldOffset(Offset = "0xEC")]
	public float m_ParticleVelocityEmissionMultiplier;

	[Token(Token = "0x4002926")]
	[FieldOffset(Offset = "0xF0")]
	public Color m_SmokeColorWhenExtinguished;

	[Token(Token = "0x4002927")]
	[FieldOffset(Offset = "0x100")]
	public Color m_SmokeCoreColorWhenExtinguished;

	[HideInInspector]
	[Token(Token = "0x4002928")]
	[FieldOffset(Offset = "0x110")]
	public Rigidbody m_Rigidbody;

	[Token(Token = "0x4002929")]
	[FieldOffset(Offset = "0x118")]
	private int m_ContactCount;

	[Token(Token = "0x400292A")]
	[FieldOffset(Offset = "0x11C")]
	private float m_EmbeddedDepth;

	[Token(Token = "0x400292B")]
	[FieldOffset(Offset = "0x120")]
	private BaseAi m_EmbeddedInAi;

	[Token(Token = "0x400292C")]
	[FieldOffset(Offset = "0x128")]
	private float m_EmbeddedInAiDeadTime;

	[Token(Token = "0x400292D")]
	[FieldOffset(Offset = "0x12C")]
	private float m_FallOutTimer;

	[Token(Token = "0x400292E")]
	[FieldOffset(Offset = "0x130")]
	private float m_ReleaseTime;

	[Token(Token = "0x400292F")]
	[FieldOffset(Offset = "0x134")]
	private float m_LastEffectTime;

	[Token(Token = "0x4002930")]
	[FieldOffset(Offset = "0x138")]
	private uint m_BurningAudioId;

	[Token(Token = "0x4002931")]
	[FieldOffset(Offset = "0x13C")]
	private float m_BurnTimer;

	[Token(Token = "0x4002932")]
	[FieldOffset(Offset = "0x140")]
	private float m_SmokeClearTime;

	[Token(Token = "0x4002933")]
	[FieldOffset(Offset = "0x144")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002934")]
	[FieldOffset(Offset = "0x148")]
	private MeshRenderer m_MeshRenderer;

	[Token(Token = "0x4002935")]
	[FieldOffset(Offset = "0x150")]
	private FlightStatus m_FlightStatus;

	[Token(Token = "0x6002214")]
	[Address(RVA = "0x826480", Offset = "0x825280", Length = "0x263")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002215")]
	[Address(RVA = "0x8266F0", Offset = "0x8254F0", Length = "0x161")]
	private void Start()
	{
	}

	[Token(Token = "0x6002216")]
	[Address(RVA = "0x826860", Offset = "0x825660", Length = "0xCF")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002217")]
	[Address(RVA = "0x826930", Offset = "0x825730", Length = "0xDE0")]
	public FlareGunRoundSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002218")]
	[Address(RVA = "0x827720", Offset = "0x826520", Length = "0x89F")]
	public void Deserialize(FlareGunRoundSaveData asd)
	{
	}

	[Token(Token = "0x6002219")]
	[Address(RVA = "0x827FC0", Offset = "0x826DC0", Length = "0x877")]
	private void Update()
	{
	}

	[Token(Token = "0x600221A")]
	[Address(RVA = "0x828840", Offset = "0x827640", Length = "0x55B")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600221B")]
	[Address(RVA = "0x828DA0", Offset = "0x827BA0", Length = "0x6C6")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600221C")]
	[Address(RVA = "0x829470", Offset = "0x828270", Length = "0x524")]
	public void Fire()
	{
	}

	[Token(Token = "0x600221D")]
	[Address(RVA = "0x8299A0", Offset = "0x8287A0", Length = "0x2A1")]
	private void BurnOut()
	{
	}

	[Token(Token = "0x600221E")]
	[Address(RVA = "0x829C50", Offset = "0x828A50", Length = "0x13")]
	public bool IsBurning()
	{
		return false;
	}

	[Token(Token = "0x600221F")]
	[Address(RVA = "0x829C70", Offset = "0x828A70", Length = "0x1AD")]
	public bool InFlight(bool onlyConsiderFirstImpact)
	{
		return false;
	}

	[Token(Token = "0x6002220")]
	[Address(RVA = "0x829E20", Offset = "0x828C20", Length = "0x292")]
	public bool BelongsToPlayer()
	{
		return false;
	}

	[Token(Token = "0x6002221")]
	[Address(RVA = "0x82A0C0", Offset = "0x828EC0", Length = "0x255")]
	private void FlightComplete()
	{
	}

	[Token(Token = "0x6002222")]
	[Address(RVA = "0x82A320", Offset = "0x829120", Length = "0x1963")]
	private void HandleCollisionWithObject(GameObject colliderGO, Vector3 collisionPoint, Vector3 collisionNormal, Vector3 relativeVelocity)
	{
	}

	[Token(Token = "0x6002223")]
	[Address(RVA = "0x82BC90", Offset = "0x82AA90", Length = "0x137")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002224")]
	[Address(RVA = "0x82BDD0", Offset = "0x82ABD0", Length = "0x894")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6002225")]
	[Address(RVA = "0x82C670", Offset = "0x82B470", Length = "0x5E5")]
	private void ParentToObject(Transform t)
	{
	}

	[Token(Token = "0x6002226")]
	[Address(RVA = "0x82CC60", Offset = "0x82BA60", Length = "0x94")]
	private void PlayImpactAudio(string surfaceTag)
	{
	}

	[Token(Token = "0x6002227")]
	[Address(RVA = "0x82CD00", Offset = "0x82BB00", Length = "0x7F2")]
	private SurfaceResponseInfo GetSurfaceResponseInfo(string surfaceTag)
	{
		return default(SurfaceResponseInfo);
	}

	[Token(Token = "0x6002228")]
	[Address(RVA = "0x82D500", Offset = "0x82C300", Length = "0x3D1")]
	private void FallFree()
	{
	}

	[Token(Token = "0x6002229")]
	[Address(RVA = "0x82D8E0", Offset = "0x82C6E0", Length = "0x550")]
	private BaseAi InflictDamage(GameObject victim, float damageScalar, bool stickIn, string collider)
	{
		return null;
	}

	[Token(Token = "0x600222A")]
	[Address(RVA = "0x82DE40", Offset = "0x82CC40", Length = "0x6B4")]
	private void MaybeScareWildlife(PackAnimal ignoreMoraleOnAnimal)
	{
	}

	[Token(Token = "0x600222B")]
	[Address(RVA = "0x82E500", Offset = "0x82D300", Length = "0x11C")]
	public static GameObject SpawnAndFire(GameObject prefab, Vector3 startPos, Quaternion startRot)
	{
		return null;
	}

	[Token(Token = "0x600222C")]
	[Address(RVA = "0x82E620", Offset = "0x82D420", Length = "0xD4")]
	public FlareGunRoundItem()
	{
	}
}
