using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Force Kill Player", 0)]
[Description("Force kill the player.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200121F")]
public class Action_ForceKillPlayer : ActionTask
{
	[Token(Token = "0x600771E")]
	[Address(RVA = "0x1156B90", Offset = "0x1155990", Length = "0x67")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600771F")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ForceKillPlayer()
	{
	}
}
