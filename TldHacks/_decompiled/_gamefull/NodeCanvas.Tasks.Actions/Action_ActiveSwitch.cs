using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Active Index", 0)]
[Description("Set which index is active in an Active Switch")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x20011A1")]
public class Action_ActiveSwitch : ActionTask
{
	[Token(Token = "0x4008893")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x4008894")]
	[FieldOffset(Offset = "0x70")]
	public int activeIndex;

	[Token(Token = "0x60075C3")]
	[Address(RVA = "0x1110EA0", Offset = "0x110FCA0", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075C4")]
	[Address(RVA = "0x1110ED0", Offset = "0x110FCD0", Length = "0x1ED")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075C5")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ActiveSwitch()
	{
	}
}
