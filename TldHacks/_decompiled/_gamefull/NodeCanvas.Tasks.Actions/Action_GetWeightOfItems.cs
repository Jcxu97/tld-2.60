using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Weight Of Items", 0)]
[Description("Adds up the weight of items in the player's inventory, based on the Target Gear Item List. Value is measured in grams.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011F6")]
public class Action_GetWeightOfItems : ActionTask
{
	[Token(Token = "0x4008968")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GearItem>> targetGearItemList;

	[Token(Token = "0x4008969")]
	[FieldOffset(Offset = "0x70")]
	public string storeWeightVar;

	[Token(Token = "0x400896A")]
	[FieldOffset(Offset = "0x78")]
	private List<GearItem> playerItems;

	[Token(Token = "0x60076B5")]
	[Address(RVA = "0x114CFC0", Offset = "0x114BDC0", Length = "0x4AB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076B6")]
	[Address(RVA = "0x114D470", Offset = "0x114C270", Length = "0x1D5")]
	public Action_GetWeightOfItems()
	{
	}
}
