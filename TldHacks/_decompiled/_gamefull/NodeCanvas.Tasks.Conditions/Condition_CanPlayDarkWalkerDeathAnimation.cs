using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Name("Can Play DarkWalker Death Animation", 0)]
[Token(Token = "0x2001143")]
public class Condition_CanPlayDarkWalkerDeathAnimation : ConditionTask
{
	[Token(Token = "0x6007458")]
	[Address(RVA = "0x10FCA40", Offset = "0x10FB840", Length = "0x57")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007459")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CanPlayDarkWalkerDeathAnimation()
	{
	}
}
