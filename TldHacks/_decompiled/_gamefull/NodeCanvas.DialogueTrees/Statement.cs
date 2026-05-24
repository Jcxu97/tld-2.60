using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Serializable]
[Token(Token = "0x2001109")]
public class Statement : IStatement
{
	[SerializeField]
	[Token(Token = "0x4008716")]
	[FieldOffset(Offset = "0x10")]
	private string _text;

	[SerializeField]
	[Token(Token = "0x4008717")]
	[FieldOffset(Offset = "0x18")]
	private AudioClip _audio;

	[SerializeField]
	[Token(Token = "0x4008718")]
	[FieldOffset(Offset = "0x20")]
	private string _meta;

	[SerializeField]
	[Token(Token = "0x4008719")]
	[FieldOffset(Offset = "0x28")]
	private VoiceOverAnimationState _anim;

	[Token(Token = "0x170008D0")]
	public string text
	{
		[Token(Token = "0x600737C")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600737D")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008D1")]
	public AudioClip audio
	{
		[Token(Token = "0x600737E")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600737F")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008D2")]
	public string meta
	{
		[Token(Token = "0x6007380")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007381")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008D3")]
	public VoiceOverAnimationState anim
	{
		[Token(Token = "0x6007382")]
		[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
		get
		{
			return default(VoiceOverAnimationState);
		}
		[Token(Token = "0x6007383")]
		[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6007384")]
	[Address(RVA = "0xD7E9D0", Offset = "0xD7D7D0", Length = "0xCA")]
	public Statement()
	{
	}

	[Token(Token = "0x6007385")]
	[Address(RVA = "0x10ECF50", Offset = "0x10EBD50", Length = "0x13C")]
	public Statement(string text)
	{
	}

	[Token(Token = "0x6007386")]
	[Address(RVA = "0x10ED090", Offset = "0x10EBE90", Length = "0x199")]
	public Statement(string text, AudioClip audio)
	{
	}

	[Token(Token = "0x6007387")]
	[Address(RVA = "0x10ED230", Offset = "0x10EC030", Length = "0x14D")]
	public Statement(string text, VoiceOverAnimationState anim)
	{
	}

	[Token(Token = "0x6007388")]
	[Address(RVA = "0x10ED380", Offset = "0x10EC180", Length = "0x1F0")]
	public Statement(string text, AudioClip audio, string meta)
	{
	}

	[Token(Token = "0x6007389")]
	[Address(RVA = "0x10ED570", Offset = "0x10EC370", Length = "0x2D2")]
	public IStatement BlackboardReplace(IBlackboard bb)
	{
		return null;
	}

	[Token(Token = "0x600738A")]
	[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
	public override string ToString()
	{
		return null;
	}
}
