using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006A0")]
public class Panel_Milling : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Token(Token = "0x400456E")]
	[FieldOffset(Offset = "0x30")]
	public List<GearItemDisplay> m_ItemList;

	[Token(Token = "0x400456F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Root;

	[Token(Token = "0x4004570")]
	[FieldOffset(Offset = "0x40")]
	public Color m_RedColorToUse;

	[Token(Token = "0x4004571")]
	[FieldOffset(Offset = "0x50")]
	public float m_RepairRealTimeSeconds;

	[Token(Token = "0x4004572")]
	[FieldOffset(Offset = "0x54")]
	public float m_SkillIncreaseChanceOnSuccess;

	[Token(Token = "0x4004573")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_ScrollbarSpawner;

	[Token(Token = "0x4004574")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x4004575")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_ConditionIcon;

	[Token(Token = "0x4004576")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_NameLabel;

	[Token(Token = "0x4004577")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_RepairAmountLabel;

	[Token(Token = "0x4004578")]
	[FieldOffset(Offset = "0x80")]
	public UILabel m_RequiredMaterialHeaderLabel;

	[Token(Token = "0x4004579")]
	[FieldOffset(Offset = "0x88")]
	public List<HarvestRepairMaterial> m_RequiredMaterials;

	[Token(Token = "0x400457A")]
	[FieldOffset(Offset = "0x90")]
	public float m_RequiredMaterialCenteredX;

	[Token(Token = "0x400457B")]
	[FieldOffset(Offset = "0x94")]
	public float m_RequiredMaterialSpacing;

	[Token(Token = "0x400457C")]
	[FieldOffset(Offset = "0x98")]
	public UITexture m_SelectedImage;

	[Token(Token = "0x400457D")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_SkillLabel;

	[Token(Token = "0x400457E")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel m_SuccessLabel;

	[Token(Token = "0x400457F")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel m_TimeRequiredLabel;

	[Token(Token = "0x4004580")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_WeightLabel;

	[Token(Token = "0x4004581")]
	[FieldOffset(Offset = "0xC0")]
	public string m_IconAccelerateTime;

	[Header("Button Legend")]
	[Token(Token = "0x4004582")]
	[FieldOffset(Offset = "0xC8")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004583")]
	[FieldOffset(Offset = "0xD0")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4004585")]
	[FieldOffset(Offset = "0xE0")]
	private MillingMachine m_Machine;

	[Token(Token = "0x4004586")]
	[FieldOffset(Offset = "0xE8")]
	private List<GearItem> m_Millables;

	[Token(Token = "0x4004587")]
	[FieldOffset(Offset = "0xF0")]
	private int m_SelectedIndex;

	[Token(Token = "0x4004588")]
	[FieldOffset(Offset = "0xF4")]
	private int m_DisplayOffset;

	[Token(Token = "0x4004589")]
	[FieldOffset(Offset = "0xF8")]
	private uint m_AudioPlayingId;

	[Token(Token = "0x400458A")]
	[FieldOffset(Offset = "0xFC")]
	private float m_CompletionProgress;

	[Token(Token = "0x400458B")]
	[FieldOffset(Offset = "0x100")]
	private float m_RealTimeCraftingElapsed;

	[Token(Token = "0x400458C")]
	[FieldOffset(Offset = "0x104")]
	private bool m_RepairSuccess;

	[Token(Token = "0x400458D")]
	[FieldOffset(Offset = "0x108")]
	private float m_StoredDayLengthScale;

	[Token(Token = "0x400458E")]
	[FieldOffset(Offset = "0x110")]
	private UISlider m_Slider;

	[Token(Token = "0x400458F")]
	[FieldOffset(Offset = "0x118")]
	private GameObject m_SliderRoot;

	[Token(Token = "0x4004590")]
	[FieldOffset(Offset = "0x120")]
	private Color m_OriginalHeaderTint;

	[Token(Token = "0x4004591")]
	[FieldOffset(Offset = "0x130")]
	private Color m_OriginalConditionTint;

	[Token(Token = "0x17000305")]
	[field: Token(Token = "0x4004584")]
	[field: FieldOffset(Offset = "0xD8")]
	public bool m_MillingInProgress
	{
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x69F950", Offset = "0x69E750", Length = "0x8")]
		get;
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x6CA060", Offset = "0x6C8E60", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x60038D3")]
	[Address(RVA = "0xB31D20", Offset = "0xB30B20", Length = "0x74D")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60038D4")]
	[Address(RVA = "0xB32470", Offset = "0xB31270", Length = "0x264")]
	private void Update()
	{
	}

	[Token(Token = "0x60038D5")]
	[Address(RVA = "0xB326E0", Offset = "0xB314E0", Length = "0xEB")]
	public void Disable()
	{
	}

	[Token(Token = "0x60038D6")]
	[Address(RVA = "0xB327D0", Offset = "0xB315D0", Length = "0x192")]
	public void Enable(MillingMachine machine)
	{
	}

	[Token(Token = "0x60038D7")]
	[Address(RVA = "0xB32970", Offset = "0xB31770", Length = "0x55")]
	public void OnBack()
	{
	}

	[Token(Token = "0x60038D8")]
	[Address(RVA = "0xB329D0", Offset = "0xB317D0", Length = "0x11")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60038D9")]
	[Address(RVA = "0xB329F0", Offset = "0xB317F0", Length = "0x288")]
	public void OnRepair()
	{
	}

	[Token(Token = "0x60038DA")]
	[Address(RVA = "0xB32C80", Offset = "0xB31A80", Length = "0x20D")]
	public void OnScrollbarChanged()
	{
	}

	[Token(Token = "0x60038DB")]
	[Address(RVA = "0xB32E90", Offset = "0xB31C90", Length = "0x31F")]
	public bool DetermineRepairables()
	{
		return false;
	}

	[Token(Token = "0x60038DC")]
	[Address(RVA = "0xB331B0", Offset = "0xB31FB0", Length = "0x75")]
	protected void OnGearItemDisplayClicked(int index)
	{
	}

	[Token(Token = "0x60038DD")]
	[Address(RVA = "0xB33230", Offset = "0xB32030", Length = "0x24D")]
	private void ApplyCondition(float percent)
	{
	}

	[Token(Token = "0x60038DE")]
	[Address(RVA = "0xB33480", Offset = "0xB32280", Length = "0x3C4")]
	private void BeginRepair()
	{
	}

	[Token(Token = "0x60038DF")]
	[Address(RVA = "0xB33850", Offset = "0xB32650", Length = "0x25E")]
	private void CompleteRepair()
	{
	}

	[Token(Token = "0x60038E0")]
	[Address(RVA = "0xB33AB0", Offset = "0xB328B0", Length = "0x243")]
	private void ConsumeMaterials(float progress)
	{
	}

	[Token(Token = "0x60038E1")]
	[Address(RVA = "0xB33D00", Offset = "0xB32B00", Length = "0xC5")]
	private float DetermineConditionImprovement(SkillType skill)
	{
		return 0f;
	}

	[Token(Token = "0x60038E2")]
	[Address(RVA = "0xB33DD0", Offset = "0xB32BD0", Length = "0xFF")]
	private void EndRepair()
	{
	}

	[Token(Token = "0x60038E3")]
	[Address(RVA = "0xB33ED0", Offset = "0xB32CD0", Length = "0x473")]
	private void GetMaterials(out GearItem[] mats, out int[] units, bool adjustForProgress)
	{
		mats = null;
		units = null;
	}

	[Token(Token = "0x60038E4")]
	[Address(RVA = "0xB34350", Offset = "0xB33150", Length = "0x8D")]
	private GearItem GetSelected()
	{
		return null;
	}

	[Token(Token = "0x60038E5")]
	[Address(RVA = "0xB343E0", Offset = "0xB331E0", Length = "0x2BB")]
	private void HandleInput()
	{
	}

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0xB346A0", Offset = "0xB334A0", Length = "0x13C")]
	private void HandleMenuMovement(float movement)
	{
	}

	[Token(Token = "0x60038E7")]
	[Address(RVA = "0xB347E0", Offset = "0xB335E0", Length = "0x23A")]
	private bool HasEnoughMaterials()
	{
		return false;
	}

	[Token(Token = "0x60038E8")]
	[Address(RVA = "0xB34A20", Offset = "0xB33820", Length = "0x25D")]
	private void Interrupt()
	{
	}

	[Token(Token = "0x60038E9")]
	[Address(RVA = "0xB34C80", Offset = "0xB33A80", Length = "0x1F")]
	private void RefreshAll()
	{
	}

	[Token(Token = "0x60038EA")]
	[Address(RVA = "0xB34CA0", Offset = "0xB33AA0", Length = "0x293")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x60038EB")]
	[Address(RVA = "0xB34F40", Offset = "0xB33D40", Length = "0x8A5")]
	private void RefreshSelected()
	{
	}

	[Token(Token = "0x60038EC")]
	[Address(RVA = "0xB357F0", Offset = "0xB345F0", Length = "0x8F9")]
	private void RefreshRequiredMaterials(GearItem gearItem)
	{
	}

	[Token(Token = "0x60038ED")]
	[Address(RVA = "0xB360F0", Offset = "0xB34EF0", Length = "0x116")]
	private bool RollForRepairSuccess(SkillType skill)
	{
		return false;
	}

	[Token(Token = "0x60038EE")]
	[Address(RVA = "0xB36210", Offset = "0xB35010", Length = "0x1B1")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60038EF")]
	[Address(RVA = "0xB363D0", Offset = "0xB351D0", Length = "0x16D")]
	private void UpdateRepair()
	{
	}

	[Token(Token = "0x60038F0")]
	[Address(RVA = "0xB36540", Offset = "0xB35340", Length = "0xAE")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x60038F1")]
	[Address(RVA = "0xB365F0", Offset = "0xB353F0", Length = "0x5D")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x60038F2")]
	[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x60038F3")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x60038F4")]
	[Address(RVA = "0xB36650", Offset = "0xB35450", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x60038F5")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x60038F6")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x60038F7")]
	[Address(RVA = "0xB366D0", Offset = "0xB354D0", Length = "0x1F1")]
	public Panel_Milling()
	{
	}
}
