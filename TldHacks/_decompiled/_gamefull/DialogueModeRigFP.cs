using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using TLD.AddressableAssets;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Timeline;

[Token(Token = "0x20002BB")]
public class DialogueModeRigFP : MonoBehaviour
{
	[Token(Token = "0x20002BC")]
	public struct IdlePropInfo
	{
		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x0")]
		public CinematicAssets.PermanentPropId m_PermanentPropId;

		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x4")]
		public int m_CurrentIdleStateHash;
	}

	[Token(Token = "0x20002BD")]
	public struct AssignedChoiceCategoryInfo
	{
		[Token(Token = "0x40018AC")]
		[FieldOffset(Offset = "0x0")]
		public string m_LocId;

		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x8")]
		public Dialogue_MultipleChoiceNode.ChoiceCategory m_AssignedCategory;
	}

	[Token(Token = "0x20002BE")]
	public class DialogueModeRigFPSaveData
	{
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x10")]
		public string m_NPC_MissionId;

		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x18")]
		public int m_CurrentIdleStateHash;

		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x20")]
		public string m_CurrentCameraFramingName;

		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x28")]
		public List<IdlePropInfo> m_CurrentPermanentPropIdles;

		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x30")]
		public AssignedChoiceCategoryInfo[] m_CurrentAssignedChoiceCategoryInfo;

		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x6DE020", Offset = "0x6DCE20", Length = "0x139")]
		public DialogueModeRigFPSaveData()
		{
		}
	}

	[Token(Token = "0x20002BF")]
	public enum DialogueModeState
	{
		[Token(Token = "0x40018B4")]
		DialogueModeStateNone,
		[Token(Token = "0x40018B5")]
		DialogueModeStateTransitionIn,
		[Token(Token = "0x40018B6")]
		DialogueModeStateStart,
		[Token(Token = "0x40018B7")]
		DialogueModeStateIdle,
		[Token(Token = "0x40018B8")]
		DialogueModeStateLoadSequence,
		[Token(Token = "0x40018B9")]
		DialogueModeStatePlayLine,
		[Token(Token = "0x40018BA")]
		DialogueModeStatePlayCinematic,
		[Token(Token = "0x40018BB")]
		DialogueModeStatePlayLineComplete,
		[Token(Token = "0x40018BC")]
		DialogueModeStatePlayCinematicComplete,
		[Token(Token = "0x40018BD")]
		DialogueModeStateTransitionOut,
		[Token(Token = "0x40018BE")]
		DialogueModeStateEnd,
		[Token(Token = "0x40018BF")]
		DialogueModeStateTimeline
	}

	[Token(Token = "0x20002C0")]
	public enum DialogueControllerMode
	{
		[Token(Token = "0x40018C1")]
		OriginalController,
		[Token(Token = "0x40018C2")]
		LoadedController
	}

	[Serializable]
	[Token(Token = "0x20002C1")]
	public class DialogueChoiceCategoryConfiguration
	{
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x10")]
		public Dialogue_MultipleChoiceNode.ChoiceCategory m_Category;

		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x14")]
		public Color m_NormalTextColor;

		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x24")]
		public Color m_TextHoveredColor;

		[Token(Token = "0x40018C6")]
		[FieldOffset(Offset = "0x34")]
		public float m_Scale;

		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D m_ForegroundImage;

		[Token(Token = "0x40018C8")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D m_BackgroundImage;

		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x6DE160", Offset = "0x6DCF60", Length = "0x8")]
		public DialogueChoiceCategoryConfiguration()
		{
		}
	}

	[Token(Token = "0x20002C2")]
	public class DialogueChoiceInfo
	{
		[Token(Token = "0x40018C9")]
		[FieldOffset(Offset = "0x10")]
		public string m_Text;

		[Token(Token = "0x40018CA")]
		[FieldOffset(Offset = "0x18")]
		public string m_LocId;

		[Token(Token = "0x40018CB")]
		[FieldOffset(Offset = "0x20")]
		public Dialogue_MultipleChoiceNode.ChoiceCategory m_OriginalSlotCategory;

		[Token(Token = "0x40018CC")]
		[FieldOffset(Offset = "0x24")]
		public DialogueOptionTopic m_Topic;

		[Token(Token = "0x40018CD")]
		[FieldOffset(Offset = "0x28")]
		public int m_ChoiceIndex;

		[Token(Token = "0x40018CE")]
		[FieldOffset(Offset = "0x2C")]
		public bool m_IsHidden;

		[Token(Token = "0x40018CF")]
		[FieldOffset(Offset = "0x30")]
		public float m_TextSize;

		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DialogueChoiceInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20002C3")]
	public class IdleMatchingInfo
	{
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x10")]
		public string m_MainIdle;

		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x18")]
		public string m_DialogueIdle;

		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public IdleMatchingInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20002C4")]
	public class CameraFramingInfo
	{
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_CharacterPlayerDummy;

		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_CameraPlayerDummy;

		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x20")]
		public string m_Name;

		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public CameraFramingInfo()
		{
		}
	}

	[Token(Token = "0x20002C5")]
	public class DialogueStatement
	{
		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x10")]
		public string m_StateName;

		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x18")]
		public string m_StateKey;

		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x20")]
		public float m_Duration;

		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x24")]
		public float m_AfterDuration;

		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x28")]
		public float m_ElapsedTime;

		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x30")]
		public string m_DialogueActorName;

		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x38")]
		public string m_SubtitlesText;

		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x40")]
		public bool m_IsUnknownSpeaker;

		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x48")]
		public string m_LocId;

		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x50")]
		public string m_AudioEventStart;

		[Token(Token = "0x40018DF")]
		[FieldOffset(Offset = "0x58")]
		public string m_AudioEventStop;

		[Token(Token = "0x40018E0")]
		[FieldOffset(Offset = "0x60")]
		public bool m_IsCinematic;

		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x68")]
		public string m_FaceStateKey;

		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DialogueStatement()
		{
		}
	}

	[Token(Token = "0x20002C6")]
	public class CinematicMoment
	{
		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x10")]
		public string m_StateName;

		[Token(Token = "0x40018E3")]
		[FieldOffset(Offset = "0x18")]
		public string m_StateKey;

		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x20")]
		public float m_Duration;

		[Token(Token = "0x40018E5")]
		[FieldOffset(Offset = "0x24")]
		public float m_ElapsedTime;

		[Token(Token = "0x40018E6")]
		[FieldOffset(Offset = "0x28")]
		public string m_AudioEventStart;

		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x30")]
		public string m_AudioEventStop;

		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x38")]
		public Utils.Subtitle[] m_Subtitles;

		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x40")]
		public uint m_NumSubtitles;

		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x6DE170", Offset = "0x6DCF70", Length = "0x87")]
		public CinematicMoment()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x20002C7")]
	private sealed class _003CLoadAnimations_003Ed__250 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x20")]
		public DialogueModeRigFP _003C_003E4__this;

		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x28")]
		public string stateKey;

		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x30")]
		private string _003CassetBundleFilename_003E5__2;

		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x38")]
		private string _003CprefabPath_003E5__3;

		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x40")]
		private AssetBundleRefRequest _003Crequest_003E5__4;

		[Token(Token = "0x170001F1")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60017BF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F2")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60017C1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CLoadAnimations_003Ed__250(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x6DE200", Offset = "0x6DD000", Length = "0xDC7")]
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
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x6DEFD0", Offset = "0x6DDDD0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4001819")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x400181A")]
	[FieldOffset(Offset = "0x28")]
	public DialogueCategoriesConfiguration m_DialogueCategoriesConfigurations;

	[Token(Token = "0x400181B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_DialogueOptionsAnimationTreePrefab;

	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_DialogueOptionsAnimationTreeParent;

	[Token(Token = "0x400181D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_LabelDialogPrefab;

	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x48")]
	public List<CameraFramingInfo> m_CameraFramingInfoList;

	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_CharacterPlayerDummy;

	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_CameraPlayerDummy;

	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_AudioEmitterNode;

	[Token(Token = "0x4001822")]
	[FieldOffset(Offset = "0x68")]
	public DialogueTreeController m_DefaultDialogueTree;

	[Header("NPC")]
	[Token(Token = "0x4001823")]
	[FieldOffset(Offset = "0x70")]
	public Animator m_CurrentNPCAnimator;

	[Tooltip("Look up the name in the knowledgebase using key. If empty, uses the default DisplayName.")]
	[Token(Token = "0x4001824")]
	[FieldOffset(Offset = "0x78")]
	public string m_KnowledgeDescLocID;

	[Tooltip("The default hover text when no knowledgebase key is provided.")]
	[Token(Token = "0x4001825")]
	[FieldOffset(Offset = "0x80")]
	public string m_DisplayName;

	[Tooltip("If a knowledgebase key is provided, but not found, display this as hover text instead of the default: Unknown.")]
	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x88")]
	public string m_OptionalUnknownDisplayName;

	[Header("Props")]
	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x90")]
	public List<CinematicAssets.PermanentPropInfo> m_PermanentProps;

	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x98")]
	public CharacterController m_CurrentNPCCharacterController;

	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0xA0")]
	public bool m_IndividualLineAnimationRequired;

	[Header("Params")]
	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0xA4")]
	public float m_Fov;

	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0xA8")]
	public float m_TransitionDurationSeconds;

	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0xB4")]
	public Vector2 m_YawLimitDegrees;

	[Range(0f, 180f)]
	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0xBC")]
	public float m_NPCInteractionConeAngleDegrees;

	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0xC0")]
	public float m_StrafingDistanceLimitMeters;

	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0xC4")]
	public bool m_SkipPlayerInTransition;

	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0xC5")]
	public bool m_SkipPlayerOutTransition;

	[Token(Token = "0x4001832")]
	[FieldOffset(Offset = "0xC6")]
	public bool m_UseTimelineForSpeech;

	[Token(Token = "0x4001833")]
	[FieldOffset(Offset = "0xC8")]
	public string m_DefaultFramingNonStory;

	[Token(Token = "0x4001834")]
	[FieldOffset(Offset = "0xD0")]
	public string m_DefaultAnimationStateNonStory;

	[Token(Token = "0x4001835")]
	[FieldOffset(Offset = "0xD8")]
	public bool m_GroundPlayerOnEnd;

	[Token(Token = "0x4001836")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_DialogueSequenceListParent;

	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0xE8")]
	private List<DialogueSequenceFP> m_DialogueSequenceList;

	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0xF0")]
	private List<DialogueChoiceInfo> m_DialogueChoiceInfo;

	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0xF8")]
	private float m_TransitionElapsedTimeSeconds;

	[Token(Token = "0x400183A")]
	[FieldOffset(Offset = "0xFC")]
	private Vector3 m_OriginalPlayerPos;

	[Token(Token = "0x400183B")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 m_OriginalCameraLocalPos;

	[Token(Token = "0x400183C")]
	[FieldOffset(Offset = "0x114")]
	private Quaternion m_OriginalCameraPlayerRotation;

	[Token(Token = "0x400183D")]
	[FieldOffset(Offset = "0x124")]
	private Vector2 m_TransitionStartCameraPlayerAngle;

	[Token(Token = "0x400183E")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 m_TransitionStartPlayerPosition;

	[Token(Token = "0x400183F")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 m_TransitionStartLocalCameraPosition;

	[Token(Token = "0x4001840")]
	[FieldOffset(Offset = "0x144")]
	private float m_OriginalCameraFov;

	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x148")]
	private PlayerControlMode m_RestorePlayerControlMode;

	[Token(Token = "0x4001842")]
	[FieldOffset(Offset = "0x14C")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x4001843")]
	[FieldOffset(Offset = "0x154")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x4001844")]
	[FieldOffset(Offset = "0x15C")]
	private Vector3 m_EndDialoguePlayerPos;

	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x168")]
	private Vector3 m_EndDialogueCameraLocalPos;

	[Token(Token = "0x4001846")]
	[FieldOffset(Offset = "0x174")]
	private Quaternion m_EndDialoguePlayerRotation;

	[Token(Token = "0x4001847")]
	[FieldOffset(Offset = "0x184")]
	private DialogueModeState m_DialogueModeState;

	[Token(Token = "0x4001848")]
	[FieldOffset(Offset = "0x188")]
	private Animator m_LoadedNPCAnimator;

	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0x190")]
	private Animator m_LoadedFPHAnimator;

	[Token(Token = "0x400184A")]
	[FieldOffset(Offset = "0x198")]
	private PlayEventMonitor m_PlayEventMonitor;

	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x1A0")]
	private Animator m_CurrentFPHAnimator;

	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0x1A8")]
	private DialogueStatement m_DialogueStatement;

	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x1B0")]
	private string m_CameraFramingIn;

	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_CameraFramingInTransitionDurationSeconds;

	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x1C0")]
	private string m_CameraFramingOut;

	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x1C8")]
	private float m_CameraFramingOutTransitionDurationSeconds;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x1CC")]
	private PlayerControlMode m_DesiredTimelineControlMode;

	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x1D0")]
	private string m_DialogueExitPoint;

	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x1D8")]
	private DialogueTreeController m_DialogueTreeController;

	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x1E0")]
	private RuntimeAnimatorController m_OriginalNPCRuntimeAnimatorController;

	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x1E8")]
	private RuntimeAnimatorController m_OriginalFPHRuntimeAnimatorController;

	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x1F0")]
	private Action m_OnStatementFinish;

	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x1F8")]
	private Action m_OnCinematicFinish;

	[Token(Token = "0x4001858")]
	private const string DEFAULT_PLAYER_ACTOR_NAME = "Mackenzie";

	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x200")]
	private bool m_LoadingRequested;

	[Token(Token = "0x400185A")]
	[FieldOffset(Offset = "0x208")]
	private string m_LoadedAssetBundleFilename;

	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x210")]
	private string m_LoadedPrefabPath;

	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x218")]
	private string m_AnimState_Idle;

	[Token(Token = "0x400185D")]
	private static DialogueModeRigFP m_Current;

	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0x220")]
	private DialogueModeState m_PendingDialogueModeState;

	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0x228")]
	private DialogueOptionsAnimationTree m_DialogueOptionsAnimationTree;

	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x230")]
	private DialogueControllerMode m_DialogueControllerMode;

	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x234")]
	private bool m_AnimationsLoadingComplete;

	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x238")]
	private AssetBundleRef m_AssetBundle;

	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0x240")]
	private GameObject m_AnimationsAsset;

	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x248")]
	private int m_NPCBaseLayerIndex;

	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x24C")]
	private int m_NPCHeadLayerIndex;

	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x250")]
	private int m_NPCFaceLayerIndex;

	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x258")]
	private CinematicAssets m_DialogueAssets;

	[Token(Token = "0x4001868")]
	[FieldOffset(Offset = "0x260")]
	private float m_CurrentTime;

	[Token(Token = "0x4001869")]
	[FieldOffset(Offset = "0x264")]
	private float m_CurrentAnimationTime;

	[Token(Token = "0x400186A")]
	[FieldOffset(Offset = "0x268")]
	private List<DialogueOptionTopic> m_CurrentFilter;

	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x270")]
	private bool m_FilterHasChanged;

	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x274")]
	private int m_DialogueStartedCount;

	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x278")]
	private PlayerAnimation.CameraLayer m_CameraLayerBeforeDialogue;

	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x27C")]
	private int m_OnGoingAnimationState;

	[Token(Token = "0x400186F")]
	[FieldOffset(Offset = "0x280")]
	private string m_OnGoingAnimationStateName;

	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x288")]
	private string m_OnGoingAnimationStateKey;

	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x290")]
	private bool m_AnimationRequested;

	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x291")]
	private bool m_NextDialogueRequested;

	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x294")]
	private float m_OnGoingAnimationDuration;

	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0x298")]
	private uint m_AudioID;

	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0x2A0")]
	private string m_AudioEventStop;

	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0x2A8")]
	private string m_AudioEventStart;

	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0x2B0")]
	private Action m_OnExitRequestedAction;

	[Token(Token = "0x4001878")]
	[FieldOffset(Offset = "0x2B8")]
	private int m_AnimParameter_Is_InDialogue;

	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0x2C0")]
	private string m_NPC_MissionId;

	[Token(Token = "0x400187A")]
	[FieldOffset(Offset = "0x2C8")]
	private bool m_RecenterCameraRequested;

	[Token(Token = "0x400187B")]
	[FieldOffset(Offset = "0x2D0")]
	private string m_CurrentCameraFramingName;

	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x2D8")]
	private NPC_Animation m_NPC_AnimationComponent;

	[Token(Token = "0x400187D")]
	[FieldOffset(Offset = "0x2E0")]
	private CinematicMoment m_CinematicMoment;

	[Token(Token = "0x400187E")]
	[FieldOffset(Offset = "0x2E8")]
	private bool m_CurrentFPHAnimatorPlaying;

	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x2E9")]
	private bool m_ShowDialogueUI;

	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0x2EC")]
	private int m_PendingIdleHash;

	[Token(Token = "0x4001881")]
	[FieldOffset(Offset = "0x2F0")]
	private int m_PendingIdleLayer;

	[Token(Token = "0x4001882")]
	[FieldOffset(Offset = "0x2F4")]
	private bool m_IsIdlePending;

	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x2F8")]
	private string m_OnGoingAnimationTrigger;

	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x300")]
	private bool m_IsCinematicOnGoing;

	[Token(Token = "0x4001885")]
	[FieldOffset(Offset = "0x304")]
	private float m_AudioDurationRealtimeSeconds;

	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x308")]
	private float m_AfterDurationTimer;

	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0x30C")]
	private bool m_PlaySequenceCompleteReady;

	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x30D")]
	private bool m_LerpCameraValuesInitialized;

	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x310")]
	private string m_OnGoingFaceAnimationTrigger;

	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0x318")]
	private string m_OnGoingFaceAnimationStateKey;

	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0x320")]
	private bool m_FadedOutOnExit;

	[Token(Token = "0x400188C")]
	public static bool s_DebugDialogue;

	[Token(Token = "0x400188D")]
	private static List<DialogueModeRigFP> s_DialogueModeRigFPs;

	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0x321")]
	private bool m_EnableExitUI;

	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0x322")]
	private bool m_ExitDialoguePending;

	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x328")]
	private Action m_OnDialogueEndsAction;

	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0x330")]
	private AssignedChoiceCategoryInfo[] m_CurrentAssignedChoiceCategoryInfo;

	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x338")]
	private bool m_CanApplyCameraMotionToJoint;

	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x33C")]
	private float m_CurrentTransitionDurationSeconds;

	[Token(Token = "0x4001894")]
	private const int MAX_CHOICES_COUNT = 32;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x340")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4001896")]
	private const string SUBTITLE_PREFIX = "SUBTITLE_";

	[Token(Token = "0x4001897")]
	private const string ANIMATION_STATE_PREFIX = "Dia_";

	[Token(Token = "0x4001898")]
	private const string TIMELINE_PREFIX = "Dia_";

	[Token(Token = "0x4001899")]
	private const string AUDIO_START_PREFIX = "Play_SndVO";

	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0x348")]
	private AssetReferenceTimeline m_TimelineRef;

	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0x350")]
	private AssetReferenceTimeline m_RequestedTimelineRef;

	[Token(Token = "0x400189C")]
	[FieldOffset(Offset = "0x358")]
	private TimelineAsset m_LoadedTimeline;

	[Token(Token = "0x400189D")]
	[FieldOffset(Offset = "0x360")]
	private bool m_LoadTimelineCompleted;

	[Token(Token = "0x400189E")]
	[FieldOffset(Offset = "0x361")]
	private bool m_LoadTimelineFailed;

	[Token(Token = "0x400189F")]
	[FieldOffset(Offset = "0x362")]
	private bool m_LerpCameraOffset;

	[Token(Token = "0x40018A0")]
	[FieldOffset(Offset = "0x363")]
	private bool m_ResetAimingModeRequested;

	[Token(Token = "0x40018A1")]
	[FieldOffset(Offset = "0x364")]
	private bool m_DisableBreathFXForTimeline;

	[Token(Token = "0x40018A2")]
	[FieldOffset(Offset = "0x368")]
	private HudDisplayMode m_RestoreHudDisplayMode;

	[Token(Token = "0x40018A3")]
	[FieldOffset(Offset = "0x36C")]
	private bool m_DelaySubtitles;

	[Token(Token = "0x40018A4")]
	private const HudDisplayMode CINEMATIC_HUD_MODE = HudDisplayMode.Subtitles;

	[SerializeField]
	[Token(Token = "0x40018A5")]
	[FieldOffset(Offset = "0x370")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x40018A6")]
	[FieldOffset(Offset = "0x378")]
	private bool m_IsTimelinePlaying;

	[Token(Token = "0x40018A7")]
	[FieldOffset(Offset = "0x379")]
	private bool m_StopRequested;

	[Token(Token = "0x40018A8")]
	[FieldOffset(Offset = "0x380")]
	private List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	[Token(Token = "0x40018A9")]
	[FieldOffset(Offset = "0x388")]
	private bool m_HandsReady;

	[Token(Token = "0x600170E")]
	[Address(RVA = "0x6C8040", Offset = "0x6C6E40", Length = "0xB22")]
	public void Awake()
	{
	}

	[Token(Token = "0x600170F")]
	[Address(RVA = "0x6C8B70", Offset = "0x6C7970", Length = "0xBE")]
	public void Start()
	{
	}

	[Token(Token = "0x6001710")]
	[Address(RVA = "0x6C8C30", Offset = "0x6C7A30", Length = "0x294")]
	public void SetAnimationParameter_IsInDialogue(bool isInDialogue)
	{
	}

	[Token(Token = "0x6001711")]
	[Address(RVA = "0x6C8ED0", Offset = "0x6C7CD0", Length = "0x74F")]
	public void Update()
	{
	}

	[Token(Token = "0x6001712")]
	[Address(RVA = "0x6C9620", Offset = "0x6C8420", Length = "0x4DD")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6001713")]
	[Address(RVA = "0x6C9B00", Offset = "0x6C8900", Length = "0x2AF")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001714")]
	[Address(RVA = "0x6C9DB0", Offset = "0x6C8BB0", Length = "0xF0")]
	public void OnPlayerEndedDialogue()
	{
	}

	[Token(Token = "0x6001715")]
	[Address(RVA = "0x6C9EA0", Offset = "0x6C8CA0", Length = "0x52")]
	public void SetExitRequestedAction(Action onExitRequested)
	{
	}

	[Token(Token = "0x6001716")]
	[Address(RVA = "0x6C9F00", Offset = "0x6C8D00", Length = "0xF1")]
	public void OnPlayerStartedDialogue()
	{
	}

	[Token(Token = "0x6001717")]
	[Address(RVA = "0x6CA000", Offset = "0x6C8E00", Length = "0x52")]
	public void SetDialogueController(DialogueTreeController dialogTreeController)
	{
	}

	[Token(Token = "0x6001718")]
	[Address(RVA = "0x6CA060", Offset = "0x6C8E60", Length = "0x7")]
	public void SetGroundPlayerOnEnd(bool groundPlayer)
	{
	}

	[Token(Token = "0x6001719")]
	[Address(RVA = "0x6CA070", Offset = "0x6C8E70", Length = "0x16E")]
	public void ResetDialogueController()
	{
	}

	[Token(Token = "0x600171A")]
	[Address(RVA = "0x6CA1E0", Offset = "0x6C8FE0", Length = "0x196")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x600171B")]
	[Address(RVA = "0x6CA380", Offset = "0x6C9180", Length = "0x349")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x600171C")]
	[Address(RVA = "0x6CA6D0", Offset = "0x6C94D0", Length = "0x19")]
	public void RequestExitDialogue()
	{
	}

	[Token(Token = "0x600171D")]
	[Address(RVA = "0x6CA6F0", Offset = "0x6C94F0", Length = "0x1A")]
	public bool IsInTransition()
	{
		return false;
	}

	[Token(Token = "0x600171E")]
	[Address(RVA = "0x6CA710", Offset = "0x6C9510", Length = "0xB")]
	public bool IsInIdle()
	{
		return false;
	}

	[Token(Token = "0x600171F")]
	[Address(RVA = "0x6CA720", Offset = "0x6C9520", Length = "0x8")]
	public bool CanShowDialogueUI()
	{
		return false;
	}

	[Token(Token = "0x6001720")]
	[Address(RVA = "0x6CA730", Offset = "0x6C9530", Length = "0x158")]
	public bool RespectContrainsts()
	{
		return false;
	}

	[Token(Token = "0x6001721")]
	[Address(RVA = "0x6CA890", Offset = "0x6C9690", Length = "0xB2")]
	public void SetFilter(List<DialogueOptionTopic> filter, bool clearFilter)
	{
	}

	[Token(Token = "0x6001722")]
	[Address(RVA = "0x6CA950", Offset = "0x6C9750", Length = "0x178")]
	public void OnChoiceSelected(int choiceIndex)
	{
	}

	[Token(Token = "0x6001723")]
	[Address(RVA = "0x6CAAD0", Offset = "0x6C98D0", Length = "0x52")]
	public void SetOnDialogueEndsAction(Action onDialogueEnds)
	{
	}

	[Token(Token = "0x6001724")]
	[Address(RVA = "0x6CAB30", Offset = "0x6C9930", Length = "0xB25")]
	public string GetDebugDialogueText()
	{
		return null;
	}

	[Token(Token = "0x6001725")]
	[Address(RVA = "0x6CB660", Offset = "0x6CA460", Length = "0x7")]
	public void ShowDialogueUI(bool showDialogueUI)
	{
	}

	[Token(Token = "0x6001726")]
	[Address(RVA = "0x6CB670", Offset = "0x6CA470", Length = "0x7")]
	public void EnableExitUI(bool enableExitUI)
	{
	}

	[Token(Token = "0x6001727")]
	[Address(RVA = "0x6CB680", Offset = "0x6CA480", Length = "0x8")]
	public bool IsExitUIEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001728")]
	[Address(RVA = "0x6CB690", Offset = "0x6CA490", Length = "0xC9")]
	public bool MaybeGetAssignedChoiceCategory(int choiceIndex, string locId, out Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		category = default(Dialogue_MultipleChoiceNode.ChoiceCategory);
		return false;
	}

	[Token(Token = "0x6001729")]
	[Address(RVA = "0x6CB760", Offset = "0x6CA560", Length = "0x217")]
	public bool AssignCategory(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return false;
	}

	[Token(Token = "0x600172A")]
	[Address(RVA = "0x6CB980", Offset = "0x6CA780", Length = "0x659")]
	public void LogChoices()
	{
	}

	[Token(Token = "0x600172B")]
	[Address(RVA = "0x6CBFE0", Offset = "0x6CADE0", Length = "0x38")]
	public void ReplacePlayerExit(Vector3 playerPosition, Quaternion cameraRotation, Vector3 originalCameraLocalPos)
	{
	}

	[Token(Token = "0x600172C")]
	[Address(RVA = "0x6CC020", Offset = "0x6CAE20", Length = "0x214")]
	private void OnCategoryAssigned(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[Token(Token = "0x600172D")]
	[Address(RVA = "0x6CC240", Offset = "0x6CB040", Length = "0x178")]
	private DialogueSequenceFP GetAssignedSlot(int choiceIndex)
	{
		return null;
	}

	[Token(Token = "0x600172E")]
	[Address(RVA = "0x6CC3C0", Offset = "0x6CB1C0", Length = "0x16F")]
	private DialogueChoiceInfo GetChoiceInfo(int choiceIndex)
	{
		return null;
	}

	[Token(Token = "0x600172F")]
	[Address(RVA = "0x6CC530", Offset = "0x6CB330", Length = "0x30")]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return false;
	}

	[Token(Token = "0x6001730")]
	[Address(RVA = "0x6CC570", Offset = "0x6CB370", Length = "0x1E1")]
	private void ExtractNPCMissionId()
	{
	}

	[Token(Token = "0x6001731")]
	[Address(RVA = "0x6CC760", Offset = "0x6CB560", Length = "0x105")]
	private void OnDialogueTreeFinished(DialogueTree obj)
	{
	}

	[Token(Token = "0x6001732")]
	[Address(RVA = "0x6CC870", Offset = "0x6CB670", Length = "0x7")]
	private void OnDialogueTreeStarted(DialogueTree obj)
	{
	}

	[Token(Token = "0x6001733")]
	[Address(RVA = "0x6CC880", Offset = "0x6CB680", Length = "0x2F1")]
	private void EnableDialogueSequenceFP(bool enabled)
	{
	}

	[Token(Token = "0x6001734")]
	[Address(RVA = "0x6CCB80", Offset = "0x6CB980", Length = "0xFF")]
	private void LimitCameraRotation()
	{
	}

	[Token(Token = "0x6001735")]
	[Address(RVA = "0x6CCC80", Offset = "0x6CBA80", Length = "0x39C")]
	private void UnloadAnimations()
	{
	}

	[Token(Token = "0x6001736")]
	[Address(RVA = "0x6CD020", Offset = "0x6CBE20", Length = "0x538")]
	private DialogueSequenceFP AssignChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex, float textSize)
	{
		return null;
	}

	[Token(Token = "0x6001737")]
	[Address(RVA = "0x6CD560", Offset = "0x6CC360", Length = "0x17B")]
	private DialogueSequenceFP GetAvailableSlotForCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return null;
	}

	[Token(Token = "0x6001738")]
	[Address(RVA = "0x6CD6E0", Offset = "0x6CC4E0", Length = "0xE")]
	private Dialogue_MultipleChoiceNode.ChoiceCategory GetFallbackSlotCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return default(Dialogue_MultipleChoiceNode.ChoiceCategory);
	}

	[Token(Token = "0x6001739")]
	[Address(RVA = "0x6CD6F0", Offset = "0x6CC4F0", Length = "0x227")]
	private DialogueChoiceCategoryConfiguration GetCategoryConfiguration(Dialogue_MultipleChoiceNode.ChoiceCategory choiceCategory)
	{
		return null;
	}

	[Token(Token = "0x600173A")]
	[Address(RVA = "0x6CD920", Offset = "0x6CC720", Length = "0x191")]
	private void AssignHiddenChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex)
	{
	}

	[Token(Token = "0x600173B")]
	[Address(RVA = "0x6CDAC0", Offset = "0x6CC8C0", Length = "0x528")]
	private void UpdateChoiceAssignment()
	{
	}

	[Token(Token = "0x600173C")]
	[Address(RVA = "0x6CDFF0", Offset = "0x6CCDF0", Length = "0x316")]
	internal void SetDialogueTreeChoices(List<Dialogue_MultipleChoiceNode.Choice> dialogueChoices, int loopBackIndex)
	{
	}

	[Token(Token = "0x600173D")]
	[Address(RVA = "0x6CE310", Offset = "0x6CD110", Length = "0x9B")]
	private bool IsChoiceAcceptedByFilter(DialogueOptionTopic topic)
	{
		return false;
	}

	[Token(Token = "0x600173E")]
	[Address(RVA = "0x6CE3B0", Offset = "0x6CD1B0", Length = "0xC5")]
	private uint PostAudioEvent(string soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x600173F")]
	[Address(RVA = "0x6CE480", Offset = "0x6CD280", Length = "0x1A1")]
	private void StopPreviousAudio()
	{
	}

	[Token(Token = "0x6001740")]
	[Address(RVA = "0x6CE630", Offset = "0x6CD430", Length = "0xE7")]
	public void SetDialogueModeState(DialogueModeState dialogueModeState)
	{
	}

	[Token(Token = "0x6001741")]
	[Address(RVA = "0x6CE720", Offset = "0x6CD520", Length = "0x11B")]
	public Animator GetNPCAnimator()
	{
		return null;
	}

	[Token(Token = "0x6001742")]
	[Address(RVA = "0x6CE840", Offset = "0x6CD640", Length = "0x18E")]
	private void ReplaceFPController(DialogueControllerMode dialogueControllerMode)
	{
	}

	[Token(Token = "0x6001743")]
	[Address(RVA = "0x6CE9D0", Offset = "0x6CD7D0", Length = "0x31A")]
	private void ReplaceAnimControllerAndResumeState(DialogueControllerMode dialogueControllerMode)
	{
	}

	[Token(Token = "0x6001744")]
	[Address(RVA = "0x6CECF0", Offset = "0x6CDAF0", Length = "0x263")]
	private void CheckLastAnimationRestore()
	{
	}

	[Token(Token = "0x6001745")]
	[Address(RVA = "0x6CEF60", Offset = "0x6CDD60", Length = "0x73")]
	private void SetCameraFov()
	{
	}

	[Token(Token = "0x6001746")]
	[Address(RVA = "0x6CEFE0", Offset = "0x6CDDE0", Length = "0x13F")]
	private bool IsStatePlaying(int stateHash)
	{
		return false;
	}

	[Token(Token = "0x6001747")]
	[Address(RVA = "0x6CF120", Offset = "0x6CDF20", Length = "0x57F")]
	private void ReturnToIdleAnimation()
	{
	}

	[Token(Token = "0x6001748")]
	[Address(RVA = "0x6CF6A0", Offset = "0x6CE4A0", Length = "0x8")]
	private void OnEnter_DialogueModeStateEnd()
	{
	}

	[Token(Token = "0x6001749")]
	[Address(RVA = "0x6CF6B0", Offset = "0x6CE4B0", Length = "0x3EC")]
	private void ExitDialogueMode()
	{
	}

	[Token(Token = "0x600174A")]
	[Address(RVA = "0x6CFAA0", Offset = "0x6CE8A0", Length = "0x45D")]
	private void OnEnter_DialogueModeStateStart()
	{
	}

	[Token(Token = "0x600174B")]
	[Address(RVA = "0x6CFF00", Offset = "0x6CED00", Length = "0x1CB")]
	private void DisableDialogue()
	{
	}

	[Token(Token = "0x600174C")]
	[Address(RVA = "0x6D00D0", Offset = "0x6CEED0", Length = "0x16A")]
	private void Update_DialogueModeStateEnd()
	{
	}

	[Token(Token = "0x600174D")]
	[Address(RVA = "0x6D0240", Offset = "0x6CF040", Length = "0x7")]
	private void OnEnter_DialogueModeStateNone()
	{
	}

	[Token(Token = "0x600174E")]
	[Address(RVA = "0x6D0240", Offset = "0x6CF040", Length = "0x7")]
	private void Update_DialogueModeStateNone()
	{
	}

	[Token(Token = "0x600174F")]
	[Address(RVA = "0x6D0250", Offset = "0x6CF050", Length = "0x3C")]
	private void Update_DialogueModeStateStart()
	{
	}

	[Token(Token = "0x6001750")]
	[Address(RVA = "0x6D0290", Offset = "0x6CF090", Length = "0x25A")]
	private Vector3 GetCharacterDesiredPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001751")]
	[Address(RVA = "0x6D04F0", Offset = "0x6CF2F0", Length = "0xD4")]
	private Quaternion GetCameraDesiredRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6001752")]
	[Address(RVA = "0x6D05D0", Offset = "0x6CF3D0", Length = "0x4A")]
	private Vector3 GetReferenceCameraForward()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001753")]
	[Address(RVA = "0x6D0620", Offset = "0x6CF420", Length = "0x4A")]
	private Vector3 GetReferenceCameraRight()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001754")]
	[Address(RVA = "0x6D0670", Offset = "0x6CF470", Length = "0xE0")]
	private Vector3 GetCameraDesiredLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001755")]
	[Address(RVA = "0x6D0760", Offset = "0x6CF560", Length = "0x2D")]
	private int GetCurrentNPCIdleStateHash()
	{
		return 0;
	}

	[Token(Token = "0x6001756")]
	[Address(RVA = "0x6D0790", Offset = "0x6CF590", Length = "0x2F7")]
	private List<IdlePropInfo> GetCurrentIdlePropInfos()
	{
		return null;
	}

	[Token(Token = "0x6001757")]
	[Address(RVA = "0x6D0A90", Offset = "0x6CF890", Length = "0x216")]
	private void RestoreCurrentPermamentPropIdle(CinematicAssets.PermanentPropInfo permanentProp, List<IdlePropInfo> currentIdlePropInfos)
	{
	}

	[Token(Token = "0x6001758")]
	[Address(RVA = "0x6D0CB0", Offset = "0x6CFAB0", Length = "0x2ED")]
	private void RestoreCurrentIdleDialogueModeRigFp(int currentNpcIdleStateHash, List<IdlePropInfo> currentIdlePropInfos)
	{
	}

	[Token(Token = "0x6001759")]
	[Address(RVA = "0x6D0FA0", Offset = "0x6CFDA0", Length = "0x21")]
	private void RequestCameraTransition(float transitionDurationSeconds)
	{
	}

	[Token(Token = "0x600175A")]
	[Address(RVA = "0x6D0FD0", Offset = "0x6CFDD0", Length = "0x53")]
	public static DialogueModeRigFP GetCurrent()
	{
		return null;
	}

	[Token(Token = "0x600175B")]
	[Address(RVA = "0x6D1030", Offset = "0x6CFE30", Length = "0x524")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x600175C")]
	[Address(RVA = "0x6D1560", Offset = "0x6D0360", Length = "0x33A")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x600175D")]
	[Address(RVA = "0x6D18A0", Offset = "0x6D06A0", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600175E")]
	[Address(RVA = "0x6D1940", Offset = "0x6D0740", Length = "0x7F")]
	public static void QuitGame()
	{
	}

	[Token(Token = "0x600175F")]
	[Address(RVA = "0x6D19C0", Offset = "0x6D07C0", Length = "0x274")]
	public static DialogueModeRigFP FindDialogueModeRigFp(string NPC_MissionId)
	{
		return null;
	}

	[Token(Token = "0x6001760")]
	[Address(RVA = "0x6D1C40", Offset = "0x6D0A40", Length = "0x2F")]
	private void UpdateChoicesAfterFilterChange()
	{
	}

	[Token(Token = "0x6001761")]
	[Address(RVA = "0x6D1C70", Offset = "0x6D0A70", Length = "0x357")]
	private void UpdateFromUnderCrosshair()
	{
	}

	[Token(Token = "0x6001762")]
	[Address(RVA = "0x6D1FD0", Offset = "0x6D0DD0", Length = "0xE5")]
	private void UpdateClosestToCenter()
	{
	}

	[Token(Token = "0x6001763")]
	[Address(RVA = "0x6D20C0", Offset = "0x6D0EC0", Length = "0x203")]
	private void ProcessSelectionConfirm()
	{
	}

	[Token(Token = "0x6001764")]
	[Address(RVA = "0x6D22D0", Offset = "0x6D10D0", Length = "0x2A3")]
	private void OnEnter_DialogueModeStateIdle()
	{
	}

	[Token(Token = "0x6001765")]
	[Address(RVA = "0x6D2580", Offset = "0x6D1380", Length = "0x138")]
	private void Update_DialogueModeStateIdle()
	{
	}

	[Token(Token = "0x6001766")]
	[Address(RVA = "0x6D26C0", Offset = "0x6D14C0", Length = "0xF8")]
	public void Update_DialogueModeStateIdleUI()
	{
	}

	[Token(Token = "0x6001767")]
	[Address(RVA = "0x6D27C0", Offset = "0x6D15C0", Length = "0x580")]
	public void OnSpeech(string meta, Action onStatementFinish, string subtitlesText, IDialogueActor dialogueActor, VoiceOverItem voiceOverItem)
	{
	}

	[Token(Token = "0x6001768")]
	[Address(RVA = "0x6D2D50", Offset = "0x6D1B50", Length = "0x4BE")]
	private void MaybeAutoAssignDialogueAnimationAndAudio(DialogueStatement dialogueStatement, string locId)
	{
	}

	[Token(Token = "0x6001769")]
	[Address(RVA = "0x6D3210", Offset = "0x6D2010", Length = "0xBCF")]
	public void OnCinematicPlay(DialogueAnimationState dialogueAnimationState, string audioStart, string audioEnd, Action onCinematicFinish, TextAsset subtitleAsset)
	{
	}

	[Token(Token = "0x600176A")]
	[Address(RVA = "0x6D3DE0", Offset = "0x6D2BE0", Length = "0x2F3")]
	public void OnTimelinePlay(DialogueTimelineScript dialogueTimelineScript, Action onCinematicFinish)
	{
	}

	[Token(Token = "0x600176B")]
	[Address(RVA = "0x6D40E0", Offset = "0x6D2EE0", Length = "0x8")]
	public bool CanApplyCameraMotionToJoint()
	{
		return false;
	}

	[Token(Token = "0x600176C")]
	[Address(RVA = "0x6D40F0", Offset = "0x6D2EF0", Length = "0x1CA")]
	public void ReplaceCameraFraming(string cameraFraming)
	{
	}

	[Token(Token = "0x600176D")]
	[Address(RVA = "0x6D42C0", Offset = "0x6D30C0", Length = "0x230")]
	private void ReplaceSavedPosition(string cameraFraming)
	{
	}

	[Token(Token = "0x600176E")]
	[Address(RVA = "0x6D4500", Offset = "0x6D3300", Length = "0x126")]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return 0f;
	}

	[Token(Token = "0x600176F")]
	[Address(RVA = "0x6D4630", Offset = "0x6D3430", Length = "0x7E")]
	private string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x6001770")]
	[Address(RVA = "0x6D46B0", Offset = "0x6D34B0", Length = "0x7E")]
	private string GePrefabPath(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x6001771")]
	[Address(RVA = "0x6D4730", Offset = "0x6D3530", Length = "0x18B")]
	private bool IsAnimationAlreadyLoaded(string stateKey)
	{
		return false;
	}

	[Token(Token = "0x6001772")]
	[Address(RVA = "0x6D48C0", Offset = "0x6D36C0", Length = "0xA3")]
	private bool IsAnimationLoadingRequired()
	{
		return false;
	}

	[Token(Token = "0x6001773")]
	[Address(RVA = "0x6D4970", Offset = "0x6D3770", Length = "0xFB")]
	private void AbortLoad()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAnimations_003Ed__250))]
	[Token(Token = "0x6001774")]
	[Address(RVA = "0x6D4A70", Offset = "0x6D3870", Length = "0xF7")]
	private IEnumerator LoadAnimations(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x6001775")]
	[Address(RVA = "0x6D4B70", Offset = "0x6D3970", Length = "0xC4")]
	private bool AreAssetsReady()
	{
		return false;
	}

	[Token(Token = "0x6001776")]
	[Address(RVA = "0x6D4C40", Offset = "0x6D3A40", Length = "0x5C6")]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[Token(Token = "0x6001777")]
	[Address(RVA = "0x6D5210", Offset = "0x6D4010", Length = "0x433")]
	private void OnEnter_DialogueModeStateLoadSequence()
	{
	}

	[Token(Token = "0x6001778")]
	[Address(RVA = "0x6D5650", Offset = "0x6D4450", Length = "0x222")]
	private void Update_DialogueModeStateLoadSequence()
	{
	}

	[Token(Token = "0x6001779")]
	[Address(RVA = "0x6D5880", Offset = "0x6D4680", Length = "0x98")]
	private void OnLoadTimelineCompleted(AssetReferenceTimeline result)
	{
	}

	[Token(Token = "0x600177A")]
	[Address(RVA = "0x6D5920", Offset = "0x6D4720", Length = "0x25E")]
	private void UnloadTimeline()
	{
	}

	[Token(Token = "0x600177B")]
	[Address(RVA = "0x6D5B80", Offset = "0x6D4980", Length = "0xC")]
	private bool IsTimelineRequested()
	{
		return false;
	}

	[Token(Token = "0x600177C")]
	[Address(RVA = "0x6D5B90", Offset = "0x6D4990", Length = "0x41")]
	public bool ShouldSupressBreathFXForTimeline()
	{
		return false;
	}

	[Token(Token = "0x600177D")]
	[Address(RVA = "0x6D5BE0", Offset = "0x6D49E0", Length = "0x186")]
	public static string GetDefaultStateNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[Token(Token = "0x600177E")]
	[Address(RVA = "0x6D5D70", Offset = "0x6D4B70", Length = "0x186")]
	public static string GetDefaultTimelineNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[Token(Token = "0x600177F")]
	[Address(RVA = "0x6D5F00", Offset = "0x6D4D00", Length = "0x11C")]
	public static string GetDefaultLocIdForDialogueLineFromTimeline(string timelineName)
	{
		return null;
	}

	[Token(Token = "0x6001780")]
	[Address(RVA = "0x6D6020", Offset = "0x6D4E20", Length = "0x122")]
	public static string GetDefaultAudioStartForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[Token(Token = "0x6001781")]
	[Address(RVA = "0x6D6150", Offset = "0x6D4F50", Length = "0x40F")]
	private void PlayCinematic()
	{
	}

	[Token(Token = "0x6001782")]
	[Address(RVA = "0x6D6560", Offset = "0x6D5360", Length = "0x2E6")]
	private void OnEnter_DialogueModeStatePlayCinematic()
	{
	}

	[Token(Token = "0x6001783")]
	[Address(RVA = "0x6D6850", Offset = "0x6D5650", Length = "0xE8")]
	private void SetHudModeForCinematic()
	{
	}

	[Token(Token = "0x6001784")]
	[Address(RVA = "0x6D6940", Offset = "0x6D5740", Length = "0x8F3")]
	private void Update_DialogueModeStatePlayCinematic()
	{
	}

	[Token(Token = "0x6001785")]
	[Address(RVA = "0x6D7240", Offset = "0x6D6040", Length = "0xF8")]
	private void OnCinematicDone()
	{
	}

	[Token(Token = "0x6001786")]
	[Address(RVA = "0x6D7340", Offset = "0x6D6140", Length = "0x352")]
	private void OnEnter_DialogueModeStatePlayCinematicComplete()
	{
	}

	[Token(Token = "0x6001787")]
	[Address(RVA = "0x6D76A0", Offset = "0x6D64A0", Length = "0x244")]
	private void Update_DialogueModeStatePlayCinematicComplete()
	{
	}

	[Token(Token = "0x6001788")]
	[Address(RVA = "0x6D78F0", Offset = "0x6D66F0", Length = "0x18")]
	public void DialogueNext()
	{
	}

	[Token(Token = "0x6001789")]
	[Address(RVA = "0x6D7910", Offset = "0x6D6710", Length = "0x9")]
	public void SetAudioDurationRealtimeSeconds(float duration)
	{
	}

	[Token(Token = "0x600178A")]
	[Address(RVA = "0x6D7920", Offset = "0x6D6720", Length = "0x71")]
	private string GetTriggeredByName(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x600178B")]
	[Address(RVA = "0x6D79A0", Offset = "0x6D67A0", Length = "0x71")]
	private string GetTriggerIdle(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x600178C")]
	[Address(RVA = "0x6D7A20", Offset = "0x6D6820", Length = "0x71")]
	private string GetStateIdle(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x600178D")]
	[Address(RVA = "0x6D7AA0", Offset = "0x6D68A0", Length = "0x75")]
	private int GetLayerIndex(string stateKey)
	{
		return 0;
	}

	[Token(Token = "0x600178E")]
	[Address(RVA = "0x6D7B20", Offset = "0x6D6920", Length = "0x97")]
	private bool IsAnimationRequested()
	{
		return false;
	}

	[Token(Token = "0x600178F")]
	[Address(RVA = "0x6D7BC0", Offset = "0x6D69C0", Length = "0x2A2")]
	private void PlayAudio(string audioEventStart, string audioEventStop)
	{
	}

	[Token(Token = "0x6001790")]
	[Address(RVA = "0x6D7E70", Offset = "0x6D6C70", Length = "0x703")]
	private void LerpCameraFramingToDesired(float normalizedProgress)
	{
	}

	[Token(Token = "0x6001791")]
	[Address(RVA = "0x6D8580", Offset = "0x6D7380", Length = "0x13F")]
	private void RecenterCameraToDesired()
	{
	}

	[Token(Token = "0x6001792")]
	[Address(RVA = "0x6D86C0", Offset = "0x6D74C0", Length = "0x3D8")]
	private bool IsCameraCentered()
	{
		return false;
	}

	[Token(Token = "0x6001793")]
	[Address(RVA = "0x6D8AA0", Offset = "0x6D78A0", Length = "0x48F")]
	private void PlayDialogueAnimation()
	{
	}

	[Token(Token = "0x6001794")]
	[Address(RVA = "0x6D8F30", Offset = "0x6D7D30", Length = "0x84")]
	private bool IsFPHPlayingIdle()
	{
		return false;
	}

	[Token(Token = "0x6001795")]
	[Address(RVA = "0x6D8FC0", Offset = "0x6D7DC0", Length = "0x2C")]
	private bool IsTransitionDone()
	{
		return false;
	}

	[Token(Token = "0x6001796")]
	[Address(RVA = "0x6D8FF0", Offset = "0x6D7DF0", Length = "0x9C")]
	private void Update_CameraControl()
	{
	}

	[Token(Token = "0x6001797")]
	[Address(RVA = "0x6D9090", Offset = "0x6D7E90", Length = "0xBA")]
	private float GetOnGoingStateDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6001798")]
	[Address(RVA = "0x6D9150", Offset = "0x6D7F50", Length = "0x4F4")]
	private void LateSynchronizeAnimators(float currentTime, int stateHash)
	{
	}

	[Token(Token = "0x6001799")]
	[Address(RVA = "0x6D9650", Offset = "0x6D8450", Length = "0x19")]
	private void OnCurrentFPHAnimatorStoppedPlaying()
	{
	}

	[Token(Token = "0x600179A")]
	[Address(RVA = "0x6D9670", Offset = "0x6D8470", Length = "0x3B")]
	private bool IsCinematicOrNotAnimatedStatement()
	{
		return false;
	}

	[Token(Token = "0x600179B")]
	[Address(RVA = "0x6D96B0", Offset = "0x6D84B0", Length = "0x2A8")]
	private void OnEnter_DialogueModeStatePlayLine()
	{
	}

	[Token(Token = "0x600179C")]
	[Address(RVA = "0x6D9960", Offset = "0x6D8760", Length = "0x15F")]
	private void DoNextStatement()
	{
	}

	[Token(Token = "0x600179D")]
	[Address(RVA = "0x6D9AC0", Offset = "0x6D88C0", Length = "0xE9")]
	private void OnNextDialogueRequested()
	{
	}

	[Token(Token = "0x600179E")]
	[Address(RVA = "0x6D9BB0", Offset = "0x6D89B0", Length = "0xD6")]
	private void ProcessAfterDuration()
	{
	}

	[Token(Token = "0x600179F")]
	[Address(RVA = "0x6D9C90", Offset = "0x6D8A90", Length = "0x9")]
	private float GetCinematicDuration()
	{
		return 0f;
	}

	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x6D9CA0", Offset = "0x6D8AA0", Length = "0x83")]
	private void MaybeUpdateIndividualLineDuration()
	{
	}

	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x6D9D30", Offset = "0x6D8B30", Length = "0x637")]
	private void Update_DialogueModeStatePlayLine()
	{
	}

	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x6DA370", Offset = "0x6D9170", Length = "0x8")]
	private void OnEnter_DialogueModeStatePlayLineComplete()
	{
	}

	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x6DA380", Offset = "0x6D9180", Length = "0x128")]
	private void Update_DialogueModeStatePlayLineComplete()
	{
	}

	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x6DA4B0", Offset = "0x6D92B0", Length = "0x193")]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x60017A5")]
	[Address(RVA = "0x6DA650", Offset = "0x6D9450", Length = "0x18D")]
	public void AssignTimelineOverride(string trackName, GameObject target)
	{
	}

	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x6DA7E0", Offset = "0x6D95E0", Length = "0x23D")]
	private void OnEnter_DialogueModeStateTimeline()
	{
	}

	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x6DAA20", Offset = "0x6D9820", Length = "0x2B2")]
	private void Update_DialogueModeStateTimeline()
	{
	}

	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x6DACE0", Offset = "0x6D9AE0", Length = "0x8B")]
	private void TimelineIndividualLineCompleted()
	{
	}

	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x6DAD70", Offset = "0x6D9B70", Length = "0x8")]
	private void OnTimelineStopped()
	{
	}

	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x6DAD80", Offset = "0x6D9B80", Length = "0x124E")]
	private void OnEnter_DialogueModeStateTransitionIn()
	{
	}

	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x6DBFD0", Offset = "0x6DADD0", Length = "0x21A")]
	private void MaybeStowItemInHand()
	{
	}

	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x6DC1F0", Offset = "0x6DAFF0", Length = "0xA6")]
	private bool IsNPCReady()
	{
		return false;
	}

	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x6DC2A0", Offset = "0x6DB0A0", Length = "0x149")]
	private bool AreHandsReady()
	{
		return false;
	}

	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x6DC3F0", Offset = "0x6DB1F0", Length = "0x8")]
	private void OnItemInHandStowed()
	{
	}

	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x6DC400", Offset = "0x6DB200", Length = "0x695")]
	private void Update_DialogueModeStateTransitionIn()
	{
	}

	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x6DCAA0", Offset = "0x6DB8A0", Length = "0x527")]
	private static void LerpPlayer(float progress, Vector3 originalPlayerPosition, Quaternion originalCameraRotation, Vector3 originalLocalCameraPosition, float originalFov, Vector3 desiredPlayerPosition, Quaternion desiredCameraRotation, Vector3 desireedLocalCameraPosition, float desiredFov)
	{
	}

	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x6DCFD0", Offset = "0x6DBDD0", Length = "0x45A")]
	private void OnEnter_DialogueModeStateTransitionOut()
	{
	}

	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x6DD430", Offset = "0x6DC230", Length = "0x410")]
	private void Update_DialogueModeStateTransitionOut()
	{
	}

	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x6DD850", Offset = "0x6DC650", Length = "0x501")]
	public DialogueModeRigFP()
	{
	}
}
