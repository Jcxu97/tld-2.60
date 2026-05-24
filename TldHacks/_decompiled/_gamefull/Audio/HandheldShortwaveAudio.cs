using AK.Wwise;
using Cpp2ILInjected;
using InteractiveObjects;
using UnityEngine;

namespace Audio;

[Token(Token = "0x2001331")]
public class HandheldShortwaveAudio : MonoBehaviour
{
	[Header("SFX")]
	[SerializeField]
	[Token(Token = "0x4008DAD")]
	[FieldOffset(Offset = "0x20")]
	private AK.Wwise.Event m_RangeThresholdEnterAudioEvent;

	[SerializeField]
	[Token(Token = "0x4008DAE")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_RangeThresholdExitAudioEvent;

	[SerializeField]
	[Token(Token = "0x4008DAF")]
	[FieldOffset(Offset = "0x30")]
	private AK.Wwise.Event m_EquippedInHandAudioEvent;

	[SerializeField]
	[Token(Token = "0x4008DB0")]
	[FieldOffset(Offset = "0x38")]
	private AK.Wwise.Event m_AddedToBackpackAudioEvent;

	[SerializeField]
	[Token(Token = "0x4008DB1")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_ElectrostaticForceActiveEvent;

	[SerializeField]
	[Token(Token = "0x4008DB2")]
	[FieldOffset(Offset = "0x48")]
	private AK.Wwise.Event m_ElectrostaticForceDeactiveEvent;

	[SerializeField]
	[Token(Token = "0x4008DB3")]
	[FieldOffset(Offset = "0x50")]
	private RTPC m_SignalStrengthRTPC;

	[SerializeField]
	[Token(Token = "0x4008DB4")]
	[FieldOffset(Offset = "0x58")]
	private RTPC m_DistanceRTPC;

	[SerializeField]
	[Token(Token = "0x4008DB5")]
	[FieldOffset(Offset = "0x60")]
	private HandheldShortwaveItem m_Handheldshortwave;

	[Token(Token = "0x4008DB6")]
	[FieldOffset(Offset = "0x68")]
	private bool m_RangeThreshholdEnteredPlayed;

	[Token(Token = "0x6007B0B")]
	[Address(RVA = "0x119B530", Offset = "0x119A330", Length = "0x144")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007B0C")]
	[Address(RVA = "0x119B680", Offset = "0x119A480", Length = "0x19E")]
	public void UpdateAudio()
	{
	}

	[Token(Token = "0x6007B0D")]
	[Address(RVA = "0x119B820", Offset = "0x119A620", Length = "0x79")]
	private void OnTrackingModeChanged(TrackableItemType trackableMode)
	{
	}

	[Token(Token = "0x6007B0E")]
	[Address(RVA = "0x119B8A0", Offset = "0x119A6A0", Length = "0x6C")]
	public void OnItemAddedToBackpack()
	{
	}

	[Token(Token = "0x6007B0F")]
	[Address(RVA = "0x119B910", Offset = "0x119A710", Length = "0x6C")]
	public void OnItemEquippedInHand()
	{
	}

	[Token(Token = "0x6007B10")]
	[Address(RVA = "0x119B980", Offset = "0x119A780", Length = "0x7A")]
	private void OnElectrostaticActivationChanged(bool isActive)
	{
	}

	[Token(Token = "0x6007B11")]
	[Address(RVA = "0x119BA00", Offset = "0x119A800", Length = "0xF2")]
	private void UpdateRangeAudio()
	{
	}

	[Token(Token = "0x6007B12")]
	[Address(RVA = "0x119BB00", Offset = "0x119A900", Length = "0xBF")]
	private void UpdateRTPCValues()
	{
	}

	[Token(Token = "0x6007B13")]
	[Address(RVA = "0x119BBC0", Offset = "0x119A9C0", Length = "0x9A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007B14")]
	[Address(RVA = "0x119BC60", Offset = "0x119AA60", Length = "0x93")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007B15")]
	[Address(RVA = "0x119BD00", Offset = "0x119AB00", Length = "0x93")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007B16")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HandheldShortwaveAudio()
	{
	}
}
