using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x200048B")]
public class FlareItem : MonoBehaviour
{
	[Token(Token = "0x400294A")]
	public static HashSet<FlareItem> s_Flares;

	[Token(Token = "0x400294B")]
	[FieldOffset(Offset = "0x20")]
	public FlareType m_Type;

	[Header("Effects")]
	[Token(Token = "0x400294C")]
	[FieldOffset(Offset = "0x24")]
	public float m_BurnLifetimeMinutes;

	[Token(Token = "0x400294D")]
	[FieldOffset(Offset = "0x28")]
	public float m_LightRepositionRate;

	[Token(Token = "0x400294E")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LightHeightOffset;

	[Token(Token = "0x400294F")]
	[FieldOffset(Offset = "0x30")]
	public float m_IgniteDelaySeconds;

	[Header("Audio")]
	[Token(Token = "0x4002950")]
	[FieldOffset(Offset = "0x38")]
	public string m_IgniteAudio;

	[Token(Token = "0x4002951")]
	[FieldOffset(Offset = "0x40")]
	public string m_BurnOutAudio;

	[Token(Token = "0x4002952")]
	[FieldOffset(Offset = "0x48")]
	public string m_LoopWithoutIgniteAudio;

	[Token(Token = "0x4002953")]
	[FieldOffset(Offset = "0x50")]
	public string m_CollideAudio;

	[Header("Throw")]
	[Token(Token = "0x4002954")]
	[FieldOffset(Offset = "0x58")]
	public float m_ThrowForce;

	[Token(Token = "0x4002955")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ThrowTorque;

	[Header("Swing")]
	[Token(Token = "0x4002956")]
	[FieldOffset(Offset = "0x60")]
	public float m_StaminaDrainPerSecond;

	[Token(Token = "0x4002957")]
	[FieldOffset(Offset = "0x64")]
	public float m_ReduceLifetimeMinutesPerSwing;

	[Header("HUD")]
	[SerializeField]
	[Token(Token = "0x4002958")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002959")]
	[FieldOffset(Offset = "0x70")]
	public string m_RadialSpriteName;

	[Header("Misc")]
	[Token(Token = "0x400295A")]
	[FieldOffset(Offset = "0x78")]
	public bool m_RuinedByWater;

	[Token(Token = "0x400295B")]
	[FieldOffset(Offset = "0x80")]
	public FlareIntensity m_IntensityComponent;

	[HideInInspector]
	[Token(Token = "0x400295C")]
	[FieldOffset(Offset = "0x88")]
	public float velDamp;

	[HideInInspector]
	[Token(Token = "0x400295D")]
	[FieldOffset(Offset = "0x8C")]
	public float aVelDamp;

	[HideInInspector]
	[Token(Token = "0x400295E")]
	[FieldOffset(Offset = "0x90")]
	public bool m_CanThrow;

	[HideInInspector]
	[Token(Token = "0x400295F")]
	[FieldOffset(Offset = "0x91")]
	public bool m_Thrown;

	[HideInInspector]
	[Token(Token = "0x4002960")]
	[FieldOffset(Offset = "0x94")]
	public Color m_Color;

	[Token(Token = "0x4002961")]
	[FieldOffset(Offset = "0xA4")]
	private FlareState m_State;

	[Token(Token = "0x4002962")]
	[FieldOffset(Offset = "0xA8")]
	private FlareState m_PreviousState;

	[Token(Token = "0x4002963")]
	[FieldOffset(Offset = "0xAC")]
	private float m_ElapsedBurnMinutes;

	[Token(Token = "0x4002964")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_FXGameObject;

	[Token(Token = "0x4002965")]
	[FieldOffset(Offset = "0xB8")]
	private HeatSource m_HeatSource;

	[Token(Token = "0x4002966")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject m_FlareCapMeshObject;

	[Token(Token = "0x4002967")]
	[FieldOffset(Offset = "0xC8")]
	private MeshRenderer m_FlareCapMeshObjectMeshRenderer;

	[Token(Token = "0x4002968")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject m_LightPosOriginalObject;

	[Token(Token = "0x4002969")]
	[FieldOffset(Offset = "0xD8")]
	private Light m_LightIndoor;

	[Token(Token = "0x400296A")]
	[FieldOffset(Offset = "0xE0")]
	private Light m_LightOutdoor;

	[Token(Token = "0x400296B")]
	[FieldOffset(Offset = "0xE8")]
	private float m_LightOffsetY;

	[Token(Token = "0x400296C")]
	[FieldOffset(Offset = "0xEC")]
	private uint m_IgniteAudioID;

	[Token(Token = "0x400296D")]
	[FieldOffset(Offset = "0xF0")]
	private float m_DragIncreaseAfterCollision;

	[Token(Token = "0x400296E")]
	[FieldOffset(Offset = "0xF4")]
	private bool m_RenderingDisabled;

	[Token(Token = "0x400296F")]
	[FieldOffset(Offset = "0xF8")]
	private float m_RenderingDisabledNumFramesLeft;

	[Token(Token = "0x4002970")]
	[FieldOffset(Offset = "0xFC")]
	private bool m_PlayCollisonAudio;

	[Token(Token = "0x4002971")]
	[FieldOffset(Offset = "0xFD")]
	private bool m_IgniteAfterDelay;

	[Token(Token = "0x4002972")]
	[FieldOffset(Offset = "0x100")]
	private float m_ElapsedIgniteDelaySeconds;

	[Token(Token = "0x4002973")]
	[FieldOffset(Offset = "0x104")]
	private float m_IgniteDelay;

	[Token(Token = "0x4002974")]
	[FieldOffset(Offset = "0x108")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002975")]
	[FieldOffset(Offset = "0x110")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x4002976")]
	[FieldOffset(Offset = "0x118")]
	private bool m_IgitePending;

	[Token(Token = "0x4002977")]
	[FieldOffset(Offset = "0x120")]
	private NavMeshObstacle m_NavMeshObstacle;

	[Token(Token = "0x4002978")]
	private static FlareItemSaveDataProxy m_FlareItemSaveDataProxy;

	[Token(Token = "0x600222E")]
	[Address(RVA = "0x82E700", Offset = "0x82D500", Length = "0x992")]
	public void Awake()
	{
	}

	[Token(Token = "0x600222F")]
	[Address(RVA = "0x82F0A0", Offset = "0x82DEA0", Length = "0xC3")]
	public void Start()
	{
	}

	[Token(Token = "0x6002230")]
	[Address(RVA = "0x82F170", Offset = "0x82DF70", Length = "0x49B")]
	public void Update()
	{
	}

	[Token(Token = "0x6002231")]
	[Address(RVA = "0x82F610", Offset = "0x82E410", Length = "0x185")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002232")]
	[Address(RVA = "0x82F7A0", Offset = "0x82E5A0", Length = "0x1FF")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002233")]
	[Address(RVA = "0x82F9A0", Offset = "0x82E7A0", Length = "0xC")]
	public void Ignite()
	{
	}

	[Token(Token = "0x6002234")]
	[Address(RVA = "0x82F9B0", Offset = "0x82E7B0", Length = "0x3E5")]
	public void Ignite(string igniteAudio)
	{
	}

	[Token(Token = "0x6002235")]
	[Address(RVA = "0x82FDA0", Offset = "0x82EBA0", Length = "0x69E")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[Token(Token = "0x6002236")]
	[Address(RVA = "0x830440", Offset = "0x82F240", Length = "0xAF")]
	private void OnIgniteComplete()
	{
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0x8304F0", Offset = "0x82F2F0", Length = "0x222")]
	public void IgniteDelayed()
	{
	}

	[Token(Token = "0x6002238")]
	[Address(RVA = "0x830720", Offset = "0x82F520", Length = "0x247")]
	public void IgniteAfterDelay()
	{
	}

	[Token(Token = "0x6002239")]
	[Address(RVA = "0x830970", Offset = "0x82F770", Length = "0xC5")]
	public void CancelIgnite()
	{
	}

	[Token(Token = "0x600223A")]
	[Address(RVA = "0x830A40", Offset = "0x82F840", Length = "0x7B")]
	public void ForcePaused()
	{
	}

	[Token(Token = "0x600223B")]
	[Address(RVA = "0x830AC0", Offset = "0x82F8C0", Length = "0x17")]
	public void PauseLight()
	{
	}

	[Token(Token = "0x600223C")]
	[Address(RVA = "0x830AE0", Offset = "0x82F8E0", Length = "0xD")]
	public void ResumeLight()
	{
	}

	[Token(Token = "0x600223D")]
	[Address(RVA = "0x830AF0", Offset = "0x82F8F0", Length = "0xB")]
	public bool IsBurning()
	{
		return false;
	}

	[Token(Token = "0x600223E")]
	[Address(RVA = "0x830B00", Offset = "0x82F900", Length = "0xB")]
	public bool IsBurnedOut()
	{
		return false;
	}

	[Token(Token = "0x600223F")]
	[Address(RVA = "0x830B10", Offset = "0x82F910", Length = "0xB")]
	public bool IsFresh()
	{
		return false;
	}

	[Token(Token = "0x6002240")]
	[Address(RVA = "0x830B20", Offset = "0x82F920", Length = "0xB")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x6002241")]
	[Address(RVA = "0x830B30", Offset = "0x82F930", Length = "0x536")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002242")]
	[Address(RVA = "0x831070", Offset = "0x82FE70", Length = "0x713")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002243")]
	[Address(RVA = "0x831790", Offset = "0x830590", Length = "0x100")]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002244")]
	[Address(RVA = "0x8318A0", Offset = "0x8306A0", Length = "0x7C")]
	public void DisableRendering(int numFrames)
	{
	}

	[Token(Token = "0x6002245")]
	[Address(RVA = "0x831920", Offset = "0x830720", Length = "0x8")]
	public void EnableCollisionAudio()
	{
	}

	[Token(Token = "0x6002246")]
	[Address(RVA = "0x831930", Offset = "0x830730", Length = "0x2C")]
	public void PrepareForThrow()
	{
	}

	[Token(Token = "0x6002247")]
	[Address(RVA = "0x831960", Offset = "0x830760", Length = "0xE5")]
	public void DestroyHeatSource()
	{
	}

	[Token(Token = "0x6002248")]
	[Address(RVA = "0x831A50", Offset = "0x830850", Length = "0x4B")]
	public void HideEffects(bool hide)
	{
	}

	[Token(Token = "0x6002249")]
	[Address(RVA = "0x831AA0", Offset = "0x8308A0", Length = "0xB")]
	public void ForceExtinguish()
	{
	}

	[Token(Token = "0x600224A")]
	[Address(RVA = "0x831AB0", Offset = "0x8308B0", Length = "0x8A")]
	public float GetNormalizedBurnTimeLeft()
	{
		return 0f;
	}

	[Token(Token = "0x600224B")]
	[Address(RVA = "0x831B40", Offset = "0x830940", Length = "0x4A")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x600224C")]
	[Address(RVA = "0x831B90", Offset = "0x830990", Length = "0x26")]
	public void OnDroppedInWater()
	{
	}

	[Token(Token = "0x600224D")]
	[Address(RVA = "0x831BC0", Offset = "0x8309C0", Length = "0x7")]
	public void ForceBurnout()
	{
	}

	[Token(Token = "0x600224E")]
	[Address(RVA = "0x831BD0", Offset = "0x8309D0", Length = "0x57")]
	public void StopLoopingAudio()
	{
	}

	[Token(Token = "0x600224F")]
	[Address(RVA = "0x831C30", Offset = "0x830A30", Length = "0x94")]
	private void UpdateFlareAudioPosition()
	{
	}

	[Token(Token = "0x6002250")]
	[Address(RVA = "0x831CD0", Offset = "0x830AD0", Length = "0x85F")]
	private void UpdateLightPosition()
	{
	}

	[Token(Token = "0x6002251")]
	[Address(RVA = "0x832530", Offset = "0x831330", Length = "0x27C")]
	private void BurnOut()
	{
	}

	[Token(Token = "0x6002252")]
	[Address(RVA = "0x8327B0", Offset = "0x8315B0", Length = "0x7")]
	private void SetState(FlareState state)
	{
	}

	[Token(Token = "0x6002253")]
	[Address(RVA = "0x8327C0", Offset = "0x8315C0", Length = "0x10A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002254")]
	[Address(RVA = "0x8328D0", Offset = "0x8316D0", Length = "0xCB")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002255")]
	[Address(RVA = "0x8329A0", Offset = "0x8317A0", Length = "0xCB")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002256")]
	[Address(RVA = "0x832A70", Offset = "0x831870", Length = "0x51")]
	public FlareItem()
	{
	}
}
