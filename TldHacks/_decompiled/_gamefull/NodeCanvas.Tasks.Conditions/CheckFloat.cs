using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x200116B")]
public class CheckFloat : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x40087FE")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> valueA;

	[Token(Token = "0x40087FF")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod checkType;

	[Token(Token = "0x4008800")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> valueB;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x4008801")]
	[FieldOffset(Offset = "0x80")]
	public float differenceThreshold;

	[Token(Token = "0x1700091A")]
	protected override string info
	{
		[Token(Token = "0x60074CC")]
		[Address(RVA = "0x1103BD0", Offset = "0x11029D0", Length = "0x8F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074CD")]
	[Address(RVA = "0x1103C60", Offset = "0x1102A60", Length = "0xE8")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074CE")]
	[Address(RVA = "0x1103D50", Offset = "0x1102B50", Length = "0x12")]
	public CheckFloat()
	{
	}
}
