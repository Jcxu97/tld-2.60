using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Bear Hunt Redux", 0)]
[Description("Start Bear Hunt Redux Mission")]
[Category("TLD Actions/Code Missions")]
[Token(Token = "0x200084C")]
public class Action_BearHuntRedux : ActionTask
{
	[Token(Token = "0x6004CBC")]
	[Address(RVA = "0xD76990", Offset = "0xD75790", Length = "0x58")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CBD")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_BearHuntRedux()
	{
	}
}
