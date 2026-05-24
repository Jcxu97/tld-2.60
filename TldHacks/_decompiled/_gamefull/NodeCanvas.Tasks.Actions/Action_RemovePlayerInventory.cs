using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Remove Player Inventory", 0)]
[Description("Will remove all items from player's inventory except the clothes they are wearing. Inventory can be restored using the Restore Player Inventory action.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001217")]
public class Action_RemovePlayerInventory : ActionTask
{
	[Token(Token = "0x40089D8")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> serializedGearData;

	[Token(Token = "0x6007711")]
	[Address(RVA = "0x11551D0", Offset = "0x1153FD0", Length = "0x697")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007712")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RemovePlayerInventory()
	{
	}
}
