using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Set a blackboard boolean variable at random between min and max value")]
[Token(Token = "0x20012A7")]
public class SetBooleanRandom : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008B8C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> boolVariable;

	[Token(Token = "0x170009D4")]
	protected override string info
	{
		[Token(Token = "0x60078BC")]
		[Address(RVA = "0x1172190", Offset = "0x1170F90", Length = "0x7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078BD")]
	[Address(RVA = "0x1172210", Offset = "0x1171010", Length = "0xA4")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078BE")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetBooleanRandom()
	{
	}
}
