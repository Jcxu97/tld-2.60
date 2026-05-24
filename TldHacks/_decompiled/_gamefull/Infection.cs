using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200051F")]
public class Infection : MonoBehaviour
{
	[Token(Token = "0x4002F04")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002F05")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002F06")]
	[FieldOffset(Offset = "0x30")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002F07")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002F08")]
	[FieldOffset(Offset = "0x38")]
	public float m_HPDrainPerHour;

	[Token(Token = "0x4002F09")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FatigueIncreasePerHour;

	[Token(Token = "0x4002F0A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_AntibioticsPrefab;

	[Token(Token = "0x4002F0B")]
	[FieldOffset(Offset = "0x48")]
	public float m_NumHoursRestForCure;

	[Header("Audio")]
	[Token(Token = "0x4002F0C")]
	[FieldOffset(Offset = "0x50")]
	public string m_InfectionVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002F0D")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002F0E")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002F0F")]
	[FieldOffset(Offset = "0x68")]
	private List<string> m_CausesLocIDs;

	[Token(Token = "0x4002F10")]
	[FieldOffset(Offset = "0x70")]
	private List<int> m_Locations;

	[Token(Token = "0x4002F11")]
	[FieldOffset(Offset = "0x78")]
	private List<float> m_ElapsedHoursList;

	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x80")]
	private List<float> m_DurationHoursList;

	[Token(Token = "0x4002F13")]
	[FieldOffset(Offset = "0x88")]
	private List<bool> m_AntibioticsTakenList;

	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x90")]
	private List<float> m_ElapsedRestList;

	[Token(Token = "0x4002F15")]
	[FieldOffset(Offset = "0x98")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002F16")]
	private static InfectionSaveDataProxy m_InfectionSaveDataProxy;

	[Token(Token = "0x17000274")]
	public string m_DisplayName
	{
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000275")]
	public string m_Description
	{
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026F3")]
	[Address(RVA = "0x8A8FC0", Offset = "0x8A7DC0", Length = "0x11")]
	public void Start()
	{
	}

	[Token(Token = "0x60026F4")]
	[Address(RVA = "0x8A8FE0", Offset = "0x8A7DE0", Length = "0x1AC")]
	public void Update()
	{
	}

	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x8A9190", Offset = "0x8A7F90", Length = "0x423")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x8A95C0", Offset = "0x8A83C0", Length = "0x485")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x8A9A50", Offset = "0x8A8850", Length = "0x197")]
	public bool LocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x8A9BF0", Offset = "0x8A89F0", Length = "0x3A9")]
	public void InfectionStart(string causeLocID, int location, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x8A9FA0", Offset = "0x8A8DA0", Length = "0x2F2")]
	public void InfectionEnd(int index)
	{
	}

	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x8AA2A0", Offset = "0x8A90A0", Length = "0xEE")]
	public void Cure()
	{
	}

	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x8AA390", Offset = "0x8A9190", Length = "0x45")]
	public bool HasInfection()
	{
		return false;
	}

	[Token(Token = "0x60026FC")]
	[Address(RVA = "0x8AA3E0", Offset = "0x8A91E0", Length = "0x9B")]
	public bool HasUntreatedInfection()
	{
		return false;
	}

	[Token(Token = "0x60026FD")]
	[Address(RVA = "0x8AA390", Offset = "0x8A9190", Length = "0x45")]
	public bool HasInfectionNeedingRest()
	{
		return false;
	}

	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x8AA480", Offset = "0x8A9280", Length = "0x97")]
	public bool HasTakenAntibiotics(int index)
	{
		return false;
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x8AA520", Offset = "0x8A9320", Length = "0xA0")]
	public float GetRestAmountRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x6002700")]
	[Address(RVA = "0x8AA5D0", Offset = "0x8A93D0", Length = "0x49")]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[Token(Token = "0x6002701")]
	[Address(RVA = "0x8AA620", Offset = "0x8A9420", Length = "0x41")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x6002702")]
	[Address(RVA = "0x8AA670", Offset = "0x8A9470", Length = "0xAA")]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Token(Token = "0x6002703")]
	[Address(RVA = "0x8AA720", Offset = "0x8A9520", Length = "0x93")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x6002704")]
	[Address(RVA = "0x8AA7C0", Offset = "0x8A95C0", Length = "0x99")]
	public void TakeAntibiotics(int localIndex)
	{
	}

	[Token(Token = "0x6002705")]
	[Address(RVA = "0x8AA860", Offset = "0x8A9660", Length = "0x10C")]
	public void AddRest(float hours)
	{
	}

	[Token(Token = "0x6002706")]
	[Address(RVA = "0x8AA970", Offset = "0x8A9770", Length = "0x4D2")]
	private void UpdateInfection(int index)
	{
	}

	[Token(Token = "0x6002707")]
	[Address(RVA = "0x8AAE50", Offset = "0x8A9C50", Length = "0x39F")]
	public Infection()
	{
	}
}
