using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Show Credits", 0)]
[Description("Marks an episode as complete")]
[Category("TLD Actions")]
[Token(Token = "0x2001273")]
public class Action_ShowCredits : ActionTask
{
	[Token(Token = "0x4008AFD")]
	[FieldOffset(Offset = "0x68")]
	public int m_CreditsSourceIndex;

	[Token(Token = "0x6007812")]
	[Address(RVA = "0x1169780", Offset = "0x1168580", Length = "0x165")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007813")]
	[Address(RVA = "0x11698F0", Offset = "0x11686F0", Length = "0x5B")]
	private static void SimpleQuit()
	{
	}

	[Token(Token = "0x6007814")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ShowCredits()
	{
	}
}
