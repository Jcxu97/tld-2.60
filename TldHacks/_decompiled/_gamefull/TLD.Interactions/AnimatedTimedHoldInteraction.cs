using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

namespace TLD.Interactions;

[Token(Token = "0x200139C")]
public class AnimatedTimedHoldInteraction : TimedHoldInteraction
{
	[Header("Animation")]
	[SerializeField]
	[Token(Token = "0x4008FDF")]
	[FieldOffset(Offset = "0x68")]
	private TimelinePlayback m_TimelinePlayback;

	[SerializeField]
	[Token(Token = "0x4008FE0")]
	[FieldOffset(Offset = "0x70")]
	private TimelinePlayback.TimelineInfo m_TimelineInfo;

	[Header("Directional Animations")]
	[Tooltip("Enables support for playing a different animation based on the direction that the player approaches the interaction")]
	[SerializeField]
	[Token(Token = "0x4008FE1")]
	[FieldOffset(Offset = "0x78")]
	private bool m_EnableDirectionalAnimations;

	[SerializeField]
	[Token(Token = "0x4008FE2")]
	[FieldOffset(Offset = "0x79")]
	private bool m_UseDefaultIfNoDirectional;

	[SerializeField]
	[Token(Token = "0x4008FE3")]
	[FieldOffset(Offset = "0x80")]
	private List<DirectionalInfluenceMapping<TimelinePlayback.TimelineInfo>> m_DirectionalInfo;

	[Token(Token = "0x4008FE4")]
	[FieldOffset(Offset = "0x88")]
	private bool m_PlayingTimeline;

	[Token(Token = "0x17000A98")]
	public override bool CanInteract
	{
		[Token(Token = "0x6007D33")]
		[Address(RVA = "0x11C5F30", Offset = "0x11C4D30", Length = "0x57")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007D34")]
	[Address(RVA = "0x11C5F90", Offset = "0x11C4D90", Length = "0x396")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6007D35")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnAnimatedInteractionBegin()
	{
	}

	[Token(Token = "0x6007D36")]
	[Address(RVA = "0x10B1C30", Offset = "0x10B0A30", Length = "0x8")]
	protected virtual void OnAnimatedInteractionEnd()
	{
	}

	[Token(Token = "0x6007D37")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public AnimatedTimedHoldInteraction()
	{
	}
}
