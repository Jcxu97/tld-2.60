using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("returns true if a fire has been burning for longer than the specified time")]
[Name("Has Fire Been Burning", 0)]
[Token(Token = "0x200114D")]
public class Condition_HasFireBeenBurning : ConditionTask
{
	[Token(Token = "0x40087C7")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	[Token(Token = "0x40087C8")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> burnTimeHours;

	[Token(Token = "0x17000903")]
	protected override string info
	{
		[Token(Token = "0x6007471")]
		[Address(RVA = "0x10FECB0", Offset = "0x10FDAB0", Length = "0xE5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007472")]
	[Address(RVA = "0x10FEDA0", Offset = "0x10FDBA0", Length = "0x685")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007473")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HasFireBeenBurning()
	{
	}
}
