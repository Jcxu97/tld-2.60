using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Caught Fish", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001142")]
public class Condition_CaughtFish : ConditionTask
{
	[Token(Token = "0x40087AF")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GearItem> targetGearItem;

	[Token(Token = "0x170008FD")]
	protected override string info
	{
		[Token(Token = "0x6007454")]
		[Address(RVA = "0x10FC5C0", Offset = "0x10FB3C0", Length = "0x162")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007455")]
	[Address(RVA = "0x10FC730", Offset = "0x10FB530", Length = "0x217")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007456")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007457")]
	[Address(RVA = "0x10FC950", Offset = "0x10FB750", Length = "0xE3")]
	public Condition_CaughtFish()
	{
	}
}
