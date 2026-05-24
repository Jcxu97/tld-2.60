using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x200099C")]
public class TLD_FPHandsTrack : AnimationTrack, TLD_IDynamicBindableTrack, TLD_ITrack
{
	[Tooltip("Move the hands to the world positon for the during of this hands track (rather than being in 'weapon view')")]
	[Token(Token = "0x40062CA")]
	[FieldOffset(Offset = "0x130")]
	public bool m_CameraRelativeTransforms;

	[Token(Token = "0x40062CB")]
	[FieldOffset(Offset = "0x131")]
	public bool m_HoldSettingsForNextTimeline;

	[Token(Token = "0x40062CC")]
	[FieldOffset(Offset = "0x138")]
	private TLD_TimelineDirector m_TimelineDirector;

	[Token(Token = "0x40062CD")]
	[FieldOffset(Offset = "0x140")]
	private PlayerAnimation m_PlayerAnimation;

	[Token(Token = "0x60055C3")]
	[Address(RVA = "0xEA78D0", Offset = "0xEA66D0", Length = "0x220")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x60055C4")]
	[Address(RVA = "0xEA7B00", Offset = "0xEA6900", Length = "0x53")]
	public void Play()
	{
	}

	[Token(Token = "0x60055C5")]
	[Address(RVA = "0xEA7B60", Offset = "0xEA6960", Length = "0x20E")]
	public void RemoveBlending()
	{
	}

	[Token(Token = "0x60055C6")]
	[Address(RVA = "0xEA7D70", Offset = "0xEA6B70", Length = "0x44C")]
	public void UpdatePlay()
	{
	}

	[Token(Token = "0x60055C7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LateUpdatePlay()
	{
	}

	[Token(Token = "0x60055C8")]
	[Address(RVA = "0xEA81C0", Offset = "0xEA6FC0", Length = "0xDD")]
	public void Stop()
	{
	}

	[Token(Token = "0x60055C9")]
	[Address(RVA = "0xEA82A0", Offset = "0xEA70A0", Length = "0x2FE")]
	public static void ResetFPHands()
	{
	}

	[Token(Token = "0x60055CA")]
	[Address(RVA = "0xEA85A0", Offset = "0xEA73A0", Length = "0x4E")]
	public TLD_FPHandsTrack()
	{
	}
}
