using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Select Next Phone DT ", 0)]
[Description("Select the next Phone DT")]
[Category("TLD Actions/Phone")]
[Token(Token = "0x20011F2")]
public class Action_SelectNextPhoneDT : ActionTask
{
	[Token(Token = "0x4008960")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<DTContainer> dialogueTreeContainer;

	[Token(Token = "0x60076AB")]
	[Address(RVA = "0x114C620", Offset = "0x114B420", Length = "0x93")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076AC")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SelectNextPhoneDT()
	{
	}
}
