using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Check Playtime Hours", 0)]
[Description("Fires an event based on the player's playtime.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011FF")]
public class Action_PlayerHoursPlayed : ActionTask<GraphOwner>
{
	[Token(Token = "0x4008981")]
	[FieldOffset(Offset = "0x68")]
	public float timeThreshold;

	[Token(Token = "0x4008982")]
	[FieldOffset(Offset = "0x70")]
	public string aboveThresholdEvent;

	[Token(Token = "0x4008983")]
	[FieldOffset(Offset = "0x78")]
	public string belowThresholdEvent;

	[Token(Token = "0x60076CE")]
	[Address(RVA = "0x114F870", Offset = "0x114E670", Length = "0x12D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076CF")]
	[Address(RVA = "0x114F9A0", Offset = "0x114E7A0", Length = "0x108")]
	public Action_PlayerHoursPlayed()
	{
	}
}
