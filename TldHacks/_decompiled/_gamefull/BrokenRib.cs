using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004FD")]
public class BrokenRib : MonoBehaviour
{
	[Token(Token = "0x4002DB0")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002DB1")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002DB2")]
	[FieldOffset(Offset = "0x30")]
	public float m_FirstRibRecoveryTimeDays;

	[Token(Token = "0x4002DB3")]
	[FieldOffset(Offset = "0x34")]
	public float m_SecondaryRibRecoveryTimeDays;

	[Token(Token = "0x4002DB4")]
	[FieldOffset(Offset = "0x38")]
	public float m_SprintStaminaReduction;

	[Token(Token = "0x4002DB5")]
	[FieldOffset(Offset = "0x3C")]
	public float m_CarryingCapacityReduction;

	[Token(Token = "0x4002DB6")]
	[FieldOffset(Offset = "0x40")]
	public int m_PainKillersRequiredPerInstance;

	[Token(Token = "0x4002DB7")]
	[FieldOffset(Offset = "0x44")]
	public int m_BandagesRequiredPerInstance;

	[Token(Token = "0x4002DB8")]
	[FieldOffset(Offset = "0x48")]
	public string m_StartAudioID;

	[Token(Token = "0x4002DB9")]
	[FieldOffset(Offset = "0x50")]
	public string m_BrokenRibVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002DBA")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002DBB")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002DBC")]
	[FieldOffset(Offset = "0x68")]
	private List<string> m_CausesLocIDs;

	[Token(Token = "0x4002DBD")]
	[FieldOffset(Offset = "0x70")]
	private List<int> m_Locations;

	[Token(Token = "0x4002DBE")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_PainKillersTaken;

	[Token(Token = "0x4002DBF")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_BandagesApplied;

	[Token(Token = "0x4002DC0")]
	[FieldOffset(Offset = "0x88")]
	private List<float> m_ElapsedRestList;

	[Token(Token = "0x4002DC1")]
	[FieldOffset(Offset = "0x90")]
	private List<float> m_NumHoursRestForCureList;

	[Token(Token = "0x4002DC2")]
	[FieldOffset(Offset = "0x98")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002DC3")]
	private static BrokenRibSaveDataProxy m_BrokenRibSaveDataProxy;

	[Token(Token = "0x17000259")]
	public string m_DisplayName
	{
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025A")]
	public string m_Description
	{
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025C1")]
	[Address(RVA = "0x880990", Offset = "0x87F790", Length = "0x96")]
	public void Start()
	{
	}

	[Token(Token = "0x60025C2")]
	[Address(RVA = "0x880A30", Offset = "0x87F830", Length = "0x1E3")]
	public void Update()
	{
	}

	[Token(Token = "0x60025C3")]
	[Address(RVA = "0x880C20", Offset = "0x87FA20", Length = "0x413")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60025C4")]
	[Address(RVA = "0x881040", Offset = "0x87FE40", Length = "0x4A5")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60025C5")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool LocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60025C6")]
	[Address(RVA = "0x8814F0", Offset = "0x8802F0", Length = "0x136")]
	public void PlayBrokenRibAudio()
	{
	}

	[Token(Token = "0x60025C7")]
	[Address(RVA = "0x881630", Offset = "0x880430", Length = "0x4AD")]
	public void BrokenRibStart(string causeID, bool displayIcon, bool noVO = false, bool isMinor = false, bool autoSave = true, float recoveryTimeModifier = 0f)
	{
	}

	[Token(Token = "0x60025C8")]
	[Address(RVA = "0x881AE0", Offset = "0x8808E0", Length = "0x240")]
	public void BrokenRibEnd(int localIndex, bool displayIcon = true)
	{
	}

	[Token(Token = "0x60025C9")]
	[Address(RVA = "0x881D30", Offset = "0x880B30", Length = "0x9C")]
	public bool RequiresBandage(int localIndex)
	{
		return false;
	}

	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x881DD0", Offset = "0x880BD0", Length = "0xBB")]
	public int GetRequiredBandages(int localIndex)
	{
		return 0;
	}

	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x881E90", Offset = "0x880C90", Length = "0x99")]
	public bool RequiresPainKiller(int localIndex)
	{
		return false;
	}

	[Token(Token = "0x60025CC")]
	[Address(RVA = "0x881F30", Offset = "0x880D30", Length = "0xB5")]
	public int GetRequiredPainKiller(int localIndex)
	{
		return 0;
	}

	[Token(Token = "0x60025CD")]
	[Address(RVA = "0x881FF0", Offset = "0x880DF0", Length = "0x96")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60025CE")]
	[Address(RVA = "0x882090", Offset = "0x880E90", Length = "0x45")]
	public bool HasBrokenRib()
	{
		return false;
	}

	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x8820E0", Offset = "0x880EE0", Length = "0x49")]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[Token(Token = "0x60025D0")]
	[Address(RVA = "0x882130", Offset = "0x880F30", Length = "0x41")]
	public int GetBrokenRibCount()
	{
		return 0;
	}

	[Token(Token = "0x60025D1")]
	[Address(RVA = "0x882130", Offset = "0x880F30", Length = "0x41")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x882180", Offset = "0x880F80", Length = "0xAA")]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x882230", Offset = "0x881030", Length = "0xD8")]
	public void TakePainKillers(int localAfflictionIndex, int paintKillerCount)
	{
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x882310", Offset = "0x881110", Length = "0xDB")]
	public void ApplyBandage(int localAfflictionIndex, int bandageCount)
	{
	}

	[Token(Token = "0x60025D5")]
	[Address(RVA = "0x8823F0", Offset = "0x8811F0", Length = "0x5D")]
	public void Cure()
	{
	}

	[Token(Token = "0x60025D6")]
	[Address(RVA = "0x882450", Offset = "0x881250", Length = "0x1AB")]
	public void AddRest(float hours)
	{
	}

	[Token(Token = "0x60025D7")]
	[Address(RVA = "0x882600", Offset = "0x881400", Length = "0xA0")]
	public float GetRestAmountRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x60025D8")]
	[Address(RVA = "0x8826B0", Offset = "0x8814B0", Length = "0x74")]
	public float GetNumHoursRestForCure(int index)
	{
		return 0f;
	}

	[Token(Token = "0x60025D9")]
	[Address(RVA = "0x882730", Offset = "0x881530", Length = "0x36F")]
	public BrokenRib()
	{
	}
}
