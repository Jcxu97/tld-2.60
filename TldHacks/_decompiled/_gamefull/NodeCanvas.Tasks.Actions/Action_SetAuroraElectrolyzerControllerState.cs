using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set All Electrolyzer Power State", 0)]
[Description("Activate/Deactivate the power state of all AuroraElectrolyzer volumes for that controller")]
[Category("TLD Actions/Aurora")]
[Token(Token = "0x20011C5")]
public class Action_SetAuroraElectrolyzerControllerState : ActionTask
{
	[Token(Token = "0x40088EB")]
	[FieldOffset(Offset = "0x68")]
	public string controllerMissionObjectIdentifier;

	[Token(Token = "0x40088EC")]
	[FieldOffset(Offset = "0x70")]
	public bool active;

	[Token(Token = "0x6007628")]
	[Address(RVA = "0x1118AB0", Offset = "0x11178B0", Length = "0x12E")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007629")]
	[Address(RVA = "0x1118BE0", Offset = "0x11179E0", Length = "0x122")]
	private void DoWork()
	{
	}

	[Token(Token = "0x600762A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetAuroraElectrolyzerControllerState()
	{
	}
}
