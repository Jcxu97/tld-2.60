using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Restore Player Inventory", 0)]
[Description("Will restore all items that were removed by a Remove Player Inventory action, requires the matching BB var.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001218")]
public class Action_RestorePlayerInventory : ActionTask
{
	[Token(Token = "0x40089D9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> serializedGearData;

	[Token(Token = "0x6007713")]
	[Address(RVA = "0x1155870", Offset = "0x1154670", Length = "0x31F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007714")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RestorePlayerInventory()
	{
	}
}
