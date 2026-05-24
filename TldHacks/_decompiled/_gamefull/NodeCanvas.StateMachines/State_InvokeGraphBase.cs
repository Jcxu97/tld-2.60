using Cpp2ILInjected;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010C5")]
public abstract class State_InvokeGraphBase : FSMState
{
	[Token(Token = "0x400865B")]
	[FieldOffset(Offset = "0x88")]
	public Graph m_GraphAsset;

	[Token(Token = "0x400865C")]
	[FieldOffset(Offset = "0x90")]
	protected GraphOwner m_ChildGraphOwner;

	[Token(Token = "0x400865D")]
	[FieldOffset(Offset = "0x98")]
	protected bool m_JustStarted;

	[Token(Token = "0x60071C5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60071C6")]
	[Address(RVA = "0x10D7F60", Offset = "0x10D6D60", Length = "0x1A8")]
	public void SetCompletionFlag(string tag, bool state)
	{
	}

	[Token(Token = "0x60071C7")]
	protected abstract void ConfigureInitialBlackboard(Blackboard bb);

	[Token(Token = "0x60071C8")]
	[Address(RVA = "0x10D8110", Offset = "0x10D6F10", Length = "0x3D4")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x60071C9")]
	[Address(RVA = "0x10D8600", Offset = "0x10D7400", Length = "0x171")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60071CA")]
	[Address(RVA = "0x10D8780", Offset = "0x10D7580", Length = "0xA3")]
	protected override void OnExit()
	{
	}

	[Token(Token = "0x60071CB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x60071CC")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	protected State_InvokeGraphBase()
	{
	}
}
