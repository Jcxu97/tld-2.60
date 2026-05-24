using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("ForceAIToAttackPlayer", 0)]
[Description("Forces AI to enter Attack state with Player as target regardless of detection range, as long as Player can be pathed to.")]
[Category("TLD/AI")]
[Token(Token = "0x20011B3")]
public class Action_ForceAIToAttackPlayer : TLD_Action
{
	[Token(Token = "0x40088BD")]
	[FieldOffset(Offset = "0x78")]
	public bool stopAiBeforeAttack;

	[Token(Token = "0x40088BE")]
	[FieldOffset(Offset = "0x79")]
	public bool playAttackStartAnimation;

	[Token(Token = "0x60075F1")]
	[Address(RVA = "0x1114E70", Offset = "0x1113C70", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075F2")]
	[Address(RVA = "0x1114EA0", Offset = "0x1113CA0", Length = "0x4CE")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075F3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ForceAIToAttackPlayer()
	{
	}
}
