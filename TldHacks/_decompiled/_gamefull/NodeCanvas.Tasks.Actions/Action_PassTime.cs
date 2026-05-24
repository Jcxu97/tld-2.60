using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Pass Time", 0)]
[Description("Simulates sleeping")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200120A")]
public class Action_PassTime : ActionTask
{
	[Token(Token = "0x4008999")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> wakingHour;

	[Token(Token = "0x400899A")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> useWakingHour;

	[Token(Token = "0x400899B")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> minSleepingHours;

	[Token(Token = "0x400899C")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> suppressUI;

	[Token(Token = "0x400899D")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> fadeAudio;

	[Token(Token = "0x400899E")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<float> sleepFadeOutSeconds;

	[Token(Token = "0x400899F")]
	[FieldOffset(Offset = "0x98")]
	public BBParameter<float> totalDisplaySeconds;

	[Token(Token = "0x40089A0")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<string> messageId;

	[Token(Token = "0x40089A1")]
	[FieldOffset(Offset = "0xA8")]
	public BBParameter<bool> usePassTimeFade;

	[Token(Token = "0x40089A2")]
	[FieldOffset(Offset = "0xB0")]
	public BBParameter<bool> showCancelButton;

	[Token(Token = "0x40089A3")]
	[FieldOffset(Offset = "0xB8")]
	public BBParameter<bool> invulnerable;

	[SerializeField]
	[Token(Token = "0x40089A4")]
	[FieldOffset(Offset = "0xC0")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40089A5")]
	[FieldOffset(Offset = "0xC8")]
	private bool previousFrostbiteState;

	[Token(Token = "0x40089A6")]
	[FieldOffset(Offset = "0xC9")]
	private bool previousHypothermiaState;

	[Token(Token = "0x40089A7")]
	[FieldOffset(Offset = "0xCA")]
	private bool previousInvulnerableState;

	[Token(Token = "0x40089A8")]
	[FieldOffset(Offset = "0xCB")]
	private bool previousPassTimeUISupressedState;

	[Token(Token = "0x40089A9")]
	[FieldOffset(Offset = "0xCC")]
	private bool previousLabelMessageState;

	[Token(Token = "0x40089AA")]
	private const float audioFadeDuration = 1f;

	[Token(Token = "0x60076EE")]
	[Address(RVA = "0x1151260", Offset = "0x1150060", Length = "0x827")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076EF")]
	[Address(RVA = "0x1151A90", Offset = "0x1150890", Length = "0x35E")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60076F0")]
	[Address(RVA = "0x1151DF0", Offset = "0x1150BF0", Length = "0x2B2")]
	public Action_PassTime()
	{
	}
}
