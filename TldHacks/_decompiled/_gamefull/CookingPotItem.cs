using Cpp2ILInjected;
using TLD.Cooking;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000476")]
public class CookingPotItem : MonoBehaviour
{
	[Token(Token = "0x2000477")]
	public enum CookingState
	{
		[Token(Token = "0x4002899")]
		Cooking,
		[Token(Token = "0x400289A")]
		Ready,
		[Token(Token = "0x400289B")]
		Ruined
	}

	[Token(Token = "0x2000478")]
	public enum GrubMeshType
	{
		[Token(Token = "0x400289D")]
		Pot,
		[Token(Token = "0x400289E")]
		Can,
		[Token(Token = "0x400289F")]
		FryingPan
	}

	[Header("Gameplay Tunables")]
	[SerializeField]
	[Token(Token = "0x4002850")]
	[FieldOffset(Offset = "0x20")]
	private CookSettings m_CookSettings;

	[Token(Token = "0x4002851")]
	[FieldOffset(Offset = "0x28")]
	public bool m_CanCookMeat;

	[Token(Token = "0x4002852")]
	[FieldOffset(Offset = "0x29")]
	public bool m_CanCookGrub;

	[Token(Token = "0x4002853")]
	[FieldOffset(Offset = "0x2A")]
	public bool m_CanCookLiquid;

	[Token(Token = "0x4002854")]
	[FieldOffset(Offset = "0x2B")]
	public bool m_CanOnlyWarmUpFood;

	[Token(Token = "0x4002855")]
	[FieldOffset(Offset = "0x30")]
	public ItemLiquidVolume m_WaterCapacity;

	[Token(Token = "0x4002856")]
	[FieldOffset(Offset = "0x38")]
	public float m_ConditionPercentDamageFromBurningFood;

	[Token(Token = "0x4002857")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ConditionPercentDamageFromBoilingDry;

	[Token(Token = "0x4002858")]
	[FieldOffset(Offset = "0x40")]
	public float m_CookingTimeMultiplier;

	[Token(Token = "0x4002859")]
	[FieldOffset(Offset = "0x44")]
	public float m_ReadyTimeMultiplier;

	[Token(Token = "0x400285A")]
	[FieldOffset(Offset = "0x48")]
	public float m_BoilingTimeMultiplier;

	[Token(Token = "0x400285B")]
	[FieldOffset(Offset = "0x4C")]
	public float m_LampOilMultiplier;

	[Token(Token = "0x400285C")]
	[FieldOffset(Offset = "0x50")]
	public float m_CookedCalorieMultiplier;

	[Token(Token = "0x400285D")]
	[FieldOffset(Offset = "0x54")]
	public float m_NearFireWarmUpCookingTimeMultiplier;

	[Token(Token = "0x400285E")]
	[FieldOffset(Offset = "0x58")]
	public float m_NearFireWarmUpReadyTimeMultiplier;

	[Header("Warning Levels")]
	[Token(Token = "0x400285F")]
	[FieldOffset(Offset = "0x5C")]
	public float m_WarningMinutesBeforeCooked;

	[Token(Token = "0x4002860")]
	[FieldOffset(Offset = "0x60")]
	public float m_WarningMinutesBeforeRuined;

	[Header("Visuals")]
	[Token(Token = "0x4002861")]
	[FieldOffset(Offset = "0x64")]
	public GrubMeshType m_GrubMeshType;

	[Token(Token = "0x4002862")]
	[FieldOffset(Offset = "0x68")]
	public MeshFilter m_GrubMeshFilter;

	[Token(Token = "0x4002863")]
	[FieldOffset(Offset = "0x70")]
	public MeshRenderer m_GrubMeshRenderer;

	[Token(Token = "0x4002864")]
	[FieldOffset(Offset = "0x78")]
	public Material[] m_RuinedFoodMaterialsList;

	[Token(Token = "0x4002865")]
	[FieldOffset(Offset = "0x80")]
	public Material[] m_MeltSnowMaterialsList;

	[Token(Token = "0x4002866")]
	[FieldOffset(Offset = "0x88")]
	public Material[] m_BoilWaterPotMaterialsList;

	[Token(Token = "0x4002867")]
	[FieldOffset(Offset = "0x90")]
	public Material[] m_BoilWaterReadyMaterialsList;

	[Token(Token = "0x4002868")]
	[FieldOffset(Offset = "0x98")]
	public Mesh m_SnowMesh;

	[Token(Token = "0x4002869")]
	[FieldOffset(Offset = "0xA0")]
	public Mesh m_WaterMesh;

	[Token(Token = "0x400286A")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_ParticlesItemCooking;

	[Token(Token = "0x400286B")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_ParticlesItemReady;

	[Token(Token = "0x400286C")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_ParticlesItemRuined;

	[Token(Token = "0x400286D")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_ParticlesSnowMelting;

	[Token(Token = "0x400286E")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_ParticlesWaterBoiling;

	[Token(Token = "0x400286F")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_ParticlesWaterReady;

	[Token(Token = "0x4002870")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_ParticlesWaterRuined;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002871")]
	[FieldOffset(Offset = "0xE0")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[SerializeField]
	[Token(Token = "0x4002872")]
	[FieldOffset(Offset = "0xE8")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x4002873")]
	[FieldOffset(Offset = "0xF0")]
	private PanelReference<Panel_CanOpening> m_CanOpening;

	[SerializeField]
	[Token(Token = "0x4002874")]
	[FieldOffset(Offset = "0xF8")]
	private PanelReference<Panel_Rest> m_Rest;

	[Token(Token = "0x4002875")]
	[FieldOffset(Offset = "0x100")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002876")]
	[FieldOffset(Offset = "0x108")]
	private Fire m_FireBeingUsed;

	[Token(Token = "0x4002877")]
	[FieldOffset(Offset = "0x110")]
	private GearPlacePoint m_GearPlacePointAttachedTo;

	[Token(Token = "0x4002878")]
	[FieldOffset(Offset = "0x118")]
	private GearItem m_GearItemBeingCooked;

	[Token(Token = "0x4002879")]
	[FieldOffset(Offset = "0x120")]
	private GearItem m_GearItemSpawnedForInspectMode;

	[Token(Token = "0x400287A")]
	[FieldOffset(Offset = "0x128")]
	private GearItem m_GearItemToEatDrinkFromInspectMode;

	[Token(Token = "0x400287B")]
	[FieldOffset(Offset = "0x130")]
	private float m_CookingElapsedHours;

	[Token(Token = "0x400287C")]
	[FieldOffset(Offset = "0x134")]
	private float m_GracePeriodElapsedHours;

	[Token(Token = "0x400287D")]
	[FieldOffset(Offset = "0x138")]
	private string m_GearItemGUIDFromDeserialize;

	[Token(Token = "0x400287E")]
	[FieldOffset(Offset = "0x140")]
	private ItemLiquidVolume m_LitersSnowBeingMelted;

	[Token(Token = "0x400287F")]
	[FieldOffset(Offset = "0x148")]
	private ItemLiquidVolume m_LitersWaterBeingBoiled;

	[Token(Token = "0x4002880")]
	[FieldOffset(Offset = "0x150")]
	private CookingState m_CookingState;

	[Token(Token = "0x4002881")]
	[FieldOffset(Offset = "0x154")]
	private float m_PercentCooked;

	[Token(Token = "0x4002882")]
	[FieldOffset(Offset = "0x158")]
	private float m_PercentRuined;

	[Token(Token = "0x4002883")]
	[FieldOffset(Offset = "0x15C")]
	private float m_MinutesUntilCooked;

	[Token(Token = "0x4002884")]
	[FieldOffset(Offset = "0x160")]
	private float m_MinutesUntilRuined;

	[Token(Token = "0x4002885")]
	[FieldOffset(Offset = "0x164")]
	private bool m_ForceParticleUpdate;

	[Token(Token = "0x4002886")]
	[FieldOffset(Offset = "0x168")]
	private GameObject m_ParticlesCurrentlyEnabled;

	[Token(Token = "0x4002887")]
	[FieldOffset(Offset = "0x170")]
	private bool m_IsBeingInspected;

	[Token(Token = "0x4002888")]
	[FieldOffset(Offset = "0x171")]
	private bool m_IsBeingPlaced;

	[Token(Token = "0x4002889")]
	[FieldOffset(Offset = "0x178")]
	private Fire m_CachedFireBeingUsed;

	[Token(Token = "0x400288A")]
	[FieldOffset(Offset = "0x180")]
	private GearPlacePoint m_CachedGearPlacePoint;

	[Token(Token = "0x400288B")]
	[FieldOffset(Offset = "0x188")]
	private uint m_CookingAudioId;

	[Token(Token = "0x400288C")]
	[FieldOffset(Offset = "0x18C")]
	private bool m_ShouldInterruptPassTime;

	[Token(Token = "0x400288D")]
	[FieldOffset(Offset = "0x18D")]
	private bool m_HasDoneReattachCheck;

	[Token(Token = "0x400288E")]
	[FieldOffset(Offset = "0x190")]
	private float m_CookingStateEventCooldown;

	[Token(Token = "0x400288F")]
	[FieldOffset(Offset = "0x194")]
	private bool m_HasParticlesItemCooking;

	[Token(Token = "0x4002890")]
	[FieldOffset(Offset = "0x195")]
	private bool m_HasParticlesItemReady;

	[Token(Token = "0x4002891")]
	[FieldOffset(Offset = "0x196")]
	private bool m_HasParticlesItemRuined;

	[Token(Token = "0x4002892")]
	[FieldOffset(Offset = "0x197")]
	private bool m_HasParticlesSnowMelting;

	[Token(Token = "0x4002893")]
	[FieldOffset(Offset = "0x198")]
	private bool m_HasParticlesWaterBoiling;

	[Token(Token = "0x4002894")]
	[FieldOffset(Offset = "0x199")]
	private bool m_HasParticlesWaterReady;

	[Token(Token = "0x4002895")]
	[FieldOffset(Offset = "0x19A")]
	private bool m_HasParticlesWaterRuined;

	[Token(Token = "0x4002896")]
	[FieldOffset(Offset = "0x19B")]
	private bool m_ParticlesTurnedOff;

	[Token(Token = "0x4002897")]
	private static readonly CookingPotItemSaveDataProxy s_CookingPotItemSaveDataProxy;

	[Token(Token = "0x600217E")]
	[Address(RVA = "0x812090", Offset = "0x810E90", Length = "0x56B")]
	private void Awake()
	{
	}

	[Token(Token = "0x600217F")]
	[Address(RVA = "0x812600", Offset = "0x811400", Length = "0x8")]
	public bool IsBeingPlaced()
	{
		return false;
	}

	[Token(Token = "0x6002180")]
	[Address(RVA = "0x812610", Offset = "0x811410", Length = "0x104")]
	public bool HasInInventory(Inventory inventory)
	{
		return false;
	}

	[Token(Token = "0x6002181")]
	[Address(RVA = "0x812720", Offset = "0x811520", Length = "0x5F3")]
	private void Update()
	{
	}

	[Token(Token = "0x6002182")]
	[Address(RVA = "0x812D20", Offset = "0x811B20", Length = "0x57")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002183")]
	[Address(RVA = "0x812D80", Offset = "0x811B80", Length = "0x5DC")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002184")]
	[Address(RVA = "0x813360", Offset = "0x812160", Length = "0x430")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002185")]
	[Address(RVA = "0x8137A0", Offset = "0x8125A0", Length = "0x11E")]
	public bool ShouldProcessInteractionInternal()
	{
		return false;
	}

	[Token(Token = "0x6002186")]
	[Address(RVA = "0x8138C0", Offset = "0x8126C0", Length = "0x104")]
	public bool CanOpenCookingInterface()
	{
		return false;
	}

	[Token(Token = "0x6002187")]
	[Address(RVA = "0x8139D0", Offset = "0x8127D0", Length = "0x116")]
	public bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002188")]
	[Address(RVA = "0x813AF0", Offset = "0x8128F0", Length = "0x1CF")]
	public bool CanCookItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6002189")]
	[Address(RVA = "0x813CC0", Offset = "0x812AC0", Length = "0xDB5")]
	public void StartCooking(GearItem gearItemToCook)
	{
	}

	[Token(Token = "0x600218A")]
	[Address(RVA = "0x814A80", Offset = "0x813880", Length = "0x192")]
	public void StartMeltingSnow(ItemLiquidVolume amountToMelt)
	{
	}

	[Token(Token = "0x600218B")]
	[Address(RVA = "0x814C20", Offset = "0x813A20", Length = "0x234")]
	public void StartBoilingWater(ItemLiquidVolume amountToBoil, bool doWaterRemoval = true)
	{
	}

	[Token(Token = "0x600218C")]
	[Address(RVA = "0x814E60", Offset = "0x813C60", Length = "0xAA")]
	public void AttachToFire(Fire fire, GearPlacePoint gpp)
	{
	}

	[Token(Token = "0x600218D")]
	[Address(RVA = "0x814F10", Offset = "0x813D10", Length = "0xAA")]
	public void DetachFromFire()
	{
	}

	[Token(Token = "0x600218E")]
	[Address(RVA = "0x814FC0", Offset = "0x813DC0", Length = "0x8")]
	public Fire GetFireBeingUsed()
	{
		return null;
	}

	[Token(Token = "0x600218F")]
	[Address(RVA = "0x814FD0", Offset = "0x813DD0", Length = "0x27C")]
	public bool TryGetCookingSlot(out CookingSlot cookingSlot)
	{
		cookingSlot = null;
		return false;
	}

	[Token(Token = "0x6002190")]
	[Address(RVA = "0x815250", Offset = "0x814050", Length = "0x7BA")]
	private static CookingSlot FindCookingSlotForGearPlacePoint(GearPlacePoint placePoint, ref Fire fire)
	{
		return null;
	}

	[Token(Token = "0x6002191")]
	[Address(RVA = "0x815A10", Offset = "0x814810", Length = "0xCA9")]
	public string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6002192")]
	[Address(RVA = "0x8166C0", Offset = "0x8154C0", Length = "0xCA")]
	public bool IsDummyPot()
	{
		return false;
	}

	[Token(Token = "0x6002193")]
	[Address(RVA = "0x816790", Offset = "0x815590", Length = "0x144")]
	public bool IsCookingSomething()
	{
		return false;
	}

	[Token(Token = "0x6002194")]
	[Address(RVA = "0x8168E0", Offset = "0x8156E0", Length = "0x7E1")]
	public void MaybeSpawnGearItemForInspectMode()
	{
	}

	[Token(Token = "0x6002195")]
	[Address(RVA = "0x8170D0", Offset = "0x815ED0", Length = "0xE6")]
	public GearItem GetGearItemForInspectMode()
	{
		return null;
	}

	[Token(Token = "0x6002196")]
	[Address(RVA = "0x8171C0", Offset = "0x815FC0", Length = "0x9F")]
	public bool ShouldShowPotModelInInspect()
	{
		return false;
	}

	[Token(Token = "0x6002197")]
	[Address(RVA = "0x817260", Offset = "0x816060", Length = "0x294")]
	public void DestroyGearItemBeingCooked()
	{
	}

	[Token(Token = "0x6002198")]
	[Address(RVA = "0x817500", Offset = "0x816300", Length = "0xFB")]
	public bool CanPickupItemWhileCooking()
	{
		return false;
	}

	[Token(Token = "0x6002199")]
	[Address(RVA = "0x817600", Offset = "0x816400", Length = "0x306")]
	public void PickUpCookedItem()
	{
	}

	[Token(Token = "0x600219A")]
	[Address(RVA = "0x817910", Offset = "0x816710", Length = "0x2DA")]
	public bool DoSpecialActionFromInspectMode(ItemLiquidVolume volumeAvailable)
	{
		return false;
	}

	[Token(Token = "0x600219B")]
	[Address(RVA = "0x817BF0", Offset = "0x8169F0", Length = "0x311")]
	public void InspectModeCallback()
	{
	}

	[Token(Token = "0x600219C")]
	[Address(RVA = "0x817F10", Offset = "0x816D10", Length = "0x7A")]
	public float GetTotalCookMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x600219D")]
	[Address(RVA = "0x817F90", Offset = "0x816D90", Length = "0x7A")]
	public float GetTotalBoilMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x600219E")]
	[Address(RVA = "0x818010", Offset = "0x816E10", Length = "0xFD")]
	public float GetTotalReadyMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x600219F")]
	[Address(RVA = "0x818110", Offset = "0x816F10", Length = "0x1CD")]
	public void EnterPlaceMesh()
	{
	}

	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x8182E0", Offset = "0x8170E0", Length = "0xCA")]
	public void RestoreCachedFire()
	{
	}

	[Token(Token = "0x60021A1")]
	[Address(RVA = "0x8183B0", Offset = "0x8171B0", Length = "0x857")]
	public void ExitPlaceMesh()
	{
	}

	[Token(Token = "0x60021A2")]
	[Address(RVA = "0x818C10", Offset = "0x817A10", Length = "0x7")]
	public CookingState GetCookingState()
	{
		return default(CookingState);
	}

	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x677F90", Offset = "0x676D90", Length = "0x8")]
	public GearPlacePoint GetGearPlacePoint()
	{
		return null;
	}

	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x818C20", Offset = "0x817A20", Length = "0xCD")]
	public bool IsAttachedToGearPlacePoint()
	{
		return false;
	}

	[Token(Token = "0x60021A5")]
	[Address(RVA = "0x818CF0", Offset = "0x817AF0", Length = "0xF5")]
	public bool AttachedFireIsBurning()
	{
		return false;
	}

	[Token(Token = "0x60021A6")]
	[Address(RVA = "0x818DF0", Offset = "0x817BF0", Length = "0x2FD")]
	public void PlayPutBackFromInspectAudio()
	{
	}

	[Token(Token = "0x60021A7")]
	[Address(RVA = "0x8190F0", Offset = "0x817EF0", Length = "0x157")]
	public void PlayStowFromInspectAudio()
	{
	}

	[Token(Token = "0x60021A8")]
	[Address(RVA = "0x819250", Offset = "0x818050", Length = "0xE5")]
	public void PlayGearItemInsidePickupAudio()
	{
	}

	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x819340", Offset = "0x818140", Length = "0x130")]
	public void PlayAttachToFireAudio(GearPlacePoint gpp)
	{
	}

	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x819480", Offset = "0x818280", Length = "0x59")]
	private void SetHeatPercentWhenCooked(FoodItem foodItem)
	{
	}

	[Token(Token = "0x60021AB")]
	[Address(RVA = "0x8194E0", Offset = "0x8182E0", Length = "0x16B0")]
	private void PickUpCookedGearItem(bool addToInventory)
	{
	}

	[Token(Token = "0x60021AC")]
	[Address(RVA = "0x81ABA0", Offset = "0x8199A0", Length = "0x5E1")]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[Token(Token = "0x60021AD")]
	[Address(RVA = "0x81B190", Offset = "0x819F90", Length = "0x244")]
	public static float GetCookedHp(float currentHp, GearItemData rawItemData, GearItemData cookedItemData)
	{
		return 0f;
	}

	[Token(Token = "0x60021AE")]
	[Address(RVA = "0x81B3E0", Offset = "0x81A1E0", Length = "0x6FC")]
	private void FindGearItemBeingCooked(string guid)
	{
	}

	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x81BAE0", Offset = "0x81A8E0", Length = "0x84")]
	private void UpdateGearItemBeingCooked()
	{
	}

	[Token(Token = "0x60021B0")]
	[Address(RVA = "0x81BB70", Offset = "0x81A970", Length = "0x6E")]
	private float ModifiedCookTimeMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x60021B1")]
	[Address(RVA = "0x81BBE0", Offset = "0x81A9E0", Length = "0x5F")]
	private float ModifiedReadyTimeMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x60021B2")]
	[Address(RVA = "0x81BC40", Offset = "0x81AA40", Length = "0x121")]
	private void UpdateMeltingSnow()
	{
	}

	[Token(Token = "0x60021B3")]
	[Address(RVA = "0x81BD70", Offset = "0x81AB70", Length = "0x206")]
	private void UpdateBoilingWater()
	{
	}

	[Token(Token = "0x60021B4")]
	[Address(RVA = "0x81BF80", Offset = "0x81AD80", Length = "0x6C0")]
	private void UpdateCookingTimeAndState(float cookTimeMinutes, float readyTimeMinutes)
	{
	}

	[Token(Token = "0x60021B5")]
	[Address(RVA = "0x81C650", Offset = "0x81B450", Length = "0x354")]
	private void UpdateVisuals()
	{
	}

	[Token(Token = "0x60021B6")]
	[Address(RVA = "0x81C9B0", Offset = "0x81B7B0", Length = "0x33D")]
	private void PickUpSnow()
	{
	}

	[Token(Token = "0x60021B7")]
	[Address(RVA = "0x81CCF0", Offset = "0x81BAF0", Length = "0x479")]
	private void PickUpWater()
	{
	}

	[Token(Token = "0x60021B8")]
	[Address(RVA = "0x81D170", Offset = "0x81BF70", Length = "0x91")]
	private void HideItemBeingCooked()
	{
	}

	[Token(Token = "0x60021B9")]
	[Address(RVA = "0x81D210", Offset = "0x81C010", Length = "0x916")]
	private void SetUpGrubMesh()
	{
	}

	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x81DB30", Offset = "0x81C930", Length = "0x289")]
	private void SetUpWaterMesh()
	{
	}

	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x81DDC0", Offset = "0x81CBC0", Length = "0x4BD")]
	private void SetCookingState(CookingState cookingState)
	{
	}

	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x81E280", Offset = "0x81D080", Length = "0x1A6")]
	private void UpdateParticles()
	{
	}

	[Token(Token = "0x60021BD")]
	[Address(RVA = "0x81E430", Offset = "0x81D230", Length = "0x83B")]
	private void TurnOnParticles(GameObject particlesToTurnOn)
	{
	}

	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x81EC70", Offset = "0x81DA70", Length = "0x1F7")]
	private void TurnOffParticles()
	{
	}

	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x81EE70", Offset = "0x81DC70", Length = "0x405")]
	private void UpdateGrubMeshVisualCondition()
	{
	}

	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x81F280", Offset = "0x81E080", Length = "0x1A0")]
	private void DoConditionDamageToPot()
	{
	}

	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x81F430", Offset = "0x81E230", Length = "0x699")]
	private void SetRuinedFoodMaterial()
	{
	}

	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x81FAD0", Offset = "0x81E8D0", Length = "0x327")]
	private void UpdateAudio()
	{
	}

	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x81FE00", Offset = "0x81EC00", Length = "0x411")]
	private void StartInspectMode()
	{
	}

	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x820220", Offset = "0x81F020", Length = "0xBC")]
	private void MaybeInterruptPassTime()
	{
	}

	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x8202E0", Offset = "0x81F0E0", Length = "0x1A3")]
	private void MaybeFlagItemAsOpened()
	{
	}

	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x820490", Offset = "0x81F290", Length = "0x294")]
	private void SetUpDummyPotMeatMesh()
	{
	}

	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x820730", Offset = "0x81F530", Length = "0x103")]
	private void CheckForFireBurntOut()
	{
	}

	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x820840", Offset = "0x81F640", Length = "0x332")]
	private bool BroadcastEventWithItemName(string eventName)
	{
		return false;
	}

	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x820B80", Offset = "0x81F980", Length = "0x1CF")]
	private bool IsItemBeingCookedHot()
	{
		return false;
	}

	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x820D50", Offset = "0x81FB50", Length = "0x19D")]
	private void ResetHeatLoss()
	{
	}

	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x820EF0", Offset = "0x81FCF0", Length = "0x82")]
	public CookingPotItem()
	{
	}
}
