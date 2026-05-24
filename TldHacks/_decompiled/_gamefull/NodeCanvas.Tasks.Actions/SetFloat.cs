using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Set a blackboard float variable")]
[Token(Token = "0x20012A9")]
public class SetFloat : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008B8F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> valueA;

	[Token(Token = "0x4008B90")]
	[FieldOffset(Offset = "0x70")]
	public OperationMethod Operation;

	[Token(Token = "0x4008B91")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> valueB;

	[Token(Token = "0x4008B92")]
	[FieldOffset(Offset = "0x80")]
	public bool perSecond;

	[Token(Token = "0x170009D6")]
	protected override string info
	{
		[Token(Token = "0x60078C2")]
		[Address(RVA = "0x11725B0", Offset = "0x11713B0", Length = "0x1FF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078C3")]
	[Address(RVA = "0x11727B0", Offset = "0x11715B0", Length = "0x157")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078C4")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetFloat()
	{
	}
}
