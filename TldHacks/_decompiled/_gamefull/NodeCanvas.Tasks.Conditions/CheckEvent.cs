using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Utility")]
[Description("Check if an event is received and return true for one frame")]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001199")]
public class CheckEvent : ConditionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x4008888")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> eventName;

	[Token(Token = "0x17000953")]
	protected override string info
	{
		[Token(Token = "0x60075AA")]
		[Address(RVA = "0x11106F0", Offset = "0x110F4F0", Length = "0x7A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075AB")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075AC")]
	[Address(RVA = "0x1110770", Offset = "0x110F570", Length = "0xC6")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60075AD")]
	[Address(RVA = "0x1110840", Offset = "0x110F640", Length = "0x44")]
	public CheckEvent()
	{
	}
}
[Category("✫ Utility")]
[Description("Check if an event is received and return true for one frame. Optionaly save the received event's value")]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200119A")]
public class CheckEvent<T> : ConditionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x4008889")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> eventName;

	[BlackboardOnly]
	[Token(Token = "0x400888A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveEventValue;

	[Token(Token = "0x17000954")]
	protected override string info
	{
		[Token(Token = "0x60075AE")]
		[Address(RVA = "0x233A430", Offset = "0x2339230", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075AF")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075B0")]
	[Address(RVA = "0x233A4C0", Offset = "0x23392C0", Length = "0x27D")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60075B1")]
	[Address(RVA = "0x233A740", Offset = "0x2339540", Length = "0x44")]
	public CheckEvent()
	{
	}
}
