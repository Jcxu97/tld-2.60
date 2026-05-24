using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Actions")]
[Description("Checks if an item is in a specific cooking state")]
[Name("Item Cooking State", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001139")]
public class Condition_ItemCookingState : ConditionTask
{
	[Token(Token = "0x40087A4")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GearItem> targetGearItem;

	[Token(Token = "0x40087A5")]
	[FieldOffset(Offset = "0x70")]
	public CookingPotItem.CookingState targetState;

	[Token(Token = "0x170008F5")]
	protected override string info
	{
		[Token(Token = "0x6007436")]
		[Address(RVA = "0x10FAF50", Offset = "0x10F9D50", Length = "0x1FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007437")]
	[Address(RVA = "0x10FB150", Offset = "0x10F9F50", Length = "0x25B")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007438")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007439")]
	[Address(RVA = "0x10FB3B0", Offset = "0x10FA1B0", Length = "0xE3")]
	public Condition_ItemCookingState()
	{
	}
}
