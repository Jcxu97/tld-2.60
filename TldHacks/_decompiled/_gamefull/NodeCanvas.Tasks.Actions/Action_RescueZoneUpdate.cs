using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("RescueZone Update", 0)]
[Description("Update RescueZone parameters")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x2001223")]
public class Action_RescueZoneUpdate : ActionTask
{
	[Token(Token = "0x40089FA")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x40089FB")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> autoreplyshot;

	[Token(Token = "0x6007728")]
	[Address(RVA = "0x11571A0", Offset = "0x1155FA0", Length = "0x177")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007729")]
	[Address(RVA = "0x1157320", Offset = "0x1156120", Length = "0x16B")]
	private void DoWork()
	{
	}

	[Token(Token = "0x600772A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RescueZoneUpdate()
	{
	}
}
