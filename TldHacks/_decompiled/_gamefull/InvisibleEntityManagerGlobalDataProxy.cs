using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000773")]
public class InvisibleEntityManagerGlobalDataProxy
{
	[Token(Token = "0x4004FE0")]
	[FieldOffset(Offset = "0x10")]
	public float m_AttackMovementSpeed;

	[Token(Token = "0x4004FE1")]
	[FieldOffset(Offset = "0x14")]
	public float m_MovementSpeedOverride;

	[Token(Token = "0x4004FE2")]
	[FieldOffset(Offset = "0x18")]
	public float m_AttackTime;

	[Token(Token = "0x4004FE3")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 m_EntityToPlayerPosition;

	[Token(Token = "0x4004FE4")]
	[FieldOffset(Offset = "0x28")]
	public float m_EntityToPlayerOrientation;

	[Token(Token = "0x4004FE5")]
	[FieldOffset(Offset = "0x2C")]
	public float m_StartMovementDelayTimeSeconds;

	[Token(Token = "0x4004FE6")]
	[FieldOffset(Offset = "0x30")]
	public int m_BehaviorIndex;

	[Token(Token = "0x4004FE7")]
	[FieldOffset(Offset = "0x34")]
	public float m_AccumulatedTimeSeconds;

	[Token(Token = "0x4004FE8")]
	[FieldOffset(Offset = "0x38")]
	public float m_AccumulatedRealTimeSeconds;

	[Token(Token = "0x4004FE9")]
	[FieldOffset(Offset = "0x40")]
	public List<IndoorWardData> m_IndoorWardLocations;

	[Token(Token = "0x60045DC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InvisibleEntityManagerGlobalDataProxy()
	{
	}
}
