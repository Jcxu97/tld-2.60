using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Check if the player fired their equipped weapon.")]
[Name("Fired Equipped Weapon (EVENT)", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x200112C")]
public class Condition_PlayerFiredEquippedWeapon : ConditionTask
{
	[Token(Token = "0x600740F")]
	[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007410")]
	[Address(RVA = "0x10F84C0", Offset = "0x10F72C0", Length = "0x96")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x6007411")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_PlayerFiredEquippedWeapon()
	{
	}
}
