using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20006D7")]
public class SubtitleSpeakerMapping
{
	[Token(Token = "0x40048D4")]
	[FieldOffset(Offset = "0x10")]
	public string m_SpeakerID;

	[Token(Token = "0x40048D5")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_SpeakerName;

	[Token(Token = "0x40048D6")]
	[FieldOffset(Offset = "0x20")]
	public Color m_SpeakerTextColor;

	[Token(Token = "0x40048D7")]
	[FieldOffset(Offset = "0x30")]
	public bool m_OverrideSpeakerColor;

	[Token(Token = "0x40048D8")]
	[FieldOffset(Offset = "0x34")]
	public Color m_SpeakerNameColor;

	[Token(Token = "0x6003C24")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SubtitleSpeakerMapping()
	{
	}
}
