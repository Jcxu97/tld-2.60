using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.StateMachines;

[Name("Gameplay SubFSM", 0)]
[Category("TLD States")]
[Description("This is a TLD custom version of Nested FSM State. It can be assigned an entire FSM. This node will return Running for as long as the FSM is Running. If a Success or Failure State is selected, then it will return Success or Failure as soon as the Nested FSM enters that state at which point the FSM will also be stopped. If the Nested FSM ends otherwise, this node will return Success.")]
[Token(Token = "0x20010C4")]
public class State_GameplaySubFSM : State_TLDBaseFSM
{
	[Token(Token = "0x400865A")]
	[FieldOffset(Offset = "0xD8")]
	public string gameplayDescription;

	[Token(Token = "0x60071C3")]
	[Address(RVA = "0x10D7E90", Offset = "0x10D6C90", Length = "0xCD")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x60071C4")]
	[Address(RVA = "0x10D60C0", Offset = "0x10D4EC0", Length = "0x7")]
	public State_GameplaySubFSM()
	{
	}
}
