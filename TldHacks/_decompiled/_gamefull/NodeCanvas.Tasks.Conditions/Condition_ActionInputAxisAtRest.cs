using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Input")]
[Description("Check for an input action value meeting the required criteria ")]
[Name("Input Axis", 0)]
[Token(Token = "0x2001125")]
public class Condition_ActionInputAxisAtRest : ConditionTask
{
	[Token(Token = "0x400876D")]
	[FieldOffset(Offset = "0x68")]
	public InputManager.InputAxis axis;

	[Token(Token = "0x400876E")]
	[FieldOffset(Offset = "0x6C")]
	public InputManager.InputAxisState inputAxis;

	[Token(Token = "0x400876F")]
	[FieldOffset(Offset = "0x70")]
	public float m_Deadzone;

	[Token(Token = "0x60073F4")]
	[Address(RVA = "0x10F5E60", Offset = "0x10F4C60", Length = "0x18B")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073F5")]
	[Address(RVA = "0x10F5FF0", Offset = "0x10F4DF0", Length = "0x143")]
	private Vector2 GetAxisValue()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60073F6")]
	[Address(RVA = "0x10F5E60", Offset = "0x10F4C60", Length = "0x18B")]
	private bool Test()
	{
		return false;
	}

	[Token(Token = "0x60073F7")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ActionInputAxisAtRest()
	{
	}
}
