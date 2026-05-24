using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Spawn Object In Hand", 0)]
[Description("Spawns an object. Can destroy the object on completion")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001209")]
public class Action_SpawnObjectOnPlayer : ActionTask
{
	[Token(Token = "0x4008994")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> prefab;

	[Token(Token = "0x4008995")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> spawnedObject;

	[Token(Token = "0x4008996")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> propInWorldSpace;

	[Token(Token = "0x4008997")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> destroyOnComplete;

	[Token(Token = "0x4008998")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<SpawnLocation> spawnLocation;

	[Token(Token = "0x60076E9")]
	[Address(RVA = "0x1150810", Offset = "0x114F610", Length = "0x6D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076EA")]
	[Address(RVA = "0x1150880", Offset = "0x114F680", Length = "0x9B")]
	private Transform GetParentJoint()
	{
		return null;
	}

	[Token(Token = "0x60076EB")]
	[Address(RVA = "0x1150920", Offset = "0x114F720", Length = "0x847")]
	private void MaybeSpawnProp()
	{
	}

	[Token(Token = "0x60076EC")]
	[Address(RVA = "0x1151170", Offset = "0x114FF70", Length = "0xED")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60076ED")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SpawnObjectOnPlayer()
	{
	}
}
