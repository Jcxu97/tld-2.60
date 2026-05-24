using Cpp2ILInjected;

namespace TLD.AI;

[Token(Token = "0x20014F0")]
public class AiBear : BaseAi
{
	[Token(Token = "0x6008437")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsImposter()
	{
		return false;
	}

	[Token(Token = "0x6008438")]
	[Address(RVA = "0x125AA90", Offset = "0x1259890", Length = "0x36A")]
	public override void MaybeFleeOrAttackFromProjectileHit(WeaponSource weapon)
	{
	}

	[Token(Token = "0x6008439")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public virtual bool ShouldAlwaysStalkPlayer()
	{
		return false;
	}

	[Token(Token = "0x600843A")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool UseFixedStalkingSpeed()
	{
		return false;
	}

	[Token(Token = "0x600843B")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool CanDieFromBleedingOut()
	{
		return false;
	}

	[Token(Token = "0x600843C")]
	[Address(RVA = "0x125AE00", Offset = "0x1259C00", Length = "0x82")]
	public override void ApplyBloodLossEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x600843D")]
	[Address(RVA = "0x125AE90", Offset = "0x1259C90", Length = "0xDB")]
	public override void ApplyRiskOfInfectionEvent()
	{
	}

	[Token(Token = "0x600843E")]
	[Address(RVA = "0x125AF70", Offset = "0x1259D70", Length = "0x78")]
	public override void ApplySprainedAnkleEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x600843F")]
	[Address(RVA = "0x125AFF0", Offset = "0x1259DF0", Length = "0x78")]
	public override void ApplySprainedWristEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6008440")]
	[Address(RVA = "0x125B070", Offset = "0x1259E70", Length = "0x4E")]
	public AiBear()
	{
	}
}
