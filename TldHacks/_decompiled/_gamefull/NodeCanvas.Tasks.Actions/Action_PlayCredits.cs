using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("PlayCredits", 0)]
[Category("TLD Actions")]
[Token(Token = "0x20011D6")]
public class Action_PlayCredits : ActionTask
{
	[Serializable]
	[Token(Token = "0x20011D7")]
	public class VideoDefinition
	{
		[Token(Token = "0x4008923")]
		[FieldOffset(Offset = "0x10")]
		public string m_VideoName;

		[Token(Token = "0x4008924")]
		[FieldOffset(Offset = "0x18")]
		public string m_AudioEventName;

		[Token(Token = "0x6007661")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public VideoDefinition()
		{
		}
	}

	[Token(Token = "0x4008916")]
	[FieldOffset(Offset = "0x68")]
	public int m_EpisodeIndex;

	[Token(Token = "0x4008917")]
	[FieldOffset(Offset = "0x70")]
	public VideoDefinition[] m_Videos;

	[Token(Token = "0x4008918")]
	[FieldOffset(Offset = "0x78")]
	public bool m_ContinueMusicFromVideo;

	[Token(Token = "0x4008919")]
	[FieldOffset(Offset = "0x7C")]
	public int m_MusicStartOffsetMs;

	[Token(Token = "0x400891A")]
	[FieldOffset(Offset = "0x80")]
	public bool stopAllPlayerAudio;

	[Token(Token = "0x400891B")]
	[FieldOffset(Offset = "0x81")]
	public bool fade;

	[Token(Token = "0x400891C")]
	[FieldOffset(Offset = "0x84")]
	public float fadeSeconds;

	[Tooltip("DO NOT USE THIS! This is only here because of the legacy setup for the end of Episode 1.")]
	[Token(Token = "0x400891D")]
	[FieldOffset(Offset = "0x88")]
	public bool legacyAdjustHUDAlpha;

	[Token(Token = "0x400891E")]
	[FieldOffset(Offset = "0x89")]
	private bool m_QuitToMainMenu;

	[Token(Token = "0x400891F")]
	[FieldOffset(Offset = "0x8C")]
	private int m_CurrentVideoIndex;

	[Token(Token = "0x4008920")]
	[FieldOffset(Offset = "0x90")]
	private string m_MusicID;

	[Token(Token = "0x4008921")]
	[FieldOffset(Offset = "0x98")]
	private int m_MusicStartOffset;

	[Token(Token = "0x4008922")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_MusicPlayingID;

	[Token(Token = "0x17000965")]
	protected override string info
	{
		[Token(Token = "0x6007659")]
		[Address(RVA = "0x1145530", Offset = "0x1144330", Length = "0x3A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600765A")]
	[Address(RVA = "0x11458E0", Offset = "0x11446E0", Length = "0x164")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600765B")]
	[Address(RVA = "0x1145A50", Offset = "0x1144850", Length = "0x2F6")]
	private void PlayNextSkippableMovie()
	{
	}

	[Token(Token = "0x600765C")]
	[Address(RVA = "0x1145D50", Offset = "0x1144B50", Length = "0x1F1")]
	private void OnMovieStop()
	{
	}

	[Token(Token = "0x600765D")]
	[Address(RVA = "0x1145F50", Offset = "0x1144D50", Length = "0x2BE")]
	private void PlayCredits()
	{
	}

	[Token(Token = "0x600765E")]
	[Address(RVA = "0x1146210", Offset = "0x1145010", Length = "0x1B7")]
	private void OnCreditsEnd()
	{
	}

	[Token(Token = "0x600765F")]
	[Address(RVA = "0x11463D0", Offset = "0x11451D0", Length = "0x123")]
	private void OnActionComplete()
	{
	}

	[Token(Token = "0x6007660")]
	[Address(RVA = "0x1146500", Offset = "0x1145300", Length = "0x1F")]
	public Action_PlayCredits()
	{
	}
}
