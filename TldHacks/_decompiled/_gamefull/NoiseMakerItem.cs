using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x20004C7")]
public class NoiseMakerItem : MonoBehaviour
{
	[Header("Scare Off")]
	[Token(Token = "0x4002BCD")]
	[FieldOffset(Offset = "0x20")]
	public float m_WildlifeFleeRadius;

	[Header("Damage Infliction")]
	[Token(Token = "0x4002BCE")]
	[FieldOffset(Offset = "0x24")]
	public float m_PlayerDamageRadius;

	[Token(Token = "0x4002BCF")]
	[FieldOffset(Offset = "0x28")]
	public float m_AIDamageRadius;

	[Token(Token = "0x4002BD0")]
	[FieldOffset(Offset = "0x2C")]
	public float m_PlayerDamageInflictionInRadius;

	[Token(Token = "0x4002BD1")]
	[FieldOffset(Offset = "0x30")]
	public float m_AIDamageInflictionInRadius;

	[Header("Damage Affliction")]
	[Token(Token = "0x4002BD2")]
	[FieldOffset(Offset = "0x34")]
	public DamageSource m_DamageSource;

	[Token(Token = "0x4002BD3")]
	[FieldOffset(Offset = "0x38")]
	public bool m_ShouldApplyDamageToPlayer;

	[Token(Token = "0x4002BD4")]
	[FieldOffset(Offset = "0x3C")]
	public float m_BurnAfflicationDamageAmount;

	[Header("Effects")]
	[Token(Token = "0x4002BD5")]
	[FieldOffset(Offset = "0x40")]
	public float m_BurnLifetimeMinutes;

	[Token(Token = "0x4002BD6")]
	[FieldOffset(Offset = "0x44")]
	public float m_IgniteDelaySeconds;

	[Token(Token = "0x4002BD7")]
	[FieldOffset(Offset = "0x48")]
	public float m_DetonateLifetimeMinutes;

	[Header("Audio")]
	[Token(Token = "0x4002BD8")]
	[FieldOffset(Offset = "0x50")]
	public string m_IgniteAudio;

	[Token(Token = "0x4002BD9")]
	[FieldOffset(Offset = "0x58")]
	public string m_BurnOutAudio;

	[Token(Token = "0x4002BDA")]
	[FieldOffset(Offset = "0x60")]
	public string m_LoopWithoutIgniteAudio;

	[Token(Token = "0x4002BDB")]
	[FieldOffset(Offset = "0x68")]
	public string m_DetonateAudio;

	[Token(Token = "0x4002BDC")]
	[FieldOffset(Offset = "0x70")]
	public string m_CollideAudio;

	[Header("Throw")]
	[Token(Token = "0x4002BDD")]
	[FieldOffset(Offset = "0x78")]
	public float m_ThrowForce;

	[Token(Token = "0x4002BDE")]
	[FieldOffset(Offset = "0x7C")]
	public float m_ThrowTorque;

	[Header("Swing")]
	[Token(Token = "0x4002BDF")]
	[FieldOffset(Offset = "0x80")]
	public float m_StaminaDrainPerSecond;

	[Token(Token = "0x4002BE0")]
	[FieldOffset(Offset = "0x84")]
	public float m_ReduceLifetimeMinutesPerSwing;

	[Header("HUD")]
	[Token(Token = "0x4002BE1")]
	[FieldOffset(Offset = "0x88")]
	public string m_RadialSpriteName;

	[Header("Misc")]
	[Token(Token = "0x4002BE2")]
	[FieldOffset(Offset = "0x90")]
	public bool m_RuinedByWater;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002BE3")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4002BE4")]
	[FieldOffset(Offset = "0xA0")]
	private NoiseMakerEffects m_Effects;

	[HideInInspector]
	[Token(Token = "0x4002BE5")]
	[FieldOffset(Offset = "0xA8")]
	public float velDamp;

	[HideInInspector]
	[Token(Token = "0x4002BE6")]
	[FieldOffset(Offset = "0xAC")]
	public float aVelDamp;

	[HideInInspector]
	[Token(Token = "0x4002BE7")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_CanThrow;

	[HideInInspector]
	[Token(Token = "0x4002BE8")]
	[FieldOffset(Offset = "0xB1")]
	public bool m_IsThrowing;

	[HideInInspector]
	[Token(Token = "0x4002BE9")]
	[FieldOffset(Offset = "0xB2")]
	public bool m_Thrown;

	[HideInInspector]
	[Token(Token = "0x4002BEA")]
	[FieldOffset(Offset = "0xB4")]
	public Color m_Color;

	[HideInInspector]
	[Token(Token = "0x4002BEB")]
	[FieldOffset(Offset = "0xC4")]
	public NoiseMakerState m_State;

	[Token(Token = "0x4002BEC")]
	[FieldOffset(Offset = "0xC8")]
	private float m_ElapsedBurnMinutes;

	[Token(Token = "0x4002BED")]
	[FieldOffset(Offset = "0xCC")]
	private float m_ElapsedTimeAfterDetonated;

	[Token(Token = "0x4002BEE")]
	[FieldOffset(Offset = "0xD0")]
	private HeatSource m_HeatSource;

	[Token(Token = "0x4002BEF")]
	[FieldOffset(Offset = "0xD8")]
	private uint m_IgniteAudioID;

	[Token(Token = "0x4002BF0")]
	[FieldOffset(Offset = "0xDC")]
	private uint m_DetonateAudioID;

	[Token(Token = "0x4002BF1")]
	[FieldOffset(Offset = "0xE0")]
	private float m_DragIncreaseAfterCollision;

	[Token(Token = "0x4002BF2")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_RenderingDisabled;

	[Token(Token = "0x4002BF3")]
	[FieldOffset(Offset = "0xE8")]
	private float m_RenderingDisabledNumFramesLeft;

	[Token(Token = "0x4002BF4")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_PlayCollisonAudio;

	[Token(Token = "0x4002BF5")]
	[FieldOffset(Offset = "0xED")]
	private bool m_IgniteAfterDelay;

	[Token(Token = "0x4002BF6")]
	[FieldOffset(Offset = "0xF0")]
	private float m_ElapsedIgniteDelaySeconds;

	[Token(Token = "0x4002BF7")]
	[FieldOffset(Offset = "0xF4")]
	private float m_IgniteDelay;

	[Token(Token = "0x4002BF8")]
	[FieldOffset(Offset = "0xF8")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002BF9")]
	[FieldOffset(Offset = "0x100")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x4002BFA")]
	[FieldOffset(Offset = "0x108")]
	private bool m_IgitePending;

	[Token(Token = "0x4002BFB")]
	[FieldOffset(Offset = "0x110")]
	private NavMeshObstacle m_NavMeshObstacle;

	[Token(Token = "0x4002BFC")]
	private static NoiseMakerSaveDataProxy m_NoiseMakerSaveDataProxy;

	[Token(Token = "0x6002453")]
	[Address(RVA = "0x865DC0", Offset = "0x864BC0", Length = "0x44B")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002454")]
	[Address(RVA = "0x866210", Offset = "0x865010", Length = "0xC3")]
	private void Start()
	{
	}

	[Token(Token = "0x6002455")]
	[Address(RVA = "0x8662E0", Offset = "0x8650E0", Length = "0xF7")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002456")]
	[Address(RVA = "0x8663E0", Offset = "0x8651E0", Length = "0x15D")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002457")]
	[Address(RVA = "0x866540", Offset = "0x865340", Length = "0x49E")]
	public void Update()
	{
	}

	[Token(Token = "0x6002458")]
	[Address(RVA = "0x8669E0", Offset = "0x8657E0", Length = "0x164")]
	public void Ignite()
	{
	}

	[Token(Token = "0x6002459")]
	[Address(RVA = "0x866B50", Offset = "0x865950", Length = "0x163")]
	public void Ignite(string igniteAudio)
	{
	}

	[Token(Token = "0x600245A")]
	[Address(RVA = "0x866CC0", Offset = "0x865AC0", Length = "0x1A5")]
	private void UpdateWickLit(float deltaTODMinutes)
	{
	}

	[Token(Token = "0x600245B")]
	[Address(RVA = "0x866E70", Offset = "0x865C70", Length = "0x43")]
	private void UpdateDetonate(float deltaTODMinutes)
	{
	}

	[Token(Token = "0x600245C")]
	[Address(RVA = "0x866EC0", Offset = "0x865CC0", Length = "0x69E")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[Token(Token = "0x600245D")]
	[Address(RVA = "0x867560", Offset = "0x866360", Length = "0xB2")]
	private void OnIgniteComplete()
	{
	}

	[Token(Token = "0x600245E")]
	[Address(RVA = "0x867620", Offset = "0x866420", Length = "0x22A")]
	public void IgniteDelayed()
	{
	}

	[Token(Token = "0x600245F")]
	[Address(RVA = "0x867850", Offset = "0x866650", Length = "0x2B8")]
	public void IgniteAfterDelay()
	{
	}

	[Token(Token = "0x6002460")]
	[Address(RVA = "0x867B10", Offset = "0x866910", Length = "0xC5")]
	public void CancelIgnite()
	{
	}

	[Token(Token = "0x6002461")]
	[Address(RVA = "0x867BE0", Offset = "0x8669E0", Length = "0x8")]
	public void Drop()
	{
	}

	[Token(Token = "0x6002462")]
	[Address(RVA = "0x867BF0", Offset = "0x8669F0", Length = "0x6F")]
	public void ForcePaused()
	{
	}

	[Token(Token = "0x6002463")]
	[Address(RVA = "0x867C60", Offset = "0x866A60", Length = "0xB")]
	public bool IsWickLit()
	{
		return false;
	}

	[Token(Token = "0x6002464")]
	[Address(RVA = "0x867C70", Offset = "0x866A70", Length = "0xB")]
	public bool IsFresh()
	{
		return false;
	}

	[Token(Token = "0x6002465")]
	[Address(RVA = "0x867C80", Offset = "0x866A80", Length = "0xB")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x6002466")]
	[Address(RVA = "0x867C90", Offset = "0x866A90", Length = "0x536")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002467")]
	[Address(RVA = "0x8681D0", Offset = "0x866FD0", Length = "0x3F8")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002468")]
	[Address(RVA = "0x8685D0", Offset = "0x8673D0", Length = "0x100")]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002469")]
	[Address(RVA = "0x8686E0", Offset = "0x8674E0", Length = "0x348")]
	private void PerformDetonation(ContactPoint[] contacts)
	{
	}

	[Token(Token = "0x600246A")]
	[Address(RVA = "0x868A30", Offset = "0x867830", Length = "0x55B")]
	private void PerformDamageToAllInRange()
	{
	}

	[Token(Token = "0x600246B")]
	[Address(RVA = "0x868F90", Offset = "0x867D90", Length = "0x7C")]
	public void DisableRendering(int numFrames)
	{
	}

	[Token(Token = "0x600246C")]
	[Address(RVA = "0x869010", Offset = "0x867E10", Length = "0x8")]
	public void EnableCollisionAudio()
	{
	}

	[Token(Token = "0x600246D")]
	[Address(RVA = "0x869010", Offset = "0x867E10", Length = "0x8")]
	public void PrepareForThrow()
	{
	}

	[Token(Token = "0x600246E")]
	[Address(RVA = "0x869020", Offset = "0x867E20", Length = "0xE5")]
	public void DestroyHeatSource()
	{
	}

	[Token(Token = "0x600246F")]
	[Address(RVA = "0x869110", Offset = "0x867F10", Length = "0x78")]
	public void HideEffects(bool hide)
	{
	}

	[Token(Token = "0x6002470")]
	[Address(RVA = "0x869190", Offset = "0x867F90", Length = "0xB")]
	public void ForceExtinguish()
	{
	}

	[Token(Token = "0x6002471")]
	[Address(RVA = "0x8691A0", Offset = "0x867FA0", Length = "0x8A")]
	public float GetNormalizedWickTimeLeft()
	{
		return 0f;
	}

	[Token(Token = "0x6002472")]
	[Address(RVA = "0x869230", Offset = "0x868030", Length = "0x4A")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x6002473")]
	[Address(RVA = "0x869280", Offset = "0x868080", Length = "0x123")]
	public void OnDroppedInWater()
	{
	}

	[Token(Token = "0x6002474")]
	[Address(RVA = "0x8693B0", Offset = "0x8681B0", Length = "0x7")]
	public void ForceBurnout()
	{
	}

	[Token(Token = "0x6002475")]
	[Address(RVA = "0x8693C0", Offset = "0x8681C0", Length = "0x57")]
	public void StopLoopingAudio()
	{
	}

	[Token(Token = "0x6002476")]
	[Address(RVA = "0x8693C0", Offset = "0x8681C0", Length = "0x57")]
	private void StopIgniteAudio()
	{
	}

	[Token(Token = "0x6002477")]
	[Address(RVA = "0x869420", Offset = "0x868220", Length = "0x57")]
	private void StopDetonateAudio()
	{
	}

	[Token(Token = "0x6002478")]
	[Address(RVA = "0x869480", Offset = "0x868280", Length = "0x9D")]
	private void UpdateNoiseMakerAudioPosition()
	{
	}

	[Token(Token = "0x6002479")]
	[Address(RVA = "0x869520", Offset = "0x868320", Length = "0xA9")]
	private void Unlight()
	{
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0x8695D0", Offset = "0x8683D0", Length = "0x362")]
	private void BurnOut()
	{
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0x869940", Offset = "0x868740", Length = "0x266")]
	private void ProcessItemInHandDetonated()
	{
	}

	[Token(Token = "0x600247C")]
	[Address(RVA = "0x869BB0", Offset = "0x8689B0", Length = "0x138")]
	public void Toggle()
	{
	}

	[Token(Token = "0x600247D")]
	[Address(RVA = "0x867BE0", Offset = "0x8669E0", Length = "0x8")]
	private void HandleOnThrown()
	{
	}

	[Token(Token = "0x600247E")]
	[Address(RVA = "0x869CF0", Offset = "0x868AF0", Length = "0x1D8")]
	private void ApplyBurnAffliction()
	{
	}

	[Token(Token = "0x600247F")]
	[Address(RVA = "0x869ED0", Offset = "0x868CD0", Length = "0x7")]
	private void SetState(NoiseMakerState state)
	{
	}

	[Token(Token = "0x6002480")]
	[Address(RVA = "0x869EE0", Offset = "0x868CE0", Length = "0x90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002481")]
	[Address(RVA = "0x8693C0", Offset = "0x8681C0", Length = "0x57")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x8693C0", Offset = "0x8681C0", Length = "0x57")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002483")]
	[Address(RVA = "0x869F70", Offset = "0x868D70", Length = "0x70")]
	public NoiseMakerItem()
	{
	}
}
