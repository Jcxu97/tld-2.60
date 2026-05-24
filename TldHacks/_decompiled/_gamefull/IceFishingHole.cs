using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gameplay.Fishing;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200058E")]
public class IceFishingHole : MonoBehaviour
{
	[Token(Token = "0x4003314")]
	public const string CAUGHT_FISH_EVENT_NAME = "GearItem_CaughtFish";

	[Header("Placement")]
	[SerializeField]
	[Token(Token = "0x4003315")]
	[FieldOffset(Offset = "0x20")]
	private float m_PlacementOverlapRange;

	[Header("Fishing")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003316")]
	[FieldOffset(Offset = "0x24")]
	private float m_MinutesBeforeFreezingStartsAfterClearing;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003317")]
	[FieldOffset(Offset = "0x28")]
	private float m_FreezePercentPerGameHour;

	[SerializeField]
	[Token(Token = "0x4003318")]
	[FieldOffset(Offset = "0x2C")]
	private float m_MinGameMinutesCatchFish;

	[SerializeField]
	[Token(Token = "0x4003319")]
	[FieldOffset(Offset = "0x30")]
	private float m_MaxGameMinutesCatchFish;

	[SerializeField]
	[Token(Token = "0x400331A")]
	[FieldOffset(Offset = "0x34")]
	private float m_EmptyTipupTimeMultiplier;

	[SerializeField]
	[Token(Token = "0x400331B")]
	[FieldOffset(Offset = "0x38")]
	private FishLootTableData m_LootTable;

	[SerializeField]
	[Token(Token = "0x400331C")]
	[FieldOffset(Offset = "0x40")]
	private float m_PlacedTipupHourlyDecay;

	[SerializeField]
	[Token(Token = "0x400331D")]
	[FieldOffset(Offset = "0x44")]
	private float m_TipupLineSnapDecay;

	[Header("Overfishing")]
	[SerializeField]
	[Token(Token = "0x400331E")]
	[FieldOffset(Offset = "0x48")]
	private float m_OverfishingRange;

	[SerializeField]
	[Token(Token = "0x400331F")]
	[FieldOffset(Offset = "0x4C")]
	private int m_OverfishingLimit;

	[SerializeField]
	[Token(Token = "0x4003320")]
	[FieldOffset(Offset = "0x50")]
	private float m_OverfishingTimeMultiplier;

	[Header("Visuals")]
	[Token(Token = "0x4003321")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 m_PlacementMeshOffset;

	[SerializeField]
	[Token(Token = "0x4003322")]
	[FieldOffset(Offset = "0x60")]
	private LocalizedString m_ClearedHoleText;

	[SerializeField]
	[Token(Token = "0x4003323")]
	[FieldOffset(Offset = "0x68")]
	private LocalizedString m_FrozenPercentPostFix;

	[SerializeField]
	[Token(Token = "0x4003324")]
	[FieldOffset(Offset = "0x70")]
	private LocalizedString m_NoFishingGearText;

	[SerializeField]
	[Token(Token = "0x4003325")]
	[FieldOffset(Offset = "0x78")]
	private LocalizedString m_FishingInProgressText;

	[SerializeField]
	[Token(Token = "0x4003326")]
	[FieldOffset(Offset = "0x80")]
	private LocalizedString m_FishingLineSnappedText;

	[SerializeField]
	[Token(Token = "0x4003327")]
	[FieldOffset(Offset = "0x88")]
	private LocalizedString m_TipupBrokeText;

	[SerializeField]
	[Token(Token = "0x4003328")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_PlacementGroup;

	[SerializeField]
	[Token(Token = "0x4003329")]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_IceHoleGroup;

	[SerializeField]
	[Token(Token = "0x400332A")]
	[FieldOffset(Offset = "0xA0")]
	private SnowImprintCustom m_IceHoleImprint;

	[Header("Tip Up Visuals")]
	[SerializeField]
	[Token(Token = "0x400332B")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_TipUp;

	[SerializeField]
	[Token(Token = "0x400332C")]
	[FieldOffset(Offset = "0xB0")]
	private Animator m_TipUpAnimator;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x400332D")]
	[FieldOffset(Offset = "0xB8")]
	private AK.Wwise.Event m_FishingProgressAudioEvent;

	[SerializeField]
	[Token(Token = "0x400332E")]
	[FieldOffset(Offset = "0xC0")]
	private AK.Wwise.Event m_CatchFishAudioEvent;

	[SerializeField]
	[Token(Token = "0x400332F")]
	[FieldOffset(Offset = "0xC8")]
	private AK.Wwise.Event m_FreeFishAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003330")]
	[FieldOffset(Offset = "0xD0")]
	private AK.Wwise.Event m_BreakThroughIceAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003331")]
	[FieldOffset(Offset = "0xD8")]
	private AK.Wwise.Event m_FishingLineSnapAudioEvent;

	[SerializeField]
	[Token(Token = "0x4003332")]
	[FieldOffset(Offset = "0xE0")]
	private AK.Wwise.Event m_TipupBreakAudioEvent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003333")]
	[FieldOffset(Offset = "0xE8")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4003334")]
	[FieldOffset(Offset = "0xF0")]
	private PanelReference<Panel_IceFishing> m_IceFishingPanel;

	[SerializeField]
	[Token(Token = "0x4003335")]
	[FieldOffset(Offset = "0xF8")]
	private PanelReference<Panel_IceFishingHoleClear> m_ClearHolePanel;

	[Token(Token = "0x4003336")]
	[FieldOffset(Offset = "0x100")]
	private FishingState m_State;

	[Token(Token = "0x400333A")]
	[FieldOffset(Offset = "0x118")]
	private bool m_IsUserPlaced;

	[HideInInspector]
	[Token(Token = "0x400333B")]
	[FieldOffset(Offset = "0x120")]
	public NavMeshObstacle m_NavmeshCut;

	[Token(Token = "0x400333D")]
	[FieldOffset(Offset = "0x12C")]
	private int m_FrozenPercent;

	[Token(Token = "0x400333E")]
	[FieldOffset(Offset = "0x130")]
	private float m_MinutesSinceLastClearing;

	[Token(Token = "0x400333F")]
	[FieldOffset(Offset = "0x138")]
	private readonly CatchParameters m_NextCatch;

	[Token(Token = "0x4003340")]
	[FieldOffset(Offset = "0x140")]
	private float m_CatchMaxTimeModifier;

	[Token(Token = "0x4003341")]
	[FieldOffset(Offset = "0x148")]
	private GearItem m_SelectedTackle;

	[Token(Token = "0x4003342")]
	[FieldOffset(Offset = "0x150")]
	private GearItem m_SelectedLure;

	[Token(Token = "0x4003343")]
	[FieldOffset(Offset = "0x158")]
	private GearItem m_SelectedBait;

	[Token(Token = "0x4003344")]
	[FieldOffset(Offset = "0x160")]
	private SerializedTackle m_SerializedBait;

	[Token(Token = "0x4003345")]
	[FieldOffset(Offset = "0x168")]
	private SerializedTackle m_SerializedLure;

	[Token(Token = "0x4003346")]
	[FieldOffset(Offset = "0x170")]
	private GearItem m_ActiveTipup;

	[Token(Token = "0x4003347")]
	private static readonly IceFishingHoleSaveData s_IceFishingHoleSaveData;

	[Token(Token = "0x4003348")]
	private static List<IceFishingHole> s_IceFishingHoles;

	[Token(Token = "0x4003349")]
	[FieldOffset(Offset = "0x178")]
	private int m_AnimParameter_TipUpCatch;

	[Token(Token = "0x400334A")]
	[FieldOffset(Offset = "0x17C")]
	private int m_AnimParameter_TipUpFreezeAmount;

	[Token(Token = "0x400334B")]
	private static readonly int s_FreezeAmountShaderID;

	[Token(Token = "0x170002C2")]
	public AK.Wwise.Event CatchFishAudioEvent
	{
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C3")]
	public AK.Wwise.Event FreeFishAudioEvent
	{
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x502670", Offset = "0x501470", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C4")]
	public bool IsFishingInProgress
	{
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x908940", Offset = "0x907740", Length = "0xB")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002C5")]
	[field: Token(Token = "0x4003337")]
	[field: FieldOffset(Offset = "0x104")]
	public bool HasCaughtFish
	{
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x908950", Offset = "0x907750", Length = "0x8")]
		get;
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x908960", Offset = "0x907760", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170002C6")]
	[field: Token(Token = "0x4003338")]
	[field: FieldOffset(Offset = "0x108")]
	public float NormalizedFrozen
	{
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x908970", Offset = "0x907770", Length = "0x9")]
		get;
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x908980", Offset = "0x907780", Length = "0x9")]
		private set;
	}

	[Token(Token = "0x170002C7")]
	[field: Token(Token = "0x4003339")]
	[field: FieldOffset(Offset = "0x110")]
	public AssetReference AssetReference
	{
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x677F90", Offset = "0x676D90", Length = "0x8")]
		get;
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x677FA0", Offset = "0x676DA0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x170002C8")]
	[field: Token(Token = "0x400333C")]
	[field: FieldOffset(Offset = "0x128")]
	public bool PauseFreezing
	{
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x908990", Offset = "0x907790", Length = "0x8")]
		get;
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x9089A0", Offset = "0x9077A0", Length = "0x7")]
		set;
	}

	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x9089B0", Offset = "0x9077B0", Length = "0x468")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002ABD")]
	[Address(RVA = "0x908E20", Offset = "0x907C20", Length = "0x83")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002ABE")]
	[Address(RVA = "0x908EB0", Offset = "0x907CB0", Length = "0xA")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002ABF")]
	[Address(RVA = "0x908EC0", Offset = "0x907CC0", Length = "0x221")]
	public void OnBuild()
	{
	}

	[Token(Token = "0x6002AC0")]
	[Address(RVA = "0x649380", Offset = "0x648180", Length = "0x52")]
	public void SetSelectedTackle(GearItem tackleGearItem)
	{
	}

	[Token(Token = "0x6002AC1")]
	[Address(RVA = "0x9090F0", Offset = "0x907EF0", Length = "0x4A0")]
	public void SetSelectedLure(GearItem lureGearItem)
	{
	}

	[Token(Token = "0x6002AC2")]
	[Address(RVA = "0x9095A0", Offset = "0x9083A0", Length = "0x23D")]
	public void SetSelectedBait(GearItem baitGearItem)
	{
	}

	[Token(Token = "0x6002AC3")]
	[Address(RVA = "0x9097E0", Offset = "0x9085E0", Length = "0x13C")]
	public void SetActiveTipup(GearItem tipupGearItem)
	{
	}

	[Token(Token = "0x6002AC4")]
	[Address(RVA = "0x909920", Offset = "0x908720", Length = "0x23E")]
	public void StartActiveFishing(float progressBarSeconds, float ingameMinutes)
	{
	}

	[Token(Token = "0x6002AC5")]
	[Address(RVA = "0x909B60", Offset = "0x908960", Length = "0xB")]
	public void OnActiveFishingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6002AC6")]
	[Address(RVA = "0x909B70", Offset = "0x908970", Length = "0x185")]
	public void StartFishing(FishingState fishingType)
	{
	}

	[Token(Token = "0x6002AC7")]
	[Address(RVA = "0x909D00", Offset = "0x908B00", Length = "0xF7")]
	public void MaybeEnableNavMeshCut(bool enable)
	{
	}

	[Token(Token = "0x6002AC8")]
	[Address(RVA = "0x909E00", Offset = "0x908C00", Length = "0x286")]
	private GearItem MaybeRemoveAndGrabGear(GearItem gearItem)
	{
		return null;
	}

	[Token(Token = "0x6002AC9")]
	[Address(RVA = "0x90A090", Offset = "0x908E90", Length = "0x823")]
	private void RollNextCatch()
	{
	}

	[Token(Token = "0x6002ACA")]
	[Address(RVA = "0x90A8C0", Offset = "0x9096C0", Length = "0x41")]
	private float GetOverfishingScale()
	{
		return 0f;
	}

	[Token(Token = "0x6002ACB")]
	[Address(RVA = "0x90A910", Offset = "0x909710", Length = "0x32C")]
	private int CountNearbyActiveFishingHoles()
	{
		return 0;
	}

	[Token(Token = "0x6002ACC")]
	[Address(RVA = "0x90AC40", Offset = "0x909A40", Length = "0x212")]
	private void Update()
	{
	}

	[Token(Token = "0x6002ACD")]
	[Address(RVA = "0x90AE60", Offset = "0x909C60", Length = "0x67")]
	private void UpdateFrozenState(float timePassedInMinutes)
	{
	}

	[Token(Token = "0x6002ACE")]
	[Address(RVA = "0x90AED0", Offset = "0x909CD0", Length = "0x551")]
	private void UpdateFishing(float timePassedInMinutes)
	{
	}

	[Token(Token = "0x6002ACF")]
	[Address(RVA = "0x90B430", Offset = "0x90A230", Length = "0x77")]
	private void UpdatePlayerPlacedHoleFreezingOver()
	{
	}

	[Token(Token = "0x6002AD0")]
	[Address(RVA = "0x90B4B0", Offset = "0x90A2B0", Length = "0x2E")]
	private void SetTipupAnimationTrigger(bool triggered)
	{
	}

	[Token(Token = "0x6002AD1")]
	[Address(RVA = "0x90B4E0", Offset = "0x90A2E0", Length = "0xDF")]
	private void MaybeExitFishing()
	{
	}

	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x90B5C0", Offset = "0x90A3C0", Length = "0x7DA")]
	private void CollectFish()
	{
	}

	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x90BDA0", Offset = "0x90ABA0", Length = "0x237")]
	private void MaybeDestroyTipup()
	{
	}

	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0x90BFE0", Offset = "0x90ADE0", Length = "0x5EC")]
	private void ConsumeBait()
	{
	}

	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0x90C5D0", Offset = "0x90B3D0", Length = "0xC8")]
	private void DestroyLure()
	{
	}

	[Token(Token = "0x6002AD6")]
	[Address(RVA = "0x90C6A0", Offset = "0x90B4A0", Length = "0x33A")]
	private GearItem InstantiateFish(AssetReference fishReference)
	{
		return null;
	}

	[Token(Token = "0x6002AD7")]
	[Address(RVA = "0x90C9E0", Offset = "0x90B7E0", Length = "0x26E")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002AD8")]
	[Address(RVA = "0x90CC50", Offset = "0x90BA50", Length = "0x1F3")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002AD9")]
	[Address(RVA = "0x90CE50", Offset = "0x90BC50", Length = "0x4D")]
	public void SetToPlacementMode(bool enabled)
	{
	}

	[Token(Token = "0x6002ADA")]
	[Address(RVA = "0x90CEA0", Offset = "0x90BCA0", Length = "0x10D")]
	public void SetNormalizedFrozen(float normalized)
	{
	}

	[Token(Token = "0x6002ADB")]
	[Address(RVA = "0x90CFB0", Offset = "0x90BDB0", Length = "0x87")]
	public void ClearHole()
	{
	}

	[Token(Token = "0x6002ADC")]
	[Address(RVA = "0x90D040", Offset = "0x90BE40", Length = "0x2DC")]
	public void CancelFishing(bool userCancelled)
	{
	}

	[Token(Token = "0x6002ADD")]
	[Address(RVA = "0x90D320", Offset = "0x90C120", Length = "0x228")]
	private void PickupTackle(GearItem selectedTackle, SerializedTackle serializedTackle)
	{
	}

	[Token(Token = "0x6002ADE")]
	[Address(RVA = "0x90D550", Offset = "0x90C350", Length = "0xE04")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002ADF")]
	[Address(RVA = "0x90E360", Offset = "0x90D160", Length = "0x31A")]
	public void Deserialize(IceFishingHoleSaveData saveData)
	{
	}

	[Token(Token = "0x6002AE0")]
	[Address(RVA = "0x90E680", Offset = "0x90D480", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0x90E720", Offset = "0x90D520", Length = "0xE4")]
	private void UpdatingFreezingMaterialProperties(MaterialPropertyBlock propertyBlock)
	{
	}

	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0x90E810", Offset = "0x90D610", Length = "0x3A0")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0x90EBC0", Offset = "0x90D9C0", Length = "0x2B2")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x90EE80", Offset = "0x90DC80", Length = "0x249")]
	private static IceFishingHole CreateIceFishingHole(AssetReference assetReference, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6002AE5")]
	[Address(RVA = "0x90F0D0", Offset = "0x90DED0", Length = "0x33E")]
	private static IceFishingHole FindIceFishingHoleByPosition(IceFishingHoleSaveData proxy)
	{
		return null;
	}

	[Token(Token = "0x6002AE6")]
	[Address(RVA = "0x90F410", Offset = "0x90E210", Length = "0x26A")]
	public static bool IsUnderPosition(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x6002AE7")]
	[Address(RVA = "0x90F680", Offset = "0x90E480", Length = "0x15E")]
	private bool IsPositionUnder(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x90F7E0", Offset = "0x90E5E0", Length = "0x117")]
	private static IceFishingHole FindIceFishingHoleByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x90F900", Offset = "0x90E700", Length = "0xE4")]
	public IceFishingHole()
	{
	}
}
