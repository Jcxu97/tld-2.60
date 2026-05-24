using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Stow Items In Hand", 0)]
[Description("Stows any items in hand")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001204")]
public class Action_StowItemsInHand : ActionTask
{
	[Token(Token = "0x60076D9")]
	[Address(RVA = "0x114FFE0", Offset = "0x114EDE0", Length = "0x2C")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076DA")]
	[Address(RVA = "0x1150010", Offset = "0x114EE10", Length = "0x22B")]
	private bool MaybeStowItemInHand()
	{
		return false;
	}

	[Token(Token = "0x60076DB")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void OnItemInHandStowed()
	{
	}

	[Token(Token = "0x60076DC")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_StowItemsInHand()
	{
	}
}
