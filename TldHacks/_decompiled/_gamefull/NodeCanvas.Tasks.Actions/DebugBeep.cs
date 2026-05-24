using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Plays a 'Beep' in editor only")]
[Token(Token = "0x20012FF")]
public class DebugBeep : ActionTask
{
	[Token(Token = "0x6007A0A")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A0B")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public DebugBeep()
	{
	}
}
