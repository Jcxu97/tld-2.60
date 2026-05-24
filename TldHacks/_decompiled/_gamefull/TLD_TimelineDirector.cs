using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[RequireComponent(typeof(PlayableDirector))]
[Token(Token = "0x20009A5")]
public class TLD_TimelineDirector : MonoBehaviour, INotificationReceiver
{
	[Serializable]
	[Token(Token = "0x20009A6")]
	public class BindingInfo
	{
		[Token(Token = "0x20009A7")]
		public enum BindingInfoType
		{
			[Token(Token = "0x40062F9")]
			MissionObjectId,
			[Token(Token = "0x40062FA")]
			GameObject
		}

		[Token(Token = "0x20009A8")]
		public enum OverrideType
		{
			[Token(Token = "0x40062FC")]
			TrackBinding,
			[Token(Token = "0x40062FD")]
			FPAnchor
		}

		[Token(Token = "0x40062F3")]
		[FieldOffset(Offset = "0x10")]
		public OverrideType m_OverrideType;

		[Token(Token = "0x40062F4")]
		[FieldOffset(Offset = "0x18")]
		public string m_Name;

		[Token(Token = "0x40062F5")]
		[FieldOffset(Offset = "0x20")]
		public BindingInfoType m_BindingType;

		[Token(Token = "0x40062F6")]
		[FieldOffset(Offset = "0x28")]
		public string m_MissionObjectId;

		[Token(Token = "0x40062F7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_GameObject;

		[Token(Token = "0x6005618")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BindingInfo()
		{
		}
	}

	[Flags]
	[Token(Token = "0x20009A9")]
	public enum PlayerTimelineFlags
	{
		[Token(Token = "0x40062FF")]
		None = 0,
		[Token(Token = "0x4006300")]
		IsPlayerTimeline = 1,
		[Token(Token = "0x4006301")]
		IsGameplayPlayerTimeline = 2
	}

	[Token(Token = "0x20009AA")]
	public delegate bool SearchTrackCB<T>(T track);

	[Token(Token = "0x40062DF")]
	public static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40062E0")]
	public static readonly List<BindingInfo> NO_BINDING_OVERRIDE;

	[Token(Token = "0x40062E1")]
	[FieldOffset(Offset = "0x20")]
	private PlayableDirector m_Director;

	[Token(Token = "0x40062E2")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsPlaying;

	[Token(Token = "0x40062E3")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_AudioId;

	[Token(Token = "0x40062E4")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsAudioDriven;

	[Token(Token = "0x40062E5")]
	[FieldOffset(Offset = "0x34")]
	private float m_AudioClipStartTime;

	[Token(Token = "0x40062E6")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsPaused;

	[Token(Token = "0x40062E7")]
	[FieldOffset(Offset = "0x39")]
	private bool m_TimeChangeRequested;

	[Token(Token = "0x40062E8")]
	[FieldOffset(Offset = "0x3C")]
	private int m_TimeChangeRequestedFrameCount;

	[Token(Token = "0x40062E9")]
	[FieldOffset(Offset = "0x40")]
	private Action m_OnStopCallback;

	[Token(Token = "0x40062EA")]
	[FieldOffset(Offset = "0x48")]
	private List<BindingInfo> m_OverrideBindingInfoList;

	[Token(Token = "0x40062EB")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasGamePaused;

	[Token(Token = "0x40062EC")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_FPPositionOnPlay;

	[Token(Token = "0x40062ED")]
	[FieldOffset(Offset = "0x60")]
	private Quaternion m_FPRotationOnPlay;

	[Token(Token = "0x40062EE")]
	[FieldOffset(Offset = "0x70")]
	private GearItem m_ItemToDeleteOnTimelineEnd;

	[Token(Token = "0x40062EF")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion m_CameraLocalRotationOnPlay;

	[Token(Token = "0x40062F0")]
	[FieldOffset(Offset = "0x88")]
	private PlayerAnimation.CameraLayer m_CameraLayerOnPlay;

	[Token(Token = "0x40062F1")]
	[FieldOffset(Offset = "0x8C")]
	private PlayerTimelineFlags m_PlayerTimelineFlags;

	[Token(Token = "0x40062F2")]
	public static bool s_IsGameplayPlayerTimelineActive;

	[Token(Token = "0x60055E9")]
	[Address(RVA = "0xEAA8A0", Offset = "0xEA96A0", Length = "0x5D3")]
	private void Awake()
	{
	}

	[Token(Token = "0x60055EA")]
	[Address(RVA = "0xEAAE80", Offset = "0xEA9C80", Length = "0x56B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60055EB")]
	[Address(RVA = "0xEAB3F0", Offset = "0xEAA1F0", Length = "0x363")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60055EC")]
	[Address(RVA = "0xEAB760", Offset = "0xEAA560", Length = "0x50E")]
	private void Update()
	{
	}

	[Token(Token = "0x60055ED")]
	[Address(RVA = "0xEABC70", Offset = "0xEAAA70", Length = "0x3F1")]
	public bool HasFPAnchor()
	{
		return false;
	}

	[Token(Token = "0x60055EE")]
	[Address(RVA = "0xEAC070", Offset = "0xEAAE70", Length = "0x2A4")]
	public bool IsControllingHands()
	{
		return false;
	}

	[Token(Token = "0x60055EF")]
	[Address(RVA = "0xEAC320", Offset = "0xEAB120", Length = "0x18C")]
	public void SetTimelineSpeed(float speed)
	{
	}

	[Token(Token = "0x60055F0")]
	[Address(RVA = "0xEAC4B0", Offset = "0xEAB2B0", Length = "0xF8")]
	public double GetDuration()
	{
		return 0.0;
	}

	[Token(Token = "0x60055F1")]
	[Address(RVA = "0xEAC5B0", Offset = "0xEAB3B0", Length = "0x12F")]
	public float GetTimeRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60055F2")]
	[Address(RVA = "0xEAC6E0", Offset = "0xEAB4E0", Length = "0x15B")]
	public float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x60055F3")]
	[Address(RVA = "0xEAC840", Offset = "0xEAB640", Length = "0x35E")]
	private TLD_CameraAnimationTrack GetCameraTrack()
	{
		return null;
	}

	[Token(Token = "0x60055F4")]
	[Address(RVA = "0xEACBA0", Offset = "0xEAB9A0", Length = "0xE5")]
	public Transform GetCameraTrackFeetTransform()
	{
		return null;
	}

	[Token(Token = "0x60055F5")]
	[Address(RVA = "0xEACC90", Offset = "0xEABA90", Length = "0x25D")]
	private void HandleGamePause()
	{
	}

	[Token(Token = "0x60055F6")]
	[Address(RVA = "0xEACEF0", Offset = "0xEABCF0", Length = "0x144")]
	private void UpdateAudioDrivenTime()
	{
	}

	[Token(Token = "0x60055F7")]
	[Address(RVA = "0xEAD040", Offset = "0xEABE40", Length = "0xBF")]
	public void SetNewTime(float newTime)
	{
	}

	[Token(Token = "0x60055F8")]
	[Address(RVA = "0xEAD100", Offset = "0xEABF00", Length = "0x9D")]
	public float GetCurrentTimelineTime()
	{
		return 0f;
	}

	[Token(Token = "0x60055F9")]
	[Address(RVA = "0xEAD1A0", Offset = "0xEABFA0", Length = "0xE3")]
	public bool ShouldUseRelativeCameraAnimation()
	{
		return false;
	}

	[Token(Token = "0x60055FA")]
	[Address(RVA = "0xEAD290", Offset = "0xEAC090", Length = "0x190")]
	public bool ShouldSupressBreathFX()
	{
		return false;
	}

	[Token(Token = "0x60055FB")]
	[Address(RVA = "0xEAD430", Offset = "0xEAC230", Length = "0xF2")]
	public float GetCameraTrackNextEndTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x60055FC")]
	[Address(RVA = "0xEAD530", Offset = "0xEAC330", Length = "0xDB")]
	public float GetCameraTrackOutTransitionDurationSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x60055FD")]
	[Address(RVA = "0xEAD610", Offset = "0xEAC410", Length = "0x6EA")]
	public bool TryGetTimeFromVoice(out float currentTime)
	{
		currentTime = default(float);
		return false;
	}

	[Token(Token = "0x60055FE")]
	[Address(RVA = "0xEADD00", Offset = "0xEACB00", Length = "0x98")]
	public bool TryGetTimeFromAudio(uint audioID, out float currAudioTime)
	{
		currAudioTime = default(float);
		return false;
	}

	[Token(Token = "0x60055FF")]
	[Address(RVA = "0xEADDA0", Offset = "0xEACBA0", Length = "0x5")]
	public bool IsTimeChangePending()
	{
		return false;
	}

	[Token(Token = "0x6005600")]
	[Address(RVA = "0xEADDB0", Offset = "0xEACBB0", Length = "0xD")]
	public void AudioDrivenStart(uint audioId, float startTime)
	{
	}

	[Token(Token = "0x6005601")]
	[Address(RVA = "0xEADDC0", Offset = "0xEACBC0", Length = "0x5")]
	public void AudioDrivenStop()
	{
	}

	[Token(Token = "0x6005602")]
	[Address(RVA = "0xEADDD0", Offset = "0xEACBD0", Length = "0x16")]
	public bool IsAudioDriven(uint audioId)
	{
		return false;
	}

	[Token(Token = "0x6005603")]
	[Address(RVA = "0xEADDF0", Offset = "0xEACBF0", Length = "0x56C")]
	public void Play(TimelineAsset timelineAsset, Action onStop, List<BindingInfo> bindingOverrides, PlayerTimelineFlags flags, DirectorWrapMode wrapMode = DirectorWrapMode.None, bool resetCamera = true)
	{
	}

	[Token(Token = "0x6005604")]
	[Address(RVA = "0xEAE360", Offset = "0xEAD160", Length = "0x99")]
	public void Stop()
	{
	}

	[Token(Token = "0x6005605")]
	[Address(RVA = "0xEAE400", Offset = "0xEAD200", Length = "0x13")]
	public Vector3 GetFPPositionOnPlay()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005606")]
	[Address(RVA = "0xEAE420", Offset = "0xEAD220", Length = "0xB")]
	public Quaternion GetFPRotationOnPlay()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6005607")]
	[Address(RVA = "0x6F56A0", Offset = "0x6F44A0", Length = "0xB")]
	public Quaternion GetCameraLocalRotationOnPlay()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6005608")]
	[Address(RVA = "0xEAE430", Offset = "0xEAD230", Length = "0x2B2")]
	public static void DoDynamicBinding(TimelineAsset timelineAsset, PlayableDirector director)
	{
	}

	[Token(Token = "0x6005609")]
	[Address(RVA = "0xEAE6F0", Offset = "0xEAD4F0", Length = "0x4D1")]
	public static TimelineClip FindClip(PlayableDirector director, UnityEngine.Object clipAsset)
	{
		return null;
	}

	[Token(Token = "0x600560A")]
	[Address(RVA = "0x19FB910", Offset = "0x19FA710", Length = "0x37E")]
	public static T FindTrack<T>(PlayableDirector director, SearchTrackCB<T> searchTrackCB) where T : TrackAsset
	{
		return null;
	}

	[Token(Token = "0x600560B")]
	[Address(RVA = "0xEAEBD0", Offset = "0xEAD9D0", Length = "0x199")]
	public static BindingInfo GetTrackBindingInfo(List<BindingInfo> list, string name)
	{
		return null;
	}

	[Token(Token = "0x600560C")]
	[Address(RVA = "0xEAED70", Offset = "0xEADB70", Length = "0x150")]
	public static BindingInfo GetFPAnchorBindingInfo(List<BindingInfo> list)
	{
		return null;
	}

	[Token(Token = "0x600560D")]
	[Address(RVA = "0xEAEED0", Offset = "0xEADCD0", Length = "0x208")]
	public GameObject GetGameObjectOverride(string objectName, string currentMissionId)
	{
		return null;
	}

	[Token(Token = "0x600560E")]
	[Address(RVA = "0xEAF0E0", Offset = "0xEADEE0", Length = "0x225")]
	public bool TryGetFPAnchorTargetOverride(out GameObject overideTarget)
	{
		overideTarget = null;
		return false;
	}

	[Token(Token = "0x600560F")]
	[Address(RVA = "0xEAF310", Offset = "0xEAE110", Length = "0xA")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6005610")]
	[Address(RVA = "0xEAF320", Offset = "0xEAE120", Length = "0x432")]
	public void Cleanup(bool resetCamera)
	{
	}

	[Token(Token = "0x6005611")]
	[Address(RVA = "0xEAF760", Offset = "0xEAE560", Length = "0x5")]
	private void OnPause(PlayableDirector director)
	{
	}

	[Token(Token = "0x6005612")]
	[Address(RVA = "0xEAF770", Offset = "0xEAE570", Length = "0x622")]
	private void OnPlay(PlayableDirector director)
	{
	}

	[Token(Token = "0x6005613")]
	[Address(RVA = "0xEAFDA0", Offset = "0xEAEBA0", Length = "0x765")]
	private void OnStop(PlayableDirector director)
	{
	}

	[Token(Token = "0x6005614")]
	[Address(RVA = "0x5026A0", Offset = "0x5014A0", Length = "0x52")]
	public void RequestDeleteOnTimelineEnd(GearItem item)
	{
	}

	[Token(Token = "0x6005615")]
	[Address(RVA = "0xEB0510", Offset = "0xEAF310", Length = "0x212")]
	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	[Token(Token = "0x6005616")]
	[Address(RVA = "0xEB0730", Offset = "0xEAF530", Length = "0xE3")]
	public TLD_TimelineDirector()
	{
	}
}
