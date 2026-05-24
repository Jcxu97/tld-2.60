using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("returns true if a fire is burning and will continue burning longer than the specified time")]
[Name("RemainingFireBurnTime", 0)]
[Token(Token = "0x200114C")]
public class Condition_RemainingFireBurnTime : ConditionTask
{
	[Token(Token = "0x40087C5")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	[Token(Token = "0x40087C6")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> burnTimeHoursRemaining;

	[Token(Token = "0x600746F")]
	[Address(RVA = "0x10FE620", Offset = "0x10FD420", Length = "0x68A")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007470")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_RemainingFireBurnTime()
	{
	}
}
