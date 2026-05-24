using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Dialogue Idle State", 0)]
[Description("Set the Idle on the dialogue object")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011B6")]
public class Action_PlayAnimationState : ActionTask
{
	[Token(Token = "0x40088CA")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x40088CB")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> animationState;

	[Token(Token = "0x60075FC")]
	[Address(RVA = "0x1115D10", Offset = "0x1114B10", Length = "0x1A5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075FD")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PlayAnimationState()
	{
	}
}
