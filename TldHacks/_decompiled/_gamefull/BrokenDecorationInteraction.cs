using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000557")]
public class BrokenDecorationInteraction : BaseInteraction, IRepairable
{
	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400314F")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Inventory_Examine> m_PanelInventoryExamine;

	[SerializeField]
	[Token(Token = "0x4003150")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_DisplayName;

	[HideInInspector]
	[Token(Token = "0x4003151")]
	[FieldOffset(Offset = "0x50")]
	public GearItem[] m_RequiredGear;

	[HideInInspector]
	[Token(Token = "0x4003152")]
	[FieldOffset(Offset = "0x58")]
	public int[] m_RequiredGearUnits;

	[Token(Token = "0x4003153")]
	[FieldOffset(Offset = "0x60")]
	public bool m_UseSelfForBrokenObject;

	[DrawIf("m_UseSelfForBrokenObject", false)]
	[SerializeField]
	[Token(Token = "0x4003154")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_BrokenObject;

	[Token(Token = "0x4003155")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_RepairedObject;

	[Token(Token = "0x4003156")]
	[FieldOffset(Offset = "0x78")]
	public int m_DurationMinutes;

	[Token(Token = "0x4003157")]
	[FieldOffset(Offset = "0x80")]
	public string m_RepairAudio;

	[Token(Token = "0x4003158")]
	[FieldOffset(Offset = "0x88")]
	public ToolsItem[] m_RepairToolChoices;

	[Token(Token = "0x4003159")]
	[FieldOffset(Offset = "0x90")]
	public bool m_RequiresToolToRepair;

	[Token(Token = "0x400315A")]
	[FieldOffset(Offset = "0x94")]
	private BrokenDecorationState m_State;

	[Token(Token = "0x400315B")]
	private static readonly List<BrokenDecorationInteraction> s_BrokenDecorationItems;

	[Token(Token = "0x400315C")]
	private static readonly BrokenDecorationSaveData s_BrokenDecorationSaveData;

	[Token(Token = "0x400315D")]
	[FieldOffset(Offset = "0x98")]
	private List<ToolsItem> m_FilteredRepairToolChoices;

	[Token(Token = "0x170002A1")]
	public string DisplayName
	{
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x87D670", Offset = "0x87C470", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A2")]
	public override bool IsEnabled
	{
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x8DA0C0", Offset = "0x8D8EC0", Length = "0xF2")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002A3")]
	public override bool CanInteract
	{
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x8DA3A0", Offset = "0x8D91A0", Length = "0x8F")]
		get
		{
			return false;
		}
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x8BE410", Offset = "0x8BD210", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x8DA1C0", Offset = "0x8D8FC0", Length = "0x14D")]
	private void Awake()
	{
	}

	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x8DA310", Offset = "0x8D9110", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x8DA430", Offset = "0x8D9230", Length = "0x160")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x86AC30", Offset = "0x869A30", Length = "0x7")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x8DA5A0", Offset = "0x8D93A0", Length = "0x1A")]
	public int GetNumMaterialsRequired()
	{
		return 0;
	}

	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x8DA5C0", Offset = "0x8D93C0", Length = "0x37")]
	public GearItem GetMaterialRequired(int index)
	{
		return null;
	}

	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x8DA600", Offset = "0x8D9400", Length = "0x36")]
	public int GetRequiredGearUnits(int index)
	{
		return 0;
	}

	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x657EE0", Offset = "0x656CE0", Length = "0x4")]
	public int GetDurationMinutes()
	{
		return 0;
	}

	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
	public string GetRepairAudio()
	{
		return null;
	}

	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x8DA640", Offset = "0x8D9440", Length = "0x58")]
	public int GetNumRepairToolChoices()
	{
		return 0;
	}

	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x8DA6A0", Offset = "0x8D94A0", Length = "0xAB")]
	public ToolsItem GetRepairToolChoice(int index)
	{
		return null;
	}

	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x8DA750", Offset = "0x8D9550", Length = "0x4C9")]
	private void InitializeRepairToolChoices()
	{
	}

	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x89B490", Offset = "0x89A290", Length = "0x8")]
	public bool RequiresToolToRepair()
	{
		return false;
	}

	[Token(Token = "0x6002900")]
	[Address(RVA = "0x87D670", Offset = "0x87C470", Length = "0x5D")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x6002901")]
	[Address(RVA = "0x8DAC20", Offset = "0x8D9A20", Length = "0xC")]
	public void OnRepairSuccessful()
	{
	}

	[Token(Token = "0x6002902")]
	[Address(RVA = "0x8DAC30", Offset = "0x8D9A30", Length = "0x9")]
	public float GetChanceSuccessfullRepair()
	{
		return 0f;
	}

	[Token(Token = "0x6002903")]
	[Address(RVA = "0x8DAC40", Offset = "0x8D9A40", Length = "0xBF")]
	public string GetSkillStringValue()
	{
		return null;
	}

	[Token(Token = "0x6002904")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public float GetConditionIncreaseFromRepair()
	{
		return 0f;
	}

	[Token(Token = "0x6002905")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool AffectsCondition()
	{
		return false;
	}

	[Token(Token = "0x6002906")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public float GetRepairConditionCap()
	{
		return 0f;
	}

	[Token(Token = "0x6002907")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool AlwaysSucceeds()
	{
		return false;
	}

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x8DAC30", Offset = "0x8D9A30", Length = "0x9")]
	public float GetChanceActionSuccess(ToolsItem tool)
	{
		return 0f;
	}

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x8DAD00", Offset = "0x8D9B00", Length = "0x1E5")]
	private void UpdateState(BrokenDecorationState state)
	{
	}

	[Token(Token = "0x600290A")]
	[Address(RVA = "0x8DAEF0", Offset = "0x8D9CF0", Length = "0x12")]
	public GameObject GetBrokenObject()
	{
		return null;
	}

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x8DAF10", Offset = "0x8D9D10", Length = "0x438")]
	public static BrokenDecorationSaveData SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x600290C")]
	[Address(RVA = "0x8DB350", Offset = "0x8DA150", Length = "0x28B")]
	public static void DeserializeAll(BrokenDecorationSaveData data)
	{
	}

	[Token(Token = "0x600290D")]
	[Address(RVA = "0x8DB5E0", Offset = "0x8DA3E0", Length = "0xB")]
	public BrokenDecorationInteraction()
	{
	}
}
