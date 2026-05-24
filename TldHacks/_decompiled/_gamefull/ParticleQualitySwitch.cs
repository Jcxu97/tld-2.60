using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003ED")]
public class ParticleQualitySwitch : MonoBehaviour
{
	[Token(Token = "0x20003EE")]
	public enum FxComponentQuality
	{
		[Token(Token = "0x4002345")]
		Off,
		[Token(Token = "0x4002346")]
		Low,
		[Token(Token = "0x4002347")]
		Medium,
		[Token(Token = "0x4002348")]
		High
	}

	[Token(Token = "0x400231D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ParticleParent;

	[Tooltip("If set to true, the script will only adjust settings if the module itself is active and being used. Eg, if collision is originally \"off\", then the script will keep it off regardless of the quality settings. Otherwise it will force it on.")]
	[Token(Token = "0x400231E")]
	[FieldOffset(Offset = "0x28")]
	public bool m_UseModuleState;

	[Header("Low Quality")]
	[Token(Token = "0x400231F")]
	[FieldOffset(Offset = "0x2C")]
	public FxComponentQuality m_LowCollideQuality;

	[Token(Token = "0x4002320")]
	[FieldOffset(Offset = "0x30")]
	public FxComponentQuality m_LowNoiseQuality;

	[Token(Token = "0x4002321")]
	[FieldOffset(Offset = "0x34")]
	public bool m_LowDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x4002322")]
	[FieldOffset(Offset = "0x38")]
	public float m_LowEmissionRateFactor;

	[Range(0f, 1f)]
	[Token(Token = "0x4002323")]
	[FieldOffset(Offset = "0x3C")]
	public float m_LowMaxParticlesFactor;

	[Header("Medium Quality")]
	[Token(Token = "0x4002324")]
	[FieldOffset(Offset = "0x40")]
	public FxComponentQuality m_MediumCollideQuality;

	[Token(Token = "0x4002325")]
	[FieldOffset(Offset = "0x44")]
	public FxComponentQuality m_MediumNoiseQuality;

	[Token(Token = "0x4002326")]
	[FieldOffset(Offset = "0x48")]
	public bool m_MediumDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x4002327")]
	[FieldOffset(Offset = "0x4C")]
	public float m_MediumEmissionRateFactor;

	[Range(0f, 1f)]
	[Token(Token = "0x4002328")]
	[FieldOffset(Offset = "0x50")]
	public float m_MediumMaxParticlesFactor;

	[Header("High Quality")]
	[Token(Token = "0x4002329")]
	[FieldOffset(Offset = "0x54")]
	public FxComponentQuality m_HighCollideQuality;

	[Token(Token = "0x400232A")]
	[FieldOffset(Offset = "0x58")]
	public FxComponentQuality m_HighNoiseQuality;

	[Token(Token = "0x400232B")]
	[FieldOffset(Offset = "0x5C")]
	public bool m_HighDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x400232C")]
	[FieldOffset(Offset = "0x60")]
	public float m_HighEmissionRateFactor;

	[Range(0f, 1f)]
	[Token(Token = "0x400232D")]
	[FieldOffset(Offset = "0x64")]
	public float m_HighMaxParticlesFactor;

	[Header("Ultra Quality")]
	[Token(Token = "0x400232E")]
	[FieldOffset(Offset = "0x68")]
	public FxComponentQuality m_UltraCollideQuality;

	[Token(Token = "0x400232F")]
	[FieldOffset(Offset = "0x6C")]
	public FxComponentQuality m_UltraNoiseQuality;

	[Token(Token = "0x4002330")]
	[FieldOffset(Offset = "0x70")]
	public bool m_UltraDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x4002331")]
	[FieldOffset(Offset = "0x74")]
	public float m_UltraEmissionRateFactor;

	[Range(0f, 1f)]
	[Token(Token = "0x4002332")]
	[FieldOffset(Offset = "0x78")]
	public float m_UltraMaxParticlesFactor;

	[Header("Console Low Quality (Switch)")]
	[Token(Token = "0x4002333")]
	[FieldOffset(Offset = "0x7C")]
	public FxComponentQuality m_ConsoleLowCollideQuality;

	[Token(Token = "0x4002334")]
	[FieldOffset(Offset = "0x80")]
	public FxComponentQuality m_ConsoleLowNoiseQuality;

	[Token(Token = "0x4002335")]
	[FieldOffset(Offset = "0x84")]
	public bool m_ConsoleLowDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x4002336")]
	[FieldOffset(Offset = "0x88")]
	public float m_ConsoleLowEmissionRateFactor;

	[Range(0f, 1f)]
	[Token(Token = "0x4002337")]
	[FieldOffset(Offset = "0x8C")]
	public float m_ConsoleLowMaxParticlesFactor;

	[Header("Console Quality (Xbox & PS4)")]
	[Token(Token = "0x4002338")]
	[FieldOffset(Offset = "0x90")]
	public FxComponentQuality m_ConsoleCollideQuality;

	[Token(Token = "0x4002339")]
	[FieldOffset(Offset = "0x94")]
	public FxComponentQuality m_ConsoleNoiseQuality;

	[Token(Token = "0x400233A")]
	[FieldOffset(Offset = "0x98")]
	public bool m_ConsoleDisabled;

	[Range(0f, 1f)]
	[Token(Token = "0x400233B")]
	[FieldOffset(Offset = "0x9C")]
	public float m_ConsoleEmissionRateFactor;

	[Range(0f, 1f)]
	[Token(Token = "0x400233C")]
	[FieldOffset(Offset = "0xA0")]
	public float m_ConsoleMaxParticlesFactor;

	[Token(Token = "0x400233D")]
	[FieldOffset(Offset = "0xA4")]
	private QualityLodBias m_CachedQuality;

	[Token(Token = "0x400233E")]
	[FieldOffset(Offset = "0xA8")]
	private List<ParticleSystem> m_FxList;

	[Token(Token = "0x400233F")]
	[FieldOffset(Offset = "0xB0")]
	private List<bool> m_FxCollideState;

	[Token(Token = "0x4002340")]
	[FieldOffset(Offset = "0xB8")]
	private List<bool> m_FxNoiseState;

	[Token(Token = "0x4002341")]
	[FieldOffset(Offset = "0xC0")]
	private List<ParticleSystem.MinMaxCurve> m_FxEmissionRateOverTime;

	[Token(Token = "0x4002342")]
	[FieldOffset(Offset = "0xC8")]
	private List<int> m_FxMaxParticles;

	[Token(Token = "0x4002343")]
	private static List<ParticleQualitySwitch> s_ParticleQualitySwitchList;

	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x7B6A80", Offset = "0x7B5880", Length = "0x103")]
	public static void UpdateLocalQualitySettings(QualityLodBias qualityLodBias)
	{
	}

	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x7B6B90", Offset = "0x7B5990", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E39")]
	[Address(RVA = "0x7B6BA0", Offset = "0x7B59A0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x7B6C30", Offset = "0x7B5A30", Length = "0xC85")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x7B78C0", Offset = "0x7B66C0", Length = "0x12E")]
	private void RefreshLocalQuality(QualityLodBias qualityLodBias)
	{
	}

	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x7B79F0", Offset = "0x7B67F0", Length = "0x97A")]
	private void SetLocalQuality(int fxIndex, bool isDisabled, FxComponentQuality collisionQuality, FxComponentQuality noiseQuality, float emissionRateFactor, float maxParticlesFactor)
	{
	}

	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x7B8370", Offset = "0x7B7170", Length = "0x10D")]
	private ParticleSystem.MinMaxCurve GetEmissionRate(ParticleSystem particleSystem)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x7B8480", Offset = "0x7B7280", Length = "0xB7")]
	private int GetMaxParticles(ParticleSystem particleSystem)
	{
		return 0;
	}

	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0x7B8540", Offset = "0x7B7340", Length = "0x17D")]
	private void SetEmissionRate(ParticleSystem particleSystem, ParticleSystem.MinMaxCurve originalMinMaxCurve, float emissionRateFactor)
	{
	}

	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x7B86C0", Offset = "0x7B74C0", Length = "0xCE")]
	private void SetMaxParticles(ParticleSystem particleSystem, int originalMaxParticles, float maxParticlesFactor)
	{
	}

	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x7B8790", Offset = "0x7B7590", Length = "0xE1")]
	public ParticleQualitySwitch()
	{
	}
}
