using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Check if the player possesses ANY or ALL inventory items in a given list.")]
[Name("Has Inventory Items", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200112A")]
public class Condition_PlayerHasInventoryItems : ConditionTask
{
	[Token(Token = "0x4008783")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	[Token(Token = "0x4008784")]
	[FieldOffset(Offset = "0x70")]
	public bool mustHaveAll;

	[Token(Token = "0x4008785")]
	[FieldOffset(Offset = "0x71")]
	public bool requireInvEvent;

	[Token(Token = "0x4008786")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<string, List<InventoryItemRequirement>> requirementsDict;

	[Token(Token = "0x170008EC")]
	protected override string info
	{
		[Token(Token = "0x6007405")]
		[Address(RVA = "0x10F7660", Offset = "0x10F6460", Length = "0x4B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007406")]
	[Address(RVA = "0x10F7B20", Offset = "0x10F6920", Length = "0x12")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007407")]
	[Address(RVA = "0x10F7B40", Offset = "0x10F6940", Length = "0xF3")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007408")]
	[Address(RVA = "0x10F7C40", Offset = "0x10F6A40", Length = "0x249")]
	private bool Test()
	{
		return false;
	}

	[Token(Token = "0x6007409")]
	[Address(RVA = "0x10F7E90", Offset = "0x10F6C90", Length = "0x163")]
	public Condition_PlayerHasInventoryItems()
	{
	}
}
