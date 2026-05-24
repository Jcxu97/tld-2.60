using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if the player is asleep")]
[Name("Player Is Sleeping", 0)]
[Token(Token = "0x2001131")]
public class Condition_PlayerSleeping : ConditionTask
{
	[Token(Token = "0x600741B")]
	[Address(RVA = "0x10F9360", Offset = "0x10F8160", Length = "0x52")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600741C")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_PlayerSleeping()
	{
	}
}
