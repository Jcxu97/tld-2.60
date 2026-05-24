using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Utility")]
[Description("Check if an event is received and it's value is equal to specified value, then return true for one frame")]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200119B")]
public class CheckEventValue<T> : ConditionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x400888B")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> eventName;

	[Name("Compare Value To", 0)]
	[Token(Token = "0x400888C")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> value;

	[Token(Token = "0x17000955")]
	protected override string info
	{
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0x23371C0", Offset = "0x2335FC0", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075B3")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075B4")]
	[Address(RVA = "0x2337250", Offset = "0x2336050", Length = "0x185")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60075B5")]
	[Address(RVA = "0x23373E0", Offset = "0x23361E0", Length = "0x44")]
	public CheckEventValue()
	{
	}
}
