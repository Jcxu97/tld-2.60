using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Empty Containers In Scene", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x200126A")]
public class Action_EmptyContainersInScene : ActionTask<GraphOwner>
{
	[Token(Token = "0x60077FF")]
	[Address(RVA = "0x1168440", Offset = "0x1167240", Length = "0x167")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007800")]
	[Address(RVA = "0x11685B0", Offset = "0x11673B0", Length = "0x44")]
	public Action_EmptyContainersInScene()
	{
	}
}
