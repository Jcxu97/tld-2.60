using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Give Back Player-Owned Items", 0)]
[Description("Will give back all player-owned items in the current scene, including items on the ground and items in containers.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001219")]
public class Action_GiveBackPlayerItems : ActionTask
{
	[Token(Token = "0x6007715")]
	[Address(RVA = "0x1155B90", Offset = "0x1154990", Length = "0x1AC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007716")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_GiveBackPlayerItems()
	{
	}
}
