using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Inv Requirements Count", 0)]
[Description("Store a count of how many items from a list of required types that the player currently possesses.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011F4")]
public class Action_GetInvRequirementsCount : ActionTask
{
	[Token(Token = "0x4008962")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	[Token(Token = "0x4008963")]
	[FieldOffset(Offset = "0x70")]
	public string storeCountVar;

	[Token(Token = "0x4008964")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<string, List<InventoryItemRequirement>> requirementsDict;

	[Token(Token = "0x17000970")]
	protected override string info
	{
		[Token(Token = "0x60076AF")]
		[Address(RVA = "0x114C840", Offset = "0x114B640", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076B0")]
	[Address(RVA = "0x114C880", Offset = "0x114B680", Length = "0x1EF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076B1")]
	[Address(RVA = "0x114CA70", Offset = "0x114B870", Length = "0x15D")]
	public Action_GetInvRequirementsCount()
	{
	}
}
