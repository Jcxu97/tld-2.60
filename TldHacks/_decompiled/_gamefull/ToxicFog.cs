using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200053A")]
public class ToxicFog : MonoBehaviour
{
	[Token(Token = "0x4003024")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_ToxicFogLocalizaedString;

	[Token(Token = "0x4003025")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_ToxicFogDescription;

	[Token(Token = "0x4003026")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_ToxicFogTreatment;

	[Token(Token = "0x4003027")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_ToxicFogCause;

	[Token(Token = "0x4003028")]
	[FieldOffset(Offset = "0x40")]
	public string m_ToxicFogIcon;

	[Range(0f, 100f)]
	[Token(Token = "0x4003029")]
	[FieldOffset(Offset = "0x48")]
	public float m_HealthLossPerMinute;

	[Token(Token = "0x400302A")]
	[FieldOffset(Offset = "0x50")]
	public MinMax m_HeadacheStrengthRange;

	[Token(Token = "0x400302B")]
	[FieldOffset(Offset = "0x58")]
	public float m_HeadachePulseDelay;

	[Header("Audio")]
	[Token(Token = "0x400302C")]
	[FieldOffset(Offset = "0x60")]
	public string m_AudioEvent;

	[Token(Token = "0x400302D")]
	[FieldOffset(Offset = "0x68")]
	private float m_HeadachePulseTimer;

	[Token(Token = "0x400302E")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_HasAffliction;

	[Token(Token = "0x400302F")]
	[FieldOffset(Offset = "0x6D")]
	public bool m_AllowAfflictionHeadache;

	[Token(Token = "0x60027F6")]
	[Address(RVA = "0x8BD620", Offset = "0x8BC420", Length = "0x1B")]
	public string GetAfflictionLocId()
	{
		return null;
	}

	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[Token(Token = "0x60027F8")]
	[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[Token(Token = "0x60027F9")]
	[Address(RVA = "0x74FFD0", Offset = "0x74EDD0", Length = "0x5D")]
	public string GetAfflictionCause()
	{
		return null;
	}

	[Token(Token = "0x60027FA")]
	[Address(RVA = "0x7523F0", Offset = "0x7511F0", Length = "0x5")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x60027FB")]
	[Address(RVA = "0x8BD640", Offset = "0x8BC440", Length = "0x136")]
	public void StartAffliction()
	{
	}

	[Token(Token = "0x60027FC")]
	[Address(RVA = "0x8BD780", Offset = "0x8BC580", Length = "0x133")]
	public void StopAffliction()
	{
	}

	[Token(Token = "0x60027FD")]
	[Address(RVA = "0x8BD8C0", Offset = "0x8BC6C0", Length = "0xBB")]
	private void ToxicFogHeadachePulse()
	{
	}

	[Token(Token = "0x60027FE")]
	[Address(RVA = "0x8BD980", Offset = "0x8BC780", Length = "0x28C")]
	public void Update()
	{
	}

	[Token(Token = "0x60027FF")]
	[Address(RVA = "0x8BDC10", Offset = "0x8BCA10", Length = "0x1C0")]
	public ToxicFog()
	{
	}
}
