using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Save Player Profile", 0)]
[Description("Saves the player profile (not saving current game progress)")]
[Category("TLD Actions")]
[Token(Token = "0x200127B")]
public class Action_SavePlayerProfile : ActionTask
{
	[Token(Token = "0x600782E")]
	[Address(RVA = "0x116A990", Offset = "0x1169790", Length = "0x58")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600782F")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SavePlayerProfile()
	{
	}
}
