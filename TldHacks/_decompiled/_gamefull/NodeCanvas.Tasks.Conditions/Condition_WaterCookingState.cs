using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Actions")]
[Description("Checks if water is in a specific cooking state")]
[Name("Water Cooking State", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200113A")]
public class Condition_WaterCookingState : ConditionTask
{
	[Token(Token = "0x40087A6")]
	[FieldOffset(Offset = "0x68")]
	public LiquidQuality waterQuality;

	[Token(Token = "0x40087A7")]
	[FieldOffset(Offset = "0x6C")]
	public CookingPotItem.CookingState targetState;

	[Token(Token = "0x170008F6")]
	protected override string info
	{
		[Token(Token = "0x600743A")]
		[Address(RVA = "0x10FB4A0", Offset = "0x10FA2A0", Length = "0x107")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600743B")]
	[Address(RVA = "0x10FB5B0", Offset = "0x10FA3B0", Length = "0x1B7")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x600743C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600743D")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_WaterCookingState()
	{
	}
}
