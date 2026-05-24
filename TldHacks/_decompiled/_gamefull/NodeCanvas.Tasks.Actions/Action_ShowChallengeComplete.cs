using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Show Challenge Complete Screen", 0)]
[Description("Bring up Panel_ChallengeComplete screen")]
[Category("TLD Actions/Challenge")]
[Token(Token = "0x20011C9")]
public class Action_ShowChallengeComplete : ActionTask
{
	[Token(Token = "0x40088F3")]
	[FieldOffset(Offset = "0x68")]
	public bool succeededChallenge;

	[Token(Token = "0x40088F4")]
	[FieldOffset(Offset = "0x69")]
	public bool showToBeContinued;

	[Token(Token = "0x40088F5")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> showFailTimeSurvived;

	[Token(Token = "0x40088F6")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> showFailStatInfo;

	[Token(Token = "0x40088F7")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<string> failStatInfoLocId;

	[Token(Token = "0x40088F8")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<string> stat1Marker;

	[Token(Token = "0x40088F9")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<int> stat1Value;

	[Token(Token = "0x40088FA")]
	[FieldOffset(Offset = "0x98")]
	public BBParameter<string> stat2Marker;

	[Token(Token = "0x40088FB")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<int> stat2Value;

	[Token(Token = "0x6007634")]
	[Address(RVA = "0x11193B0", Offset = "0x11181B0", Length = "0x210")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007635")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ShowChallengeComplete()
	{
	}
}
