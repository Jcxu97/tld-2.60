using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Lerp Player To Sync Bone", 0)]
[Description("Lerps the player transform to the SyncBone transform over the time specified")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011BB")]
public class Action_LerpToSyncBone : ActionTask
{
	[Token(Token = "0x40088DA")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> syncBone;

	[Token(Token = "0x40088DB")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> secondsToSync;

	[Token(Token = "0x40088DC")]
	[FieldOffset(Offset = "0x78")]
	private float secondsLeftToSync;

	[Token(Token = "0x40088DD")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 startPosition;

	[Token(Token = "0x40088DE")]
	[FieldOffset(Offset = "0x88")]
	private Quaternion startRotation;

	[Token(Token = "0x600760B")]
	[Address(RVA = "0x1116CA0", Offset = "0x1115AA0", Length = "0x67")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600760C")]
	[Address(RVA = "0x1116D10", Offset = "0x1115B10", Length = "0x7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600760D")]
	[Address(RVA = "0x1116D20", Offset = "0x1115B20", Length = "0x69D")]
	private void MaybePopToSync()
	{
	}

	[Token(Token = "0x600760E")]
	[Address(RVA = "0x11173C0", Offset = "0x11161C0", Length = "0x646")]
	private void MaybeBlendToSyncBone()
	{
	}

	[Token(Token = "0x600760F")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_LerpToSyncBone()
	{
	}
}
