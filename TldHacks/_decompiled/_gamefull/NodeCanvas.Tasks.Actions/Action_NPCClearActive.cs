using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("NPC Clear Active", 0)]
[Description("Clear the internally tracked Active NPC")]
[Category("TLD Actions/NPC")]
[Token(Token = "0x20011EF")]
public class Action_NPCClearActive : ActionTask
{
	[Token(Token = "0x60076A5")]
	[Address(RVA = "0x114C560", Offset = "0x114B360", Length = "0x58")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076A6")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_NPCClearActive()
	{
	}
}
