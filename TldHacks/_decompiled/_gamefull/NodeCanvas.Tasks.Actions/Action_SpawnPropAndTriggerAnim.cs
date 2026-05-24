using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Actions/Player")]
[Description("Spawn a prop, call a trigger.")]
[Name("Spawn Prop And Call Trigger", 0)]
[Token(Token = "0x2001212")]
public class Action_SpawnPropAndTriggerAnim : ActionTask
{
	[Serializable]
	[Token(Token = "0x2001213")]
	public class ConstrainedLimits
	{
		[Token(Token = "0x40089C5")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 PitchLimitDegrees;

		[Token(Token = "0x40089C6")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 YawLimitDegrees;

		[Token(Token = "0x6007706")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ConstrainedLimits()
		{
		}
	}

	[Token(Token = "0x40089B5")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> trigger;

	[Token(Token = "0x40089B6")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> prefab;

	[Token(Token = "0x40089B7")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> propInWorldSpace;

	[Token(Token = "0x40089B8")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> removePropOnComplete;

	[Token(Token = "0x40089B9")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<SpawnLocation> spawnLocation;

	[Token(Token = "0x40089BA")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<bool> disableCharacterController;

	[Token(Token = "0x40089BB")]
	[FieldOffset(Offset = "0x98")]
	public bool disableDefaultLayers;

	[Token(Token = "0x40089BC")]
	[FieldOffset(Offset = "0x9C")]
	public float hipAndShoulderLayerWeight;

	[Token(Token = "0x40089BD")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<bool> loadAnimation;

	[Token(Token = "0x40089BE")]
	[FieldOffset(Offset = "0xA8")]
	public BBParameter<FPAnimationState> fpAnimationState;

	[Token(Token = "0x40089BF")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_spawnedObject;

	[Token(Token = "0x40089C0")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_WasCharacterControllerEnabled;

	[Token(Token = "0x40089C1")]
	[FieldOffset(Offset = "0xB9")]
	private bool m_HasDisabledCharacterController;

	[Token(Token = "0x40089C2")]
	[FieldOffset(Offset = "0xBA")]
	public bool ConstrainCameraLimits;

	[Token(Token = "0x40089C3")]
	[FieldOffset(Offset = "0xC0")]
	private ConstrainedLimits m_StartingConstainedLimits;

	[Token(Token = "0x40089C4")]
	[FieldOffset(Offset = "0xC8")]
	public ConstrainedLimits ActionConstainedLimits;

	[Token(Token = "0x6007701")]
	[Address(RVA = "0x1152E10", Offset = "0x1151C10", Length = "0xDF4")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007702")]
	[Address(RVA = "0x1153C10", Offset = "0x1152A10", Length = "0xE4")]
	private Transform GetParentJoint()
	{
		return null;
	}

	[Token(Token = "0x6007703")]
	[Address(RVA = "0x1153D00", Offset = "0x1152B00", Length = "0x2B1")]
	private void OnEnterPlaying(bool success)
	{
	}

	[Token(Token = "0x6007704")]
	[Address(RVA = "0x1153FC0", Offset = "0x1152DC0", Length = "0x22B")]
	private void OnComplete()
	{
	}

	[Token(Token = "0x6007705")]
	[Address(RVA = "0x11541F0", Offset = "0x1152FF0", Length = "0x110")]
	public Action_SpawnPropAndTriggerAnim()
	{
	}
}
