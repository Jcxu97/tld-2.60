using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005C9")]
public class CaptureScreenTransition
{
	[Token(Token = "0x400356D")]
	[FieldOffset(Offset = "0x10")]
	private bool m_CaptureFadeOutCompleted;

	[Token(Token = "0x400356E")]
	[FieldOffset(Offset = "0x11")]
	private bool m_HasRequestedCapture;

	[Token(Token = "0x400356F")]
	[FieldOffset(Offset = "0x12")]
	private bool m_HasStartedCapture;

	[Token(Token = "0x4003570")]
	[FieldOffset(Offset = "0x13")]
	private bool m_HasStartedFadeout;

	[Token(Token = "0x4003571")]
	[FieldOffset(Offset = "0x14")]
	private bool m_HasCaptured;

	[Token(Token = "0x4003572")]
	[FieldOffset(Offset = "0x18")]
	private Action m_OnCaptureFinish;

	[Token(Token = "0x4003573")]
	[FieldOffset(Offset = "0x20")]
	private bool m_UseCaptureFading;

	[Token(Token = "0x4003574")]
	private static Texture2D m_ScreenCaptureTexture;

	[Token(Token = "0x6002CCE")]
	[Address(RVA = "0x93C5B0", Offset = "0x93B3B0", Length = "0x5E")]
	public void StartCapture(Action OnCaptureFinish)
	{
	}

	[Token(Token = "0x6002CCF")]
	[Address(RVA = "0x93C610", Offset = "0x93B410", Length = "0x35")]
	public void UpdateCapture()
	{
	}

	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
	public bool HasFadeoutCaptureCompleted()
	{
		return false;
	}

	[Token(Token = "0x6002CD1")]
	[Address(RVA = "0x93C650", Offset = "0x93B450", Length = "0xCD")]
	public void StartCaptureFadeOut(UISprite background)
	{
	}

	[Token(Token = "0x6002CD2")]
	[Address(RVA = "0x93C720", Offset = "0x93B520", Length = "0x129")]
	public void DoCaptureScreen()
	{
	}

	[Token(Token = "0x6002CD3")]
	[Address(RVA = "0x93C850", Offset = "0x93B650", Length = "0x17")]
	public bool ShouldCaptureScreen()
	{
		return false;
	}

	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x93C870", Offset = "0x93B670", Length = "0x161")]
	public void OnFadeoutCompleted()
	{
	}

	[Token(Token = "0x6002CD5")]
	[Address(RVA = "0x93C9E0", Offset = "0x93B7E0", Length = "0x1F")]
	public void OnDisable(UISprite background)
	{
	}

	[Token(Token = "0x6002CD6")]
	[Address(RVA = "0x93CA00", Offset = "0x93B800", Length = "0x5")]
	public void CaptureStarted()
	{
	}

	[Token(Token = "0x6002CD7")]
	[Address(RVA = "0x93CA10", Offset = "0x93B810", Length = "0xEB")]
	public void MaybeStartCaptureFadeOut(UISprite background)
	{
	}

	[Token(Token = "0x6002CD8")]
	[Address(RVA = "0x93CB00", Offset = "0x93B900", Length = "0x1ED")]
	public void OnUpdate(UISprite background, GameObject loadingAnimation)
	{
	}

	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x93CCF0", Offset = "0x93BAF0", Length = "0x97")]
	private void ResetBackgrounds(UISprite backround)
	{
	}

	[Token(Token = "0x6002CDA")]
	[Address(RVA = "0x93CD90", Offset = "0x93BB90", Length = "0xF")]
	public void MaybeResetBackgrounds(UISprite background)
	{
	}

	[Token(Token = "0x6002CDB")]
	[Address(RVA = "0x93CDA0", Offset = "0x93BBA0", Length = "0xF")]
	public void MaybeInitFadeOut(UISprite background, GameObject loadingAnimation)
	{
	}

	[Token(Token = "0x6002CDC")]
	[Address(RVA = "0x93CDB0", Offset = "0x93BBB0", Length = "0x11")]
	public bool IsCaptureFadingInProgress()
	{
		return false;
	}

	[Token(Token = "0x6002CDD")]
	[Address(RVA = "0x93CDD0", Offset = "0x93BBD0", Length = "0x108")]
	public void MaybeEnableAnimationLoading(GameObject loadingAnimation)
	{
	}

	[Token(Token = "0x6002CDE")]
	[Address(RVA = "0x93CEE0", Offset = "0x93BCE0", Length = "0x2E")]
	private void SetTweenAlpha(TweenAlpha tweenAlpha, float from, float to, float duration)
	{
	}

	[Token(Token = "0x6002CDF")]
	[Address(RVA = "0x93CF10", Offset = "0x93BD10", Length = "0xE3")]
	private void InitBackgroundTweenAlpha(UISprite background, float currentAlpha)
	{
	}

	[Token(Token = "0x6002CE0")]
	[Address(RVA = "0x93D000", Offset = "0x93BE00", Length = "0x28C")]
	private void InitFadeOutCapture(UISprite background, GameObject loadingAnimation)
	{
	}

	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
	private bool IsCaptureFading()
	{
		return false;
	}

	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x93D290", Offset = "0x93C090", Length = "0xE7")]
	private static void SetBackgroundAlpha(UIWidget widget, float alpha)
	{
	}

	[Token(Token = "0x6002CE3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CaptureScreenTransition()
	{
	}
}
