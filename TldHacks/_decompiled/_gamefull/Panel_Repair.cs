using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006B5")]
public class Panel_Repair : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[SerializeField]
	[Token(Token = "0x4004749")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x400474A")]
	[FieldOffset(Offset = "0x38")]
	public float m_SkillIncreaseChanceOnSuccess;

	[Token(Token = "0x400474B")]
	[FieldOffset(Offset = "0x3C")]
	public float m_SkillIncreaseChanceOnFailure;

	[Token(Token = "0x400474C")]
	[FieldOffset(Offset = "0x40")]
	public float m_RepairTimeSeconds;

	[Token(Token = "0x400474D")]
	[FieldOffset(Offset = "0x48")]
	public UITexture m_ItemBGSprite;

	[Token(Token = "0x400474E")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_ItemNameLabel;

	[Token(Token = "0x400474F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_SkillLabel;

	[Token(Token = "0x4004750")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_AmountLabel;

	[Token(Token = "0x4004751")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ChanceSuccessLabel;

	[Token(Token = "0x4004752")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_TimeLabel;

	[Token(Token = "0x4004753")]
	[FieldOffset(Offset = "0x78")]
	public HarvestRepairMaterial[] m_RequiredMaterials;

	[Token(Token = "0x4004754")]
	[FieldOffset(Offset = "0x80")]
	public float m_RequiredMaterialCenteredX;

	[Token(Token = "0x4004755")]
	[FieldOffset(Offset = "0x84")]
	public float m_RequiredMaterialSpacing;

	[Token(Token = "0x4004756")]
	[FieldOffset(Offset = "0x88")]
	public UISlider m_Slider_RepairProgress;

	[Token(Token = "0x4004757")]
	[FieldOffset(Offset = "0x90")]
	public UITexture m_ToolSprite;

	[Token(Token = "0x4004758")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_ToolNameLabel;

	[Token(Token = "0x4004759")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite m_ToolConditionSprite;

	[Token(Token = "0x400475A")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel m_ToolConditionLabel;

	[Token(Token = "0x400475B")]
	[FieldOffset(Offset = "0xB0")]
	public Color m_CantRepairTextColor;

	[Token(Token = "0x400475C")]
	[FieldOffset(Offset = "0xC0")]
	public Color m_HighConditionColor;

	[Token(Token = "0x400475D")]
	[FieldOffset(Offset = "0xD0")]
	public string m_NoToolSpriteName;

	[Token(Token = "0x400475E")]
	[FieldOffset(Offset = "0xD8")]
	public Color m_NoToolSpriteColor;

	[Token(Token = "0x400475F")]
	[FieldOffset(Offset = "0xE8")]
	public Vector3 m_NoToolSpriteSizeModifier;

	[Token(Token = "0x4004760")]
	[FieldOffset(Offset = "0xF8")]
	public string m_IconAccelerateTime;

	[HideInInspector]
	[Token(Token = "0x4004761")]
	[FieldOffset(Offset = "0x100")]
	public GearItem m_AutoSelectItem;

	[HideInInspector]
	[Token(Token = "0x4004762")]
	[FieldOffset(Offset = "0x108")]
	public bool m_EnableDiaryOnExit;

	[Token(Token = "0x4004763")]
	[FieldOffset(Offset = "0x10C")]
	private float m_ElapsedProgressBarSeconds;

	[Token(Token = "0x4004764")]
	[FieldOffset(Offset = "0x110")]
	private float m_ProgressBarTimeSeconds;

	[Token(Token = "0x4004765")]
	[FieldOffset(Offset = "0x114")]
	private bool m_RepairWillSucceed;

	[Token(Token = "0x4004766")]
	[FieldOffset(Offset = "0x115")]
	private bool m_RepairFailed;

	[Token(Token = "0x4004767")]
	[FieldOffset(Offset = "0x116")]
	private bool m_RepairSucceeded;

	[Token(Token = "0x4004768")]
	[FieldOffset(Offset = "0x118")]
	private float m_FailureAtProgressPercentage;

	[Token(Token = "0x4004769")]
	[FieldOffset(Offset = "0x11C")]
	private float m_ElapsedDisplayRepairOutcomeTime;

	[Token(Token = "0x400476A")]
	[FieldOffset(Offset = "0x120")]
	private float m_DayLengthScaleBeforeRepair;

	[Token(Token = "0x400476B")]
	[FieldOffset(Offset = "0x124")]
	private int m_SelectedToolIndex;

	[Token(Token = "0x400476C")]
	[FieldOffset(Offset = "0x128")]
	private List<GameObject> m_Tools;

	[Token(Token = "0x400476D")]
	[FieldOffset(Offset = "0x130")]
	private WorkBench m_Workbench;

	[Token(Token = "0x400476E")]
	[FieldOffset(Offset = "0x138")]
	private uint m_ProgressBarAudio;

	[Token(Token = "0x400476F")]
	[FieldOffset(Offset = "0x13C")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x4004770")]
	[FieldOffset(Offset = "0x13D")]
	private bool m_RepairInProgress;

	[Token(Token = "0x6003A8C")]
	[Address(RVA = "0xB48710", Offset = "0xB47510", Length = "0x3F")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003A8D")]
	[Address(RVA = "0xB48750", Offset = "0xB47550", Length = "0x83")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A8E")]
	[Address(RVA = "0xB487E0", Offset = "0xB475E0", Length = "0x2E4")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003A8F")]
	[Address(RVA = "0xB48AD0", Offset = "0xB478D0", Length = "0xD3")]
	public void OnNextTool()
	{
	}

	[Token(Token = "0x6003A90")]
	[Address(RVA = "0xB48BB0", Offset = "0xB479B0", Length = "0xC5")]
	public void OnPrevTool()
	{
	}

	[Token(Token = "0x6003A91")]
	[Address(RVA = "0xB48C80", Offset = "0xB47A80", Length = "0xB9B")]
	public void OnRepair()
	{
	}

	[Token(Token = "0x6003A92")]
	[Address(RVA = "0xB49820", Offset = "0xB48620", Length = "0x7")]
	private void SetRepairInProgress(bool on)
	{
	}

	[Token(Token = "0x6003A93")]
	[Address(RVA = "0xB49830", Offset = "0xB48630", Length = "0x2AE")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003A94")]
	[Address(RVA = "0xB49AE0", Offset = "0xB488E0", Length = "0x1D8")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003A95")]
	[Address(RVA = "0x6491F0", Offset = "0x647FF0", Length = "0x52")]
	public void SetWorkbench(WorkBench wb)
	{
	}

	[Token(Token = "0x6003A96")]
	[Address(RVA = "0xB49CC0", Offset = "0xB48AC0", Length = "0x8")]
	public bool RepairInProgress()
	{
		return false;
	}

	[Token(Token = "0x6003A97")]
	[Address(RVA = "0xB49CD0", Offset = "0xB48AD0", Length = "0x6E")]
	private GameObject GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x6003A98")]
	[Address(RVA = "0xB49D40", Offset = "0xB48B40", Length = "0x20")]
	private GameObject GetSelectedRepairableItem()
	{
		return null;
	}

	[Token(Token = "0x6003A99")]
	[Address(RVA = "0xB49D70", Offset = "0xB48B70", Length = "0x435")]
	private void RefreshTools()
	{
	}

	[Token(Token = "0x6003A9A")]
	[Address(RVA = "0xB4A1B0", Offset = "0xB48FB0", Length = "0x7A4")]
	private void RefreshMaterialsTable()
	{
	}

	[Token(Token = "0x6003A9B")]
	[Address(RVA = "0xB4A960", Offset = "0xB49760", Length = "0x275")]
	private float GetChanceSuccess()
	{
		return 0f;
	}

	[Token(Token = "0x6003A9C")]
	[Address(RVA = "0xB4ABE0", Offset = "0xB499E0", Length = "0xE4")]
	private void RefreshRepairSkillLabel()
	{
	}

	[Token(Token = "0x6003A9D")]
	[Address(RVA = "0xB4ACD0", Offset = "0xB49AD0", Length = "0x80F")]
	private void RefreshChanceSuccessLabel()
	{
	}

	[Token(Token = "0x6003A9E")]
	[Address(RVA = "0xB4B4E0", Offset = "0xB4A2E0", Length = "0x7A0")]
	private void RefreshLabels()
	{
	}

	[Token(Token = "0x6003A9F")]
	[Address(RVA = "0xB4BC90", Offset = "0xB4AA90", Length = "0x32")]
	private void DisableProgressBar()
	{
	}

	[Token(Token = "0x6003AA0")]
	[Address(RVA = "0xB4BCD0", Offset = "0xB4AAD0", Length = "0x28")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6003AA1")]
	[Address(RVA = "0xB4BD00", Offset = "0xB4AB00", Length = "0x111")]
	private void DegradeToolUsedForRepair()
	{
	}

	[Token(Token = "0x6003AA2")]
	[Address(RVA = "0xB4BE20", Offset = "0xB4AC20", Length = "0x12D")]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[Token(Token = "0x6003AA3")]
	[Address(RVA = "0xB4BF50", Offset = "0xB4AD50", Length = "0x57")]
	private void StopProgressBarAudio()
	{
	}

	[Token(Token = "0x6003AA4")]
	[Address(RVA = "0xB4BFB0", Offset = "0xB4ADB0", Length = "0x516")]
	private void RepairFinished()
	{
	}

	[Token(Token = "0x6003AA5")]
	[Address(RVA = "0xB4C4D0", Offset = "0xB4B2D0", Length = "0x12E")]
	private void RepairFailed()
	{
	}

	[Token(Token = "0x6003AA6")]
	[Address(RVA = "0xB4C600", Offset = "0xB4B400", Length = "0x1FD")]
	private void RepairSuccessful()
	{
	}

	[Token(Token = "0x6003AA7")]
	[Address(RVA = "0xB4C800", Offset = "0xB4B600", Length = "0x315")]
	private void UpdateRepair()
	{
	}

	[Token(Token = "0x6003AA8")]
	[Address(RVA = "0xB4CB20", Offset = "0xB4B920", Length = "0x9E")]
	private bool RollForRepairSuccess()
	{
		return false;
	}

	[Token(Token = "0x6003AA9")]
	[Address(RVA = "0xB4CBC0", Offset = "0xB4B9C0", Length = "0x77")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x6003AAA")]
	[Address(RVA = "0xB4CC40", Offset = "0xB4BA40", Length = "0xA9")]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[Token(Token = "0x6003AAB")]
	[Address(RVA = "0xB4CCF0", Offset = "0xB4BAF0", Length = "0x312")]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[Token(Token = "0x6003AAC")]
	[Address(RVA = "0xB4D010", Offset = "0xB4BE10", Length = "0xA1")]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[Token(Token = "0x6003AAD")]
	[Address(RVA = "0xB4D0C0", Offset = "0xB4BEC0", Length = "0x32F")]
	private int GetModifiedRepairDuration(Repairable r, int baseMinutes)
	{
		return 0;
	}

	[Token(Token = "0x6003AAE")]
	[Address(RVA = "0xB4D3F0", Offset = "0xB4C1F0", Length = "0x305")]
	private bool ToolCanRepairSelectedItem(GameObject toolObject)
	{
		return false;
	}

	[Token(Token = "0x6003AAF")]
	[Address(RVA = "0xB4D700", Offset = "0xB4C500", Length = "0xAE")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003AB0")]
	[Address(RVA = "0xB4D7B0", Offset = "0xB4C5B0", Length = "0x5D")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6003AB1")]
	[Address(RVA = "0x6BF850", Offset = "0x6BE650", Length = "0x8")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6003AB2")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6003AB3")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6003AB4")]
	[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6003AB5")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6003AB6")]
	[Address(RVA = "0xB4D810", Offset = "0xB4C610", Length = "0x16F")]
	public Panel_Repair()
	{
	}
}
