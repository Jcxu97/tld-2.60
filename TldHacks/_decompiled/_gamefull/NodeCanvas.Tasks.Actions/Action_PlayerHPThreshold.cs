using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Check Player HP Threshold", 0)]
[Description("Fires an event based on the player's HP.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011FE")]
public class Action_PlayerHPThreshold : ActionTask<GraphOwner>
{
	[Token(Token = "0x400897E")]
	[FieldOffset(Offset = "0x68")]
	public float hpThreshold;

	[Token(Token = "0x400897F")]
	[FieldOffset(Offset = "0x70")]
	public string aboveThresholdEvent;

	[Token(Token = "0x4008980")]
	[FieldOffset(Offset = "0x78")]
	public string belowThresholdEvent;

	[Token(Token = "0x60076CC")]
	[Address(RVA = "0x114F640", Offset = "0x114E440", Length = "0x112")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076CD")]
	[Address(RVA = "0x114F760", Offset = "0x114E560", Length = "0x108")]
	public Action_PlayerHPThreshold()
	{
	}
}
