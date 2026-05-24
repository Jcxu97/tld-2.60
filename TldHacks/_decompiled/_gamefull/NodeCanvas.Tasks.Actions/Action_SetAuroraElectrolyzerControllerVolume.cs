using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Volume Aurora Electrolizer State", 0)]
[Description("Set the power state of individual AuroraElectrolyzer volume for that controller")]
[Category("TLD Actions/Aurora")]
[Token(Token = "0x20011C6")]
public class Action_SetAuroraElectrolyzerControllerVolume : ActionTask
{
	[Token(Token = "0x40088ED")]
	[FieldOffset(Offset = "0x68")]
	public string controllerMissionObjectIdentifier;

	[Token(Token = "0x40088EE")]
	[FieldOffset(Offset = "0x70")]
	public string volumeName;

	[Token(Token = "0x40088EF")]
	[FieldOffset(Offset = "0x78")]
	public bool active;

	[Token(Token = "0x600762B")]
	[Address(RVA = "0x1118D10", Offset = "0x1117B10", Length = "0x133")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600762C")]
	[Address(RVA = "0x1118E50", Offset = "0x1117C50", Length = "0x127")]
	private void DoWork()
	{
	}

	[Token(Token = "0x600762D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetAuroraElectrolyzerControllerVolume()
	{
	}
}
