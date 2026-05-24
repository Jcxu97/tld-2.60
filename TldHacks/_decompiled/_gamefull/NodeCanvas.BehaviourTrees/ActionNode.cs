using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Action", 0)]
[Description("Executes an action and returns Success or Failure.\nReturns Running until the action is finished.")]
[Icon("Action", false, null)]
[Token(Token = "0x2001045")]
public class ActionNode : BTNode, ITaskAssignable<ActionTask>, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x400850A")]
	[FieldOffset(Offset = "0x78")]
	private ActionTask _action;

	[Token(Token = "0x17000782")]
	public Task task
	{
		[Token(Token = "0x6006E04")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E05")]
		[Address(RVA = "0x10B3CE0", Offset = "0x10B2AE0", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000783")]
	public ActionTask action
	{
		[Token(Token = "0x6006E06")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E07")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000784")]
	public override string name
	{
		[Token(Token = "0x6006E08")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E09")]
	[Address(RVA = "0x10B3DA0", Offset = "0x10B2BA0", Length = "0x25")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E0A")]
	[Address(RVA = "0x10B3DD0", Offset = "0x10B2BD0", Length = "0x17")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006E0B")]
	[Address(RVA = "0x10B3DF0", Offset = "0x10B2BF0", Length = "0x11")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6006E0C")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public ActionNode()
	{
	}
}
