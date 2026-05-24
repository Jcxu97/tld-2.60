using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Wakeup Player", 0)]
[Description("Forcibly wakes up the player, if they are asleep.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200120F")]
public class Action_PlayerWakeup : ActionTask
{
	[Token(Token = "0x60076FB")]
	[Address(RVA = "0x1152B70", Offset = "0x1151970", Length = "0x92")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076FC")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PlayerWakeup()
	{
	}
}
