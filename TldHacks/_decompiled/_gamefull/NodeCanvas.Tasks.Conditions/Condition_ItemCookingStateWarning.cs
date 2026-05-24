using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Actions")]
[Description("Checks to see if a specific item is close to switching cooking states")]
[Name("Item Cooking State Warning", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200113B")]
public class Condition_ItemCookingStateWarning : ConditionTask
{
	[Token(Token = "0x40087A8")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GearItem> targetGearItem;

	[Token(Token = "0x40087A9")]
	[FieldOffset(Offset = "0x70")]
	public CookingPotItem.CookingState warningState;

	[Token(Token = "0x170008F7")]
	protected override string info
	{
		[Token(Token = "0x600743E")]
		[Address(RVA = "0x10FB770", Offset = "0x10FA570", Length = "0x1FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600743F")]
	[Address(RVA = "0x10FB970", Offset = "0x10FA770", Length = "0x25B")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007440")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007441")]
	[Address(RVA = "0x10FBBD0", Offset = "0x10FA9D0", Length = "0xE3")]
	public Condition_ItemCookingStateWarning()
	{
	}
}
