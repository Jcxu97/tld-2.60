using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

[Name("Spawn Challenge Bear", 0)]
[Description("Spawn a Hunted Challenge Bear if one doesn't already exist")]
[Category("TLD Actions/Challenge/Hunted")]
[Token(Token = "0x2000852")]
public class Action_SpawnHuntedChallengeBear : ActionTask
{
	[Token(Token = "0x400568F")]
	[FieldOffset(Offset = "0x68")]
	public bool spawnOnTopOfPlayer;

	[Token(Token = "0x4005690")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> bearHP;

	[Token(Token = "0x4005691")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> forceStalkDistance;

	[Token(Token = "0x4005692")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> minSpawnDistance;

	[Token(Token = "0x4005693")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> maxSpawnDistance;

	[Token(Token = "0x4005694")]
	private const string WILDLIFE_BEAR = "WILDLIFE_BearHuntedChallenge";

	[Token(Token = "0x6004CC9")]
	[Address(RVA = "0xD77510", Offset = "0xD76310", Length = "0x45")]
	private void SpawnBear()
	{
	}

	[Token(Token = "0x6004CCA")]
	[Address(RVA = "0xD77560", Offset = "0xD76360", Length = "0x5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CCB")]
	[Address(RVA = "0xD77510", Offset = "0xD76310", Length = "0x45")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6004CCC")]
	[Address(RVA = "0xD77570", Offset = "0xD76370", Length = "0x3B6")]
	private GameObject InstantiateChallengeBear(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6004CCD")]
	[Address(RVA = "0xD77930", Offset = "0xD76730", Length = "0x75D")]
	private bool SpawnChallengeBearOnTopOfPlayer()
	{
		return false;
	}

	[Token(Token = "0x6004CCE")]
	[Address(RVA = "0xD78090", Offset = "0xD76E90", Length = "0x89E")]
	private bool SpawnChallengeBearNearPlayer()
	{
		return false;
	}

	[Token(Token = "0x6004CCF")]
	[Address(RVA = "0xD78930", Offset = "0xD77730", Length = "0x211")]
	private bool ChallengeBearIsActive()
	{
		return false;
	}

	[Token(Token = "0x6004CD0")]
	[Address(RVA = "0xD78B50", Offset = "0xD77950", Length = "0x337")]
	public Action_SpawnHuntedChallengeBear()
	{
	}
}
