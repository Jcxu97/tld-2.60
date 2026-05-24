using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Play Timeline On Target", 0)]
[Category("TLD Actions/Timeline")]
[Token(Token = "0x2001232")]
public class Action_PlayTimelineOnTarget : Action_PlayTimeline
{
	[Token(Token = "0x4008A30")]
	[FieldOffset(Offset = "0xC8")]
	public BBParameter<GameObject> m_Target;

	[Token(Token = "0x4008A31")]
	[FieldOffset(Offset = "0xD0")]
	public BBParameter<string> m_MissionIdentifierTarget;

	[Token(Token = "0x17000986")]
	protected override string TimelineActionName
	{
		[Token(Token = "0x6007762")]
		[Address(RVA = "0x115B840", Offset = "0x115A640", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007763")]
	[Address(RVA = "0x115B880", Offset = "0x115A680", Length = "0x228")]
	protected override void ExecuteTimelineAction()
	{
	}

	[Token(Token = "0x6007764")]
	[Address(RVA = "0x115BAB0", Offset = "0x115A8B0", Length = "0x1FB")]
	private TimelinePlayback GetTimelinePlayback()
	{
		return null;
	}

	[Token(Token = "0x6007765")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void OnTimelineComplete()
	{
	}

	[Token(Token = "0x6007766")]
	[Address(RVA = "0x115BCB0", Offset = "0x115AAB0", Length = "0x7")]
	public Action_PlayTimelineOnTarget()
	{
	}
}
