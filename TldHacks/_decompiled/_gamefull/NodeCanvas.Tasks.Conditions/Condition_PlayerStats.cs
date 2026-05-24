using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if the comparison operator is true")]
[Name("Player Stats", 0)]
[Token(Token = "0x200112F")]
public class Condition_PlayerStats : ConditionTask
{
	[Token(Token = "0x2001130")]
	public enum Stat
	{
		[Token(Token = "0x4008792")]
		Fatigue,
		[Token(Token = "0x4008793")]
		Freezing,
		[Token(Token = "0x4008794")]
		Health,
		[Token(Token = "0x4008795")]
		Hunger,
		[Token(Token = "0x4008796")]
		Thirst
	}

	[Token(Token = "0x400878D")]
	[FieldOffset(Offset = "0x68")]
	public Stat stat;

	[Token(Token = "0x400878E")]
	[FieldOffset(Offset = "0x6C")]
	public CompareMethod checkType;

	[Token(Token = "0x400878F")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> compareValue;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x4008790")]
	[FieldOffset(Offset = "0x78")]
	public float differenceThreshold;

	[Token(Token = "0x170008EF")]
	protected override string info
	{
		[Token(Token = "0x6007418")]
		[Address(RVA = "0x10F8EF0", Offset = "0x10F7CF0", Length = "0x293")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007417")]
	[Address(RVA = "0x10F8B40", Offset = "0x10F7940", Length = "0x3A4")]
	private float GetStatValue()
	{
		return 0f;
	}

	[Token(Token = "0x6007419")]
	[Address(RVA = "0x10F9190", Offset = "0x10F7F90", Length = "0x1C7")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600741A")]
	[Address(RVA = "0x10F8B30", Offset = "0x10F7930", Length = "0xF")]
	public Condition_PlayerStats()
	{
	}
}
