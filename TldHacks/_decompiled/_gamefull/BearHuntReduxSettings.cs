using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "BearHuntReduxSettings", menuName = "Mission/Create BearHuntReduxSettings", order = 10004)]
[Token(Token = "0x20001D2")]
public class BearHuntReduxSettings : ScriptableObject
{
	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0x18")]
	public float m_PlayerConditionLossPercentAfterMauling;

	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0x1C")]
	public float m_BearDespawnRadius;

	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_BearEarPrefab;

	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0x28")]
	public float m_MaxInitialStalkTimeSeconds;

	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxStalkTimeSeconds;

	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0x30")]
	public float m_PlayerStunnnedDuration;

	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinDistanceForSpearDrop;

	[Token(Token = "0x4000FC7")]
	[FieldOffset(Offset = "0x38")]
	public float m_MaxDistanceForSpearDrop;

	[Token(Token = "0x4000FC8")]
	[FieldOffset(Offset = "0x3C")]
	public float m_StruggleLengthMaxSeconds;

	[Token(Token = "0x4000FC9")]
	[FieldOffset(Offset = "0x40")]
	public float m_SpearStruggleDamagePerSecondToPlayer;

	[Token(Token = "0x4000FCA")]
	[FieldOffset(Offset = "0x44")]
	public float m_StruggleStartDamageAfterSeconds;

	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0x48")]
	public float m_SpearStruggleSecondsPerAttackMin;

	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x4C")]
	public float m_SpearStruggleSecondsPerAttackMax;

	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x50")]
	public float m_FleeDistanceForWanderAround;

	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x54")]
	public float m_WanderAroundRadiusAfterFlee;

	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x58")]
	public float m_IgnorePlayerAfterFleeWanderAroundDelaySeconds;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x5C")]
	public float m_SpearStruggleStaminaCost;

	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x60")]
	public float m_MaulingStruggleStaminaCost;

	[Header("UnreachableTargetFleeTimeout")]
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x64")]
	public float m_UnreachableTargetFleeTimeoutSeconds;

	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x68")]
	public float m_WanderRadiusAfterUnreachableTargetFleeTimeout;

	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x6C")]
	public float m_WanderDurationAfterUnreachableTargetFleeTimeout;

	[Header("Struggle scaling")]
	[Tooltip("Delay for 1st attack after struggle tap bar appears")]
	[Range(0f, 10f)]
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x70")]
	public float m_StruggleTapStrengthScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x74")]
	public float m_StrugglePlayerDamageReceivedIntervalScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x78")]
	public float m_StrugglePlayerDamageReceivedScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x7C")]
	public float m_StrugglePlayerClothingDamageScale;

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x62BCF0", Offset = "0x62AAF0", Length = "0xA8")]
	public BearHuntReduxSettings()
	{
	}
}
