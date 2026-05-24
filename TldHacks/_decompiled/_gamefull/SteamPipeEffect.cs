using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000960")]
public class SteamPipeEffect : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000961")]
	private class ParticleParameters
	{
		[Token(Token = "0x400619E")]
		[FieldOffset(Offset = "0x10")]
		public ParticleSystem m_ParticleSystem;

		[Token(Token = "0x400619F")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve m_ThawingEmissionCurve;

		[Token(Token = "0x40061A0")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve m_HeatingEmissionCurve;

		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ParticleParameters()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x400617F")]
	[FieldOffset(Offset = "0x20")]
	private Renderer[] m_AffectedRenderers;

	[SerializeField]
	[Token(Token = "0x4006180")]
	[FieldOffset(Offset = "0x28")]
	private ParticleParameters[] m_AffectedParticles;

	[SerializeField]
	[Token(Token = "0x4006181")]
	[FieldOffset(Offset = "0x30")]
	private AnimationCurve m_ThawingCurve;

	[SerializeField]
	[Token(Token = "0x4006182")]
	[FieldOffset(Offset = "0x38")]
	private AnimationCurve m_HeatingCurve;

	[SerializeField]
	[Token(Token = "0x4006183")]
	[FieldOffset(Offset = "0x40")]
	private float m_ThawingTime;

	[SerializeField]
	[Token(Token = "0x4006184")]
	[FieldOffset(Offset = "0x44")]
	private float m_HeatingTime;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4006185")]
	[FieldOffset(Offset = "0x48")]
	private float m_StartingFreeze;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4006186")]
	[FieldOffset(Offset = "0x4C")]
	private float m_StartingHeat;

	[SerializeField]
	[Token(Token = "0x4006187")]
	[FieldOffset(Offset = "0x50")]
	private float m_HeatSaturationThreshold;

	[SerializeField]
	[Token(Token = "0x4006188")]
	[FieldOffset(Offset = "0x54")]
	private float m_DistanceFactorFromHeatSource;

	[SerializeField]
	[Token(Token = "0x4006189")]
	[FieldOffset(Offset = "0x58")]
	private string m_ThawingAudio;

	[SerializeField]
	[Token(Token = "0x400618A")]
	[FieldOffset(Offset = "0x60")]
	private string m_HeatOnAudio;

	[SerializeField]
	[Token(Token = "0x400618B")]
	[FieldOffset(Offset = "0x68")]
	private string m_HeatOffAudio;

	[Token(Token = "0x400618C")]
	[FieldOffset(Offset = "0x70")]
	private SteamPipe m_Source;

	[Token(Token = "0x400618D")]
	[FieldOffset(Offset = "0x78")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x400618E")]
	[FieldOffset(Offset = "0x80")]
	private float m_CurrentFreeze;

	[Token(Token = "0x400618F")]
	[FieldOffset(Offset = "0x84")]
	private float m_LastFreeze;

	[Token(Token = "0x4006190")]
	[FieldOffset(Offset = "0x88")]
	private float m_TargetFreeze;

	[Token(Token = "0x4006191")]
	[FieldOffset(Offset = "0x8C")]
	private float m_ThawTimeStart;

	[Token(Token = "0x4006192")]
	[FieldOffset(Offset = "0x90")]
	private float m_ThawTimeEnd;

	[Token(Token = "0x4006193")]
	[FieldOffset(Offset = "0x94")]
	private float m_CurrentHeat;

	[Token(Token = "0x4006194")]
	[FieldOffset(Offset = "0x98")]
	private float m_LastHeat;

	[Token(Token = "0x4006195")]
	[FieldOffset(Offset = "0x9C")]
	private float m_TargetHeat;

	[Token(Token = "0x4006196")]
	[FieldOffset(Offset = "0xA0")]
	private float m_HeatTimeStart;

	[Token(Token = "0x4006197")]
	[FieldOffset(Offset = "0xA4")]
	private float m_HeatTimeEnd;

	[Token(Token = "0x4006198")]
	[FieldOffset(Offset = "0xA8")]
	private float m_DistanceDelay;

	[Token(Token = "0x4006199")]
	[FieldOffset(Offset = "0xAC")]
	private uint m_ThawingAudioID;

	[Token(Token = "0x400619A")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_HeatOnAudioID;

	[Token(Token = "0x400619B")]
	[FieldOffset(Offset = "0xB4")]
	private uint m_HeatOffAudioID;

	[Token(Token = "0x400619C")]
	private static readonly int s_FrozenAmountShaderID;

	[Token(Token = "0x400619D")]
	private static readonly int s_HeatedAmountShaderID;

	[Token(Token = "0x60054C2")]
	[Address(RVA = "0xE8E0C0", Offset = "0xE8CEC0", Length = "0x9DB")]
	public void SetSource(SteamPipe source)
	{
	}

	[Token(Token = "0x60054C3")]
	[Address(RVA = "0xE8EAA0", Offset = "0xE8D8A0", Length = "0xE0")]
	public void Thaw(bool immediate)
	{
	}

	[Token(Token = "0x60054C4")]
	[Address(RVA = "0xE8EB90", Offset = "0xE8D990", Length = "0x6C")]
	public bool IsFrozen()
	{
		return false;
	}

	[Token(Token = "0x60054C5")]
	[Address(RVA = "0xE8EC00", Offset = "0xE8DA00", Length = "0x111")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054C6")]
	[Address(RVA = "0xE8ED20", Offset = "0xE8DB20", Length = "0xA")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054C7")]
	[Address(RVA = "0xE8ED30", Offset = "0xE8DB30", Length = "0x103")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60054C8")]
	[Address(RVA = "0xE8EE40", Offset = "0xE8DC40", Length = "0xBF")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60054C9")]
	[Address(RVA = "0xE8EF00", Offset = "0xE8DD00", Length = "0x3CC")]
	public void DoUpdate(float currentTime)
	{
	}

	[Token(Token = "0x60054CA")]
	[Address(RVA = "0xE8F2D0", Offset = "0xE8E0D0", Length = "0x3D")]
	private void OnPipeSourceInternalFlowChanged(float value)
	{
	}

	[Token(Token = "0x60054CB")]
	[Address(RVA = "0xE8F310", Offset = "0xE8E110", Length = "0xB7")]
	private void UpdateHeatTime()
	{
	}

	[Token(Token = "0x60054CC")]
	[Address(RVA = "0xE8F3D0", Offset = "0xE8E1D0", Length = "0x124")]
	private bool MaybeUpdateThawing(float currentTime)
	{
		return false;
	}

	[Token(Token = "0x60054CD")]
	[Address(RVA = "0xE8F500", Offset = "0xE8E300", Length = "0x172")]
	private bool MaybeUpdateHeating(float currentTime)
	{
		return false;
	}

	[Token(Token = "0x60054CE")]
	[Address(RVA = "0xE8F680", Offset = "0xE8E480", Length = "0x22")]
	private void MaybePlayThawingAudio(bool isThawing)
	{
	}

	[Token(Token = "0x60054CF")]
	[Address(RVA = "0xE8F6B0", Offset = "0xE8E4B0", Length = "0x12C")]
	private void MaybePlayHeatingAudio(bool isHeatChanging)
	{
	}

	[Token(Token = "0x60054D0")]
	[Address(RVA = "0xE8F7E0", Offset = "0xE8E5E0", Length = "0xC3")]
	private void PlayOrStopAudio(bool shouldPlay, string audio, ref uint audioID)
	{
	}

	[Token(Token = "0x60054D1")]
	[Address(RVA = "0xE8F8B0", Offset = "0xE8E6B0", Length = "0x36B")]
	private void UpdateRenderers()
	{
	}

	[Token(Token = "0x60054D2")]
	[Address(RVA = "0xE8FC20", Offset = "0xE8EA20", Length = "0x339")]
	private void UpdateParticles()
	{
	}

	[Token(Token = "0x60054D3")]
	[Address(RVA = "0xE8FF60", Offset = "0xE8ED60", Length = "0x5F")]
	public SteamPipeEffect()
	{
	}
}
