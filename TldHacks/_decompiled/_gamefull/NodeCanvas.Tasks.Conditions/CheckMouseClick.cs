using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[EventReceiver(new string[] { "OnMouseDown", "OnMouseUp" })]
[Token(Token = "0x2001193")]
public class CheckMouseClick : ConditionTask<Collider>
{
	[Token(Token = "0x400887A")]
	[FieldOffset(Offset = "0x68")]
	public MouseClickEvent checkType;

	[Token(Token = "0x1700094D")]
	protected override string info
	{
		[Token(Token = "0x6007580")]
		[Address(RVA = "0x110FAC0", Offset = "0x110E8C0", Length = "0x58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007581")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007582")]
	[Address(RVA = "0x110F960", Offset = "0x110E760", Length = "0x11")]
	public void OnMouseDown()
	{
	}

	[Token(Token = "0x6007583")]
	[Address(RVA = "0x110F980", Offset = "0x110E780", Length = "0x11")]
	public void OnMouseUp()
	{
	}

	[Token(Token = "0x6007584")]
	[Address(RVA = "0x110FB20", Offset = "0x110E920", Length = "0x44")]
	public CheckMouseClick()
	{
	}
}
