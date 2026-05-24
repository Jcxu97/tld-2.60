using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Is Carrying Body", 0)]
[Token(Token = "0x2001141")]
public class Condition_HasBodyCarry : ConditionTask
{
	[Token(Token = "0x6007452")]
	[Address(RVA = "0x10FC4B0", Offset = "0x10FB2B0", Length = "0x105")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007453")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HasBodyCarry()
	{
	}
}
