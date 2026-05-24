using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Check Whiteout Gear Requiements", 0)]
[Description("Fires an event based on gear requirements for Whiteout challenge")]
[Category("TLD Actions/Challenge/Whiteout")]
[Token(Token = "0x2000856")]
public class Action_WhiteoutGearRequirements : ActionTask<GraphOwner>
{
	[Token(Token = "0x40056B3")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	[Token(Token = "0x40056B4")]
	[FieldOffset(Offset = "0x70")]
	public List<string> requiredItemsHeaderList;

	[Token(Token = "0x40056B5")]
	[FieldOffset(Offset = "0x78")]
	public float numLitersPotableWater;

	[Token(Token = "0x40056B6")]
	[FieldOffset(Offset = "0x7C")]
	public float numLitersKerosene;

	[Token(Token = "0x40056B7")]
	[FieldOffset(Offset = "0x80")]
	public float daysOfFoodRequired;

	[Token(Token = "0x40056B8")]
	[FieldOffset(Offset = "0x84")]
	public float caloriesPerDay;

	[Token(Token = "0x40056B9")]
	[FieldOffset(Offset = "0x88")]
	public string sceneToStockpileItems;

	[Token(Token = "0x40056BA")]
	[FieldOffset(Offset = "0x90")]
	public string hasItemsEvent;

	[Token(Token = "0x40056BB")]
	[FieldOffset(Offset = "0x98")]
	public string doesNotHaveItemsEvent;

	[Token(Token = "0x40056BC")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<string> stockpiledGearSerialized;

	[Token(Token = "0x40056BD")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<string, float> m_StockpiledGearDict;

	[Token(Token = "0x40056BE")]
	[FieldOffset(Offset = "0xB0")]
	private List<string> m_ChecklistValsLastFrame;

	[Token(Token = "0x40056BF")]
	[FieldOffset(Offset = "0xB8")]
	private List<bool> m_ChecklistBoolsLastFrame;

	[Token(Token = "0x6004CDD")]
	[Address(RVA = "0xD77560", Offset = "0xD76360", Length = "0x5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CDE")]
	[Address(RVA = "0xD7C1F0", Offset = "0xD7AFF0", Length = "0x186F")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6004CDF")]
	[Address(RVA = "0xD7DA60", Offset = "0xD7C860", Length = "0x8AA")]
	private void AddGearItemsToDict(GearItem[] gearItems)
	{
	}

	[Token(Token = "0x6004CE0")]
	[Address(RVA = "0xD7E310", Offset = "0xD7D110", Length = "0x136")]
	private void AddOrIncrementDictEntry(string key, float val)
	{
	}

	[Token(Token = "0x6004CE1")]
	[Address(RVA = "0xD7E450", Offset = "0xD7D250", Length = "0xAB")]
	private float GetDictValueIfExists(string key)
	{
		return 0f;
	}

	[Token(Token = "0x6004CE2")]
	[Address(RVA = "0xD7E500", Offset = "0xD7D300", Length = "0x355")]
	public Action_WhiteoutGearRequirements()
	{
	}
}
