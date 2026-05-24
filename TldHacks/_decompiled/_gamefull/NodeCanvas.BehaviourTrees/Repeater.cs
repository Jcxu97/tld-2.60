using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Repeat", 0)]
[Category("Decorators")]
[Description("Repeat the child either x times or until it returns the specified status, or forever")]
[Icon("Repeat", false, null)]
[Token(Token = "0x200103F")]
public class Repeater : BTDecorator
{
	[Token(Token = "0x2001040")]
	public enum RepeaterMode
	{
		[Token(Token = "0x40084FF")]
		RepeatTimes,
		[Token(Token = "0x4008500")]
		RepeatUntil,
		[Token(Token = "0x4008501")]
		RepeatForever
	}

	[Token(Token = "0x2001041")]
	public enum RepeatUntilStatus
	{
		[Token(Token = "0x4008503")]
		Failure,
		[Token(Token = "0x4008504")]
		Success
	}

	[Token(Token = "0x40084FA")]
	[FieldOffset(Offset = "0x78")]
	public RepeaterMode repeaterMode;

	[ShowIf("repeaterMode", 0)]
	[Token(Token = "0x40084FB")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<int> repeatTimes;

	[ShowIf("repeaterMode", 1)]
	[Token(Token = "0x40084FC")]
	[FieldOffset(Offset = "0x88")]
	public RepeatUntilStatus repeatUntilStatus;

	[Token(Token = "0x40084FD")]
	[FieldOffset(Offset = "0x8C")]
	private int currentIteration;

	[Token(Token = "0x6006DF5")]
	[Address(RVA = "0x10B3520", Offset = "0x10B2320", Length = "0x1A0")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DF6")]
	[Address(RVA = "0x10B36D0", Offset = "0x10B24D0", Length = "0xB")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DF7")]
	[Address(RVA = "0x10B36E0", Offset = "0x10B24E0", Length = "0xA9")]
	public Repeater()
	{
	}
}
