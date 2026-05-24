using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Name("FSM", 0)]
[Category("Nested")]
[Description("Execute a nested FSM OnEnter and Stop that FSM OnExit. This state is Finished when the nested FSM is finished as well")]
[Token(Token = "0x20010D8")]
public class NestedFSMState : FSMState, IGraphAssignable
{
	[SerializeField]
	[Token(Token = "0x400868F")]
	[FieldOffset(Offset = "0x88")]
	protected BBParameter<FSM> _nestedFSM;

	[Token(Token = "0x4008690")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<FSM, FSM> instances;

	[Token(Token = "0x4008691")]
	[FieldOffset(Offset = "0x98")]
	protected FSM currentInstance;

	[Token(Token = "0x17000878")]
	public FSM nestedFSM
	{
		[Token(Token = "0x6007260")]
		[Address(RVA = "0x10DED20", Offset = "0x10DDB20", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007261")]
		[Address(RVA = "0x10DED70", Offset = "0x10DDB70", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x17000879")]
	Graph IGraphAssignable.nestedGraph
	{
		[Token(Token = "0x6007262")]
		[Address(RVA = "0x10DED20", Offset = "0x10DDB20", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007263")]
		[Address(RVA = "0x10DEDD0", Offset = "0x10DDBD0", Length = "0xB1")]
		set
		{
		}
	}

	[Token(Token = "0x6007264")]
	[Address(RVA = "0x10DEE90", Offset = "0x10DDC90", Length = "0xE2")]
	Graph[] IGraphAssignable.GetInstances()
	{
		return null;
	}

	[Token(Token = "0x6007265")]
	[Address(RVA = "0x10DEF80", Offset = "0x10DDD80", Length = "0x212")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6007266")]
	[Address(RVA = "0x10DF1A0", Offset = "0x10DDFA0", Length = "0xF7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007267")]
	[Address(RVA = "0x10DF2A0", Offset = "0x10DE0A0", Length = "0xFA")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x6007268")]
	[Address(RVA = "0x10DF3A0", Offset = "0x10DE1A0", Length = "0xE5")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007269")]
	[Address(RVA = "0x10DF490", Offset = "0x10DE290", Length = "0x3B0")]
	protected FSM CheckInstance()
	{
		return null;
	}

	[Token(Token = "0x600726A")]
	[Address(RVA = "0x10DF850", Offset = "0x10DE650", Length = "0xC5")]
	public NestedFSMState()
	{
	}
}
