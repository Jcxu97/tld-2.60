using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Remove Gear Items", 0)]
[Description("Remove gear items from the player's inventory")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011F8")]
public class Action_RemoveGearItem : ActionTask
{
	[Token(Token = "0x400896E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<InventoryItemRequirement>> removeItemsList;

	[Token(Token = "0x400896F")]
	[FieldOffset(Offset = "0x70")]
	public bool suppressItemRemovedEvent;

	[Token(Token = "0x17000973")]
	protected override string info
	{
		[Token(Token = "0x60076BA")]
		[Address(RVA = "0x114DE30", Offset = "0x114CC30", Length = "0x226")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076BB")]
	[Address(RVA = "0x114E060", Offset = "0x114CE60", Length = "0x20D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076BC")]
	[Address(RVA = "0x114E270", Offset = "0x114D070", Length = "0x161")]
	public Action_RemoveGearItem()
	{
	}
}
