using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Actions")]
[Description("Has the played placed a specific item onto a place point, specific or any point")]
[Name("Has Placed Item", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001138")]
public class Condition_HasPlacedItem : ConditionTask
{
	[Token(Token = "0x40087A3")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GearItem> targetGearItem;

	[Token(Token = "0x170008F4")]
	protected override string info
	{
		[Token(Token = "0x6007432")]
		[Address(RVA = "0x10FAAD0", Offset = "0x10F98D0", Length = "0x162")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007433")]
	[Address(RVA = "0x10FAC40", Offset = "0x10F9A40", Length = "0x217")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007434")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007435")]
	[Address(RVA = "0x10FAE60", Offset = "0x10F9C60", Length = "0xE3")]
	public Condition_HasPlacedItem()
	{
	}
}
