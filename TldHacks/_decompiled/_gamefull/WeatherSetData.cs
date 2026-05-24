using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Weather Set")]
[Token(Token = "0x2000327")]
public class WeatherSetData : ScriptableObject
{
	[Token(Token = "0x2000328")]
	public delegate void WeatherStageChangedEvent(WeatherSetStage current);

	[Token(Token = "0x4001C2B")]
	private static WeatherSetDataInstanceSaveData m_WeatherSetInstanceSaveData;

	[Token(Token = "0x4001C2C")]
	private const float MIN_HOURS_FOR_REPORT_RESULT = 16f;

	[Token(Token = "0x4001C2D")]
	private const float NIGHT_WEIGHT_REDUCTION = 0.5f;

	[Token(Token = "0x4001C2E")]
	private const int DEACTIVATED_INDEX = -2;

	[Token(Token = "0x4001C2F")]
	[FieldOffset(Offset = "0x18")]
	public string m_CustomTypeName;

	[Token(Token = "0x4001C30")]
	[FieldOffset(Offset = "0x20")]
	public WeatherStage m_CharacterizingType;

	[Token(Token = "0x4001C31")]
	[FieldOffset(Offset = "0x24")]
	public int m_SameTypeSelectionWeight;

	[Token(Token = "0x4001C32")]
	[FieldOffset(Offset = "0x28")]
	public WeatherSetStage[] m_WeatherStages;

	[Token(Token = "0x4001C33")]
	[FieldOffset(Offset = "0x30")]
	public List<WeatherStage> m_UpgradedWeatherTypes;

	[Token(Token = "0x4001C34")]
	[FieldOffset(Offset = "0x38")]
	public WeatherStage m_DowngradedWeatherType;

	[Token(Token = "0x4001C35")]
	[FieldOffset(Offset = "0x3C")]
	public int m_ClearAsNextSelectionWeight;

	[Token(Token = "0x4001C36")]
	[FieldOffset(Offset = "0x40")]
	public int m_CloudyAsNextSelectionWeight;

	[Token(Token = "0x4001C37")]
	[FieldOffset(Offset = "0x44")]
	public int m_LightSnowAsNextSelectionWeight;

	[Token(Token = "0x4001C38")]
	[FieldOffset(Offset = "0x48")]
	public int m_HeavySnowAsNextSelectionWeight;

	[Token(Token = "0x4001C39")]
	[FieldOffset(Offset = "0x4C")]
	public int m_LightFogAsNextSelectionWeight;

	[Token(Token = "0x4001C3A")]
	[FieldOffset(Offset = "0x50")]
	public int m_DenseFogAsNextSelectionWeight;

	[Token(Token = "0x4001C3B")]
	[FieldOffset(Offset = "0x54")]
	public int m_ToxicFogAsNextSelectionWeight;

	[Token(Token = "0x4001C3C")]
	[FieldOffset(Offset = "0x58")]
	public int m_BlizzardAsNextSelectionWeight;

	[Token(Token = "0x4001C3D")]
	[FieldOffset(Offset = "0x5C")]
	public int m_ElectrostaticFogAsNextSelectionWeight;

	[HideInInspector]
	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0x60")]
	public bool m_IsDefaultSet;

	[Token(Token = "0x4001C3F")]
	public static WeatherStageChangedEvent OnWeatherStageChanged;

	[Token(Token = "0x4001C40")]
	[FieldOffset(Offset = "0x64")]
	public int m_CurrentIndex;

	[Token(Token = "0x4001C41")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurrentSetDuration;

	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x7433A0", Offset = "0x7421A0", Length = "0x20")]
	public bool IsComplete()
	{
		return false;
	}

	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x7433D0", Offset = "0x7421D0", Length = "0x10F")]
	public void Initialize(string name, WeatherSetStage[] stages)
	{
	}

	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x7434E0", Offset = "0x7422E0", Length = "0x156")]
	public void Prepare()
	{
	}

	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x743640", Offset = "0x742440", Length = "0x10B")]
	public void Activate(float startAtFrac = 0f, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x743750", Offset = "0x742550", Length = "0x4A")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x7437A0", Offset = "0x7425A0", Length = "0x236")]
	private void ActivateStage(float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x7439E0", Offset = "0x7427E0", Length = "0x44C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x743E30", Offset = "0x742C30", Length = "0x198")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x743FD0", Offset = "0x742DD0", Length = "0x289")]
	public void UpdateWeatherSet()
	{
	}

	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x744260", Offset = "0x743060", Length = "0xA0")]
	public float GetProgressFrac()
	{
		return 0f;
	}

	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x744310", Offset = "0x743110", Length = "0x6E")]
	public void ForceTransitionToStep(int forceIndex)
	{
	}

	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x744380", Offset = "0x743180", Length = "0x1F0")]
	public void ForceStep(int forceIndex)
	{
	}

	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x744580", Offset = "0x743380", Length = "0x41F")]
	public string GetDebugString()
	{
		return null;
	}

	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x7449A0", Offset = "0x7437A0", Length = "0x64")]
	private void WeatherSetComplete()
	{
	}

	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x744A10", Offset = "0x743810", Length = "0x2FE")]
	public float ReportHoursOfBlizzardForDay(int reportDay)
	{
		return 0f;
	}

	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x744D10", Offset = "0x743B10", Length = "0x57")]
	public void RefreshDuration()
	{
	}

	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x744D70", Offset = "0x743B70", Length = "0x776")]
	public WeatherStage ReportWeatherForDay(int reportDay)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x7454F0", Offset = "0x7442F0", Length = "0x1C3")]
	private WeatherStage GetBlendedWeatherPair(WeatherStage ws1, WeatherStage ws2, bool allowSubordination)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x7456C0", Offset = "0x7444C0", Length = "0x78")]
	private WeatherStage GetDowngradedWeatherType(WeatherStage ws)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x745740", Offset = "0x744540", Length = "0xEB")]
	private WeatherStage GetMoreSeriousWeatherType(WeatherStage ws1, WeatherStage ws2)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x745830", Offset = "0x744630", Length = "0x95")]
	public WeatherSetData()
	{
	}
}
