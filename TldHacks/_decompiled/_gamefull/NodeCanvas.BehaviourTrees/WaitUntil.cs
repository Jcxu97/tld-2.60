using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Decorators")]
[Description("Returns Running until the assigned condition becomes true")]
[Icon("Halt", false, null)]
[Token(Token = "0x2001044")]
public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x4008508")]
	[FieldOffset(Offset = "0x78")]
	private ConditionTask _condition;

	[Token(Token = "0x4008509")]
	[FieldOffset(Offset = "0x80")]
	private bool accessed;

	[Token(Token = "0x17000780")]
	public Task task
	{
		[Token(Token = "0x6006DFD")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DFE")]
		[Address(RVA = "0x10B3AF0", Offset = "0x10B28F0", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000781")]
	private ConditionTask condition
	{
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E00")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x6006E01")]
	[Address(RVA = "0x10B3BB0", Offset = "0x10B29B0", Length = "0x112")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E02")]
	[Address(RVA = "0x10B3CD0", Offset = "0x10B2AD0", Length = "0x8")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006E03")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public WaitUntil()
	{
	}
}
