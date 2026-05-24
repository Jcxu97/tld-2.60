using System;
using Cpp2ILInjected;
using UnityEngine;

[Obsolete("WeatherSet components have been replaced with WeatherSetData scriptable objects")]
[Token(Token = "0x2000324")]
public class WeatherSet : MonoBehaviour
{
	[Token(Token = "0x2000325")]
	private class WeatherSetInstanceSaveData
	{
		[Token(Token = "0x4001C23")]
		[FieldOffset(Offset = "0x10")]
		public int m_CurrentIndex;

		[Token(Token = "0x4001C24")]
		[FieldOffset(Offset = "0x14")]
		public float m_CurrentStageElapsedTime;

		[Token(Token = "0x4001C25")]
		[FieldOffset(Offset = "0x18")]
		public float[] m_StageDurations;

		[Token(Token = "0x4001C26")]
		[FieldOffset(Offset = "0x20")]
		public float[] m_StageTransitionTimes;

		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public WeatherSetInstanceSaveData()
		{
		}
	}

	[Token(Token = "0x4001C11")]
	private static WeatherSetInstanceSaveData m_WeatherSetInstanceSaveData;

	[Token(Token = "0x4001C12")]
	private const float MIN_HOURS_FOR_REPORT_RESULT = 16f;

	[Token(Token = "0x4001C13")]
	private const float NIGHT_WEIGHT_REDUCTION = 0.5f;

	[Token(Token = "0x4001C14")]
	[FieldOffset(Offset = "0x20")]
	public string m_CustomTypeName;

	[Token(Token = "0x4001C15")]
	[FieldOffset(Offset = "0x28")]
	public WeatherStage m_CharacterizingType;

	[Token(Token = "0x4001C16")]
	[FieldOffset(Offset = "0x2C")]
	public int m_SameTypeSelectionWeight;

	[Token(Token = "0x4001C17")]
	[FieldOffset(Offset = "0x30")]
	public WeatherSetStage[] m_WeatherStages;

	[Token(Token = "0x4001C18")]
	[FieldOffset(Offset = "0x38")]
	public int m_ClearAsNextSelectionWeight;

	[Token(Token = "0x4001C19")]
	[FieldOffset(Offset = "0x3C")]
	public int m_CloudyAsNextSelectionWeight;

	[Token(Token = "0x4001C1A")]
	[FieldOffset(Offset = "0x40")]
	public int m_LightSnowAsNextSelectionWeight;

	[Token(Token = "0x4001C1B")]
	[FieldOffset(Offset = "0x44")]
	public int m_HeavySnowAsNextSelectionWeight;

	[Token(Token = "0x4001C1C")]
	[FieldOffset(Offset = "0x48")]
	public int m_LightFogAsNextSelectionWeight;

	[Token(Token = "0x4001C1D")]
	[FieldOffset(Offset = "0x4C")]
	public int m_DenseFogAsNextSelectionWeight;

	[Token(Token = "0x4001C1E")]
	[FieldOffset(Offset = "0x50")]
	public int m_ToxicFogAsNextSelectionWeight;

	[Token(Token = "0x4001C1F")]
	[FieldOffset(Offset = "0x54")]
	public int m_BlizzardAsNextSelectionWeight;

	[HideInInspector]
	[Token(Token = "0x4001C20")]
	[FieldOffset(Offset = "0x58")]
	public bool m_IsDefaultSet;

	[Token(Token = "0x4001C21")]
	[FieldOffset(Offset = "0x5C")]
	public int m_CurrentIndex;

	[Token(Token = "0x4001C22")]
	[FieldOffset(Offset = "0x60")]
	private float m_CurrentSetDuration;

	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x740FF0", Offset = "0x73FDF0", Length = "0x20")]
	public bool IsComplete()
	{
		return false;
	}

	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x741020", Offset = "0x73FE20", Length = "0x107")]
	public void Initialize(string name, WeatherSetStage[] stages)
	{
	}

	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x741130", Offset = "0x73FF30", Length = "0x156")]
	public void Prepare()
	{
	}

	[Token(Token = "0x60019C9")]
	[Address(RVA = "0x741290", Offset = "0x740090", Length = "0x12B")]
	public void Activate(float startAtFrac = 0f, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x7413C0", Offset = "0x7401C0", Length = "0xC2")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x741490", Offset = "0x740290", Length = "0x1CB")]
	private void ActivateStage(float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x741660", Offset = "0x740460", Length = "0x44C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x741AB0", Offset = "0x7408B0", Length = "0x198")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x741C50", Offset = "0x740A50", Length = "0x289")]
	private void Update()
	{
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x741EE0", Offset = "0x740CE0", Length = "0xA0")]
	public float GetProgressFrac()
	{
		return 0f;
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x741F90", Offset = "0x740D90", Length = "0x6E")]
	public void ForceTransitionToStep(int forceIndex)
	{
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x742000", Offset = "0x740E00", Length = "0x1F0")]
	public void ForceStep(int forceIndex)
	{
	}

	[Token(Token = "0x60019D2")]
	[Address(RVA = "0x742200", Offset = "0x741000", Length = "0x244")]
	public string GetDebugString()
	{
		return null;
	}

	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x742450", Offset = "0x741250", Length = "0x64")]
	private void WeatherSetComplete()
	{
	}

	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x7424C0", Offset = "0x7412C0", Length = "0x2FE")]
	public float ReportHoursOfBlizzardForDay(int reportDay)
	{
		return 0f;
	}

	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x7427C0", Offset = "0x7415C0", Length = "0x57")]
	public void RefreshDuration()
	{
	}

	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x742820", Offset = "0x741620", Length = "0x776")]
	public WeatherStage ReportWeatherForDay(int reportDay)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019D7")]
	[Address(RVA = "0x742FA0", Offset = "0x741DA0", Length = "0x170")]
	private WeatherStage GetBlendedWeatherPair(WeatherStage ws1, WeatherStage ws2, bool allowSubordination)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x743190", Offset = "0x741F90", Length = "0x48")]
	private WeatherStage GetDowngradedWeatherType(WeatherStage ws)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x743200", Offset = "0x742000", Length = "0x78")]
	private WeatherStage GetMoreSeriousWeatherType(WeatherStage ws1, WeatherStage ws2)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WeatherSet()
	{
	}
}
