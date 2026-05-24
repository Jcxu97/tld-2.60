using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Use this to get a variable on any blackboard by overriding the agent")]
[Token(Token = "0x2001293")]
public class GetOtherBlackboardVariable : ActionTask<Blackboard>
{
	[RequiredField]
	[Token(Token = "0x4008B60")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> targetVariableName;

	[BlackboardOnly]
	[Token(Token = "0x4008B61")]
	[FieldOffset(Offset = "0x70")]
	public BBObjectParameter saveAs;

	[Token(Token = "0x170009C6")]
	protected override string info
	{
		[Token(Token = "0x6007887")]
		[Address(RVA = "0x1170390", Offset = "0x116F190", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007888")]
	[Address(RVA = "0x1170420", Offset = "0x116F220", Length = "0x19F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007889")]
	[Address(RVA = "0x11705C0", Offset = "0x116F3C0", Length = "0x44")]
	public GetOtherBlackboardVariable()
	{
	}
}
