using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if Bear Encounter is a final one.")]
[Name("Is Bear Encounter Last", 0)]
[Token(Token = "0x200115C")]
public class TLD_IsBearEncounterLast : ConditionTask
{
	[Token(Token = "0x40087E3")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x600749B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600749C")]
	[Address(RVA = "0x1101460", Offset = "0x1100260", Length = "0xC2")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600749D")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_IsBearEncounterLast()
	{
	}
}
