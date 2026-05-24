using Cpp2ILInjected;
using InteractiveObjects;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Transponders")]
[Description("Check if a transmitter site is currently active")]
[Name("Check Transmitter Active", 0)]
[Token(Token = "0x2001161")]
public class Condition_TransmitterCheckActive : Condition_TransmitterCheckBase
{
	[Token(Token = "0x60074AB")]
	[Address(RVA = "0x1102450", Offset = "0x1101250", Length = "0x137")]
	protected override string GetPropertyInfoString(TransmitterRuntimeState state)
	{
		return null;
	}

	[Token(Token = "0x60074AC")]
	[Address(RVA = "0x1102590", Offset = "0x1101390", Length = "0x67")]
	protected override bool GetPropertyValue(TransmitterRuntimeState state)
	{
		return false;
	}

	[Token(Token = "0x60074AD")]
	[Address(RVA = "0x1102600", Offset = "0x1101400", Length = "0x44")]
	public Condition_TransmitterCheckActive()
	{
	}
}
