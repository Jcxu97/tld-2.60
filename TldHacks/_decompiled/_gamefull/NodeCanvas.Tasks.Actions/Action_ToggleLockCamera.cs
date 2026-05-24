using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Lock Camera Controls", 0)]
[Description("Set the camera controls to locked or unlocked")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011FA")]
public class Action_ToggleLockCamera : ActionTask
{
	[Token(Token = "0x4008971")]
	[FieldOffset(Offset = "0x68")]
	public bool shouldLock;

	[Token(Token = "0x60076BF")]
	[Address(RVA = "0x114E4B0", Offset = "0x114D2B0", Length = "0x81")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076C0")]
	[Address(RVA = "0x11185E0", Offset = "0x11173E0", Length = "0xC")]
	public Action_ToggleLockCamera()
	{
	}
}
