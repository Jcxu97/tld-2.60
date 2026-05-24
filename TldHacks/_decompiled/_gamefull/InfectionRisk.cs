using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000521")]
public class InfectionRisk : MonoBehaviour
{
	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Tooltip("The minimum number of hours until the infection check occurs")]
	[Token(Token = "0x4002F26")]
	[FieldOffset(Offset = "0x30")]
	public float m_InfectionRollMinHours;

	[Tooltip("The maximum number of hours until the infection check occurs")]
	[Token(Token = "0x4002F27")]
	[FieldOffset(Offset = "0x34")]
	public float m_InfectionRollMaxHours;

	[Range(0f, 100f)]
	[Token(Token = "0x4002F28")]
	[FieldOffset(Offset = "0x38")]
	public float m_InfectionBaseChance;

	[Range(0f, 100f)]
	[Token(Token = "0x4002F29")]
	[FieldOffset(Offset = "0x3C")]
	public float m_InfectionMaxChance;

	[Range(0f, 100f)]
	[Token(Token = "0x4002F2A")]
	[FieldOffset(Offset = "0x40")]
	public float m_InfectionChanceAntisepticReduction;

	[Token(Token = "0x4002F2B")]
	[FieldOffset(Offset = "0x44")]
	public float m_InfectionChanceIncreasePerHour;

	[Token(Token = "0x4002F2C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_BandagePrefab;

	[Token(Token = "0x4002F2D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_AntisepticPrefab;

	[Token(Token = "0x4002F2E")]
	[FieldOffset(Offset = "0x58")]
	public float m_CommentDelaySeconds;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002F2F")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002F30")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002F31")]
	[FieldOffset(Offset = "0x70")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002F32")]
	[FieldOffset(Offset = "0x74")]
	private float m_DurationHours;

	[Token(Token = "0x4002F33")]
	[FieldOffset(Offset = "0x78")]
	private bool m_AntisepticTaken;

	[Token(Token = "0x4002F34")]
	[FieldOffset(Offset = "0x7C")]
	private float m_CommentTime;

	[Token(Token = "0x4002F35")]
	[FieldOffset(Offset = "0x80")]
	private List<string> m_CausesLocIDs;

	[Token(Token = "0x4002F36")]
	[FieldOffset(Offset = "0x88")]
	private List<int> m_Locations;

	[Token(Token = "0x4002F37")]
	[FieldOffset(Offset = "0x90")]
	private List<int> m_ConstantAfflictionIndices;

	[Token(Token = "0x4002F38")]
	[FieldOffset(Offset = "0x98")]
	private List<float> m_ElapsedHoursList;

	[Token(Token = "0x4002F39")]
	[FieldOffset(Offset = "0xA0")]
	private List<float> m_DurationHoursList;

	[Token(Token = "0x4002F3A")]
	[FieldOffset(Offset = "0xA8")]
	private List<bool> m_AntisepticTakenList;

	[Token(Token = "0x4002F3B")]
	[FieldOffset(Offset = "0xB0")]
	private List<float> m_CurrentInfectionChanceList;

	[Token(Token = "0x4002F3C")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002F3D")]
	private static InfectionRiskSaveDataProxy m_InfectionRiskSaveDataProxy;

	[Token(Token = "0x17000276")]
	public string m_DisplayName
	{
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000277")]
	public string m_Description
	{
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600270C")]
	[Address(RVA = "0x8AB2A0", Offset = "0x8AA0A0", Length = "0x11")]
	public void Start()
	{
	}

	[Token(Token = "0x600270D")]
	[Address(RVA = "0x8AB2C0", Offset = "0x8AA0C0", Length = "0x1CB")]
	public void Update()
	{
	}

	[Token(Token = "0x600270E")]
	[Address(RVA = "0x8AB490", Offset = "0x8AA290", Length = "0x4C5")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600270F")]
	[Address(RVA = "0x8AB960", Offset = "0x8AA760", Length = "0x4DB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002710")]
	[Address(RVA = "0x8ABE40", Offset = "0x8AAC40", Length = "0x19A")]
	public bool LocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x6002711")]
	[Address(RVA = "0x8ABFE0", Offset = "0x8AADE0", Length = "0x1B7")]
	public void ConstantInfectionRiskStart(string cause, AfflictionBodyArea area, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x6002712")]
	[Address(RVA = "0x8AC1A0", Offset = "0x8AAFA0", Length = "0x389")]
	public void InfectionRiskStart(string cause, AfflictionBodyArea area, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x6002713")]
	[Address(RVA = "0x8AC530", Offset = "0x8AB330", Length = "0x374")]
	public void InfectionRiskEnd(int index, bool infected)
	{
	}

	[Token(Token = "0x6002714")]
	[Address(RVA = "0x8AC8B0", Offset = "0x8AB6B0", Length = "0xFB")]
	public void Cure()
	{
	}

	[Token(Token = "0x6002715")]
	[Address(RVA = "0x8AC9B0", Offset = "0x8AB7B0", Length = "0x48")]
	public bool HasInfectionRisk()
	{
		return false;
	}

	[Token(Token = "0x6002716")]
	[Address(RVA = "0x8ACA00", Offset = "0x8AB800", Length = "0xB9")]
	public int GetCurrentRisk(int index)
	{
		return 0;
	}

	[Token(Token = "0x6002717")]
	[Address(RVA = "0x8ACAC0", Offset = "0x8AB8C0", Length = "0x4C")]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[Token(Token = "0x6002718")]
	[Address(RVA = "0x8ACB10", Offset = "0x8AB910", Length = "0x44")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x6002719")]
	[Address(RVA = "0x8ACB60", Offset = "0x8AB960", Length = "0xAD")]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Token(Token = "0x600271A")]
	[Address(RVA = "0x8ACC10", Offset = "0x8ABA10", Length = "0x96")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x600271B")]
	[Address(RVA = "0x8ACCB0", Offset = "0x8ABAB0", Length = "0x18D")]
	public void TakeAntiseptic(int index)
	{
	}

	[Token(Token = "0x600271C")]
	[Address(RVA = "0x8ACE40", Offset = "0x8ABC40", Length = "0xFD")]
	public int GetIndexFromLocation(AfflictionBodyArea area)
	{
		return 0;
	}

	[Token(Token = "0x600271D")]
	[Address(RVA = "0x8ACF40", Offset = "0x8ABD40", Length = "0xFA")]
	public void ApplyAntisepticToLocation(AfflictionBodyArea area)
	{
	}

	[Token(Token = "0x600271E")]
	[Address(RVA = "0x8AD040", Offset = "0x8ABE40", Length = "0x9A")]
	public bool RequiresAntiseptic(int index)
	{
		return false;
	}

	[Token(Token = "0x600271F")]
	[Address(RVA = "0x8AD0E0", Offset = "0x8ABEE0", Length = "0x1AB")]
	private void CheckForInfection(int index)
	{
	}

	[Token(Token = "0x6002720")]
	[Address(RVA = "0x8AD290", Offset = "0x8AC090", Length = "0xA6")]
	private bool IsConstant(int index)
	{
		return false;
	}

	[Token(Token = "0x6002721")]
	[Address(RVA = "0x8AD340", Offset = "0x8AC140", Length = "0x490")]
	private void UpdateInfectionRisk(int index)
	{
	}

	[Token(Token = "0x6002722")]
	[Address(RVA = "0x8AD7E0", Offset = "0x8AC5E0", Length = "0x40F")]
	public InfectionRisk()
	{
	}
}
