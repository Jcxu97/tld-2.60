using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Audio;
using UnityEngine;

[Token(Token = "0x2000744")]
public class GameAudioManager : MonoBehaviour
{
	[Token(Token = "0x2000745")]
	private enum AudioFadeState
	{
		[Token(Token = "0x4004CFD")]
		FadedIn,
		[Token(Token = "0x4004CFE")]
		FadedOut
	}

	[Flags]
	[Token(Token = "0x2000746")]
	public enum PlayOptions
	{
		[Token(Token = "0x4004D00")]
		None = 0,
		[Token(Token = "0x4004D01")]
		SkipAt0SoundVolume = 1
	}

	[Token(Token = "0x2000747")]
	public delegate void OnStopAllAudioCallback(GameObject gameObject);

	[Token(Token = "0x4004CDA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_WiseAudioPrefab;

	[Token(Token = "0x4004CDB")]
	[FieldOffset(Offset = "0x28")]
	public float m_FadeInAudioSeconds;

	[Token(Token = "0x4004CDC")]
	[FieldOffset(Offset = "0x2C")]
	public int m_StopAudioFadeOutMicroseconds;

	[Token(Token = "0x4004CDD")]
	[FieldOffset(Offset = "0x30")]
	public AK.Wwise.Event m_ErrorAudio;

	[Token(Token = "0x4004CDE")]
	[FieldOffset(Offset = "0x38")]
	public AK.Wwise.Event m_ButtonClickAudio;

	[Token(Token = "0x4004CDF")]
	[FieldOffset(Offset = "0x40")]
	public AK.Wwise.Event m_ButtonBackAudio;

	[Token(Token = "0x4004CE0")]
	[FieldOffset(Offset = "0x48")]
	public AK.Wwise.Event m_MenuOpenAudio;

	[Token(Token = "0x4004CE1")]
	[FieldOffset(Offset = "0x50")]
	public AK.Wwise.Event m_MenuCloseAudio;

	[Token(Token = "0x4004CE2")]
	[FieldOffset(Offset = "0x58")]
	public AK.Wwise.Event m_ScrollAudio;

	[Token(Token = "0x4004CE3")]
	[FieldOffset(Offset = "0x60")]
	public AK.Wwise.Event m_ComboBoxScrollAudio;

	[Token(Token = "0x4004CE4")]
	[FieldOffset(Offset = "0x68")]
	public AK.Wwise.Event m_SliderAudio;

	[Token(Token = "0x4004CE5")]
	[FieldOffset(Offset = "0x70")]
	public AK.Wwise.Event m_MouseOver;

	[Token(Token = "0x4004CE6")]
	[FieldOffset(Offset = "0x78")]
	public AK.Wwise.Event m_Confirm;

	[SerializeField]
	[Token(Token = "0x4004CE7")]
	[FieldOffset(Offset = "0x80")]
	private RTPC m_GlobalGameTimeScale;

	[SerializeField]
	[Token(Token = "0x4004CE8")]
	[FieldOffset(Offset = "0x88")]
	private AudioMaterialTagMapping m_MaterialMapping;

	[HideInInspector]
	[Token(Token = "0x4004CE9")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_WiseAudio;

	[Token(Token = "0x4004CEA")]
	private static float m_LastAudioFade;

	[Token(Token = "0x4004CEB")]
	private static bool m_AudioPaused;

	[Token(Token = "0x4004CEC")]
	[FieldOffset(Offset = "0x98")]
	private int m_InsideHeavyOcclusionTriggerCount;

	[Token(Token = "0x4004CED")]
	[FieldOffset(Offset = "0x9C")]
	private int m_InsideMediumOcclusionTriggerCount;

	[Token(Token = "0x4004CEE")]
	[FieldOffset(Offset = "0xA0")]
	private int m_InsideMildOcclusionTriggerCount;

	[Token(Token = "0x4004CEF")]
	[FieldOffset(Offset = "0xA4")]
	private float m_LastTimeScale;

	[Token(Token = "0x4004CF0")]
	private static int m_FramesSincePlayedButtonClick;

	[Token(Token = "0x4004CF1")]
	[FieldOffset(Offset = "0xA8")]
	private AudioOcclusionLevel m_CurrentAudioOcclusionLevel;

	[Token(Token = "0x4004CF2")]
	public static List<OnStopAllAudioCallback> m_OnStopAllAudioCallbacks;

	[Token(Token = "0x4004CF3")]
	private static AudioFadeState m_AudioFadeState;

	[Token(Token = "0x4004CF4")]
	private static AudioFadeState m_AudioFadeRequestedState;

	[Token(Token = "0x4004CF5")]
	private static float m_AudioFadeTimer;

	[Token(Token = "0x4004CF6")]
	private static float m_AudioFadeDuration;

	[Token(Token = "0x4004CF7")]
	public static string m_WwiseEventOnStart;

	[Token(Token = "0x4004CF8")]
	public static bool m_WwiseFadeInOnStart;

	[Token(Token = "0x4004CF9")]
	public static bool m_WwiseStopAllOnStart;

	[Token(Token = "0x4004CFA")]
	private static SoundbankLoader s_EpisodeLoader;

	[Token(Token = "0x1700031F")]
	[field: Token(Token = "0x4004CFB")]
	public static GameAudioManager Instance
	{
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0xC295D0", Offset = "0xC283D0", Length = "0x54")]
		get;
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0xC29630", Offset = "0xC28430", Length = "0xB7")]
		private set;
	}

	[Token(Token = "0x60041A7")]
	[Address(RVA = "0xC296F0", Offset = "0xC284F0", Length = "0x56")]
	private void Awake()
	{
	}

	[Token(Token = "0x60041A8")]
	[Address(RVA = "0xC29750", Offset = "0xC28550", Length = "0x45")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60041A9")]
	[Address(RVA = "0xC297A0", Offset = "0xC285A0", Length = "0x327")]
	private void Start()
	{
	}

	[Token(Token = "0x60041AA")]
	[Address(RVA = "0xC29AD0", Offset = "0xC288D0", Length = "0x24E")]
	private void Update()
	{
	}

	[Token(Token = "0x60041AB")]
	[Address(RVA = "0xC29D20", Offset = "0xC28B20", Length = "0x74")]
	public static void StopAll()
	{
	}

	[Token(Token = "0x60041AC")]
	[Address(RVA = "0xC29DA0", Offset = "0xC28BA0", Length = "0x57")]
	public static bool CanPlaySpecialUIEntrySound()
	{
		return false;
	}

	[Token(Token = "0x60041AD")]
	[Address(RVA = "0xC29E00", Offset = "0xC28C00", Length = "0x18E")]
	public static void PauseAudioImmediate()
	{
	}

	[Token(Token = "0x60041AE")]
	[Address(RVA = "0xC29F90", Offset = "0xC28D90", Length = "0x18E")]
	public static void PauseAudio()
	{
	}

	[Token(Token = "0x60041AF")]
	[Address(RVA = "0xC2A120", Offset = "0xC28F20", Length = "0x18E")]
	public static void UnPauseAudio()
	{
	}

	[Token(Token = "0x60041B0")]
	[Address(RVA = "0xC2A2B0", Offset = "0xC290B0", Length = "0x177")]
	public static void PlayGUIError()
	{
	}

	[Token(Token = "0x60041B1")]
	[Address(RVA = "0xC2A430", Offset = "0xC29230", Length = "0x187")]
	public static void PlayGUIButtonClick()
	{
	}

	[Token(Token = "0x60041B2")]
	[Address(RVA = "0xC2A5C0", Offset = "0xC293C0", Length = "0x177")]
	public static void PlayGUIButtonBack()
	{
	}

	[Token(Token = "0x60041B3")]
	[Address(RVA = "0xC2A740", Offset = "0xC29540", Length = "0x177")]
	public static void PlayGUIMenuOpen()
	{
	}

	[Token(Token = "0x60041B4")]
	[Address(RVA = "0xC2A8C0", Offset = "0xC296C0", Length = "0x177")]
	public static void PlayGUIMenuClose()
	{
	}

	[Token(Token = "0x60041B5")]
	[Address(RVA = "0xC2AA40", Offset = "0xC29840", Length = "0x18D")]
	public static void PlayGUIScroll()
	{
	}

	[Token(Token = "0x60041B6")]
	[Address(RVA = "0xC2ABD0", Offset = "0xC299D0", Length = "0x177")]
	public static void PlayGUIComboBoxScroll()
	{
	}

	[Token(Token = "0x60041B7")]
	[Address(RVA = "0xC2AD50", Offset = "0xC29B50", Length = "0x177")]
	public static void PlayGUISlider()
	{
	}

	[Token(Token = "0x60041B8")]
	[Address(RVA = "0xC2AED0", Offset = "0xC29CD0", Length = "0x177")]
	public static void PlayGUIMouseOver()
	{
	}

	[Token(Token = "0x60041B9")]
	[Address(RVA = "0xC2B050", Offset = "0xC29E50", Length = "0x177")]
	public static void PlayGuiConfirm()
	{
	}

	[Token(Token = "0x60041BA")]
	[Address(RVA = "0xC2B1D0", Offset = "0xC29FD0", Length = "0x10A")]
	public static void StopPlayingID(ref uint id, int fadeOutMilliseconds = 100)
	{
	}

	[Token(Token = "0x60041BB")]
	[Address(RVA = "0xC2B2E0", Offset = "0xC2A0E0", Length = "0x37")]
	public void EnterOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[Token(Token = "0x60041BC")]
	[Address(RVA = "0xC2B320", Offset = "0xC2A120", Length = "0x84")]
	public void ExitOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[Token(Token = "0x60041BD")]
	[Address(RVA = "0xC2B3B0", Offset = "0xC2A1B0", Length = "0x2B8")]
	public static void SetAiStateSwitch(AiMode mode, EmitterProxy ep)
	{
	}

	[Token(Token = "0x60041BE")]
	[Address(RVA = "0xC2B6B0", Offset = "0xC2A4B0", Length = "0x145")]
	public static void SetCookingSlotSwitch(GearPlacePoint gpp)
	{
	}

	[Token(Token = "0x60041BF")]
	[Address(RVA = "0xC2B800", Offset = "0xC2A600", Length = "0x24B")]
	public static void SetMaterialSwitch(string tag, GameObject go)
	{
	}

	[Token(Token = "0x60041C0")]
	[Address(RVA = "0xC2BA50", Offset = "0xC2A850", Length = "0x28D")]
	public static void SetCuttingToolSwitch(GearItem gearItem, GameObject go)
	{
	}

	[Token(Token = "0x60041C1")]
	[Address(RVA = "0xC2BCE0", Offset = "0xC2AAE0", Length = "0x1C0")]
	public static void SetWeaponTypeSwitch(StruggleBonus.StruggleWeaponType weaponType, GameObject go)
	{
	}

	[Token(Token = "0x60041C2")]
	[Address(RVA = "0xC2BED0", Offset = "0xC2ACD0", Length = "0xBC")]
	public static void SetCramponsSwitch(CramponsState cramponsState, GameObject go)
	{
	}

	[Token(Token = "0x60041C3")]
	[Address(RVA = "0xC2BF90", Offset = "0xC2AD90", Length = "0xA4")]
	public static void SetIndoorEnvironmentSwitch(GameObject go)
	{
	}

	[Token(Token = "0x60041C4")]
	[Address(RVA = "0xC2C040", Offset = "0xC2AE40", Length = "0xA4")]
	public static void SetOutdoorEnvironmentSwitch(GameObject go)
	{
	}

	[Token(Token = "0x60041C5")]
	[Address(RVA = "0xC2C0F0", Offset = "0xC2AEF0", Length = "0x39C")]
	public static void SetAudioSourceTransform(GameObject owner, Transform t)
	{
	}

	[Token(Token = "0x60041C6")]
	[Address(RVA = "0xC2C490", Offset = "0xC2B290", Length = "0x37D")]
	public static void SetAudioSourceTransform(EmitterProxy ep, Transform t)
	{
	}

	[Token(Token = "0x60041C7")]
	[Address(RVA = "0xC2C810", Offset = "0xC2B610", Length = "0x62B")]
	public static void PlayDynamicSequence(string soundID, GameObject go)
	{
	}

	[Token(Token = "0x60041C8")]
	[Address(RVA = "0xC2CE40", Offset = "0xC2BC40", Length = "0xDB")]
	public static uint PlayMusic(string soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041C9")]
	[Address(RVA = "0xC2CF20", Offset = "0xC2BD20", Length = "0x8F")]
	public static uint PlayMusic(uint soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041CA")]
	[Address(RVA = "0xC2CFB0", Offset = "0xC2BDB0", Length = "0x1FC")]
	public static uint PlaySoundWithPositionTracking(AK.Wwise.Event soundEvent, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return 0u;
	}

	[Token(Token = "0x60041CB")]
	[Address(RVA = "0xC2D1B0", Offset = "0xC2BFB0", Length = "0x1D9")]
	public static uint PlaySoundWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return 0u;
	}

	[Token(Token = "0x60041CC")]
	[Address(RVA = "0xC2D390", Offset = "0xC2C190", Length = "0x1DA")]
	public static uint PlayVoiceWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback)
	{
		return 0u;
	}

	[Token(Token = "0x60041CD")]
	[Address(RVA = "0xC2D570", Offset = "0xC2C370", Length = "0x16A")]
	public static uint PlaySound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041CE")]
	[Address(RVA = "0xC2D6E0", Offset = "0xC2C4E0", Length = "0x181")]
	public static uint PlaySound(string soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041CF")]
	[Address(RVA = "0xC2D870", Offset = "0xC2C670", Length = "0x344")]
	public static void Seek(string soundID, int audioMs, GameObject go)
	{
	}

	[Token(Token = "0x60041D0")]
	[Address(RVA = "0xC2DBC0", Offset = "0xC2C9C0", Length = "0x136")]
	public static uint PlaySound(uint soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041D1")]
	[Address(RVA = "0xC2DD00", Offset = "0xC2CB00", Length = "0x1C1")]
	public static uint Play3DSound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041D2")]
	[Address(RVA = "0xC2DED0", Offset = "0xC2CCD0", Length = "0x1FE")]
	public static uint Play3DSound(string soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041D3")]
	[Address(RVA = "0xC2E0D0", Offset = "0xC2CED0", Length = "0x158")]
	public static uint Play3DSound(uint soundID, GameObject go)
	{
		return 0u;
	}

	[Token(Token = "0x60041D4")]
	[Address(RVA = "0xC2E230", Offset = "0xC2D030", Length = "0x20E")]
	public static void NotifyAiAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[Token(Token = "0x60041D5")]
	[Address(RVA = "0xC2E440", Offset = "0xC2D240", Length = "0x374")]
	public static GameObject GetSoundEmitterFromGameObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60041D6")]
	[Address(RVA = "0xC2E7C0", Offset = "0xC2D5C0", Length = "0x275")]
	public static EmitterProxy GetSoundEmitterProxyFromGameObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60041D7")]
	[Address(RVA = "0xC2EA40", Offset = "0xC2D840", Length = "0x64")]
	public static void MuteGameplayAudio()
	{
	}

	[Token(Token = "0x60041D8")]
	[Address(RVA = "0xC2EAB0", Offset = "0xC2D8B0", Length = "0xE3")]
	public static void UnmuteGameplayAudio()
	{
	}

	[Token(Token = "0x60041D9")]
	[Address(RVA = "0xC2EBA0", Offset = "0xC2D9A0", Length = "0x27C")]
	public static uint MaybePlayOverrideCloseSound()
	{
		return 0u;
	}

	[Token(Token = "0x60041DA")]
	[Address(RVA = "0xC2EE20", Offset = "0xC2DC20", Length = "0x1B")]
	private static string TrimAudioEventString(string soundId)
	{
		return null;
	}

	[Token(Token = "0x60041DB")]
	[Address(RVA = "0xC2EE40", Offset = "0xC2DC40", Length = "0x184")]
	private static void EnsureEmitterIsRegistered(GameObject go)
	{
	}

	[Token(Token = "0x60041DC")]
	[Address(RVA = "0xC2EFD0", Offset = "0xC2DDD0", Length = "0x19B")]
	private static void EnsureEmitterIsRegistered(EmitterProxy ep)
	{
	}

	[Token(Token = "0x60041DD")]
	[Address(RVA = "0xC2F170", Offset = "0xC2DF70", Length = "0x115")]
	public static void StopAllSoundsFromGameObject(GameObject go)
	{
	}

	[Token(Token = "0x60041DE")]
	[Address(RVA = "0xC2F290", Offset = "0xC2E090", Length = "0x9F")]
	public static void SetRTPCValue(uint rtpcID, float rtpcValue, GameObject go)
	{
	}

	[Token(Token = "0x60041DF")]
	[Address(RVA = "0xC2F330", Offset = "0xC2E130", Length = "0xCB")]
	public static void SetAudioFade(float normalizedValue)
	{
	}

	[Token(Token = "0x60041E0")]
	[Address(RVA = "0xC2F400", Offset = "0xC2E200", Length = "0x86")]
	public static void StartAudioFadeIn(float duration)
	{
	}

	[Token(Token = "0x60041E1")]
	[Address(RVA = "0xC2F490", Offset = "0xC2E290", Length = "0x8C")]
	public static void StartAudioFadeOut(float duration)
	{
	}

	[Token(Token = "0x60041E2")]
	[Address(RVA = "0xC2F520", Offset = "0xC2E320", Length = "0x54")]
	public static bool AudioIsPaused()
	{
		return false;
	}

	[Token(Token = "0x60041E3")]
	[Address(RVA = "0xC2F580", Offset = "0xC2E380", Length = "0x1A0")]
	public static void FadeInAudioOnSceneStart()
	{
	}

	[Token(Token = "0x60041E4")]
	[Address(RVA = "0xC2F730", Offset = "0xC2E530", Length = "0x68")]
	public static bool HasFadedInOnStart()
	{
		return false;
	}

	[Token(Token = "0x60041E5")]
	[Address(RVA = "0xC2F7A0", Offset = "0xC2E5A0", Length = "0x138")]
	public static void LoadEpisode(Episode episode)
	{
	}

	[Token(Token = "0x60041E6")]
	[Address(RVA = "0xC2F8E0", Offset = "0xC2E6E0", Length = "0x12F")]
	public static void DebugLoadAllEpisodeBanks()
	{
	}

	[Token(Token = "0x60041E7")]
	[Address(RVA = "0xC2FA10", Offset = "0xC2E810", Length = "0x12F")]
	public static void UnloadActiveEpisode()
	{
	}

	[Token(Token = "0x60041E8")]
	[Address(RVA = "0xC2FB40", Offset = "0xC2E940", Length = "0xD8")]
	private static void TriggerStopAllAudioCallbackFor(GameObject gameObject)
	{
	}

	[Token(Token = "0x60041E9")]
	[Address(RVA = "0xC2FC20", Offset = "0xC2EA20", Length = "0x1AF")]
	private static EmitterProxy AddAudioComponents(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60041EA")]
	[Address(RVA = "0xC2FDD0", Offset = "0xC2EBD0", Length = "0x26A")]
	private static bool GameObjectHasCollider(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60041EB")]
	[Address(RVA = "0xC30040", Offset = "0xC2EE40", Length = "0x181")]
	private void UpdateTimeScaleRTPC()
	{
	}

	[Token(Token = "0x60041EC")]
	[Address(RVA = "0xC301D0", Offset = "0xC2EFD0", Length = "0x1E2")]
	private void UpdateAudioOcclusion()
	{
	}

	[Token(Token = "0x60041ED")]
	[Address(RVA = "0xC303C0", Offset = "0xC2F1C0", Length = "0x26B")]
	private void UpdateAudioFade()
	{
	}

	[Token(Token = "0x60041EE")]
	[Address(RVA = "0xC30630", Offset = "0xC2F430", Length = "0x6A")]
	private void SetHeavyOcclusion()
	{
	}

	[Token(Token = "0x60041EF")]
	[Address(RVA = "0xC306A0", Offset = "0xC2F4A0", Length = "0x6A")]
	private void SetMediumOcclusion()
	{
	}

	[Token(Token = "0x60041F0")]
	[Address(RVA = "0xC30710", Offset = "0xC2F510", Length = "0x6A")]
	private void SetMildOcclusion()
	{
	}

	[Token(Token = "0x60041F1")]
	[Address(RVA = "0xC30780", Offset = "0xC2F580", Length = "0x6A")]
	private void SetNoOcclusion()
	{
	}

	[Token(Token = "0x60041F2")]
	[Address(RVA = "0xC307F0", Offset = "0xC2F5F0", Length = "0x464")]
	private void InstantiateWiseAudio()
	{
	}

	[Token(Token = "0x60041F3")]
	[Address(RVA = "0xC30C60", Offset = "0xC2FA60", Length = "0x3E3")]
	private static void AddAudioComponentsInternal(EmitterProxy ep)
	{
	}

	[Token(Token = "0x60041F4")]
	[Address(RVA = "0xC31050", Offset = "0xC2FE50", Length = "0x535")]
	private static EmitterProxy AddAudioEmitterProxy(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60041F5")]
	[Address(RVA = "0xC31590", Offset = "0xC30390", Length = "0xAC")]
	private static void SetRTPCAudioFade(float normalizedValue)
	{
	}

	[Token(Token = "0x60041F6")]
	[Address(RVA = "0xC31640", Offset = "0xC30440", Length = "0x4D")]
	public GameAudioManager()
	{
	}
}
