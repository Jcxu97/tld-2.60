using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Set a blackboard boolean variable")]
[Token(Token = "0x20012A5")]
public class SetBoolean : ActionTask
{
	[Token(Token = "0x20012A6")]
	public enum BoolSetModes
	{
		[Token(Token = "0x4008B89")]
		False,
		[Token(Token = "0x4008B8A")]
		True,
		[Token(Token = "0x4008B8B")]
		Toggle
	}

	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B86")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> boolVariable;

	[Token(Token = "0x4008B87")]
	[FieldOffset(Offset = "0x70")]
	public BoolSetModes setTo;

	[Token(Token = "0x170009D3")]
	protected override string info
	{
		[Token(Token = "0x60078B9")]
		[Address(RVA = "0x1171FC0", Offset = "0x1170DC0", Length = "0x114")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078BA")]
	[Address(RVA = "0x11720E0", Offset = "0x1170EE0", Length = "0x92")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078BB")]
	[Address(RVA = "0x1172180", Offset = "0x1170F80", Length = "0xF")]
	public SetBoolean()
	{
	}
}
