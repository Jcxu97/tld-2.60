using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Multi Say", 0)]
[Description("Make the selected Dialogue Actors speak.")]
[Token(Token = "0x20010E0")]
public class Dialogue_VoiceOverNodeSequence : DTNode
{
	[Serializable]
	[Token(Token = "0x20010E1")]
	public class ActorVoiceOverItem
	{
		[Token(Token = "0x40086A6")]
		[FieldOffset(Offset = "0x10")]
		public bool m_IsUnfolded;

		[SerializeField]
		[Token(Token = "0x40086A7")]
		[FieldOffset(Offset = "0x18")]
		private string m_ActorName;

		[SerializeField]
		[Token(Token = "0x40086A8")]
		[FieldOffset(Offset = "0x20")]
		private string m_ActorParameterID;

		[NonSerialized]
		[Token(Token = "0x40086A9")]
		[FieldOffset(Offset = "0x28")]
		public DialogueTree m_DialogueTree;

		[SerializeField]
		[Token(Token = "0x40086AA")]
		[FieldOffset(Offset = "0x30")]
		public VoiceOverItem m_VoiceOverItem;

		[Token(Token = "0x17000881")]
		public string actorName
		{
			[Token(Token = "0x6007294")]
			[Address(RVA = "0x10E1F40", Offset = "0x10E0D40", Length = "0xFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007295")]
			[Address(RVA = "0x10E2040", Offset = "0x10E0E40", Length = "0x163")]
			set
			{
			}
		}

		[Token(Token = "0x17000882")]
		public IDialogueActor finalActor
		{
			[Token(Token = "0x6007296")]
			[Address(RVA = "0x10E21B0", Offset = "0x10E0FB0", Length = "0x63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007297")]
		[Address(RVA = "0x10E2220", Offset = "0x10E1020", Length = "0x129")]
		public ActorVoiceOverItem()
		{
		}
	}

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x40086A4")]
	[FieldOffset(Offset = "0x88")]
	public List<ActorVoiceOverItem> m_ActorVoiceOverItemList;

	[Token(Token = "0x40086A5")]
	[FieldOffset(Offset = "0x90")]
	private int m_CurrentIndex;

	[Token(Token = "0x1700087F")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x600728D")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000880")]
	public override string name
	{
		[Token(Token = "0x600728E")]
		[Address(RVA = "0x10E15B0", Offset = "0x10E03B0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600728F")]
	[Address(RVA = "0x10E15F0", Offset = "0x10E03F0", Length = "0x362")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007290")]
	[Address(RVA = "0x10E1960", Offset = "0x10E0760", Length = "0x47F")]
	private void PlayStatement(int index)
	{
	}

	[Token(Token = "0x6007291")]
	[Address(RVA = "0x10E1DE0", Offset = "0x10E0BE0", Length = "0x87")]
	private void OnStatementFinish()
	{
	}

	[Token(Token = "0x6007292")]
	[Address(RVA = "0x10E0E30", Offset = "0x10DFC30", Length = "0x2D")]
	private void OnSequenceFinish()
	{
	}

	[Token(Token = "0x6007293")]
	[Address(RVA = "0x10E1E70", Offset = "0x10E0C70", Length = "0xC5")]
	public Dialogue_VoiceOverNodeSequence()
	{
	}
}
