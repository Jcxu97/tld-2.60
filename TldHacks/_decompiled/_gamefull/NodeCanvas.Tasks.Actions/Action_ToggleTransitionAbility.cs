using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Allowed To Scene Transition", 0)]
[Description("Allow or disallow ability for player to transition scenes")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001201")]
public class Action_ToggleTransitionAbility : ActionTask
{
	[Token(Token = "0x4008986")]
	[FieldOffset(Offset = "0x68")]
	public bool shouldLock;

	[Token(Token = "0x4008987")]
	[FieldOffset(Offset = "0x70")]
	public string locIDToShow;

	[Token(Token = "0x17000977")]
	protected override string info
	{
		[Token(Token = "0x60076D3")]
		[Address(RVA = "0x114FC80", Offset = "0x114EA80", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076D4")]
	[Address(RVA = "0x114FCE0", Offset = "0x114EAE0", Length = "0xD9")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076D5")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ToggleTransitionAbility()
	{
	}
}
