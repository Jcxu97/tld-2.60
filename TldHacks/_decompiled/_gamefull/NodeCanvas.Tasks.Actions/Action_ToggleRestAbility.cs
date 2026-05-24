using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Allowed To Rest", 0)]
[Description("Allow or disallow ability for player to rest")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001200")]
public class Action_ToggleRestAbility : ActionTask
{
	[Token(Token = "0x4008984")]
	[FieldOffset(Offset = "0x68")]
	public bool shouldLock;

	[Token(Token = "0x4008985")]
	[FieldOffset(Offset = "0x70")]
	public string locIDToShow;

	[Token(Token = "0x17000976")]
	protected override string info
	{
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0x114FAB0", Offset = "0x114E8B0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076D1")]
	[Address(RVA = "0x114FB10", Offset = "0x114E910", Length = "0xD9")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076D2")]
	[Address(RVA = "0x114FBF0", Offset = "0x114E9F0", Length = "0x8E")]
	public Action_ToggleRestAbility()
	{
	}
}
