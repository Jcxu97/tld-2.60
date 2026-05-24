using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[GraphInfo(packageName = "NodeCanvas", docsURL = "http://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "http://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "http://nodecanvas.paradoxnotion.com/forums-page/")]
[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/FSM Asset")]
[Token(Token = "0x20010C9")]
public class FSM : Graph
{
	[Token(Token = "0x4008660")]
	[FieldOffset(Offset = "0x90")]
	private bool hasInitialized;

	[Token(Token = "0x4008661")]
	[FieldOffset(Offset = "0x98")]
	private List<IUpdatable> updatableNodes;

	[Token(Token = "0x4008662")]
	[FieldOffset(Offset = "0xA0")]
	private List<AnyState> anyStates;

	[Token(Token = "0x4008663")]
	[FieldOffset(Offset = "0xA8")]
	private List<ConcurrentState> concurentStates;

	[Token(Token = "0x4008664")]
	[FieldOffset(Offset = "0xB0")]
	private List<ConcurrentSuperState> concurentSuperStates;

	[Token(Token = "0x1700084B")]
	[field: Token(Token = "0x4008669")]
	[field: FieldOffset(Offset = "0xD8")]
	public FSMState currentState
	{
		[Token(Token = "0x60071DD")]
		[Address(RVA = "0x502650", Offset = "0x501450", Length = "0x8")]
		get;
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0x10D9480", Offset = "0x10D8280", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700084C")]
	[field: Token(Token = "0x400866A")]
	[field: FieldOffset(Offset = "0xE0")]
	public FSMState previousState
	{
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0x502660", Offset = "0x501460", Length = "0x8")]
		get;
		[Token(Token = "0x60071E0")]
		[Address(RVA = "0x926B10", Offset = "0x925910", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700084D")]
	public string currentStateName
	{
		[Token(Token = "0x60071E1")]
		[Address(RVA = "0x10D94E0", Offset = "0x10D82E0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084E")]
	public string previousStateName
	{
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0x10D9510", Offset = "0x10D8310", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084F")]
	public override Type baseNodeType
	{
		[Token(Token = "0x60071E3")]
		[Address(RVA = "0x10D9540", Offset = "0x10D8340", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000850")]
	public override bool requiresAgent
	{
		[Token(Token = "0x60071E4")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000851")]
	public override bool requiresPrimeNode
	{
		[Token(Token = "0x60071E5")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000852")]
	public override bool isTree
	{
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000853")]
	public override bool useLocalBlackboard
	{
		[Token(Token = "0x60071E7")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000854")]
	public sealed override bool canAcceptVariableDrops
	{
		[Token(Token = "0x60071E8")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1400002F")]
	public event Action<IState> onStateEnter
	{
		[CompilerGenerated]
		[Token(Token = "0x60071D5")]
		[Address(RVA = "0x10D8900", Offset = "0x10D7700", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60071D6")]
		[Address(RVA = "0x10D8A70", Offset = "0x10D7870", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000030")]
	public event Action<IState> onStateUpdate
	{
		[CompilerGenerated]
		[Token(Token = "0x60071D7")]
		[Address(RVA = "0x10D8BE0", Offset = "0x10D79E0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60071D8")]
		[Address(RVA = "0x10D8D50", Offset = "0x10D7B50", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000031")]
	public event Action<IState> onStateExit
	{
		[CompilerGenerated]
		[Token(Token = "0x60071D9")]
		[Address(RVA = "0x10D8EC0", Offset = "0x10D7CC0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0x10D9030", Offset = "0x10D7E30", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000032")]
	public event Action<IState> onStateTransition
	{
		[CompilerGenerated]
		[Token(Token = "0x60071DB")]
		[Address(RVA = "0x10D91A0", Offset = "0x10D7FA0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60071DC")]
		[Address(RVA = "0x10D9310", Offset = "0x10D8110", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x60071E9")]
	[Address(RVA = "0x10D95C0", Offset = "0x10D83C0", Length = "0xB2A")]
	protected override void OnGraphStarted()
	{
	}

	[Token(Token = "0x60071EA")]
	[Address(RVA = "0x10DA0F0", Offset = "0x10D8EF0", Length = "0x9A")]
	protected override void OnGraphUnpaused()
	{
	}

	[Token(Token = "0x60071EB")]
	[Address(RVA = "0x10DA190", Offset = "0x10D8F90", Length = "0x2B5")]
	protected override void OnGraphUpdate()
	{
	}

	[Token(Token = "0x60071EC")]
	[Address(RVA = "0x10DA450", Offset = "0x10D9250", Length = "0x119")]
	protected override void OnGraphStoped()
	{
	}

	[Token(Token = "0x60071ED")]
	[Address(RVA = "0x10DA570", Offset = "0x10D9370", Length = "0xBA")]
	protected override void OnGraphPaused()
	{
	}

	[Token(Token = "0x60071EE")]
	[Address(RVA = "0x10DA630", Offset = "0x10D9430", Length = "0x1F2")]
	public bool EnterState(FSMState newState)
	{
		return false;
	}

	[Token(Token = "0x60071EF")]
	[Address(RVA = "0x10DA830", Offset = "0x10D9630", Length = "0x2BC")]
	public FSMState TriggerState(string stateName)
	{
		return null;
	}

	[Token(Token = "0x60071F0")]
	[Address(RVA = "0x10DAAF0", Offset = "0x10D98F0", Length = "0x349")]
	public string[] GetStateNames()
	{
		return null;
	}

	[Token(Token = "0x60071F1")]
	[Address(RVA = "0x10DAE40", Offset = "0x10D9C40", Length = "0x180")]
	public FSMState GetStateWithName(string name)
	{
		return null;
	}

	[Token(Token = "0x60071F2")]
	[Address(RVA = "0x10DAFD0", Offset = "0x10D9DD0", Length = "0x6C6")]
	private void GatherDelegates()
	{
	}

	[Token(Token = "0x60071F3")]
	[Address(RVA = "0x10DB6A0", Offset = "0x10DA4A0", Length = "0x4E")]
	public FSM()
	{
	}
}
