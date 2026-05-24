using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Start Ringing", 0)]
[Description("Set Phone State To Ringing")]
[Category("TLD Actions/Phone")]
[Token(Token = "0x20011F0")]
public class Action_PhoneStartRinging : ActionTask
{
	[Token(Token = "0x400895E")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x60076A7")]
	[Address(RVA = "0x114C5C0", Offset = "0x114B3C0", Length = "0x26")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076A8")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PhoneStartRinging()
	{
	}
}
