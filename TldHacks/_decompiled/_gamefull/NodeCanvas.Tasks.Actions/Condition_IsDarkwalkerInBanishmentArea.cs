using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Is the invisible entity (darkwalker) within the banishment area", 0)]
[Description("Returns true if the darkwalker is inside the bounds, false otherwise")]
[Category("TLD Conditions/Challenge")]
[Token(Token = "0x20011CC")]
public class Condition_IsDarkwalkerInBanishmentArea : ConditionTask
{
	[Token(Token = "0x600763B")]
	[Address(RVA = "0x1119710", Offset = "0x1118510", Length = "0x20B")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600763C")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsDarkwalkerInBanishmentArea()
	{
	}
}
