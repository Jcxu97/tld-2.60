using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Name("BehaviourTree", 0)]
[Category("Nested")]
[Description("Execute a Behaviour Tree OnEnter. OnExit that Behavior Tree will be stoped or paused based on the relevant specified setting. You can optionaly specify a Success Event and a Failure Event which will be sent when the BT's root node status returns either of the two. If so, use alongside with a CheckEvent on a transition.")]
[Token(Token = "0x20010D5")]
public class NestedBTState : FSMState, IGraphAssignable
{
	[Token(Token = "0x20010D6")]
	public enum BTExecutionMode
	{
		[Token(Token = "0x400868A")]
		Once,
		[Token(Token = "0x400868B")]
		Repeat
	}

	[Token(Token = "0x20010D7")]
	public enum BTExitMode
	{
		[Token(Token = "0x400868D")]
		StopAndRestart,
		[Token(Token = "0x400868E")]
		PauseAndResume
	}

	[SerializeField]
	[Token(Token = "0x4008682")]
	[FieldOffset(Offset = "0x88")]
	private BBParameter<BehaviourTree> _nestedBT;

	[Token(Token = "0x4008683")]
	[FieldOffset(Offset = "0x90")]
	public BTExecutionMode executionMode;

	[Token(Token = "0x4008684")]
	[FieldOffset(Offset = "0x94")]
	public BTExitMode exitMode;

	[Token(Token = "0x4008685")]
	[FieldOffset(Offset = "0x98")]
	public string successEvent;

	[Token(Token = "0x4008686")]
	[FieldOffset(Offset = "0xA0")]
	public string failureEvent;

	[Token(Token = "0x4008687")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<BehaviourTree, BehaviourTree> instances;

	[Token(Token = "0x4008688")]
	[FieldOffset(Offset = "0xB0")]
	private BehaviourTree currentInstance;

	[Token(Token = "0x17000876")]
	public BehaviourTree nestedBT
	{
		[Token(Token = "0x6007254")]
		[Address(RVA = "0x10DE070", Offset = "0x10DCE70", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007255")]
		[Address(RVA = "0x10DE0C0", Offset = "0x10DCEC0", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x17000877")]
	Graph IGraphAssignable.nestedGraph
	{
		[Token(Token = "0x6007256")]
		[Address(RVA = "0x10DE070", Offset = "0x10DCE70", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007257")]
		[Address(RVA = "0x10DE120", Offset = "0x10DCF20", Length = "0xB1")]
		set
		{
		}
	}

	[Token(Token = "0x6007258")]
	[Address(RVA = "0x10DE1E0", Offset = "0x10DCFE0", Length = "0xE2")]
	Graph[] IGraphAssignable.GetInstances()
	{
		return null;
	}

	[Token(Token = "0x6007259")]
	[Address(RVA = "0x10DE2D0", Offset = "0x10DD0D0", Length = "0x25B")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x600725A")]
	[Address(RVA = "0x10DE530", Offset = "0x10DD330", Length = "0xA4")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600725B")]
	[Address(RVA = "0x10DE5E0", Offset = "0x10DD3E0", Length = "0xF8")]
	private void OnFinish(bool success)
	{
	}

	[Token(Token = "0x600725C")]
	[Address(RVA = "0x10DE6E0", Offset = "0x10DD4E0", Length = "0x10B")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x600725D")]
	[Address(RVA = "0x10DE7F0", Offset = "0x10DD5F0", Length = "0xEE")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x600725E")]
	[Address(RVA = "0x10DE8E0", Offset = "0x10DD6E0", Length = "0x363")]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[Token(Token = "0x600725F")]
	[Address(RVA = "0x10DEC50", Offset = "0x10DDA50", Length = "0xC5")]
	public NestedBTState()
	{
	}
}
