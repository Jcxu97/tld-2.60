using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Banish Darkwalker", 0)]
[Description("Stop the darkwalker from stalking you")]
[Category("TLD Actions/Challenge")]
[Token(Token = "0x20011CD")]
public class Action_BanishDarkwalker : ActionTask
{
	[Token(Token = "0x600763D")]
	[Address(RVA = "0x1119920", Offset = "0x1118720", Length = "0x6D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600763E")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_BanishDarkwalker()
	{
	}
}
