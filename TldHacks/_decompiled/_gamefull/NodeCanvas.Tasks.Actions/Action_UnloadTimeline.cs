using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unload Timeline", 0)]
[Category("TLD Actions/Timeline")]
[Token(Token = "0x200122E")]
public class Action_UnloadTimeline : Action_Timeline
{
	[Token(Token = "0x17000983")]
	protected override string TimelineActionName
	{
		[Token(Token = "0x6007754")]
		[Address(RVA = "0x115AE40", Offset = "0x1159C40", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007755")]
	[Address(RVA = "0x115AE80", Offset = "0x1159C80", Length = "0x27")]
	protected override void ExecuteTimelineAction()
	{
	}

	[Token(Token = "0x6007756")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnloadTimeline()
	{
	}
}
