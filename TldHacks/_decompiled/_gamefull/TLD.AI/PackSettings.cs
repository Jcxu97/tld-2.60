using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[CreateAssetMenu(menuName = "The Long Dark/Ai/PackSettings")]
[Token(Token = "0x2001506")]
public class PackSettings : ScriptableObject
{
	[Range(1f, 1000f)]
	[Token(Token = "0x4009817")]
	[FieldOffset(Offset = "0x18")]
	public float m_PackFormRange;

	[Range(0f, 1000f)]
	[Tooltip("Game Time (GT) to Real Time (RT) conversion: 1 hour = 6 minutes. So 15m GT = 1.5m RT.")]
	[Token(Token = "0x4009818")]
	[FieldOffset(Offset = "0x1C")]
	public float m_PackReformDelayTimeMinutes;

	[Range(0f, 1000f)]
	[Tooltip("Game Time (GT) to Real Time (RT) conversion: 1 hour = 6 minutes. So 15m GT = 1.5m RT.")]
	[Token(Token = "0x4009819")]
	[FieldOffset(Offset = "0x20")]
	public float m_TaggedGroupPackReformDelayTimeMinutes;

	[Range(1f, 48f)]
	[Token(Token = "0x400981A")]
	[FieldOffset(Offset = "0x24")]
	public float m_DisbandGroupOnForgetTargetAfterTimeHours;

	[Range(1f, 48f)]
	[Token(Token = "0x400981B")]
	[FieldOffset(Offset = "0x28")]
	public float m_DisbandTaggedGroupOnForgetTargetAfterTimeHours;

	[Range(1f, 48f)]
	[Token(Token = "0x400981C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_DespawnLonersAfterInteriorTimeHours;

	[Tooltip("When in hide and seek mode, use this attack rate")]
	[Range(0f, 120f)]
	[Token(Token = "0x400981D")]
	[FieldOffset(Offset = "0x30")]
	public float m_AttackCooldownSeconds;

	[Range(0f, 500f)]
	[Token(Token = "0x400981E")]
	[FieldOffset(Offset = "0x34")]
	public float m_HoldGroundBlueFlareDistance;

	[Tooltip("When in a confined combat restricted area, use this attack rate")]
	[Range(0f, 120f)]
	[Token(Token = "0x400981F")]
	[FieldOffset(Offset = "0x38")]
	public float m_AttackCombatRestrictedCooldownSeconds;

	[Range(0f, 600f)]
	[Token(Token = "0x4009820")]
	[FieldOffset(Offset = "0x3C")]
	public float m_HoldGroundCombatRestrictedTimeSeconds;

	[Range(0f, 600f)]
	[Token(Token = "0x4009821")]
	[FieldOffset(Offset = "0x40")]
	public float m_HoldGroundTimeSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x4009822")]
	[FieldOffset(Offset = "0x44")]
	public float m_FleeMoraleThreshold;

	[Range(0f, 100f)]
	[Token(Token = "0x4009823")]
	[FieldOffset(Offset = "0x48")]
	public float m_MinMoraleFleeChance;

	[Range(0f, 100f)]
	[Token(Token = "0x4009824")]
	[FieldOffset(Offset = "0x4C")]
	public float m_MaxMoraleFleeChance;

	[Range(0f, 1000f)]
	[Token(Token = "0x4009825")]
	[FieldOffset(Offset = "0x50")]
	public float m_FleeFromBearRange;

	[Space]
	[Range(-100f, 100f)]
	[Token(Token = "0x4009826")]
	[FieldOffset(Offset = "0x54")]
	public float m_MoraleModifierHitByBlueFlarePercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009827")]
	[FieldOffset(Offset = "0x58")]
	public float m_MoraleModifierHitByRedFlarePercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009828")]
	[FieldOffset(Offset = "0x5C")]
	public float m_MoraleModifierHitByTorchPercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009829")]
	[FieldOffset(Offset = "0x60")]
	public float m_MoraleModifierHitByStonePercent;

	[Space]
	[Range(-100f, 100f)]
	[Token(Token = "0x400982A")]
	[FieldOffset(Offset = "0x64")]
	public float m_MoraleModifierThrownRedFlarePercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x400982B")]
	[FieldOffset(Offset = "0x68")]
	public float m_MoraleModifierThrownBlueFlarePercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x400982C")]
	[FieldOffset(Offset = "0x6C")]
	public float m_MoraleModifierThrownTorchPercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x400982D")]
	[FieldOffset(Offset = "0x70")]
	public float m_MoraleModifierThrownStonePercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x400982E")]
	[FieldOffset(Offset = "0x74")]
	public float m_MoraleModifierThrownNoiseMakerPercent;

	[Space]
	[Range(-100f, 100f)]
	[Token(Token = "0x400982F")]
	[FieldOffset(Offset = "0x78")]
	public float m_MoraleModifierOnFlareGunRoundPercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009830")]
	[FieldOffset(Offset = "0x7C")]
	public float m_MoraleModifierOnFlareGunRoundStuckInAnimalPercent;

	[Space]
	[Range(0.1f, 100f)]
	[Token(Token = "0x4009831")]
	[FieldOffset(Offset = "0x80")]
	public float m_ReactToGunShotDistance;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009832")]
	[FieldOffset(Offset = "0x84")]
	public float m_MoraleModifierNearMissGunshotPercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009833")]
	[FieldOffset(Offset = "0x88")]
	public float m_MoraleModifierGunshotPercent;

	[Space]
	[Range(-100f, 100f)]
	[Token(Token = "0x4009834")]
	[FieldOffset(Offset = "0x8C")]
	public float m_MoraleModifierDamagePercent;

	[Range(-100f, 100f)]
	[Token(Token = "0x4009835")]
	[FieldOffset(Offset = "0x90")]
	public float m_MoraleModifierDamageLeaderPercent;

	[Range(0f, 30f)]
	[Token(Token = "0x4009836")]
	[FieldOffset(Offset = "0x94")]
	public float m_MoraleModifierMultiplierAuroraActive;

	[Range(0.1f, 1000f)]
	[Token(Token = "0x4009837")]
	[FieldOffset(Offset = "0x98")]
	public float m_PackFormationRange;

	[Range(0f, 1000f)]
	[Token(Token = "0x4009838")]
	[FieldOffset(Offset = "0x9C")]
	public float m_MinBleedOutTimeMinutes;

	[Token(Token = "0x60084FF")]
	[Address(RVA = "0x126EB20", Offset = "0x126D920", Length = "0x10D")]
	public PackSettings()
	{
	}
}
