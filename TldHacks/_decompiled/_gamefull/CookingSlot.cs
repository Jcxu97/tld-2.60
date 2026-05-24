using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000564")]
public class CookingSlot : BaseInteraction
{
	[Token(Token = "0x40031DA")]
	[FieldOffset(Offset = "0x40")]
	public GearPlacePoint m_GearPlacePoint;

	[SerializeField]
	[Token(Token = "0x40031DB")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[Token(Token = "0x40031DC")]
	[FieldOffset(Offset = "0x50")]
	private FireplaceInteraction m_FireplaceHost;

	[Token(Token = "0x6002975")]
	[Address(RVA = "0x8EC210", Offset = "0x8EB010", Length = "0xA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002976")]
	[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
	public void SetFireplaceHost(FireplaceInteraction fireplaceHost)
	{
	}

	[Token(Token = "0x6002977")]
	[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
	public FireplaceInteraction GetFireplaceHost()
	{
		return null;
	}

	[Token(Token = "0x6002978")]
	[Address(RVA = "0x8EC2C0", Offset = "0x8EB0C0", Length = "0x23B")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6002979")]
	[Address(RVA = "0x8EC500", Offset = "0x8EB300", Length = "0xBC")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x600297A")]
	[Address(RVA = "0x8EC5C0", Offset = "0x8EB3C0", Length = "0x1A8")]
	public bool CanCookingSlotBeUsed()
	{
		return false;
	}

	[Token(Token = "0x600297B")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	public CookingSlot()
	{
	}
}
