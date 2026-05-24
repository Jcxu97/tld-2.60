using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Player Panel Activation", 0)]
[Description("Sets if the player can activate panels (UI)")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011FB")]
public class Action_TogglePanelActivation : ActionTask
{
	[Token(Token = "0x4008972")]
	[FieldOffset(Offset = "0x68")]
	public bool allowActivation;

	[Token(Token = "0x17000974")]
	protected override string info
	{
		[Token(Token = "0x60076C1")]
		[Address(RVA = "0x114E540", Offset = "0x114D340", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076C2")]
	[Address(RVA = "0x114E5A0", Offset = "0x114D3A0", Length = "0x12F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076C3")]
	[Address(RVA = "0x11185E0", Offset = "0x11173E0", Length = "0xC")]
	public Action_TogglePanelActivation()
	{
	}
}
