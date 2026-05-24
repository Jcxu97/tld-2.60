using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[Name("Check Mouse 2D", 0)]
[EventReceiver(new string[] { "OnMouseEnter", "OnMouseExit", "OnMouseOver" })]
[Token(Token = "0x2001192")]
public class CheckMouse2D : ConditionTask<Collider2D>
{
	[Token(Token = "0x4008879")]
	[FieldOffset(Offset = "0x68")]
	public MouseInteractionTypes checkType;

	[Token(Token = "0x1700094C")]
	protected override string info
	{
		[Token(Token = "0x600757A")]
		[Address(RVA = "0x110FA10", Offset = "0x110E810", Length = "0x58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600757B")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600757C")]
	[Address(RVA = "0x110F960", Offset = "0x110E760", Length = "0x11")]
	public void OnMouseEnter()
	{
	}

	[Token(Token = "0x600757D")]
	[Address(RVA = "0x110F980", Offset = "0x110E780", Length = "0x11")]
	public void OnMouseExit()
	{
	}

	[Token(Token = "0x600757E")]
	[Address(RVA = "0x110F9A0", Offset = "0x110E7A0", Length = "0x11")]
	public void OnMouseOver()
	{
	}

	[Token(Token = "0x600757F")]
	[Address(RVA = "0x110FA70", Offset = "0x110E870", Length = "0x44")]
	public CheckMouse2D()
	{
	}
}
