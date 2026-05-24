using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000523")]
public class IntestinalParasites : MonoBehaviour
{
	[Tooltip("The minimum number of hours until the infection check occurs")]
	[Token(Token = "0x4002F48")]
	[FieldOffset(Offset = "0x20")]
	public float m_InfectionRollMinHours;

	[Tooltip("The maximum number of hours until the infection check occurs")]
	[Token(Token = "0x4002F49")]
	[FieldOffset(Offset = "0x24")]
	public float m_InfectionRollMaxHours;

	[Tooltip("Parasites risk will reduce each day that you have risk and don't eat more carnivore meat.")]
	[Token(Token = "0x4002F4A")]
	[FieldOffset(Offset = "0x28")]
	public float m_ChanceReductionPerDay;

	[Token(Token = "0x4002F4B")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxHitPointReductionPerDay;

	[Token(Token = "0x4002F4C")]
	[FieldOffset(Offset = "0x30")]
	public float m_MaxFatigueReductionPerDay;

	[Header("Audio")]
	[Token(Token = "0x4002F4D")]
	[FieldOffset(Offset = "0x38")]
	public string m_ParasitesVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002F4E")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002F4F")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002F50")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasParasites;

	[Token(Token = "0x4002F51")]
	[FieldOffset(Offset = "0x51")]
	private bool m_HasParasiteRisk;

	[Token(Token = "0x4002F52")]
	[FieldOffset(Offset = "0x54")]
	private float m_ParasitesElapsedHours;

	[Token(Token = "0x4002F53")]
	[FieldOffset(Offset = "0x58")]
	private float m_RiskElapsedHours;

	[Token(Token = "0x4002F54")]
	[FieldOffset(Offset = "0x5C")]
	private float m_RiskDurationHours;

	[Token(Token = "0x4002F55")]
	[FieldOffset(Offset = "0x60")]
	private int m_NumDosesTaken;

	[Token(Token = "0x4002F56")]
	[FieldOffset(Offset = "0x64")]
	private bool m_HasTakenDoseToday;

	[Token(Token = "0x4002F57")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurrentInfectionChance;

	[Token(Token = "0x4002F58")]
	[FieldOffset(Offset = "0x6C")]
	private int m_DayToAllowNextDose;

	[Token(Token = "0x4002F59")]
	[FieldOffset(Offset = "0x70")]
	private int m_NumPiecesEatenThisRiskCycle;

	[Token(Token = "0x4002F5A")]
	[FieldOffset(Offset = "0x74")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002F5B")]
	private static IntestinalParasitesSaveDataProxy m_IntestinalParasitesSaveDataProxy;

	[Token(Token = "0x6002725")]
	[Address(RVA = "0x8ADCA0", Offset = "0x8ACAA0", Length = "0xB")]
	public void Start()
	{
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0x8ADCB0", Offset = "0x8ACAB0", Length = "0x203")]
	public void Update()
	{
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0x8ADEC0", Offset = "0x8ACCC0", Length = "0x202")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002728")]
	[Address(RVA = "0x8AE0D0", Offset = "0x8ACED0", Length = "0xD2")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002729")]
	[Address(RVA = "0x8AE1B0", Offset = "0x8ACFB0", Length = "0x294")]
	public void AddRiskPercent(float[] riskToAdd, bool nofx = false)
	{
	}

	[Token(Token = "0x600272A")]
	[Address(RVA = "0x8AE450", Offset = "0x8AD250", Length = "0x2A7")]
	public void IntestinalParasitesStart(bool nofx = false)
	{
	}

	[Token(Token = "0x600272B")]
	[Address(RVA = "0x8AE700", Offset = "0x8AD500", Length = "0x121")]
	public void IntestinalParasitesEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x600272C")]
	[Address(RVA = "0x6674B0", Offset = "0x6662B0", Length = "0x5")]
	public bool HasIntestinalParasites()
	{
		return false;
	}

	[Token(Token = "0x600272D")]
	[Address(RVA = "0x8AE830", Offset = "0x8AD630", Length = "0xE")]
	public bool HasIntestinalParasitesRisk()
	{
		return false;
	}

	[Token(Token = "0x600272E")]
	[Address(RVA = "0x8AE840", Offset = "0x8AD640", Length = "0x28")]
	public int GetCurrentRisk()
	{
		return 0;
	}

	[Token(Token = "0x600272F")]
	[Address(RVA = "0x8AE870", Offset = "0x8AD670", Length = "0x46")]
	public void TakeAntibiotics()
	{
	}

	[Token(Token = "0x6002730")]
	[Address(RVA = "0x8AE8C0", Offset = "0x8AD6C0", Length = "0x4")]
	public int GetNumDosesTaken()
	{
		return 0;
	}

	[Token(Token = "0x6002731")]
	[Address(RVA = "0x8AE8D0", Offset = "0x8AD6D0", Length = "0x19")]
	public int GetNumDosesRemaining()
	{
		return 0;
	}

	[Token(Token = "0x6002732")]
	[Address(RVA = "0x502540", Offset = "0x501340", Length = "0x5")]
	public bool HasTakenDoseToday()
	{
		return false;
	}

	[Token(Token = "0x6002733")]
	[Address(RVA = "0x8AE8F0", Offset = "0x8AD6F0", Length = "0x1EC")]
	public int GetNumDosesRequired()
	{
		return 0;
	}

	[Token(Token = "0x6002734")]
	[Address(RVA = "0x8AEAE0", Offset = "0x8AD8E0", Length = "0x1D")]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[Token(Token = "0x6002735")]
	[Address(RVA = "0x8AEB00", Offset = "0x8AD900", Length = "0x1D")]
	public float GetTotalFatigueReduction()
	{
		return 0f;
	}

	[Token(Token = "0x6002736")]
	[Address(RVA = "0x8AEB20", Offset = "0x8AD920", Length = "0x1EF")]
	private void CheckForInfection()
	{
	}

	[Token(Token = "0x6002737")]
	[Address(RVA = "0x8AED10", Offset = "0x8ADB10", Length = "0xF1")]
	private void UpdateIntestinalParasites()
	{
	}

	[Token(Token = "0x6002738")]
	[Address(RVA = "0x8AEE10", Offset = "0x8ADC10", Length = "0x2D")]
	private void RestartRiskTimer()
	{
	}

	[Token(Token = "0x6002739")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public IntestinalParasites()
	{
	}
}
