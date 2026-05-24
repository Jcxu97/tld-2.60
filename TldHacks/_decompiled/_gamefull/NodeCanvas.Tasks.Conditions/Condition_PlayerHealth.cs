using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if the comparison operator is true")]
[Name("Player Health", 0)]
[Token(Token = "0x200112E")]
public class Condition_PlayerHealth : ConditionTask
{
	[Token(Token = "0x400878A")]
	[FieldOffset(Offset = "0x68")]
	public CompareMethod checkType;

	[Token(Token = "0x400878B")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> compareValue;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x400878C")]
	[FieldOffset(Offset = "0x78")]
	public float differenceThreshold;

	[Token(Token = "0x170008EE")]
	protected override string info
	{
		[Token(Token = "0x6007414")]
		[Address(RVA = "0x10F8660", Offset = "0x10F7460", Length = "0x2CB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007415")]
	[Address(RVA = "0x10F8930", Offset = "0x10F7730", Length = "0x1F3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007416")]
	[Address(RVA = "0x10F8B30", Offset = "0x10F7930", Length = "0xF")]
	public Condition_PlayerHealth()
	{
	}
}
