using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Check Panel Requirements", 0)]
[Description("returns true if the panel specified can be shown")]
[Category("TLD Conditions/Player/Interface")]
[Token(Token = "0x2001244")]
public class Condition_CheckPanelRequirements : ConditionTask
{
	[Token(Token = "0x4008A75")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Action_ShowPanel.Panel> panel;

	[Token(Token = "0x600779A")]
	[Address(RVA = "0x115F350", Offset = "0x115E150", Length = "0x1A0")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600779B")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckPanelRequirements()
	{
	}
}
