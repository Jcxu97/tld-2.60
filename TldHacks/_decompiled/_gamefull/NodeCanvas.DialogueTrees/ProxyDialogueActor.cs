using System;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Serializable]
[Token(Token = "0x20010F8")]
public class ProxyDialogueActor : IDialogueActor
{
	[Token(Token = "0x40086F3")]
	[FieldOffset(Offset = "0x10")]
	private string _name;

	[Token(Token = "0x40086F4")]
	[FieldOffset(Offset = "0x18")]
	private Transform _transform;

	[Token(Token = "0x170008AE")]
	public string name
	{
		[Token(Token = "0x6007315")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008AF")]
	public Texture2D portrait
	{
		[Token(Token = "0x6007316")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B0")]
	public Sprite portraitSprite
	{
		[Token(Token = "0x6007317")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B1")]
	public Color dialogueColor
	{
		[Token(Token = "0x6007318")]
		[Address(RVA = "0x50BF80", Offset = "0x50AD80", Length = "0xE")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170008B2")]
	public Vector3 dialoguePosition
	{
		[Token(Token = "0x6007319")]
		[Address(RVA = "0x10E80B0", Offset = "0x10E6EB0", Length = "0x4F")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170008B3")]
	public Transform transform
	{
		[Token(Token = "0x600731A")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600731B")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public ProxyDialogueActor(string name, Transform transform)
	{
	}
}
