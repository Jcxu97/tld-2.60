using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Interface.PanelRequest;
using TLD.GameplayTags;
using TLD.Logging;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000678")]
public class Panel_Loading : Panel_AutoReferenced
{
	[Token(Token = "0x2000679")]
	public enum LoadingAnimationSelection
	{
		[Token(Token = "0x400420F")]
		Random,
		[Token(Token = "0x4004210")]
		Linear,
		[Token(Token = "0x4004211")]
		Static
	}

	[Token(Token = "0x200067A")]
	public struct HintQueueEntry
	{
		[Token(Token = "0x4004212")]
		[FieldOffset(Offset = "0x0")]
		public string Text;

		[Token(Token = "0x4004213")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x600367A")]
		[Address(RVA = "0xADF090", Offset = "0xADDE90", Length = "0xAA")]
		public HintQueueEntry(string text, string title)
		{
			Text = null;
			Title = null;
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x200067B")]
	private sealed class _003CCaptureScreenCoroutine_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004214")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004215")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004216")]
		[FieldOffset(Offset = "0x20")]
		private Panel_Loading _003Cloading_003E5__2;

		[Token(Token = "0x170002FF")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600367E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000300")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003680")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCaptureScreenCoroutine_003Ed__77(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600367D")]
		[Address(RVA = "0xADF140", Offset = "0xADDF40", Length = "0x2DD")]
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
		[Token(Token = "0x600367F")]
		[Address(RVA = "0xADF420", Offset = "0xADE220", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40041CB")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40041CC")]
	private const int DELAY_HIDE_PANEL_FRAMES = 8;

	[Token(Token = "0x40041CD")]
	public static bool s_Debug;

	[Token(Token = "0x40041CE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_HintsBackgroundParent;

	[Token(Token = "0x40041CF")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_Background;

	[Token(Token = "0x40041D0")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_SceneLabel;

	[Token(Token = "0x40041D1")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_GameModeLabel;

	[Token(Token = "0x40041D2")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_ContinueLabel;

	[Token(Token = "0x40041D3")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_Quotes;

	[Token(Token = "0x40041D4")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_Animations;

	[Token(Token = "0x40041D5")]
	[FieldOffset(Offset = "0x68")]
	public float m_FadeDurationSeconds;

	[Token(Token = "0x40041D6")]
	[FieldOffset(Offset = "0x70")]
	public string m_Audio;

	[Token(Token = "0x40041D7")]
	[FieldOffset(Offset = "0x78")]
	public UITexture m_BackgroundTexture;

	[Token(Token = "0x40041D8")]
	[FieldOffset(Offset = "0x80")]
	public TLDBehaviourTreeOwner m_LoadingScreenBehaviourTree;

	[Token(Token = "0x40041D9")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_CustomLoadScreenLabel;

	[Token(Token = "0x40041DA")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_NonCustomElements;

	[Token(Token = "0x40041DB")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_DebugText;

	[Token(Token = "0x40041DC")]
	[FieldOffset(Offset = "0xA0")]
	public GameplayTag m_UseTwoSecondFadeInDelay;

	[Token(Token = "0x40041DD")]
	[FieldOffset(Offset = "0xB0")]
	public float m_DelayPendingSceneLoadsSeconds;

	[Header("Quotes")]
	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x40041DE")]
	[FieldOffset(Offset = "0xB4")]
	private float m_QuoteFadeFromBlackTime;

	[SerializeField]
	[Range(0f, 30f)]
	[Token(Token = "0x40041DF")]
	[FieldOffset(Offset = "0xB8")]
	private float m_QuoteVisibleOnScreenAfterFadeInStarts;

	[HideInInspector]
	[Token(Token = "0x40041E0")]
	[FieldOffset(Offset = "0xC0")]
	public Action m_CallbackAfterLoad;

	[HideInInspector]
	[Token(Token = "0x40041E1")]
	[FieldOffset(Offset = "0xC8")]
	public bool m_ShowQuoteAfterLoad;

	[HideInInspector]
	[Token(Token = "0x40041E2")]
	[FieldOffset(Offset = "0xC9")]
	public bool m_HoldScreenAfterLoad;

	[HideInInspector]
	[Token(Token = "0x40041E3")]
	[FieldOffset(Offset = "0xCA")]
	public bool m_HoldFadeAfterLoad;

	[HideInInspector]
	[Token(Token = "0x40041E4")]
	[FieldOffset(Offset = "0xD0")]
	public string m_CommandToRunAfterLoad;

	[HideInInspector]
	[Token(Token = "0x40041E5")]
	[FieldOffset(Offset = "0xD8")]
	public bool m_SaveAfterLoad;

	[HideInInspector]
	[Token(Token = "0x40041E6")]
	[FieldOffset(Offset = "0xE0")]
	public LoadingScreenInfo m_Info;

	[Header("Hints")]
	[Token(Token = "0x40041E7")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_Label_Hint;

	[Token(Token = "0x40041E8")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_Label_HintTitle;

	[Token(Token = "0x40041E9")]
	[FieldOffset(Offset = "0xF8")]
	public TLDBehaviourTreeOwner m_HintsBehaviourTree;

	[Token(Token = "0x40041EA")]
	[FieldOffset(Offset = "0x100")]
	public int m_HintQueueMaxSize;

	[Header("NowhereToHide")]
	[Token(Token = "0x40041EB")]
	[FieldOffset(Offset = "0x108")]
	public UIPanel m_NowhereToHideGroup;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40041EC")]
	[FieldOffset(Offset = "0x110")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40041ED")]
	[FieldOffset(Offset = "0x118")]
	private PanelReference<Panel_Actions> m_ActionsPanel;

	[SerializeField]
	[Token(Token = "0x40041EE")]
	[FieldOffset(Offset = "0x120")]
	private PanelReference<Panel_Subtitles> m_SubtitlesPanel;

	[SerializeField]
	[Token(Token = "0x40041EF")]
	[FieldOffset(Offset = "0x128")]
	private PanelReference<Panel_OptionsMenu> m_OptionsPanel;

	[SerializeField]
	[Token(Token = "0x40041F0")]
	[FieldOffset(Offset = "0x130")]
	private PanelReference<Panel_Debug> m_DebugPanel;

	[Token(Token = "0x40041F1")]
	[FieldOffset(Offset = "0x138")]
	private ILoadPanelRequest m_LoadPanelRequest;

	[Token(Token = "0x40041F2")]
	[FieldOffset(Offset = "0x140")]
	private bool m_ShowHints;

	[Token(Token = "0x40041F3")]
	[FieldOffset(Offset = "0x144")]
	private float m_LabelLoadingAlpha;

	[Token(Token = "0x40041F4")]
	[FieldOffset(Offset = "0x148")]
	private float m_LabelContinueAlpha;

	[Token(Token = "0x40041F5")]
	[FieldOffset(Offset = "0x14C")]
	private float m_BackgroundTextureAlpha;

	[Token(Token = "0x40041F6")]
	[FieldOffset(Offset = "0x150")]
	private float m_MinHoldTime;

	[Token(Token = "0x40041F7")]
	[FieldOffset(Offset = "0x154")]
	private bool m_ContinueToGame;

	[Token(Token = "0x40041F8")]
	[FieldOffset(Offset = "0x158")]
	private uint m_AudioID;

	[Token(Token = "0x40041F9")]
	[FieldOffset(Offset = "0x160")]
	private UILabel m_ActiveQuoteLabel;

	[Token(Token = "0x40041FA")]
	[FieldOffset(Offset = "0x168")]
	private float m_StartLoadingTimeSeconds;

	[Token(Token = "0x40041FB")]
	[FieldOffset(Offset = "0x16C")]
	private bool m_HasLoggedLoadingTime;

	[Token(Token = "0x40041FC")]
	[FieldOffset(Offset = "0x170")]
	private float m_DelayHideUntilFrame;

	[Token(Token = "0x40041FD")]
	[FieldOffset(Offset = "0x174")]
	private bool m_LoadingMainMenu;

	[Token(Token = "0x40041FE")]
	[FieldOffset(Offset = "0x178")]
	private LoadingAnimation[] m_LoadingAnimations;

	[Token(Token = "0x40041FF")]
	[FieldOffset(Offset = "0x180")]
	private GameObject m_CurrentLoadingAnimation;

	[Token(Token = "0x4004200")]
	[FieldOffset(Offset = "0x188")]
	private int m_CurrentLoadingAnimationIndex;

	[Token(Token = "0x4004201")]
	[FieldOffset(Offset = "0x18C")]
	private LoadingAnimationSelection m_LoadingAnimationSelection;

	[Token(Token = "0x4004202")]
	[FieldOffset(Offset = "0x190")]
	private LoadingScreenData m_BackgroundData;

	[Token(Token = "0x4004203")]
	[FieldOffset(Offset = "0x198")]
	private LoadingScreenData m_TextData;

	[Token(Token = "0x4004204")]
	[FieldOffset(Offset = "0x1A0")]
	private string m_BackgroundSprite;

	[Token(Token = "0x4004205")]
	[FieldOffset(Offset = "0x1A8")]
	private string m_LoadScreenTextLocID;

	[Token(Token = "0x4004206")]
	[FieldOffset(Offset = "0x1B0")]
	private List<HintQueueEntry> m_HintQueue;

	[Token(Token = "0x4004207")]
	[FieldOffset(Offset = "0x1B8")]
	private int m_HintIndex;

	[Token(Token = "0x4004208")]
	[FieldOffset(Offset = "0x1C0")]
	private string m_CustomLoadScreenLocID;

	[Token(Token = "0x4004209")]
	[FieldOffset(Offset = "0x1C8")]
	private CaptureScreenTransition m_captureTransition;

	[Token(Token = "0x400420A")]
	public static bool m_EnableCaptureScreenTransition;

	[Token(Token = "0x400420B")]
	private static List<string> m_AsyncScenesRemoveList;

	[Token(Token = "0x400420C")]
	[FieldOffset(Offset = "0x1D0")]
	private List<AsyncOperationHandle<SceneInstance>> m_AsyncOperations;

	[Token(Token = "0x400420D")]
	[FieldOffset(Offset = "0x1D8")]
	private float m_DelayPendingSceneLoadsTimer;

	[Token(Token = "0x170002FE")]
	private bool HasPendingSceneLoads
	{
		[Token(Token = "0x600364F")]
		[Address(RVA = "0xAD9200", Offset = "0xAD8000", Length = "0x12")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6003650")]
	[Address(RVA = "0xAD9220", Offset = "0xAD8020", Length = "0xC1")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003651")]
	[Address(RVA = "0xAD92F0", Offset = "0xAD80F0", Length = "0x12A")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003652")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6003653")]
	[Address(RVA = "0xAD9420", Offset = "0xAD8220", Length = "0xCE1")]
	private void Update()
	{
	}

	[Token(Token = "0x6003654")]
	[Address(RVA = "0xADA110", Offset = "0xAD8F10", Length = "0x6E")]
	private bool HasFinishedHolding()
	{
		return false;
	}

	[Token(Token = "0x6003655")]
	[Address(RVA = "0xADA180", Offset = "0xAD8F80", Length = "0x148")]
	private bool HasFinishedLoading()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCaptureScreenCoroutine_003Ed__77))]
	[Token(Token = "0x6003656")]
	[Address(RVA = "0xADA2D0", Offset = "0xAD90D0", Length = "0x3D")]
	public static IEnumerator CaptureScreenCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6003657")]
	[Address(RVA = "0xADA310", Offset = "0xAD9110", Length = "0x1046")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003658")]
	[Address(RVA = "0xADB360", Offset = "0xADA160", Length = "0x774")]
	private void FindBackgroundAndLoadingText()
	{
	}

	[Token(Token = "0x6003659")]
	[Address(RVA = "0xADBAE0", Offset = "0xADA8E0", Length = "0xC9")]
	private string FindChallengeOrSurvivalText()
	{
		return null;
	}

	[Token(Token = "0x600365A")]
	[Address(RVA = "0xADBBB0", Offset = "0xADA9B0", Length = "0x18")]
	public bool HasFoundLoadingBackground()
	{
		return false;
	}

	[Token(Token = "0x600365B")]
	[Address(RVA = "0xADBBD0", Offset = "0xADA9D0", Length = "0x18")]
	public bool HasFoundLoadingText()
	{
		return false;
	}

	[Token(Token = "0x600365C")]
	[Address(RVA = "0xADBBF0", Offset = "0xADA9F0", Length = "0x231")]
	public void SetBackgroundData(LoadingScreenData data)
	{
	}

	[Token(Token = "0x600365D")]
	[Address(RVA = "0xADBE30", Offset = "0xADAC30", Length = "0x14F")]
	public void SetTextData(LoadingScreenData data)
	{
	}

	[Token(Token = "0x600365E")]
	[Address(RVA = "0xADBF80", Offset = "0xADAD80", Length = "0x368")]
	public bool IsLoading()
	{
		return false;
	}

	[Token(Token = "0x600365F")]
	[Address(RVA = "0xADC2F0", Offset = "0xADB0F0", Length = "0x8A")]
	public override bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6003660")]
	[Address(RVA = "0xADC380", Offset = "0xADB180", Length = "0xCD")]
	public bool IsShowingQuote()
	{
		return false;
	}

	[Token(Token = "0x6003661")]
	[Address(RVA = "0xADC450", Offset = "0xADB250", Length = "0x67")]
	public void OnQuoteFinished()
	{
	}

	[Token(Token = "0x6003662")]
	[Address(RVA = "0xADC4C0", Offset = "0xADB2C0", Length = "0x15F")]
	public void QueueHintLabel(string textLocId, string titleLocId = "")
	{
	}

	[Token(Token = "0x6003663")]
	[Address(RVA = "0xADC620", Offset = "0xADB420", Length = "0x268")]
	public void ShowHintLabel(HintQueueEntry hint)
	{
	}

	[Token(Token = "0x6003664")]
	[Address(RVA = "0xADC890", Offset = "0xADB690", Length = "0xB1")]
	public void OnHintFinished()
	{
	}

	[Token(Token = "0x6003665")]
	[Address(RVA = "0xADC950", Offset = "0xADB750", Length = "0x4D")]
	public bool IsHintQueueFull()
	{
		return false;
	}

	[Token(Token = "0x6003666")]
	[Address(RVA = "0xADC9A0", Offset = "0xADB7A0", Length = "0x52")]
	public void ForceCustomLoadScreen(string textLocId)
	{
	}

	[Token(Token = "0x6003667")]
	[Address(RVA = "0xADCA00", Offset = "0xADB800", Length = "0x17")]
	public void ForceMinHoldTime(float minHoldTime)
	{
	}

	[Token(Token = "0x6003668")]
	[Address(RVA = "0xADCA20", Offset = "0xADB820", Length = "0xB")]
	public void ResetMinHoldTime()
	{
	}

	[Token(Token = "0x6003669")]
	[Address(RVA = "0xADCA30", Offset = "0xADB830", Length = "0x16E")]
	public void OnScreenBackgroundTransitionFinished()
	{
	}

	[Token(Token = "0x600366A")]
	[Address(RVA = "0xADCBA0", Offset = "0xADB9A0", Length = "0x6B5")]
	private void SetLoadingScreenText()
	{
	}

	[Token(Token = "0x600366B")]
	[Address(RVA = "0xADD260", Offset = "0xADC060", Length = "0xA92")]
	private void SetRandomQuoteActive()
	{
	}

	[Token(Token = "0x600366C")]
	[Address(RVA = "0xADDD00", Offset = "0xADCB00", Length = "0xB5")]
	private void MaybePlayAudio()
	{
	}

	[Token(Token = "0x600366D")]
	[Address(RVA = "0xADDDC0", Offset = "0xADCBC0", Length = "0x241")]
	private void LoadPendingScenes()
	{
	}

	[Token(Token = "0x600366E")]
	[Address(RVA = "0xADE010", Offset = "0xADCE10", Length = "0x108")]
	private bool AsyncLoadsComplete()
	{
		return false;
	}

	[Token(Token = "0x600366F")]
	[Address(RVA = "0xADE120", Offset = "0xADCF20", Length = "0xB8")]
	public LoadingAnimation[] GetPossibleLoadingAnimations()
	{
		return null;
	}

	[Token(Token = "0x6003670")]
	[Address(RVA = "0xADE1E0", Offset = "0xADCFE0", Length = "0x42")]
	public void SetLoadingAnimationSelection(LoadingAnimationSelection selection, int index = -1)
	{
	}

	[Token(Token = "0x6003671")]
	[Address(RVA = "0xADE230", Offset = "0xADD030", Length = "0x3BA")]
	private void SelectLoadingAnimation()
	{
	}

	[Token(Token = "0x6003672")]
	[Address(RVA = "0xADE5F0", Offset = "0xADD3F0", Length = "0x481")]
	private void RefreshAsyncSceneLoadRecord()
	{
	}

	[Token(Token = "0x6003673")]
	[Address(RVA = "0xADEA80", Offset = "0xADD880", Length = "0x34")]
	public bool ShouldCaptureScreen()
	{
		return false;
	}

	[Token(Token = "0x6003674")]
	[Address(RVA = "0xADEAC0", Offset = "0xADD8C0", Length = "0x77")]
	public void StartCapture(Action OnCaptureFinish)
	{
	}

	[Token(Token = "0x6003675")]
	[Address(RVA = "0xADEB40", Offset = "0xADD940", Length = "0x43")]
	public void UpdateCaptureForTransition()
	{
	}

	[Token(Token = "0x6003676")]
	[Address(RVA = "0xADEB90", Offset = "0xADD990", Length = "0x136")]
	public void DoCaptureScreen()
	{
	}

	[Token(Token = "0x6003677")]
	[Address(RVA = "0xADECD0", Offset = "0xADDAD0", Length = "0x1E")]
	public void CaptureStarted()
	{
	}

	[Token(Token = "0x6003678")]
	[Address(RVA = "0xADECF0", Offset = "0xADDAF0", Length = "0x1A1")]
	public Panel_Loading()
	{
	}
}
