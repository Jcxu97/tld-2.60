using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Input")]
[Description("Check for an input action value meeting the required criteria ")]
[Name("Input Action", 0)]
[Token(Token = "0x2001124")]
public class Condition_ActionInputButton : ConditionTask
{
	[Token(Token = "0x400876B")]
	[FieldOffset(Offset = "0x68")]
	public InputManager.InputAction action;

	[Token(Token = "0x400876C")]
	[FieldOffset(Offset = "0x6C")]
	public InputManager.InputState inputState;

	[Token(Token = "0x60073F1")]
	[Address(RVA = "0x10F5D70", Offset = "0x10F4B70", Length = "0xEC")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073F2")]
	[Address(RVA = "0x10F5D70", Offset = "0x10F4B70", Length = "0xEC")]
	private bool Test()
	{
		return false;
	}

	[Token(Token = "0x60073F3")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ActionInputButton()
	{
	}
}
