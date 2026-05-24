using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Name("Action State", 0)]
[Description("Execute a number of Action Tasks OnEnter. All actions will be stoped OnExit. This state is Finished when all Actions are finished as well")]
[Token(Token = "0x20010D2")]
public class ActionState : FSMState, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x400867B")]
	[FieldOffset(Offset = "0x88")]
	private ActionList _actionList;

	[SerializeField]
	[Token(Token = "0x400867C")]
	[FieldOffset(Offset = "0x90")]
	private bool _repeatStateActions;

	[Token(Token = "0x17000868")]
	public Task task
	{
		[Token(Token = "0x6007231")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007232")]
		[Address(RVA = "0x10DD3B0", Offset = "0x10DC1B0", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000869")]
	public ActionList actionList
	{
		[Token(Token = "0x6007233")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007234")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700086A")]
	public bool repeatStateActions
	{
		[Token(Token = "0x6007235")]
		[Address(RVA = "0x89B490", Offset = "0x89A290", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6007236")]
		[Address(RVA = "0xC264C0", Offset = "0xC252C0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x6007237")]
	[Address(RVA = "0x10DD480", Offset = "0x10DC280", Length = "0x16F")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x6007238")]
	[Address(RVA = "0x10DD5F0", Offset = "0x10DC3F0", Length = "0x58")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6007239")]
	[Address(RVA = "0x10DD650", Offset = "0x10DC450", Length = "0x71")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600723A")]
	[Address(RVA = "0x10DD6D0", Offset = "0x10DC4D0", Length = "0x26")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x600723B")]
	[Address(RVA = "0x10DD700", Offset = "0x10DC500", Length = "0x20")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x600723C")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public ActionState()
	{
	}
}
