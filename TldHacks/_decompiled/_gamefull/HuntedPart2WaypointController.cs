using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[Token(Token = "0x200081B")]
public class HuntedPart2WaypointController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4005565")]
	[FieldOffset(Offset = "0x20")]
	private ChallengeConfig m_HuntedPart2Config;

	[SerializeField]
	[Token(Token = "0x4005566")]
	[FieldOffset(Offset = "0x28")]
	private MissionObjectIdentifier m_WaypointMissionObject;

	[SerializeField]
	[Token(Token = "0x4005567")]
	[FieldOffset(Offset = "0x30")]
	private MissionObjectIdentifier m_WaypointSetMissionObject;

	[Token(Token = "0x4005568")]
	[FieldOffset(Offset = "0x38")]
	private HuntedPart2Waypoint[] m_Waypoints;

	[Token(Token = "0x4005569")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentWaypoint;

	[Token(Token = "0x400556A")]
	[FieldOffset(Offset = "0x44")]
	private int m_CurrentWeatherStage;

	[Token(Token = "0x400556B")]
	[FieldOffset(Offset = "0x48")]
	private float m_WaypointIncrementTimer;

	[Token(Token = "0x400556C")]
	[FieldOffset(Offset = "0x4C")]
	private float m_WaypointWanderPauseTimer;

	[Token(Token = "0x400556D")]
	[FieldOffset(Offset = "0x50")]
	private bool m_WanderPaused;

	[Token(Token = "0x400556E")]
	[FieldOffset(Offset = "0x51")]
	private bool m_WanderingAroundPoint;

	[Token(Token = "0x400556F")]
	[FieldOffset(Offset = "0x58")]
	private BaseAi m_BaseAI;

	[Token(Token = "0x4005570")]
	[FieldOffset(Offset = "0x60")]
	private float m_DetectionRangeOrig;

	[Token(Token = "0x4005571")]
	[FieldOffset(Offset = "0x64")]
	private float m_DetectionFOVOrig;

	[Token(Token = "0x4005572")]
	[FieldOffset(Offset = "0x68")]
	private float m_HearFootstepsRangeOrig;

	[Token(Token = "0x4005573")]
	[FieldOffset(Offset = "0x6C")]
	private float m_HearRifleRangeOrig;

	[Token(Token = "0x4005574")]
	[FieldOffset(Offset = "0x70")]
	private float m_HearCarAlarmRangeOrig;

	[Token(Token = "0x4005575")]
	[FieldOffset(Offset = "0x74")]
	private float m_SmellRangeOrig;

	[Token(Token = "0x4005576")]
	[FieldOffset(Offset = "0x78")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4005577")]
	[FieldOffset(Offset = "0x7C")]
	private HuntedPart2WaypointControllerState m_State;

	[Token(Token = "0x4005578")]
	private static ChallengeConfig s_HuntedPart2Config;

	[Token(Token = "0x4005579")]
	private static readonly HuntedPart2WaypointControllerSaveData m_HuntedPart2WaypointControllerSaveData;

	[Token(Token = "0x6004B5E")]
	[Address(RVA = "0xD525B0", Offset = "0xD513B0", Length = "0x21C")]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return false;
	}

	[Token(Token = "0x6004B5F")]
	[Address(RVA = "0xD527D0", Offset = "0xD515D0", Length = "0x85")]
	public static int GetCurrentWaypoint(string text)
	{
		return 0;
	}

	[Token(Token = "0x6004B60")]
	[Address(RVA = "0xD52860", Offset = "0xD51660", Length = "0x119")]
	public void ProcessHitByPlayer()
	{
	}

	[Token(Token = "0x6004B61")]
	[Address(RVA = "0xD52980", Offset = "0xD51780", Length = "0x264")]
	private void Start()
	{
	}

	[Token(Token = "0x6004B62")]
	[Address(RVA = "0xD52BF0", Offset = "0xD519F0", Length = "0x123")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004B63")]
	[Address(RVA = "0xD52D20", Offset = "0xD51B20", Length = "0xCD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004B64")]
	[Address(RVA = "0xD52DF0", Offset = "0xD51BF0", Length = "0x1F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6004B65")]
	[Address(RVA = "0xD53980", Offset = "0xD52780", Length = "0x27")]
	public void SetCurrentWaypoint(int waypoint)
	{
	}

	[Token(Token = "0x6004B66")]
	[Address(RVA = "0xD539B0", Offset = "0xD527B0", Length = "0x15B")]
	public bool GoToCurrentWaypoint()
	{
		return false;
	}

	[Token(Token = "0x6004B67")]
	[Address(RVA = "0xD53B10", Offset = "0xD52910", Length = "0x22D")]
	public void IncrementWaypoint()
	{
	}

	[Token(Token = "0x6004B68")]
	[Address(RVA = "0xD53D40", Offset = "0xD52B40", Length = "0x224")]
	public bool InRangeOfTargetWaypoint()
	{
		return false;
	}

	[Token(Token = "0x6004B69")]
	[Address(RVA = "0xD53F70", Offset = "0xD52D70", Length = "0x40")]
	public HuntedPart2Waypoint.WaypointType GetCurrentWaypointType()
	{
		return default(HuntedPart2Waypoint.WaypointType);
	}

	[Token(Token = "0x6004B6A")]
	[Address(RVA = "0xD53FC0", Offset = "0xD52DC0", Length = "0x8")]
	public bool FinalAmbushStarted()
	{
		return false;
	}

	[Token(Token = "0x6004B6B")]
	[Address(RVA = "0xD53FD0", Offset = "0xD52DD0", Length = "0x8")]
	public bool AwaitingFinalAmbush()
	{
		return false;
	}

	[Token(Token = "0x6004B6C")]
	[Address(RVA = "0xD53FE0", Offset = "0xD52DE0", Length = "0x74")]
	public void WinChallenge()
	{
	}

	[Token(Token = "0x6004B6D")]
	[Address(RVA = "0xD54060", Offset = "0xD52E60", Length = "0x4CA")]
	public void ForceEndGame()
	{
	}

	[Token(Token = "0x6004B6E")]
	[Address(RVA = "0xD54530", Offset = "0xD53330", Length = "0x3A2")]
	private static bool InRequiredGameMode()
	{
		return false;
	}

	[Token(Token = "0x6004B6F")]
	[Address(RVA = "0xD548E0", Offset = "0xD536E0", Length = "0x47E")]
	private bool ShouldDoWanderPause()
	{
		return false;
	}

	[Token(Token = "0x6004B70")]
	[Address(RVA = "0xD54D60", Offset = "0xD53B60", Length = "0xCE")]
	private void ToggleDetection(bool enableDetection)
	{
	}

	[Token(Token = "0x6004B71")]
	[Address(RVA = "0xD54E30", Offset = "0xD53C30", Length = "0x500")]
	private void WaypointsInitialize()
	{
	}

	[Token(Token = "0x6004B72")]
	[Address(RVA = "0xD55340", Offset = "0xD54140", Length = "0x4C")]
	private bool SkipWaypointFollowingBasedOnAiMode()
	{
		return false;
	}

	[Token(Token = "0x6004B73")]
	[Address(RVA = "0xD553B0", Offset = "0xD541B0", Length = "0x544")]
	private bool MaybeDisableDuplicateBear()
	{
		return false;
	}

	[Token(Token = "0x6004B74")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HuntedPart2WaypointController()
	{
	}
}
