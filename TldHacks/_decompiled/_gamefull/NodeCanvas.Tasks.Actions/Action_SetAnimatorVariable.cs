using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Animator variable", 0)]
[Description("Sets a variable on an animator")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011B4")]
public class Action_SetAnimatorVariable : ActionTask
{
	[Token(Token = "0x40088BF")]
	[FieldOffset(Offset = "0x68")]
	public bool onThisObject;

	[Token(Token = "0x40088C0")]
	[FieldOffset(Offset = "0x70")]
	public string missionObjectIdentifierString;

	[Token(Token = "0x40088C1")]
	[FieldOffset(Offset = "0x78")]
	public string animatorControllerName;

	[Token(Token = "0x40088C2")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<string> bbParameter;

	[Token(Token = "0x40088C3")]
	[FieldOffset(Offset = "0x88")]
	public string defaultParameter;

	[Token(Token = "0x40088C4")]
	[FieldOffset(Offset = "0x90")]
	public AnimatorControllerParameterType parameterType;

	[Token(Token = "0x40088C5")]
	[FieldOffset(Offset = "0x98")]
	public string value;

	[Token(Token = "0x60075F4")]
	[Address(RVA = "0x1115370", Offset = "0x1114170", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075F5")]
	[Address(RVA = "0x11153A0", Offset = "0x11141A0", Length = "0x38A")]
	private Animator GetAnimator()
	{
		return null;
	}

	[Token(Token = "0x60075F6")]
	[Address(RVA = "0x1115730", Offset = "0x1114530", Length = "0x2D9")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075F7")]
	[Address(RVA = "0x1115A10", Offset = "0x1114810", Length = "0x12")]
	public Action_SetAnimatorVariable()
	{
	}
}
