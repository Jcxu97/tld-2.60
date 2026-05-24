using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Description("It's best to use the respective Condition for a type if existant since they support operations as well")]
[Token(Token = "0x200116F")]
public class CheckVariable<T> : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008809")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> valueA;

	[Token(Token = "0x400880A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> valueB;

	[Token(Token = "0x1700091E")]
	protected override string info
	{
		[Token(Token = "0x60074D8")]
		[Address(RVA = "0x234AEF0", Offset = "0x2349CF0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074D9")]
	[Address(RVA = "0x234AF90", Offset = "0x2349D90", Length = "0x3E8")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074DA")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckVariable()
	{
	}
}
