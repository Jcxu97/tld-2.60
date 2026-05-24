using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Name("Dialogue SubDT", 0)]
[Category("TLD States")]
[Description("Run a dialogue tree that is associated with the specified actor.")]
[Token(Token = "0x20010C3")]
public class State_DialogueSubDT : FSMState, ITaskAssignable, ITLDChildGraphOwner
{
	[Token(Token = "0x400864F")]
	[FieldOffset(Offset = "0x88")]
	public string actorName;

	[Token(Token = "0x4008650")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<GameObject> childDialogueTreePrefab;

	[Token(Token = "0x4008651")]
	[FieldOffset(Offset = "0x98")]
	public bool groundPlayerOnEnd;

	[SerializeField]
	[Token(Token = "0x4008652")]
	[FieldOffset(Offset = "0xA0")]
	private ActionList _actionList;

	[SerializeField]
	[Token(Token = "0x4008653")]
	[FieldOffset(Offset = "0xA8")]
	private bool _repeatStateActions;

	[Token(Token = "0x4008654")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject childGraphObject;

	[Token(Token = "0x4008655")]
	[FieldOffset(Offset = "0xB8")]
	private Graph childGraph;

	[Token(Token = "0x4008656")]
	[FieldOffset(Offset = "0xC0")]
	private DialogueTreeController dialogTreeController;

	[Token(Token = "0x4008657")]
	[FieldOffset(Offset = "0xC8")]
	private DialogueModeRigFP m_DialogueModeRigFP;

	[Token(Token = "0x4008658")]
	[FieldOffset(Offset = "0xD0")]
	private int m_RetryOnEnterCounter;

	[Token(Token = "0x4008659")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_DoRetryOnEnter;

	[Token(Token = "0x17000847")]
	public Task task
	{
		[Token(Token = "0x60071B3")]
		[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071B4")]
		[Address(RVA = "0x10D6A30", Offset = "0x10D5830", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000848")]
	public ActionList actionList
	{
		[Token(Token = "0x60071B5")]
		[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071B6")]
		[Address(RVA = "0x40DAC0", Offset = "0x40C8C0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000849")]
	public bool repeatStateActions
	{
		[Token(Token = "0x60071B7")]
		[Address(RVA = "0x835870", Offset = "0x834670", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60071B8")]
		[Address(RVA = "0x99BB70", Offset = "0x99A970", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700084A")]
	public GameObject childGraphPrefab
	{
		[Token(Token = "0x60071B9")]
		[Address(RVA = "0x10D6B00", Offset = "0x10D5900", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071BA")]
		[Address(RVA = "0x10D6B50", Offset = "0x10D5950", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x60071BB")]
	[Address(RVA = "0x10D6BB0", Offset = "0x10D59B0", Length = "0x172")]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x60071BC")]
	[Address(RVA = "0x10D6D30", Offset = "0x10D5B30", Length = "0x5B1")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x60071BD")]
	[Address(RVA = "0x10D72F0", Offset = "0x10D60F0", Length = "0x21C")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60071BE")]
	[Address(RVA = "0x10D7510", Offset = "0x10D6310", Length = "0x20")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x60071BF")]
	[Address(RVA = "0x10D7540", Offset = "0x10D6340", Length = "0x2C1")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x60071C0")]
	[Address(RVA = "0x10D7810", Offset = "0x10D6610", Length = "0x2A7")]
	private void StartDialogueTree()
	{
	}

	[Token(Token = "0x60071C1")]
	[Address(RVA = "0x10D7AC0", Offset = "0x10D68C0", Length = "0x297")]
	private DialogueModeRigFP GetDialogModeRigFPOnActor(string name)
	{
		return null;
	}

	[Token(Token = "0x60071C2")]
	[Address(RVA = "0x10D7D60", Offset = "0x10D6B60", Length = "0x12B")]
	public State_DialogueSubDT()
	{
	}
}
