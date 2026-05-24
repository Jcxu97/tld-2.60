using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[Token(Token = "0x20006F5")]
public class LoadingZone : TimedHoldInteraction
{
	[Token(Token = "0x40049F5")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_LocalizedTransitionType;

	[Token(Token = "0x40049F6")]
	[FieldOffset(Offset = "0x70")]
	public LoadScene m_PartnerLoadScene;

	[Token(Token = "0x40049F7")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 m_Forward;

	[Token(Token = "0x40049F8")]
	[FieldOffset(Offset = "0x84")]
	private bool m_LoadingZoneActive;

	[Token(Token = "0x17000314")]
	public override bool CanInteract
	{
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0xB8A480", Offset = "0xB89280", Length = "0x13F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000315")]
	public override bool CanCancel
	{
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6003D06")]
	[Address(RVA = "0xB8A5C0", Offset = "0xB893C0", Length = "0x1A1")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D07")]
	[Address(RVA = "0xB8A770", Offset = "0xB89570", Length = "0x1C0")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6003D08")]
	[Address(RVA = "0xB8A940", Offset = "0xB89740", Length = "0x4E")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6003D09")]
	[Address(RVA = "0xB8A990", Offset = "0xB89790", Length = "0x7")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003D0A")]
	[Address(RVA = "0xB8A9A0", Offset = "0xB897A0", Length = "0x245")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6003D0B")]
	[Address(RVA = "0xB8ABF0", Offset = "0xB899F0", Length = "0x82")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6003D0C")]
	[Address(RVA = "0xB8AC80", Offset = "0xB89A80", Length = "0x7A2")]
	private void ComputeTriggerForwardDirection()
	{
	}

	[Token(Token = "0x6003D0D")]
	[Address(RVA = "0xB8B430", Offset = "0xB8A230", Length = "0x10C")]
	private void ActivateLoadingZone()
	{
	}

	[Token(Token = "0x6003D0E")]
	[Address(RVA = "0xB8B540", Offset = "0xB8A340", Length = "0x6E")]
	private void DeactivateLoadingZone()
	{
	}

	[Token(Token = "0x6003D0F")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public LoadingZone()
	{
	}
}
