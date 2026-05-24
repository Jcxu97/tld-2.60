using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Adds up the weight of items in the player's inventory, based on the Target Gear Item List, and determines if that sum matches the Target Weight and Check Type.")]
[Name("Has Items With Weight", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001137")]
public class Condition_PlayerHasItemsWithWeight : ConditionTask
{
	[Token(Token = "0x400879E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GearItem>> targetGearItemList;

	[Token(Token = "0x400879F")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod checkType;

	[Name("Target Weight (kg)", 0)]
	[Token(Token = "0x40087A0")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> targetWeight;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x40087A1")]
	[FieldOffset(Offset = "0x80")]
	public float differenceThreshold;

	[Token(Token = "0x40087A2")]
	[FieldOffset(Offset = "0x88")]
	private List<GearItem> playerItems;

	[Token(Token = "0x600742E")]
	[Address(RVA = "0x10FA290", Offset = "0x10F9090", Length = "0x7")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600742F")]
	[Address(RVA = "0x10FA2A0", Offset = "0x10F90A0", Length = "0xF3")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007430")]
	[Address(RVA = "0x10FA3A0", Offset = "0x10F91A0", Length = "0x53A")]
	private bool Test()
	{
		return false;
	}

	[Token(Token = "0x6007431")]
	[Address(RVA = "0x10FA8E0", Offset = "0x10F96E0", Length = "0x1E7")]
	public Condition_PlayerHasItemsWithWeight()
	{
	}
}
