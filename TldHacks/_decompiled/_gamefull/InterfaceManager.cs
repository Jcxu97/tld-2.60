using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Interface.PanelRequest;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

[Token(Token = "0x2000770")]
public class InterfaceManager : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000771")]
	private sealed class _003CTakeMapScreenshot_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FD7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FD8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000324")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60045D9")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000325")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60045DB")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60045D6")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CTakeMapScreenshot_003Ed__97(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60045D8")]
		[Address(RVA = "0xC94630", Offset = "0xC93430", Length = "0x10")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0xC94640", Offset = "0xC93440", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Prefabs/Assets")]
	[Token(Token = "0x4004F9B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_TimeWidgetPrefab;

	[Token(Token = "0x4004F9C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_CommonGUIPrefab;

	[Token(Token = "0x4004F9D")]
	[FieldOffset(Offset = "0x30")]
	public SceneNameMapping m_SceneNameMappingAsset;

	[SerializeField]
	[Token(Token = "0x4004F9E")]
	[FieldOffset(Offset = "0x38")]
	private BlueprintManager m_BlueprintManager;

	[SerializeField]
	[Token(Token = "0x4004F9F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_BasicMenuPrefab;

	[SerializeField]
	[Token(Token = "0x4004FA0")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_BasicMenuSwitchPrefab;

	[Token(Token = "0x4004FA1")]
	public static GameObject s_BasicMenuPrefab;

	[SerializeField]
	[Token(Token = "0x4004FA2")]
	[FieldOffset(Offset = "0x50")]
	private PlatformSpecificScreens m_SwitchSpecificScreens;

	[Header("Display Labels")]
	[Token(Token = "0x4004FA3")]
	[FieldOffset(Offset = "0x58")]
	public float m_DisplayLabelCoolDownTimeSeconds;

	[Token(Token = "0x4004FA4")]
	[FieldOffset(Offset = "0x5C")]
	public float m_DisplayLabelTimeSeconds;

	[Token(Token = "0x4004FA5")]
	[FieldOffset(Offset = "0x60")]
	public string m_DisplayLabelDefaultStingerAudio;

	[Header("Tab Colors")]
	[Token(Token = "0x4004FA6")]
	[FieldOffset(Offset = "0x68")]
	public Color m_TabHighlightColor;

	[Token(Token = "0x4004FA7")]
	[FieldOffset(Offset = "0x78")]
	public Color m_TabUnselectedColor;

	[Token(Token = "0x4004FA8")]
	[FieldOffset(Offset = "0x88")]
	public GameplayTag m_DontUseSurvivalTabs;

	[Token(Token = "0x4004FA9")]
	[FieldOffset(Offset = "0x98")]
	public GameplayTag m_TalesAvailable;

	[Header("Click/Hold Times")]
	[Token(Token = "0x4004FAA")]
	[FieldOffset(Offset = "0xA8")]
	public float m_ContainerSearchSeconds;

	[Token(Token = "0x4004FAB")]
	[FieldOffset(Offset = "0xAC")]
	public float m_ContainerOpenSeconds;

	[Token(Token = "0x4004FAC")]
	[FieldOffset(Offset = "0xB0")]
	public float m_SceneTransitionSeconds;

	[Token(Token = "0x4004FAD")]
	[FieldOffset(Offset = "0xB4")]
	public float m_DoorInteractSeconds;

	[Token(Token = "0x4004FAE")]
	[FieldOffset(Offset = "0xB8")]
	public float m_PlotObjectInteractSeconds;

	[Header("Status Bar Colors")]
	[Token(Token = "0x4004FAF")]
	[FieldOffset(Offset = "0xBC")]
	public Color m_StatusMainSpriteRegularColor;

	[Token(Token = "0x4004FB0")]
	[FieldOffset(Offset = "0xCC")]
	public Color m_StatusMainSpriteBelowThresholdColor;

	[Token(Token = "0x4004FB1")]
	[FieldOffset(Offset = "0xDC")]
	public Color m_StatusOuterBoxRegularColor;

	[Token(Token = "0x4004FB2")]
	[FieldOffset(Offset = "0xEC")]
	public Color m_StatusOuterBoxBelowThresholdColor;

	[Token(Token = "0x4004FB3")]
	[FieldOffset(Offset = "0xFC")]
	public Color m_StatusOuterBoxEmptyColor;

	[Header("Condition Bar Colors")]
	[Token(Token = "0x4004FB4")]
	[FieldOffset(Offset = "0x10C")]
	public Color m_ConditionMainSpriteRegularColor;

	[Token(Token = "0x4004FB5")]
	[FieldOffset(Offset = "0x11C")]
	public Color m_ConditionMainSpriteBelowThresholdColor;

	[Token(Token = "0x4004FB6")]
	[FieldOffset(Offset = "0x12C")]
	public Color m_ConditionOuterBoxRegularColor;

	[Token(Token = "0x4004FB7")]
	[FieldOffset(Offset = "0x13C")]
	public Color m_ConditionOuterBoxBelowThresholdColor;

	[Token(Token = "0x4004FB8")]
	[FieldOffset(Offset = "0x14C")]
	public Color m_ConditionOuterBoxEmptyColor;

	[Token(Token = "0x4004FB9")]
	[FieldOffset(Offset = "0x15C")]
	public float m_ConditionHeartTweenScale;

	[Token(Token = "0x4004FBA")]
	[FieldOffset(Offset = "0x160")]
	public float m_ConditionHeartTweenDuration;

	[Token(Token = "0x4004FBB")]
	[FieldOffset(Offset = "0x164")]
	public UITweener.Method m_ConditionHeartTweenMethod;

	[Header("Scalable Atlases")]
	[Token(Token = "0x4004FBC")]
	[FieldOffset(Offset = "0x168")]
	public UIAtlas[] m_ScalableAtlases;

	[Token(Token = "0x4004FBD")]
	public static Transform s_CommonUIAnchor;

	[Token(Token = "0x4004FBE")]
	public static Color m_FirstAidRedColor;

	[Token(Token = "0x4004FBF")]
	public static Color m_FirstAidRiskColor;

	[Token(Token = "0x4004FC0")]
	public static Color m_FirstAidBuffColor;

	[Token(Token = "0x4004FC1")]
	public static bool m_ImmediatelyExitOverlay;

	[Token(Token = "0x4004FC2")]
	public static bool m_ShowCalories;

	[Token(Token = "0x4004FC3")]
	public static bool m_ShowTemperature;

	[Token(Token = "0x4004FC4")]
	[FieldOffset(Offset = "0x170")]
	private Panel_Crafting m_Panel_Crafting;

	[Token(Token = "0x4004FC5")]
	public const string SD_ATLAS_LABEL = "SD";

	[Token(Token = "0x4004FC6")]
	public const string HD_ATLAS_LABEL = "HD";

	[Token(Token = "0x4004FC7")]
	private static GameObject m_TimeWidget;

	[Token(Token = "0x4004FC8")]
	private static Panel_Confirmation.CallbackDelegate m_ConfirmRequest;

	[Token(Token = "0x4004FC9")]
	private static bool s_IsOverlayActive;

	[Token(Token = "0x4004FCA")]
	private static bool s_ShouldRenderGameCamera;

	[Token(Token = "0x4004FCB")]
	public static bool s_UseSdAtlases;

	[Token(Token = "0x4004FCC")]
	private static HudDisplayMode m_SubtitleRestoreHudDisplayMode;

	[Token(Token = "0x4004FCD")]
	private static List<GameObject> m_SubtitleHiddenPanels;

	[Token(Token = "0x4004FCE")]
	private static int m_SubtitleUiCount;

	[Token(Token = "0x4004FCF")]
	private static bool m_MainMenuPanelsLoaded;

	[Token(Token = "0x4004FD0")]
	private static Type[] m_InstantiatedPanels;

	[Token(Token = "0x4004FD1")]
	private static List<Type> m_MainMenuPanels;

	[SerializeField]
	[Token(Token = "0x4004FD2")]
	[FieldOffset(Offset = "0x178")]
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[Token(Token = "0x4004FD3")]
	private static InterfaceManager m_Instance;

	[Token(Token = "0x4004FD4")]
	public static bool s_DebugPanelLoading;

	[Token(Token = "0x4004FD5")]
	[FieldOffset(Offset = "0x180")]
	private Dictionary<Type, Panel_Base> m_PanelCache;

	[Token(Token = "0x4004FD6")]
	[FieldOffset(Offset = "0x188")]
	private List<ILoadPanelRequest> m_AsyncPanelRequests;

	[Token(Token = "0x600457B")]
	[Address(RVA = "0xC892B0", Offset = "0xC880B0", Length = "0x57")]
	public static InterfaceManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x600457C")]
	[Address(RVA = "0xC89310", Offset = "0xC88110", Length = "0x101")]
	public static bool HasInstance()
	{
		return false;
	}

	[Token(Token = "0x600457D")]
	[Address(RVA = "0xC89420", Offset = "0xC88220", Length = "0x359")]
	public static void CreateInterfaceManager()
	{
	}

	[Token(Token = "0x600457E")]
	[Address(RVA = "0xC89780", Offset = "0xC88580", Length = "0x3D5")]
	public void LoadReplacementAtlases(string label)
	{
	}

	[Token(Token = "0x600457F")]
	[Address(RVA = "0xC89B60", Offset = "0xC88960", Length = "0x163")]
	public void ResetReplacementAtlases()
	{
	}

	[Token(Token = "0x6004580")]
	[Address(RVA = "0xC89CD0", Offset = "0xC88AD0", Length = "0x31")]
	public static string GetReplacementAtlasLabel()
	{
		return null;
	}

	[Token(Token = "0x6004581")]
	[Address(RVA = "0xC89D10", Offset = "0xC88B10", Length = "0x2D6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004582")]
	[Address(RVA = "0xC89B60", Offset = "0xC88960", Length = "0x163")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004583")]
	[Address(RVA = "0xC89FF0", Offset = "0xC88DF0", Length = "0x1AD")]
	private void SetupBasicMenuPrefab()
	{
	}

	[Token(Token = "0x6004584")]
	[Address(RVA = "0xC8A1A0", Offset = "0xC88FA0", Length = "0x35F")]
	private void Update()
	{
	}

	[Token(Token = "0x6004585")]
	[Address(RVA = "0xC8A500", Offset = "0xC89300", Length = "0x22A")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004586")]
	[Address(RVA = "0xC8A730", Offset = "0xC89530", Length = "0x47")]
	public static bool ShouldHidePopupBase()
	{
		return false;
	}

	[Token(Token = "0x6004587")]
	[Address(RVA = "0xC8A780", Offset = "0xC89580", Length = "0x7D")]
	public static bool IsOverlayActiveImmediate()
	{
		return false;
	}

	[Token(Token = "0x6004588")]
	[Address(RVA = "0xC8A800", Offset = "0xC89600", Length = "0x54")]
	public static bool IsOverlayActiveCached()
	{
		return false;
	}

	[Token(Token = "0x6004589")]
	[Address(RVA = "0xC8A860", Offset = "0xC89660", Length = "0x54")]
	public static bool ShouldRenderGameCameraCached()
	{
		return false;
	}

	[Token(Token = "0x600458A")]
	[Address(RVA = "0xC8A8C0", Offset = "0xC896C0", Length = "0xB1")]
	public static bool IsPanelLoadingEnabledOrLoading()
	{
		return false;
	}

	[Token(Token = "0x600458B")]
	[Address(RVA = "0xC8A980", Offset = "0xC89780", Length = "0x47")]
	private static bool DetermineIfOverlayIsActive()
	{
		return false;
	}

	[Token(Token = "0x600458C")]
	[Address(RVA = "0xC8A9D0", Offset = "0xC897D0", Length = "0x4A6")]
	private static bool DetermineIfOverlayIsActiveInternal(bool checkPopupBaseActive)
	{
		return false;
	}

	[Token(Token = "0x600458D")]
	[Address(RVA = "0xC8AE80", Offset = "0xC89C80", Length = "0x7B6")]
	public static void QuitCurrentScreens()
	{
	}

	[Token(Token = "0x600458E")]
	[Address(RVA = "0xC8B640", Offset = "0xC8A440", Length = "0x134")]
	public static bool ShouldImmediatelyExitOverlayDuringStruggle()
	{
		return false;
	}

	[Token(Token = "0x600458F")]
	[Address(RVA = "0xC8B780", Offset = "0xC8A580", Length = "0x16A")]
	public static bool ShouldImmediatelyExitOverlay()
	{
		return false;
	}

	[Token(Token = "0x6004590")]
	[Address(RVA = "0xC8B8F0", Offset = "0xC8A6F0", Length = "0x51B")]
	public static void CloseOverlaysDueToSceneLoad()
	{
	}

	[Token(Token = "0x6004591")]
	[Address(RVA = "0xC8BE10", Offset = "0xC8AC10", Length = "0x4B")]
	private static void ResetNotificationsDataIfNotNull(INotificationHandler handler)
	{
	}

	[Token(Token = "0x6004592")]
	[Address(RVA = "0xC8BE60", Offset = "0xC8AC60", Length = "0x12A")]
	public bool SetCameraViewPort(float x, float y, float w, float h)
	{
		return false;
	}

	[Token(Token = "0x6004593")]
	[Address(RVA = "0xC8BF90", Offset = "0xC8AD90", Length = "0x149")]
	public static GameObject GetSoundEmitter()
	{
		return null;
	}

	[Token(Token = "0x6004594")]
	[Address(RVA = "0xC8C0E0", Offset = "0xC8AEE0", Length = "0x93")]
	public static void UpdateMousePointerState()
	{
	}

	[Token(Token = "0x6004595")]
	[Address(RVA = "0xC8C180", Offset = "0xC8AF80", Length = "0x3DD")]
	public static bool IsUsingSurvivalTabs()
	{
		return false;
	}

	[Token(Token = "0x6004596")]
	[Address(RVA = "0xC8C560", Offset = "0xC8B360", Length = "0x6E")]
	public void SetTimeWidgetActive(bool active)
	{
	}

	[Token(Token = "0x6004597")]
	[Address(RVA = "0xC8C5D0", Offset = "0xC8B3D0", Length = "0x1B6")]
	public void InitializeAndActivateTimeWidget(Transform parent, Vector3 pos)
	{
	}

	[Token(Token = "0x6004598")]
	[Address(RVA = "0xC8C790", Offset = "0xC8B590", Length = "0x1E3")]
	public void InitializeAndActivateTimeWidget(Transform positionMarker)
	{
	}

	[Token(Token = "0x6004599")]
	[Address(RVA = "0xC8C980", Offset = "0xC8B780", Length = "0x446")]
	private void ParentToCommonGUIAnchor(GameObject panel, Transform anchor)
	{
	}

	[Token(Token = "0x600459A")]
	[Address(RVA = "0xC8CDD0", Offset = "0xC8BBD0", Length = "0x71")]
	private bool AreTalesAvailable()
	{
		return false;
	}

	[Token(Token = "0x600459B")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	private PlatformSpecificScreens GetSpecificScreensForCurrentPlatform()
	{
		return null;
	}

	[Token(Token = "0x600459C")]
	[Address(RVA = "0xC8CE50", Offset = "0xC8BC50", Length = "0x278")]
	private void InstantiateCommonGUI()
	{
	}

	[Token(Token = "0x600459D")]
	[Address(RVA = "0xC8D0D0", Offset = "0xC8BED0", Length = "0x27B")]
	private void InstantiateTimeWidget()
	{
	}

	[Token(Token = "0x600459E")]
	[Address(RVA = "0xC8D350", Offset = "0xC8C150", Length = "0x5B")]
	public static void InstantiateInterfaceObjectsForLoading()
	{
	}

	[Token(Token = "0x600459F")]
	[Address(RVA = "0xC8D3B0", Offset = "0xC8C1B0", Length = "0x3A9")]
	public static void InstantiateInterfaceObjects()
	{
	}

	[Token(Token = "0x60045A0")]
	[Address(RVA = "0xC8D760", Offset = "0xC8C560", Length = "0xBA")]
	private static void CachePanelReferences()
	{
	}

	[Token(Token = "0x60045A1")]
	[Address(RVA = "0xC8D820", Offset = "0xC8C620", Length = "0x68")]
	private void CacheInstancePanelReferences()
	{
	}

	[Token(Token = "0x60045A2")]
	[Address(RVA = "0xC8D890", Offset = "0xC8C690", Length = "0x50")]
	public void MapScreenshot(int detailLevel = 4)
	{
	}

	[IteratorStateMachine(typeof(_003CTakeMapScreenshot_003Ed__97))]
	[Token(Token = "0x60045A3")]
	[Address(RVA = "0xC8D8E0", Offset = "0xC8C6E0", Length = "0x3D")]
	private IEnumerator TakeMapScreenshot(int detailLevel)
	{
		return null;
	}

	[Token(Token = "0x60045A4")]
	[Address(RVA = "0xC8D920", Offset = "0xC8C720", Length = "0xA5E")]
	private static bool ShouldEnableMousePointer()
	{
		return false;
	}

	[Token(Token = "0x60045A5")]
	[Address(RVA = "0xC8E380", Offset = "0xC8D180", Length = "0x5B")]
	public static bool IsMainMenuEnabled()
	{
		return false;
	}

	[Token(Token = "0x60045A6")]
	[Address(RVA = "0xC8E3E0", Offset = "0xC8D1E0", Length = "0xC3")]
	public static bool IsBrightnessCalibrationActive()
	{
		return false;
	}

	[Token(Token = "0x60045A7")]
	[Address(RVA = "0xC8E4B0", Offset = "0xC8D2B0", Length = "0x15B")]
	public static string GetNameForScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60045A8")]
	[Address(RVA = "0xC8E610", Offset = "0xC8D410", Length = "0x51")]
	public static string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60045A9")]
	[Address(RVA = "0xC8E670", Offset = "0xC8D470", Length = "0x12E")]
	public static string GetLocIDForScene(string sceneName, bool warnIfNotAvailable)
	{
		return null;
	}

	[Token(Token = "0x60045AA")]
	[Address(RVA = "0xC8E7A0", Offset = "0xC8D5A0", Length = "0x2FE")]
	public static string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60045AB")]
	[Address(RVA = "0xC8EAA0", Offset = "0xC8D8A0", Length = "0x20E")]
	public static void RequestConfirmationPanel(Panel_Confirmation.CallbackDelegate onConfirm)
	{
	}

	[Token(Token = "0x60045AC")]
	[Address(RVA = "0xC8ECB0", Offset = "0xC8DAB0", Length = "0x112")]
	public static GameObject InstantiatePopup(UIPanel panelPrefab)
	{
		return null;
	}

	[Token(Token = "0x60045AD")]
	[Address(RVA = "0xC8EDD0", Offset = "0xC8DBD0", Length = "0xE1")]
	private void UpdateConfirmPanelRequest()
	{
	}

	[Token(Token = "0x60045AE")]
	[Address(RVA = "0xC8EEC0", Offset = "0xC8DCC0", Length = "0x5BC")]
	public static void ClearUISaveData()
	{
	}

	[Token(Token = "0x60045AF")]
	[Address(RVA = "0xC8F480", Offset = "0xC8E280", Length = "0x4DA")]
	public static void HidePanelsForSubtitle()
	{
	}

	[Token(Token = "0x60045B0")]
	[Address(RVA = "0xC8F960", Offset = "0xC8E760", Length = "0x356")]
	public static void RestorePanelsAfterSubtitle()
	{
	}

	[Token(Token = "0x60045B1")]
	[Address(RVA = "0xC8FCC0", Offset = "0xC8EAC0", Length = "0x12F")]
	public static ILoadPanelRequest LoadAllPanelsAsync()
	{
		return null;
	}

	[Token(Token = "0x60045B2")]
	[Address(RVA = "0xC8FDF0", Offset = "0xC8EBF0", Length = "0x1D2")]
	private static void LoadMainMenuPanels()
	{
	}

	[Token(Token = "0x60045B3")]
	[Address(RVA = "0xC8FFD0", Offset = "0xC8EDD0", Length = "0x95")]
	public static ILoadPanelRequest LoadMainMenuPanelsAsync()
	{
		return null;
	}

	[Token(Token = "0x60045B4")]
	[Address(RVA = "0xC90070", Offset = "0xC8EE70", Length = "0x2E6")]
	public static void UnloadMainMenuPanels()
	{
	}

	[Token(Token = "0x60045B5")]
	[Address(RVA = "0x18F3AA0", Offset = "0x18F28A0", Length = "0x132")]
	public static bool IsPanelLoaded<T>() where T : Panel_Base
	{
		return false;
	}

	[Token(Token = "0x60045B6")]
	[Address(RVA = "0x18F31F0", Offset = "0x18F1FF0", Length = "0x32E")]
	public static void GetPanelsWithComponent<T>(IList<T> list)
	{
	}

	[Token(Token = "0x60045B7")]
	[Address(RVA = "0xC90360", Offset = "0xC8F160", Length = "0x73")]
	private bool IsPanelLoaded_Internal(Type panelType)
	{
		return false;
	}

	[Token(Token = "0x60045B8")]
	[Address(RVA = "0x18F3960", Offset = "0x18F2760", Length = "0x130")]
	public static bool IsPanelEnabled<T>() where T : Panel_Base
	{
		return false;
	}

	[Token(Token = "0x60045B9")]
	[Address(RVA = "0xC903E0", Offset = "0xC8F1E0", Length = "0xBF")]
	public static bool IsPanelEnabled(Type panelType)
	{
		return false;
	}

	[Token(Token = "0x60045BA")]
	[Address(RVA = "0xC904A0", Offset = "0xC8F2A0", Length = "0x4C")]
	private bool IsPanelEnabled_Internal(Type panelType)
	{
		return false;
	}

	[Token(Token = "0x60045BB")]
	[Address(RVA = "0xC904F0", Offset = "0xC8F2F0", Length = "0x24B")]
	public bool AnyOverlayPanelEnabled()
	{
		return false;
	}

	[Token(Token = "0x60045BC")]
	[Address(RVA = "0xC90740", Offset = "0xC8F540", Length = "0x1C9")]
	public bool AllShouldRenderGameCamera()
	{
		return false;
	}

	[Token(Token = "0x60045BD")]
	[Address(RVA = "0x18F41B0", Offset = "0x18F2FB0", Length = "0x149")]
	public static bool TrySetPanelEnabled<T>(bool enable) where T : Panel_Base
	{
		return false;
	}

	[Token(Token = "0x60045BE")]
	[Address(RVA = "0xC90910", Offset = "0xC8F710", Length = "0xD3")]
	public static bool TrySetPanelEnabled(Type panelType, bool enable)
	{
		return false;
	}

	[Token(Token = "0x60045BF")]
	[Address(RVA = "0xC909F0", Offset = "0xC8F7F0", Length = "0x56")]
	private bool TrySetPanelEnabled_Internal(Type panelType, bool enable)
	{
		return false;
	}

	[Token(Token = "0x60045C0")]
	[Address(RVA = "0x18F3F00", Offset = "0x18F2D00", Length = "0x2AD")]
	public static bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return false;
	}

	[Token(Token = "0x60045C1")]
	[Address(RVA = "0xC90A50", Offset = "0xC8F850", Length = "0x144")]
	private bool TryGetPanel_Internal(Type panelType, out Panel_Base panel)
	{
		panel = null;
		return false;
	}

	[Token(Token = "0x60045C2")]
	[Address(RVA = "0x18F30D0", Offset = "0x18F1ED0", Length = "0x11E")]
	public static T GetPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[Token(Token = "0x60045C3")]
	[Address(RVA = "0xC90BA0", Offset = "0xC8F9A0", Length = "0x7D")]
	private Panel_Base GetPanel_Internal(Type panelType)
	{
		return null;
	}

	[Token(Token = "0x60045C4")]
	[Address(RVA = "0x18F3BE0", Offset = "0x18F29E0", Length = "0x11E")]
	public static T LoadPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[Token(Token = "0x60045C5")]
	[Address(RVA = "0xC90C20", Offset = "0xC8FA20", Length = "0x89")]
	public static Panel_Base LoadPanel(Type panelType)
	{
		return null;
	}

	[Token(Token = "0x60045C6")]
	[Address(RVA = "0xC90CB0", Offset = "0xC8FAB0", Length = "0x135")]
	private Panel_Base LoadPanel_Internal(Type panelType)
	{
		return null;
	}

	[Token(Token = "0x60045C7")]
	[Address(RVA = "0x18F3D00", Offset = "0x18F2B00", Length = "0x101")]
	public static AsyncLoadPanelRequest LoadPanelAsync<T>(Action<Panel_Base> panelLoadedCallback = null) where T : Panel_Base
	{
		return null;
	}

	[Token(Token = "0x60045C8")]
	[Address(RVA = "0xC90DF0", Offset = "0xC8FBF0", Length = "0x9D")]
	public static AsyncLoadPanelRequest LoadPanelAsync(Type panelType, Action<Panel_Base> panelLoadedCallback = null)
	{
		return null;
	}

	[Token(Token = "0x60045C9")]
	[Address(RVA = "0xC90E90", Offset = "0xC8FC90", Length = "0x466")]
	private AsyncLoadPanelRequest LoadPanelAsync_Internal(Type panelType, Action<Panel_Base> panelLoadedCallback = null)
	{
		return null;
	}

	[Token(Token = "0x60045CA")]
	[Address(RVA = "0xC91300", Offset = "0xC90100", Length = "0x9D")]
	public static BatchAsyncLoadPanelRequest GetBatchAsyncPanels(List<Type> panelTypes, Action<bool> panelLoadedCallback = null)
	{
		return null;
	}

	[Token(Token = "0x60045CB")]
	[Address(RVA = "0xC913A0", Offset = "0xC901A0", Length = "0x28B")]
	private BatchAsyncLoadPanelRequest GetBatchAsyncPanels_Internal(List<Type> panelTypes, Action<bool> panelLoadedCallback = null)
	{
		return null;
	}

	[Token(Token = "0x60045CC")]
	[Address(RVA = "0xC91630", Offset = "0xC90430", Length = "0x215")]
	private AsyncLoadPanelRequest GetPendingAsyncPanelRequest(string panelName)
	{
		return null;
	}

	[Token(Token = "0x60045CD")]
	[Address(RVA = "0x18F3E10", Offset = "0x18F2C10", Length = "0xED")]
	public static bool TryDestroyPanel<T>() where T : Panel_Base
	{
		return false;
	}

	[Token(Token = "0x60045CE")]
	[Address(RVA = "0xC91850", Offset = "0xC90650", Length = "0x89")]
	public static bool TryDestroyPanel(Type panelType)
	{
		return false;
	}

	[Token(Token = "0x60045CF")]
	[Address(RVA = "0xC918E0", Offset = "0xC906E0", Length = "0x2DB")]
	private bool TryDestroyPanel_Internal(Type panelType)
	{
		return false;
	}

	[Token(Token = "0x60045D0")]
	[Address(RVA = "0xC91BC0", Offset = "0xC909C0", Length = "0xCE")]
	private string GetPanelName(Type panelType)
	{
		return null;
	}

	[Token(Token = "0x60045D1")]
	[Address(RVA = "0xC91C90", Offset = "0xC90A90", Length = "0xCE")]
	private string GetPanelVariantName(Type panelType)
	{
		return null;
	}

	[Token(Token = "0x60045D2")]
	[Address(RVA = "0xC91D60", Offset = "0xC90B60", Length = "0x295")]
	private void UpdateAsyncLoadPanelRequests()
	{
	}

	[Token(Token = "0x60045D3")]
	[Address(RVA = "0xC92000", Offset = "0xC90E00", Length = "0x1D1")]
	private void FinishLoadPanelRequest(ILoadPanelRequest panelRequest)
	{
	}

	[Token(Token = "0x60045D4")]
	[Address(RVA = "0xC921E0", Offset = "0xC90FE0", Length = "0x18F")]
	public InterfaceManager()
	{
	}
}
