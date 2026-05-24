using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.Playables;

namespace NodeCanvas.Tasks.Actions;

[Token(Token = "0x2001230")]
public abstract class Action_PlayTimeline : Action_Timeline
{
	[Token(Token = "0x4008A23")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> m_SkipDisableCrouch;

	[Token(Token = "0x4008A24")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<Animator> m_BindingAnimator;

	[Token(Token = "0x4008A25")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<string> m_BindingTrackName;

	[Token(Token = "0x4008A26")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<GameObject> m_SyncBone;

	[Token(Token = "0x4008A27")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<DirectorWrapMode> m_WrapMode;

	[Token(Token = "0x4008A28")]
	[FieldOffset(Offset = "0x98")]
	public BBParameter<float> m_TimeToSyncPlayerToSyncBone;

	[Token(Token = "0x4008A29")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<float> m_TimeToTransitionOut;

	[Token(Token = "0x4008A2A")]
	[FieldOffset(Offset = "0xA8")]
	public BBParameter<float> m_DesiredFov;

	[Token(Token = "0x4008A2B")]
	[FieldOffset(Offset = "0xB0")]
	public BBParameter<bool> m_UnloadAfterPlay;

	[Token(Token = "0x4008A2C")]
	[FieldOffset(Offset = "0xB8")]
	public BBParameter<TLD_TimelineDirector.PlayerTimelineFlags> m_PlayerTimelineFlags;

	[Token(Token = "0x4008A2D")]
	[FieldOffset(Offset = "0xC0")]
	protected TimelinePlayback.TimelineInfo m_TimelineInfo;

	[Token(Token = "0x600775B")]
	[Address(RVA = "0x115AFD0", Offset = "0x1159DD0", Length = "0x7")]
	protected override void ExecuteTimelineAction()
	{
	}

	[Token(Token = "0x600775C")]
	[Address(RVA = "0x115AFE0", Offset = "0x1159DE0", Length = "0x3C8")]
	protected void BuildTimelineInfo()
	{
	}

	[Token(Token = "0x600775D")]
	[Address(RVA = "0x115B3B0", Offset = "0x115A1B0", Length = "0x130")]
	protected Action_PlayTimeline()
	{
	}
}
