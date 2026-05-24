using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Show/Hide Hands", 0)]
[Description("Show or hide hands. If hidden, prevent equipping of items.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001202")]
public class Action_ShowHideHands : ActionTask
{
	[Token(Token = "0x2001203")]
	public enum Mode
	{
		[Token(Token = "0x400898A")]
		ShowHands,
		[Token(Token = "0x400898B")]
		HideHands
	}

	[Token(Token = "0x4008988")]
	[FieldOffset(Offset = "0x68")]
	public Mode handsMode;

	[Token(Token = "0x17000978")]
	protected override string info
	{
		[Token(Token = "0x60076D6")]
		[Address(RVA = "0x114FDC0", Offset = "0x114EBC0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076D7")]
	[Address(RVA = "0x114FE20", Offset = "0x114EC20", Length = "0x1B0")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076D8")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ShowHideHands()
	{
	}
}
