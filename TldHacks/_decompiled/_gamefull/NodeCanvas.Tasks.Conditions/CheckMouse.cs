using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[EventReceiver(new string[] { "OnMouseEnter", "OnMouseExit", "OnMouseOver" })]
[Token(Token = "0x2001191")]
public class CheckMouse : ConditionTask<Collider>
{
	[Token(Token = "0x4008878")]
	[FieldOffset(Offset = "0x68")]
	public MouseInteractionTypes checkType;

	[Token(Token = "0x1700094B")]
	protected override string info
	{
		[Token(Token = "0x6007574")]
		[Address(RVA = "0x110F900", Offset = "0x110E700", Length = "0x58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007575")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007576")]
	[Address(RVA = "0x110F960", Offset = "0x110E760", Length = "0x11")]
	public void OnMouseEnter()
	{
	}

	[Token(Token = "0x6007577")]
	[Address(RVA = "0x110F980", Offset = "0x110E780", Length = "0x11")]
	public void OnMouseExit()
	{
	}

	[Token(Token = "0x6007578")]
	[Address(RVA = "0x110F9A0", Offset = "0x110E7A0", Length = "0x11")]
	public void OnMouseOver()
	{
	}

	[Token(Token = "0x6007579")]
	[Address(RVA = "0x110F9C0", Offset = "0x110E7C0", Length = "0x44")]
	public CheckMouse()
	{
	}
}
