using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("NPC Set Freezing", 0)]
[Description("Set the current freezing level of the NPC")]
[Category("TLD Actions/NPC")]
[Token(Token = "0x20011EE")]
public class Action_NPCSetFreezing : ActionTask
{
	[Token(Token = "0x400895C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> targetFreezing;

	[Token(Token = "0x400895D")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> npcIdentifier;

	[Token(Token = "0x60076A3")]
	[Address(RVA = "0x114C390", Offset = "0x114B190", Length = "0x1C8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076A4")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_NPCSetFreezing()
	{
	}
}
