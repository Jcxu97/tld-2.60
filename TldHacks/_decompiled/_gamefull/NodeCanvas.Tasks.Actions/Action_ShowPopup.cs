using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Show Popup", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200125E")]
public class Action_ShowPopup : ActionTask
{
	[Token(Token = "0x4008AC5")]
	[FieldOffset(Offset = "0x68")]
	public PopupDefinition popup;

	[Token(Token = "0x4008AC6")]
	[FieldOffset(Offset = "0x70")]
	public bool waitCompletion;

	[Token(Token = "0x170009A4")]
	protected override string info
	{
		[Token(Token = "0x60077E0")]
		[Address(RVA = "0x11660F0", Offset = "0x1164EF0", Length = "0x125")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077E1")]
	[Address(RVA = "0x1166220", Offset = "0x1165020", Length = "0x160")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077E2")]
	[Address(RVA = "0x1166390", Offset = "0x1165190", Length = "0x11")]
	private void OnPopupEnd()
	{
	}

	[Token(Token = "0x60077E3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ShowPopup()
	{
	}
}
