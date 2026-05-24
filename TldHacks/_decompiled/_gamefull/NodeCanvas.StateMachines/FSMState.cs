using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010D0")]
public abstract class FSMState : Node, IState
{
	[Token(Token = "0x20010D1")]
	public enum TransitionEvaluationMode
	{
		[Token(Token = "0x4008678")]
		CheckContinuously,
		[Token(Token = "0x4008679")]
		CheckAfterStateFinished,
		[Token(Token = "0x400867A")]
		CheckManually
	}

	[SerializeField]
	[Token(Token = "0x4008674")]
	[FieldOffset(Offset = "0x78")]
	private TransitionEvaluationMode _transitionEvaluation;

	[Token(Token = "0x4008675")]
	[FieldOffset(Offset = "0x7C")]
	private float _elapsedTime;

	[Token(Token = "0x4008676")]
	[FieldOffset(Offset = "0x80")]
	private bool _hasInit;

	[Token(Token = "0x1700085F")]
	public override bool allowAsPrime
	{
		[Token(Token = "0x6007214")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000860")]
	public override int maxInConnections
	{
		[Token(Token = "0x6007215")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000861")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007216")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000862")]
	public sealed override Type outConnectionType
	{
		[Token(Token = "0x6007217")]
		[Address(RVA = "0x10DC7D0", Offset = "0x10DB5D0", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000863")]
	public sealed override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6007218")]
		[Address(RVA = "0x7D84A0", Offset = "0x7D72A0", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x17000864")]
	public sealed override Alignment2x2 iconAlignment
	{
		[Token(Token = "0x6007219")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x17000865")]
	public TransitionEvaluationMode transitionEvaluation
	{
		[Token(Token = "0x600721A")]
		[Address(RVA = "0x657EE0", Offset = "0x656CE0", Length = "0x4")]
		get
		{
			return default(TransitionEvaluationMode);
		}
		[Token(Token = "0x600721B")]
		[Address(RVA = "0x99B0A0", Offset = "0x999EA0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000866")]
	public float elapsedTime
	{
		[Token(Token = "0x600721C")]
		[Address(RVA = "0x502720", Offset = "0x501520", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600721D")]
		[Address(RVA = "0x10DC850", Offset = "0x10DB650", Length = "0x6")]
		private set
		{
		}
	}

	[Token(Token = "0x17000867")]
	public FSM FSM
	{
		[Token(Token = "0x600721E")]
		[Address(RVA = "0x10DC860", Offset = "0x10DB660", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600721F")]
	[Address(RVA = "0x10DC8D0", Offset = "0x10DB6D0", Length = "0xD3")]
	public FSMConnection[] GetTransitions()
	{
		return null;
	}

	[Token(Token = "0x6007220")]
	[Address(RVA = "0x10DC9B0", Offset = "0x10DB7B0", Length = "0x1A")]
	public void Finish()
	{
	}

	[Token(Token = "0x6007221")]
	[Address(RVA = "0x10D4EA0", Offset = "0x10D3CA0", Length = "0x19")]
	public void Finish(bool inSuccess)
	{
	}

	[Token(Token = "0x6007222")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6007223")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnGraphStoped()
	{
	}

	[Token(Token = "0x6007224")]
	[Address(RVA = "0x10DC9D0", Offset = "0x10DB7D0", Length = "0x18")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6007225")]
	[Address(RVA = "0x10DC9F0", Offset = "0x10DB7F0", Length = "0x1AB")]
	protected override bool CanConnectFromSource(Node sourceNode)
	{
		return false;
	}

	[Token(Token = "0x6007226")]
	[Address(RVA = "0x10DCBA0", Offset = "0x10DB9A0", Length = "0x1AB")]
	protected override bool CanConnectToTarget(Node targetNode)
	{
		return false;
	}

	[Token(Token = "0x6007227")]
	[Address(RVA = "0x10DCD50", Offset = "0x10DBB50", Length = "0x209")]
	protected sealed override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007228")]
	[Address(RVA = "0x10DCF60", Offset = "0x10DBD60", Length = "0x98")]
	public void Update()
	{
	}

	[Token(Token = "0x6007229")]
	[Address(RVA = "0x10DD000", Offset = "0x10DBE00", Length = "0x1F8")]
	public bool CheckTransitions()
	{
		return false;
	}

	[Token(Token = "0x600722A")]
	[Address(RVA = "0x10DD200", Offset = "0x10DC000", Length = "0x1A1")]
	protected sealed override void OnReset()
	{
	}

	[Token(Token = "0x600722B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x600722C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnEnter()
	{
	}

	[Token(Token = "0x600722D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x600722E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnExit()
	{
	}

	[Token(Token = "0x600722F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnPause()
	{
	}

	[Token(Token = "0x6007230")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	protected FSMState()
	{
	}
}
