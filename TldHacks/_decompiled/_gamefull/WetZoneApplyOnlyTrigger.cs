using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009D8")]
public class WetZoneApplyOnlyTrigger : MonoBehaviour
{
	[Token(Token = "0x40063D8")]
	[FieldOffset(Offset = "0x20")]
	public List<ClothingRegion> m_ClothingRegionsToMakeWet;

	[Token(Token = "0x40063D9")]
	[FieldOffset(Offset = "0x28")]
	public bool m_OnlyOuterLayerGetWet;

	[Token(Token = "0x40063DA")]
	[FieldOffset(Offset = "0x2C")]
	public float m_WetnessIncreasePerHour;

	[Token(Token = "0x40063DB")]
	[FieldOffset(Offset = "0x30")]
	public bool m_InstantWetOnContact;

	[Token(Token = "0x40063DC")]
	[FieldOffset(Offset = "0x31")]
	public bool m_UnfreezeOnContact;

	[Token(Token = "0x40063DD")]
	[FieldOffset(Offset = "0x34")]
	public float m_ColdIncreasePerHour;

	[Token(Token = "0x40063DE")]
	[FieldOffset(Offset = "0x38")]
	public float m_ColdIncreaseOnEntry;

	[Tooltip("Enable the water pulsing visual effect when the player is in this trigger")]
	[Token(Token = "0x40063DF")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_EnableWaterEffect;

	[Tooltip("Extinguish held lit items when the player is in this trigger")]
	[Token(Token = "0x40063E0")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_ExtingquishHeldItem;

	[Token(Token = "0x40063E1")]
	[FieldOffset(Offset = "0x3E")]
	private bool m_PlayerInTrigger;

	[Header("Player Voice")]
	[Token(Token = "0x40063E2")]
	[FieldOffset(Offset = "0x40")]
	public string m_PlayerVoiceOver;

	[Tooltip("Critical voice lines will play every time the player enters this trigger. Non critical have a delay between events")]
	[Token(Token = "0x40063E3")]
	[FieldOffset(Offset = "0x48")]
	public bool m_VoiceOverIsCritical;

	[Token(Token = "0x60056D2")]
	[Address(RVA = "0xEC10E0", Offset = "0xEBFEE0", Length = "0x16E")]
	private void Update()
	{
	}

	[Token(Token = "0x60056D3")]
	[Address(RVA = "0xEC1250", Offset = "0xEC0050", Length = "0x239")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60056D4")]
	[Address(RVA = "0xEC1490", Offset = "0xEC0290", Length = "0x7C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60056D5")]
	[Address(RVA = "0xEC1510", Offset = "0xEC0310", Length = "0x68")]
	private void AddFreezing(float freezingValue)
	{
	}

	[Token(Token = "0x60056D6")]
	[Address(RVA = "0xEC1580", Offset = "0xEC0380", Length = "0x325")]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[Token(Token = "0x60056D7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WetZoneApplyOnlyTrigger()
	{
	}
}
