using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Reset Phone DT sequence", 0)]
[Description("Reset the Phone DT index to 0")]
[Category("TLD Actions/Phone")]
[Token(Token = "0x20011F3")]
public class Action_ResetPhoneDT : ActionTask
{
	[Token(Token = "0x4008961")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<DTContainer> dialogueTreeContainer;

	[Token(Token = "0x60076AD")]
	[Address(RVA = "0x114C6C0", Offset = "0x114B4C0", Length = "0x17B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076AE")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ResetPhoneDT()
	{
	}
}
