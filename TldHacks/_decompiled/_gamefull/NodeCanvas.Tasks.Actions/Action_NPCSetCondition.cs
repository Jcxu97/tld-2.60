using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("NPC Set Condition", 0)]
[Description("Set the current HP of the NPC")]
[Category("TLD Actions/NPC")]
[Token(Token = "0x20011ED")]
public class Action_NPCSetCondition : ActionTask
{
	[Token(Token = "0x400895A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> targetHP;

	[Token(Token = "0x400895B")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> npcIdentifier;

	[Token(Token = "0x60076A1")]
	[Address(RVA = "0x114C1C0", Offset = "0x114AFC0", Length = "0x1C8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076A2")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_NPCSetCondition()
	{
	}
}
