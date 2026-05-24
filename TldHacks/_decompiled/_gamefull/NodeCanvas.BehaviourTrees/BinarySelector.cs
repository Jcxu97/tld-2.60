using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Composites")]
[Description("Quick way to execute the left, or the right child node based on a Condition Task evaluation.")]
[Icon("Condition", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x2001022")]
public class BinarySelector : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[Token(Token = "0x400849B")]
	[FieldOffset(Offset = "0x78")]
	public bool dynamic;

	[SerializeField]
	[Token(Token = "0x400849C")]
	[FieldOffset(Offset = "0x80")]
	private ConditionTask _condition;

	[Token(Token = "0x400849D")]
	[FieldOffset(Offset = "0x88")]
	private int succeedIndex;

	[Token(Token = "0x17000772")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6006D96")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000773")]
	public override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6006D97")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x17000774")]
	public override string name
	{
		[Token(Token = "0x6006D98")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000775")]
	public Task task
	{
		[Token(Token = "0x6006D99")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D9A")]
		[Address(RVA = "0x10AEEB0", Offset = "0x10ADCB0", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000776")]
	private ConditionTask condition
	{
		[Token(Token = "0x6006D9B")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D9C")]
		[Address(RVA = "0xB51E90", Offset = "0xB50C90", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x6006D9D")]
	[Address(RVA = "0x10AEF80", Offset = "0x10ADD80", Length = "0x175")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006D9E")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public BinarySelector()
	{
	}
}
