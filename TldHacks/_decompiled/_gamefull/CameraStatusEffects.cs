using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000370")]
public class CameraStatusEffects : MonoBehaviour
{
	[Header("Low condition")]
	[Token(Token = "0x4001E5B")]
	[FieldOffset(Offset = "0x20")]
	public bool m_LowConditionBlurOverride;

	[Token(Token = "0x4001E5C")]
	[FieldOffset(Offset = "0x24")]
	public float m_LowConditionBlurValue;

	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x28")]
	public float m_LowConditionVignetteScalar;

	[Token(Token = "0x4001E5E")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LowConditionChromaticAberrationScalar;

	[Header("Pain")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x30")]
	public float m_PainAmount;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E60")]
	[FieldOffset(Offset = "0x34")]
	public float m_PainColorGradingBlend;

	[Token(Token = "0x4001E61")]
	[FieldOffset(Offset = "0x38")]
	public bool m_TriggerPainPulse;

	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0x3C")]
	private float m_PainTarget;

	[Header("Stim")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E63")]
	[FieldOffset(Offset = "0x40")]
	public float m_StimAmount;

	[Token(Token = "0x4001E64")]
	[FieldOffset(Offset = "0x44")]
	public float m_StimChromaticAberration;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E65")]
	[FieldOffset(Offset = "0x48")]
	public float m_StimColorGradingBlend;

	[Token(Token = "0x4001E66")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_TriggerStimPulse;

	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0x50")]
	private float m_StimTarget;

	[Header("BoostEffect")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0x54")]
	public float m_BoostEffectAmount;

	[Token(Token = "0x4001E69")]
	[FieldOffset(Offset = "0x58")]
	public float m_BoostEffectChromaticAberration;

	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0x5C")]
	public float m_BoostEffectVignetteIntensity;

	[Token(Token = "0x4001E6B")]
	[FieldOffset(Offset = "0x60")]
	public Color m_BoostEffectVignetteColor;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E6C")]
	[FieldOffset(Offset = "0x70")]
	public float m_BoostEffectColorGradingBlend;

	[Token(Token = "0x4001E6D")]
	[FieldOffset(Offset = "0x74")]
	public bool m_TriggerBoostEffectPulse;

	[Token(Token = "0x4001E6E")]
	[FieldOffset(Offset = "0x78")]
	private float m_BoostEffectTarget;

	[Header("Headache")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x7C")]
	public float m_HeadacheAmount;

	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0x80")]
	public float m_HeadacheAmountSin;

	[Token(Token = "0x4001E71")]
	[FieldOffset(Offset = "0x84")]
	public float m_HeadacheSinSpeed;

	[Token(Token = "0x4001E72")]
	[FieldOffset(Offset = "0x88")]
	public float m_HeadacheChromaticAberration;

	[Token(Token = "0x4001E73")]
	[FieldOffset(Offset = "0x8C")]
	public float m_HeadacheVignetteIntensity;

	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0x90")]
	public Color m_HeadacheVignetteColor;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E75")]
	[FieldOffset(Offset = "0xA0")]
	public float m_HeadacheColorGradingBlend;

	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0xA4")]
	public bool m_TriggerHeadachePulse;

	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0xA8")]
	private float m_HeadacheTarget;

	[Header("Suffocation")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E78")]
	[FieldOffset(Offset = "0xAC")]
	public float m_SuffocationAmount;

	[Token(Token = "0x4001E79")]
	[FieldOffset(Offset = "0xB0")]
	public float m_SuffocationChromaticAberration;

	[Token(Token = "0x4001E7A")]
	[FieldOffset(Offset = "0xB4")]
	public float m_SuffocationVignetteIntensity;

	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_SuffocationVignetteColor;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E7C")]
	[FieldOffset(Offset = "0xC8")]
	public float m_SuffocationColorGradingBlend;

	[Token(Token = "0x4001E7D")]
	[FieldOffset(Offset = "0xCC")]
	public bool m_TriggerSuffocationPulse;

	[Token(Token = "0x4001E7E")]
	[FieldOffset(Offset = "0xD0")]
	private float m_SuffocationTarget;

	[Header("Sprain")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E7F")]
	[FieldOffset(Offset = "0xD4")]
	public float m_SprainAmount;

	[Token(Token = "0x4001E80")]
	[FieldOffset(Offset = "0xD8")]
	public float m_SprainAmountSin;

	[Token(Token = "0x4001E81")]
	[FieldOffset(Offset = "0xDC")]
	public float m_SprainSinSpeed;

	[Token(Token = "0x4001E82")]
	[FieldOffset(Offset = "0xE0")]
	public float m_SprainVignetteIntensity;

	[Token(Token = "0x4001E83")]
	[FieldOffset(Offset = "0xE4")]
	public Color m_SprainVignetteColor;

	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0xF4")]
	public bool m_TriggerSprainPulse;

	[Token(Token = "0x4001E85")]
	[FieldOffset(Offset = "0xF8")]
	private float m_SprainTarget;

	[Header("Electrocution")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E86")]
	[FieldOffset(Offset = "0xFC")]
	public float m_ElectrocutionAmount;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E87")]
	[FieldOffset(Offset = "0x100")]
	public float m_ElectrocutionColorGradingBlend;

	[Token(Token = "0x4001E88")]
	[FieldOffset(Offset = "0x108")]
	public Light m_ElectrocutionLight;

	[Token(Token = "0x4001E89")]
	[FieldOffset(Offset = "0x110")]
	public float m_ElectrocutionChromaticAberration;

	[Token(Token = "0x4001E8A")]
	[FieldOffset(Offset = "0x114")]
	private float m_ElectrocutionTarget;

	[Token(Token = "0x4001E8B")]
	[FieldOffset(Offset = "0x118")]
	public bool m_TriggerElectrocutionPulse;

	[Token(Token = "0x4001E8C")]
	[FieldOffset(Offset = "0x11C")]
	private float m_FlickeringElectrocutionAmount;

	[Header("Water")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E8D")]
	[FieldOffset(Offset = "0x120")]
	public float m_WaterAmount;

	[Token(Token = "0x4001E8E")]
	[FieldOffset(Offset = "0x124")]
	public bool m_TriggerWaterPulse;

	[Token(Token = "0x4001E8F")]
	[FieldOffset(Offset = "0x128")]
	private float m_WaterTarget;

	[Header("Aiming")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E90")]
	[FieldOffset(Offset = "0x12C")]
	public float m_AimingAmount;

	[Token(Token = "0x4001E91")]
	[FieldOffset(Offset = "0x130")]
	public bool m_IsAiming;

	[Token(Token = "0x4001E92")]
	[FieldOffset(Offset = "0x134")]
	private float m_AimingTarget;

	[Token(Token = "0x4001E93")]
	[FieldOffset(Offset = "0x138")]
	private UnityEngine.Rendering.PostProcessing.ColorGrading m_NewColorGrading;

	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x76AD90", Offset = "0x769B90", Length = "0xAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x76AE40", Offset = "0x769C40", Length = "0x39")]
	public void PainPulse(float newPain)
	{
	}

	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x76AE80", Offset = "0x769C80", Length = "0x39")]
	public void StimPulse(float newStim)
	{
	}

	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x76AEC0", Offset = "0x769CC0", Length = "0x39")]
	public void BoostEffectPulse(float newBoostEffect)
	{
	}

	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x76AF00", Offset = "0x769D00", Length = "0x32")]
	public void HeadachePulse(float newHeadache)
	{
	}

	[Token(Token = "0x6001BDC")]
	[Address(RVA = "0x76AF40", Offset = "0x769D40", Length = "0x32")]
	public void SuffocationPulse(float newSuffocation)
	{
	}

	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x76AF80", Offset = "0x769D80", Length = "0x32")]
	public void ElectrocutionPulse(float newElectrocution)
	{
	}

	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x76AFC0", Offset = "0x769DC0", Length = "0x32")]
	public void WaterPulse(float newWater)
	{
	}

	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x76B000", Offset = "0x769E00", Length = "0x32")]
	public void SprainPulse(float newSprain)
	{
	}

	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x76B040", Offset = "0x769E40", Length = "0x8")]
	public void StartAiming()
	{
	}

	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x76B050", Offset = "0x769E50", Length = "0x8")]
	public void StopAiming()
	{
	}

	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x76B060", Offset = "0x769E60", Length = "0x12BF")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x76C320", Offset = "0x76B120", Length = "0x416")]
	private void UpdateImage()
	{
	}

	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x76C740", Offset = "0x76B540", Length = "0x4A")]
	private void ResetEffects()
	{
	}

	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x76C790", Offset = "0x76B590", Length = "0x2D7")]
	public CameraStatusEffects()
	{
	}
}
