using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if latest Bear Encounter was won.")]
[Name("Is Bear Encounter Won", 0)]
[Token(Token = "0x200115A")]
public class TLD_IsLatestBearEncounterWon : ConditionTask
{
	[Token(Token = "0x40087E1")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x6007495")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6007496")]
	[Address(RVA = "0x11012C0", Offset = "0x11000C0", Length = "0xC5")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007497")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_IsLatestBearEncounterWon()
	{
	}
}
