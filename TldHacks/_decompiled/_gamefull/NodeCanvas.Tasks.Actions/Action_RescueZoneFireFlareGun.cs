using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("RescueZone FireFlareGun", 0)]
[Description("Fire a shot")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x2001222")]
public class Action_RescueZoneFireFlareGun : ActionTask
{
	[Token(Token = "0x40089F9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x6007725")]
	[Address(RVA = "0x1156F30", Offset = "0x1155D30", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007726")]
	[Address(RVA = "0x1156F60", Offset = "0x1155D60", Length = "0x236")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007727")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RescueZoneFireFlareGun()
	{
	}
}
