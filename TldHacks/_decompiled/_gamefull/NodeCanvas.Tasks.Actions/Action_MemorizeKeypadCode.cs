using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Memorize Keypad Code", 0)]
[Description("Add Code to Player Memory")]
[Category("TLD Actions/Keypad")]
[Token(Token = "0x20011E1")]
public class Action_MemorizeKeypadCode : ActionTask
{
	[Token(Token = "0x400893D")]
	[FieldOffset(Offset = "0x68")]
	public int code;

	[Token(Token = "0x6007679")]
	[Address(RVA = "0x11489F0", Offset = "0x11477F0", Length = "0x170")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600767A")]
	[Address(RVA = "0x1148B70", Offset = "0x1147970", Length = "0x159")]
	private void DoWork()
	{
	}

	[Token(Token = "0x600767B")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_MemorizeKeypadCode()
	{
	}
}
