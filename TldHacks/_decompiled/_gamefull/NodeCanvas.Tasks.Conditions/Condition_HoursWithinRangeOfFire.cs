using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if the comparison operator is true")]
[Name("HoursWithinRangeOfFire", 0)]
[Token(Token = "0x2001132")]
public class Condition_HoursWithinRangeOfFire : ConditionTask
{
	[Token(Token = "0x4008797")]
	[FieldOffset(Offset = "0x68")]
	public CompareMethod checkType;

	[Token(Token = "0x4008798")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> compareValue;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x4008799")]
	[FieldOffset(Offset = "0x78")]
	public float differenceThreshold;

	[Token(Token = "0x170008F0")]
	protected override string info
	{
		[Token(Token = "0x600741E")]
		[Address(RVA = "0x10F94C0", Offset = "0x10F82C0", Length = "0x1B6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600741D")]
	[Address(RVA = "0x10F93C0", Offset = "0x10F81C0", Length = "0xF9")]
	protected float GetHoursWithinRangeOfFire()
	{
		return 0f;
	}

	[Token(Token = "0x600741F")]
	[Address(RVA = "0x10F9680", Offset = "0x10F8480", Length = "0xD6")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007420")]
	[Address(RVA = "0x10F8B30", Offset = "0x10F7930", Length = "0xF")]
	public Condition_HoursWithinRangeOfFire()
	{
	}
}
