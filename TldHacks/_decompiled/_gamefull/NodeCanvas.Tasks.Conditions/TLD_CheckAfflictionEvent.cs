using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if an event relating to a specific mission object has been received and return true for one frame")]
[Name("Check Affliction Event", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001118")]
public class TLD_CheckAfflictionEvent : ConditionTask<GraphOwner>
{
	[Token(Token = "0x4008753")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectName;

	[Token(Token = "0x4008754")]
	[FieldOffset(Offset = "0x70")]
	public AfflictionType affliction;

	[Token(Token = "0x4008755")]
	[FieldOffset(Offset = "0x74")]
	public AfflictionEventType eventType;

	[Token(Token = "0x170008E2")]
	protected override string info
	{
		[Token(Token = "0x60073CC")]
		[Address(RVA = "0x10F2350", Offset = "0x10F1150", Length = "0x1A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073CD")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073CE")]
	[Address(RVA = "0x10F2500", Offset = "0x10F1300", Length = "0x28A")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60073CF")]
	[Address(RVA = "0x10F2790", Offset = "0x10F1590", Length = "0x138")]
	public TLD_CheckAfflictionEvent()
	{
	}
}
