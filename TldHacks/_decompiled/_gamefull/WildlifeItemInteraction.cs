using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[RequireComponent(typeof(BaseAi), typeof(BodyHarvest), typeof(WildlifeItem))]
[Token(Token = "0x2000574")]
public class WildlifeItemInteraction : SimpleInteraction
{
	[Token(Token = "0x4003230")]
	[FieldOffset(Offset = "0x48")]
	private BaseAi m_BaseAi;

	[Token(Token = "0x4003231")]
	[FieldOffset(Offset = "0x50")]
	private WildlifeItem m_WildlifeItem;

	[Token(Token = "0x4003232")]
	[FieldOffset(Offset = "0x58")]
	private BodyHarvest m_BodyHarvest;

	[Token(Token = "0x170002BD")]
	public override bool CanInteract
	{
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x8F7150", Offset = "0x8F5F50", Length = "0x62")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x8F71C0", Offset = "0x8F5FC0", Length = "0x189")]
	private void Awake()
	{
	}

	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x8F7350", Offset = "0x8F6150", Length = "0x168")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x8F74C0", Offset = "0x8F62C0", Length = "0xCC")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	public WildlifeItemInteraction()
	{
	}
}
