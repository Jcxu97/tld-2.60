using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001F4")]
public class Suffocating : MonoBehaviour
{
	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_SufocatingRiskLocalizedString;

	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_SufocatingDescription;

	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_SufocatingTreatment;

	[Token(Token = "0x40011A6")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_SuffocatingCause;

	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x40")]
	public string m_SuffocatingRiskIcon;

	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x48")]
	public float m_SuffocatingDelayTimerSeconds;

	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x4C")]
	public float m_SuffocatingTimerSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x50")]
	public float m_SuffocatingVFXDurationSeconds;

	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x58")]
	public MinMax m_SuffocatingVisualEffectStrengthRange;

	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve m_SuffocatingVisualEffectStrength;

	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x68")]
	public string m_NoBreathingSound;

	[Range(0f, 500f)]
	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x70")]
	public float m_NoBreathingSoundDelayTimeMinSeconds;

	[Range(0f, 500f)]
	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x74")]
	public float m_NoBreathingSoundDelayTimeMaxSeconds;

	[Header("Audio")]
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x78")]
	public string m_AudioEvent;

	[Token(Token = "0x40011B1")]
	private static SuffocatingSaveDataProxy m_SuffocatingSaveDataProxy;

	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsSuffocating;

	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x84")]
	private int m_SuffocatingTriggerCounter;

	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x88")]
	private float m_SuffocatingDelayTimeRemaining;

	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x8C")]
	private float m_SuffocatingTimeRemaining;

	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x90")]
	private float m_SoundDelayTimeRemaining;

	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x94")]
	private float m_SuffocatingVisualEffectTimer;

	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x98")]
	private float m_SuffocatingTimerSecondsOverride;

	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_SuffocatingTimerIsPaused;

	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x9D")]
	private bool m_BlockSuffocating;

	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x6436D0", Offset = "0x6424D0", Length = "0xA")]
	public void Start()
	{
	}

	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x6436E0", Offset = "0x6424E0", Length = "0x7")]
	public void BlockSuffocating(bool block)
	{
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x6436F0", Offset = "0x6424F0", Length = "0x8")]
	public bool IsSuffocatingBlocked()
	{
		return false;
	}

	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x643700", Offset = "0x642500", Length = "0x2BB")]
	public void StartSuffocating(SuffocatingSettings suffocatingSettingsPrefab = null)
	{
	}

	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x6439C0", Offset = "0x6427C0", Length = "0x10C")]
	public void MaybeStopSuffocating()
	{
	}

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x643AD0", Offset = "0x6428D0", Length = "0x44")]
	public void ForceStopSuffocating(bool stopSilently)
	{
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x502360", Offset = "0x501160", Length = "0x9")]
	public float GetSuffocatingTimeRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x643B20", Offset = "0x642920", Length = "0x36")]
	public float GetSoffocatingTimeRemainingAsPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x643B60", Offset = "0x642960", Length = "0x2E")]
	private void ApplySuffocation()
	{
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x643B90", Offset = "0x642990", Length = "0x173")]
	private void ApplySuffocatingVisualEffect()
	{
	}

	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x643D10", Offset = "0x642B10", Length = "0x5F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x644310", Offset = "0x643110", Length = "0x14D")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x644460", Offset = "0x643260", Length = "0xBB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x644520", Offset = "0x643320", Length = "0x8")]
	public bool IsSuffocating()
	{
		return false;
	}

	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x644530", Offset = "0x643330", Length = "0xB")]
	public bool HasSuffocatingRisk()
	{
		return false;
	}

	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x644540", Offset = "0x643340", Length = "0x90")]
	private void StopAudio()
	{
	}

	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x6445E0", Offset = "0x6433E0", Length = "0x1F")]
	private void StopSuffocating()
	{
	}

	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x644600", Offset = "0x643400", Length = "0x16A")]
	public Suffocating()
	{
	}
}
