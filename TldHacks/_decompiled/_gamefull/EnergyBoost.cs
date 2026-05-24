using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001DF")]
public class EnergyBoost : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x20")]
	private HeadacheData m_HeadacheSettings;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_EnergyBoostPulseEvent;

	[SerializeField]
	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x30")]
	private AK.Wwise.Event m_EnergyBoostStartAudio;

	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x38")]
	private EnergyBoostParams m_EnergyBoostParams;

	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x40")]
	private float m_LastBoostPulseTime;

	[Token(Token = "0x6001118")]
	[Address(RVA = "0x637CF0", Offset = "0x636AF0", Length = "0x8D")]
	public void Update()
	{
	}

	[Token(Token = "0x6001119")]
	[Address(RVA = "0x637D80", Offset = "0x636B80", Length = "0x88")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600111A")]
	[Address(RVA = "0x637E10", Offset = "0x636C10", Length = "0xCC")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600111B")]
	[Address(RVA = "0x637EE0", Offset = "0x636CE0", Length = "0x89")]
	public bool GetEnergyBoostActive()
	{
		return false;
	}

	[Token(Token = "0x600111C")]
	[Address(RVA = "0x637F70", Offset = "0x636D70", Length = "0x302")]
	public void ApplyEnergyBoost(EnergyBoostItem energyBoostItem)
	{
	}

	[Token(Token = "0x600111D")]
	[Address(RVA = "0x638280", Offset = "0x637080", Length = "0x8E")]
	public float GetEnergyBoostTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x600111E")]
	[Address(RVA = "0x638310", Offset = "0x637110", Length = "0x3F")]
	public float GetEnergyBoostTimeRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x600111F")]
	[Address(RVA = "0x638350", Offset = "0x637150", Length = "0x9E")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6001120")]
	[Address(RVA = "0x6383F0", Offset = "0x6371F0", Length = "0x397")]
	private void MaybeUpdateEnergyBoostEffects()
	{
	}

	[Token(Token = "0x6001121")]
	[Address(RVA = "0x638790", Offset = "0x637590", Length = "0xBC")]
	private void ApplyEnergyBoostExitEffects()
	{
	}

	[Token(Token = "0x6001122")]
	[Address(RVA = "0x638850", Offset = "0x637650", Length = "0xF0")]
	public void ResetEnergyBoost()
	{
	}

	[Token(Token = "0x6001123")]
	[Address(RVA = "0x638940", Offset = "0x637740", Length = "0xC4")]
	public EnergyBoost()
	{
	}
}
