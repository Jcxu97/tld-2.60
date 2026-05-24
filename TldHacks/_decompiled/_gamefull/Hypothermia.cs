using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200051D")]
public class Hypothermia : MonoBehaviour
{
	[Token(Token = "0x4002EE8")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002EE9")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002EEA")]
	[FieldOffset(Offset = "0x30")]
	public float m_HoursSpentFreezingRequired;

	[Token(Token = "0x4002EEB")]
	[FieldOffset(Offset = "0x34")]
	public float m_HPDrainPerHour;

	[Token(Token = "0x4002EEC")]
	[FieldOffset(Offset = "0x38")]
	public float m_FatigueIncreasePerHour;

	[Token(Token = "0x4002EED")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NumHoursWarmForCure;

	[Tooltip("For each wet clothing item on the innermost layer, hypothermia risk will increase X% faster, reducing the Hours Spent Freezing Required value above")]
	[Token(Token = "0x4002EEE")]
	[FieldOffset(Offset = "0x40")]
	public float m_HypothermiaRatePercentIncreasePerInnerWetItem;

	[Header("Audio")]
	[Token(Token = "0x4002EEF")]
	[FieldOffset(Offset = "0x48")]
	public string m_HypothermiaVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002EF0")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002EF1")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002EF2")]
	[FieldOffset(Offset = "0x60")]
	private bool m_Active;

	[Token(Token = "0x4002EF3")]
	[FieldOffset(Offset = "0x64")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002EF4")]
	[FieldOffset(Offset = "0x68")]
	private float m_ElapsedWarmTime;

	[Token(Token = "0x4002EF5")]
	[FieldOffset(Offset = "0x70")]
	private string m_CauseLocID;

	[Token(Token = "0x4002EF6")]
	[FieldOffset(Offset = "0x78")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002EF7")]
	[FieldOffset(Offset = "0x79")]
	private bool m_SuppressHypothermia;

	[Token(Token = "0x4002EF8")]
	private static HypothermiaSaveDataProxy m_HypothermiaSaveDataProxy;

	[Token(Token = "0x17000272")]
	public string m_DisplayName
	{
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000273")]
	public string m_Description
	{
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x8A7D60", Offset = "0x8A6B60", Length = "0xF")]
	public void Start()
	{
	}

	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x8A7D70", Offset = "0x8A6B70", Length = "0xC2")]
	public void Update()
	{
	}

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x8A7E40", Offset = "0x8A6C40", Length = "0x187")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x8A7FD0", Offset = "0x8A6DD0", Length = "0xF8")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x8A80D0", Offset = "0x8A6ED0", Length = "0x2DA")]
	public void HypothermiaStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x8A83B0", Offset = "0x8A71B0", Length = "0x11B")]
	public void HypothermiaEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x864050", Offset = "0x862E50", Length = "0x5")]
	public bool HasHypothermia()
	{
		return false;
	}

	[Token(Token = "0x60026E3")]
	[Address(RVA = "0x8A84D0", Offset = "0x8A72D0", Length = "0x19")]
	public bool HasHypothermiaRisk()
	{
		return false;
	}

	[Token(Token = "0x60026E4")]
	[Address(RVA = "0x8A84F0", Offset = "0x8A72F0", Length = "0xB")]
	public float GetHypothermiaRiskValue()
	{
		return 0f;
	}

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0x8A8500", Offset = "0x8A7300", Length = "0x1B")]
	public float GetWarmTimeAmountRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x8A8520", Offset = "0x8A7320", Length = "0x52")]
	public string GetCauseString()
	{
		return null;
	}

	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
	public string GetCauseLocalizationId()
	{
		return null;
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetWarmingUp(bool isWarming)
	{
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x8A8580", Offset = "0x8A7380", Length = "0x4")]
	public void SetSuppressHypothermia(bool suppress)
	{
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x8A8590", Offset = "0x8A7390", Length = "0x5")]
	public bool GetSuppressHypothermia()
	{
		return false;
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x8A85A0", Offset = "0x8A73A0", Length = "0x3B5")]
	private void UpdateHypothermia()
	{
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x8A8960", Offset = "0x8A7760", Length = "0x45A")]
	private void CheckForHypothermia()
	{
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x8A8DC0", Offset = "0x8A7BC0", Length = "0x148")]
	public float GetNumHoursWarmForCure()
	{
		return 0f;
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Hypothermia()
	{
	}
}
