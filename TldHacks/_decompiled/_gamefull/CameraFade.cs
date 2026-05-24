using System;
using Cpp2ILInjected;
using TLD.Logging;

[Token(Token = "0x20009F3")]
public static class CameraFade
{
	[Token(Token = "0x4006534")]
	private const float FADE_OUT_THRESHOLD = 0.8f;

	[Token(Token = "0x4006535")]
	private const float FADE_IN_THRESHOLD = 0.2f;

	[Token(Token = "0x4006536")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4006539")]
	private static float m_FadeTimer;

	[Token(Token = "0x400653A")]
	private static float m_FadeDuration;

	[Token(Token = "0x400653B")]
	private static float m_StartAlpha;

	[Token(Token = "0x400653C")]
	private static float m_TargetAlpha;

	[Token(Token = "0x400653D")]
	private static Action m_OnFadeFinished;

	[Token(Token = "0x17000385")]
	[field: Token(Token = "0x4006537")]
	public static bool IsFading
	{
		[Token(Token = "0x6005799")]
		[Address(RVA = "0xED6660", Offset = "0xED5460", Length = "0x54")]
		get;
		[Token(Token = "0x600579A")]
		[Address(RVA = "0xED66C0", Offset = "0xED54C0", Length = "0x59")]
		private set;
	}

	[Token(Token = "0x17000386")]
	public static bool IsFadingIn
	{
		[Token(Token = "0x600579B")]
		[Address(RVA = "0xED6720", Offset = "0xED5520", Length = "0xC2")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000387")]
	public static bool IsFadingOut
	{
		[Token(Token = "0x600579C")]
		[Address(RVA = "0xED67F0", Offset = "0xED55F0", Length = "0xC2")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000388")]
	[field: Token(Token = "0x4006538")]
	public static float CurrentAlpha
	{
		[Token(Token = "0x600579D")]
		[Address(RVA = "0xED68C0", Offset = "0xED56C0", Length = "0x55")]
		get;
		[Token(Token = "0x600579E")]
		[Address(RVA = "0xED6920", Offset = "0xED5720", Length = "0x62")]
		private set;
	}

	[Token(Token = "0x17000389")]
	public static bool IsFadedOut
	{
		[Token(Token = "0x600579F")]
		[Address(RVA = "0xED6990", Offset = "0xED5790", Length = "0x92")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700038A")]
	public static bool IsFadedIn
	{
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0xED6A30", Offset = "0xED5830", Length = "0x92")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60057A1")]
	[Address(RVA = "0xED6AD0", Offset = "0xED58D0", Length = "0x83")]
	public static void FadeIn(float time, float delay = 0f, Action onFadeFinished = null)
	{
	}

	[Token(Token = "0x60057A2")]
	[Address(RVA = "0xED6B60", Offset = "0xED5960", Length = "0x83")]
	public static void FadeOut(float time, float delay = 0f, Action onFadeFinished = null)
	{
	}

	[Token(Token = "0x60057A3")]
	[Address(RVA = "0xED6BF0", Offset = "0xED59F0", Length = "0xD5")]
	public static void FadeTo(float targetAlpha, float time, float delay = 0f, Action onFadeFinished = null)
	{
	}

	[Token(Token = "0x60057A4")]
	[Address(RVA = "0xED6CD0", Offset = "0xED5AD0", Length = "0x398")]
	public static void Fade(float startAlpha, float targetAlpha, float time, float delay = 0f, Action onFadeFinished = null)
	{
	}

	[Token(Token = "0x60057A5")]
	[Address(RVA = "0xED7070", Offset = "0xED5E70", Length = "0x1F6")]
	public static void UpdateCameraFade()
	{
	}

	[Token(Token = "0x60057A6")]
	[Address(RVA = "0xED7270", Offset = "0xED6070", Length = "0x13E")]
	public static void FinishFade(bool skipToEnd = false)
	{
	}
}
