using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD/AI")]
[Name("SetBaseAiState", 0)]
[Description("Sets the baseai state on the agent")]
[Token(Token = "0x20011A6")]
public class Action_SetBaseAIState : TLD_Action
{
	[Token(Token = "0x40088A2")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<AiMode> state;

	[Token(Token = "0x60075D0")]
	[Address(RVA = "0x1111970", Offset = "0x1110770", Length = "0x1E3")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075D1")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBaseAIState()
	{
	}
}
