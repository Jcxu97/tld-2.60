using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[Name("Check Mouse Click 2D", 0)]
[EventReceiver(new string[] { "OnMouseDown", "OnMouseUp" })]
[Token(Token = "0x2001194")]
public class CheckMouseClick2D : ConditionTask<Collider2D>
{
	[Token(Token = "0x400887B")]
	[FieldOffset(Offset = "0x68")]
	public MouseClickEvent checkType;

	[Token(Token = "0x1700094E")]
	protected override string info
	{
		[Token(Token = "0x6007585")]
		[Address(RVA = "0x110FB70", Offset = "0x110E970", Length = "0x58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007586")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007587")]
	[Address(RVA = "0x110F960", Offset = "0x110E760", Length = "0x11")]
	public void OnMouseDown()
	{
	}

	[Token(Token = "0x6007588")]
	[Address(RVA = "0x110F980", Offset = "0x110E780", Length = "0x11")]
	public void OnMouseUp()
	{
	}

	[Token(Token = "0x6007589")]
	[Address(RVA = "0x110FBD0", Offset = "0x110E9D0", Length = "0x44")]
	public CheckMouseClick2D()
	{
	}
}
