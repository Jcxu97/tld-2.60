using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using TLD.Utility;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000569")]
public class CuringStorage : DecorationItem
{
	[Header("General Settings")]
	[SerializeField]
	[Token(Token = "0x40031ED")]
	[FieldOffset(Offset = "0x108")]
	private float m_UpdateIntervalHours;

	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x40031EE")]
	[FieldOffset(Offset = "0x110")]
	private string m_OpenActionSprite;

	[Header("Curing")]
	[SerializeField]
	[Token(Token = "0x40031EF")]
	[FieldOffset(Offset = "0x118")]
	private ItemWeight m_MaxStorage;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x40031F0")]
	[FieldOffset(Offset = "0x120")]
	private float m_HoursUntilCured;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x40031F1")]
	[FieldOffset(Offset = "0x124")]
	private float m_MinItemNormalizedCondition;

	[Header("Rotting")]
	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x40031F2")]
	[FieldOffset(Offset = "0x128")]
	private float m_HoursUntilRotten;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x40031F3")]
	[FieldOffset(Offset = "0x12C")]
	private float m_MinRottedNormalizedCondition;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x40031F4")]
	[FieldOffset(Offset = "0x130")]
	private float m_MaxRottenNormalizedCondition;

	[Header("Salt Storage")]
	[SerializeField]
	[Token(Token = "0x40031F5")]
	[FieldOffset(Offset = "0x138")]
	private LocalizedString m_SaltText;

	[SerializeField]
	[Token(Token = "0x40031F6")]
	[FieldOffset(Offset = "0x140")]
	private PowderType m_SaltPowderType;

	[SerializeField]
	[Token(Token = "0x40031F7")]
	[FieldOffset(Offset = "0x148")]
	private ItemWeight m_MaxSalt;

	[SerializeField]
	[Token(Token = "0x40031F8")]
	[FieldOffset(Offset = "0x150")]
	private ItemWeight m_StartingSalt;

	[SerializeField]
	[Token(Token = "0x40031F9")]
	[FieldOffset(Offset = "0x158")]
	private ItemWeight m_SaltConsumedPerHour;

	[SerializeField]
	[Token(Token = "0x40031FA")]
	[FieldOffset(Offset = "0x160")]
	private ItemWeight m_MinSaltForCuring;

	[Header("Cured References")]
	[SerializeField]
	[Token(Token = "0x40031FB")]
	[FieldOffset(Offset = "0x168")]
	private GearItemData m_CuredMeat;

	[SerializeField]
	[Token(Token = "0x40031FC")]
	[FieldOffset(Offset = "0x170")]
	private GearItemData m_CuredFish;

	[Header("Box Elements")]
	[SerializeField]
	[Token(Token = "0x40031FD")]
	[FieldOffset(Offset = "0x178")]
	private ObjectAnim m_ObjectAnim;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40031FE")]
	[FieldOffset(Offset = "0x180")]
	private AK.Wwise.Event m_BoxOpenEvent;

	[SerializeField]
	[Token(Token = "0x40031FF")]
	[FieldOffset(Offset = "0x188")]
	private AK.Wwise.Event m_BoxCloseEvent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003200")]
	[FieldOffset(Offset = "0x190")]
	private PanelReference<Panel_CuringStorage> m_CuringStorageReference;

	[SerializeField]
	[Token(Token = "0x4003201")]
	[FieldOffset(Offset = "0x198")]
	private PanelReference<Panel_PickUnits> m_PickUnits;

	[SerializeField]
	[Token(Token = "0x4003202")]
	[FieldOffset(Offset = "0x1A0")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[Token(Token = "0x4003203")]
	private static readonly List<CuringStorage> s_AllCuringStorage;

	[Token(Token = "0x4003204")]
	[FieldOffset(Offset = "0x1A8")]
	private bool m_PendingClose;

	[Token(Token = "0x4003205")]
	[FieldOffset(Offset = "0x1A9")]
	private bool m_ShowingPanel;

	[Token(Token = "0x4003206")]
	[FieldOffset(Offset = "0x1B0")]
	private CuringStorageState m_State;

	[Token(Token = "0x4003207")]
	[FieldOffset(Offset = "0x1B8")]
	private ItemWeight m_LastHoverTextSalt;

	[Token(Token = "0x4003208")]
	[FieldOffset(Offset = "0x1C0")]
	private readonly List<GearItem> m_AddedSalt;

	[Token(Token = "0x4003209")]
	[FieldOffset(Offset = "0x1C8")]
	private readonly List<GearItem> m_NewItems;

	[Token(Token = "0x170002AB")]
	public List<CuringStorageState.CuringItem> CuringItems
	{
		[Token(Token = "0x6002985")]
		[Address(RVA = "0x8EC840", Offset = "0x8EB640", Length = "0x1E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AC")]
	public List<GearItem> AddedSalt
	{
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x8EC860", Offset = "0x8EB660", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AD")]
	[field: Token(Token = "0x400320A")]
	[field: FieldOffset(Offset = "0x1D0")]
	public ItemWeight TotalWeight
	{
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x8EC870", Offset = "0x8EB670", Length = "0x8")]
		get;
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x8EC880", Offset = "0x8EB680", Length = "0x8")]
		private set;
	}

	[Token(Token = "0x170002AE")]
	public ItemWeight Capacity
	{
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x699260", Offset = "0x698060", Length = "0x8")]
		get
		{
			return default(ItemWeight);
		}
	}

	[Token(Token = "0x170002AF")]
	public ItemWeight CurrentSaltStorage
	{
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x8EC890", Offset = "0x8EB690", Length = "0x1E")]
		get
		{
			return default(ItemWeight);
		}
	}

	[Token(Token = "0x170002B0")]
	public ItemWeight SaltStorageCapacity
	{
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x8EC8B0", Offset = "0x8EB6B0", Length = "0x8")]
		get
		{
			return default(ItemWeight);
		}
	}

	[Token(Token = "0x170002B1")]
	[field: Token(Token = "0x400320B")]
	[field: FieldOffset(Offset = "0x1D8")]
	public ItemWeight AddedSaltWeight
	{
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x5C4D50", Offset = "0x5C3B50", Length = "0x8")]
		get;
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x8EC8C0", Offset = "0x8EB6C0", Length = "0x8")]
		private set;
	}

	[Token(Token = "0x170002B2")]
	public override bool IsEnabled
	{
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x8EC8D0", Offset = "0x8EB6D0", Length = "0x98")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600298F")]
	[Address(RVA = "0x8EC970", Offset = "0x8EB770", Length = "0x204")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002990")]
	[Address(RVA = "0x8ECB80", Offset = "0x8EB980", Length = "0x211")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002991")]
	[Address(RVA = "0x8ECDA0", Offset = "0x8EBBA0", Length = "0x14A")]
	protected override void SetupInteraction()
	{
	}

	[Token(Token = "0x6002992")]
	[Address(RVA = "0x8ECEF0", Offset = "0x8EBCF0", Length = "0x136")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6002993")]
	[Address(RVA = "0x8ED030", Offset = "0x8EBE30", Length = "0xEB")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6002994")]
	[Address(RVA = "0x8ED120", Offset = "0x8EBF20", Length = "0x286")]
	private void UpdateHoverText()
	{
	}

	[Token(Token = "0x6002995")]
	[Address(RVA = "0x8ED3B0", Offset = "0x8EC1B0", Length = "0x232")]
	private void PrepareAndShow()
	{
	}

	[Token(Token = "0x6002996")]
	[Address(RVA = "0x8ED5F0", Offset = "0x8EC3F0", Length = "0x6DF")]
	private void CloseCuringStorage()
	{
	}

	[Token(Token = "0x6002997")]
	[Address(RVA = "0x8EDCD0", Offset = "0x8ECAD0", Length = "0x449")]
	private bool UpdateInstantiatedItems()
	{
		return false;
	}

	[Token(Token = "0x6002998")]
	[Address(RVA = "0x8EE120", Offset = "0x8ECF20", Length = "0x371")]
	private GearItem InstantiateGearItem(AssetReference prefabReference, float normalizedCondition, float remainingFraction)
	{
		return null;
	}

	[Token(Token = "0x6002999")]
	[Address(RVA = "0x8EE4A0", Offset = "0x8ED2A0", Length = "0x58F")]
	private void Update()
	{
	}

	[Token(Token = "0x600299A")]
	[Address(RVA = "0x8EEA30", Offset = "0x8ED830", Length = "0xA0")]
	private bool IsPanelClosed()
	{
		return false;
	}

	[Token(Token = "0x600299B")]
	[Address(RVA = "0x8EEAD0", Offset = "0x8ED8D0", Length = "0x496")]
	private void UpdateTotalWeight()
	{
	}

	[Token(Token = "0x600299C")]
	[Address(RVA = "0x8EEF70", Offset = "0x8EDD70", Length = "0x4C0")]
	public void AddItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x600299D")]
	[Address(RVA = "0x8EF440", Offset = "0x8EE240", Length = "0x2FD")]
	public void RemoveItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x600299E")]
	[Address(RVA = "0x8EF740", Offset = "0x8EE540", Length = "0x377")]
	public bool IsLockedItem(GearItem gearItem, bool isInventoryItem)
	{
		return false;
	}

	[Token(Token = "0x600299F")]
	[Address(RVA = "0x8EFAC0", Offset = "0x8EE8C0", Length = "0x283")]
	public bool HasFinishedCuring(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x8EFD50", Offset = "0x8EEB50", Length = "0x283")]
	public float GetCuredFraction(GearItem gearItem)
	{
		return 0f;
	}

	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x8EFFE0", Offset = "0x8EEDE0", Length = "0xC5")]
	private void AnimateBoxOpen()
	{
	}

	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x8F00B0", Offset = "0x8EEEB0", Length = "0xF5")]
	private void AnimateBoxClose()
	{
	}

	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x8F01B0", Offset = "0x8EEFB0", Length = "0x38D")]
	public static List<CuringStorageState> SerializeAllCuringStorage()
	{
		return null;
	}

	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x8F0540", Offset = "0x8EF340", Length = "0x2B7")]
	public static void DeserializeAllCuringStorage(List<CuringStorageState> states)
	{
	}

	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x8F0800", Offset = "0x8EF600", Length = "0x89")]
	private CuringStorageState SerializeCuringStorage()
	{
		return null;
	}

	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x8F0890", Offset = "0x8EF690", Length = "0x52")]
	private void DeserializeCuringStorage(CuringStorageState state)
	{
	}

	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x8F08F0", Offset = "0x8EF6F0", Length = "0x8E")]
	public bool IsEmpty()
	{
		return false;
	}

	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x8F0980", Offset = "0x8EF780", Length = "0x167")]
	public CuringStorage()
	{
	}
}
