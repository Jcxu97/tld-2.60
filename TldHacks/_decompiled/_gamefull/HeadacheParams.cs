using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Serializable]
[Token(Token = "0x20001EF")]
public class HeadacheParams
{
	[Token(Token = "0x4001155")]
	[FieldOffset(Offset = "0x44")]
	private float m_TimeSpentIndoor;

	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x48")]
	private float m_TimeSpentOutdoor;

	[Token(Token = "0x4001157")]
	[FieldOffset(Offset = "0x4C")]
	private float m_StartTimeInGameHours;

	[Token(Token = "0x4001158")]
	[FieldOffset(Offset = "0x50")]
	private float m_LastHeadachePulseTime;

	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x54")]
	private float m_HeadacheDurationHours;

	[Token(Token = "0x400115A")]
	[FieldOffset(Offset = "0x58")]
	private float m_HeadachePulseFrequencyStart;

	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x5C")]
	private float m_HeadachePulseFrequencyEnd;

	[Token(Token = "0x400115C")]
	[FieldOffset(Offset = "0x60")]
	private string m_HeadachePulseEvent;

	[Token(Token = "0x400115D")]
	[FieldOffset(Offset = "0x68")]
	private string m_HeadacheStartAudio;

	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x70")]
	private string m_HeadacheAfflictionIcoName;

	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x78")]
	private float m_HoursRequiredOutdoorToGetAffliction;

	[Header("Panel References")]
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x170001BA")]
	[field: Token(Token = "0x400114D")]
	[field: FieldOffset(Offset = "0x10")]
	public LocalizedString m_CausedByLocalizedId
	{
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6001180")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170001BB")]
	[field: Token(Token = "0x400114E")]
	[field: FieldOffset(Offset = "0x18")]
	public LocalizedString m_HeadacheLocalizedId
	{
		[Token(Token = "0x6001181")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170001BC")]
	[field: Token(Token = "0x400114F")]
	[field: FieldOffset(Offset = "0x20")]
	public LocalizedString m_HealedAfflictionLocalizedId
	{
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170001BD")]
	[field: Token(Token = "0x4001150")]
	[field: FieldOffset(Offset = "0x28")]
	public LocalizedString m_HeadacheDescription
	{
		[Token(Token = "0x6001185")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get;
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170001BE")]
	[field: Token(Token = "0x4001151")]
	[field: FieldOffset(Offset = "0x30")]
	public LocalizedString m_TreatmentRequiredDescription
	{
		[Token(Token = "0x6001187")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170001BF")]
	[field: Token(Token = "0x4001152")]
	[field: FieldOffset(Offset = "0x38")]
	public HeadacheStatus m_HeadacheStatus
	{
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get;
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x502770", Offset = "0x501570", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x170001C0")]
	[field: Token(Token = "0x4001153")]
	[field: FieldOffset(Offset = "0x3C")]
	public HeadacheCause m_Cause
	{
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
		get;
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x620C80", Offset = "0x61FA80", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x170001C1")]
	[field: Token(Token = "0x4001154")]
	[field: FieldOffset(Offset = "0x40")]
	public float m_HoursRequiredIndoorToExitAffliction
	{
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x502440", Offset = "0x501240", Length = "0x6")]
		get;
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x63F4F0", Offset = "0x63E2F0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HeadacheParams()
	{
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0x63F500", Offset = "0x63E300", Length = "0x305")]
	public HeadacheParams(HeadacheData data)
	{
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x63F810", Offset = "0x63E610", Length = "0x44")]
	public void OverrideDefaultValue(HeadacheParams oldHp, HeadacheParams newHp)
	{
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0x63F860", Offset = "0x63E660", Length = "0x327")]
	public HeadacheParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0x63FB90", Offset = "0x63E990", Length = "0x2DC")]
	public void Deserialize(HeadacheParamsSaveDataProxy saveDataProxy)
	{
	}

	[Token(Token = "0x6001194")]
	[Address(RVA = "0x63FE70", Offset = "0x63EC70", Length = "0xC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0x63FE80", Offset = "0x63EC80", Length = "0x1BB")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0x640040", Offset = "0x63EE40", Length = "0x22")]
	public void RemoveRisk()
	{
	}

	[Token(Token = "0x6001197")]
	[Address(RVA = "0x640070", Offset = "0x63EE70", Length = "0xE9")]
	public void Update()
	{
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0x640160", Offset = "0x63EF60", Length = "0x99")]
	public float GetActiveHoursRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x6001199")]
	[Address(RVA = "0x640200", Offset = "0x63F000", Length = "0x1B")]
	public float GetNormalizedTimeRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x600119A")]
	[Address(RVA = "0x640220", Offset = "0x63F020", Length = "0x12")]
	public bool IsAfflictionActive()
	{
		return false;
	}

	[Token(Token = "0x600119B")]
	[Address(RVA = "0x640240", Offset = "0x63F040", Length = "0x249")]
	private void AddHeadacheAffliction()
	{
	}

	[Token(Token = "0x600119C")]
	[Address(RVA = "0x640490", Offset = "0x63F290", Length = "0x84")]
	private void ApplyHeadacheExitEffects()
	{
	}

	[Token(Token = "0x600119D")]
	[Address(RVA = "0x640520", Offset = "0x63F320", Length = "0x206")]
	private void UpdateTimer()
	{
	}

	[Token(Token = "0x600119E")]
	[Address(RVA = "0x640730", Offset = "0x63F530", Length = "0xB")]
	private float HoursRequiredToDeactivateAfflictionRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x600119F")]
	[Address(RVA = "0x640740", Offset = "0x63F540", Length = "0xB")]
	private float HoursRequiredToActivateAfflictionRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x640750", Offset = "0x63F550", Length = "0x232")]
	public void SetStatus(HeadacheStatus status)
	{
	}

	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x640990", Offset = "0x63F790", Length = "0xF")]
	public bool NeedsTreatment()
	{
		return false;
	}

	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x6409A0", Offset = "0x63F7A0", Length = "0x16")]
	private void MaybePutOnHold()
	{
	}

	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x6409C0", Offset = "0x63F7C0", Length = "0xAB")]
	private void MaybePutOnHoldAfterRisk()
	{
	}

	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x640A70", Offset = "0x63F870", Length = "0x33")]
	private void MaybeActivate()
	{
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x640AB0", Offset = "0x63F8B0", Length = "0x31")]
	private void MaybeActivateWithCondition()
	{
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x640AF0", Offset = "0x63F8F0", Length = "0x28C")]
	private void MaybeStartHealing()
	{
	}
}
