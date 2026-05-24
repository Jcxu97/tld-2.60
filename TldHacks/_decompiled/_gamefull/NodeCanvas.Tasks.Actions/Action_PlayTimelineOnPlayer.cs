using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Play Timeline On Player", 0)]
[Category("TLD Actions/Timeline")]
[Token(Token = "0x2001231")]
public class Action_PlayTimelineOnPlayer : Action_PlayTimeline
{
	[Token(Token = "0x4008A2E")]
	[FieldOffset(Offset = "0xC8")]
	public BBParameter<bool> m_ShouldStowItemInHands;

	[Token(Token = "0x4008A2F")]
	[FieldOffset(Offset = "0xD0")]
	public BBParameter<PlayerControlMode> m_PlayerControlMode;

	[Token(Token = "0x17000985")]
	protected override string TimelineActionName
	{
		[Token(Token = "0x600775E")]
		[Address(RVA = "0x115B4E0", Offset = "0x115A2E0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600775F")]
	[Address(RVA = "0x115B520", Offset = "0x115A320", Length = "0x1E3")]
	protected override void ExecuteTimelineAction()
	{
	}

	[Token(Token = "0x6007760")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void OnTimelineComplete()
	{
	}

	[Token(Token = "0x6007761")]
	[Address(RVA = "0x115B710", Offset = "0x115A510", Length = "0x122")]
	public Action_PlayTimelineOnPlayer()
	{
	}
}
