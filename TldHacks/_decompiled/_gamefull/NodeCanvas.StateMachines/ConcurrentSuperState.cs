using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Name("Concurrent Super State", 0)]
[Category("TLD States")]
[Description("A concurrent states that offers the Enter/Update/Exit functionality of a Super State.")]
[Token(Token = "0x20010C2")]
public class ConcurrentSuperState : FSMState, IUpdatable
{
	[SerializeField]
	[Token(Token = "0x400864C")]
	[FieldOffset(Offset = "0x88")]
	private ActionList _onEnterList;

	[SerializeField]
	[Token(Token = "0x400864D")]
	[FieldOffset(Offset = "0x90")]
	private ActionList _onUpdateList;

	[SerializeField]
	[Token(Token = "0x400864E")]
	[FieldOffset(Offset = "0x98")]
	private ActionList _onExitList;

	[Token(Token = "0x17000840")]
	public ActionList onEnterList
	{
		[Token(Token = "0x60071A1")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071A2")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000841")]
	public ActionList onUpdateList
	{
		[Token(Token = "0x60071A3")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071A4")]
		[Address(RVA = "0x40DA10", Offset = "0x40C810", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000842")]
	public ActionList onExitList
	{
		[Token(Token = "0x60071A5")]
		[Address(RVA = "0x4B3EA0", Offset = "0x4B2CA0", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071A6")]
		[Address(RVA = "0x760E50", Offset = "0x75FC50", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000843")]
	public override int maxInConnections
	{
		[Token(Token = "0x60071A8")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000844")]
	public override int maxOutConnections
	{
		[Token(Token = "0x60071A9")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000845")]
	public override bool allowAsPrime
	{
		[Token(Token = "0x60071AA")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000846")]
	public override string name
	{
		[Token(Token = "0x60071AB")]
		[Address(RVA = "0x10D6320", Offset = "0x10D5120", Length = "0x98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60071A7")]
	[Address(RVA = "0x10D61F0", Offset = "0x10D4FF0", Length = "0x129")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x60071AC")]
	[Address(RVA = "0x10D63C0", Offset = "0x10D51C0", Length = "0x470")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x60071AD")]
	[Address(RVA = "0x10D6840", Offset = "0x10D5640", Length = "0x1D")]
	public new void Update()
	{
	}

	[Token(Token = "0x60071AE")]
	[Address(RVA = "0x10D6860", Offset = "0x10D5660", Length = "0x57")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x60071AF")]
	[Address(RVA = "0x10D68C0", Offset = "0x10D56C0", Length = "0x97")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60071B0")]
	[Address(RVA = "0x10D6960", Offset = "0x10D5760", Length = "0x8A")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x60071B1")]
	[Address(RVA = "0x10D69F0", Offset = "0x10D57F0", Length = "0x39")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x60071B2")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public ConcurrentSuperState()
	{
	}
}
