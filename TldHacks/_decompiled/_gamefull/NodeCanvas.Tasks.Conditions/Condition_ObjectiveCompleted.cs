using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if the objective is completed")]
[Name("ObjectiveCompleted", 0)]
[Token(Token = "0x2001135")]
public class Condition_ObjectiveCompleted : ConditionTask
{
	[Token(Token = "0x400879D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x170008F3")]
	protected override string info
	{
		[Token(Token = "0x6007429")]
		[Address(RVA = "0x10F9EF0", Offset = "0x10F8CF0", Length = "0x1E3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600742A")]
	[Address(RVA = "0x10FA0E0", Offset = "0x10F8EE0", Length = "0x147")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600742B")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ObjectiveCompleted()
	{
	}
}
