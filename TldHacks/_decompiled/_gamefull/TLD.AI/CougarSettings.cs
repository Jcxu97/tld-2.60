using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[CreateAssetMenu(menuName = "The Long Dark/Ai/CougarSettings")]
[Token(Token = "0x2001504")]
public class CougarSettings : ScriptableObject
{
	[Header("Cougar Arrival Time")]
	[Tooltip("The minimum amount of time in region before the cougar will arrive in a territory")]
	[Token(Token = "0x4009805")]
	[FieldOffset(Offset = "0x18")]
	public float m_ArrivalTimeMinimumDays;

	[Tooltip("The maximum amount of time in region before the cougar will arrive in a territory")]
	[Token(Token = "0x4009806")]
	[FieldOffset(Offset = "0x1C")]
	public float m_ArrivalTimeGuaranteedDays;

	[Tooltip("The minimum amount of time before the arrival of the next cougar in a territory")]
	[Token(Token = "0x4009807")]
	[FieldOffset(Offset = "0x20")]
	public float m_ArrivalTimeStaggeringDays;

	[Tooltip("The odds a cougar will arrive in a territory")]
	[Token(Token = "0x4009808")]
	[FieldOffset(Offset = "0x24")]
	public float m_ArrivalChancePerDay;

	[Tooltip("How many days before the threat level is reduced by 1 to a minimum of threat level 1")]
	[Token(Token = "0x4009809")]
	[FieldOffset(Offset = "0x28")]
	public float m_ThreatCooldownDays;

	[Tooltip("How long to respawn a cougar into a spawn region after it has been killed")]
	[Token(Token = "0x400980A")]
	[FieldOffset(Offset = "0x2C")]
	public float m_RespawnCooldownDays;

	[Token(Token = "0x60084F4")]
	[Address(RVA = "0x126D8E0", Offset = "0x126C6E0", Length = "0x31")]
	public CougarSettings()
	{
	}
}
