using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Tutorial Popup", 0)]
[Description("Enables the tutorial popup panel, with the locID message specified")]
[Category("TLD Actions/TLD Mission UI")]
[Token(Token = "0x2001245")]
public class Action_TutorialPopup : ActionTask
{
	[Token(Token = "0x4008A76")]
	[FieldOffset(Offset = "0x68")]
	public string m_TutorialName;

	[Token(Token = "0x4008A77")]
	[FieldOffset(Offset = "0x70")]
	public bool useHUDPopup;

	[Token(Token = "0x4008A78")]
	[FieldOffset(Offset = "0x71")]
	private bool m_PreviousUseHudPopupValue;

	[Token(Token = "0x600779C")]
	[Address(RVA = "0x115F500", Offset = "0x115E300", Length = "0x16B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600779D")]
	[Address(RVA = "0x115F670", Offset = "0x115E470", Length = "0x16D")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600779E")]
	[Address(RVA = "0x115F7E0", Offset = "0x115E5E0", Length = "0x7B")]
	public Action_TutorialPopup()
	{
	}
}
