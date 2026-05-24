using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Switch the entire FSM of FSMTreeOwner")]
[Token(Token = "0x2001310")]
public class SwitchFSM : ActionTask<FSMOwner>
{
	[RequiredField]
	[Token(Token = "0x4008CDB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<FSM> fsm;

	[Token(Token = "0x17000A2D")]
	protected override string info
	{
		[Token(Token = "0x6007A3C")]
		[Address(RVA = "0x11902B0", Offset = "0x118F0B0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A3D")]
	[Address(RVA = "0x1190340", Offset = "0x118F140", Length = "0x112")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A3E")]
	[Address(RVA = "0x1190460", Offset = "0x118F260", Length = "0x44")]
	public SwitchFSM()
	{
	}
}
