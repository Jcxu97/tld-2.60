using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("ResetHitAndShoulderOffsetLayer", 0)]
[Description("Reset the hip and shoulder offset layer on player animations.")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011BC")]
public class Action_ResetHitAndShoulderOffsetLayer : ActionTask
{
	[Token(Token = "0x6007610")]
	[Address(RVA = "0x1117A10", Offset = "0x1116810", Length = "0x91")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007611")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ResetHitAndShoulderOffsetLayer()
	{
	}
}
