using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Check if a given item is currently equipped in the player's hands")]
[Name("Item Is Equipped", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200112B")]
public class Condition_PlayerItemIsEquipped : ConditionTask
{
	[Token(Token = "0x4008787")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<InventoryItemRequirement> requiredItem;

	[Token(Token = "0x4008788")]
	[FieldOffset(Offset = "0x70")]
	public bool requireInvEvent;

	[Token(Token = "0x170008ED")]
	protected override string info
	{
		[Token(Token = "0x600740A")]
		[Address(RVA = "0x10F8000", Offset = "0x10F6E00", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600740B")]
	[Address(RVA = "0x10F8060", Offset = "0x10F6E60", Length = "0x12")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600740C")]
	[Address(RVA = "0x10F8080", Offset = "0x10F6E80", Length = "0xA1")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x600740D")]
	[Address(RVA = "0x10F8130", Offset = "0x10F6F30", Length = "0x29E")]
	private bool Test()
	{
		return false;
	}

	[Token(Token = "0x600740E")]
	[Address(RVA = "0x10F83D0", Offset = "0x10F71D0", Length = "0xE7")]
	public Condition_PlayerItemIsEquipped()
	{
	}
}
