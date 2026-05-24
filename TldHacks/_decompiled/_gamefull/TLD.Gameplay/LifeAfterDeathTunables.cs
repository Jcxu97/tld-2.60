using System;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.Serialization;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001482")]
public struct LifeAfterDeathTunables
{
	[Serializable]
	[Token(Token = "0x2001483")]
	public struct RespawnEnvironment
	{
		[Token(Token = "0x40094EA")]
		[FieldOffset(Offset = "0x0")]
		public WeatherStage[] m_PotentialWeatherStages;

		[Token(Token = "0x40094EB")]
		[FieldOffset(Offset = "0x8")]
		public string m_MinTOD;

		[Token(Token = "0x40094EC")]
		[FieldOffset(Offset = "0x10")]
		public string m_MaxTOD;

		[Tooltip("If the hours passed is below this threshold, we add 24 hours")]
		[Token(Token = "0x40094ED")]
		[FieldOffset(Offset = "0x18")]
		public float m_MinHoursPassed;
	}

	[Serializable]
	[Token(Token = "0x2001484")]
	public struct RespawnPlayerState
	{
		[Token(Token = "0x40094EE")]
		[FieldOffset(Offset = "0x0")]
		public RespawnStatus m_Condition;

		[Token(Token = "0x40094EF")]
		[FieldOffset(Offset = "0x8")]
		public RespawnStatus m_Fatigue;

		[Token(Token = "0x40094F0")]
		[FieldOffset(Offset = "0x10")]
		public RespawnStatus m_Thirst;

		[Token(Token = "0x40094F1")]
		[FieldOffset(Offset = "0x18")]
		public RespawnStatus m_Cold;

		[Token(Token = "0x40094F2")]
		[FieldOffset(Offset = "0x20")]
		public RespawnStatus m_Hunger;
	}

	[Serializable]
	[Token(Token = "0x2001485")]
	public struct RespawnStatus
	{
		[Range(0f, 1f)]
		[Token(Token = "0x40094F3")]
		[FieldOffset(Offset = "0x0")]
		public float m_Min;

		[Range(0f, 1f)]
		[Token(Token = "0x40094F4")]
		[FieldOffset(Offset = "0x4")]
		public float m_Max;
	}

	[Serializable]
	[Token(Token = "0x2001486")]
	public struct RespawnInventory
	{
		[Range(0f, 100f)]
		[Token(Token = "0x40094F5")]
		[FieldOffset(Offset = "0x0")]
		public float m_LostItemsPercent;

		[Range(0f, 100f)]
		[Token(Token = "0x40094F6")]
		[FieldOffset(Offset = "0x4")]
		public float m_WearableConditionDamagePercent;

		[Range(0f, 100f)]
		[Token(Token = "0x40094F7")]
		[FieldOffset(Offset = "0x8")]
		public float m_PercentageInContainer;

		[Range(0f, 100f)]
		[Token(Token = "0x40094F8")]
		[FieldOffset(Offset = "0xC")]
		public float m_LostDecorationItemsPercent;

		[Header("Kept Inventory")]
		[Min(0f)]
		[Token(Token = "0x40094F9")]
		[FieldOffset(Offset = "0x10")]
		public float m_KeptCalories;

		[Min(0f)]
		[Token(Token = "0x40094FA")]
		[FieldOffset(Offset = "0x14")]
		public int m_KeptMatches;

		[Min(0f)]
		[Token(Token = "0x40094FB")]
		[FieldOffset(Offset = "0x18")]
		public int m_KeptLightSources;

		[Min(0f)]
		[Token(Token = "0x40094FC")]
		[FieldOffset(Offset = "0x1C")]
		public int m_KeptTinder;

		[Min(0f)]
		[Token(Token = "0x40094FD")]
		[FieldOffset(Offset = "0x20")]
		public int m_KeptFirewood;

		[Min(0f)]
		[Token(Token = "0x40094FE")]
		[FieldOffset(Offset = "0x24")]
		public int m_KeptBedrolls;

		[Token(Token = "0x40094FF")]
		[FieldOffset(Offset = "0x28")]
		public ItemLiquidVolume m_KeptWaterPotable;

		[Token(Token = "0x4009500")]
		[FieldOffset(Offset = "0x30")]
		public ItemLiquidVolume m_KeptWaterNonpotable;
	}

	[Tooltip("0 means Life after Death is not available in the experience mode")]
	[Min(0f)]
	[Token(Token = "0x40094E2")]
	[FieldOffset(Offset = "0x0")]
	public int m_AvailableLives;

	[Header("Affliction Settings")]
	[Token(Token = "0x40094E3")]
	[FieldOffset(Offset = "0x4")]
	public float CheatDeathTempHoursActive;

	[Token(Token = "0x40094E4")]
	[FieldOffset(Offset = "0x8")]
	public float[] DiminishedStateHoursActivePerDeath;

	[Header("Respawn Environment Settings")]
	[Token(Token = "0x40094E5")]
	[FieldOffset(Offset = "0x10")]
	public RespawnEnvironment m_SafeSpawnEnvironment;

	[Token(Token = "0x40094E6")]
	[FieldOffset(Offset = "0x30")]
	public RespawnEnvironment m_RiskySpawnEnvironment;

	[Header("Player Respawn Settings")]
	[FormerlySerializedAs("m_SafeSpawnState")]
	[Token(Token = "0x40094E7")]
	[FieldOffset(Offset = "0x50")]
	public RespawnPlayerState m_SafeSpawnPlayerState;

	[FormerlySerializedAs("m_RiskySpawnState")]
	[Token(Token = "0x40094E8")]
	[FieldOffset(Offset = "0x78")]
	public RespawnPlayerState m_RiskySpawnPlayerState;

	[Token(Token = "0x40094E9")]
	[FieldOffset(Offset = "0xA0")]
	public RespawnInventory m_Inventory;
}
