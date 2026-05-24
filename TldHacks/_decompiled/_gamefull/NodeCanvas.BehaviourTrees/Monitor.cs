using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Decorators")]
[Icon("Eye", false, null)]
[Description("Monitors the decorated child node for a returned Status and executes an Action when that is the case.\nThe final Status returned to the parent can either be the original Decorated Child Node Status, or the new Decorator Action Status.")]
[Token(Token = "0x2001039")]
public class Monitor : BTDecorator, ITaskAssignable<ActionTask>, ITaskAssignable
{
	[Token(Token = "0x200103A")]
	public enum MonitorMode
	{
		[Token(Token = "0x40084EF")]
		Failure = 0,
		[Token(Token = "0x40084F0")]
		Success = 1,
		[Token(Token = "0x40084F1")]
		AnyStatus = 10
	}

	[Token(Token = "0x200103B")]
	public enum ReturnStatusMode
	{
		[Token(Token = "0x40084F3")]
		OriginalDecoratedChildStatus,
		[Token(Token = "0x40084F4")]
		NewDecoratorActionStatus
	}

	[Name("Monitor", 0)]
	[Token(Token = "0x40084EA")]
	[FieldOffset(Offset = "0x78")]
	public MonitorMode monitorMode;

	[Name("Return", 0)]
	[Token(Token = "0x40084EB")]
	[FieldOffset(Offset = "0x7C")]
	public ReturnStatusMode returnMode;

	[Token(Token = "0x40084EC")]
	[FieldOffset(Offset = "0x80")]
	private Status decoratorActionStatus;

	[SerializeField]
	[Token(Token = "0x40084ED")]
	[FieldOffset(Offset = "0x88")]
	private ActionTask _action;

	[Token(Token = "0x1700077E")]
	public ActionTask action
	{
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DEB")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700077F")]
	public Task task
	{
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DED")]
		[Address(RVA = "0x10B3120", Offset = "0x10B1F20", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x6006DEE")]
	[Address(RVA = "0x10B31F0", Offset = "0x10B1FF0", Length = "0x114")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DEF")]
	[Address(RVA = "0x10B3310", Offset = "0x10B2110", Length = "0x37")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DF0")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Monitor()
	{
	}
}
