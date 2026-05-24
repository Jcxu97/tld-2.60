using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200088C")]
public class CinematicManager : MonoBehaviour
{
	[Token(Token = "0x4005825")]
	public static bool s_IsCutsceneActive;

	[Token(Token = "0x4005826")]
	[FieldOffset(Offset = "0x20")]
	private bool m_HasLockedPlayer;

	[Token(Token = "0x4005827")]
	[FieldOffset(Offset = "0x24")]
	private PlayerControlMode m_ControlModeToRestore;

	[Token(Token = "0x4005828")]
	[FieldOffset(Offset = "0x28")]
	private List<CinematicTrack> m_CinematicTracks;

	[Token(Token = "0x4005829")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_CameraEffectsBone;

	[Token(Token = "0x400582A")]
	private static float s_AnimationTimeWhenMoviePlayStarted;

	[Token(Token = "0x400582B")]
	private static Dictionary<Animator, float[]> s_AnimationTimeArrayDict;

	[Token(Token = "0x400582C")]
	private static Dictionary<Animator, int[]> s_StateHashArrayDict;

	[Token(Token = "0x6004DEF")]
	[Address(RVA = "0xD990C0", Offset = "0xD97EC0", Length = "0x10C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DF0")]
	[Address(RVA = "0xD991D0", Offset = "0xD97FD0", Length = "0x231")]
	public void Update()
	{
	}

	[Token(Token = "0x6004DF1")]
	[Address(RVA = "0xD99410", Offset = "0xD98210", Length = "0x14F")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6004DF2")]
	[Address(RVA = "0xD99560", Offset = "0xD98360", Length = "0x180")]
	public void StartLoading(CinematicTrack track, string assetBundleFilemame, string prefabPath)
	{
	}

	[Token(Token = "0x6004DF3")]
	[Address(RVA = "0xD996F0", Offset = "0xD984F0", Length = "0x155")]
	public bool IsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6004DF4")]
	[Address(RVA = "0xD99850", Offset = "0xD98650", Length = "0x155")]
	public bool IsReady()
	{
		return false;
	}

	[Token(Token = "0x6004DF5")]
	[Address(RVA = "0xD999B0", Offset = "0xD987B0", Length = "0x155")]
	public bool IsLoading()
	{
		return false;
	}

	[Token(Token = "0x6004DF6")]
	[Address(RVA = "0xD99B10", Offset = "0xD98910", Length = "0x9D")]
	public void UpdateAnimDrivenEffects()
	{
	}

	[Token(Token = "0x6004DF7")]
	[Address(RVA = "0xD990C0", Offset = "0xD97EC0", Length = "0x10C")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6004DF8")]
	[Address(RVA = "0xD99BB0", Offset = "0xD989B0", Length = "0x202")]
	private void LockPlayer()
	{
	}

	[Token(Token = "0x6004DF9")]
	[Address(RVA = "0xD99DC0", Offset = "0xD98BC0", Length = "0x20B")]
	private void UnLockPlayer()
	{
	}

	[Token(Token = "0x6004DFA")]
	[Address(RVA = "0xD99FD0", Offset = "0xD98DD0", Length = "0xF8")]
	private void StartMasterTrack(CinematicTrack cinematic)
	{
	}

	[Token(Token = "0x6004DFB")]
	[Address(RVA = "0xD9A0D0", Offset = "0xD98ED0", Length = "0x89")]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[Token(Token = "0x6004DFC")]
	[Address(RVA = "0xD9A160", Offset = "0xD98F60", Length = "0x6B")]
	public static void MaybeSetFadedOutOnLoad(FPAnimationState fpAnimationState)
	{
	}

	[Token(Token = "0x6004DFD")]
	[Address(RVA = "0xD9A1D0", Offset = "0xD98FD0", Length = "0x6B")]
	public static void MaybeSetFadedOutOnLoad(DialogueAnimationState dialogueAnimationState)
	{
	}

	[Token(Token = "0x6004DFE")]
	[Address(RVA = "0xD9A240", Offset = "0xD99040", Length = "0x262")]
	public static CinematicTrack StartMasterFP(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, CinematicTrack.OnEnterPlaying onEnterPlaying, bool shouldLockPlayer)
	{
		return null;
	}

	[Token(Token = "0x6004DFF")]
	[Address(RVA = "0xD9A4B0", Offset = "0xD992B0", Length = "0x1E0")]
	public static void StartMasterNPC(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, bool shouldLockPlayer)
	{
	}

	[Token(Token = "0x6004E00")]
	[Address(RVA = "0xD9A6A0", Offset = "0xD994A0", Length = "0x184")]
	public static void SwitchControllerAndResumeState(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[Token(Token = "0x6004E01")]
	[Address(RVA = "0xD9A830", Offset = "0xD99630", Length = "0x1DC")]
	public static void SwapFPController(Animator fpAnimator, RuntimeAnimatorController controller)
	{
	}

	[Token(Token = "0x6004E02")]
	[Address(RVA = "0xD9AA10", Offset = "0xD99810", Length = "0x13B")]
	public static void SwitchController(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[Token(Token = "0x6004E03")]
	[Address(RVA = "0xD9AB50", Offset = "0xD99950", Length = "0xAE")]
	public static void ClearSavedAnimationState()
	{
	}

	[Token(Token = "0x6004E04")]
	[Address(RVA = "0xD9AC00", Offset = "0xD99A00", Length = "0x3BB")]
	public static void SaveAnimationState(Animator animatorSource)
	{
	}

	[Token(Token = "0x6004E05")]
	[Address(RVA = "0xD9AFC0", Offset = "0xD99DC0", Length = "0x2F8")]
	public static void RestoreAnimationState(Animator animatorSource)
	{
	}

	[Token(Token = "0x6004E06")]
	[Address(RVA = "0xD9B2C0", Offset = "0xD9A0C0", Length = "0x1DB")]
	public static void CheckAnimationRestored(Animator animatorSource)
	{
	}

	[Token(Token = "0x6004E07")]
	[Address(RVA = "0xD9B4A0", Offset = "0xD9A2A0", Length = "0x21B")]
	public static void UpdateFadeAndBlur(GameObject effectsBone, float maxBlurSize)
	{
	}

	[Token(Token = "0x6004E08")]
	[Address(RVA = "0xD9B6C0", Offset = "0xD9A4C0", Length = "0x11B")]
	public static float GetAdjustedSkipTimeAndTryToSeekAudio(float cinematicDuration, float currentAnimationTime, float audioDuration, string audioStart, uint audioId, GameObject audioEmitterNode)
	{
		return 0f;
	}

	[Token(Token = "0x6004E09")]
	[Address(RVA = "0xD9B7E0", Offset = "0xD9A5E0", Length = "0x268")]
	public static void MaybeSeekMovie(float cinematicDuration, float currentAnimationTime)
	{
	}

	[Token(Token = "0x6004E0A")]
	[Address(RVA = "0xD9BA50", Offset = "0xD9A850", Length = "0xE7")]
	public static float GetMovieTimeFromAnimationTime(float animationTime)
	{
		return 0f;
	}

	[Token(Token = "0x6004E0B")]
	[Address(RVA = "0xD9BB40", Offset = "0xD9A940", Length = "0x55")]
	public static float GetAnimationTimeWhenMoviePlayStarted()
	{
		return 0f;
	}

	[Token(Token = "0x6004E0C")]
	[Address(RVA = "0xD9BBA0", Offset = "0xD9A9A0", Length = "0x62")]
	public static void SetAnimationTimeWhenMoviePlayStarted(float animationTime)
	{
	}

	[Token(Token = "0x6004E0D")]
	[Address(RVA = "0xD9BC10", Offset = "0xD9AA10", Length = "0xD6")]
	public static bool TryGetTimeFromAudio(float cinematicDuration, float audioDuration, float currentAnimationTime, uint audioID, out float newAnimationTime)
	{
		newAnimationTime = default(float);
		return false;
	}

	[Token(Token = "0x6004E0E")]
	[Address(RVA = "0xD9BCF0", Offset = "0xD9AAF0", Length = "0xE3")]
	public CinematicManager()
	{
	}
}
