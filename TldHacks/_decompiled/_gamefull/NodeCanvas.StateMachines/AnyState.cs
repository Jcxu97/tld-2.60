using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.StateMachines;

[Name("Any State", 0)]
[Description("The Transitions of this node will constantly be checked. If any becomes true, the target connected State will Enter regardless of the current State. This node can have no incomming transitions.")]
[Color("b3ff7f")]
[Token(Token = "0x20010D3")]
public class AnyState : FSMState, IUpdatable
{
	[Token(Token = "0x400867D")]
	[FieldOffset(Offset = "0x88")]
	public bool dontRetriggerStates;

	[Token(Token = "0x1700086B")]
	public override string name
	{
		[Token(Token = "0x600723D")]
		[Address(RVA = "0x10DD730", Offset = "0x10DC530", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086C")]
	public override int maxInConnections
	{
		[Token(Token = "0x600723E")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700086D")]
	public override int maxOutConnections
	{
		[Token(Token = "0x600723F")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700086E")]
	public override bool allowAsPrime
	{
		[Token(Token = "0x6007240")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007241")]
	[Address(RVA = "0x10DD770", Offset = "0x10DC570", Length = "0x2AB")]
	public new void Update()
	{
	}

	[Token(Token = "0x6007242")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public AnyState()
	{
	}
}
