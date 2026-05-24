using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x20004E5")]
public class TorchItem : MonoBehaviour
{
	[Token(Token = "0x4002CA2")]
	public static HashSet<TorchItem> s_Torches;

	[Header("Time")]
	[Token(Token = "0x4002CA3")]
	[FieldOffset(Offset = "0x20")]
	public float m_BurnLifetimeMinutes;

	[Token(Token = "0x4002CA4")]
	[FieldOffset(Offset = "0x24")]
	public float m_ExtinguishTime;

	[Header("Usage")]
	[Token(Token = "0x4002CA5")]
	[FieldOffset(Offset = "0x28")]
	public bool m_CanBeRelit;

	[Token(Token = "0x4002CA6")]
	[FieldOffset(Offset = "0x29")]
	public bool m_CanBeHolstered;

	[Header("Effects")]
	[Token(Token = "0x4002CA7")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LightRepositionRate;

	[Token(Token = "0x4002CA8")]
	[FieldOffset(Offset = "0x30")]
	public float m_LightHeightOffset;

	[Token(Token = "0x4002CA9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_TorchMeshGameObject;

	[Token(Token = "0x4002CAA")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_TorchBurntMeshGameObject;

	[Token(Token = "0x4002CAB")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_FXGameObject;

	[Header("Audio")]
	[Token(Token = "0x4002CAC")]
	[FieldOffset(Offset = "0x50")]
	public string m_IgniteAudio;

	[Token(Token = "0x4002CAD")]
	[FieldOffset(Offset = "0x58")]
	public string m_ExtinguishAudio;

	[Token(Token = "0x4002CAE")]
	[FieldOffset(Offset = "0x60")]
	public string m_BlownOutAudio;

	[Token(Token = "0x4002CAF")]
	[FieldOffset(Offset = "0x68")]
	public string m_BurnOutAudio;

	[Token(Token = "0x4002CB0")]
	[FieldOffset(Offset = "0x70")]
	public string m_LoopWithoutIgniteAudio;

	[Token(Token = "0x4002CB1")]
	[FieldOffset(Offset = "0x78")]
	public string m_CollideAudio;

	[Header("Throw")]
	[Token(Token = "0x4002CB2")]
	[FieldOffset(Offset = "0x80")]
	public float m_ThrowForce;

	[Token(Token = "0x4002CB3")]
	[FieldOffset(Offset = "0x84")]
	public float m_ThrowTorque;

	[Header("Wind")]
	[Token(Token = "0x4002CB4")]
	[FieldOffset(Offset = "0x88")]
	public float m_WindSpeedCannotIgnite;

	[Token(Token = "0x4002CB5")]
	[FieldOffset(Offset = "0x8C")]
	public float m_WindSpeedExtinguish;

	[Header("Swing")]
	[Token(Token = "0x4002CB6")]
	[FieldOffset(Offset = "0x90")]
	public float m_StaminaDrainPerSecond;

	[Token(Token = "0x4002CB7")]
	[FieldOffset(Offset = "0x94")]
	public float m_ReduceLifetimeMinutesPerSwing;

	[Header("HUD")]
	[Token(Token = "0x4002CB8")]
	[FieldOffset(Offset = "0x98")]
	public string m_RadialSpriteName;

	[SerializeField]
	[Token(Token = "0x4002CB9")]
	[FieldOffset(Offset = "0xA0")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4002CBA")]
	[FieldOffset(Offset = "0xA8")]
	private PanelReference<Panel_TorchLight> m_TorchLight;

	[Token(Token = "0x4002CBB")]
	[FieldOffset(Offset = "0xB0")]
	public TorchIntensity m_IntensityComponent;

	[HideInInspector]
	[Token(Token = "0x4002CBC")]
	[FieldOffset(Offset = "0xB8")]
	public float velDamp;

	[HideInInspector]
	[Token(Token = "0x4002CBD")]
	[FieldOffset(Offset = "0xBC")]
	public float aVelDamp;

	[HideInInspector]
	[Token(Token = "0x4002CBE")]
	[FieldOffset(Offset = "0xC0")]
	public bool m_CanThrow;

	[HideInInspector]
	[Token(Token = "0x4002CBF")]
	[FieldOffset(Offset = "0xC1")]
	public bool m_Thrown;

	[HideInInspector]
	[Token(Token = "0x4002CC0")]
	[FieldOffset(Offset = "0xC4")]
	public float m_ElapsedBurnMinutes;

	[HideInInspector]
	[Token(Token = "0x4002CC1")]
	[FieldOffset(Offset = "0xC8")]
	public Color m_Color;

	[Token(Token = "0x4002CC2")]
	[FieldOffset(Offset = "0xD8")]
	private TorchState m_State;

	[Token(Token = "0x4002CC3")]
	[FieldOffset(Offset = "0xDC")]
	private TorchState m_PreviousState;

	[Token(Token = "0x4002CC4")]
	[FieldOffset(Offset = "0xE0")]
	private HeatSource m_HeatSource;

	[Token(Token = "0x4002CC5")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject m_LightPosOriginalObject;

	[Token(Token = "0x4002CC6")]
	[FieldOffset(Offset = "0xF0")]
	private Light m_LightIndoor;

	[Token(Token = "0x4002CC7")]
	[FieldOffset(Offset = "0xF8")]
	private Light m_LightOutdoor;

	[Token(Token = "0x4002CC8")]
	[FieldOffset(Offset = "0x100")]
	private float m_LightOffsetY;

	[Token(Token = "0x4002CC9")]
	[FieldOffset(Offset = "0x104")]
	private uint m_IgniteAudioID;

	[Token(Token = "0x4002CCA")]
	[FieldOffset(Offset = "0x108")]
	private float m_DragIncreaseAfterCollision;

	[Token(Token = "0x4002CCB")]
	[FieldOffset(Offset = "0x10C")]
	private bool m_RenderingDisabled;

	[Token(Token = "0x4002CCC")]
	[FieldOffset(Offset = "0x110")]
	private float m_RenderingDisabledNumFramesLeft;

	[Token(Token = "0x4002CCD")]
	[FieldOffset(Offset = "0x114")]
	private bool m_PlayCollisonAudio;

	[Token(Token = "0x4002CCE")]
	[FieldOffset(Offset = "0x115")]
	private bool m_IgniteAfterDelay;

	[Token(Token = "0x4002CCF")]
	[FieldOffset(Offset = "0x118")]
	private float m_ElapsedIgniteDelaySeconds;

	[Token(Token = "0x4002CD0")]
	[FieldOffset(Offset = "0x11C")]
	private float m_IgniteDelaySeconds;

	[Token(Token = "0x4002CD1")]
	[FieldOffset(Offset = "0x120")]
	private uint m_IgniteLoop;

	[Token(Token = "0x4002CD2")]
	[FieldOffset(Offset = "0x124")]
	private bool m_IgniteFromFire;

	[Token(Token = "0x4002CD3")]
	[FieldOffset(Offset = "0x125")]
	private bool m_ExtinguishAfterDelay;

	[Token(Token = "0x4002CD4")]
	[FieldOffset(Offset = "0x128")]
	private float m_ElapsedExtinguishDelaySeconds;

	[Token(Token = "0x4002CD5")]
	[FieldOffset(Offset = "0x130")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002CD6")]
	[FieldOffset(Offset = "0x138")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x4002CD7")]
	[FieldOffset(Offset = "0x140")]
	private NavMeshObstacle m_NavMeshObstacle;

	[Token(Token = "0x4002CD8")]
	private static TorchItemSaveDataProxy m_TorchItemSaveDataProxy;

	[Token(Token = "0x4002CD9")]
	[FieldOffset(Offset = "0x148")]
	private bool m_FlareIsPaused;

	[Token(Token = "0x4002CDA")]
	private const float DRAG_STATIONARY_LIMIT = 5000f;

	[Token(Token = "0x6002514")]
	[Address(RVA = "0x873330", Offset = "0x872130", Length = "0x7B9")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x873AF0", Offset = "0x8728F0", Length = "0xC3")]
	public void Start()
	{
	}

	[Token(Token = "0x6002516")]
	[Address(RVA = "0x873BC0", Offset = "0x8729C0", Length = "0x682")]
	public void Update()
	{
	}

	[Token(Token = "0x6002517")]
	[Address(RVA = "0x874250", Offset = "0x873050", Length = "0x1AA")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002518")]
	[Address(RVA = "0x874400", Offset = "0x873200", Length = "0x29F")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002519")]
	[Address(RVA = "0x8746A0", Offset = "0x8734A0", Length = "0x27")]
	public void Ignite()
	{
	}

	[Token(Token = "0x600251A")]
	[Address(RVA = "0x8746D0", Offset = "0x8734D0", Length = "0x25A")]
	public void Ignite(string igniteAudio)
	{
	}

	[Token(Token = "0x600251B")]
	[Address(RVA = "0x874930", Offset = "0x873730", Length = "0xB2")]
	private void OnIgniteComplete()
	{
	}

	[Token(Token = "0x600251C")]
	[Address(RVA = "0x8749F0", Offset = "0x8737F0", Length = "0x223")]
	public void IgniteDelayed(float delaySeconds, string igniteAudio, bool isFire)
	{
	}

	[Token(Token = "0x600251D")]
	[Address(RVA = "0x874C20", Offset = "0x873A20", Length = "0x2A9")]
	public void IgniteAfterDelay()
	{
	}

	[Token(Token = "0x600251E")]
	[Address(RVA = "0x874ED0", Offset = "0x873CD0", Length = "0x15D")]
	public void IgniteFromSource(GameObject source)
	{
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0x875030", Offset = "0x873E30", Length = "0x1B1")]
	public void CancelIgnite()
	{
	}

	[Token(Token = "0x6002520")]
	[Address(RVA = "0x8751F0", Offset = "0x873FF0", Length = "0x8")]
	public bool IsSetToIgniteAfterDelay()
	{
		return false;
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x875200", Offset = "0x874000", Length = "0x1D8")]
	public void ExtinguishDelayed()
	{
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnExtinguishCompleteCallback()
	{
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0x8753E0", Offset = "0x8741E0", Length = "0x29A")]
	public void ExtinguishAfterDelayStarted()
	{
	}

	[Token(Token = "0x6002524")]
	[Address(RVA = "0x875680", Offset = "0x874480", Length = "0x130")]
	public void CancelExtinguish()
	{
	}

	[Token(Token = "0x6002525")]
	[Address(RVA = "0x8757C0", Offset = "0x8745C0", Length = "0x1E")]
	public bool CanBeLit()
	{
		return false;
	}

	[Token(Token = "0x6002526")]
	[Address(RVA = "0x8757E0", Offset = "0x8745E0", Length = "0xB")]
	public bool IsBurning()
	{
		return false;
	}

	[Token(Token = "0x6002527")]
	[Address(RVA = "0x8757F0", Offset = "0x8745F0", Length = "0x8")]
	public bool IsExtinguishing()
	{
		return false;
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0x875800", Offset = "0x874600", Length = "0xB")]
	public bool IsBurnedOut()
	{
		return false;
	}

	[Token(Token = "0x6002529")]
	[Address(RVA = "0x875810", Offset = "0x874610", Length = "0xB")]
	public bool IsFresh()
	{
		return false;
	}

	[Token(Token = "0x600252A")]
	[Address(RVA = "0x875820", Offset = "0x874620", Length = "0x8E")]
	public void PauseLight()
	{
	}

	[Token(Token = "0x600252B")]
	[Address(RVA = "0x8758B0", Offset = "0x8746B0", Length = "0x15")]
	public void ResumeLight()
	{
	}

	[Token(Token = "0x600252C")]
	[Address(RVA = "0x8758D0", Offset = "0x8746D0", Length = "0x8")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x600252D")]
	[Address(RVA = "0x8758E0", Offset = "0x8746E0", Length = "0x67D")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Token(Token = "0x600252E")]
	[Address(RVA = "0x875F60", Offset = "0x874D60", Length = "0x79F")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Token(Token = "0x600252F")]
	[Address(RVA = "0x876700", Offset = "0x875500", Length = "0x100")]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002530")]
	[Address(RVA = "0x876810", Offset = "0x875610", Length = "0x7C")]
	public void DisableRendering(int numFrames)
	{
	}

	[Token(Token = "0x6002531")]
	[Address(RVA = "0x876890", Offset = "0x875690", Length = "0x8")]
	public void EnableCollisionAudio()
	{
	}

	[Token(Token = "0x6002532")]
	[Address(RVA = "0x8768A0", Offset = "0x8756A0", Length = "0x2C")]
	public void PrepareForThrow()
	{
	}

	[Token(Token = "0x6002533")]
	[Address(RVA = "0x8768D0", Offset = "0x8756D0", Length = "0xE5")]
	public void DestroyHeatSource()
	{
	}

	[Token(Token = "0x6002534")]
	[Address(RVA = "0x8769C0", Offset = "0x8757C0", Length = "0x45")]
	public void HideEffects(bool hide)
	{
	}

	[Token(Token = "0x6002535")]
	[Address(RVA = "0x876A10", Offset = "0x875810", Length = "0x1B3")]
	public void AttemptToLight()
	{
	}

	[Token(Token = "0x6002536")]
	[Address(RVA = "0x876BD0", Offset = "0x8759D0", Length = "0xB")]
	public void ForceExtinguish()
	{
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0x876BE0", Offset = "0x8759E0", Length = "0x5F")]
	public float GetBurnProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0x876C40", Offset = "0x875A40", Length = "0x94")]
	private void UpdateTorchAudioPosition()
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0x876CE0", Offset = "0x875AE0", Length = "0x85C")]
	private void UpdateLightPosition()
	{
	}

	[Token(Token = "0x600253A")]
	[Address(RVA = "0x877540", Offset = "0x876340", Length = "0x57")]
	public void StopBurningAudioLoop()
	{
	}

	[Token(Token = "0x600253B")]
	[Address(RVA = "0x8775A0", Offset = "0x8763A0", Length = "0x286")]
	public void Extinguish(TorchState newState)
	{
	}

	[Token(Token = "0x600253C")]
	[Address(RVA = "0x877830", Offset = "0x876630", Length = "0x8")]
	public bool IsIgnitedFromFire()
	{
		return false;
	}

	[Token(Token = "0x600253D")]
	[Address(RVA = "0x877840", Offset = "0x876640", Length = "0x4A")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x600253E")]
	[Address(RVA = "0x877890", Offset = "0x876690", Length = "0xC")]
	public void OnDroppedInWater()
	{
	}

	[Token(Token = "0x600253F")]
	[Address(RVA = "0x8778A0", Offset = "0x8766A0", Length = "0xA9")]
	public void StopLoopingAudio()
	{
	}

	[Token(Token = "0x6002540")]
	[Address(RVA = "0x877950", Offset = "0x876750", Length = "0x97")]
	private void SetState(TorchState state)
	{
	}

	[Token(Token = "0x6002541")]
	[Address(RVA = "0x8779F0", Offset = "0x8767F0", Length = "0x186")]
	private bool ShouldBlowOut()
	{
		return false;
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0x877B80", Offset = "0x876980", Length = "0x36D")]
	private void MaybeAdjustHeatSource()
	{
	}

	[Token(Token = "0x6002543")]
	[Address(RVA = "0x877EF0", Offset = "0x876CF0", Length = "0x57")]
	private void StopIgniteLoop()
	{
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0x877F50", Offset = "0x876D50", Length = "0x10A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0x878060", Offset = "0x876E60", Length = "0x8C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0x8780F0", Offset = "0x876EF0", Length = "0x8C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002547")]
	[Address(RVA = "0x878180", Offset = "0x876F80", Length = "0x105")]
	private GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x6002548")]
	[Address(RVA = "0x878290", Offset = "0x877090", Length = "0x69E")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[Token(Token = "0x6002549")]
	[Address(RVA = "0x878930", Offset = "0x877730", Length = "0x4D")]
	public TorchItem()
	{
	}
}
