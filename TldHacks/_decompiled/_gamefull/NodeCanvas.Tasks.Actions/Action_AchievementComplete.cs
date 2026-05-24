using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Challenge Achievement Complete", 0)]
[Category("TLD Achievement")]
[Token(Token = "0x200119F")]
public class Action_AchievementComplete : ActionTask
{
	[Token(Token = "0x4008891")]
	[FieldOffset(Offset = "0x68")]
	public AchievementManager.ChallengeAchievement achievement;

	[Token(Token = "0x60075BF")]
	[Address(RVA = "0x1110DA0", Offset = "0x110FBA0", Length = "0x80")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075C0")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_AchievementComplete()
	{
	}
}
