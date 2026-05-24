using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Video;

[Token(Token = "0x20005FA")]
public class MoviePlayer : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x20005FB")]
	public enum Options
	{
		[Token(Token = "0x4003734")]
		None = 0,
		[Token(Token = "0x4003735")]
		FillScreen = 1,
		[Token(Token = "0x4003736")]
		RenderGameplay = 2,
		[Token(Token = "0x4003737")]
		PlayAudio = 4,
		[Token(Token = "0x4003738")]
		SuppressErrors = 8,
		[Token(Token = "0x4003739")]
		WaitFirstFrame = 0x20,
		[Token(Token = "0x400373A")]
		NoUserInterrupt = 0x40,
		[Token(Token = "0x400373B")]
		PrepareMovieOnly = 0x80,
		[Token(Token = "0x400373C")]
		TryToUsePreparedMovie = 0x100,
		[Token(Token = "0x400373D")]
		DoNotSyncToAudio = 0x200,
		[Token(Token = "0x400373E")]
		DoNotStopAudio = 0x400
	}

	[Token(Token = "0x20005FC")]
	private enum State
	{
		[Token(Token = "0x4003740")]
		Stopped,
		[Token(Token = "0x4003741")]
		Preparing,
		[Token(Token = "0x4003742")]
		Playing,
		[Token(Token = "0x4003743")]
		Paused,
		[Token(Token = "0x4003744")]
		Stopping
	}

	[Token(Token = "0x20005FD")]
	public delegate void OnPlaybackComplete();

	[Token(Token = "0x4003718")]
	public static bool m_MovieInterrupted;

	[Token(Token = "0x4003719")]
	public static bool m_MovieCancelledWithEscape;

	[Token(Token = "0x400371A")]
	public static bool m_HasIntroPlayedForMainMenu;

	[Token(Token = "0x400371B")]
	private static string m_AudioEventName;

	[Token(Token = "0x400371C")]
	private static string m_Filename;

	[Token(Token = "0x400371D")]
	private static string m_FullPath;

	[Token(Token = "0x400371E")]
	private static Camera m_Camera;

	[Token(Token = "0x400371F")]
	private static State m_State;

	[Token(Token = "0x4003720")]
	private static State m_PrePauseState;

	[Token(Token = "0x4003721")]
	private static Options m_Options;

	[Token(Token = "0x4003722")]
	private static bool m_PlaybackFailed;

	[Token(Token = "0x4003723")]
	private static bool m_RestorePause;

	[Token(Token = "0x4003724")]
	private static bool m_RestoreAudio;

	[Token(Token = "0x4003725")]
	public static bool m_IsSkippable;

	[Token(Token = "0x4003726")]
	private static OnPlaybackComplete m_OnPlaybackComplete;

	[Token(Token = "0x4003727")]
	private static VideoPlayer m_Player;

	[Token(Token = "0x4003728")]
	private static readonly string SUBTITLE_EXTENSION;

	[Token(Token = "0x4003729")]
	private const int MAX_SUBTITLES = 100;

	[Token(Token = "0x400372A")]
	private static Utils.Subtitle[] m_Subtitles;

	[Token(Token = "0x400372B")]
	private static uint m_NumSubtitles;

	[Token(Token = "0x400372C")]
	private static uint m_SubtitleFrameRate;

	[Token(Token = "0x400372D")]
	private static string s_MoviePath;

	[Token(Token = "0x400372E")]
	private static string s_SubtitlesPath;

	[Token(Token = "0x400372F")]
	private static uint s_AudioPlayingID;

	[Token(Token = "0x4003730")]
	private static long m_LastFrameId;

	[Token(Token = "0x4003731")]
	private static Dictionary<string, string> s_FilePaths;

	[SerializeField]
	[Token(Token = "0x4003732")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_CameraPrefab;

	[Token(Token = "0x6002E21")]
	[Address(RVA = "0x95EE40", Offset = "0x95DC40", Length = "0x31")]
	internal static string GetPlatformName()
	{
		return null;
	}

	[Token(Token = "0x6002E22")]
	[Address(RVA = "0x95EE80", Offset = "0x95DC80", Length = "0x2D7")]
	public static string[] GetFilenameList()
	{
		return null;
	}

	[Token(Token = "0x6002E23")]
	[Address(RVA = "0x95F160", Offset = "0x95DF60", Length = "0x53")]
	public static uint GetAudioPlayingID()
	{
		return 0u;
	}

	[Token(Token = "0x6002E24")]
	[Address(RVA = "0x95F1C0", Offset = "0x95DFC0", Length = "0xB4")]
	public static string GetAudioEventFromFileName(string fileName)
	{
		return null;
	}

	[Token(Token = "0x6002E25")]
	[Address(RVA = "0x95F280", Offset = "0x95E080", Length = "0x333")]
	private static void SetupMovie(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath)
	{
	}

	[Token(Token = "0x6002E26")]
	[Address(RVA = "0x95F5C0", Offset = "0x95E3C0", Length = "0x17E")]
	private static string FindFullMoviePath(string filename)
	{
		return null;
	}

	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x95F740", Offset = "0x95E540", Length = "0x179")]
	public static bool TryToUsePreparedMovie(string fullpath, OnPlaybackComplete onPlaybackComplete, Options opts)
	{
		return false;
	}

	[Token(Token = "0x6002E28")]
	[Address(RVA = "0x95F8C0", Offset = "0x95E6C0", Length = "0xE6")]
	public static void Play(string filename, string audioEventName, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x95F9B0", Offset = "0x95E7B0", Length = "0x412")]
	public static void Play(string filename, OnPlaybackComplete onPlaybackComplete, Options opts = Options.None)
	{
	}

	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x95FDD0", Offset = "0x95EBD0", Length = "0x5CA")]
	public static void PlayMovieFromFullPath(OnPlaybackComplete onPlaybackComplete, Options opts, string fullpath, string filename)
	{
	}

	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x9603A0", Offset = "0x95F1A0", Length = "0xA2")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0x960450", Offset = "0x95F250", Length = "0x144")]
	public static float GetCurrentMovieDurationSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6002E2D")]
	[Address(RVA = "0x9605A0", Offset = "0x95F3A0", Length = "0x1BF")]
	public static bool IsPreparingPending()
	{
		return false;
	}

	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0x960760", Offset = "0x95F560", Length = "0x154")]
	public static bool IsPreparingReady()
	{
		return false;
	}

	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0x9608C0", Offset = "0x95F6C0", Length = "0x19D")]
	public static void Seek(float newTime)
	{
	}

	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x960A60", Offset = "0x95F860", Length = "0x1B7")]
	public static bool IsInitialized()
	{
		return false;
	}

	[Token(Token = "0x6002E31")]
	[Address(RVA = "0x960C20", Offset = "0x95FA20", Length = "0x7D")]
	public static bool IsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6002E32")]
	[Address(RVA = "0x960CA0", Offset = "0x95FAA0", Length = "0x57")]
	public static bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x6002E33")]
	[Address(RVA = "0x960D00", Offset = "0x95FB00", Length = "0x56")]
	public static bool IsScreenFilled()
	{
		return false;
	}

	[Token(Token = "0x6002E34")]
	[Address(RVA = "0x960D60", Offset = "0x95FB60", Length = "0x57")]
	public static bool IsGameplayRendering()
	{
		return false;
	}

	[Token(Token = "0x6002E35")]
	[Address(RVA = "0x960DC0", Offset = "0x95FBC0", Length = "0x57")]
	public static bool IsAudioEnabled()
	{
		return false;
	}

	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x960E20", Offset = "0x95FC20", Length = "0x57")]
	public static bool SuppressingErrors()
	{
		return false;
	}

	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x960E80", Offset = "0x95FC80", Length = "0x57")]
	public static bool ShouldWaitFirstFrame()
	{
		return false;
	}

	[Token(Token = "0x6002E38")]
	[Address(RVA = "0x960EE0", Offset = "0x95FCE0", Length = "0x5A")]
	public static bool ShouldPrepareMovieOnly()
	{
		return false;
	}

	[Token(Token = "0x6002E39")]
	[Address(RVA = "0x960F40", Offset = "0x95FD40", Length = "0x57")]
	public static bool HasNoUserInterrupt()
	{
		return false;
	}

	[Token(Token = "0x6002E3A")]
	[Address(RVA = "0x960FA0", Offset = "0x95FDA0", Length = "0xA")]
	public static bool ShouldTryToUsePreparedMovie(Options opts)
	{
		return false;
	}

	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x960FB0", Offset = "0x95FDB0", Length = "0x5A")]
	public static bool ShouldSyncToAudio()
	{
		return false;
	}

	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x961010", Offset = "0x95FE10", Length = "0x5A")]
	public static bool ShouldStopAudio()
	{
		return false;
	}

	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x961070", Offset = "0x95FE70", Length = "0x2C6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x961340", Offset = "0x960140", Length = "0x492")]
	private void Update()
	{
	}

	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x9617E0", Offset = "0x9605E0", Length = "0x25A")]
	private bool CheckForInterrupt()
	{
		return false;
	}

	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x961A40", Offset = "0x960840", Length = "0x1E8")]
	private void CheckForPause()
	{
	}

	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x961C30", Offset = "0x960A30", Length = "0x58C")]
	private static void DoStop()
	{
	}

	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x9621C0", Offset = "0x960FC0", Length = "0x82")]
	public static void StopAudio()
	{
	}

	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x962250", Offset = "0x961050", Length = "0x179")]
	private void UpdatePause()
	{
	}

	[Token(Token = "0x6002E44")]
	[Address(RVA = "0x9623D0", Offset = "0x9611D0", Length = "0x3BF")]
	private void UpdatePrepare()
	{
	}

	[Token(Token = "0x6002E45")]
	[Address(RVA = "0x962790", Offset = "0x961590", Length = "0x363")]
	private void UpdatePlayback()
	{
	}

	[Token(Token = "0x6002E46")]
	[Address(RVA = "0x962B00", Offset = "0x961900", Length = "0xE24")]
	private void InstantiateCameraForPlayer()
	{
	}

	[Token(Token = "0x6002E47")]
	[Address(RVA = "0x963930", Offset = "0x962730", Length = "0x154")]
	private static bool ShouldReplacePathEntry(FileInfo fi)
	{
		return false;
	}

	[Token(Token = "0x6002E48")]
	[Address(RVA = "0x963A90", Offset = "0x962890", Length = "0x44A")]
	private static void BuildPathDictionary()
	{
	}

	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x963EE0", Offset = "0x962CE0", Length = "0x8B")]
	private static void OnErrorReceived(VideoPlayer source, string message)
	{
	}

	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x963F70", Offset = "0x962D70", Length = "0x1AA")]
	private void OnLoopPointReached(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x964120", Offset = "0x962F20", Length = "0x5D")]
	private static void OnLoopPointReached()
	{
	}

	[Token(Token = "0x6002E4C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void LogError(string err)
	{
	}

	[Token(Token = "0x6002E4D")]
	[Address(RVA = "0x964180", Offset = "0x962F80", Length = "0x16D")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6002E4E")]
	[Address(RVA = "0x9642F0", Offset = "0x9630F0", Length = "0xE0")]
	private long GetCurrentFrame()
	{
		return 0L;
	}

	[Token(Token = "0x6002E4F")]
	[Address(RVA = "0x9643E0", Offset = "0x9631E0", Length = "0xE0")]
	private double GetCurrentFrameTime()
	{
		return 0.0;
	}

	[Token(Token = "0x6002E50")]
	[Address(RVA = "0x9644D0", Offset = "0x9632D0", Length = "0xE0")]
	private long GetLastFrame()
	{
		return 0L;
	}

	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MoviePlayer()
	{
	}
}
