using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Loading Screen")]
[Name("Is Starting New Game", 0)]
[Token(Token = "0x2001121")]
public class Condition_IsStartingNewGame : ConditionTask
{
	[Token(Token = "0x60073E9")]
	[Address(RVA = "0x10F5460", Offset = "0x10F4260", Length = "0x125")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073EA")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsStartingNewGame()
	{
	}
}
