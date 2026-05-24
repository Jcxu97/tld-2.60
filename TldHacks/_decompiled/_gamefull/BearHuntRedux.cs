using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001D1")]
public class BearHuntRedux : MonoBehaviour
{
	[Token(Token = "0x4000FB8")]
	private static bool s_DeprecatedActive;

	[Token(Token = "0x4000FB9")]
	private static bool s_SaveCheckPoint;

	[Token(Token = "0x4000FBA")]
	private static BaseAi s_BearBaseAi;

	[Token(Token = "0x4000FBB")]
	private static BearHuntReduxSaveData s_BearHuntReduxSavedData;

	[Token(Token = "0x4000FBC")]
	private static bool s_Completed;

	[Token(Token = "0x4000FBD")]
	private static bool s_PlayerDiesAfterSpearMiss;

	[Token(Token = "0x4000FBE")]
	public static List<BearEncounterInfo> s_BearEncounterInfoList;

	[Token(Token = "0x4000FBF")]
	public static bool s_DebugBearHuntRedux;

	[Token(Token = "0x6001084")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6001085")]
	[Address(RVA = "0x628A80", Offset = "0x627880", Length = "0x1AD")]
	public static void UpdateMission()
	{
	}

	[Token(Token = "0x6001086")]
	[Address(RVA = "0x628C30", Offset = "0x627A30", Length = "0xE8")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6001087")]
	[Address(RVA = "0x628D20", Offset = "0x627B20", Length = "0x1E1")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001088")]
	[Address(RVA = "0x628F10", Offset = "0x627D10", Length = "0x1AD")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001089")]
	[Address(RVA = "0x6290C0", Offset = "0x627EC0", Length = "0xB7")]
	public static void SetHuntBear(BaseAi bearAi)
	{
	}

	[Token(Token = "0x600108A")]
	[Address(RVA = "0x629180", Offset = "0x627F80", Length = "0xE1")]
	public static void Begin()
	{
	}

	[Token(Token = "0x600108B")]
	[Address(RVA = "0x629270", Offset = "0x628070", Length = "0x83")]
	public static void End()
	{
	}

	[Token(Token = "0x600108C")]
	[Address(RVA = "0x629300", Offset = "0x628100", Length = "0x53")]
	public static bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x600108D")]
	[Address(RVA = "0x629360", Offset = "0x628160", Length = "0x153")]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return false;
	}

	[Token(Token = "0x600108E")]
	[Address(RVA = "0x6294C0", Offset = "0x6282C0", Length = "0x28")]
	public static void OnPlayerDetected(BaseAi bai)
	{
	}

	[Token(Token = "0x600108F")]
	[Address(RVA = "0x6294F0", Offset = "0x6282F0", Length = "0xFE")]
	public static bool IsBearSpawned()
	{
		return false;
	}

	[Token(Token = "0x6001090")]
	[Address(RVA = "0x6295F0", Offset = "0x6283F0", Length = "0x54")]
	public static BaseAi GetSpawnedBear()
	{
		return null;
	}

	[Token(Token = "0x6001091")]
	[Address(RVA = "0x629650", Offset = "0x628450", Length = "0x5A")]
	public static void OnBearSpearOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[Token(Token = "0x6001092")]
	[Address(RVA = "0x6296B0", Offset = "0x6284B0", Length = "0x54")]
	public static void SaveCheckpoint()
	{
	}

	[Token(Token = "0x6001093")]
	[Address(RVA = "0x629710", Offset = "0x628510", Length = "0xB6")]
	public static void RetrieveSpawnedBear()
	{
	}

	[Token(Token = "0x6001094")]
	[Address(RVA = "0x6297D0", Offset = "0x6285D0", Length = "0x3C1")]
	public static bool ActivateEncounter(string missionObjectId, bool activate)
	{
		return false;
	}

	[Token(Token = "0x6001095")]
	[Address(RVA = "0x629BA0", Offset = "0x6289A0", Length = "0x5E")]
	public static bool IsEncounterActivated(string missionObjectId)
	{
		return false;
	}

	[Token(Token = "0x6001096")]
	[Address(RVA = "0x629C00", Offset = "0x628A00", Length = "0x1EE")]
	public static bool SetLastEncounter(string missionObjectId, bool isLast)
	{
		return false;
	}

	[Token(Token = "0x6001097")]
	[Address(RVA = "0x629DF0", Offset = "0x628BF0", Length = "0x378")]
	public static bool SetPostStruggleBehavior(string missionObjectId, BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
		return false;
	}

	[Token(Token = "0x6001098")]
	[Address(RVA = "0x62A170", Offset = "0x628F70", Length = "0x5E")]
	public static bool IsLastEncounter(string missionObjectId)
	{
		return false;
	}

	[Token(Token = "0x6001099")]
	[Address(RVA = "0x62A1D0", Offset = "0x628FD0", Length = "0x61")]
	public static bool HasWonLatestEncounter(string missionObjectId)
	{
		return false;
	}

	[Token(Token = "0x600109A")]
	[Address(RVA = "0x62A240", Offset = "0x629040", Length = "0x59")]
	public static void SetPlayerDiesAfterSpearMiss(bool playerShouldDie)
	{
	}

	[Token(Token = "0x600109B")]
	[Address(RVA = "0x62A2A0", Offset = "0x6290A0", Length = "0x54")]
	public static bool GetPlayerDiesAfterSpearMiss()
	{
		return false;
	}

	[Token(Token = "0x600109C")]
	[Address(RVA = "0x62A300", Offset = "0x629100", Length = "0x44F")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x600109D")]
	[Address(RVA = "0x62A750", Offset = "0x629550", Length = "0x8E")]
	private static void MaybeLoseMission()
	{
	}

	[Token(Token = "0x600109E")]
	[Address(RVA = "0x62A7E0", Offset = "0x6295E0", Length = "0x8B")]
	private static void MaybeSaveCheckpoint()
	{
	}

	[Token(Token = "0x600109F")]
	[Address(RVA = "0x62A870", Offset = "0x629670", Length = "0x1EF")]
	private static BaseAi FindHuntBear()
	{
		return null;
	}

	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x62AA60", Offset = "0x629860", Length = "0x13A")]
	private static void Win()
	{
	}

	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x62ABA0", Offset = "0x6299A0", Length = "0x2A6")]
	private static void OnBearSpearOutcomeInternal(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x62AE50", Offset = "0x629C50", Length = "0x1DE")]
	private static BearEncounterInfo GetBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x62B030", Offset = "0x629E30", Length = "0x18E")]
	private static BearEncounterInfo GetOrCreateBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x62B1C0", Offset = "0x629FC0", Length = "0x1F2")]
	private static void UpdateBearEncounterInfo(BearEncounter bearEncounter)
	{
	}

	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x62B3C0", Offset = "0x62A1C0", Length = "0x528")]
	private static void OnBearEncounterOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome, BearEncounter bearEncounter, BearHuntAiRedux bearHuntReduxAi)
	{
	}

	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x62B8F0", Offset = "0x62A6F0", Length = "0x1C8")]
	private static BearEncounter FindBearEncounter(string missionObjectId)
	{
		return null;
	}

	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BearHuntRedux()
	{
	}
}
