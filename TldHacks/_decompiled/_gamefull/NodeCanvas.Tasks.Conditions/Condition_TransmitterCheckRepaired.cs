using Cpp2ILInjected;
using InteractiveObjects;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Transponders")]
[Description("Check if a transmitter site has been repaired and is on")]
[Name("Check Transmitter Repaired", 0)]
[Token(Token = "0x2001163")]
public class Condition_TransmitterCheckRepaired : Condition_TransmitterCheckBase
{
	[Token(Token = "0x60074B4")]
	[Address(RVA = "0x1102C10", Offset = "0x1101A10", Length = "0xF6")]
	protected override string GetPropertyInfoString(TransmitterRuntimeState state)
	{
		return null;
	}

	[Token(Token = "0x60074B5")]
	[Address(RVA = "0x1102D10", Offset = "0x1101B10", Length = "0x24")]
	protected override bool GetPropertyValue(TransmitterRuntimeState state)
	{
		return false;
	}

	[Token(Token = "0x60074B6")]
	[Address(RVA = "0x1102600", Offset = "0x1101400", Length = "0x44")]
	public Condition_TransmitterCheckRepaired()
	{
	}
}
