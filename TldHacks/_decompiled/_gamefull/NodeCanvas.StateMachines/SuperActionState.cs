using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Description("The Super Action State provides finer control on when to execute actions. This state is never Finished by it's own if there is any Actions in the OnUpdate list and thus OnFinish transitions will never be called in that case. OnExit Actions are only called for 1 frame when the state exits.")]
[Token(Token = "0x20010D9")]
public class SuperActionState : FSMState, ISubTasksContainer
{
	[SerializeField]
	[Token(Token = "0x4008692")]
	[FieldOffset(Offset = "0x88")]
	private ActionList _onEnterList;

	[SerializeField]
	[Token(Token = "0x4008693")]
	[FieldOffset(Offset = "0x90")]
	private ActionList _onUpdateList;

	[SerializeField]
	[Token(Token = "0x4008694")]
	[FieldOffset(Offset = "0x98")]
	private ActionList _onExitList;

	[Token(Token = "0x4008695")]
	[FieldOffset(Offset = "0xA0")]
	private bool enterListFinished;

	[Token(Token = "0x600726B")]
	[Address(RVA = "0x10DF920", Offset = "0x10DE720", Length = "0x129")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x600726C")]
	[Address(RVA = "0x10DFA50", Offset = "0x10DE850", Length = "0x470")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x600726D")]
	[Address(RVA = "0x10DFED0", Offset = "0x10DECD0", Length = "0x18")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x600726E")]
	[Address(RVA = "0x10DFEF0", Offset = "0x10DECF0", Length = "0xF1")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600726F")]
	[Address(RVA = "0x10DFFF0", Offset = "0x10DEDF0", Length = "0xAF")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x6007270")]
	[Address(RVA = "0x10D69F0", Offset = "0x10D57F0", Length = "0x39")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007271")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public SuperActionState()
	{
	}
}
