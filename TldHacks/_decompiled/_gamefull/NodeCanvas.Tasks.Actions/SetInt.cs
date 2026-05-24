using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Integer", 0)]
[Category("✫ Blackboard")]
[Description("Set a blackboard integer variable")]
[Token(Token = "0x20012AB")]
public class SetInt : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008B96")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> valueA;

	[Token(Token = "0x4008B97")]
	[FieldOffset(Offset = "0x70")]
	public OperationMethod Operation;

	[Token(Token = "0x4008B98")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> valueB;

	[Token(Token = "0x170009D8")]
	protected override string info
	{
		[Token(Token = "0x60078C8")]
		[Address(RVA = "0x1172B70", Offset = "0x1171970", Length = "0x8F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078C9")]
	[Address(RVA = "0x1172C00", Offset = "0x1171A00", Length = "0xD7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078CA")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetInt()
	{
	}
}
