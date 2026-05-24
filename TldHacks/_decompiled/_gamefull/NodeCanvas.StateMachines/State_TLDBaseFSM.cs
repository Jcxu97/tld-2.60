using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010C0")]
public class State_TLDBaseFSM : NestedFSMState, ITaskAssignable, ITLDConcurrentGraphOwner, ITLDCustomManagedObjectOwner, ITLDChildGraphOwner
{
	[Token(Token = "0x4008641")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<GameObject> childFsmPrefab;

	[Token(Token = "0x4008642")]
	[FieldOffset(Offset = "0xA8")]
	private List<string> m_ConcurrentGraphs;

	[Token(Token = "0x4008643")]
	[FieldOffset(Offset = "0xB0")]
	private List<string> m_CustomManagedObjects;

	[SerializeField]
	[Token(Token = "0x4008644")]
	[FieldOffset(Offset = "0xB8")]
	private ActionList _actionList;

	[SerializeField]
	[Token(Token = "0x4008645")]
	[FieldOffset(Offset = "0xC0")]
	private bool _repeatStateActions;

	[Token(Token = "0x4008646")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject childGraphObject;

	[Token(Token = "0x4008647")]
	[FieldOffset(Offset = "0xD0")]
	private FSMHierarchy.Rank m_NestedFSMRank;

	[Token(Token = "0x4008648")]
	[FieldOffset(Offset = "0xD4")]
	private bool initialized;

	[Token(Token = "0x4008649")]
	[FieldOffset(Offset = "0xD5")]
	private bool inState;

	[Token(Token = "0x1700083C")]
	public Task task
	{
		[Token(Token = "0x6007188")]
		[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007189")]
		[Address(RVA = "0x10D3E00", Offset = "0x10D2C00", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x1700083D")]
	public ActionList actionList
	{
		[Token(Token = "0x600718A")]
		[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600718B")]
		[Address(RVA = "0x633890", Offset = "0x632690", Length = "0x115")]
		set
		{
		}
	}

	[Token(Token = "0x1700083E")]
	public GameObject childGraphPrefab
	{
		[Token(Token = "0x600718C")]
		[Address(RVA = "0x10D3ED0", Offset = "0x10D2CD0", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600718D")]
		[Address(RVA = "0x10D3F20", Offset = "0x10D2D20", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x1700083F")]
	public bool repeatStateActions
	{
		[Token(Token = "0x600718E")]
		[Address(RVA = "0x6BCD20", Offset = "0x6BBB20", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600718F")]
		[Address(RVA = "0x10D3F80", Offset = "0x10D2D80", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x6007190")]
	[Address(RVA = "0x10D3F90", Offset = "0x10D2D90", Length = "0x2A9")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6007191")]
	[Address(RVA = "0x10D4240", Offset = "0x10D3040", Length = "0x11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6007192")]
	[Address(RVA = "0x10D4260", Offset = "0x10D3060", Length = "0x8E6")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x6007193")]
	[Address(RVA = "0x10D4B50", Offset = "0x10D3950", Length = "0x107")]
	public GraphOwner GetChildGraphOwner()
	{
		return null;
	}

	[Token(Token = "0x6007194")]
	[Address(RVA = "0x10D4C60", Offset = "0x10D3A60", Length = "0x134")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007195")]
	[Address(RVA = "0x10D4DA0", Offset = "0x10D3BA0", Length = "0xF7")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007196")]
	[Address(RVA = "0x10D4EA0", Offset = "0x10D3CA0", Length = "0x19")]
	protected void OnChildGraphComplete(bool success)
	{
	}

	[Token(Token = "0x6007197")]
	[Address(RVA = "0x10D4EC0", Offset = "0x10D3CC0", Length = "0x765")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x6007198")]
	[Address(RVA = "0x10D5630", Offset = "0x10D4430", Length = "0x330")]
	private void RegisterAsSubFSMOwner(Graph _graph)
	{
	}

	[Token(Token = "0x6007199")]
	[Address(RVA = "0x10D5970", Offset = "0x10D4770", Length = "0x246")]
	private void RemoveSubFSMOwnerVar(Graph _graph)
	{
	}

	[Token(Token = "0x600719A")]
	[Address(RVA = "0x10D5BC0", Offset = "0x10D49C0", Length = "0x1B6")]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[Token(Token = "0x600719B")]
	[Address(RVA = "0x10D5D80", Offset = "0x10D4B80", Length = "0x165")]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[Token(Token = "0x600719C")]
	[Address(RVA = "0x10D5EF0", Offset = "0x10D4CF0", Length = "0x129")]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[Token(Token = "0x600719D")]
	[Address(RVA = "0x10D6020", Offset = "0x10D4E20", Length = "0x9B")]
	public void RemoveCustomManagedObject(string name)
	{
	}

	[Token(Token = "0x600719E")]
	[Address(RVA = "0x10D60C0", Offset = "0x10D4EC0", Length = "0x7")]
	public State_TLDBaseFSM()
	{
	}
}
