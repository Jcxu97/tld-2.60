using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200015C")]
public class BaseAiDataProxy
{
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x14")]
	public float m_TimeInModeSeconds;

	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x18")]
	public float m_TimeInModeTODHours;

	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x1C")]
	public AiMode m_StartMode;

	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x20")]
	public AiMode m_CurrentMode;

	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x24")]
	public AiMode m_PreviousMode;

	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_SpawnPos;

	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x34")]
	public float m_CurrentHP;

	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x38")]
	public bool m_BleedingOut;

	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ElapsedBleedingOutMinutes;

	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x40")]
	public float m_DeathAfterBleeingOutMinutes;

	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x48")]
	public Vector3[] m_Waypoints;

	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x50")]
	public int m_TargetWaypointIndex;

	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x54")]
	public float m_SleepTimeHours;

	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x58")]
	public bool m_Wounded;

	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ElapsedWoundedMinutes;

	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x60")]
	public float m_SuppressFootStepDetectionAndSmellSecondsRemaining;

	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x64")]
	public bool m_CurrentTargetIsPlayer;

	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x68")]
	public DamageSource m_DamageSource;

	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x70")]
	public string m_ScriptedSequenceAnimTrigger;

	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x78")]
	public string m_Hunted2WaypointControllerSerialized;

	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x80")]
	public string m_BearHuntAiSerialized;

	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x88")]
	public string m_BearHuntAiReduxSerialized;

	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x90")]
	public string m_PackAnimalDataSerialized;

	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x98")]
	public bool m_FakeFeeding;

	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x9C")]
	public Vector3 m_FakeFeedingPos;

	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0xA8")]
	public float m_FakeFeedingDurationHours;

	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0xAC")]
	public bool m_UseForcedFleePos;

	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0xB0")]
	public Vector3 m_ForcedFleePos;

	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0xBC")]
	public bool m_UseWanderDestinationAfterStruggle;

	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0xC0")]
	public Vector3 m_WanderDestinationAfterStruggle;

	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0xD0")]
	public string m_MissionIdSerialized;

	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0xD8")]
	public Vector3 m_FleeFromPos;

	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0xE4")]
	public int m_FleeReason;

	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0xE8")]
	public BaseAi.PointOfInterest[] m_PointsOfInterest;

	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0xF0")]
	public int m_TargetPointOfInterestIndex;

	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0xF4")]
	public bool m_RandomizePointsOfInterest;

	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0xF8")]
	public AiMode m_DefaultMode;

	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0xFC")]
	public int m_PassingAttackCount;

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BaseAiDataProxy()
	{
	}
}
