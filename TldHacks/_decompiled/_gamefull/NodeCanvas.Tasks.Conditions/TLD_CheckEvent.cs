using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if an event is received and return true for one frame")]
[Name("Check Event (EVENT)", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001115")]
public class TLD_CheckEvent : ConditionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x400874C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> eventName;

	[Token(Token = "0x170008DF")]
	protected override string info
	{
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x10F1A60", Offset = "0x10F0860", Length = "0x7A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073C1")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073C2")]
	[Address(RVA = "0x10F1AE0", Offset = "0x10F08E0", Length = "0xC6")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60073C3")]
	[Address(RVA = "0x10F1BB0", Offset = "0x10F09B0", Length = "0x44")]
	public TLD_CheckEvent()
	{
	}
}
[Category("TLD Conditions")]
[Description("Check if an event is received and return true for one frame. Optional save the received event's value")]
[Name("Check Event<T> (EVENT)", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001116")]
public class TLD_CheckEvent<T> : ConditionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x400874D")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> eventName;

	[BlackboardOnly]
	[Token(Token = "0x400874E")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveEventValue;

	[Token(Token = "0x170008E0")]
	protected override string info
	{
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0x2054B80", Offset = "0x2053980", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073C5")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073C6")]
	[Address(RVA = "0x2054C10", Offset = "0x2053A10", Length = "0x219")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60073C7")]
	[Address(RVA = "0x2054E30", Offset = "0x2053C30", Length = "0x44")]
	public TLD_CheckEvent()
	{
	}
}
