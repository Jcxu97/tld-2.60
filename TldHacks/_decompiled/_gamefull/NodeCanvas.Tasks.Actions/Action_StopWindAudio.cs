using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Stop Wind Audio", 0)]
[Description("Forcibly stop the active wind audio loop instance")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011C3")]
public class Action_StopWindAudio : ActionTask
{
	[Token(Token = "0x6007624")]
	[Address(RVA = "0x1118980", Offset = "0x1117780", Length = "0xBA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007625")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_StopWindAudio()
	{
	}
}
