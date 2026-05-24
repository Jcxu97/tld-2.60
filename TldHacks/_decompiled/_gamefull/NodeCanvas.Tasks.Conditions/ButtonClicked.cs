using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Conditions;

[Category("UGUI")]
[Token(Token = "0x2001197")]
public class ButtonClicked : ConditionTask
{
	[RequiredField]
	[Token(Token = "0x4008886")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Button> button;

	[Token(Token = "0x17000951")]
	protected override string info
	{
		[Token(Token = "0x6007594")]
		[Address(RVA = "0x1110320", Offset = "0x110F120", Length = "0x9B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007595")]
	[Address(RVA = "0x11103C0", Offset = "0x110F1C0", Length = "0xC5")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007596")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007597")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6007598")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public ButtonClicked()
	{
	}
}
