using System;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200088A")]
public class Breath : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200088B")]
	private class HeavyBreathingAudio
	{
		[Token(Token = "0x4005822")]
		[FieldOffset(Offset = "0x10")]
		public AK.Wwise.Event m_Light;

		[Token(Token = "0x4005823")]
		[FieldOffset(Offset = "0x18")]
		public AK.Wwise.Event m_Medium;

		[Token(Token = "0x4005824")]
		[FieldOffset(Offset = "0x20")]
		public AK.Wwise.Event m_Heavy;

		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public HeavyBreathingAudio()
		{
		}
	}

	[Token(Token = "0x400580D")]
	[FieldOffset(Offset = "0x20")]
	public float m_NormalBreathSeconds;

	[Token(Token = "0x400580E")]
	[FieldOffset(Offset = "0x24")]
	public float m_HeavyBreathSeconds;

	[Token(Token = "0x400580F")]
	[FieldOffset(Offset = "0x28")]
	public float m_ColdBreathTempThreshold;

	[Token(Token = "0x4005810")]
	[FieldOffset(Offset = "0x2C")]
	public float m_VeryColdBreathTempThreshold;

	[Token(Token = "0x4005811")]
	[FieldOffset(Offset = "0x30")]
	public float m_FreezingBreathTempThreshold;

	[Token(Token = "0x4005812")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BreathColdPrefab;

	[Token(Token = "0x4005813")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_BreathVeryColdPrefab;

	[Token(Token = "0x4005814")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_BreathFreezingPrefab;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4005815")]
	[FieldOffset(Offset = "0x50")]
	private AK.Wwise.Event m_TooInjuredToSprintAudio;

	[SerializeField]
	[Token(Token = "0x4005816")]
	[FieldOffset(Offset = "0x58")]
	private HeavyBreathingAudio m_HeavyBreathingAudio;

	[Token(Token = "0x4005817")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_BreathCold;

	[Token(Token = "0x4005818")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_BreathVeryCold;

	[Token(Token = "0x4005819")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_BreathFreezing;

	[Token(Token = "0x400581A")]
	[FieldOffset(Offset = "0x78")]
	private ParticleSystem m_BreathColdParticleSystem;

	[Token(Token = "0x400581B")]
	[FieldOffset(Offset = "0x80")]
	private ParticleSystem m_BreathVeryColdParticleSystem;

	[Token(Token = "0x400581C")]
	[FieldOffset(Offset = "0x88")]
	private ParticleSystem m_BreathFreezingParticleSystem;

	[Token(Token = "0x400581D")]
	[FieldOffset(Offset = "0x90")]
	private float m_NextBreathTime;

	[Token(Token = "0x400581E")]
	[FieldOffset(Offset = "0x94")]
	private bool m_EffectsParented;

	[Token(Token = "0x400581F")]
	[FieldOffset(Offset = "0x98")]
	private float m_BreathTimePercent;

	[Token(Token = "0x4005820")]
	[FieldOffset(Offset = "0x9C")]
	private float m_BreathTime;

	[Token(Token = "0x4005821")]
	[FieldOffset(Offset = "0xA0")]
	public bool m_SuppressEffects;

	[Token(Token = "0x6004DE3")]
	[Address(RVA = "0xD97300", Offset = "0xD96100", Length = "0x839")]
	public void Start()
	{
	}

	[Token(Token = "0x6004DE4")]
	[Address(RVA = "0xD97B40", Offset = "0xD96940", Length = "0x41B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004DE5")]
	[Address(RVA = "0xD97F60", Offset = "0xD96D60", Length = "0x247")]
	public void StopBreathEffectImmediate()
	{
	}

	[Token(Token = "0x6004DE6")]
	[Address(RVA = "0x507960", Offset = "0x506760", Length = "0x9")]
	public float GetBreathTimePercent()
	{
		return 0f;
	}

	[Token(Token = "0x6004DE7")]
	[Address(RVA = "0xD981B0", Offset = "0xD96FB0", Length = "0x390")]
	private void PlayBreathEffect()
	{
	}

	[Token(Token = "0x6004DE8")]
	[Address(RVA = "0xD98550", Offset = "0xD97350", Length = "0x32")]
	public static float GetBreathingStatePercent(HeavyBreathingState hbs)
	{
		return 0f;
	}

	[Token(Token = "0x6004DE9")]
	[Address(RVA = "0xD98590", Offset = "0xD97390", Length = "0x35D")]
	public void Update()
	{
	}

	[Token(Token = "0x6004DEA")]
	[Address(RVA = "0xD988F0", Offset = "0xD976F0", Length = "0x496")]
	private void ParentEffectToCamera(GameObject instance)
	{
	}

	[Token(Token = "0x6004DEB")]
	[Address(RVA = "0xD98D90", Offset = "0xD97B90", Length = "0x2D6")]
	private bool ShouldSuppressBreathEffect()
	{
		return false;
	}

	[Token(Token = "0x6004DEC")]
	[Address(RVA = "0xD99070", Offset = "0xD97E70", Length = "0x4B")]
	private bool ShouldSuppressBreathingParticleEffects()
	{
		return false;
	}

	[Token(Token = "0x6004DED")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Breath()
	{
	}
}
