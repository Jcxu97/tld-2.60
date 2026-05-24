using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Stop Ringing", 0)]
[Description("Set Phone State To Not Ringing")]
[Category("TLD Actions/Phone")]
[Token(Token = "0x20011F1")]
public class Action_PhoneStopRinging : ActionTask
{
	[Token(Token = "0x400895F")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x60076A9")]
	[Address(RVA = "0x114C5F0", Offset = "0x114B3F0", Length = "0x26")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076AA")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PhoneStopRinging()
	{
	}
}
