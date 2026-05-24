using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Actions/Player")]
[Description("Reset the player's inventory to use the current XP mode's starting gear.")]
[Name("Reset Start Gear", 0)]
[Token(Token = "0x2001211")]
public class Action_ResetStartGear : ActionTask
{
	[Description("This will destroy all gear currently on the player")]
	[Token(Token = "0x40089B4")]
	[FieldOffset(Offset = "0x68")]
	public bool DestroyCurrentGear;

	[Token(Token = "0x60076FF")]
	[Address(RVA = "0x1152D70", Offset = "0x1151B70", Length = "0x96")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007700")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ResetStartGear()
	{
	}
}
