using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Name("Concurrent", 0)]
[Description("Execute a number of Actions with optional conditional requirement and in parallel to any other state, as soon as the FSM is started.\nAll actions will prematurely be stoped as soon as the FSM stops as well.\nThis is not a state per-se and thus can have neither incomming, nor outgoing transitions.")]
[Color("ff64cb")]
[Token(Token = "0x20010D4")]
public class ConcurrentState : FSMState, IUpdatable, ISubTasksContainer
{
	[SerializeField]
	[Token(Token = "0x400867E")]
	[FieldOffset(Offset = "0x88")]
	private ConditionList _conditionList;

	[SerializeField]
	[Token(Token = "0x400867F")]
	[FieldOffset(Offset = "0x90")]
	private ActionList _actionList;

	[SerializeField]
	[Token(Token = "0x4008680")]
	[FieldOffset(Offset = "0x98")]
	private bool _repeatStateActions;

	[Token(Token = "0x4008681")]
	[FieldOffset(Offset = "0x99")]
	private bool accessed;

	[Token(Token = "0x1700086F")]
	public ConditionList conditionList
	{
		[Token(Token = "0x6007243")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007244")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000870")]
	public ActionList actionList
	{
		[Token(Token = "0x6007245")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007246")]
		[Address(RVA = "0x40DA10", Offset = "0x40C810", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000871")]
	public bool repeatStateActions
	{
		[Token(Token = "0x6007248")]
		[Address(RVA = "0x5023A0", Offset = "0x5011A0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6007249")]
		[Address(RVA = "0x5023B0", Offset = "0x5011B0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000872")]
	public override string name
	{
		[Token(Token = "0x600724A")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000873")]
	public override int maxInConnections
	{
		[Token(Token = "0x600724B")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000874")]
	public override int maxOutConnections
	{
		[Token(Token = "0x600724C")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000875")]
	public override bool allowAsPrime
	{
		[Token(Token = "0x600724D")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007247")]
	[Address(RVA = "0x10DDA20", Offset = "0x10DC820", Length = "0xE1")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x600724E")]
	[Address(RVA = "0x10DDB10", Offset = "0x10DC910", Length = "0x2CC")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x600724F")]
	[Address(RVA = "0x10DDDE0", Offset = "0x10DCBE0", Length = "0x125")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6007250")]
	[Address(RVA = "0x10DDF10", Offset = "0x10DCD10", Length = "0xD0")]
	public new void Update()
	{
	}

	[Token(Token = "0x6007251")]
	[Address(RVA = "0x10DDFF0", Offset = "0x10DCDF0", Length = "0x4C")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x6007252")]
	[Address(RVA = "0x10DE040", Offset = "0x10DCE40", Length = "0x20")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007253")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public ConcurrentState()
	{
	}
}
