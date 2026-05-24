using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[AddComponentMenu("NodeCanvas/Dialogue Tree Controller")]
[Token(Token = "0x20010F4")]
public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor
{
	[Token(Token = "0x17000897")]
	string IDialogueActor.name
	{
		[Token(Token = "0x60072F1")]
		[Address(RVA = "0x10B87B0", Offset = "0x10B75B0", Length = "0x9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000898")]
	Texture2D IDialogueActor.portrait
	{
		[Token(Token = "0x60072F2")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000899")]
	Sprite IDialogueActor.portraitSprite
	{
		[Token(Token = "0x60072F3")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089A")]
	Color IDialogueActor.dialogueColor
	{
		[Token(Token = "0x60072F4")]
		[Address(RVA = "0x50BF80", Offset = "0x50AD80", Length = "0xE")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700089B")]
	Vector3 IDialogueActor.dialoguePosition
	{
		[Token(Token = "0x60072F5")]
		[Address(RVA = "0x10E80B0", Offset = "0x10E6EB0", Length = "0x4F")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700089C")]
	Transform IDialogueActor.transform
	{
		[Token(Token = "0x60072F6")]
		[Address(RVA = "0x935C80", Offset = "0x934A80", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60072F7")]
	[Address(RVA = "0x10E8100", Offset = "0x10E6F00", Length = "0xE")]
	public void StartDialogue()
	{
	}

	[Token(Token = "0x60072F8")]
	[Address(RVA = "0x10E8110", Offset = "0x10E6F10", Length = "0xE")]
	public void StartDialogue(Action<bool> callback)
	{
	}

	[Token(Token = "0x60072F9")]
	[Address(RVA = "0x10E8120", Offset = "0x10E6F20", Length = "0xB")]
	public void StartDialogue(IDialogueActor instigator)
	{
	}

	[Token(Token = "0x60072FA")]
	[Address(RVA = "0x10E8130", Offset = "0x10E6F30", Length = "0x16E")]
	public void StartDialogue(IDialogueActor instigator, Action<bool> callback)
	{
	}

	[Token(Token = "0x60072FB")]
	[Address(RVA = "0x10E82A0", Offset = "0x10E70A0", Length = "0x2F")]
	public void PauseDialogue()
	{
	}

	[Token(Token = "0x60072FC")]
	[Address(RVA = "0x10E82D0", Offset = "0x10E70D0", Length = "0x32")]
	public void StopDialogue()
	{
	}

	[Token(Token = "0x60072FD")]
	[Address(RVA = "0x10E8310", Offset = "0x10E7110", Length = "0x111")]
	public void SetActorReference(string paramName, IDialogueActor actor)
	{
	}

	[Token(Token = "0x60072FE")]
	[Address(RVA = "0x10E8430", Offset = "0x10E7230", Length = "0x101")]
	public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
	{
	}

	[Token(Token = "0x60072FF")]
	[Address(RVA = "0x10E8540", Offset = "0x10E7340", Length = "0x112")]
	public IDialogueActor GetActorReferenceByName(string paramName)
	{
		return null;
	}

	[Token(Token = "0x6007300")]
	[Address(RVA = "0x10E8660", Offset = "0x10E7460", Length = "0x3E")]
	public DialogueTreeController()
	{
	}
}
