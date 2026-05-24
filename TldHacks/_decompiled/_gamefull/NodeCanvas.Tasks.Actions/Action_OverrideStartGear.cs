using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Gear;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Actions/Player")]
[Description("Override the player's current gear with a defined set of starting gear.")]
[Name("Override Start Gear", 0)]
[Token(Token = "0x2001210")]
public class Action_OverrideStartGear : ActionTask
{
	[Description("This will destroy all gear currently on the player")]
	[Token(Token = "0x40089B2")]
	[FieldOffset(Offset = "0x68")]
	public bool DestroyCurrentGear;

	[Description("Link to a prefab with the requested starting gear defined")]
	[Token(Token = "0x40089B3")]
	[FieldOffset(Offset = "0x70")]
	public StartGear Gear;

	[Token(Token = "0x60076FD")]
	[Address(RVA = "0x1152C10", Offset = "0x1151A10", Length = "0x156")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076FE")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_OverrideStartGear()
	{
	}
}
