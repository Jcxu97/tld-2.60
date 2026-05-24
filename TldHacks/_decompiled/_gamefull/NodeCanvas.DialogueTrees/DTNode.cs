using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Token(Token = "0x20010F6")]
public abstract class DTNode : Node
{
	[SerializeField]
	[Token(Token = "0x40086F1")]
	[FieldOffset(Offset = "0x78")]
	private string _actorName;

	[SerializeField]
	[Token(Token = "0x40086F2")]
	[FieldOffset(Offset = "0x80")]
	private string _actorParameterID;

	[Token(Token = "0x1700089D")]
	public override string name
	{
		[Token(Token = "0x6007302")]
		[Address(RVA = "0x10E86A0", Offset = "0x10E74A0", Length = "0x172")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089E")]
	public virtual bool requireActorSelection
	{
		[Token(Token = "0x6007303")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700089F")]
	public override int maxInConnections
	{
		[Token(Token = "0x6007304")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008A0")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007305")]
		[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008A1")]
	public sealed override Type outConnectionType
	{
		[Token(Token = "0x6007306")]
		[Address(RVA = "0x10E8820", Offset = "0x10E7620", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A2")]
	public sealed override bool allowAsPrime
	{
		[Token(Token = "0x6007307")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170008A3")]
	public sealed override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6007308")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x170008A4")]
	public sealed override Alignment2x2 iconAlignment
	{
		[Token(Token = "0x6007309")]
		[Address(RVA = "0x7D84A0", Offset = "0x7D72A0", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x170008A5")]
	protected DialogueTree DLGTree
	{
		[Token(Token = "0x600730A")]
		[Address(RVA = "0x10E88A0", Offset = "0x10E76A0", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A6")]
	protected string actorName
	{
		[Token(Token = "0x600730B")]
		[Address(RVA = "0x10E8910", Offset = "0x10E7710", Length = "0x45")]
		get
		{
			return null;
		}
		[Token(Token = "0x600730C")]
		[Address(RVA = "0x10E8960", Offset = "0x10E7760", Length = "0x173")]
		set
		{
		}
	}

	[Token(Token = "0x170008A7")]
	protected IDialogueActor finalActor
	{
		[Token(Token = "0x600730D")]
		[Address(RVA = "0x10E8AE0", Offset = "0x10E78E0", Length = "0x75")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600730E")]
	[Address(RVA = "0x10E8B60", Offset = "0x10E7960", Length = "0x90")]
	protected DTNode()
	{
	}
}
