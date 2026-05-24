using System;
using Cpp2ILInjected;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x2000983")]
public class PlayableBehaviourChangeTOD : PlayableBehaviour
{
	[Token(Token = "0x4006221")]
	[FieldOffset(Offset = "0x10")]
	public string m_OptionalStartTOD;

	[Token(Token = "0x4006222")]
	[FieldOffset(Offset = "0x18")]
	public string m_TargetTOD;

	[Token(Token = "0x4006223")]
	[FieldOffset(Offset = "0x20")]
	public bool m_Instant;

	[Token(Token = "0x4006224")]
	[FieldOffset(Offset = "0x21")]
	private bool m_HasValidTOD;

	[Token(Token = "0x4006225")]
	[FieldOffset(Offset = "0x24")]
	private float m_NormalizedStartTOD;

	[Token(Token = "0x4006226")]
	[FieldOffset(Offset = "0x28")]
	private float m_NormalizedTargetTOD;

	[Token(Token = "0x4006227")]
	[FieldOffset(Offset = "0x30")]
	private TimeOfDay m_TimeOfDay;

	[Token(Token = "0x6005545")]
	[Address(RVA = "0xE98AA0", Offset = "0xE978A0", Length = "0x232")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005546")]
	[Address(RVA = "0xE98CE0", Offset = "0xE97AE0", Length = "0xED")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005547")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourChangeTOD()
	{
	}
}
