using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(NPC))]
[Token(Token = "0x2000868")]
public class NPCFreezing : MonoBehaviour
{
	[Token(Token = "0x2000869")]
	private class SaveData
	{
		[Token(Token = "0x4005721")]
		[FieldOffset(Offset = "0x10")]
		public float m_CurrentFreezing;

		[Token(Token = "0x4005722")]
		[FieldOffset(Offset = "0x14")]
		public float m_CurrentFreezingPerHour;

		[Token(Token = "0x4005723")]
		[FieldOffset(Offset = "0x18")]
		public float m_CurrentWarmingPerHour;

		[Token(Token = "0x6004D3E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveData()
		{
		}
	}

	[Token(Token = "0x200086A")]
	private enum Level
	{
		[Token(Token = "0x4005725")]
		Freezing,
		[Token(Token = "0x4005726")]
		Cold
	}

	[Token(Token = "0x4005711")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentFreezing;

	[Token(Token = "0x4005712")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxFreezing;

	[Token(Token = "0x4005713")]
	[FieldOffset(Offset = "0x28")]
	public float m_FreezingThreshold;

	[Token(Token = "0x4005714")]
	[FieldOffset(Offset = "0x2C")]
	public float m_TemperatureFreezingStarts;

	[Token(Token = "0x4005715")]
	[FieldOffset(Offset = "0x30")]
	public float m_FreezingIncreasePerHourPerDegreeCelsius;

	[Token(Token = "0x4005716")]
	[FieldOffset(Offset = "0x34")]
	public float m_WarmingIncreasePerHourPerDegreeCelsius;

	[Tooltip("Base warmth bonus for the NPC, in degrees Celsius")]
	[Token(Token = "0x4005717")]
	[FieldOffset(Offset = "0x38")]
	public float m_WarmthBonus;

	[Tooltip("Base wind chill bonus for the NPC, in degrees Celsius")]
	[Token(Token = "0x4005718")]
	[FieldOffset(Offset = "0x3C")]
	public float m_WindChillBonus;

	[Token(Token = "0x4005719")]
	[FieldOffset(Offset = "0x40")]
	public float m_FreezingRateScale;

	[Header("Audio")]
	[Token(Token = "0x400571A")]
	[FieldOffset(Offset = "0x48")]
	public string m_FreezingVoiceOver;

	[Token(Token = "0x400571B")]
	[FieldOffset(Offset = "0x50")]
	public string m_WarmingVoiceOver;

	[NonSerialized]
	[Token(Token = "0x400571C")]
	[FieldOffset(Offset = "0x58")]
	public float m_CurrentFreezingPerHour;

	[NonSerialized]
	[Token(Token = "0x400571D")]
	[FieldOffset(Offset = "0x5C")]
	public float m_CurrentWarmingPerHour;

	[NonSerialized]
	[Token(Token = "0x400571E")]
	[FieldOffset(Offset = "0x60")]
	public float m_CurrentTemperature;

	[NonSerialized]
	[Token(Token = "0x400571F")]
	[FieldOffset(Offset = "0x68")]
	public NPC m_NPC;

	[Token(Token = "0x4005720")]
	[FieldOffset(Offset = "0x70")]
	private Level m_LastVOLevel;

	[Token(Token = "0x6004D31")]
	[Address(RVA = "0xD84EA0", Offset = "0xD83CA0", Length = "0x14")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D32")]
	[Address(RVA = "0xD84EC0", Offset = "0xD83CC0", Length = "0xA8")]
	public float GetHealthyDelta(float delta)
	{
		return 0f;
	}

	[Token(Token = "0x6004D33")]
	[Address(RVA = "0xD84F70", Offset = "0xD83D70", Length = "0x115")]
	public void ApplyTODHours(float delta)
	{
	}

	[Token(Token = "0x6004D34")]
	[Address(RVA = "0xD85090", Offset = "0xD83E90", Length = "0x712")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[Token(Token = "0x6004D35")]
	[Address(RVA = "0xD857B0", Offset = "0xD845B0", Length = "0xD")]
	public bool IsFreezing()
	{
		return false;
	}

	[Token(Token = "0x6004D36")]
	[Address(RVA = "0xD857C0", Offset = "0xD845C0", Length = "0xA4")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6004D37")]
	[Address(RVA = "0xD85870", Offset = "0xD84670", Length = "0xC9")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004D38")]
	[Address(RVA = "0xD85940", Offset = "0xD84740", Length = "0x36B")]
	private float CalculateCurrentTemperature(bool inRangeOfFire)
	{
		return 0f;
	}

	[Token(Token = "0x6004D39")]
	[Address(RVA = "0xD85CB0", Offset = "0xD84AB0", Length = "0xF")]
	private Level GetCurrentFreezingLevel()
	{
		return default(Level);
	}

	[Token(Token = "0x6004D3A")]
	[Address(RVA = "0xD85CC0", Offset = "0xD84AC0", Length = "0x3A2")]
	private Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004D3B")]
	[Address(RVA = "0xD86070", Offset = "0xD84E70", Length = "0xF7")]
	private void MaybePlayVoiceOver()
	{
	}

	[Token(Token = "0x6004D3C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void EndHypothermia()
	{
	}

	[Token(Token = "0x6004D3D")]
	[Address(RVA = "0xD86170", Offset = "0xD84F70", Length = "0x4A")]
	public NPCFreezing()
	{
	}
}
