using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Loading Screen")]
[Name("Hint Queue Full", 0)]
[Token(Token = "0x2001120")]
public class Condition_HintQueueFull : ConditionTask
{
	[Token(Token = "0x60073E7")]
	[Address(RVA = "0x10F5390", Offset = "0x10F4190", Length = "0xC5")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073E8")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HintQueueFull()
	{
	}
}
