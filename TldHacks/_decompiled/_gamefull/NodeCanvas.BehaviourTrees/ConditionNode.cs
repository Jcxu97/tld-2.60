using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Condition", 0)]
[Description("Check a condition and return Success or Failure")]
[Icon("Condition", false, null)]
[Token(Token = "0x2001046")]
public class ConditionNode : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x400850B")]
	[FieldOffset(Offset = "0x78")]
	private ConditionTask _condition;

	[Token(Token = "0x17000785")]
	public Task task
	{
		[Token(Token = "0x6006E0D")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x10B3E10", Offset = "0x10B2C10", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000786")]
	public ConditionTask condition
	{
		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E10")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000787")]
	public override string name
	{
		[Token(Token = "0x6006E11")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E12")]
	[Address(RVA = "0x10B3ED0", Offset = "0x10B2CD0", Length = "0x2D")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E13")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public ConditionNode()
	{
	}
}
