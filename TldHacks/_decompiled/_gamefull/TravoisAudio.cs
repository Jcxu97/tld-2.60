using System;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001C9")]
public class TravoisAudio : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001CA")]
	private class BreathAudioMapping
	{
		[Range(0f, 1f)]
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x10")]
		public float m_WeightThreshold;

		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x18")]
		public AK.Wwise.Event m_BreathingEvent;

		[Token(Token = "0x6001067")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BreathAudioMapping()
		{
		}
	}

	[Header("Pickup")]
	[SerializeField]
	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x20")]
	private AK.Wwise.Event m_PickupAudioEvent;

	[SerializeField]
	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_PutDownAudioEvent;

	[SerializeField]
	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x30")]
	private AK.Wwise.Event m_PickupVOEvent;

	[SerializeField]
	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x38")]
	private AK.Wwise.Event m_PutDownVOEvent;

	[Header("Carry")]
	[SerializeField]
	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_MovementLoopEvent;

	[Header("Breathing")]
	[SerializeField]
	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x48")]
	private AK.Wwise.Event m_IdleBreathingEvent;

	[SerializeField]
	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x50")]
	private BreathAudioMapping[] m_MovingBreathingEvents;

	[Header("Destroy")]
	[SerializeField]
	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x58")]
	private AK.Wwise.Event m_DestroyAudioEvent;

	[Header("RTPC")]
	[SerializeField]
	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x60")]
	private RTPC m_ContainerWeightRatioRTPC;

	[SerializeField]
	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x68")]
	private RTPC m_TurnAngleRTPC;

	[SerializeField]
	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x70")]
	private float m_TurnAudioUpdateRateSeconds;

	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_LastUpdatedForwardDirection;

	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_CurrentForwardDirection;

	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x8C")]
	private float m_TurnAudioUpdateTimer;

	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x90")]
	private float m_LastSentTurnAngle;

	[Token(Token = "0x600105E")]
	[Address(RVA = "0x6274D0", Offset = "0x6262D0", Length = "0xF9")]
	public void InitializeAudio(Vector3 forwardDirection)
	{
	}

	[Token(Token = "0x600105F")]
	[Address(RVA = "0x6275D0", Offset = "0x6263D0", Length = "0x111")]
	public void PlayHoistAudio(bool pickingUp)
	{
	}

	[Token(Token = "0x6001060")]
	[Address(RVA = "0x6276F0", Offset = "0x6264F0", Length = "0x6C")]
	public void PlayCarryAudioLoop()
	{
	}

	[Token(Token = "0x6001061")]
	[Address(RVA = "0x627760", Offset = "0x626560", Length = "0xCD")]
	public AK.Wwise.Event GetBreathAudioEvent(float weightRatio)
	{
		return null;
	}

	[Token(Token = "0x6001062")]
	[Address(RVA = "0x627830", Offset = "0x626630", Length = "0x62")]
	public void PlayDestroyAudio(GameObject ruinedTravois)
	{
	}

	[Token(Token = "0x6001063")]
	[Address(RVA = "0x6278A0", Offset = "0x6266A0", Length = "0xE7")]
	public void UpdateContainerWeight(float weightRatio)
	{
	}

	[Token(Token = "0x6001064")]
	[Address(RVA = "0x627990", Offset = "0x626790", Length = "0x16")]
	public void UpdateForwardDirection(Vector3 forwardDirection)
	{
	}

	[Token(Token = "0x6001065")]
	[Address(RVA = "0x6279B0", Offset = "0x6267B0", Length = "0x23E")]
	public void UpdateAudio()
	{
	}

	[Token(Token = "0x6001066")]
	[Address(RVA = "0x627BF0", Offset = "0x6269F0", Length = "0x4A")]
	public TravoisAudio()
	{
	}
}
