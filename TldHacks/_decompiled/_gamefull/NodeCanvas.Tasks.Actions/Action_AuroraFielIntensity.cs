using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("AuroraField Intensity", 0)]
[Description("Set AuroraField intensity")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x20011C8")]
public class Action_AuroraFielIntensity : ActionTask
{
	[Token(Token = "0x40088F2")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x6007631")]
	[Address(RVA = "0x11191B0", Offset = "0x1117FB0", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007632")]
	[Address(RVA = "0x11191E0", Offset = "0x1117FE0", Length = "0x1CE")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007633")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_AuroraFielIntensity()
	{
	}
}
