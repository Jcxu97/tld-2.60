using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Challenge Complete Screen Showing", 0)]
[Description("Bring up Panel_ChallengeComplete screen")]
[Category("TLD Conditions/Challenge")]
[Token(Token = "0x20011CB")]
public class Condition_HoursWithinRangeOfFire : ConditionTask
{
	[Token(Token = "0x6007639")]
	[Address(RVA = "0x11196B0", Offset = "0x11184B0", Length = "0x5B")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600763A")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HoursWithinRangeOfFire()
	{
	}
}
