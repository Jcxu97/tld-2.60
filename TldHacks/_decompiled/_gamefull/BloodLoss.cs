using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004FA")]
public class BloodLoss : MonoBehaviour
{
	[Token(Token = "0x4002D8D")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002D8E")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002D8F")]
	[FieldOffset(Offset = "0x30")]
	public float m_ChanceBloodLossAfterFall;

	[Token(Token = "0x4002D90")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002D91")]
	[FieldOffset(Offset = "0x38")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002D92")]
	[FieldOffset(Offset = "0x3C")]
	public float m_HPDrainPerHour;

	[Token(Token = "0x4002D93")]
	[FieldOffset(Offset = "0x40")]
	public float m_HPDrainPerHourBandaged;

	[Token(Token = "0x4002D94")]
	[FieldOffset(Offset = "0x44")]
	public float m_FatigueIncreasePerHour;

	[Token(Token = "0x4002D95")]
	[FieldOffset(Offset = "0x48")]
	public float m_FatigueIncreasePerHourBandaged;

	[Token(Token = "0x4002D96")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_BandagePrefab;

	[Token(Token = "0x4002D97")]
	[FieldOffset(Offset = "0x58")]
	public float m_HPThresholdForSound;

	[Token(Token = "0x4002D98")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ScentIntensity;

	[Token(Token = "0x4002D99")]
	[FieldOffset(Offset = "0x60")]
	public GameplayTag m_UseMinimumTimeForSave;

	[Header("Audio")]
	[Token(Token = "0x4002D9A")]
	[FieldOffset(Offset = "0x70")]
	public string m_SoundToPlayAboveThreshold;

	[Token(Token = "0x4002D9B")]
	[FieldOffset(Offset = "0x78")]
	public string m_SoundToPlayBelowThreshold;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002D9C")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002D9D")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002D9E")]
	[FieldOffset(Offset = "0x90")]
	private List<string> m_CausesLocIDs;

	[Token(Token = "0x4002D9F")]
	[FieldOffset(Offset = "0x98")]
	private List<int> m_Locations;

	[Token(Token = "0x4002DA0")]
	[FieldOffset(Offset = "0xA0")]
	private List<float> m_ElapsedHoursList;

	[Token(Token = "0x4002DA1")]
	[FieldOffset(Offset = "0xA8")]
	private List<float> m_DurationHoursList;

	[Token(Token = "0x4002DA2")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002DA3")]
	[FieldOffset(Offset = "0xB1")]
	private bool m_ForceNoDamage;

	[Token(Token = "0x4002DA4")]
	[FieldOffset(Offset = "0xB2")]
	private bool m_ShouldOverrideArea;

	[Token(Token = "0x4002DA5")]
	[FieldOffset(Offset = "0xB4")]
	private AfflictionBodyArea m_OverrideArea;

	[Token(Token = "0x4002DA6")]
	private static BloodLossSaveDataProxy m_BloodLossSaveDataProxy;

	[Token(Token = "0x17000254")]
	public string m_DisplayName
	{
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000255")]
	public string m_Description
	{
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x87E190", Offset = "0x87CF90", Length = "0x11")]
	private void Start()
	{
	}

	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x87E1B0", Offset = "0x87CFB0", Length = "0x26F")]
	public void Update()
	{
	}

	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x87E420", Offset = "0x87D220", Length = "0x313")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x87E740", Offset = "0x87D540", Length = "0x37B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x87EAC0", Offset = "0x87D8C0", Length = "0x19A")]
	public bool LocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x87EC60", Offset = "0x87DA60", Length = "0x44")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x87ECB0", Offset = "0x87DAB0", Length = "0xAD")]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x87ED60", Offset = "0x87DB60", Length = "0x2E")]
	public void BloodLossStartOverrideArea(AfflictionBodyArea area, string cause, bool displayIcon, AfflictionOptions options = AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave)
	{
	}

	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x87ED90", Offset = "0x87DB90", Length = "0xCE6")]
	public void BloodLossStart(string cause, bool displayIcon, AfflictionOptions options = AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave)
	{
	}

	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x87FA80", Offset = "0x87E880", Length = "0x27C")]
	public void BloodLossEnd(int index, AfflictionOptions options = AfflictionOptions.PlayFX)
	{
	}

	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x87FD00", Offset = "0x87EB00", Length = "0xC2")]
	public void Cure()
	{
	}

	[Token(Token = "0x60025AB")]
	[Address(RVA = "0x87FDD0", Offset = "0x87EBD0", Length = "0x48")]
	public bool HasBloodLoss()
	{
		return false;
	}

	[Token(Token = "0x60025AC")]
	[Address(RVA = "0x87FDD0", Offset = "0x87EBD0", Length = "0x48")]
	public bool RequiresBandage()
	{
		return false;
	}

	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x87FE20", Offset = "0x87EC20", Length = "0xC")]
	public void ApplyBandage(int index)
	{
	}

	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x87FE30", Offset = "0x87EC30", Length = "0x4C")]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[Token(Token = "0x60025AF")]
	[Address(RVA = "0x87FE80", Offset = "0x87EC80", Length = "0x96")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x87FF20", Offset = "0x87ED20", Length = "0x50")]
	public AfflictionBodyArea GetLocationOfLastAdded()
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x87FF80", Offset = "0x87ED80", Length = "0x8")]
	public bool GetNoDamage()
	{
		return false;
	}

	[Token(Token = "0x60025B2")]
	[Address(RVA = "0x87FF90", Offset = "0x87ED90", Length = "0x7")]
	public void SetNoDamage(bool noDamage)
	{
	}

	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x87FFA0", Offset = "0x87EDA0", Length = "0xBB")]
	private void UpdateBloodLoss(int index)
	{
	}

	[Token(Token = "0x60025B4")]
	[Address(RVA = "0x880060", Offset = "0x87EE60", Length = "0x271")]
	private void MaybeApplyDamage()
	{
	}

	[Token(Token = "0x60025B5")]
	[Address(RVA = "0x8802E0", Offset = "0x87F0E0", Length = "0x28F")]
	public BloodLoss()
	{
	}
}
