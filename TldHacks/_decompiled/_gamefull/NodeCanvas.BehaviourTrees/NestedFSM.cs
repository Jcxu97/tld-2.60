using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("FSM", 0)]
[Category("Nested")]
[Description("NestedFSM can be assigned an entire FSM. This node will return Running for as long as the FSM is Running. If a Success or Failure State is selected, then it will return Success or Failure as soon as the Nested FSM enters that state at which point the FSM will also be stoped. If the Nested FSM ends otherwise, this node will return Success.")]
[Icon("FSM", false, null)]
[Token(Token = "0x2001047")]
public class NestedFSM : BTNode, IGraphAssignable
{
	[SerializeField]
	[Token(Token = "0x400850C")]
	[FieldOffset(Offset = "0x78")]
	private BBParameter<FSM> _nestedFSM;

	[Token(Token = "0x400850D")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<FSM, FSM> instances;

	[Token(Token = "0x400850E")]
	[FieldOffset(Offset = "0x88")]
	private FSM currentInstance;

	[Token(Token = "0x400850F")]
	[FieldOffset(Offset = "0x90")]
	public string successState;

	[Token(Token = "0x4008510")]
	[FieldOffset(Offset = "0x98")]
	public string failureState;

	[Token(Token = "0x17000788")]
	public override string name
	{
		[Token(Token = "0x6006E14")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000789")]
	public FSM nestedFSM
	{
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0x10B3F00", Offset = "0x10B2D00", Length = "0x49")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0x10B3F50", Offset = "0x10B2D50", Length = "0x58")]
		set
		{
		}
	}

	[Token(Token = "0x1700078A")]
	Graph IGraphAssignable.nestedGraph
	{
		[Token(Token = "0x6006E17")]
		[Address(RVA = "0x10B3F00", Offset = "0x10B2D00", Length = "0x49")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E18")]
		[Address(RVA = "0x10B3FB0", Offset = "0x10B2DB0", Length = "0xAE")]
		set
		{
		}
	}

	[Token(Token = "0x6006E19")]
	[Address(RVA = "0x10B4060", Offset = "0x10B2E60", Length = "0xE2")]
	Graph[] IGraphAssignable.GetInstances()
	{
		return null;
	}

	[Token(Token = "0x6006E1A")]
	[Address(RVA = "0x10B4150", Offset = "0x10B2F50", Length = "0x3C7")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E1B")]
	[Address(RVA = "0x10B4520", Offset = "0x10B3320", Length = "0xD")]
	private void OnFSMFinish(bool success)
	{
	}

	[Token(Token = "0x6006E1C")]
	[Address(RVA = "0x10B4530", Offset = "0x10B3330", Length = "0xE8")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006E1D")]
	[Address(RVA = "0x10B4620", Offset = "0x10B3420", Length = "0xE5")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6006E1E")]
	[Address(RVA = "0x10B4710", Offset = "0x10B3510", Length = "0xE8")]
	public override void OnGraphStoped()
	{
	}

	[Token(Token = "0x6006E1F")]
	[Address(RVA = "0x10B4800", Offset = "0x10B3600", Length = "0x354")]
	private FSM CheckInstance()
	{
		return null;
	}

	[Token(Token = "0x6006E20")]
	[Address(RVA = "0x10B4B60", Offset = "0x10B3960", Length = "0xC5")]
	public NestedFSM()
	{
	}
}
