using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Utility")]
[Description("Simply use to debug return true or false by inverting the condition if needed")]
[Token(Token = "0x200119C")]
public class DebugCondition : ConditionTask
{
	[Token(Token = "0x60075B6")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075B7")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public DebugCondition()
	{
	}
}
