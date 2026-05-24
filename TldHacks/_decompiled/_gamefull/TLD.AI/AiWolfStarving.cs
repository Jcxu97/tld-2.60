using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x20014FD")]
public class AiWolfStarving : AiBaseWolf
{
	[Token(Token = "0x40097AF")]
	[FieldOffset(Offset = "0xA58")]
	public float m_BiteToxicityOnBloodLoss;

	[Token(Token = "0x60084A0")]
	[Address(RVA = "0x1264650", Offset = "0x1263450", Length = "0x112")]
	public override void ApplyBloodLossEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x60084A1")]
	[Address(RVA = "0x1264770", Offset = "0x1263570", Length = "0x15")]
	protected override bool MaybeHoldGroundChemicalHazardForAttack()
	{
		return false;
	}

	[Token(Token = "0x60084A2")]
	[Address(RVA = "0x1264790", Offset = "0x1263590", Length = "0x30")]
	protected override void ChooseNewBehaviorForInvestigate()
	{
	}

	[Token(Token = "0x60084A3")]
	[Address(RVA = "0x1264790", Offset = "0x1263590", Length = "0x30")]
	protected override void ChooseNewBehaviorForStalking()
	{
	}

	[Token(Token = "0x60084A4")]
	[Address(RVA = "0x12647C0", Offset = "0x12635C0", Length = "0xC2")]
	protected override void MaybeWanderAroundPointForAttack(Vector3 attackPos)
	{
	}

	[Token(Token = "0x60084A5")]
	[Address(RVA = "0x1264890", Offset = "0x1263690", Length = "0x187")]
	protected override void MaybeWanderAroundPointForStalking()
	{
	}

	[Token(Token = "0x60084A6")]
	[Address(RVA = "0x1264A20", Offset = "0x1263820", Length = "0x172")]
	private bool MaybeHoldGround()
	{
		return false;
	}

	[Token(Token = "0x60084A7")]
	[Address(RVA = "0x1264BA0", Offset = "0x12639A0", Length = "0x6C")]
	public AiWolfStarving()
	{
	}
}
