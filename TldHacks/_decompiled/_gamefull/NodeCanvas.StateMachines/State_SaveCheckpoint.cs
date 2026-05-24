using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.StateMachines;

[Name("Save Checkpoint", 0)]
[Category("TLD States")]
[Description("Saves a checkpoint")]
[Token(Token = "0x20010C7")]
public class State_SaveCheckpoint : FSMState
{
	[Token(Token = "0x400865E")]
	[FieldOffset(Offset = "0x88")]
	private bool m_RestoredFromSave;

	[Token(Token = "0x60071CF")]
	[Address(RVA = "0x862D40", Offset = "0x861B40", Length = "0x8")]
	public void SetRestoredFromSave()
	{
	}

	[Token(Token = "0x60071D0")]
	[Address(RVA = "0x10D8840", Offset = "0x10D7640", Length = "0x18")]
	protected override void OnEnter()
	{
	}

	[Token(Token = "0x60071D1")]
	[Address(RVA = "0x10D8860", Offset = "0x10D7660", Length = "0x9E")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60071D2")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public State_SaveCheckpoint()
	{
	}
}
