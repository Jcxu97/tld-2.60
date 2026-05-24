using Cpp2ILInjected;

namespace TLD.AI;

[Token(Token = "0x20014F1")]
public class AiBearChallengeHunted : AiBear
{
	[Token(Token = "0x6008441")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected override bool WillOnlyTargetPlayer()
	{
		return false;
	}

	[Token(Token = "0x6008442")]
	[Address(RVA = "0x125B0C0", Offset = "0x1259EC0", Length = "0x86")]
	public override bool ShouldAlwaysStalkPlayer()
	{
		return false;
	}

	[Token(Token = "0x6008443")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool UseFixedStalkingSpeed()
	{
		return false;
	}

	[Token(Token = "0x6008444")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool CanDieFromBleedingOut()
	{
		return false;
	}

	[Token(Token = "0x6008445")]
	[Address(RVA = "0x125B070", Offset = "0x1259E70", Length = "0x4E")]
	public AiBearChallengeHunted()
	{
	}
}
