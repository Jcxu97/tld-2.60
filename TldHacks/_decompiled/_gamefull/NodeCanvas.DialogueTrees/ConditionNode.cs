using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Icon("Condition", false, null)]
[Name("Task Condition", 0)]
[Category("Branch")]
[Description("Execute the first child node if a Condition is true, or the second one if that Condition is false. The Actor selected is used for the Condition check")]
[Color("b3ff7f")]
[Token(Token = "0x20010FB")]
public class ConditionNode : DTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x40086FA")]
	[FieldOffset(Offset = "0x88")]
	private ConditionTask _condition;

	[Token(Token = "0x170008B9")]
	public ConditionTask condition
	{
		[Token(Token = "0x600732D")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600732E")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008BA")]
	public Task task
	{
		[Token(Token = "0x600732F")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007330")]
		[Address(RVA = "0x10E9100", Offset = "0x10E7F00", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x170008BB")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007331")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008BC")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x6007332")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007333")]
	[Address(RVA = "0x10E91D0", Offset = "0x10E7FD0", Length = "0x156")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007334")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public ConditionNode()
	{
	}
}
