using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Show Panel", 0)]
[Description("Activates a panel. Can block flow until panel is closed")]
[Category("TLD Mission UI")]
[Token(Token = "0x2001242")]
public class Action_ShowPanel : ActionTask
{
	[Token(Token = "0x2001243")]
	public enum Panel
	{
		[Token(Token = "0x4008A74")]
		BodyHarvest
	}

	[Token(Token = "0x4008A70")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Panel> panel;

	[Token(Token = "0x4008A71")]
	[FieldOffset(Offset = "0x70")]
	public bool waitForClose;

	[Token(Token = "0x4008A72")]
	[FieldOffset(Offset = "0x71")]
	public bool triggerEndAnimation;

	[Token(Token = "0x6007795")]
	[Address(RVA = "0x115EC50", Offset = "0x115DA50", Length = "0x1DA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007796")]
	[Address(RVA = "0x115EE30", Offset = "0x115DC30", Length = "0x1D4")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007797")]
	[Address(RVA = "0x115F010", Offset = "0x115DE10", Length = "0x192")]
	private void MaybeShowBodyHarvest()
	{
	}

	[Token(Token = "0x6007798")]
	[Address(RVA = "0x115F1B0", Offset = "0x115DFB0", Length = "0x18C")]
	private void MaybeUpdateBodyHarvest()
	{
	}

	[Token(Token = "0x6007799")]
	[Address(RVA = "0x115F340", Offset = "0x115E140", Length = "0xC")]
	public Action_ShowPanel()
	{
	}
}
