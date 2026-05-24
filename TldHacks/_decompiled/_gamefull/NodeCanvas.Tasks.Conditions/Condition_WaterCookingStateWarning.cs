using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Actions")]
[Description("Checks to see if water is close to switching cooking states")]
[Name("Water Cooking State Warning", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200113C")]
public class Condition_WaterCookingStateWarning : ConditionTask
{
	[Token(Token = "0x40087AA")]
	[FieldOffset(Offset = "0x68")]
	public LiquidQuality waterQuality;

	[Token(Token = "0x40087AB")]
	[FieldOffset(Offset = "0x6C")]
	public CookingPotItem.CookingState warningState;

	[Token(Token = "0x170008F8")]
	protected override string info
	{
		[Token(Token = "0x6007442")]
		[Address(RVA = "0x10FBCC0", Offset = "0x10FAAC0", Length = "0x107")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007443")]
	[Address(RVA = "0x10FBDD0", Offset = "0x10FABD0", Length = "0x1B7")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007444")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007445")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_WaterCookingStateWarning()
	{
	}
}
