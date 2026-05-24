using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Conditional", 0)]
[Category("Decorators")]
[Description("Execute and return the child node status if the condition is true, otherwise return Failure. The condition is evaluated only once in the first Tick and when the node is not already Running unless it is set as 'Dynamic' in which case it will revaluate even while running")]
[Icon("Accessor", false, null)]
[Token(Token = "0x200102E")]
public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[Token(Token = "0x40084C3")]
	[FieldOffset(Offset = "0x78")]
	public bool isDynamic;

	[SerializeField]
	[Token(Token = "0x40084C4")]
	[FieldOffset(Offset = "0x80")]
	private ConditionTask _condition;

	[Token(Token = "0x40084C5")]
	[FieldOffset(Offset = "0x88")]
	private bool accessed;

	[Token(Token = "0x17000777")]
	public Task task
	{
		[Token(Token = "0x6006DC6")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x10B1A00", Offset = "0x10B0800", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000778")]
	private ConditionTask condition
	{
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DC9")]
		[Address(RVA = "0xB51E90", Offset = "0xB50C90", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x6006DCA")]
	[Address(RVA = "0x10B1AD0", Offset = "0x10B08D0", Length = "0x159")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DCB")]
	[Address(RVA = "0x10B1C30", Offset = "0x10B0A30", Length = "0x8")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DCC")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public ConditionalEvaluator()
	{
	}
}
