using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000608")]
public class Panel_Affliction : Panel_AutoReferenced
{
	[Flags]
	[Token(Token = "0x2000609")]
	public enum AfflictionExclusions
	{
		[Token(Token = "0x4003851")]
		None = 0,
		[Token(Token = "0x4003852")]
		MajorWristSprain = 1,
		[Token(Token = "0x4003853")]
		MustBeTreatable = 2
	}

	[SerializeField]
	[Token(Token = "0x4003833")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x4003834")]
	[FieldOffset(Offset = "0x38")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x4003835")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x4003836")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x4003837")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ButtonLeftGamepad;

	[Token(Token = "0x4003838")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_ButtonLeftGamepadSprite;

	[Token(Token = "0x4003839")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_ButtonRightGamepad;

	[Token(Token = "0x400383A")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_ButtonRightGamepadSprite;

	[Token(Token = "0x400383B")]
	[FieldOffset(Offset = "0x70")]
	public GenericButtonMouseSpawner m_MouseButtonTreatWounds;

	[Token(Token = "0x400383C")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_Background;

	[Token(Token = "0x400383D")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_PanelContent;

	[Token(Token = "0x400383E")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_AfflictionButtonColorReferencesPrefab;

	[Token(Token = "0x400383F")]
	[FieldOffset(Offset = "0x90")]
	public UILabel m_Label;

	[Token(Token = "0x4003840")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_LabelCause;

	[Token(Token = "0x4003841")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_LabelLocation;

	[Token(Token = "0x4003842")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_SelectionEffect;

	[Token(Token = "0x4003843")]
	[FieldOffset(Offset = "0xB0")]
	public Vector2 m_PanelOffsetInInventory;

	[Token(Token = "0x4003844")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 m_ButtonTreatWoundsOffsetInInventory;

	[SerializeField]
	[Token(Token = "0x4003845")]
	[FieldOffset(Offset = "0xC0")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003846")]
	[FieldOffset(Offset = "0xC8")]
	private readonly List<AfflictionCoverflow> m_CoverflowAfflictions;

	[Token(Token = "0x4003847")]
	[FieldOffset(Offset = "0xD0")]
	private readonly List<Affliction> m_Afflictions;

	[Token(Token = "0x4003848")]
	[FieldOffset(Offset = "0xD8")]
	private FirstAidItem m_FirstAidItem;

	[Token(Token = "0x4003849")]
	[FieldOffset(Offset = "0xE0")]
	private Vector2 m_OriginalPanelPosition;

	[Token(Token = "0x400384A")]
	[FieldOffset(Offset = "0xE8")]
	private Vector2 m_OriginalBUttonTreatWoundsPosition;

	[Token(Token = "0x400384B")]
	[FieldOffset(Offset = "0xF0")]
	private string m_TreatWoundsLocalizationId;

	[Token(Token = "0x400384C")]
	[FieldOffset(Offset = "0xF8")]
	private AfflictionButton m_AfflictionButtonColorReferences;

	[Token(Token = "0x400384D")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_AfflictionButtonColorReferencesObject;

	[Token(Token = "0x400384E")]
	private static readonly AfflictionType[] s_TypesToCheck;

	[Token(Token = "0x400384F")]
	private static readonly List<AfflictionType> s_ShownAfflictionTypes;

	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x97D030", Offset = "0x97BE30", Length = "0x1F1")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x97D230", Offset = "0x97C030", Length = "0xC6")]
	private void Update()
	{
	}

	[Token(Token = "0x6002F10")]
	[Address(RVA = "0x97D300", Offset = "0x97C100", Length = "0x95")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002F11")]
	[Address(RVA = "0x97D3A0", Offset = "0x97C1A0", Length = "0x1D")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002F12")]
	[Address(RVA = "0x97D3C0", Offset = "0x97C1C0", Length = "0x42B")]
	public void Enable(bool enable, List<Affliction> listAffliction, FirstAidItem firstAidItem)
	{
	}

	[Token(Token = "0x6002F13")]
	[Address(RVA = "0x97D7F0", Offset = "0x97C5F0", Length = "0x65")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x97D860", Offset = "0x97C660", Length = "0xA2")]
	public void SelectItemByIndex(int index)
	{
	}

	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x97D910", Offset = "0x97C710", Length = "0xFE")]
	public void PreviousAffliction()
	{
	}

	[Token(Token = "0x6002F16")]
	[Address(RVA = "0x97DA10", Offset = "0x97C810", Length = "0xFE")]
	public void NextAffliction()
	{
	}

	[Token(Token = "0x6002F17")]
	[Address(RVA = "0x97DB10", Offset = "0x97C910", Length = "0x242")]
	public void TreatWound()
	{
	}

	[Token(Token = "0x6002F18")]
	[Address(RVA = "0x97DD60", Offset = "0x97CB60", Length = "0x51")]
	public static void GetAllAfflictions(List<Affliction> list)
	{
	}

	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x97DDC0", Offset = "0x97CBC0", Length = "0x465")]
	public static void GetAllBadAfflictions(AfflictionExclusions exclusions, List<Affliction> badAfflictions)
	{
	}

	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x97E230", Offset = "0x97D030", Length = "0x72")]
	public static AfflictionBodyArea GetAfflictionLocation(AfflictionType type, int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x97E2B0", Offset = "0x97D0B0", Length = "0xB38")]
	public static bool HasAffliction(AfflictionType afflictionType)
	{
		return false;
	}

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x97EED0", Offset = "0x97DCD0", Length = "0x307")]
	public static void GetAfflictions(FirstAidItem firstAidItem, List<Affliction> list)
	{
	}

	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x97F1E0", Offset = "0x97DFE0", Length = "0x1AD")]
	public static bool CanBeTreated(Affliction affliction)
	{
		return false;
	}

	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x97F390", Offset = "0x97E190", Length = "0x26B")]
	public static bool CanBeTreatedWith(FirstAidItem firstAidItem, Affliction affliction)
	{
		return false;
	}

	[Token(Token = "0x6002F1F")]
	[Address(RVA = "0x97F600", Offset = "0x97E400", Length = "0x488")]
	public static int GetAfflictionsCount(AfflictionType afflictionType)
	{
		return 0;
	}

	[Token(Token = "0x6002F20")]
	[Address(RVA = "0x97FB10", Offset = "0x97E910", Length = "0x1C9")]
	private bool TryGetSelectedAffliction(out Affliction affliction)
	{
		affliction = default(Affliction);
		return false;
	}

	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x97FCE0", Offset = "0x97EAE0", Length = "0x3B2")]
	private void MovePanel()
	{
	}

	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x9800A0", Offset = "0x97EEA0", Length = "0x341")]
	private void RestorePanel()
	{
	}

	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x9803F0", Offset = "0x97F1F0", Length = "0x1D7")]
	private void UpdateCoverFlowColor(int index, bool isSelected)
	{
	}

	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x9805D0", Offset = "0x97F3D0", Length = "0x364")]
	private void UpdateSelectedAffliction(Affliction affliction)
	{
	}

	[Token(Token = "0x6002F25")]
	[Address(RVA = "0x980940", Offset = "0x97F740", Length = "0xAF")]
	private void UpdateSelectedAffliction(int selectedAfflictionIndex)
	{
	}

	[Token(Token = "0x6002F26")]
	[Address(RVA = "0x9809F0", Offset = "0x97F7F0", Length = "0x300")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x980D00", Offset = "0x97FB00", Length = "0x84")]
	private void EnableInventoryRightSide(bool enabled)
	{
	}

	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x980D90", Offset = "0x97FB90", Length = "0x44A")]
	private void SetupScrollList(List<Affliction> afflictionList)
	{
	}

	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x9811E0", Offset = "0x97FFE0", Length = "0x1F7")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x9813E0", Offset = "0x9801E0", Length = "0x171")]
	private void UpdateTreatWoundsLocalizationId()
	{
	}

	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x981560", Offset = "0x980360", Length = "0x2FD")]
	private void InitializeColorReferences()
	{
	}

	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x981860", Offset = "0x980660", Length = "0x195")]
	private static void MaybeAddOrFilter(FirstAidItem firstAidItem, List<Affliction> list, Affliction affliction)
	{
	}

	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x981A00", Offset = "0x980800", Length = "0xA9")]
	private static string LocalizedNameFromAfflictionLocation(AfflictionBodyArea afflictionBodyArea)
	{
		return null;
	}

	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x981AB0", Offset = "0x9808B0", Length = "0x21C")]
	private static bool RequiresBandage(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x981CD0", Offset = "0x980AD0", Length = "0x133")]
	private static bool RequiresAntibiotic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[Token(Token = "0x6002F30")]
	[Address(RVA = "0x981E10", Offset = "0x980C10", Length = "0x7D")]
	private static bool RequiresAntiseptic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x981E90", Offset = "0x980C90", Length = "0x16B")]
	private static bool RequiresPainKiller(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x982000", Offset = "0x980E00", Length = "0x45C")]
	private static void RefreshtListOfShownAfflictionTypes()
	{
	}

	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x982460", Offset = "0x981260", Length = "0x31F")]
	private void UpdateGamepadSelection()
	{
	}

	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x982780", Offset = "0x981580", Length = "0x1610")]
	private static Affliction GetCurrentAffliction(AfflictionType type, int localAfflictionIndex)
	{
		return default(Affliction);
	}

	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x983E80", Offset = "0x982C80", Length = "0x20F")]
	public Panel_Affliction()
	{
	}
}
