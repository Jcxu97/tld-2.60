using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Add Gear Items", 0)]
[Description("Add gear items to the player's inventory")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011F7")]
public class Action_AddGearItem : ActionTask
{
	[Token(Token = "0x400896B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<InventoryItemRequirement>> addItemsList;

	[Token(Token = "0x400896C")]
	[FieldOffset(Offset = "0x70")]
	public bool suppressItemAddedEvent;

	[Token(Token = "0x400896D")]
	[FieldOffset(Offset = "0x71")]
	public bool enableNotificationFlag;

	[Token(Token = "0x17000972")]
	protected override string info
	{
		[Token(Token = "0x60076B7")]
		[Address(RVA = "0x114D650", Offset = "0x114C450", Length = "0x273")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076B8")]
	[Address(RVA = "0x114D8D0", Offset = "0x114C6D0", Length = "0x3E7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076B9")]
	[Address(RVA = "0x114DCC0", Offset = "0x114CAC0", Length = "0x161")]
	public Action_AddGearItem()
	{
	}
}
