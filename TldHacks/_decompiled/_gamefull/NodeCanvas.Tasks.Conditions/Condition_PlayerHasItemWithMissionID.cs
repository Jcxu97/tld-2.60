using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Check if the player possesses an inventory item with a specific mission object identifier")]
[Name("Has Item With Mission ID", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001133")]
public class Condition_PlayerHasItemWithMissionID : ConditionTask
{
	[Token(Token = "0x400879A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectId;

	[Token(Token = "0x400879B")]
	[FieldOffset(Offset = "0x70")]
	public bool requireInvEvent;

	[Token(Token = "0x170008F1")]
	protected override string info
	{
		[Token(Token = "0x6007421")]
		[Address(RVA = "0x10F9760", Offset = "0x10F8560", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007422")]
	[Address(RVA = "0x10F97D0", Offset = "0x10F85D0", Length = "0x12")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007423")]
	[Address(RVA = "0x10F97F0", Offset = "0x10F85F0", Length = "0xF3")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007424")]
	[Address(RVA = "0x10F98F0", Offset = "0x10F86F0", Length = "0x358")]
	private bool Test()
	{
		return false;
	}

	[Token(Token = "0x6007425")]
	[Address(RVA = "0x10F9C50", Offset = "0x10F8A50", Length = "0x10C")]
	public Condition_PlayerHasItemWithMissionID()
	{
	}
}
