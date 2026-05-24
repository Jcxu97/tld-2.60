using System;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Audio.Migration;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007D6")]
public class ExploreMusic
{
	[AudioEventMigratedString("m_AudioID")]
	[Token(Token = "0x4005412")]
	[FieldOffset(Offset = "0x10")]
	public AK.Wwise.Event m_Event;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x4005413")]
	[FieldOffset(Offset = "0x18")]
	public string m_AudioID;

	[Token(Token = "0x4005414")]
	[FieldOffset(Offset = "0x20")]
	public ExploreMusicTime m_TimeToPlay;

	[Token(Token = "0x6004A13")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ExploreMusic()
	{
	}
}
