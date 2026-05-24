using System;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200065C")]
public class Panel_Harvest : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[SerializeField]
	[Token(Token = "0x4003E0E")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x4003E0F")]
	[FieldOffset(Offset = "0x38")]
	public float m_HarvestTimeSeconds;

	[Token(Token = "0x4003E10")]
	[FieldOffset(Offset = "0x40")]
	public UITexture m_ItemBGSprite;

	[Token(Token = "0x4003E11")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_ItemNameLabel;

	[Token(Token = "0x4003E12")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_AmountObject;

	[Token(Token = "0x4003E13")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_AmountLabel;

	[Token(Token = "0x4003E14")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_TimeObject;

	[Token(Token = "0x4003E15")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_TimeLabel;

	[Token(Token = "0x4003E16")]
	[FieldOffset(Offset = "0x70")]
	public HarvestRepairMaterial[] m_HarvestYields;

	[Token(Token = "0x4003E17")]
	[FieldOffset(Offset = "0x78")]
	public float m_HarvestYieldCenteredX;

	[Token(Token = "0x4003E18")]
	[FieldOffset(Offset = "0x7C")]
	public float m_HarvestYieldSpacing;

	[Token(Token = "0x4003E19")]
	[FieldOffset(Offset = "0x80")]
	public string m_IconAccelerateTime;

	[HideInInspector]
	[Token(Token = "0x4003E1A")]
	[FieldOffset(Offset = "0x88")]
	public bool m_EnableDiaryOnExit;

	[Token(Token = "0x4003E1B")]
	[FieldOffset(Offset = "0x8C")]
	private float m_ElapsedProgressBarSeconds;

	[Token(Token = "0x4003E1C")]
	[FieldOffset(Offset = "0x90")]
	private float m_ProgressBarTimeSeconds;

	[Token(Token = "0x4003E1D")]
	[FieldOffset(Offset = "0x94")]
	private float m_DayLengthScaleBeforeRepair;

	[HideInInspector]
	[Token(Token = "0x4003E1E")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_Label_RepairProgress;

	[HideInInspector]
	[Token(Token = "0x4003E1F")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_Progress_Repair;

	[HideInInspector]
	[Token(Token = "0x4003E20")]
	[FieldOffset(Offset = "0xA8")]
	public GearItem m_AutoSelectItem;

	[Token(Token = "0x4003E21")]
	[FieldOffset(Offset = "0xB0")]
	private GearItem m_HarvestItem;

	[Token(Token = "0x4003E22")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_ProgressBarAudio;

	[Token(Token = "0x4003E23")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x4003E24")]
	[FieldOffset(Offset = "0xBD")]
	private bool m_HarvestInProgress;

	[Token(Token = "0x4003E25")]
	[FieldOffset(Offset = "0xC0")]
	private int m_NumUnitsToHarvest;

	[Token(Token = "0x4003E26")]
	[FieldOffset(Offset = "0xC4")]
	private int m_NumUnitsLeftToHarvest;

	[Token(Token = "0x4003E27")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 m_TimeObjectOrigPos;

	[Token(Token = "0x600341C")]
	[Address(RVA = "0xA56450", Offset = "0xA55250", Length = "0x249")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600341D")]
	[Address(RVA = "0xA566A0", Offset = "0xA554A0", Length = "0x4FB")]
	private void Update()
	{
	}

	[Token(Token = "0x600341E")]
	[Address(RVA = "0xA56BA0", Offset = "0xA559A0", Length = "0x238")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600341F")]
	[Address(RVA = "0xA56DE0", Offset = "0xA55BE0", Length = "0x7BD")]
	private void HarvestSuccessful()
	{
	}

	[Token(Token = "0x6003420")]
	[Address(RVA = "0xA575A0", Offset = "0xA563A0", Length = "0x15E")]
	public void OnAmountIncrease()
	{
	}

	[Token(Token = "0x6003421")]
	[Address(RVA = "0xA57700", Offset = "0xA56500", Length = "0x7F")]
	public void OnAmountDecrease()
	{
	}

	[Token(Token = "0x6003422")]
	[Address(RVA = "0xA57780", Offset = "0xA56580", Length = "0x2C4")]
	public void OnHarvest()
	{
	}

	[Token(Token = "0x6003423")]
	[Address(RVA = "0xA57A50", Offset = "0xA56850", Length = "0x4C")]
	public bool HarvestInProgress()
	{
		return false;
	}

	[Token(Token = "0x6003424")]
	[Address(RVA = "0xA57AA0", Offset = "0xA568A0", Length = "0x12D")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003425")]
	[Address(RVA = "0xA57BD0", Offset = "0xA569D0", Length = "0x188")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003426")]
	[Address(RVA = "0xA57D60", Offset = "0xA56B60", Length = "0x3B9")]
	public void StartHarvest(int numUnits, int durationMinutes, string harvestAudio)
	{
	}

	[Token(Token = "0x6003427")]
	[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
	private GearItem GetSelectedHarvestItem()
	{
		return null;
	}

	[Token(Token = "0x6003428")]
	[Address(RVA = "0xA58120", Offset = "0xA56F20", Length = "0x192")]
	private void RefreshRepairProgressLabel()
	{
	}

	[Token(Token = "0x6003429")]
	[Address(RVA = "0xA582C0", Offset = "0xA570C0", Length = "0x3F")]
	private void DisableProgressBar()
	{
	}

	[Token(Token = "0x600342A")]
	[Address(RVA = "0xA58300", Offset = "0xA57100", Length = "0xA8E")]
	private void Refresh()
	{
	}

	[Token(Token = "0x600342B")]
	[Address(RVA = "0xA58D90", Offset = "0xA57B90", Length = "0x57")]
	private void StopProgressBarAudio()
	{
	}

	[Token(Token = "0x600342C")]
	[Address(RVA = "0xA58DF0", Offset = "0xA57BF0", Length = "0x232")]
	private void UpdateHarvest()
	{
	}

	[Token(Token = "0x600342D")]
	[Address(RVA = "0xA59030", Offset = "0xA57E30", Length = "0x77")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x600342E")]
	[Address(RVA = "0xA590B0", Offset = "0xA57EB0", Length = "0xA9")]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[Token(Token = "0x600342F")]
	[Address(RVA = "0xA59160", Offset = "0xA57F60", Length = "0x4E4")]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[Token(Token = "0x6003430")]
	[Address(RVA = "0xA59650", Offset = "0xA58450", Length = "0x9B")]
	private void StopProgressBar()
	{
	}

	[Token(Token = "0x6003431")]
	[Address(RVA = "0xA596F0", Offset = "0xA584F0", Length = "0x16E")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003432")]
	[Address(RVA = "0xA59860", Offset = "0xA58660", Length = "0x5D")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6003433")]
	[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6003434")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6003435")]
	[Address(RVA = "0xA598C0", Offset = "0xA586C0", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6003436")]
	[Address(RVA = "0xA59940", Offset = "0xA58740", Length = "0x4C")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6003437")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6003438")]
	[Address(RVA = "0xA59990", Offset = "0xA58790", Length = "0xC2")]
	public Panel_Harvest()
	{
	}
}
