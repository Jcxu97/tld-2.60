using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Say", 0)]
[Description("Make the player say a given line of dialogue.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011FC")]
public class Action_PlayerSay : ActionTask
{
	[Token(Token = "0x20011FD")]
	public enum BusyState
	{
		[Token(Token = "0x400897B")]
		Play,
		[Token(Token = "0x400897C")]
		Skip,
		[Token(Token = "0x400897D")]
		Block
	}

	[Token(Token = "0x4008973")]
	[FieldOffset(Offset = "0x68")]
	public BusyState busyState;

	[Token(Token = "0x4008974")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<VoiceOverItem>> speechOptions;

	[Token(Token = "0x4008975")]
	[FieldOffset(Offset = "0x78")]
	public string lastChoiceVar;

	[Token(Token = "0x4008976")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> randomize;

	[Token(Token = "0x4008977")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> blockUntilComplete;

	[Token(Token = "0x4008978")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<bool> queueLines;

	[Token(Token = "0x4008979")]
	[FieldOffset(Offset = "0x98")]
	private bool sayTriggered;

	[Token(Token = "0x17000975")]
	protected override string info
	{
		[Token(Token = "0x60076C4")]
		[Address(RVA = "0x114E6D0", Offset = "0x114D4D0", Length = "0x211")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076C5")]
	[Address(RVA = "0x114E8F0", Offset = "0x114D6F0", Length = "0xE")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076C6")]
	[Address(RVA = "0x114E900", Offset = "0x114D700", Length = "0x680")]
	private void DoSay()
	{
	}

	[Token(Token = "0x60076C7")]
	[Address(RVA = "0x114EF90", Offset = "0x114DD90", Length = "0x1B4")]
	private void OnStopAllAudio(GameObject gameObject)
	{
	}

	[Token(Token = "0x60076C8")]
	[Address(RVA = "0x114F150", Offset = "0x114DF50", Length = "0x11")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60076C9")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void DialogueCompleted()
	{
	}

	[Token(Token = "0x60076CA")]
	[Address(RVA = "0x114F170", Offset = "0x114DF70", Length = "0x112")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60076CB")]
	[Address(RVA = "0x114F290", Offset = "0x114E090", Length = "0x3A6")]
	public Action_PlayerSay()
	{
	}
}
