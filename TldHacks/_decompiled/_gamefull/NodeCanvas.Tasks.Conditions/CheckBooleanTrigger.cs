using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Description("Check if a boolean variable is true and if so, it is immediately reset to false.")]
[Token(Token = "0x2001169")]
public class CheckBooleanTrigger : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x40087FB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> trigger;

	[Token(Token = "0x17000918")]
	protected override string info
	{
		[Token(Token = "0x60074C6")]
		[Address(RVA = "0x11037B0", Offset = "0x11025B0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074C7")]
	[Address(RVA = "0x1103840", Offset = "0x1102640", Length = "0x77")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074C8")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckBooleanTrigger()
	{
	}
}
