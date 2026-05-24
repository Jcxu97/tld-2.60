using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[RequireComponent(typeof(BodyHarvest))]
[Token(Token = "0x200056C")]
public class BodyHarvestInteraction : SimpleInteraction
{
	[Token(Token = "0x4003216")]
	[FieldOffset(Offset = "0x48")]
	private BodyHarvest m_BodyHarvest;

	[Token(Token = "0x4003217")]
	[FieldOffset(Offset = "0x50")]
	private string m_BodyName;

	[Token(Token = "0x4003218")]
	[FieldOffset(Offset = "0x58")]
	private int m_LastFrozenPercentage;

	[Token(Token = "0x170002B3")]
	public override bool CanInteract
	{
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x8F3830", Offset = "0x8F2630", Length = "0x3D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x8F3870", Offset = "0x8F2670", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x8F3900", Offset = "0x8F2700", Length = "0x140")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x8F3A50", Offset = "0x8F2850", Length = "0x1BA")]
	private string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x8F3C10", Offset = "0x8F2A10", Length = "0x1B9")]
	private bool CheckCanInteract()
	{
		return false;
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x8F3DD0", Offset = "0x8F2BD0", Length = "0xB3")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x8F3E90", Offset = "0x8F2C90", Length = "0xB0")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	public BodyHarvestInteraction()
	{
	}
}
