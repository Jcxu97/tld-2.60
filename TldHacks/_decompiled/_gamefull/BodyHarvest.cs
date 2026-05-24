using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200054A")]
public class BodyHarvest : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200054B")]
	public class BodyHarvestTimelineData
	{
		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0x10")]
		public BaseAi.DamageSide m_DamageSide;

		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_FPAnchor;

		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x20")]
		public Transform m_CameraStartPosition;

		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0x28")]
		public BodyHarvestTimelineSet m_TimelineSet;

		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x8CFCD0", Offset = "0x8CEAD0", Length = "0x16")]
		public bool IsValidDamageSide(BaseAi.DamageSide damageSide)
		{
			return false;
		}

		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x8CFCF0", Offset = "0x8CEAF0", Length = "0x8")]
		public BodyHarvestTimelineData()
		{
		}
	}

	[Token(Token = "0x200054C")]
	private struct FastForwardState
	{
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x0")]
		public float m_PercentFrozen;

		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0x4")]
		public float m_HoursRemaining;

		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0x8")]
		public float m_HoursRemainingNextToFire;

		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0xC")]
		public float m_PercentDecay;
	}

	[Token(Token = "0x200054D")]
	private struct FrozenDecayCalculator
	{
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0x0")]
		private readonly float m_ThawedDecayRate;

		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0x4")]
		private readonly float m_FrozenDecayRate;

		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0x8")]
		private readonly float m_HoursToThaw;

		[Token(Token = "0x4003121")]
		[FieldOffset(Offset = "0xC")]
		private readonly float m_HoursToFreeze;

		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x8CFD00", Offset = "0x8CEB00", Length = "0x1A")]
		public FrozenDecayCalculator(float thawedConditionLossPerHour, float frozenConditionLossPerHour, float hoursToThawCarcass, float hoursToFreezeCarcass)
		{
			m_ThawedDecayRate = 0f;
			m_FrozenDecayRate = 0f;
			m_HoursToThaw = 0f;
			m_HoursToFreeze = 0f;
		}

		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x8CFD20", Offset = "0x8CEB20", Length = "0x209")]
		public FastForwardState FastForwardTime(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x8CFF30", Offset = "0x8CED30", Length = "0xDA")]
		private FastForwardState HandleThawingNextToFire(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x8D0010", Offset = "0x8CEE10", Length = "0x84")]
		private FastForwardState HandleFullyThawedNextToFire(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x8D00A0", Offset = "0x8CEEA0", Length = "0x165")]
		private FastForwardState HandleFreezeOrThawChanges(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[Token(Token = "0x60028B7")]
		[Address(RVA = "0x8D0210", Offset = "0x8CF010", Length = "0x55")]
		private FastForwardState HandleSteadyStateAfterFreezeOrThaw(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x8D0270", Offset = "0x8CF070", Length = "0x95")]
		private float IntegrateDecay(float hoursInLinearSection, float startPercentFrozen, float endPercentFrozen)
		{
			return 0f;
		}

		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x8D0310", Offset = "0x8CF110", Length = "0x46")]
		private float GetDecayRate(float percentFrozen)
		{
			return 0f;
		}
	}

	[Token(Token = "0x40030CB")]
	private const float MINDIST_UPDATE_DESTROY = 200f;

	[Token(Token = "0x40030CC")]
	private const float MINDIST_LOAD_ONSCREEN_DESTROY = 70f;

	[Token(Token = "0x40030CD")]
	private const float MINDIST_LOAD_OFFSCREEN_DESTROY = 30f;

	[Token(Token = "0x40030CE")]
	private const string SPAWNED_MODEL_PARENT = "SpawnedBodyHarvestModels";

	[Token(Token = "0x40030CF")]
	private static readonly ItemWeight s_RoundToZeroThreshold;

	[Token(Token = "0x40030D0")]
	private static readonly LocalizedString s_DefaultMeatLabel;

	[Token(Token = "0x40030D1")]
	private static readonly LocalizedString s_DefaultHideLabel;

	[Token(Token = "0x40030D2")]
	private static readonly LocalizedString s_DefaultGutLabel;

	[SerializeField]
	[Token(Token = "0x40030D3")]
	[FieldOffset(Offset = "0x20")]
	private BodyHarvestModel m_BodyHarvestModel;

	[Token(Token = "0x40030D4")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x40030D5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_MeatPrefab;

	[SerializeField]
	[Token(Token = "0x40030D6")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_MeatLabelOverride;

	[Token(Token = "0x40030D7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_HidePrefab;

	[SerializeField]
	[Token(Token = "0x40030D8")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_HideLabelOverride;

	[Token(Token = "0x40030D9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_GutPrefab;

	[SerializeField]
	[Token(Token = "0x40030DA")]
	[FieldOffset(Offset = "0x58")]
	private LocalizedString m_GutLabelOverride;

	[Token(Token = "0x40030DB")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_FatPrefab;

	[Token(Token = "0x40030DC")]
	[FieldOffset(Offset = "0x68")]
	public string m_HarvestAudio;

	[SerializeField]
	[Token(Token = "0x40030DD")]
	[FieldOffset(Offset = "0x70")]
	private ItemWeight m_MeatAvailableMin;

	[SerializeField]
	[Token(Token = "0x40030DE")]
	[FieldOffset(Offset = "0x78")]
	private ItemWeight m_MeatAvailableMax;

	[Token(Token = "0x40030DF")]
	[FieldOffset(Offset = "0x80")]
	public int m_HideAvailableUnits;

	[Token(Token = "0x40030E0")]
	[FieldOffset(Offset = "0x84")]
	public int m_GutAvailableUnits;

	[Token(Token = "0x40030E1")]
	[FieldOffset(Offset = "0x88")]
	public float m_FatToMeatRatio;

	[Token(Token = "0x40030E2")]
	[FieldOffset(Offset = "0x90")]
	public List<AssetReferenceGearItem> m_BonusItemsOnHarvestHide;

	[HideInInspector]
	[Token(Token = "0x40030E3")]
	[FieldOffset(Offset = "0x98")]
	public bool m_HaveBonusItemsBeenHarvested;

	[Range(0f, 100f)]
	[Token(Token = "0x40030E4")]
	[FieldOffset(Offset = "0x9C")]
	public float m_SpawnChance;

	[Range(0f, 100f)]
	[Token(Token = "0x40030E5")]
	[FieldOffset(Offset = "0xA0")]
	public float m_StartConditionMin;

	[Range(0f, 100f)]
	[Token(Token = "0x40030E6")]
	[FieldOffset(Offset = "0xA4")]
	public float m_StartConditionMax;

	[Token(Token = "0x40030E7")]
	[FieldOffset(Offset = "0xA8")]
	public float m_DecayConditionPerHour;

	[Token(Token = "0x40030E8")]
	[FieldOffset(Offset = "0xAC")]
	public bool m_StartFrozen;

	[Token(Token = "0x40030E9")]
	[FieldOffset(Offset = "0xAD")]
	public bool m_StartRavaged;

	[Token(Token = "0x40030EA")]
	[FieldOffset(Offset = "0xAE")]
	public bool m_StartHarvested;

	[Token(Token = "0x40030EB")]
	[FieldOffset(Offset = "0xAF")]
	public bool m_HideIsAvailable;

	[Token(Token = "0x40030EC")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_GutIsAvailable;

	[Header("Quartering")]
	[Token(Token = "0x40030ED")]
	[FieldOffset(Offset = "0xB1")]
	public bool m_CanQuarter;

	[Token(Token = "0x40030EE")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_QuarterObjectPrefab;

	[Token(Token = "0x40030EF")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_CarcassSitePrefab;

	[SerializeField]
	[Token(Token = "0x40030F0")]
	[FieldOffset(Offset = "0xC8")]
	private Transform m_CarcassSiteLocationLeft;

	[SerializeField]
	[Token(Token = "0x40030F1")]
	[FieldOffset(Offset = "0xD0")]
	private Transform m_CarcassSiteLocationRight;

	[Token(Token = "0x40030F2")]
	[FieldOffset(Offset = "0xD8")]
	public string m_QuarterAudio;

	[Token(Token = "0x40030F3")]
	[FieldOffset(Offset = "0xE0")]
	public float m_QuarterDurationMinutes;

	[Token(Token = "0x40030F4")]
	[FieldOffset(Offset = "0xE8")]
	public ItemWeight m_QuarterBagMeatCapacity;

	[Token(Token = "0x40030F5")]
	[FieldOffset(Offset = "0xF0")]
	public float m_QuarterBagWasteMultiplier;

	[Header("Quartering Layout")]
	[Token(Token = "0x40030F6")]
	[FieldOffset(Offset = "0xF4")]
	public float m_QuarterPrefabSpawnRadius;

	[Header("Collisions")]
	[Tooltip("On activation, a 10% smaller clone of colliders will be generated (non interactive).")]
	[Token(Token = "0x40030F7")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_LargeObjectCollidersRoot;

	[Header("Harvest Timeline")]
	[SerializeField]
	[Token(Token = "0x40030F8")]
	[FieldOffset(Offset = "0x100")]
	private List<DirectionalInfluenceMapping<BodyHarvestTimelineData>> m_TimelineSets;

	[SerializeField]
	[Token(Token = "0x40030F9")]
	[FieldOffset(Offset = "0x108")]
	private BodyHarvestModel m_TimelineHarvestModelPrefab;

	[SerializeField]
	[Token(Token = "0x40030FA")]
	[FieldOffset(Offset = "0x110")]
	private bool m_SpawnTimelineHarvestModelInHand;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40030FB")]
	[FieldOffset(Offset = "0x118")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvestPanel;

	[HideInInspector]
	[Token(Token = "0x40030FC")]
	[FieldOffset(Offset = "0x120")]
	public bool m_Frozen;

	[HideInInspector]
	[Token(Token = "0x40030FD")]
	[FieldOffset(Offset = "0x121")]
	public bool m_Ravaged;

	[HideInInspector]
	[Token(Token = "0x40030FE")]
	[FieldOffset(Offset = "0x128")]
	public ItemWeight m_MeatAvailableKG;

	[HideInInspector]
	[Token(Token = "0x40030FF")]
	[FieldOffset(Offset = "0x130")]
	public bool m_DestroyPending;

	[HideInInspector]
	[Token(Token = "0x4003100")]
	[FieldOffset(Offset = "0x138")]
	public string m_MissionIdSerialized;

	[HideInInspector]
	[Token(Token = "0x4003101")]
	[FieldOffset(Offset = "0x140")]
	public BearHuntAiRedux m_BearHuntAiRedux;

	[Token(Token = "0x4003102")]
	[FieldOffset(Offset = "0x148")]
	private float m_Condition;

	[Token(Token = "0x4003103")]
	[FieldOffset(Offset = "0x14C")]
	private bool m_RolledSpawnChance;

	[Token(Token = "0x4003104")]
	[FieldOffset(Offset = "0x14D")]
	private bool m_AllowDecay;

	[Token(Token = "0x4003105")]
	[FieldOffset(Offset = "0x14E")]
	private bool m_AllowFreezing;

	[Token(Token = "0x4003106")]
	[FieldOffset(Offset = "0x150")]
	private float m_PercentFrozen;

	[Token(Token = "0x4003107")]
	[FieldOffset(Offset = "0x158")]
	private GearItem m_GearItem;

	[Token(Token = "0x4003108")]
	private static BodyHarvestSaveDataProxy m_BodyHarvestSaveDataProxy;

	[Token(Token = "0x4003109")]
	[FieldOffset(Offset = "0x160")]
	private string m_FrozenDisplayNameId;

	[Token(Token = "0x400310A")]
	[FieldOffset(Offset = "0x168")]
	private CarcassSite m_CarcassSite;

	[Token(Token = "0x400310B")]
	[FieldOffset(Offset = "0x170")]
	private bool m_HasHarvested;

	[Token(Token = "0x400310C")]
	[FieldOffset(Offset = "0x174")]
	private float m_LastHarvestTimeHours;

	[Token(Token = "0x400310D")]
	[FieldOffset(Offset = "0x178")]
	private ItemWeight m_GutWeightKgPerUnit;

	[Token(Token = "0x400310E")]
	[FieldOffset(Offset = "0x180")]
	private ItemWeight m_HideWeightKgPerUnit;

	[Token(Token = "0x400310F")]
	[FieldOffset(Offset = "0x188")]
	private bool m_HasUpdatedColliders;

	[Token(Token = "0x4003110")]
	[FieldOffset(Offset = "0x190")]
	private GameObject m_NonInteractiveCollidersRoot;

	[Token(Token = "0x4003111")]
	[FieldOffset(Offset = "0x198")]
	private bool m_HasInitialized;

	[Token(Token = "0x4003112")]
	private static readonly Dictionary<GameObject, BodyHarvestModel> s_SpawnedBodyHarvestModelMap;

	[Token(Token = "0x4003113")]
	private static Transform s_SpawnedBodyHarvestModelParent;

	[Token(Token = "0x4003114")]
	[FieldOffset(Offset = "0x199")]
	private bool m_BodyHarvestModelWasActive;

	[Token(Token = "0x4003115")]
	[FieldOffset(Offset = "0x1A0")]
	private BodyHarvestModel m_SpawnedBodyHarvestModel;

	[Token(Token = "0x1700029A")]
	public LocalizedString MeatLabel
	{
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x8C8150", Offset = "0x8C6F50", Length = "0x77")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029B")]
	public LocalizedString HideLabel
	{
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x8C81D0", Offset = "0x8C6FD0", Length = "0x77")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029C")]
	public LocalizedString GutLabel
	{
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x8C8250", Offset = "0x8C7050", Length = "0x77")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029D")]
	public bool SpawnTimelineHarvestModelInHand
	{
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x55BD20", Offset = "0x55AB20", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600287D")]
	[Address(RVA = "0x8C82D0", Offset = "0x8C70D0", Length = "0x21A")]
	private void Awake()
	{
	}

	[Token(Token = "0x600287E")]
	[Address(RVA = "0x8C84F0", Offset = "0x8C72F0", Length = "0x24C")]
	public void UpdateBodyHarvest(float todHours)
	{
	}

	[Token(Token = "0x600287F")]
	[Address(RVA = "0x8C8740", Offset = "0x8C7540", Length = "0x183")]
	private void Update()
	{
	}

	[Token(Token = "0x6002880")]
	[Address(RVA = "0x8C88D0", Offset = "0x8C76D0", Length = "0x7")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6002881")]
	[Address(RVA = "0x8C88E0", Offset = "0x8C76E0", Length = "0x8")]
	public void OnHarvestActionSuccess()
	{
	}

	[Token(Token = "0x6002882")]
	[Address(RVA = "0x8C88F0", Offset = "0x8C76F0", Length = "0xBD5")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002883")]
	[Address(RVA = "0x8C94D0", Offset = "0x8C82D0", Length = "0x6DE")]
	public void Deserialize(string text, bool isSceneLoad)
	{
	}

	[Token(Token = "0x6002884")]
	[Address(RVA = "0x8C9BB0", Offset = "0x8C89B0", Length = "0x20C")]
	private void FastForwardTime(float elapsedHours, float percentFrozen, float hoursRemainingOnCloseFire)
	{
	}

	[Token(Token = "0x6002885")]
	[Address(RVA = "0x8C9DC0", Offset = "0x8C8BC0", Length = "0x74")]
	public bool IsTooFrozenToHarvestWithBareHands()
	{
		return false;
	}

	[Token(Token = "0x6002886")]
	[Address(RVA = "0x8C9E40", Offset = "0x8C8C40", Length = "0xA5")]
	public bool CanHarvestWithBareHands()
	{
		return false;
	}

	[Token(Token = "0x6002887")]
	[Address(RVA = "0x8C9EF0", Offset = "0x8C8CF0", Length = "0x17")]
	public bool IsAFreshBody()
	{
		return false;
	}

	[Token(Token = "0x6002888")]
	[Address(RVA = "0x8C9F10", Offset = "0x8C8D10", Length = "0xCD")]
	public bool IsGearItem()
	{
		return false;
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0x8C9FE0", Offset = "0x8C8DE0", Length = "0x9")]
	public float GetCondition()
	{
		return 0f;
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0x8C9FF0", Offset = "0x8C8DF0", Length = "0x11D")]
	public float GetGearItemCondition()
	{
		return 0f;
	}

	[Token(Token = "0x600288B")]
	[Address(RVA = "0x8CA110", Offset = "0x8C8F10", Length = "0xD")]
	public void SetAllowDecay(bool allow)
	{
	}

	[Token(Token = "0x600288C")]
	[Address(RVA = "0x8CA120", Offset = "0x8C8F20", Length = "0xD")]
	public int GetPercentFrozen()
	{
		return 0;
	}

	[Token(Token = "0x600288D")]
	[Address(RVA = "0x8CA130", Offset = "0x8C8F30", Length = "0x98")]
	public void InteractWithBodyHarvest(bool playBookEndAnimation)
	{
	}

	[Token(Token = "0x600288E")]
	[Address(RVA = "0x8CA1D0", Offset = "0x8C8FD0", Length = "0x55")]
	public string GetFrozenDisplayName()
	{
		return null;
	}

	[Token(Token = "0x600288F")]
	[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x6002890")]
	[Address(RVA = "0x8CA230", Offset = "0x8C9030", Length = "0x19F")]
	public void SetCarcassMeshEnabled(bool carcassMeshEnabled)
	{
	}

	[Token(Token = "0x6002891")]
	[Address(RVA = "0x8CA3D0", Offset = "0x8C91D0", Length = "0x563")]
	public bool TryGetBodyHarvestTimelineData(Vector3 playerPosition, out BodyHarvestTimelineData data)
	{
		data = null;
		return false;
	}

	[Token(Token = "0x6002892")]
	[Address(RVA = "0x8CA940", Offset = "0x8C9740", Length = "0x852")]
	public GameObject GetHarvestTimelineModel()
	{
		return null;
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0x8CB1A0", Offset = "0x8C9FA0", Length = "0x20B")]
	public void CleanupHarvestTimelineModel()
	{
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0x8CB3B0", Offset = "0x8CA1B0", Length = "0xEB")]
	public static void ResetSpawnedModelList()
	{
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0x8CB4A0", Offset = "0x8CA2A0", Length = "0x5BA")]
	public void BodyHarvestDestroy()
	{
	}

	[Token(Token = "0x6002896")]
	[Address(RVA = "0x8CBA60", Offset = "0x8CA860", Length = "0xD1")]
	public void MaybeRoundMeatAvailableToZero()
	{
	}

	[Token(Token = "0x6002897")]
	[Address(RVA = "0x8CBB40", Offset = "0x8CA940", Length = "0x1C7")]
	public bool NoMoreResources()
	{
		return false;
	}

	[Token(Token = "0x6002898")]
	[Address(RVA = "0x8CBD10", Offset = "0x8CAB10", Length = "0x63")]
	public ItemWeight GetGutsAvailableWeightKg()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6002899")]
	[Address(RVA = "0x8CBD80", Offset = "0x8CAB80", Length = "0x63")]
	public ItemWeight GetHideAvailableWeightKg()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600289A")]
	[Address(RVA = "0x8CBDF0", Offset = "0x8CABF0", Length = "0x6C")]
	public bool ConditionReachedZero()
	{
		return false;
	}

	[Token(Token = "0x600289B")]
	[Address(RVA = "0x8CBE60", Offset = "0x8CAC60", Length = "0xCE")]
	public bool CanSpawnCarcassSite()
	{
		return false;
	}

	[Token(Token = "0x600289C")]
	[Address(RVA = "0x8CBF30", Offset = "0x8CAD30", Length = "0x32")]
	public bool AreResourcesAvailable()
	{
		return false;
	}

	[Token(Token = "0x600289D")]
	[Address(RVA = "0x8CBF70", Offset = "0x8CAD70", Length = "0x1CC")]
	public void MaybeSpawnOrRefreshCarcassSite()
	{
	}

	[Token(Token = "0x600289E")]
	[Address(RVA = "0x8CC140", Offset = "0x8CAF40", Length = "0x10")]
	public void MaybeRestoreCarcassSite()
	{
	}

	[Token(Token = "0x600289F")]
	[Address(RVA = "0x8CC150", Offset = "0x8CAF50", Length = "0x5C6")]
	public void MaybeSpawnCarcassSite(float timeHours)
	{
	}

	[Token(Token = "0x60028A0")]
	[Address(RVA = "0x8CC720", Offset = "0x8CB520", Length = "0xCD")]
	public bool HasSpawnedCarcassSite()
	{
		return false;
	}

	[Token(Token = "0x60028A1")]
	[Address(RVA = "0x8CC7F0", Offset = "0x8CB5F0", Length = "0x3D4")]
	public static void Copy(BodyHarvest from, BodyHarvest to)
	{
	}

	[Token(Token = "0x60028A2")]
	[Address(RVA = "0x8CCBD0", Offset = "0x8CB9D0", Length = "0x41F")]
	private void RefreshInternalReferences()
	{
	}

	[Token(Token = "0x60028A3")]
	[Address(RVA = "0x8CCFF0", Offset = "0x8CBDF0", Length = "0x14F")]
	private bool IsNearFire()
	{
		return false;
	}

	[Token(Token = "0x60028A4")]
	[Address(RVA = "0x8CD140", Offset = "0x8CBF40", Length = "0x12F")]
	private void DestroyIfFarAway()
	{
	}

	[Token(Token = "0x60028A5")]
	[Address(RVA = "0x8CD270", Offset = "0x8CC070", Length = "0x88E")]
	private void MaybeDestroyAfterDeserialize(bool useTeleportTransformAfterSceneLoad)
	{
	}

	[Token(Token = "0x60028A6")]
	[Address(RVA = "0x8CDB00", Offset = "0x8CC900", Length = "0xFE")]
	private void MaybeDecay(float hours)
	{
	}

	[Token(Token = "0x60028A7")]
	[Address(RVA = "0x8CDC00", Offset = "0x8CCA00", Length = "0x21E")]
	private void MaybeFreeze(float hours)
	{
	}

	[Token(Token = "0x60028A8")]
	[Address(RVA = "0x8CDE20", Offset = "0x8CCC20", Length = "0x19C")]
	private void UpdateFrozenShader()
	{
	}

	[Token(Token = "0x60028A9")]
	[Address(RVA = "0x8CDFC0", Offset = "0x8CCDC0", Length = "0x19D")]
	private void InitializeResourcesAndConditions()
	{
	}

	[Token(Token = "0x60028AA")]
	[Address(RVA = "0x8CE160", Offset = "0x8CCF60", Length = "0xFE")]
	private void RefreshCarcassSite(float hoursAtRefresh)
	{
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x8CE260", Offset = "0x8CD060", Length = "0x3FA")]
	private void UnparentArrows(List<ArrowItem> arrows, List<Transform> parentArrows)
	{
	}

	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x8CE660", Offset = "0x8CD460", Length = "0x272")]
	private void ReparentArrows(List<ArrowItem> arrows, List<Transform> parentArrows)
	{
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x8CE8E0", Offset = "0x8CD6E0", Length = "0xE28")]
	private void UpdateColliders()
	{
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x8CF710", Offset = "0x8CE510", Length = "0x107")]
	public BodyHarvest()
	{
	}
}
