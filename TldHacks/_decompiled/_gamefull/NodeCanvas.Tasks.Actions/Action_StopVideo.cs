using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("StopVideo", 0)]
[Category("TLD Actions")]
[Token(Token = "0x2001280")]
public class Action_StopVideo : ActionTask
{
	[Token(Token = "0x6007844")]
	[Address(RVA = "0x116B650", Offset = "0x116A450", Length = "0x58")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007845")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_StopVideo()
	{
	}
}
