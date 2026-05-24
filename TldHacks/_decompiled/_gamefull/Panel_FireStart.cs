using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000653")]
public class Panel_FireStart : Panel_AutoReferenced
{
	[Token(Token = "0x2000654")]
	private delegate void OnMethod();

	[SerializeField]
	[Token(Token = "0x4003D12")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[Token(Token = "0x4003D13")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Label_BaseSkill;

	[Token(Token = "0x4003D14")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_Label_ChanceSuccess;

	[Token(Token = "0x4003D15")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_Label_EstimatedDuration;

	[Token(Token = "0x4003D16")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_Label_Tinder;

	[Token(Token = "0x4003D17")]
	[FieldOffset(Offset = "0x58")]
	public StartFireSelectionRow m_SelectStarter;

	[Token(Token = "0x4003D18")]
	[FieldOffset(Offset = "0x60")]
	public StartFireSelectionRow m_SelectTinder;

	[Token(Token = "0x4003D19")]
	[FieldOffset(Offset = "0x68")]
	public StartFireSelectionRow m_SelectFuel;

	[Token(Token = "0x4003D1A")]
	[FieldOffset(Offset = "0x70")]
	public StartFireSelectionRow m_SelectAccelerant;

	[Token(Token = "0x4003D1B")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_CharcoalItemPrefab;

	[Token(Token = "0x4003D1C")]
	[FieldOffset(Offset = "0x80")]
	public float m_SecondsBetweenMove;

	[Token(Token = "0x4003D1D")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_ButtonStartFireMouse;

	[Token(Token = "0x4003D1E")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_ButtonHarvestCharcoalMouse;

	[Token(Token = "0x4003D1F")]
	[FieldOffset(Offset = "0x98")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x4003D20")]
	[FieldOffset(Offset = "0xA0")]
	private LiquidType m_Kerosene;

	[SerializeField]
	[Token(Token = "0x4003D21")]
	[FieldOffset(Offset = "0xA8")]
	private PowderType m_Gunpowder;

	[Token(Token = "0x4003D22")]
	[FieldOffset(Offset = "0xB0")]
	private int m_SelectedStarterIndex;

	[Token(Token = "0x4003D23")]
	[FieldOffset(Offset = "0xB4")]
	private int m_SelectedTinderIndex;

	[Token(Token = "0x4003D24")]
	[FieldOffset(Offset = "0xB8")]
	private int m_SelectedFuelIndex;

	[Token(Token = "0x4003D25")]
	[FieldOffset(Offset = "0xBC")]
	private int m_SelectedAccelerantIndex;

	[Token(Token = "0x4003D26")]
	[FieldOffset(Offset = "0xC0")]
	private List<GearItem> m_StarterList;

	[Token(Token = "0x4003D27")]
	[FieldOffset(Offset = "0xC8")]
	private List<GearItem> m_TinderList;

	[Token(Token = "0x4003D28")]
	[FieldOffset(Offset = "0xD0")]
	private List<GearItem> m_FuelList;

	[Token(Token = "0x4003D29")]
	[FieldOffset(Offset = "0xD8")]
	private List<GearItem> m_AccelerantList;

	[Token(Token = "0x4003D2A")]
	[FieldOffset(Offset = "0xE0")]
	private FireManager m_FireManager;

	[Token(Token = "0x4003D2B")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_EnablePending;

	[Token(Token = "0x4003D2C")]
	[FieldOffset(Offset = "0xEC")]
	private float m_EnableDelaySeconds;

	[Token(Token = "0x4003D2D")]
	[FieldOffset(Offset = "0xF0")]
	private float m_EnableDelayElapsed;

	[Token(Token = "0x4003D2E")]
	[FieldOffset(Offset = "0xF8")]
	private FireplaceInteraction m_FireplaceInteraction;

	[Token(Token = "0x4003D2F")]
	[FieldOffset(Offset = "0x100")]
	private bool m_DestroyFireplaceOnCancel;

	[Token(Token = "0x4003D30")]
	[FieldOffset(Offset = "0x101")]
	private bool m_DirtyLabels;

	[Token(Token = "0x4003D31")]
	[FieldOffset(Offset = "0x104")]
	private int m_FramesSinceEnabled;

	[Token(Token = "0x4003D32")]
	[FieldOffset(Offset = "0x108")]
	private FireStarterItem m_GunpowderAccelerant;

	[Token(Token = "0x4003D33")]
	[FieldOffset(Offset = "0x110")]
	private GearItem m_GunpowderGearItem;

	[Token(Token = "0x4003D34")]
	[FieldOffset(Offset = "0x118")]
	private FireStarterItem m_KeroseneAccelerant;

	[Token(Token = "0x4003D35")]
	[FieldOffset(Offset = "0x120")]
	private GearItem m_KeroseneGearItem;

	[Token(Token = "0x4003D36")]
	[FieldOffset(Offset = "0x128")]
	private int m_SelectedButtonIndex;

	[Token(Token = "0x4003D37")]
	[FieldOffset(Offset = "0x130")]
	private List<OnMethod> m_OnIncreaseDelegates;

	[Token(Token = "0x4003D38")]
	[FieldOffset(Offset = "0x138")]
	private List<OnMethod> m_OnDecreaseDelegates;

	[Token(Token = "0x4003D39")]
	[FieldOffset(Offset = "0x140")]
	private List<StartFireSelectionRow> m_StartFireSelectionRows;

	[Token(Token = "0x4003D3A")]
	[FieldOffset(Offset = "0x148")]
	private List<List<GearItem>> m_ItemLists;

	[Token(Token = "0x4003D3B")]
	[FieldOffset(Offset = "0x150")]
	private float m_SecondsToNextMove;

	[Token(Token = "0x4003D3C")]
	[FieldOffset(Offset = "0x158")]
	private Action m_OnDoneStartingFire;

	[Token(Token = "0x170002F2")]
	public LiquidType KeroseneType
	{
		[Token(Token = "0x6003365")]
		[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F3")]
	public PowderType GunpowderType
	{
		[Token(Token = "0x6003366")]
		[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003367")]
	[Address(RVA = "0xA0F5E0", Offset = "0xA0E3E0", Length = "0x35")]
	public override void CloseSelf()
	{
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0xA0F620", Offset = "0xA0E420", Length = "0x692")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003369")]
	[Address(RVA = "0xA0FCC0", Offset = "0xA0EAC0", Length = "0x2DA")]
	private void Update()
	{
	}

	[Token(Token = "0x600336A")]
	[Address(RVA = "0xA0FFA0", Offset = "0xA0EDA0", Length = "0x24D")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x600336B")]
	[Address(RVA = "0xA101F0", Offset = "0xA0EFF0", Length = "0x4DC")]
	private void UpdateMenuNavigation()
	{
	}

	[Token(Token = "0x600336C")]
	[Address(RVA = "0xA106D0", Offset = "0xA0F4D0", Length = "0x118")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600336D")]
	[Address(RVA = "0xA107F0", Offset = "0xA0F5F0", Length = "0x5BB")]
	public void ShowStartFire(float delaySeconds, Action onClosePanel)
	{
	}

	[Token(Token = "0x600336E")]
	[Address(RVA = "0xA10DB0", Offset = "0xA0FBB0", Length = "0x68")]
	private void NotifyDoneStartingFire()
	{
	}

	[Token(Token = "0x600336F")]
	[Address(RVA = "0xA10E20", Offset = "0xA0FC20", Length = "0x8")]
	public bool IsEnablePending()
	{
		return false;
	}

	[Token(Token = "0x6003370")]
	[Address(RVA = "0xA10E30", Offset = "0xA0FC30", Length = "0x1F2")]
	private void LookAtFire()
	{
	}

	[Token(Token = "0x6003371")]
	[Address(RVA = "0xA11030", Offset = "0xA0FE30", Length = "0x9CA")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0xA11A00", Offset = "0xA10800", Length = "0x61")]
	public void SetFireplaceInteraction(FireplaceInteraction fireplaceInteraction, bool destroyOnCancel = false)
	{
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0xA11A70", Offset = "0xA10870", Length = "0x1A8")]
	private FireStarterItem GetSelectedFireStarter()
	{
		return null;
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0xA11C20", Offset = "0xA10A20", Length = "0x1A8")]
	private FuelSourceItem GetSelectedTinder()
	{
		return null;
	}

	[Token(Token = "0x6003375")]
	[Address(RVA = "0xA11DD0", Offset = "0xA10BD0", Length = "0x1A8")]
	private FuelSourceItem GetSelectedFuelSource()
	{
		return null;
	}

	[Token(Token = "0x6003376")]
	[Address(RVA = "0xA11F80", Offset = "0xA10D80", Length = "0x1A8")]
	private FireStarterItem GetSelectedAccelerant()
	{
		return null;
	}

	[Token(Token = "0x6003377")]
	[Address(RVA = "0xA12130", Offset = "0xA10F30", Length = "0x3A2")]
	private void RefreshChanceOfSuccessLabel()
	{
	}

	[Token(Token = "0x6003378")]
	[Address(RVA = "0xA124E0", Offset = "0xA112E0", Length = "0x12E")]
	private void RefreshBaseSkillLabel()
	{
	}

	[Token(Token = "0x6003379")]
	[Address(RVA = "0xA12610", Offset = "0xA11410", Length = "0x1F4")]
	private void RefreshEstimatedDurationLabel()
	{
	}

	[Token(Token = "0x600337A")]
	[Address(RVA = "0xA12810", Offset = "0xA11610", Length = "0x151")]
	private void RefreshTinderLabel()
	{
	}

	[Token(Token = "0x600337B")]
	[Address(RVA = "0xA12970", Offset = "0xA11770", Length = "0xF2")]
	public void IncreaseStarter()
	{
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0xA12A70", Offset = "0xA11870", Length = "0xE9")]
	public void DecreaseStarter()
	{
	}

	[Token(Token = "0x600337D")]
	[Address(RVA = "0xA12B60", Offset = "0xA11960", Length = "0xF2")]
	public void IncreaseTinder()
	{
	}

	[Token(Token = "0x600337E")]
	[Address(RVA = "0xA12C60", Offset = "0xA11A60", Length = "0xE9")]
	public void DecreaseTinder()
	{
	}

	[Token(Token = "0x600337F")]
	[Address(RVA = "0xA12D50", Offset = "0xA11B50", Length = "0xF2")]
	public void IncreaseFuel()
	{
	}

	[Token(Token = "0x6003380")]
	[Address(RVA = "0xA12E50", Offset = "0xA11C50", Length = "0xE9")]
	public void DecreaseFuel()
	{
	}

	[Token(Token = "0x6003381")]
	[Address(RVA = "0xA12F40", Offset = "0xA11D40", Length = "0xF2")]
	public void IncreaseAccelerant()
	{
	}

	[Token(Token = "0x6003382")]
	[Address(RVA = "0xA13040", Offset = "0xA11E40", Length = "0xE9")]
	public void DecreaseAccelerant()
	{
	}

	[Token(Token = "0x6003383")]
	[Address(RVA = "0xA13130", Offset = "0xA11F30", Length = "0x292")]
	private bool CanStartFire()
	{
		return false;
	}

	[Token(Token = "0x6003384")]
	[Address(RVA = "0xA133D0", Offset = "0xA121D0", Length = "0x92A")]
	public void OnStartFire(bool skipResearchItemCheck = false)
	{
	}

	[Token(Token = "0x6003385")]
	[Address(RVA = "0xA13D00", Offset = "0xA12B00", Length = "0xEA")]
	private void OnDoneStartingFire(bool success)
	{
	}

	[Token(Token = "0x6003386")]
	[Address(RVA = "0xA13DF0", Offset = "0xA12BF0", Length = "0xA")]
	private void ForceBurnResearchItem()
	{
	}

	[Token(Token = "0x6003387")]
	[Address(RVA = "0xA13E00", Offset = "0xA12C00", Length = "0x25C")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003388")]
	[Address(RVA = "0xA14060", Offset = "0xA12E60", Length = "0x1A9")]
	public bool CanHarvestCharcoal()
	{
		return false;
	}

	[Token(Token = "0x6003389")]
	[Address(RVA = "0xA14210", Offset = "0xA13010", Length = "0x732")]
	public void OnCharcoalHarvest()
	{
	}

	[Token(Token = "0x600338A")]
	[Address(RVA = "0xA14950", Offset = "0xA13750", Length = "0x3E0")]
	public static bool FilterItem(GearItem gi, FireStartMaterialType type)
	{
		return false;
	}

	[Token(Token = "0x600338B")]
	[Address(RVA = "0xA14D40", Offset = "0xA13B40", Length = "0xE2")]
	private static bool FilterItemFireStarter(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600338C")]
	[Address(RVA = "0xA14E30", Offset = "0xA13C30", Length = "0xE2")]
	private static bool FilterItemTinder(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600338D")]
	[Address(RVA = "0xA14F20", Offset = "0xA13D20", Length = "0xE2")]
	private static bool FilterItemFuelSource(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600338E")]
	[Address(RVA = "0xA15010", Offset = "0xA13E10", Length = "0xE2")]
	private static bool FilterItemAccelerant(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600338F")]
	[Address(RVA = "0xA15100", Offset = "0xA13F00", Length = "0xC81")]
	private void RefreshList(StartFireSelectionRow row, List<GearItem> gearList, FireStartMaterialType type)
	{
	}

	[Token(Token = "0x6003390")]
	[Address(RVA = "0xA15D90", Offset = "0xA14B90", Length = "0x285")]
	private void RefreshLabels()
	{
	}

	[Token(Token = "0x6003391")]
	[Address(RVA = "0xA16020", Offset = "0xA14E20", Length = "0xCA")]
	private bool HasDirectSunlight()
	{
		return false;
	}

	[Token(Token = "0x6003392")]
	[Address(RVA = "0xA160F0", Offset = "0xA14EF0", Length = "0x1FD")]
	public bool IsThisKeroseneAccelerant(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6003393")]
	[Address(RVA = "0xA162F0", Offset = "0xA150F0", Length = "0x1FD")]
	public bool IsGunpowderAccelerant(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6003394")]
	[Address(RVA = "0xA164F0", Offset = "0xA152F0", Length = "0x501")]
	public Panel_FireStart()
	{
	}
}
