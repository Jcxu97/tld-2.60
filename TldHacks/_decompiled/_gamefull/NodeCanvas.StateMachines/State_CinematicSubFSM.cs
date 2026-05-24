using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.StateMachines;

[Name("Cinematic SubFSM", 0)]
[Category("TLD States")]
[Description("This is a TLD custom version of Nested FSM State. It can be assigned an entire FSM. This node will return Running for as long as the FSM is Running. If a Success or Failure State is selected, then it will return Success or Failure as soon as the Nested FSM enters that state at which point the FSM will also be stopped. If the Nested FSM ends otherwise, this node will return Success.")]
[Token(Token = "0x20010C1")]
public class State_CinematicSubFSM : NestedFSMState
{
	[Token(Token = "0x400864A")]
	[FieldOffset(Offset = "0xA0")]
	public string cinematicFile;

	[Token(Token = "0x400864B")]
	[FieldOffset(Offset = "0xA8")]
	public string cinematicDescription;

	[Token(Token = "0x600719F")]
	[Address(RVA = "0x10D60D0", Offset = "0x10D4ED0", Length = "0x119")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x60071A0")]
	[Address(RVA = "0x10D60C0", Offset = "0x10D4EC0", Length = "0x7")]
	public State_CinematicSubFSM()
	{
	}
}
