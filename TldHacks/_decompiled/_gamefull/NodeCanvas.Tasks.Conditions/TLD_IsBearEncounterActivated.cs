using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if Bear Encounter has been activated.")]
[Name("Is Bear Encounter Activated", 0)]
[Token(Token = "0x200115B")]
public class TLD_IsBearEncounterActivated : ConditionTask
{
	[Token(Token = "0x40087E2")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x6007498")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6007499")]
	[Address(RVA = "0x1101390", Offset = "0x1100190", Length = "0xC2")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600749A")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_IsBearEncounterActivated()
	{
	}
}
