using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if player is in struggle")]
[Name("IsPlayerInStruggle", 0)]
[Token(Token = "0x2001136")]
public class Condition_IsPlayerInStrugglee : ConditionTask
{
	[Token(Token = "0x600742C")]
	[Address(RVA = "0x10FA230", Offset = "0x10F9030", Length = "0x57")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600742D")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsPlayerInStrugglee()
	{
	}
}
