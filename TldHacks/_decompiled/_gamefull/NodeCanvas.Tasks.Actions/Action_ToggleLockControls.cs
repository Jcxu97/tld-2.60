using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Lock Player Controls", 0)]
[Description("Set the player controls to locked or unlocked")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011F9")]
public class Action_ToggleLockControls : ActionTask
{
	[Token(Token = "0x4008970")]
	[FieldOffset(Offset = "0x68")]
	public bool shouldLock;

	[Token(Token = "0x60076BD")]
	[Address(RVA = "0x114E3E0", Offset = "0x114D1E0", Length = "0xC0")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076BE")]
	[Address(RVA = "0x11185E0", Offset = "0x11173E0", Length = "0xC")]
	public Action_ToggleLockControls()
	{
	}
}
