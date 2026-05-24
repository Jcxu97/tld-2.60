using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("PlayVideo", 0)]
[Category("TLD Actions")]
[Token(Token = "0x200127E")]
public class Action_PlayVideo : ActionTask
{
	[Token(Token = "0x4008B0C")]
	[FieldOffset(Offset = "0x68")]
	public bool waitForComplete;

	[Token(Token = "0x4008B0D")]
	[FieldOffset(Offset = "0x70")]
	public string videoPath;

	[Token(Token = "0x4008B0E")]
	[FieldOffset(Offset = "0x78")]
	public bool stopAllPlayerAudio;

	[Token(Token = "0x4008B0F")]
	[FieldOffset(Offset = "0x79")]
	public bool fadeOutOnStart;

	[Token(Token = "0x4008B10")]
	[FieldOffset(Offset = "0x7A")]
	public bool fadeInOnComplete;

	[Token(Token = "0x4008B11")]
	[FieldOffset(Offset = "0x7B")]
	public bool blackOutOnComplete;

	[Token(Token = "0x4008B12")]
	[FieldOffset(Offset = "0x7C")]
	public float fadeSeconds;

	[Token(Token = "0x4008B13")]
	private static List<Action> m_OnMovieCompleteCallbacks;

	[Token(Token = "0x170009B4")]
	protected override string info
	{
		[Token(Token = "0x6007838")]
		[Address(RVA = "0x116ACF0", Offset = "0x1169AF0", Length = "0x8A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007836")]
	[Address(RVA = "0x116AB40", Offset = "0x1169940", Length = "0xCC")]
	public static void RegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[Token(Token = "0x6007837")]
	[Address(RVA = "0x116AC10", Offset = "0x1169A10", Length = "0xD3")]
	public static void UnRegisterOnActionMovieCompleteCallback(Action onMovieCompleteCallback)
	{
	}

	[Token(Token = "0x6007839")]
	[Address(RVA = "0x116AD80", Offset = "0x1169B80", Length = "0x134")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600783A")]
	[Address(RVA = "0x116AEC0", Offset = "0x1169CC0", Length = "0xFA")]
	private void ProcessOnMovieCompleteCallback()
	{
	}

	[Token(Token = "0x600783B")]
	[Address(RVA = "0x116AFC0", Offset = "0x1169DC0", Length = "0x21B")]
	private void PlayMovie()
	{
	}

	[Token(Token = "0x600783C")]
	[Address(RVA = "0x116B1E0", Offset = "0x1169FE0", Length = "0x148")]
	private void OnMovieComplete()
	{
	}

	[Token(Token = "0x600783D")]
	[Address(RVA = "0x116B330", Offset = "0x116A130", Length = "0x7")]
	private void OnFadeInComplete()
	{
	}

	[Token(Token = "0x600783E")]
	[Address(RVA = "0x116B340", Offset = "0x116A140", Length = "0x10B")]
	private void OnActionComplete()
	{
	}

	[Token(Token = "0x600783F")]
	[Address(RVA = "0x116B450", Offset = "0x116A250", Length = "0x19")]
	public Action_PlayVideo()
	{
	}
}
