using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Look At Target For Time", 0)]
[Description("Look at a GameObject (registered with a MissionObjectIdientifier) for a fixed amount of time.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001214")]
public class Action_LookAtTargetForTime : ActionTask
{
	[RequiredField]
	[Token(Token = "0x40089C7")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> targetMissionObjectIdentifier;

	[SliderField(0f, 0.5f)]
	[Token(Token = "0x40089C8")]
	[FieldOffset(Offset = "0x70")]
	public float blendInPercent;

	[SliderField(0f, 0.5f)]
	[Token(Token = "0x40089C9")]
	[FieldOffset(Offset = "0x74")]
	public float blendOutPercent;

	[SliderField(0.1f, 60f)]
	[Token(Token = "0x40089CA")]
	[FieldOffset(Offset = "0x78")]
	public float frameTimeSeconds;

	[Token(Token = "0x40089CB")]
	[FieldOffset(Offset = "0x7C")]
	public bool shouldRestoreCameraOrientation;

	[Token(Token = "0x40089CC")]
	[FieldOffset(Offset = "0x80")]
	public UITweener.Method tweenInMethod;

	[Token(Token = "0x40089CD")]
	[FieldOffset(Offset = "0x84")]
	public bool steeperCurvesIn;

	[Token(Token = "0x40089CE")]
	[FieldOffset(Offset = "0x88")]
	public UITweener.Method tweenOutMethod;

	[Token(Token = "0x40089CF")]
	[FieldOffset(Offset = "0x8C")]
	public bool steeperCurvesOut;

	[Token(Token = "0x40089D0")]
	[FieldOffset(Offset = "0x90")]
	private float timeRemaining;

	[Token(Token = "0x40089D1")]
	[FieldOffset(Offset = "0x94")]
	private PlayerControlMode restoreControlMode;

	[Token(Token = "0x40089D2")]
	[FieldOffset(Offset = "0x98")]
	private Quaternion restoreCameraOrientation;

	[Token(Token = "0x40089D3")]
	[FieldOffset(Offset = "0xA8")]
	private Quaternion cameraTargetOrientation;

	[Token(Token = "0x40089D4")]
	[FieldOffset(Offset = "0xB8")]
	private float blendInTime;

	[Token(Token = "0x40089D5")]
	[FieldOffset(Offset = "0xBC")]
	private float blendOutTime;

	[Token(Token = "0x1700097B")]
	protected override string info
	{
		[Token(Token = "0x6007707")]
		[Address(RVA = "0x1154300", Offset = "0x1153100", Length = "0x11B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007708")]
	[Address(RVA = "0x1154420", Offset = "0x1153220", Length = "0x720")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007709")]
	[Address(RVA = "0x1154B50", Offset = "0x1153950", Length = "0x206")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600770A")]
	[Address(RVA = "0x1154D60", Offset = "0x1153B60", Length = "0x43")]
	public Action_LookAtTargetForTime()
	{
	}
}
