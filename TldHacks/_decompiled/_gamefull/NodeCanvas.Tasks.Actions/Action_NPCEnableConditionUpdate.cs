using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("NPC Enable Condition Updates", 0)]
[Description("Enable or disable condition updates on a target NPC")]
[Category("TLD Actions/NPC")]
[Token(Token = "0x20011EC")]
public class Action_NPCEnableConditionUpdate : ActionTask
{
	[Token(Token = "0x4008958")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> enableUpdates;

	[Token(Token = "0x4008959")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> npcIdentifier;

	[Token(Token = "0x600769F")]
	[Address(RVA = "0x114BF20", Offset = "0x114AD20", Length = "0x1F1")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076A0")]
	[Address(RVA = "0x114C120", Offset = "0x114AF20", Length = "0x93")]
	public Action_NPCEnableConditionUpdate()
	{
	}
}
