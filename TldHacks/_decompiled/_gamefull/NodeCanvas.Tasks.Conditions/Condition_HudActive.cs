using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("Checks if any hud elements are active")]
[Name("Hud Active", 0)]
[Token(Token = "0x200114B")]
public class Condition_HudActive : ConditionTask
{
	[Token(Token = "0x600746D")]
	[Address(RVA = "0x10FE5D0", Offset = "0x10FD3D0", Length = "0x45")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600746E")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HudActive()
	{
	}
}
