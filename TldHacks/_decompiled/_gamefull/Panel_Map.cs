using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Scenes;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200069A")]
public class Panel_Map : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
{
	[Flags]
	[Token(Token = "0x200069B")]
	private enum ResetOpts
	{
		[Token(Token = "0x4004559")]
		None = 0,
		[Token(Token = "0x400455A")]
		Zoomed = 1,
		[Token(Token = "0x400455B")]
		CenterOnPlayer = 2,
		[Token(Token = "0x400455C")]
		ShowPlayer = 4
	}

	[Token(Token = "0x200069C")]
	private enum HoverState
	{
		[Token(Token = "0x400455E")]
		None,
		[Token(Token = "0x400455F")]
		BigSprite,
		[Token(Token = "0x4004560")]
		SmallSprite,
		[Token(Token = "0x4004561")]
		Area
	}

	[Flags]
	[Token(Token = "0x200069D")]
	private enum IconDisplayFilters : short
	{
		[Token(Token = "0x4004563")]
		None = 0,
		[Token(Token = "0x4004564")]
		Resources = 1,
		[Token(Token = "0x4004565")]
		Structures = 2,
		[Token(Token = "0x4004566")]
		Corpses = 4,
		[Token(Token = "0x4004567")]
		RockCaches = 8,
		[Token(Token = "0x4004568")]
		SprayMarkers = 0x10,
		[Token(Token = "0x4004569")]
		All = 0x1F
	}

	[Token(Token = "0x40044C0")]
	public const float MAP_RADIUS = 300f;

	[Token(Token = "0x40044C1")]
	private const int OBJECT_POOL_SIZE = 100;

	[Token(Token = "0x40044C2")]
	private const int DETAIL_POOL_SIZE = 700;

	[Token(Token = "0x40044C3")]
	private const int AREA_POOL_SIZE = 10;

	[Token(Token = "0x40044C4")]
	private const float FOGOFWAR_RADIUS_MULTIPLIER = 3f;

	[Token(Token = "0x40044C5")]
	public static bool s_ForceShowPlayerIcon;

	[Header("Object References")]
	[Token(Token = "0x40044C6")]
	[FieldOffset(Offset = "0x30")]
	public MiniTopNav m_MiniTopNav;

	[Token(Token = "0x40044C7")]
	[FieldOffset(Offset = "0x38")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40044C8")]
	[FieldOffset(Offset = "0x40")]
	public GenericButtonMouseSpawner m_WorldMapButtonObj;

	[Token(Token = "0x40044C9")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_HeaderLabel;

	[Token(Token = "0x40044CA")]
	[FieldOffset(Offset = "0x50")]
	public Transform m_MapElementsTransform;

	[Token(Token = "0x40044CB")]
	[FieldOffset(Offset = "0x58")]
	public MapCrosshair m_Crosshair;

	[Token(Token = "0x40044CC")]
	[FieldOffset(Offset = "0x60")]
	public Transform m_PlayerIcon;

	[Token(Token = "0x40044CD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_BigSpritePrefab;

	[Token(Token = "0x40044CE")]
	[FieldOffset(Offset = "0x70")]
	public Transform m_BigSpritePoolParent;

	[Token(Token = "0x40044CF")]
	[FieldOffset(Offset = "0x78")]
	public Transform m_BigSpriteActiveObjects;

	[Token(Token = "0x40044D0")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_SmallSpritePrefab;

	[Token(Token = "0x40044D1")]
	[FieldOffset(Offset = "0x88")]
	public Transform m_SmallSpritePoolParent;

	[Token(Token = "0x40044D2")]
	[FieldOffset(Offset = "0x90")]
	public Transform m_SmallSpriteActiveObjects;

	[Token(Token = "0x40044D3")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_DetailEntryPrefab;

	[Token(Token = "0x40044D4")]
	[FieldOffset(Offset = "0xA0")]
	public Transform m_DetailEntryPoolParent;

	[Token(Token = "0x40044D5")]
	[FieldOffset(Offset = "0xA8")]
	public Transform m_DetailEntryActiveObjects;

	[Token(Token = "0x40044D6")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_TextPrefab;

	[Token(Token = "0x40044D7")]
	[FieldOffset(Offset = "0xB8")]
	public Transform m_TextPoolParent;

	[Token(Token = "0x40044D8")]
	[FieldOffset(Offset = "0xC0")]
	public Transform m_TextActiveObjects;

	[Token(Token = "0x40044D9")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_AreaPrefab;

	[Token(Token = "0x40044DA")]
	[FieldOffset(Offset = "0xD0")]
	public Transform m_AreaPoolParent;

	[Token(Token = "0x40044DB")]
	[FieldOffset(Offset = "0xD8")]
	public Transform m_AreaActiveObjects;

	[Token(Token = "0x40044DC")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_RegionSelectObject;

	[Token(Token = "0x40044DD")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_LastUpdatedLabel;

	[Token(Token = "0x40044DE")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_MousePromptDelete;

	[Header("Tunables")]
	[Token(Token = "0x40044DF")]
	[FieldOffset(Offset = "0xF8")]
	public float m_DetailSurveyRadiusMeters;

	[Token(Token = "0x40044E0")]
	[FieldOffset(Offset = "0xFC")]
	public float m_DetailSurveyRockCacheRadiusMeters;

	[Token(Token = "0x40044E1")]
	[FieldOffset(Offset = "0x100")]
	public float m_DetailSurveySprayPaintRadiusMeters;

	[Token(Token = "0x40044E2")]
	[FieldOffset(Offset = "0x104")]
	public float m_DetailSurvayPolaroidRadiusMeters;

	[Token(Token = "0x40044E3")]
	[FieldOffset(Offset = "0x108")]
	public float m_RangeToShowMapIcons;

	[Token(Token = "0x40044E4")]
	[FieldOffset(Offset = "0x10C")]
	public float m_ZoomedInSize;

	[Token(Token = "0x40044E5")]
	[FieldOffset(Offset = "0x110")]
	public float m_GamepadMoveSpeed;

	[Token(Token = "0x40044E6")]
	[FieldOffset(Offset = "0x114")]
	public float m_MagnetizeSpeed;

	[Token(Token = "0x40044E7")]
	[FieldOffset(Offset = "0x118")]
	public List<RegionMap> m_MapObjects;

	[Token(Token = "0x40044E8")]
	[FieldOffset(Offset = "0x120")]
	public Transform m_WorldMapParent;

	[Token(Token = "0x40044E9")]
	[FieldOffset(Offset = "0x128")]
	public GameObject m_WorldMapVignette;

	[Token(Token = "0x40044EA")]
	[FieldOffset(Offset = "0x130")]
	public List<string> m_LocationsToUseBigSprite;

	[Token(Token = "0x40044EB")]
	[FieldOffset(Offset = "0x138")]
	public List<string> m_OutdoorLocationLabelsToIgnore;

	[Token(Token = "0x40044EC")]
	[FieldOffset(Offset = "0x140")]
	public bool m_DoMapCondense;

	[Token(Token = "0x40044ED")]
	[FieldOffset(Offset = "0x144")]
	public float m_MapCondenseDistance;

	[Token(Token = "0x40044EE")]
	[FieldOffset(Offset = "0x148")]
	public bool m_DoMapIconSpacing;

	[Token(Token = "0x40044EF")]
	[FieldOffset(Offset = "0x14C")]
	public float m_MapIconSpacingDistance;

	[Token(Token = "0x40044F0")]
	[FieldOffset(Offset = "0x150")]
	public bool m_MergeMissionIconsWithLocations;

	[Token(Token = "0x40044F1")]
	[FieldOffset(Offset = "0x154")]
	public float m_MapIconLocationSpacingDistance;

	[Token(Token = "0x40044F2")]
	[FieldOffset(Offset = "0x158")]
	public string m_MessageMapIcon;

	[Token(Token = "0x40044F3")]
	[FieldOffset(Offset = "0x160")]
	public LocalizedString m_SprayPaintQuickKeyMapHeader;

	[Token(Token = "0x40044F4")]
	[FieldOffset(Offset = "0x168")]
	public LocalizedString m_SprayPaintQuickKeyMapMessage;

	[Token(Token = "0x40044F5")]
	[FieldOffset(Offset = "0x170")]
	public LocalizedString m_VistaLocationDiscoveredHeader;

	[Token(Token = "0x40044F6")]
	[FieldOffset(Offset = "0x178")]
	public LocalizedString m_VistaLocationDiscoveredMessage;

	[Token(Token = "0x40044F7")]
	[FieldOffset(Offset = "0x180")]
	public string m_VistaDiscoverDynamicString;

	[Range(0f, 1080f)]
	[Tooltip("Offset from the top of the screen that mission markers will be clamped to at 1080p")]
	[Token(Token = "0x40044F8")]
	[FieldOffset(Offset = "0x188")]
	public int m_ScreenTopOffset;

	[Range(0f, 1080f)]
	[Tooltip("Offset from the bottom of the screen that mission markers will be clamped to at 1080p")]
	[Token(Token = "0x40044F9")]
	[FieldOffset(Offset = "0x18C")]
	public int m_ScreenBottomOffset;

	[Range(0f, 1920f)]
	[Tooltip("Offset from the left-side of the screen that mission markers will be clamped to at 1080p")]
	[Token(Token = "0x40044FA")]
	[FieldOffset(Offset = "0x190")]
	public int m_ScreenLeftOffset;

	[Range(0f, 1920f)]
	[Tooltip("Offset from the right-side of the screen that mission markers will be clamped to at 1080p")]
	[Token(Token = "0x40044FB")]
	[FieldOffset(Offset = "0x194")]
	public int m_ScreenRightOffset;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40044FC")]
	[FieldOffset(Offset = "0x198")]
	private AK.Wwise.Event m_OpenMapEvent;

	[SerializeField]
	[Token(Token = "0x40044FD")]
	[FieldOffset(Offset = "0x1A0")]
	private AK.Wwise.Event m_CloseMapEvent;

	[SerializeField]
	[Token(Token = "0x40044FE")]
	[FieldOffset(Offset = "0x1A8")]
	private AK.Wwise.Event m_ChangeMapEvent;

	[SerializeField]
	[Token(Token = "0x40044FF")]
	[FieldOffset(Offset = "0x1B0")]
	private AK.Wwise.Event m_VistaCompletedEvent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004500")]
	[FieldOffset(Offset = "0x1B8")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x4004501")]
	[FieldOffset(Offset = "0x1C0")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4004502")]
	[FieldOffset(Offset = "0x1C8")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x4004503")]
	[FieldOffset(Offset = "0x1D0")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4004504")]
	[FieldOffset(Offset = "0x1D8")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x4004505")]
	[FieldOffset(Offset = "0x1E0")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x4004506")]
	[FieldOffset(Offset = "0x1E8")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4004507")]
	[FieldOffset(Offset = "0x1F0")]
	private PanelReference<Panel_MarkerList> m_MarkerList;

	[SerializeField]
	[Token(Token = "0x4004508")]
	[FieldOffset(Offset = "0x1F8")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[Header("Last Update Label Thresholds")]
	[Token(Token = "0x4004509")]
	[FieldOffset(Offset = "0x200")]
	public float m_HoursThresholdJustNow;

	[Token(Token = "0x400450A")]
	[FieldOffset(Offset = "0x204")]
	public float m_HoursThresholdHoursAgo;

	[Token(Token = "0x400450B")]
	[FieldOffset(Offset = "0x208")]
	public float m_HoursThresholdToday;

	[Token(Token = "0x400450C")]
	[FieldOffset(Offset = "0x20C")]
	public float m_HoursThresholdYesterday;

	[Header("Map Objectives")]
	[Token(Token = "0x400450D")]
	[FieldOffset(Offset = "0x210")]
	public TweenAlpha m_ObjectiveTween;

	[Token(Token = "0x400450E")]
	[FieldOffset(Offset = "0x218")]
	public UILabel m_ObjectiveLabel;

	[Token(Token = "0x400450F")]
	[FieldOffset(Offset = "0x220")]
	public UILabel m_ObjectiveDesc;

	[Token(Token = "0x4004510")]
	[FieldOffset(Offset = "0x228")]
	public UISprite m_ObjectiveIcon;

	[Header("Map Filters")]
	[Token(Token = "0x4004511")]
	[FieldOffset(Offset = "0x230")]
	public GameObject m_CartographyFilters;

	[Range(0f, 0.5f)]
	[Token(Token = "0x4004512")]
	[FieldOffset(Offset = "0x238")]
	public float m_FilterVerticalDelayTimeSeconds;

	[Token(Token = "0x4004513")]
	[FieldOffset(Offset = "0x240")]
	public UIButton m_ResourcesButton;

	[Token(Token = "0x4004514")]
	[FieldOffset(Offset = "0x248")]
	public UIWidget m_ResourcesOffOnDeselect;

	[Token(Token = "0x4004515")]
	[FieldOffset(Offset = "0x250")]
	public UIButton m_StructuresButton;

	[Token(Token = "0x4004516")]
	[FieldOffset(Offset = "0x258")]
	public UIWidget m_StructuresOffOnDeselect;

	[Token(Token = "0x4004517")]
	[FieldOffset(Offset = "0x260")]
	public UIButton m_CorpsesButton;

	[Token(Token = "0x4004518")]
	[FieldOffset(Offset = "0x268")]
	public UIWidget m_CorpsesOffOnDeselect;

	[Token(Token = "0x4004519")]
	[FieldOffset(Offset = "0x270")]
	public UIButton m_RockCachesButton;

	[Token(Token = "0x400451A")]
	[FieldOffset(Offset = "0x278")]
	public UIWidget m_RockCachesOffOnDeselect;

	[Token(Token = "0x400451B")]
	[FieldOffset(Offset = "0x280")]
	public UIButton m_SprayMarkingsButton;

	[Token(Token = "0x400451C")]
	[FieldOffset(Offset = "0x288")]
	public UIWidget m_SprayMarkingsOffOnDeselect;

	[Range(1f, 5f)]
	[Token(Token = "0x400451D")]
	[FieldOffset(Offset = "0x290")]
	public int m_CartographyRockCacheSkillLevel;

	[Range(1f, 5f)]
	[Token(Token = "0x400451E")]
	[FieldOffset(Offset = "0x294")]
	public int m_CartographyFilterSkillLevel;

	[Range(1f, 5f)]
	[Token(Token = "0x400451F")]
	[FieldOffset(Offset = "0x298")]
	public int m_CartographyMarkerSkillLevel;

	[Token(Token = "0x4004520")]
	[FieldOffset(Offset = "0x2A0")]
	public List<string> m_StructuresKeywordList;

	[Token(Token = "0x4004521")]
	[FieldOffset(Offset = "0x2A8")]
	public List<string> m_CorpseKeywordList;

	[Token(Token = "0x4004522")]
	[FieldOffset(Offset = "0x2B0")]
	public string m_RockCacheKeyword;

	[Token(Token = "0x4004523")]
	private const string m_SprayMarkerKeyword = "SprayPaint";

	[Token(Token = "0x4004524")]
	[FieldOffset(Offset = "0x2B8")]
	public string m_UserMarkerKeyword;

	[Token(Token = "0x4004525")]
	[FieldOffset(Offset = "0x2C0")]
	public float m_MarkerClusterMapSize;

	[Token(Token = "0x4004526")]
	[FieldOffset(Offset = "0x2C8")]
	public string m_SprayClusterIcon;

	[Token(Token = "0x4004527")]
	[FieldOffset(Offset = "0x2D0")]
	public string m_RockCacheClusterIcon;

	[Token(Token = "0x4004528")]
	[FieldOffset(Offset = "0x2D8")]
	public string m_MarkerClusterLocID;

	[Token(Token = "0x4004529")]
	[FieldOffset(Offset = "0x2E0")]
	public string m_LowVisibilitySurveyLocId;

	[Token(Token = "0x400452A")]
	[FieldOffset(Offset = "0x2E8")]
	public float m_MultiMarkerIconSize;

	[Header("Nowhere to Hide")]
	[Token(Token = "0x400452B")]
	[FieldOffset(Offset = "0x2F0")]
	public GameObject m_N2HRoot;

	[Token(Token = "0x400452C")]
	[FieldOffset(Offset = "0x2F8")]
	public UILabel m_N2HProgressLabel;

	[Token(Token = "0x400452D")]
	[FieldOffset(Offset = "0x300")]
	public UISprite m_N2HProgressBarSprite;

	[Header("Life After Death")]
	[SerializeField]
	[Token(Token = "0x400452E")]
	[FieldOffset(Offset = "0x308")]
	private GameObject m_RecoveryCampParent;

	[HideInInspector]
	[Token(Token = "0x400452F")]
	[FieldOffset(Offset = "0x310")]
	public string[] m_LocationNames;

	[HideInInspector]
	[Token(Token = "0x4004530")]
	[FieldOffset(Offset = "0x318")]
	public string[] m_SpriteAssignments;

	[NonSerialized]
	[Token(Token = "0x4004531")]
	[FieldOffset(Offset = "0x320")]
	public bool m_HasBeenUpdated;

	[Token(Token = "0x4004532")]
	[FieldOffset(Offset = "0x328")]
	private readonly Dictionary<string, List<MapElementSaveData>> m_MapElementData;

	[Token(Token = "0x4004533")]
	[FieldOffset(Offset = "0x330")]
	private readonly Dictionary<Transform, MapElementSaveData> m_TransformToMapData;

	[Token(Token = "0x4004534")]
	[FieldOffset(Offset = "0x338")]
	private readonly Dictionary<string, List<DetailSurveyPosition>> m_DetailSurveyPositions;

	[Token(Token = "0x4004535")]
	[FieldOffset(Offset = "0x340")]
	private readonly Dictionary<string, float> m_DetailSurveyLastUpdateTimes;

	[Token(Token = "0x4004536")]
	[FieldOffset(Offset = "0x348")]
	private readonly Dictionary<string, FogOfWar> m_FogOfWar;

	[Token(Token = "0x4004537")]
	[FieldOffset(Offset = "0x350")]
	private readonly Dictionary<string, List<VistaLocationData>> m_SurveyedVistaLocations;

	[Token(Token = "0x4004538")]
	[FieldOffset(Offset = "0x358")]
	private readonly List<VistaLocation> m_ActiveVistaLocations;

	[Token(Token = "0x4004539")]
	[FieldOffset(Offset = "0x360")]
	private readonly List<VistaLocation> m_VistaLocationList;

	[Token(Token = "0x400453A")]
	[FieldOffset(Offset = "0x368")]
	private readonly List<MapElementRemovalData> m_DelayedMapElementRemovals;

	[Token(Token = "0x400453B")]
	[FieldOffset(Offset = "0x370")]
	private readonly Dictionary<string, string> m_ParentZoneSpecificationByChild;

	[Token(Token = "0x400453C")]
	[FieldOffset(Offset = "0x378")]
	private readonly Dictionary<WorldMapSpecification, UIWorldMap> m_WorldMaps;

	[Token(Token = "0x400453D")]
	[FieldOffset(Offset = "0x380")]
	private readonly Dictionary<string, GameObject> m_RegionMapIcons;

	[Token(Token = "0x400453E")]
	[FieldOffset(Offset = "0x388")]
	private bool m_IsZoomed;

	[Token(Token = "0x400453F")]
	[FieldOffset(Offset = "0x38C")]
	private HoverState m_HoverState;

	[Token(Token = "0x4004540")]
	[FieldOffset(Offset = "0x390")]
	private Vector3 m_MapElementsOrigPos;

	[Token(Token = "0x4004541")]
	[FieldOffset(Offset = "0x3A0")]
	private MapIcon m_MapIconBeingHovered;

	[Token(Token = "0x4004542")]
	[FieldOffset(Offset = "0x3A8")]
	private MapIcon m_MapIconToRenameDelete;

	[Token(Token = "0x4004543")]
	[FieldOffset(Offset = "0x3B0")]
	private UIWidget m_CrosshairWidget;

	[Token(Token = "0x4004544")]
	[FieldOffset(Offset = "0x3B8")]
	private readonly List<string> m_UnlockedRegionNames;

	[Token(Token = "0x4004545")]
	[FieldOffset(Offset = "0x3C0")]
	private int m_RegionSelectedIndex;

	[Token(Token = "0x4004546")]
	[FieldOffset(Offset = "0x3C8")]
	private IList<GameObject> m_MarkerInfoAddressables;

	[Token(Token = "0x4004547")]
	[FieldOffset(Offset = "0x3D0")]
	private MissionMapMarkerInfo[] m_MarkerInfoFromResources;

	[Token(Token = "0x4004548")]
	[FieldOffset(Offset = "0x3D8")]
	private uint m_OpenCloseAudioID;

	[Token(Token = "0x4004549")]
	[FieldOffset(Offset = "0x3DC")]
	private bool m_DoMapCondenseInternal;

	[Token(Token = "0x400454A")]
	[FieldOffset(Offset = "0x3DD")]
	private bool m_DoMapIconSpacingInternal;

	[Token(Token = "0x400454B")]
	[FieldOffset(Offset = "0x3DE")]
	private bool m_MergeMissionIconsWithLocationsInternal;

	[Token(Token = "0x400454C")]
	[FieldOffset(Offset = "0x3E0")]
	private readonly List<Transform> m_MergedLocations;

	[Token(Token = "0x400454D")]
	[FieldOffset(Offset = "0x3E8")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x400454E")]
	[FieldOffset(Offset = "0x3F0")]
	private MapElementSaveData m_ObjectIconMapData;

	[Token(Token = "0x400454F")]
	[FieldOffset(Offset = "0x3F8")]
	private IconDisplayFilters m_IconDisplayFilters;

	[Token(Token = "0x4004550")]
	[FieldOffset(Offset = "0x400")]
	private List<UIWidget> m_FilterOffOnDeselect;

	[Token(Token = "0x4004551")]
	[FieldOffset(Offset = "0x408")]
	private bool m_FilterSelecterEnabled;

	[Token(Token = "0x4004552")]
	[FieldOffset(Offset = "0x40C")]
	private int m_FilterSelectionIndex;

	[Token(Token = "0x4004553")]
	[FieldOffset(Offset = "0x410")]
	private readonly List<ClusterCell> m_ClusterCells;

	[Token(Token = "0x4004554")]
	[FieldOffset(Offset = "0x418")]
	private MapElementSaveData m_LastMapElementAdded;

	[Token(Token = "0x4004555")]
	[FieldOffset(Offset = "0x420")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x4004556")]
	[FieldOffset(Offset = "0x428")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x4004557")]
	[FieldOffset(Offset = "0x430")]
	private AsyncOperationHandle<IList<ZoneSpecification>> m_ZoneRequests;

	[Token(Token = "0x17000304")]
	public override bool RenderGameCamera
	{
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600382B")]
	[Address(RVA = "0xAECA60", Offset = "0xAEB860", Length = "0xC32")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600382C")]
	[Address(RVA = "0xAED6A0", Offset = "0xAEC4A0", Length = "0x48E")]
	private void OnZoneSpecificationsLoaded(AsyncOperationHandle<IList<ZoneSpecification>> zoneLoadOperation)
	{
	}

	[Token(Token = "0x600382D")]
	[Address(RVA = "0xAEDB30", Offset = "0xAEC930", Length = "0x296")]
	private void AddRegionMap(ZoneSpecification zone)
	{
	}

	[Token(Token = "0x600382E")]
	[Address(RVA = "0xAEDDD0", Offset = "0xAECBD0", Length = "0x4C3")]
	private void OnRegionMapInstanceCreated(ZoneSpecification zone, AsyncOperationHandle<GameObject> regionMapOperation)
	{
	}

	[Token(Token = "0x600382F")]
	[Address(RVA = "0xAEE2A0", Offset = "0xAED0A0", Length = "0x39C")]
	private void AddMapIcon(ZoneSpecification zone)
	{
	}

	[Token(Token = "0x6003830")]
	[Address(RVA = "0xAEE640", Offset = "0xAED440", Length = "0x175")]
	private void OnMapIconInstanceCreated(ZoneSpecification zone, AsyncOperationHandle<GameObject> mapIconOperation)
	{
	}

	[Token(Token = "0x6003831")]
	[Address(RVA = "0xAEE7C0", Offset = "0xAED5C0", Length = "0xC")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x6003832")]
	[Address(RVA = "0xAEE7D0", Offset = "0xAED5D0", Length = "0x22D")]
	private void Update()
	{
	}

	[Token(Token = "0x6003833")]
	[Address(RVA = "0xAEEA00", Offset = "0xAED800", Length = "0xFEA")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003834")]
	[Address(RVA = "0xAEF9F0", Offset = "0xAEE7F0", Length = "0x14FD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003835")]
	[Address(RVA = "0xAF0EF0", Offset = "0xAEFCF0", Length = "0x444")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6003836")]
	[Address(RVA = "0xAF1340", Offset = "0xAF0140", Length = "0x4B4")]
	public void RevealOnPolaroidDiscovery(string polaroidGearItemName, bool showOnMap)
	{
	}

	[Token(Token = "0x6003837")]
	[Address(RVA = "0xAF1800", Offset = "0xAF0600", Length = "0xC7")]
	public void DoDetailSurvey(SurveyType surveyType = SurveyType.Charcoal)
	{
	}

	[Token(Token = "0x6003838")]
	[Address(RVA = "0xAF18D0", Offset = "0xAF06D0", Length = "0xBD0")]
	public void DoNearbyDetailsCheck(float radius, bool forceAddSurveyPosition, bool useOverridePosition, Vector3 overridePostion, bool shouldAllowVistaReveals = false)
	{
	}

	[Token(Token = "0x6003839")]
	[Address(RVA = "0xAF24B0", Offset = "0xAF12B0", Length = "0x2BA")]
	public bool ShouldAddSurveyPosition()
	{
		return false;
	}

	[Token(Token = "0x600383A")]
	[Address(RVA = "0xAF2770", Offset = "0xAF1570", Length = "0x27F")]
	public void RevealFogForScene(ZoneSpecification zone)
	{
	}

	[Token(Token = "0x600383B")]
	[Address(RVA = "0xAF29F0", Offset = "0xAF17F0", Length = "0x1B6")]
	public void RevealFogForScene(string sceneName)
	{
	}

	[Token(Token = "0x600383C")]
	[Address(RVA = "0xAF2BB0", Offset = "0xAF19B0", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600383D")]
	[Address(RVA = "0xAF2BC0", Offset = "0xAF19C0", Length = "0xD84")]
	public void Enable(bool enable, bool cameFromDetailSurvey)
	{
	}

	[Token(Token = "0x600383E")]
	[Address(RVA = "0xAF3950", Offset = "0xAF2750", Length = "0x30B")]
	private void DisableWorldMaps()
	{
	}

	[Token(Token = "0x600383F")]
	[Address(RVA = "0xAF3C60", Offset = "0xAF2A60", Length = "0x10B")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003840")]
	[Address(RVA = "0xAF3D70", Offset = "0xAF2B70", Length = "0x222")]
	public void OnRockCacheNav(string rockCacheName)
	{
	}

	[Token(Token = "0x6003841")]
	[Address(RVA = "0xAF3FA0", Offset = "0xAF2DA0", Length = "0x7A1")]
	public void ToggleWorldMap()
	{
	}

	[Token(Token = "0x6003842")]
	[Address(RVA = "0xAF4750", Offset = "0xAF3550", Length = "0x269")]
	private bool IsWorldMapActive()
	{
		return false;
	}

	[Token(Token = "0x6003843")]
	[Address(RVA = "0xAF49C0", Offset = "0xAF37C0", Length = "0x23E")]
	private void EnableWorldMapOfCurrentScene()
	{
	}

	[Token(Token = "0x6003844")]
	[Address(RVA = "0xAF4C00", Offset = "0xAF3A00", Length = "0x26E")]
	private WorldMapSpecification GetWorldMapForSceneSet(SceneSet sceneSet)
	{
		return null;
	}

	[Token(Token = "0x6003845")]
	[Address(RVA = "0xAF4E70", Offset = "0xAF3C70", Length = "0x1BF")]
	public void OnNextRegion()
	{
	}

	[Token(Token = "0x6003846")]
	[Address(RVA = "0xAF5030", Offset = "0xAF3E30", Length = "0x1BF")]
	public void OnPrevRegion()
	{
	}

	[Token(Token = "0x6003847")]
	[Address(RVA = "0xAF51F0", Offset = "0xAF3FF0", Length = "0x1F6")]
	public bool IsRegionUnlocked(string regionName)
	{
		return false;
	}

	[Token(Token = "0x6003848")]
	[Address(RVA = "0xAF53F0", Offset = "0xAF41F0", Length = "0x19E")]
	public void SetRegion(string regionName)
	{
	}

	[Token(Token = "0x6003849")]
	[Address(RVA = "0xAF5590", Offset = "0xAF4390", Length = "0x42")]
	public void UnlockMapCurrentScene()
	{
	}

	[Token(Token = "0x600384A")]
	[Address(RVA = "0xAF55E0", Offset = "0xAF43E0", Length = "0x2BC")]
	public void UnlockRegionMap(ZoneSpecification zone)
	{
	}

	[Token(Token = "0x600384B")]
	[Address(RVA = "0xAF58A0", Offset = "0xAF46A0", Length = "0x168")]
	public void UnlockRegionMap(string regionName)
	{
	}

	[Token(Token = "0x600384C")]
	[Address(RVA = "0xAF5A10", Offset = "0xAF4810", Length = "0x52")]
	public void GetUnlockedRegionNames(ref List<string> unlockRegionNames)
	{
	}

	[Token(Token = "0x600384D")]
	[Address(RVA = "0xAF5A70", Offset = "0xAF4870", Length = "0x261")]
	public void RevealCurrentScene()
	{
	}

	[Token(Token = "0x600384E")]
	[Address(RVA = "0xAF5CE0", Offset = "0xAF4AE0", Length = "0x182")]
	public ClusterCell FindCluster(int x, int y)
	{
		return null;
	}

	[Token(Token = "0x600384F")]
	[Address(RVA = "0xAF5E70", Offset = "0xAF4C70", Length = "0xEE")]
	public void ForceUpdateRegion()
	{
	}

	[Token(Token = "0x6003850")]
	[Address(RVA = "0xAF5F60", Offset = "0xAF4D60", Length = "0x3D")]
	public void RefreshIconVisibility()
	{
	}

	[Token(Token = "0x6003851")]
	[Address(RVA = "0xAF5FA0", Offset = "0xAF4DA0", Length = "0xEEB")]
	public void LoadMapElementsForScene(string sceneName)
	{
	}

	[Token(Token = "0x6003852")]
	[Address(RVA = "0xAF6E90", Offset = "0xAF5C90", Length = "0x356")]
	public void RenameMapMarkerFromGuid(string guid, string newName)
	{
	}

	[Token(Token = "0x6003853")]
	[Address(RVA = "0xAF71F0", Offset = "0xAF5FF0", Length = "0x164")]
	public void AddMapDetailToMap(MapDetail mapDetail)
	{
	}

	[Token(Token = "0x6003854")]
	[Address(RVA = "0xAF7360", Offset = "0xAF6160", Length = "0x130")]
	public void RemoveMapDetailFromMap(MapDetail mapDetail, float delayHours)
	{
	}

	[Token(Token = "0x6003855")]
	[Address(RVA = "0xAF74A0", Offset = "0xAF62A0", Length = "0x169")]
	public void AddIndoorSpaceTrigger(string triggerID, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[Token(Token = "0x6003856")]
	[Address(RVA = "0xAF7610", Offset = "0xAF6410", Length = "0x1AF")]
	public void AddLoadScene(string sceneName, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[Token(Token = "0x6003857")]
	[Address(RVA = "0xAF77C0", Offset = "0xAF65C0", Length = "0x12C")]
	public void AddDisplayLocationLabel(string locationLocID, Vector3 worldPos)
	{
	}

	[Token(Token = "0x6003858")]
	[Address(RVA = "0xAF78F0", Offset = "0xAF66F0", Length = "0x23B")]
	public bool AddMapMarkerToMap(string markerID, bool isSurveyed = true)
	{
		return false;
	}

	[Token(Token = "0x6003859")]
	[Address(RVA = "0xAF7B30", Offset = "0xAF6930", Length = "0x25F")]
	public void RemoveMapMarkerFromMap(string markerID)
	{
	}

	[Token(Token = "0x600385A")]
	[Address(RVA = "0xAF7D90", Offset = "0xAF6B90", Length = "0x371")]
	public void AddMapIconFromFSM(string markerID, bool nameIsKnown)
	{
	}

	[Token(Token = "0x600385B")]
	[Address(RVA = "0xAF8110", Offset = "0xAF6F10", Length = "0x277")]
	public bool AddDecalMapMarker(DecalProjectorInstance decal)
	{
		return false;
	}

	[Token(Token = "0x600385C")]
	[Address(RVA = "0xAF8390", Offset = "0xAF7190", Length = "0x100")]
	public void RemoveDecalMapMarker(DecalProjectorInstance decal)
	{
	}

	[Token(Token = "0x600385D")]
	[Address(RVA = "0xAF84A0", Offset = "0xAF72A0", Length = "0x105")]
	public float GetDetailLevelAlpha()
	{
		return 0f;
	}

	[Token(Token = "0x600385E")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool NoMapsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x600385F")]
	[Address(RVA = "0xAF85B0", Offset = "0xAF73B0", Length = "0x9A")]
	public void ShowNoMapsUnlockedMessage()
	{
	}

	[Token(Token = "0x6003860")]
	[Address(RVA = "0xAF8650", Offset = "0xAF7450", Length = "0x153")]
	public bool CheckRegionForAchievement(string sceneName, int numTopLevelIconsRequired, int numLocationTriggersRequired, ref int numComplete)
	{
		return false;
	}

	[Token(Token = "0x6003861")]
	[Address(RVA = "0xAF87B0", Offset = "0xAF75B0", Length = "0x129")]
	public int GetNumberOfUnlockedMapElements(string sceneName)
	{
		return 0;
	}

	[Token(Token = "0x6003862")]
	[Address(RVA = "0xAF88E0", Offset = "0xAF76E0", Length = "0x1C4")]
	public List<string> GetLocIdsOfUnlockedMapElements(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6003863")]
	[Address(RVA = "0xAF8AB0", Offset = "0xAF78B0", Length = "0xA6")]
	public string GetSelectedMission()
	{
		return null;
	}

	[Token(Token = "0x6003864")]
	[Address(RVA = "0xAF8B60", Offset = "0xAF7960", Length = "0x558")]
	public void CenterOn(string missionId)
	{
	}

	[Token(Token = "0x6003865")]
	[Address(RVA = "0xAF90C0", Offset = "0xAF7EC0", Length = "0x1B2")]
	public void CenterOnPoint(Vector3 point)
	{
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0xAF9280", Offset = "0xAF8080", Length = "0x10E")]
	public MapElementSaveData AddMapElementCurrentRegion(string locationLocID, string spriteName, bool bigSprite, bool nameIsKnown, Vector3 worldPos, bool isDetail = false, bool isArea = false, bool showDirectional = false, float directionalAngle = float.NaN, string customName = "", bool worldPosIsMapPos = false, string optionalGuid = null)
	{
		return null;
	}

	[Token(Token = "0x6003867")]
	[Address(RVA = "0xAF9390", Offset = "0xAF8190", Length = "0x67")]
	public void RemoveMapElementCurrentRegion(string locationLocID, Vector3 worldPos)
	{
	}

	[Token(Token = "0x6003868")]
	[Address(RVA = "0xAF9400", Offset = "0xAF8200", Length = "0xADA")]
	public void AddSurveyedVistaLocation(string regionName, VistaLocation vistaLocation)
	{
	}

	[Token(Token = "0x6003869")]
	[Address(RVA = "0xAF9EE0", Offset = "0xAF8CE0", Length = "0x32")]
	public bool HasVistaLocationBeenSurveyed(VistaLocation vistaLocation)
	{
		return false;
	}

	[Token(Token = "0x600386A")]
	[Address(RVA = "0xAF9F20", Offset = "0xAF8D20", Length = "0x2E4")]
	private bool HasVistaLocationBeenSurveyed(string regionName, VistaLocation vistaLocation)
	{
		return false;
	}

	[Token(Token = "0x600386B")]
	[Address(RVA = "0xAFA210", Offset = "0xAF9010", Length = "0x9B")]
	public void RegisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[Token(Token = "0x600386C")]
	[Address(RVA = "0xAFA2B0", Offset = "0xAF90B0", Length = "0x5B")]
	public void UnregisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[Token(Token = "0x600386D")]
	[Address(RVA = "0xAFA310", Offset = "0xAF9110", Length = "0x7E")]
	public void AddActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[Token(Token = "0x600386E")]
	[Address(RVA = "0xAFA390", Offset = "0xAF9190", Length = "0x85")]
	public void RemoveActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[Token(Token = "0x600386F")]
	[Address(RVA = "0xAFA420", Offset = "0xAF9220", Length = "0x190")]
	public bool AreAnyUnsurveyedVistasActive()
	{
		return false;
	}

	[Token(Token = "0x6003870")]
	[Address(RVA = "0xAFA5C0", Offset = "0xAF93C0", Length = "0x1D4")]
	public MapIcon GetMapIconFromMapElement(MapElementSaveData mesd)
	{
		return null;
	}

	[Token(Token = "0x6003871")]
	[Address(RVA = "0xAFA7A0", Offset = "0xAF95A0", Length = "0x496")]
	public void DeleteMarker(MapElementSaveData mesd, MapIcon mapIcon, bool shouldClearHoveredIcon)
	{
	}

	[Token(Token = "0x6003872")]
	[Address(RVA = "0xAFAC40", Offset = "0xAF9A40", Length = "0x135")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x6003873")]
	[Address(RVA = "0xAFAD80", Offset = "0xAF9B80", Length = "0x1B")]
	private static bool IsPartOfCluster(MapElementSaveData me)
	{
		return false;
	}

	[Token(Token = "0x6003874")]
	[Address(RVA = "0xAFADA0", Offset = "0xAF9BA0", Length = "0x7E")]
	private static bool IsCluster(MapElementSaveData me)
	{
		return false;
	}

	[Token(Token = "0x6003875")]
	[Address(RVA = "0xAFAE20", Offset = "0xAF9C20", Length = "0xA6")]
	public static bool IsRockCache(MapElementSaveData me)
	{
		return false;
	}

	[Token(Token = "0x6003876")]
	[Address(RVA = "0xAFAED0", Offset = "0xAF9CD0", Length = "0xA6")]
	private static bool IsLegacyUserMarker(MapElementSaveData me)
	{
		return false;
	}

	[Token(Token = "0x6003877")]
	[Address(RVA = "0x696330", Offset = "0x695130", Length = "0x1D")]
	public static bool IsSprayPaint(MapElementSaveData me)
	{
		return false;
	}

	[Token(Token = "0x6003878")]
	[Address(RVA = "0xAFAF80", Offset = "0xAF9D80", Length = "0x137")]
	private static bool IsLocationIdSprayPaint(string locationName)
	{
		return false;
	}

	[Token(Token = "0x6003879")]
	[Address(RVA = "0xAFB0C0", Offset = "0xAF9EC0", Length = "0x71")]
	private void RemoveMapElementCurrentRegion(string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[Token(Token = "0x600387A")]
	[Address(RVA = "0xAFB140", Offset = "0xAF9F40", Length = "0x377")]
	public void RemoveMapElement(string regionName, string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[Token(Token = "0x600387B")]
	[Address(RVA = "0xAFB4C0", Offset = "0xAFA2C0", Length = "0x58B")]
	private MapElementSaveData AddMapElement(string regionName, string locationLocID, string spriteName, bool bigSprite, bool nameIsKnown, Vector3 worldPos, bool isDetail = false, bool isArea = false, bool showDirectional = false, float directionalAngle = float.NaN, Vector2 areaZoneSize = default(Vector2), string customName = "", bool worldPosIsMapPos = false, string optionalGuid = null)
	{
		return null;
	}

	[Token(Token = "0x600387C")]
	[Address(RVA = "0xAFBA50", Offset = "0xAFA850", Length = "0x7DD")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x600387D")]
	[Address(RVA = "0xAFC230", Offset = "0xAFB030", Length = "0x2FD")]
	private Vector3 WorldPositionToMapPosition(string regionName, Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600387E")]
	[Address(RVA = "0xAFC530", Offset = "0xAFB330", Length = "0x31B")]
	private void MapPositionToWorldPosition(string regionName, Vector2 mapPosition, float radius, out Vector3 worldPos, out float worldRadius)
	{
		worldPos = default(Vector3);
		worldRadius = default(float);
	}

	[Token(Token = "0x600387F")]
	[Address(RVA = "0xAFC850", Offset = "0xAFB650", Length = "0x46C")]
	private Quaternion WorldRotationToMapRotation(string regionName, Quaternion worldRotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6003880")]
	[Address(RVA = "0xAFCCC0", Offset = "0xAFBAC0", Length = "0x11FC")]
	private void CreateObjectPools()
	{
	}

	[Token(Token = "0x6003881")]
	[Address(RVA = "0xAFDEC0", Offset = "0xAFCCC0", Length = "0x11E6")]
	private void UnloadMapElements()
	{
	}

	[Token(Token = "0x6003882")]
	[Address(RVA = "0xAFF0B0", Offset = "0xAFDEB0", Length = "0x112")]
	private string GetSpriteNameForLocation(string location)
	{
		return null;
	}

	[Token(Token = "0x6003883")]
	[Address(RVA = "0xAFF1D0", Offset = "0xAFDFD0", Length = "0x295")]
	public bool MapElementExists(string regionName, string locationNameLocID, Vector3 worldPos)
	{
		return false;
	}

	[Token(Token = "0x6003884")]
	[Address(RVA = "0xAFF470", Offset = "0xAFE270", Length = "0xF1")]
	private bool MapDataIsMatch(MapElementSaveData mapData, string locationNameLocID, Vector3 worldPos, string regionName)
	{
		return false;
	}

	[Token(Token = "0x6003885")]
	[Address(RVA = "0xAFF570", Offset = "0xAFE370", Length = "0xF4")]
	private bool MissionMapDataIsMatch(MapElementSaveData mapData, string missionNameLocID, Vector3 worldPos, string regionName)
	{
		return false;
	}

	[Token(Token = "0x6003886")]
	[Address(RVA = "0xAFF670", Offset = "0xAFE470", Length = "0x278")]
	private void HideFilterButtonLabels()
	{
	}

	[Token(Token = "0x6003887")]
	[Address(RVA = "0xAFF8F0", Offset = "0xAFE6F0", Length = "0x16A")]
	private void ProcessFilterButtons()
	{
	}

	[Token(Token = "0x6003888")]
	[Address(RVA = "0xAFFA60", Offset = "0xAFE860", Length = "0x6F")]
	private void FilterSelectionToggle()
	{
	}

	[Token(Token = "0x6003889")]
	[Address(RVA = "0xAFFAD0", Offset = "0xAFE8D0", Length = "0x7F5")]
	private void DoGamepadControls()
	{
	}

	[Token(Token = "0x600388A")]
	[Address(RVA = "0xB002D0", Offset = "0xAFF0D0", Length = "0x333")]
	private void HandleMiniTopNavPrevious()
	{
	}

	[Token(Token = "0x600388B")]
	[Address(RVA = "0xB00610", Offset = "0xAFF410", Length = "0x123")]
	private void ShowClusterList(MapElementSaveData mesd, MapIcon mapBeingHovered)
	{
	}

	[Token(Token = "0x600388C")]
	[Address(RVA = "0xB00740", Offset = "0xAFF540", Length = "0x4ED")]
	private void DoMouseControls()
	{
	}

	[Token(Token = "0x600388D")]
	[Address(RVA = "0xB00C30", Offset = "0xAFFA30", Length = "0x13E")]
	public void ForceZoomIn()
	{
	}

	[Token(Token = "0x600388E")]
	[Address(RVA = "0xB00D70", Offset = "0xAFFB70", Length = "0x3AD")]
	private void ToggleZoom()
	{
	}

	[Token(Token = "0x600388F")]
	[Address(RVA = "0xB01120", Offset = "0xAFFF20", Length = "0x1266")]
	private void CheckForHoverState()
	{
	}

	[Token(Token = "0x6003890")]
	[Address(RVA = "0xB02390", Offset = "0xB01190", Length = "0xA3")]
	private void UpdateCrosshairState()
	{
	}

	[Token(Token = "0x6003891")]
	[Address(RVA = "0xB02440", Offset = "0xB01240", Length = "0x671")]
	private void SetMapIconBeingHovered(MapIcon newMapIcon)
	{
	}

	[Token(Token = "0x6003892")]
	[Address(RVA = "0xB02AC0", Offset = "0xB018C0", Length = "0x1AE")]
	private void MaybeShowClusterListOnHover()
	{
	}

	[Token(Token = "0x6003893")]
	[Address(RVA = "0xB02C70", Offset = "0xB01A70", Length = "0x527")]
	private void RefreshHoverIconText(MapIcon hoverIcon)
	{
	}

	[Token(Token = "0x6003894")]
	[Address(RVA = "0xB031A0", Offset = "0xB01FA0", Length = "0x479")]
	private void UpdateObjectiveGroup(MapElementSaveData mapData)
	{
	}

	[Token(Token = "0x6003895")]
	[Address(RVA = "0xB03620", Offset = "0xB02420", Length = "0xB95")]
	private void ResetToNormal(ResetOpts opts)
	{
	}

	[Token(Token = "0x6003896")]
	[Address(RVA = "0xB041C0", Offset = "0xB02FC0", Length = "0x457")]
	private void MagnetTowardsHoveredIcon()
	{
	}

	[Token(Token = "0x6003897")]
	[Address(RVA = "0xB04620", Offset = "0xB03420", Length = "0x1BA")]
	private void RemoveExpiredMapElements(bool force)
	{
	}

	[Token(Token = "0x6003898")]
	[Address(RVA = "0xB047E0", Offset = "0xB035E0", Length = "0x8C1")]
	private void CheckForExpiredMissionTimers()
	{
	}

	[Token(Token = "0x6003899")]
	[Address(RVA = "0xB050B0", Offset = "0xB03EB0", Length = "0x7BA")]
	private void MaybeFollowMouseWithCrosshair()
	{
	}

	[Token(Token = "0x600389A")]
	[Address(RVA = "0xB05870", Offset = "0xB04670", Length = "0x5E3")]
	private int GetIndexOfCurrentScene()
	{
		return 0;
	}

	[Token(Token = "0x600389B")]
	[Address(RVA = "0x65D7A0", Offset = "0x65C5A0", Length = "0xC6")]
	private static bool SceneNameEquals(string a, string b)
	{
		return false;
	}

	[Token(Token = "0x600389C")]
	[Address(RVA = "0xB05E60", Offset = "0xB04C60", Length = "0x247")]
	private void LoadMarkerDataFromResources()
	{
	}

	[Token(Token = "0x600389D")]
	[Address(RVA = "0xB060B0", Offset = "0xB04EB0", Length = "0xC8")]
	private int GetMapMarkerIndex(string markerID)
	{
		return 0;
	}

	[Token(Token = "0x600389E")]
	[Address(RVA = "0xB06180", Offset = "0xB04F80", Length = "0x67D")]
	private void AddMarkerToWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Token(Token = "0x600389F")]
	[Address(RVA = "0xB06800", Offset = "0xB05600", Length = "0x997")]
	private void AddMarkerToLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Token(Token = "0x60038A0")]
	[Address(RVA = "0xB071A0", Offset = "0xB05FA0", Length = "0x2E7")]
	private void RemoveMarkerFromWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Token(Token = "0x60038A1")]
	[Address(RVA = "0xB07490", Offset = "0xB06290", Length = "0x437")]
	private void RemoveMarkerFromLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Token(Token = "0x60038A2")]
	[Address(RVA = "0xB078D0", Offset = "0xB066D0", Length = "0x400")]
	private void RefreshLastUpdateTimeLabel()
	{
	}

	[Token(Token = "0x60038A3")]
	[Address(RVA = "0xB07CE0", Offset = "0xB06AE0", Length = "0x20C")]
	private bool SceneCanBeMapped(string sceneName)
	{
		return false;
	}

	[Token(Token = "0x60038A4")]
	[Address(RVA = "0xB07EF0", Offset = "0xB06CF0", Length = "0x52E")]
	private void DoMapCondense(Transform mapIconParent)
	{
	}

	[Token(Token = "0x60038A5")]
	[Address(RVA = "0xB08420", Offset = "0xB07220", Length = "0x554")]
	private void DoMapIconSpacing(Transform mapIconParentStatic, Transform mapIconParentMoveable)
	{
	}

	[Token(Token = "0x60038A6")]
	[Address(RVA = "0xB08980", Offset = "0xB07780", Length = "0x3CF")]
	private void MergeNearbyMissionMapIconsWithLocations(Transform mapIconMissionParent, Transform mapIconLocationParent)
	{
	}

	[Token(Token = "0x60038A7")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	private bool ShouldAlwaysBeZoomed()
	{
		return false;
	}

	[Token(Token = "0x60038A8")]
	[Address(RVA = "0xB08D50", Offset = "0xB07B50", Length = "0xA4")]
	private string GetMapNameOfScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60038A9")]
	[Address(RVA = "0xB08E00", Offset = "0xB07C00", Length = "0x78")]
	private string GetParentZoneSpecificationName(string name)
	{
		return null;
	}

	[Token(Token = "0x60038AA")]
	[Address(RVA = "0xB08E80", Offset = "0xB07C80", Length = "0x17D")]
	private string GetMapNameOfCurrentScene()
	{
		return null;
	}

	[Token(Token = "0x60038AB")]
	[Address(RVA = "0xB09000", Offset = "0xB07E00", Length = "0x95A")]
	private void UpdateIconsForOffscreenMissionMarkers()
	{
	}

	[Token(Token = "0x60038AC")]
	[Address(RVA = "0x9B6190", Offset = "0x9B4F90", Length = "0x38")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x60038AD")]
	[Address(RVA = "0xB09960", Offset = "0xB08760", Length = "0x17C")]
	private void UpdateFilterButtons()
	{
	}

	[Token(Token = "0x60038AE")]
	[Address(RVA = "0xB09AE0", Offset = "0xB088E0", Length = "0x32")]
	private void SetButtonState(UIButton button, bool selected)
	{
	}

	[Token(Token = "0x60038AF")]
	[Address(RVA = "0xB09B20", Offset = "0xB08920", Length = "0x8")]
	private void ToggleIconDisplayFlag(IconDisplayFilters flagToToggle)
	{
	}

	[Token(Token = "0x60038B0")]
	[Address(RVA = "0xB09B30", Offset = "0xB08930", Length = "0x17B")]
	private bool IsStructure(string locNameID)
	{
		return false;
	}

	[Token(Token = "0x60038B1")]
	[Address(RVA = "0xB09CB0", Offset = "0xB08AB0", Length = "0x17B")]
	private bool IsCorpse(string locNameID)
	{
		return false;
	}

	[Token(Token = "0x60038B2")]
	[Address(RVA = "0xB09E30", Offset = "0xB08C30", Length = "0xFA")]
	public void OnToggleResourcesFilter()
	{
	}

	[Token(Token = "0x60038B3")]
	[Address(RVA = "0xB09F30", Offset = "0xB08D30", Length = "0x361")]
	public void UpdateIconVisibility_Resources()
	{
	}

	[Token(Token = "0x60038B4")]
	[Address(RVA = "0xB0A2A0", Offset = "0xB090A0", Length = "0x8B")]
	public void OnToggleStructuresFilter()
	{
	}

	[Token(Token = "0x60038B5")]
	[Address(RVA = "0xB0A330", Offset = "0xB09130", Length = "0x2E3")]
	public void UpdateIconVisibility_Structures()
	{
	}

	[Token(Token = "0x60038B6")]
	[Address(RVA = "0xB0A620", Offset = "0xB09420", Length = "0x8D")]
	public void OnToggleCorpsesFilter()
	{
	}

	[Token(Token = "0x60038B7")]
	[Address(RVA = "0xB0A6B0", Offset = "0xB094B0", Length = "0x2E3")]
	public void UpdateIconVisibility_Corpses()
	{
	}

	[Token(Token = "0x60038B8")]
	[Address(RVA = "0xB0A9A0", Offset = "0xB097A0", Length = "0x8E")]
	public void OnToggleRockCacheFilter()
	{
	}

	[Token(Token = "0x60038B9")]
	[Address(RVA = "0xB0AA30", Offset = "0xB09830", Length = "0x2CA")]
	public void UpdateIconVisibility_RockCache()
	{
	}

	[Token(Token = "0x60038BA")]
	[Address(RVA = "0xB0AD00", Offset = "0xB09B00", Length = "0x8E")]
	public void OnToggleSprayMarkingsFilter()
	{
	}

	[Token(Token = "0x60038BB")]
	[Address(RVA = "0xB0AD90", Offset = "0xB09B90", Length = "0x2DF")]
	public void UpdateIconVisibility_SprayMarkings()
	{
	}

	[Token(Token = "0x60038BC")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x60038BD")]
	[Address(RVA = "0xB0B070", Offset = "0xB09E70", Length = "0x8E")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x60038BE")]
	[Address(RVA = "0xB0B100", Offset = "0xB09F00", Length = "0x30B")]
	private void OnSprayPaintMarkerRemove(MapElementSaveData mesd)
	{
	}

	[Token(Token = "0x60038BF")]
	[Address(RVA = "0xB0B410", Offset = "0xB0A210", Length = "0x115")]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[Token(Token = "0x60038C0")]
	[Address(RVA = "0xB0B530", Offset = "0xB0A330", Length = "0x52")]
	private void OnSprayPaintMarkerRemoveCancel(bool wasCancelled)
	{
	}

	[Token(Token = "0x60038C1")]
	[Address(RVA = "0xB0B590", Offset = "0xB0A390", Length = "0x120")]
	private void OnMarkerRemove(bool enable)
	{
	}

	[Token(Token = "0x60038C2")]
	[Address(RVA = "0xB0B6C0", Offset = "0xB0A4C0", Length = "0x8C")]
	private void LoadMapElementsForSceneDone()
	{
	}

	[Token(Token = "0x60038C3")]
	[Address(RVA = "0xB0B750", Offset = "0xB0A550", Length = "0x12E")]
	private void EnableCartographyFilters()
	{
	}

	[Token(Token = "0x60038C4")]
	[Address(RVA = "0xB0B880", Offset = "0xB0A680", Length = "0x516")]
	private void GatherClustersElementsForScene(List<MapElementSaveData> mapData)
	{
	}

	[Token(Token = "0x60038C5")]
	[Address(RVA = "0xB0BDA0", Offset = "0xB0ABA0", Length = "0x483")]
	private ClusterCell GetOrCreateClusterCell(Vector2 positionOnMap, float width)
	{
		return null;
	}

	[Token(Token = "0x60038C6")]
	[Address(RVA = "0xB0C230", Offset = "0xB0B030", Length = "0x75")]
	private void OnMapElementsPositionChanged()
	{
	}

	[Token(Token = "0x60038C7")]
	[Address(RVA = "0xB0C2B0", Offset = "0xB0B0B0", Length = "0x75")]
	private void OnMapClicked()
	{
	}

	[Token(Token = "0x60038C8")]
	[Address(RVA = "0xB0C330", Offset = "0xB0B130", Length = "0x72")]
	private void CloseMarkerListIfActive()
	{
	}

	[Token(Token = "0x60038C9")]
	[Address(RVA = "0xB0C3B0", Offset = "0xB0B1B0", Length = "0x7")]
	private bool ShouldCenterOnPlayer()
	{
		return false;
	}

	[Token(Token = "0x60038CA")]
	[Address(RVA = "0xB0C3C0", Offset = "0xB0B1C0", Length = "0x32F")]
	private void UpdateNowhereToHide()
	{
	}

	[Token(Token = "0x60038CB")]
	[Address(RVA = "0xB0C6F0", Offset = "0xB0B4F0", Length = "0x1C3")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x60038CC")]
	[Address(RVA = "0xB0C8C0", Offset = "0xB0B6C0", Length = "0x1143")]
	public Panel_Map()
	{
	}
}
