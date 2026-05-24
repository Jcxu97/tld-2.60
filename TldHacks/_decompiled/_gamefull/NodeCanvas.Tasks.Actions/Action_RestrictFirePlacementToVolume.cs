using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("RestrictFirePlacementToVolume", 0)]
[Description("FIres will not be placeable outside of this volume")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200120B")]
public class Action_RestrictFirePlacementToVolume : ActionTask
{
	[Token(Token = "0x40089AB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	[Token(Token = "0x60076F1")]
	[Address(RVA = "0x11520B0", Offset = "0x1150EB0", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076F2")]
	[Address(RVA = "0x11520E0", Offset = "0x1150EE0", Length = "0x4BA")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60076F3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RestrictFirePlacementToVolume()
	{
	}
}
