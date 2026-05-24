using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("SetBaseAiCanScanForTargets", 0)]
[Description("Sets disable baseai scan for targets")]
[Category("TLD Actions/BaseAi")]
[Token(Token = "0x20011AE")]
public class Action_SetBaseAiCanScanForTargets : TLD_Action
{
	[Token(Token = "0x40088B3")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> disableScanForTargets;

	[Token(Token = "0x60075E3")]
	[Address(RVA = "0x1113160", Offset = "0x1111F60", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075E4")]
	[Address(RVA = "0x1113190", Offset = "0x1111F90", Length = "0x1BC")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075E5")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBaseAiCanScanForTargets()
	{
	}
}
