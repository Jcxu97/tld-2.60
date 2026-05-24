using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000144")]
public class AiUtils
{
	[Token(Token = "0x4000A06")]
	private const int MAX_NAVMESH_RAYCAST_HITS = 10;

	[Token(Token = "0x4000A07")]
	private static RaycastHit[] m_GetRandomPointOnNavmeshNoPaddingHits;

	[Token(Token = "0x4000A08")]
	private const float XZTHRESHOLDDIST = 2f;

	[Token(Token = "0x4000A09")]
	private const float THRESHOLDDIST = 5f;

	[Token(Token = "0x4000A0A")]
	private static RaycastHit[] s_SphereCastResults;

	[Token(Token = "0x4000A0B")]
	private const float NAVMESH_SPHERECAST_RADIUS = 0.1f;

	[Token(Token = "0x4000A0C")]
	private const int NAVMESH_SPHERECAST_PHYSICAL_MASK = 269228801;

	[Token(Token = "0x4000A0D")]
	private const int NAVMESH_SPHERECAST_NAVMESH_MASK = 2817;

	[Token(Token = "0x4000A0E")]
	private static Collider[] s_CollidersForOverlapSphereNonSelf;

	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x5D73A0", Offset = "0x5D61A0", Length = "0x1C6")]
	public static bool PositionInCameraFrustum(Vector3 npcPos, Vector3 npcForward, Vector3 pos, float range, float fov)
	{
		return false;
	}

	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x5D7570", Offset = "0x5D6370", Length = "0x48A")]
	public static bool PositionVisible(Vector3 npcPos, Vector3 npcForward, Vector3 pos, float range, float fov, float raycastRadius, int layerMask)
	{
		return false;
	}

	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x5D7A00", Offset = "0x5D6800", Length = "0x414")]
	public static Fire GetClosestVisibleBurningFire(BaseAi bai)
	{
		return null;
	}

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x5D7E20", Offset = "0x5D6C20", Length = "0x194")]
	public static bool InSameNavmeshArea(Vector3 start, Vector3 end)
	{
		return false;
	}

	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x5D7FC0", Offset = "0x5D6DC0", Length = "0x11A")]
	public static Vector3 GetClosestNavmeshPoint(Vector3 pos, int area)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x5D80E0", Offset = "0x5D6EE0", Length = "0x17E")]
	public static bool CanPathfindToPosition(Vector3 pos, Vector3 testedPosition, float xzThreshold)
	{
		return false;
	}

	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x5D8260", Offset = "0x5D7060", Length = "0x90")]
	public static int GetNavmeshArea(Vector3 pos)
	{
		return 0;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x5D8300", Offset = "0x5D7100", Length = "0x35C")]
	public static void DrawDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x5D8660", Offset = "0x5D7460", Length = "0x479")]
	public static bool FindNearestGroundAndNavmeshFor(Vector3 pos, out Vector3 groundPos, out Vector3 navmeshPos)
	{
		groundPos = default(Vector3);
		navmeshPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x5D8AE0", Offset = "0x5D78E0", Length = "0x2A1")]
	private static bool GetNavmeshClampedPosition(out Vector3 clampedPosition, Vector3 pos, Vector3 constraintPos, float heightOffset, float radius, float xzThresholdDist, float thresholdDist)
	{
		clampedPosition = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x5D8D90", Offset = "0x5D7B90", Length = "0x2CE")]
	private static bool GetValidPositionUnder(out Vector3 validPosition, Vector3 raycastStart, Vector3 clampedPosition, float xzThresholdDist, float thresholdDist)
	{
		validPosition = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x5D9060", Offset = "0x5D7E60", Length = "0x22A")]
	public static bool GetClosestNavmeshPos(out Vector3 navmeshPos, Vector3 pos, Vector3 constraintPos, float radius = 2f, float heightOffset = 100f)
	{
		navmeshPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x5D9290", Offset = "0x5D8090", Length = "0x220")]
	public static bool IsNavmeshPosValid(Vector3 pos, float radius, float heightOffset)
	{
		return false;
	}

	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x5D94B0", Offset = "0x5D82B0", Length = "0xFA")]
	public static bool GetRandomPointOnNavmeshWithDistance(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float liftDistance, float raycastDistance)
	{
		outPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x5D95B0", Offset = "0x5D83B0", Length = "0xF9")]
	public static bool GetRandomPointOnNavmesh(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly = false, float liftDistance = 0.2f)
	{
		outPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x5D96B0", Offset = "0x5D84B0", Length = "0x70A")]
	public static bool GetRandomPointAndNormalOnNavmeshNoPadding(out Vector3 outPos, out Vector3 outNormal, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float raycastDistance)
	{
		outPos = default(Vector3);
		outNormal = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x5D9DC0", Offset = "0x5D8BC0", Length = "0x39E")]
	public static bool OverlapSphereNonSelf(Vector3 position, float radius, int layerMask, Collider[] selfColliders)
	{
		return false;
	}

	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x5DA160", Offset = "0x5D8F60", Length = "0xA2")]
	public static bool PositionIsClear(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf)
	{
		return false;
	}

	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x5DA210", Offset = "0x5D9010", Length = "0x15F")]
	public static bool PositionIsClearGivenCollisionMask(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf, int collisionMask)
	{
		return false;
	}

	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x5DA370", Offset = "0x5D9170", Length = "0x2CA")]
	public static BaseAi GetAiFeedingOnCarcass(BodyHarvest bh)
	{
		return null;
	}

	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x5DA640", Offset = "0x5D9440", Length = "0x2C5")]
	public static void DespawnHostileAiAroundPoint(Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x5DA910", Offset = "0x5D9710", Length = "0x1BF")]
	public static void TurnTowardsTarget(BaseAi bai)
	{
	}

	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x5DAAD0", Offset = "0x5D98D0", Length = "0x46")]
	public static void PointTowardsDirection(BaseAi bai, Vector3 dir)
	{
	}

	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x5DAB20", Offset = "0x5D9920", Length = "0x3C9")]
	public static List<BaseAi> GetAisWithinRange(Vector3 position, float range)
	{
		return null;
	}

	[Token(Token = "0x6000B98")]
	[Address(RVA = "0x5DAEF0", Offset = "0x5D9CF0", Length = "0x40C")]
	public static BaseAi FindClosestAiWithinCone(Vector3 position, Vector3 direction, float minDistance, float maxDistance, float maxAngleDegrees)
	{
		return null;
	}

	[Token(Token = "0x6000B99")]
	[Address(RVA = "0x5DB300", Offset = "0x5DA100", Length = "0x138")]
	public static BaseAi GetBaseAiFromObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0x5DB440", Offset = "0x5DA240", Length = "0x4CA")]
	public static bool RaycastWithAimAssist(Vector3 position, Vector3 direction, out RaycastHit hit, float maxDistance, float minDistanceForAssist, float maxDistanceForAssist, float maxAngleDegrees, int layerMask)
	{
		hit = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0x5DB910", Offset = "0x5DA710", Length = "0xB5B")]
	public static Vector3[] GetPointsForGradualTurn(Transform transform, Vector3 target, float turnRadius, float maxTurnSegmentAngle)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x5DC470", Offset = "0x5DB270", Length = "0x64")]
	public static void LogWarning(string output)
	{
	}

	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x5DC4E0", Offset = "0x5DB2E0", Length = "0x15")]
	private static bool LayerCanBeGround(int layer)
	{
		return false;
	}

	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AiUtils()
	{
	}
}
