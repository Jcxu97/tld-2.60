using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Play Animation State", 0)]
[Description("Set the Idle on the dialogue object")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011B7")]
public class Action_PlayAnimatorControllerState : ActionTask
{
	[Token(Token = "0x40088CC")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x40088CD")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> animationState;

	[Token(Token = "0x60075FE")]
	[Address(RVA = "0x1115EC0", Offset = "0x1114CC0", Length = "0x1AE")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075FF")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PlayAnimatorControllerState()
	{
	}
}
