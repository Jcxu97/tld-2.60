using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Non-Movement Input", 0)]
[Description("Toggle non-movement input in preparation for Panel_ChallengeComplete screen")]
[Category("TLD Actions/Challenge")]
[Token(Token = "0x20011CA")]
public class Action_BlockNonMovementInput : ActionTask
{
	[Token(Token = "0x40088FC")]
	[FieldOffset(Offset = "0x68")]
	public bool canDoInput;

	[Token(Token = "0x17000960")]
	protected override string info
	{
		[Token(Token = "0x6007636")]
		[Address(RVA = "0x11195D0", Offset = "0x11183D0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007637")]
	[Address(RVA = "0x1119630", Offset = "0x1118430", Length = "0x78")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007638")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_BlockNonMovementInput()
	{
	}
}
