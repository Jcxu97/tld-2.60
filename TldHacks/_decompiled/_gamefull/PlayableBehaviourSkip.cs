using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x200098D")]
public class PlayableBehaviourSkip : PlayableBehaviour
{
	[Token(Token = "0x200098E")]
	private struct SkipInfo
	{
		[Token(Token = "0x4006263")]
		[FieldOffset(Offset = "0x0")]
		public float m_SkipTime;

		[Token(Token = "0x4006264")]
		[FieldOffset(Offset = "0x8")]
		public TimelineClip m_Clip;

		[Token(Token = "0x4006265")]
		[FieldOffset(Offset = "0x10")]
		public bool m_HasFoundValue;
	}

	[Token(Token = "0x4006260")]
	[FieldOffset(Offset = "0x10")]
	public List<TimelineClip> m_SkipableClips;

	[Token(Token = "0x4006261")]
	[FieldOffset(Offset = "0x18")]
	public bool m_CanSkip;

	[Token(Token = "0x4006262")]
	public static bool s_ForceSkipEnabled;

	[Token(Token = "0x6005576")]
	[Address(RVA = "0xE9CF30", Offset = "0xE9BD30", Length = "0x312")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005577")]
	[Address(RVA = "0xE9D250", Offset = "0xE9C050", Length = "0x31")]
	private float GetNextSkipTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6005578")]
	[Address(RVA = "0xE9D290", Offset = "0xE9C090", Length = "0x383")]
	public float GetNextEndOrStartTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6005579")]
	[Address(RVA = "0xE9D620", Offset = "0xE9C420", Length = "0x174")]
	private bool CanOverrideValue(TimelineClip clip, SkipInfo skipInfo, float time)
	{
		return false;
	}

	[Token(Token = "0x600557A")]
	[Address(RVA = "0xE9D7A0", Offset = "0xE9C5A0", Length = "0xB1")]
	public PlayableBehaviourSkip()
	{
	}
}
