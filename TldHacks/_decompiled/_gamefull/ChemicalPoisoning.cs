using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;
using Voice;

[Token(Token = "0x200050C")]
public class ChemicalPoisoning : AfflictionTriggerListener
{
	[Serializable]
	[Token(Token = "0x200050D")]
	public struct CommonAfflictionDataSet
	{
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x0")]
		public AfflictionDefinition m_Definition;

		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x8")]
		public AfflictionType m_Type;

		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x10")]
		public LocalizedString m_Cause;

		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x18")]
		public LocalizedString m_Gained;

		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x20")]
		public LocalizedString m_Removed;
	}

	[Token(Token = "0x200050E")]
	private enum ToxicityState
	{
		[Token(Token = "0x4002E5C")]
		Accumulate,
		[Token(Token = "0x4002E5D")]
		Idle,
		[Token(Token = "0x4002E5E")]
		RemovalDelay
	}

	[Token(Token = "0x4002E41")]
	public static bool s_ShowDebug;

	[Token(Token = "0x4002E42")]
	[FieldOffset(Offset = "0x28")]
	public CommonAfflictionDataSet m_AfflictionData;

	[Token(Token = "0x4002E43")]
	[FieldOffset(Offset = "0x50")]
	public CommonAfflictionDataSet m_RiskData;

	[Header("Toxicity Rates")]
	[Min(1f)]
	[Token(Token = "0x4002E44")]
	[FieldOffset(Offset = "0x78")]
	public float m_ToxicityMaxium;

	[Token(Token = "0x4002E45")]
	[FieldOffset(Offset = "0x7C")]
	public float m_ToxicityGainedPerHour;

	[Token(Token = "0x4002E46")]
	[FieldOffset(Offset = "0x80")]
	public float m_ToxicityLostPerHour;

	[Token(Token = "0x4002E47")]
	[FieldOffset(Offset = "0x84")]
	public float m_ToxicityRemovalDelayHours;

	[Range(0f, 1f)]
	[Token(Token = "0x4002E48")]
	[FieldOffset(Offset = "0x88")]
	public float m_ToxicityRiskWarningThreshold;

	[Header("Clothing Damage")]
	[Token(Token = "0x4002E49")]
	[FieldOffset(Offset = "0x8C")]
	public ClothingRegion m_ClothingDamageRegion;

	[Token(Token = "0x4002E4A")]
	[FieldOffset(Offset = "0x90")]
	public float m_ClothingHPLostPerHour;

	[Header("Screen Effect")]
	[Token(Token = "0x4002E4B")]
	[FieldOffset(Offset = "0x94")]
	public float m_ScreenEffectTransitionSeconds;

	[Header("Audio")]
	[Token(Token = "0x4002E4C")]
	[FieldOffset(Offset = "0x98")]
	public AK.Wwise.Event m_GainedAfflictionVO;

	[Token(Token = "0x4002E4D")]
	[FieldOffset(Offset = "0xA0")]
	public AK.Wwise.Event m_GainedRiskVO;

	[Token(Token = "0x4002E4E")]
	[FieldOffset(Offset = "0xA8")]
	public AK.Wwise.Event m_LostRiskVO;

	[Token(Token = "0x4002E4F")]
	[FieldOffset(Offset = "0xB0")]
	public Priority m_PlayerVoicePriority;

	[Token(Token = "0x4002E50")]
	[FieldOffset(Offset = "0xB4")]
	private float m_Toxicity;

	[Token(Token = "0x4002E51")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_InHazardZone;

	[Token(Token = "0x4002E52")]
	[FieldOffset(Offset = "0xBC")]
	private float m_RemovalDelayTime;

	[Token(Token = "0x4002E53")]
	private const int AFFLICTION_LIST_INITIAL_CAPACITY = 10;

	[Token(Token = "0x4002E54")]
	[FieldOffset(Offset = "0xC0")]
	private List<float> m_ActiveAfflictions;

	[Token(Token = "0x4002E55")]
	[FieldOffset(Offset = "0xC8")]
	private ToxicityState m_State;

	[Token(Token = "0x17000265")]
	public bool IsPlayerInHazardZone
	{
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x8352F0", Offset = "0x8340F0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0x89F460", Offset = "0x89E260", Length = "0xF")]
	protected override bool IsSupportedType(AfflictionType afflictionType)
	{
		return false;
	}

	[Token(Token = "0x600264C")]
	[Address(RVA = "0x89F470", Offset = "0x89E270", Length = "0x8")]
	public override void OnStartAffliction()
	{
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0x89F480", Offset = "0x89E280", Length = "0x8")]
	public override void OnStopAffliction()
	{
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0x89F490", Offset = "0x89E290", Length = "0xA6")]
	public void Deserialize(ChemicalPoisoningSaveData data)
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0x89F540", Offset = "0x89E340", Length = "0xAF")]
	public ChemicalPoisoningSaveData Serialize()
	{
		return default(ChemicalPoisoningSaveData);
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0x89F5F0", Offset = "0x89E3F0", Length = "0x41")]
	public void AddToxicity(float units)
	{
	}

	[Token(Token = "0x6002651")]
	[Address(RVA = "0x89F640", Offset = "0x89E440", Length = "0x55")]
	public void CureAll()
	{
	}

	[Token(Token = "0x6002652")]
	[Address(RVA = "0x89F6A0", Offset = "0x89E4A0", Length = "0x44")]
	public int GetAfflictionCount()
	{
		return 0;
	}

	[Token(Token = "0x6002653")]
	[Address(RVA = "0x89F6F0", Offset = "0x89E4F0", Length = "0x9A")]
	public float GetAfflictionTimeRemainingHours(int index)
	{
		return 0f;
	}

	[Token(Token = "0x6002654")]
	[Address(RVA = "0x89F790", Offset = "0x89E590", Length = "0xE")]
	public float GetNormalizedToxicity()
	{
		return 0f;
	}

	[Token(Token = "0x6002655")]
	[Address(RVA = "0x89F7A0", Offset = "0x89E5A0", Length = "0x57")]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[Token(Token = "0x6002656")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6002657")]
	[Address(RVA = "0x89F800", Offset = "0x89E600", Length = "0x48")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x6002658")]
	[Address(RVA = "0x89F850", Offset = "0x89E650", Length = "0x12")]
	public bool HasRisk()
	{
		return false;
	}

	[Token(Token = "0x6002659")]
	[Address(RVA = "0x89F870", Offset = "0x89E670", Length = "0xCF")]
	public void RemoveSingleAfflictionInstance()
	{
	}

	[Token(Token = "0x600265A")]
	[Address(RVA = "0x89F940", Offset = "0x89E740", Length = "0x14")]
	public void SkipDelay()
	{
	}

	[Token(Token = "0x600265B")]
	[Address(RVA = "0x89F960", Offset = "0x89E760", Length = "0x76")]
	public float GetScreenEffectTransitionTime()
	{
		return 0f;
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0x89F9E0", Offset = "0x89E7E0", Length = "0x63")]
	private bool IsHazardActive()
	{
		return false;
	}

	[Token(Token = "0x600265D")]
	[Address(RVA = "0x89FA50", Offset = "0x89E850", Length = "0x208")]
	private void ShowDamageNotification(CommonAfflictionDataSet dataSet, bool gained)
	{
	}

	[Token(Token = "0x600265E")]
	[Address(RVA = "0x89FC60", Offset = "0x89EA60", Length = "0xA0")]
	private void TriggerAudioNotification(AK.Wwise.Event voEvent)
	{
	}

	[Token(Token = "0x600265F")]
	[Address(RVA = "0x89FD10", Offset = "0x89EB10", Length = "0x10D")]
	public void SpawnAfflictionInstance()
	{
	}

	[Token(Token = "0x6002660")]
	[Address(RVA = "0x89FE20", Offset = "0x89EC20", Length = "0x1C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6002661")]
	[Address(RVA = "0x89FFF0", Offset = "0x89EDF0", Length = "0x1EC")]
	private void UpdateAfflictions(float deltaTODHours)
	{
	}

	[Token(Token = "0x6002662")]
	[Address(RVA = "0x8A01E0", Offset = "0x89EFE0", Length = "0x92")]
	private void UpdateHazardDamage(float deltaTODHours)
	{
	}

	[Token(Token = "0x6002663")]
	[Address(RVA = "0x8A0280", Offset = "0x89F080", Length = "0x6A")]
	private void SetState(ToxicityState newState)
	{
	}

	[Token(Token = "0x6002664")]
	[Address(RVA = "0x8A02F0", Offset = "0x89F0F0", Length = "0x2B2")]
	private void UpdateRisk(float deltaTODHours)
	{
	}

	[Token(Token = "0x6002665")]
	[Address(RVA = "0x8A05B0", Offset = "0x89F3B0", Length = "0x132")]
	private void UpdateState_Accumulate(float deltaTODHours)
	{
	}

	[Token(Token = "0x6002666")]
	[Address(RVA = "0x8A06F0", Offset = "0x89F4F0", Length = "0xEB")]
	private void UpdateState_Idle(float deltaTODHours)
	{
	}

	[Token(Token = "0x6002667")]
	[Address(RVA = "0x8A07E0", Offset = "0x89F5E0", Length = "0xE4")]
	private void UpdateState_RemovalDelay(float deltaTODHours)
	{
	}

	[Token(Token = "0x6002668")]
	[Address(RVA = "0x8A08D0", Offset = "0x89F6D0", Length = "0x1BB")]
	public ChemicalPoisoning()
	{
	}
}
