using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Phone")]
[Description("Check if Player has completed all conversations from a Phone sequence.")]
[Name("Is Phone Sequence Complete", 0)]
[Token(Token = "0x200115F")]
public class TLD_IsSequenceComplete : ConditionTask
{
	[Token(Token = "0x40087EB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<DTContainer> dialogueTreeContainer;

	[Token(Token = "0x17000911")]
	protected override string info
	{
		[Token(Token = "0x60074A4")]
		[Address(RVA = "0x1101B50", Offset = "0x1100950", Length = "0x171")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074A5")]
	[Address(RVA = "0x1101CD0", Offset = "0x1100AD0", Length = "0x193")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074A6")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_IsSequenceComplete()
	{
	}
}
