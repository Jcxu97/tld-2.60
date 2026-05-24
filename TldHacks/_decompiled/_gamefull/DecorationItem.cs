using System;
using System.Collections.Generic;
using System.ComponentModel;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.Interactions;
using TLD.Logging;
using TLD.Placement;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x20002AD")]
public class DecorationItem : BaseInteraction, IAlternativeInteraction, ICraftingResult
{
	[Serializable]
	[Token(Token = "0x20002AE")]
	public struct PlacementReference
	{
		[Token(Token = "0x20002AF")]
		public enum ReferenceType
		{
			[Token(Token = "0x40017E7")]
			Default,
			[Token(Token = "0x40017E8")]
			Ground,
			[Token(Token = "0x40017E9")]
			Wall
		}

		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0x0")]
		public ReferenceType m_ReferenceType;

		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0x8")]
		public Transform m_Transform;

		[Token(Token = "0x170001EE")]
		[field: Token(Token = "0x40017E5")]
		public static PlacementReference[] EmptyList
		{
			[Token(Token = "0x60016E4")]
			[Address(RVA = "0x6C37D0", Offset = "0x6C25D0", Length = "0x53")]
			get;
		}
	}

	[Header("Decoration")]
	[SerializeField]
	[DefaultValue(true)]
	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x40")]
	private bool m_AllowInInventory;

	[SerializeField]
	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceDecorationItem m_DecorationPrefab;

	[SerializeField]
	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x50")]
	private DecorationCategory m_Category;

	[SerializeField]
	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x58")]
	private ItemWeight m_Weight;

	[Header("UI")]
	[SerializeField]
	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x60")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0x68")]
	private LocalizedString m_Description;

	[SerializeField]
	[Token(Token = "0x40017CB")]
	[FieldOffset(Offset = "0x70")]
	private AssetReferenceTexture2D m_IconReference;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0x78")]
	private AK.Wwise.Event m_DestroyEvent;

	[SerializeField]
	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x80")]
	private AK.Wwise.Event m_DropEvent;

	[SerializeField]
	[Token(Token = "0x40017CE")]
	[FieldOffset(Offset = "0x88")]
	private AK.Wwise.Event m_PickUpEvent;

	[SerializeField]
	[Token(Token = "0x40017CF")]
	[FieldOffset(Offset = "0x90")]
	private AK.Wwise.Event m_PlaceEvent;

	[SerializeField]
	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0x98")]
	private AK.Wwise.Event m_StowEvent;

	[SerializeField]
	[HideInInspector]
	[AutoComponent(ComponentRequirement.Optional)]
	[Token(Token = "0x40017D1")]
	[FieldOffset(Offset = "0xA0")]
	private BreakDown m_Breakdown;

	[HideInInspector]
	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0xB0")]
	public InProgressCraftItem m_InProgressCraftItem;

	[HideInInspector]
	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0xB8")]
	public RecoveryCamp m_RecoveryCampParent;

	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_CraftedItemPlacementPending;

	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0xC8")]
	private readonly List<Renderer> m_TintedRenderers;

	[Token(Token = "0x40017D7")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40017D8")]
	private static readonly List<DecorationItem> s_DecorationItems;

	[Token(Token = "0x40017D9")]
	private static readonly List<DecorationItem> s_ActiveSafehouseDecorationItems;

	[Token(Token = "0x40017DA")]
	private static readonly DecorationItemData s_DecorationItemData;

	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsTrackedAsActive;

	[Header("Placement")]
	[SerializeField]
	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0xD4")]
	private PlaceMeshRules m_PlacementRules;

	[SerializeField]
	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0xD8")]
	private PlacementReference[] m_ReferencePoints;

	[SerializeField]
	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_PrioritizeInteractionOverChildren;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0xE8")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0xF0")]
	private DecorationItem m_DecorationParent;

	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0xF8")]
	private readonly List<DecorationItem> m_DecorationChildren;

	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x100")]
	protected readonly List<ActionPickerItemData> m_ItemData;

	[Token(Token = "0x170001D9")]
	public AK.Wwise.Event DestroyEvent
	{
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DA")]
	public AK.Wwise.Event DropEvent
	{
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DB")]
	public AK.Wwise.Event PickUpEvent
	{
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DC")]
	public AK.Wwise.Event PlaceEvent
	{
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DD")]
	public AK.Wwise.Event StowEvent
	{
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x4B3EA0", Offset = "0x4B2CA0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DE")]
	public bool AllowInInventory
	{
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x6BCD10", Offset = "0x6BBB10", Length = "0x10")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001DF")]
	public DecorationCategory Category
	{
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x6285C0", Offset = "0x6273C0", Length = "0x4")]
		get
		{
			return default(DecorationCategory);
		}
	}

	[Token(Token = "0x170001E0")]
	public ItemWeight Weight
	{
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return default(ItemWeight);
		}
	}

	[Token(Token = "0x170001E1")]
	public string DisplayName
	{
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x6BCD50", Offset = "0x6BBB50", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E2")]
	public string DisplayNameLocId
	{
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x6BCDB0", Offset = "0x6BBBB0", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E3")]
	public AssetReferenceTexture2D IconReference
	{
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E4")]
	public AssetReference DecorationPrefab
	{
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x6BCDD0", Offset = "0x6BBBD0", Length = "0xC3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E5")]
	[field: Token(Token = "0x40017D2")]
	[field: FieldOffset(Offset = "0xA8")]
	public Action<bool> OnPlaceMeshComplete
	{
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
		get;
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x6BCEA0", Offset = "0x6BBCA0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x170001E6")]
	public override bool IsEnabled
	{
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x6BCF00", Offset = "0x6BBD00", Length = "0xF2")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001E7")]
	public static int NumActiveDecorations
	{
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x6BD000", Offset = "0x6BBE00", Length = "0x72")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170001E8")]
	public PlaceMeshRules PlacementRules
	{
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x6BE230", Offset = "0x6BD030", Length = "0x7")]
		get
		{
			return default(PlaceMeshRules);
		}
	}

	[Token(Token = "0x170001E9")]
	public bool AllowAsStackingParent
	{
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x6BF840", Offset = "0x6BE640", Length = "0xB")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001EA")]
	public List<DecorationItem> DecorationChildren
	{
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x6BF850", Offset = "0x6BE650", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001EB")]
	public DecorationItem DecorationParent
	{
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x694DC0", Offset = "0x693BC0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001EC")]
	public bool PrioritizeInteractionOverChildren
	{
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x67FFB0", Offset = "0x67EDB0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001ED")]
	public bool AllowEditModePlacement
	{
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x6BF860", Offset = "0x6BE660", Length = "0xEF")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x6BCD20", Offset = "0x6BBB20", Length = "0x8")]
	public bool IsCraftedItemPlacementPending()
	{
		return false;
	}

	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x6BCD30", Offset = "0x6BBB30", Length = "0x8")]
	public void SetCraftedItemPlacementPending()
	{
	}

	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x69A4D0", Offset = "0x6992D0", Length = "0x8")]
	public void ResetCraftedItemPlacementPending()
	{
	}

	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x6BD080", Offset = "0x6BBE80", Length = "0x39C")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x6BD420", Offset = "0x6BC220", Length = "0x91")]
	public bool HasRenderer(Renderer renderer)
	{
		return false;
	}

	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x6BD4C0", Offset = "0x6BC2C0", Length = "0x58")]
	private List<Renderer> GetRenderers()
	{
		return null;
	}

	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x6BD520", Offset = "0x6BC320", Length = "0x150")]
	private void GatherRenderers()
	{
	}

	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x6BD680", Offset = "0x6BC480", Length = "0x7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x6BD690", Offset = "0x6BC490", Length = "0x347")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x6BD9E0", Offset = "0x6BC7E0", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x6BD9F0", Offset = "0x6BC7F0", Length = "0x8A")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x6BDA80", Offset = "0x6BC880", Length = "0x67")]
	public void FinalizePlacement(bool success)
	{
	}

	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x6BDAF0", Offset = "0x6BC8F0", Length = "0x5D7")]
	private void FinalizePlacementRecursive(bool success, bool isParent)
	{
	}

	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x6BCD50", Offset = "0x6BBB50", Length = "0x5D")]
	public string GetCraftingDisplayName()
	{
		return null;
	}

	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public StackableItem GetStackableItem()
	{
		return null;
	}

	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x6BE0D0", Offset = "0x6BCED0", Length = "0x5D")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x6BE130", Offset = "0x6BCF30", Length = "0xF1")]
	public ItemWeight GetItemWeightKG(float stackMultiplier, bool ignoreClothingBonus)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x6BCD10", Offset = "0x6BBB10", Length = "0x10")]
	public bool AllowedInInventory()
	{
		return false;
	}

	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x6BE230", Offset = "0x6BD030", Length = "0x7")]
	public PlaceMeshRules GetPlacementRules()
	{
		return default(PlaceMeshRules);
	}

	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x6BE240", Offset = "0x6BD040", Length = "0xC3")]
	public InProgressCraftItem InitializeCraftInProgress()
	{
		return null;
	}

	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x6BE310", Offset = "0x6BD110", Length = "0xC5")]
	private void OnStartCustomization()
	{
	}

	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x6BE3E0", Offset = "0x6BD1E0", Length = "0x6F")]
	private void OnStopCustomization()
	{
	}

	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x6BCDD0", Offset = "0x6BBBD0", Length = "0xC3")]
	private AssetReference GetDecorationPrefab()
	{
		return null;
	}

	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x6BE450", Offset = "0x6BD250", Length = "0x681")]
	public static DecorationItemData SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x6BEAE0", Offset = "0x6BD8E0", Length = "0x688")]
	public static void DeserializeAll(DecorationItemData data)
	{
	}

	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x6BF170", Offset = "0x6BDF70", Length = "0x3F6")]
	private static void ReassignBoxSectors()
	{
	}

	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x6BF570", Offset = "0x6BE370", Length = "0x1FD")]
	private static bool TryGetDecorationFromId(string itemId, out DecorationItem item)
	{
		item = null;
		return false;
	}

	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x6BF770", Offset = "0x6BE570", Length = "0xC6")]
	public void MaybeCountAsActiveDecoration()
	{
	}

	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x6BF950", Offset = "0x6BE750", Length = "0xEF")]
	private bool IsCorpseRemoval()
	{
		return false;
	}

	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x6BFA40", Offset = "0x6BE840", Length = "0x52")]
	public Texture2D GetInventoryIconTexture()
	{
		return null;
	}

	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x6BFAA0", Offset = "0x6BE8A0", Length = "0xFD")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x6BFBA0", Offset = "0x6BE9A0", Length = "0x121")]
	public override void HideInteraction()
	{
	}

	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x6BFCD0", Offset = "0x6BEAD0", Length = "0x368")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x6C0040", Offset = "0x6BEE40", Length = "0x323")]
	public bool PerformAlternativeInteraction()
	{
		return false;
	}

	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x6C0370", Offset = "0x6BF170", Length = "0x561")]
	public void GetBestReferenceRelativePose(RaycastHit hit, out Vector3 rootToReferenceOffset, out Quaternion rootToReferenceRotation)
	{
		rootToReferenceOffset = default(Vector3);
		rootToReferenceRotation = default(Quaternion);
	}

	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x6C08E0", Offset = "0x6BF6E0", Length = "0x48")]
	public bool HasChildren()
	{
		return false;
	}

	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x6C0930", Offset = "0x6BF730", Length = "0x34D")]
	public void SetParent(DecorationItem decorationParent)
	{
	}

	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x6C0C80", Offset = "0x6BFA80", Length = "0x3AD")]
	protected virtual void SetupInteraction()
	{
	}

	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x6C1030", Offset = "0x6BFE30", Length = "0xFF")]
	private bool IsInStackingChain(Transform t)
	{
		return false;
	}

	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x6C1130", Offset = "0x6BFF30", Length = "0x368")]
	private void OnPickup()
	{
	}

	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x6C14A0", Offset = "0x6C02A0", Length = "0xEE")]
	private void OnBreakdown()
	{
	}

	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x6C1590", Offset = "0x6C0390", Length = "0x420")]
	public void RemoveFromHierarchy()
	{
	}

	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x6C19C0", Offset = "0x6C07C0", Length = "0x23A")]
	private void RefreshInteractionSetup()
	{
	}

	[Token(Token = "0x60016DC")]
	[Address(RVA = "0x6C1C00", Offset = "0x6C0A00", Length = "0x50F")]
	private Transform GetBestReferencePoint(RaycastHit hit)
	{
		return null;
	}

	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x6C2110", Offset = "0x6C0F10", Length = "0xE1")]
	private void DropToReferencePosition(Vector3 referencePosition)
	{
	}

	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x6C2200", Offset = "0x6C1000", Length = "0x2FD")]
	private void DropSelfAndChildren(float dropAmount)
	{
	}

	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x6C2500", Offset = "0x6C1300", Length = "0x105")]
	private PlacementReference GetReferenceForType(PlacementReference.ReferenceType type)
	{
		return default(PlacementReference);
	}

	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x6C2610", Offset = "0x6C1410", Length = "0x3C9")]
	private void MaybeInitializeStackingParent()
	{
	}

	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x6C29E0", Offset = "0x6C17E0", Length = "0x6C1")]
	private void GetPossibleParentAlongRay(PlacementReference reference, float maxDistance, RaycastHit[] hits, int mask, ref DecorationItem possibleParent, ref float closestDistance)
	{
	}

	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x6C30B0", Offset = "0x6C1EB0", Length = "0x2D2")]
	public DecorationItem()
	{
	}
}
