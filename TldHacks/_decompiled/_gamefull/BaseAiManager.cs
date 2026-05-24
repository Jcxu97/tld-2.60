using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[Token(Token = "0x2000714")]
public class BaseAiManager
{
	[Token(Token = "0x4004B4F")]
	public static bool m_AiDebug;

	[Token(Token = "0x4004B50")]
	public static bool m_DisableAi;

	[Token(Token = "0x4004B51")]
	public static bool m_AiNavMeshDebug;

	[Token(Token = "0x4004B52")]
	public static bool m_AiSpawnDebug;

	[Token(Token = "0x4004B53")]
	public static bool m_AiDebugLite;

	[Token(Token = "0x4004B54")]
	public static bool s_AiDebugClosestOnly;

	[Token(Token = "0x4004B55")]
	public static bool m_AiDebugStates;

	[Token(Token = "0x4004B56")]
	public static bool s_EnableBatchGroundRaycast;

	[Token(Token = "0x4004B57")]
	public static bool s_EnableContinuousCollision;

	[Token(Token = "0x4004B58")]
	public static List<BaseAi> m_BaseAis;

	[Token(Token = "0x4004B59")]
	public const CollisionDetectionMode DEFAULT_CONTINUOUS_COLLISION_MODE = CollisionDetectionMode.ContinuousSpeculative;

	[Token(Token = "0x4004B5A")]
	private static BaseAi s_ClosestAiToPlayer;

	[Token(Token = "0x4004B5B")]
	private static GameObject s_Subsystems;

	[Token(Token = "0x4004B5C")]
	private static WolfHowlController s_WolfHowlController;

	[Token(Token = "0x4004B5D")]
	private static Dictionary<string, int> ms_CurrentWaypointIndexByGUID;

	[Token(Token = "0x4004B5E")]
	private static JobHandle s_BatchGroundRaycastJob;

	[Token(Token = "0x4004B5F")]
	private static NativeArray<RaycastHit> s_BatchGroundRaycastResults;

	[Token(Token = "0x4004B60")]
	private static NativeArray<SpherecastCommand> s_BatchGroundRaycastCommands;

	[Token(Token = "0x4004B61")]
	private static bool s_BatchGroundRaycastJobCompleted;

	[Token(Token = "0x4004B62")]
	private static RaycastHit s_InvalidHit;

	[Token(Token = "0x4004B63")]
	private static bool s_BatchGroundRaycastCommandsAllocated;

	[Token(Token = "0x1400000B")]
	public static event Action<BaseAi> m_OnBaseAiAdded
	{
		[CompilerGenerated]
		[Token(Token = "0x6003E20")]
		[Address(RVA = "0xC024A0", Offset = "0xC012A0", Length = "0x1CB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003E21")]
		[Address(RVA = "0xC02670", Offset = "0xC01470", Length = "0x1CB")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event Action<BaseAi> m_OnBaseAiRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x6003E22")]
		[Address(RVA = "0xC02840", Offset = "0xC01640", Length = "0x1CB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0xC02A10", Offset = "0xC01810", Length = "0x1CB")]
		remove
		{
		}
	}

	[Token(Token = "0x6003E1B")]
	[Address(RVA = "0xC01580", Offset = "0xC00380", Length = "0x815")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003E1C")]
	[Address(RVA = "0xC01DA0", Offset = "0xC00BA0", Length = "0x20B")]
	public static void DisableInvalidAi()
	{
	}

	[Token(Token = "0x6003E1D")]
	[Address(RVA = "0xC01FB0", Offset = "0xC00DB0", Length = "0x54")]
	public static WolfHowlController GetWolfHowlController()
	{
		return null;
	}

	[Token(Token = "0x6003E1E")]
	[Address(RVA = "0xC02010", Offset = "0xC00E10", Length = "0x167")]
	public static bool IsClosestToPlayer(BaseAi ai)
	{
		return false;
	}

	[Token(Token = "0x6003E1F")]
	[Address(RVA = "0xC02180", Offset = "0xC00F80", Length = "0x311")]
	public static void RefreshClosestToPlayer()
	{
	}

	[Token(Token = "0x6003E24")]
	[Address(RVA = "0xC02BE0", Offset = "0xC019E0", Length = "0x2A8")]
	private static bool BearHuntPart2Validate(BaseAiDataProxy proxy, BaseAi bai, BaseAiData bad)
	{
		return false;
	}

	[Token(Token = "0x6003E25")]
	[Address(RVA = "0xC02E90", Offset = "0xC01C90", Length = "0xAA")]
	public static bool CreateMoveAgent(Transform transform, BaseAi bai, Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x6003E26")]
	[Address(RVA = "0xC02F40", Offset = "0xC01D40", Length = "0xA44")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003E27")]
	[Address(RVA = "0xC03990", Offset = "0xC02790", Length = "0x360")]
	public static void DeserializeAi(BaseAi bai, BaseAiData bad, BaseAiDataProxy proxy)
	{
	}

	[Token(Token = "0x6003E28")]
	[Address(RVA = "0xC03D00", Offset = "0xC02B00", Length = "0x348")]
	public static void InstantiateSubsystems(GameObject prefab, Transform parent)
	{
	}

	[Token(Token = "0x6003E29")]
	[Address(RVA = "0xC04050", Offset = "0xC02E50", Length = "0x410")]
	public static void Add(BaseAi bai)
	{
	}

	[Token(Token = "0x6003E2A")]
	[Address(RVA = "0xC04470", Offset = "0xC03270", Length = "0x2A2")]
	public static void Remove(BaseAi bai)
	{
	}

	[Token(Token = "0x6003E2B")]
	[Address(RVA = "0xC04720", Offset = "0xC03520", Length = "0x33E")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003E2C")]
	[Address(RVA = "0xC04A60", Offset = "0xC03860", Length = "0x306")]
	public static void ResetAudioLoops()
	{
	}

	[Token(Token = "0x6003E2D")]
	[Address(RVA = "0xC04D70", Offset = "0xC03B70", Length = "0x312")]
	public static void Destroy(BaseAi bai)
	{
	}

	[Token(Token = "0x6003E2E")]
	[Address(RVA = "0xC05090", Offset = "0xC03E90", Length = "0x3E4")]
	public static bool FindAiByName(string name, ref List<BaseAi> animals)
	{
		return false;
	}

	[Token(Token = "0x6003E2F")]
	[Address(RVA = "0xC05480", Offset = "0xC04280", Length = "0x28E")]
	public static BaseAi GetAIFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[Token(Token = "0x6003E30")]
	[Address(RVA = "0xC05710", Offset = "0xC04510", Length = "0x2ED")]
	public static void RegisterAnyAIGuid()
	{
	}

	[Token(Token = "0x6003E31")]
	[Address(RVA = "0xC05A00", Offset = "0xC04800", Length = "0x1E7")]
	public static bool AnyLivingAI()
	{
		return false;
	}

	[Token(Token = "0x6003E32")]
	[Address(RVA = "0xC05BF0", Offset = "0xC049F0", Length = "0x111")]
	private static void MaybeSetAiModeWhenInactiveOrDisabled(BaseAi bai)
	{
	}

	[Token(Token = "0x6003E33")]
	[Address(RVA = "0xC05D10", Offset = "0xC04B10", Length = "0x26F")]
	private static void MaybeSetAiToFleeOrDespawn()
	{
	}

	[Token(Token = "0x6003E34")]
	[Address(RVA = "0xC05F80", Offset = "0xC04D80", Length = "0x764")]
	public static void Update()
	{
	}

	[Token(Token = "0x6003E35")]
	[Address(RVA = "0xC066F0", Offset = "0xC054F0", Length = "0x1F5")]
	public static void UpdateCollisionMode(CollisionDetectionMode mode)
	{
	}

	[Token(Token = "0x6003E36")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void DisplayDebugText()
	{
	}

	[Token(Token = "0x6003E37")]
	[Address(RVA = "0xC068F0", Offset = "0xC056F0", Length = "0x115")]
	private static bool CanUpdateAI(BaseAi bai)
	{
		return false;
	}

	[Token(Token = "0x6003E38")]
	[Address(RVA = "0xC06A10", Offset = "0xC05810", Length = "0x10B")]
	private static int GetBatchGroundRaycastSize()
	{
		return 0;
	}

	[Token(Token = "0x6003E39")]
	[Address(RVA = "0xC06B20", Offset = "0xC05920", Length = "0x1C8")]
	public static void DoLateUpdate()
	{
	}

	[Token(Token = "0x6003E3A")]
	[Address(RVA = "0xC06CF0", Offset = "0xC05AF0", Length = "0x4DA")]
	public static void BatchGroundRaycast()
	{
	}

	[Token(Token = "0x6003E3B")]
	[Address(RVA = "0xC071D0", Offset = "0xC05FD0", Length = "0xE4")]
	public static RaycastHit GetBatchGroundRaycastHit(int id)
	{
		return default(RaycastHit);
	}

	[Token(Token = "0x6003E3C")]
	[Address(RVA = "0xC072C0", Offset = "0xC060C0", Length = "0x100")]
	public static void DiposeBatchGroundRaycastHit()
	{
	}

	[Token(Token = "0x6003E3D")]
	[Address(RVA = "0xC073C0", Offset = "0xC061C0", Length = "0x4E")]
	public static void RegisterForBaseAiAdded(Action<BaseAi> function)
	{
	}

	[Token(Token = "0x6003E3E")]
	[Address(RVA = "0xC07410", Offset = "0xC06210", Length = "0x4E")]
	public static void RegisterForBaseAiRemoved(Action<BaseAi> function)
	{
	}

	[Token(Token = "0x6003E3F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BaseAiManager()
	{
	}
}
