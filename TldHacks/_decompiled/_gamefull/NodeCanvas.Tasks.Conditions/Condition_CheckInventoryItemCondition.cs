using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("returns true if the condition is met for all items matching name")]
[Name("Check Inventory Item Condition", 0)]
[Token(Token = "0x2001150")]
public class Condition_CheckInventoryItemCondition : ConditionTask
{
	[Token(Token = "0x40087CC")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<InventoryItemRequirement> requiredItem;

	[Token(Token = "0x40087CD")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod checkType;

	[Token(Token = "0x40087CE")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> compareValue;

	[Token(Token = "0x40087CF")]
	[FieldOffset(Offset = "0x80")]
	private List<GearItem> items;

	[Token(Token = "0x17000906")]
	protected override string info
	{
		[Token(Token = "0x600747A")]
		[Address(RVA = "0x10FFF60", Offset = "0x10FED60", Length = "0x1B6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600747B")]
	[Address(RVA = "0x1100120", Offset = "0x10FEF20", Length = "0x2CE")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600747C")]
	[Address(RVA = "0x11003F0", Offset = "0x10FF1F0", Length = "0x265")]
	public Condition_CheckInventoryItemCondition()
	{
	}
}
