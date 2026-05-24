using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200088D")]
public class CinematicTrack
{
	[Token(Token = "0x200088E")]
	public enum MasterAnimatorType
	{
		[Token(Token = "0x400585A")]
		NPC,
		[Token(Token = "0x400585B")]
		FP
	}

	[Token(Token = "0x200088F")]
	public delegate void OnEnterPlaying(bool success);

	[Token(Token = "0x2000890")]
	private enum State
	{
		[Token(Token = "0x400585D")]
		None,
		[Token(Token = "0x400585E")]
		Loading,
		[Token(Token = "0x400585F")]
		Playing,
		[Token(Token = "0x4005860")]
		Complete
	}

	[CompilerGenerated]
	[Token(Token = "0x2000891")]
	private sealed class _003CLoadAnimations_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005861")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005862")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005863")]
		[FieldOffset(Offset = "0x20")]
		public CinematicTrack _003C_003E4__this;

		[Token(Token = "0x4005864")]
		[FieldOffset(Offset = "0x28")]
		public string assetBundleFilename;

		[Token(Token = "0x4005865")]
		[FieldOffset(Offset = "0x30")]
		public string prefabPath;

		[Token(Token = "0x4005866")]
		[FieldOffset(Offset = "0x38")]
		private AssetBundleRefRequest _003Crequest_003E5__2;

		[Token(Token = "0x17000361")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004E3E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000362")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004E40")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CLoadAnimations_003Ed__66(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0xDA02B0", Offset = "0xD9F0B0", Length = "0xC55")]
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
		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0xDA0F10", Offset = "0xD9FD10", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400582D")]
	[FieldOffset(Offset = "0x10")]
	private MasterAnimatorType m_MasterAnimatorType;

	[Token(Token = "0x400582E")]
	[FieldOffset(Offset = "0x18")]
	private OnEnterPlaying m_OnEnterPlaying;

	[Token(Token = "0x400582F")]
	[FieldOffset(Offset = "0x20")]
	private string m_NPCID;

	[Token(Token = "0x4005830")]
	[FieldOffset(Offset = "0x28")]
	private TextAsset m_SubtitlesAsset;

	[Token(Token = "0x4005831")]
	[FieldOffset(Offset = "0x30")]
	private string m_LoadedAssetBundleFilename;

	[Token(Token = "0x4005832")]
	[FieldOffset(Offset = "0x38")]
	private string m_LoadedPrefabPath;

	[Token(Token = "0x4005833")]
	[FieldOffset(Offset = "0x40")]
	private AssetBundleRef m_AssetBundle;

	[Token(Token = "0x4005834")]
	[FieldOffset(Offset = "0x48")]
	private CinematicAssets m_CinematicAssets;

	[Token(Token = "0x4005835")]
	[FieldOffset(Offset = "0x50")]
	private bool m_AnimationsLoadingComplete;

	[Token(Token = "0x4005836")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_AnimationsAsset;

	[Token(Token = "0x4005837")]
	[FieldOffset(Offset = "0x60")]
	private Animator m_CurrentFPHAnimator;

	[Token(Token = "0x4005838")]
	[FieldOffset(Offset = "0x68")]
	private Animator m_CurrentNPCAnimator;

	[Token(Token = "0x4005839")]
	[FieldOffset(Offset = "0x70")]
	private RuntimeAnimatorController m_OriginalFPHRuntimeAnimatorController;

	[Token(Token = "0x400583A")]
	[FieldOffset(Offset = "0x78")]
	private RuntimeAnimatorController m_OriginalNPCRuntimeAnimatorController;

	[Token(Token = "0x400583B")]
	[FieldOffset(Offset = "0x80")]
	private State m_State;

	[Token(Token = "0x400583C")]
	[FieldOffset(Offset = "0x88")]
	private string m_AudioEventStart;

	[Token(Token = "0x400583D")]
	[FieldOffset(Offset = "0x90")]
	private float m_CurrentAnimationTime;

	[Token(Token = "0x400583E")]
	[FieldOffset(Offset = "0x98")]
	private string m_StateName;

	[Token(Token = "0x400583F")]
	[FieldOffset(Offset = "0xA0")]
	private string m_OnGoingAnimationStateKey;

	[Token(Token = "0x4005840")]
	[FieldOffset(Offset = "0xA8")]
	private Utils.Subtitle[] m_Subtitles;

	[Token(Token = "0x4005841")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_NumSubtitles;

	[Token(Token = "0x4005842")]
	[FieldOffset(Offset = "0xB4")]
	private int m_OnGoingAnimationState;

	[Token(Token = "0x4005843")]
	[FieldOffset(Offset = "0xB8")]
	private int m_FPBaseLayerIndex;

	[Token(Token = "0x4005844")]
	[FieldOffset(Offset = "0xBC")]
	private int m_NPCBaseLayerIndex;

	[Token(Token = "0x4005845")]
	[FieldOffset(Offset = "0xC0")]
	private float m_OnGoingAnimationDuration;

	[Token(Token = "0x4005846")]
	private static float s_AudioDurationRealtimeSeconds;

	[Token(Token = "0x4005847")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_AudioID;

	[Token(Token = "0x4005848")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject m_AudioEmitterNode;

	[Token(Token = "0x4005849")]
	[FieldOffset(Offset = "0xD0")]
	private List<CinematicAssets.PermanentPropInfo> m_PermanentProps;

	[Token(Token = "0x400584A")]
	[FieldOffset(Offset = "0xD8")]
	private Animator m_LoadedNPCAnimator;

	[Token(Token = "0x400584B")]
	[FieldOffset(Offset = "0xE0")]
	private Animator m_LoadedFPHAnimator;

	[Token(Token = "0x400584C")]
	[FieldOffset(Offset = "0xE8")]
	private PlayEventMonitor m_FPPlayEventMonitor;

	[Token(Token = "0x400584D")]
	[FieldOffset(Offset = "0xF0")]
	private PlayEventMonitor m_NPCPlayEventMonitor;

	[Token(Token = "0x400584E")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_CurrentNPCAnimatorPlaying;

	[Token(Token = "0x400584F")]
	[FieldOffset(Offset = "0xF9")]
	private bool m_CurrentFPHAnimatorPlaying;

	[Token(Token = "0x4005850")]
	[FieldOffset(Offset = "0xFC")]
	private int m_PendingIdleHash;

	[Token(Token = "0x4005851")]
	[FieldOffset(Offset = "0x100")]
	private int m_PendingIdleLayer;

	[Token(Token = "0x4005852")]
	[FieldOffset(Offset = "0x104")]
	private bool m_IsIdlePending;

	[Token(Token = "0x4005853")]
	[FieldOffset(Offset = "0x105")]
	private bool m_ShouldLockPlayer;

	[Token(Token = "0x4005854")]
	[FieldOffset(Offset = "0x106")]
	private bool m_RestoreControllers;

	[Token(Token = "0x4005855")]
	[FieldOffset(Offset = "0x107")]
	private bool m_FadedOutOnExit;

	[Token(Token = "0x4005856")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 m_WorldSpaceViewPositionAtStart;

	[Token(Token = "0x4005857")]
	[FieldOffset(Offset = "0x114")]
	private Quaternion m_WorldSpaceViewRotationAtStart;

	[Token(Token = "0x4005858")]
	[FieldOffset(Offset = "0x124")]
	private bool m_UseMotionFromRef;

	[Token(Token = "0x6004E10")]
	[Address(RVA = "0xD9BF80", Offset = "0xD9AD80", Length = "0x44D")]
	private CinematicTrack(string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode)
	{
	}

	[Token(Token = "0x6004E11")]
	[Address(RVA = "0xD9C3D0", Offset = "0xD9B1D0", Length = "0x16C")]
	public static CinematicTrack CreateFPCinematicTrack(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, OnEnterPlaying onEnterPlaying)
	{
		return null;
	}

	[Token(Token = "0x6004E12")]
	[Address(RVA = "0xD9C540", Offset = "0xD9B340", Length = "0x104")]
	public static CinematicTrack CreateNPCCinematicTrack(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode)
	{
		return null;
	}

	[Token(Token = "0x6004E13")]
	[Address(RVA = "0xD9C650", Offset = "0xD9B450", Length = "0x62")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6004E14")]
	[Address(RVA = "0xD9C6C0", Offset = "0xD9B4C0", Length = "0xB")]
	public bool IsUnused()
	{
		return false;
	}

	[Token(Token = "0x6004E15")]
	[Address(RVA = "0xD9C6D0", Offset = "0xD9B4D0", Length = "0x14")]
	public bool ShouldLockPlayer()
	{
		return false;
	}

	[Token(Token = "0x6004E16")]
	[Address(RVA = "0xD9C6F0", Offset = "0xD9B4F0", Length = "0x7")]
	public void SetShouldLockPLayer(bool shouldLockPLayer)
	{
	}

	[Token(Token = "0x6004E17")]
	[Address(RVA = "0xD9C700", Offset = "0xD9B500", Length = "0x7")]
	public void SetFadedOutOnExit(bool fadedOutOnExit)
	{
	}

	[Token(Token = "0x6004E18")]
	[Address(RVA = "0xD9C710", Offset = "0xD9B510", Length = "0xB")]
	public bool IsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6004E19")]
	[Address(RVA = "0x85DE90", Offset = "0x85CC90", Length = "0xB")]
	public bool IsLoading()
	{
		return false;
	}

	[Token(Token = "0x6004E1A")]
	[Address(RVA = "0xD9C720", Offset = "0xD9B520", Length = "0x2B8")]
	public void Play()
	{
	}

	[Token(Token = "0x6004E1B")]
	[Address(RVA = "0xD9C9E0", Offset = "0xD9B7E0", Length = "0x4F1")]
	private void LoadCinematicAsync(string assetBundleFilemame, string prefabPath, TextAsset subtitleAsset)
	{
	}

	[Token(Token = "0x6004E1C")]
	[Address(RVA = "0xD9CEE0", Offset = "0xD9BCE0", Length = "0x49E")]
	public void Update()
	{
	}

	[Token(Token = "0x6004E1D")]
	[Address(RVA = "0xD9C6C0", Offset = "0xD9B4C0", Length = "0xB")]
	public bool IsReady()
	{
		return false;
	}

	[Token(Token = "0x6004E1E")]
	[Address(RVA = "0xD9D380", Offset = "0xD9C180", Length = "0xE1")]
	private bool IsWaitingForIdle()
	{
		return false;
	}

	[Token(Token = "0x6004E1F")]
	[Address(RVA = "0xD9D470", Offset = "0xD9C270", Length = "0x79")]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return false;
	}

	[Token(Token = "0x6004E20")]
	[Address(RVA = "0xD9D4F0", Offset = "0xD9C2F0", Length = "0x79")]
	private bool IsFPStatePlaying(int hashState, int layer)
	{
		return false;
	}

	[Token(Token = "0x6004E21")]
	[Address(RVA = "0xD9D570", Offset = "0xD9C370", Length = "0x2D6")]
	private void UnloadCinematic()
	{
	}

	[Token(Token = "0x6004E22")]
	[Address(RVA = "0xD9D850", Offset = "0xD9C650", Length = "0x157")]
	private void EnterPlaying()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAnimations_003Ed__66))]
	[Token(Token = "0x6004E23")]
	[Address(RVA = "0xD9D9B0", Offset = "0xD9C7B0", Length = "0x15C")]
	public IEnumerator LoadAnimations(string assetBundleFilename, string prefabPath)
	{
		return null;
	}

	[Token(Token = "0x6004E24")]
	[Address(RVA = "0xD9DB10", Offset = "0xD9C910", Length = "0x496")]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[Token(Token = "0x6004E25")]
	[Address(RVA = "0xD9DFB0", Offset = "0xD9CDB0", Length = "0x10F")]
	private void SwapNPCController(RuntimeAnimatorController controller)
	{
	}

	[Token(Token = "0x6004E26")]
	[Address(RVA = "0xD9E0C0", Offset = "0xD9CEC0", Length = "0x243")]
	private void SaveOriginalControllers()
	{
	}

	[Token(Token = "0x6004E27")]
	[Address(RVA = "0xD9E310", Offset = "0xD9D110", Length = "0xEF")]
	private bool AreAssetsReady()
	{
		return false;
	}

	[Token(Token = "0x6004E28")]
	[Address(RVA = "0xD9E400", Offset = "0xD9D200", Length = "0x22")]
	private void AbortLoad()
	{
	}

	[Token(Token = "0x6004E29")]
	[Address(RVA = "0xD9E430", Offset = "0xD9D230", Length = "0x91")]
	private float GetOnGoingStateDuration(MasterAnimatorType masterAnimatorType)
	{
		return 0f;
	}

	[Token(Token = "0x6004E2A")]
	[Address(RVA = "0x557970", Offset = "0x556770", Length = "0x9")]
	private float GetCinematicDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6004E2B")]
	[Address(RVA = "0xD9E4D0", Offset = "0xD9D2D0", Length = "0xAF")]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6004E2C")]
	[Address(RVA = "0xD9E580", Offset = "0xD9D380", Length = "0x343")]
	private void PlayAudio(string audioEventStart)
	{
	}

	[Token(Token = "0x6004E2D")]
	[Address(RVA = "0xD9E8D0", Offset = "0xD9D6D0", Length = "0x29D")]
	private void LateSynchronizeAnimatorsNPC(float currentTime, int stateHash)
	{
	}

	[Token(Token = "0x6004E2E")]
	[Address(RVA = "0xD9EB70", Offset = "0xD9D970", Length = "0x2F1")]
	private void LateSynchronizeAnimatorsFP(float currentTime, int stateHash)
	{
	}

	[Token(Token = "0x6004E2F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnCurrentNPCAnimatorStoppedPlaying()
	{
	}

	[Token(Token = "0x6004E30")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnCurrentFPHAnimatorStoppedPlaying()
	{
	}

	[Token(Token = "0x6004E31")]
	[Address(RVA = "0xD9EE70", Offset = "0xD9DC70", Length = "0xD7")]
	public void UpdateAudioAndMaybeAnimationTime()
	{
	}

	[Token(Token = "0x6004E32")]
	[Address(RVA = "0xD9EF50", Offset = "0xD9DD50", Length = "0x28E")]
	private void ReturnToIdleAnimation()
	{
	}

	[Token(Token = "0x6004E33")]
	[Address(RVA = "0xD9F1E0", Offset = "0xD9DFE0", Length = "0x3F7")]
	private void StartMasterAnimation()
	{
	}

	[Token(Token = "0x6004E34")]
	[Address(RVA = "0xD9F5E0", Offset = "0xD9E3E0", Length = "0xB4E")]
	private void UpdatePlaying()
	{
	}

	[Token(Token = "0x6004E35")]
	[Address(RVA = "0xDA0130", Offset = "0xD9EF30", Length = "0x16D")]
	private void OnCinematicDone()
	{
	}

	[Token(Token = "0x6004E36")]
	[Address(RVA = "0xDA02A0", Offset = "0xD9F0A0", Length = "0x7")]
	public void SetUseMotionFromRef(bool useMotionFromRef)
	{
	}
}
