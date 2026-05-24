using AK.Wwise;
using Cpp2ILInjected;
using TLD.Audio.Migration;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000598")]
public class OpenClose : LockedInteraction
{
	[Token(Token = "0x4003383")]
	private const string DEFAULT_ANIM_PARAMETER_IS_OPEN = "IsOpen";

	[Token(Token = "0x4003384")]
	private const string DEFAULT_ANIM_PARAMETER_SPEED_MULTIPLIER = "OpenCloseSpeedMultiplier";

	[Token(Token = "0x4003385")]
	private const float IMMEDIATE_OPEN_CLOSE_SPEED_MULTIPLIER = 1000f;

	[Token(Token = "0x4003386")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4003387")]
	[FieldOffset(Offset = "0x80")]
	public LocalizedString m_LocalizedDisplayName;

	[AudioEventMigratedString("m_OpenAudio")]
	[Token(Token = "0x4003388")]
	[FieldOffset(Offset = "0x88")]
	public AK.Wwise.Event m_OpenAudioEvent;

	[AudioEventMigratedString("m_CloseAudio")]
	[Token(Token = "0x4003389")]
	[FieldOffset(Offset = "0x90")]
	public AK.Wwise.Event m_CloseAudioEvent;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400338A")]
	[FieldOffset(Offset = "0x98")]
	private string m_OpenAudio;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400338B")]
	[FieldOffset(Offset = "0xA0")]
	private string m_CloseAudio;

	[Token(Token = "0x400338C")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_ReverseAnimLocator;

	[Token(Token = "0x400338D")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_AllowInteractionWhileCarrying;

	[Token(Token = "0x400338E")]
	[FieldOffset(Offset = "0xB1")]
	public bool m_StartOpened;

	[Header("Behavior")]
	[Token(Token = "0x400338F")]
	[FieldOffset(Offset = "0xB2")]
	public bool m_DisableOnClose;

	[Token(Token = "0x4003390")]
	[FieldOffset(Offset = "0xB3")]
	public bool m_DisableOnOpen;

	[Token(Token = "0x4003391")]
	[FieldOffset(Offset = "0xB4")]
	public bool m_DisableCollisionDuringAnimation;

	[Tooltip("Send an InteractionComplete mission event when opening or closing interaction has completed successfully.")]
	[Token(Token = "0x4003392")]
	[FieldOffset(Offset = "0xB5")]
	public bool m_SendInteractionCompleteEvent;

	[SerializeField]
	[Token(Token = "0x4003393")]
	[FieldOffset(Offset = "0xB8")]
	private string m_AnimParameter_IsOpen;

	[SerializeField]
	[Token(Token = "0x4003394")]
	[FieldOffset(Offset = "0xC0")]
	private string m_AnimParameter_SpeedMultiplier;

	[SerializeField]
	[Token(Token = "0x4003395")]
	[FieldOffset(Offset = "0xC8")]
	private OpenClose[] m_LinkedObjects;

	[Header("Navmesh Obstacles")]
	[SerializeField]
	[Range(0f, 5f)]
	[Token(Token = "0x4003396")]
	[FieldOffset(Offset = "0xD0")]
	private float m_NavmeshObstaclePadding;

	[Header("Timeline Animation")]
	[SerializeField]
	[Token(Token = "0x4003397")]
	[FieldOffset(Offset = "0xD8")]
	private TimelinePlayback m_TimelinePlayback;

	[SerializeField]
	[Token(Token = "0x4003398")]
	[FieldOffset(Offset = "0xE0")]
	private TimelinePlayback.TimelineInfo m_OpenTimelineInfo;

	[SerializeField]
	[Token(Token = "0x4003399")]
	[FieldOffset(Offset = "0xE8")]
	private TimelinePlayback.TimelineInfo m_CloseTimelineInfo;

	[SerializeField]
	[Token(Token = "0x400339A")]
	[FieldOffset(Offset = "0xF0")]
	private Renderer[] m_Renderers;

	[Token(Token = "0x400339B")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_IsOpen;

	[Token(Token = "0x400339C")]
	[FieldOffset(Offset = "0x100")]
	private ObjectAnim m_ObjectAnim;

	[Token(Token = "0x400339D")]
	[FieldOffset(Offset = "0x108")]
	private bool m_AnimsReversed;

	[Token(Token = "0x400339E")]
	[FieldOffset(Offset = "0x109")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400339F")]
	[FieldOffset(Offset = "0x10A")]
	private bool m_Animating;

	[Token(Token = "0x40033A0")]
	[FieldOffset(Offset = "0x10B")]
	private bool m_IsPlayingTimeline;

	[Token(Token = "0x40033A1")]
	[FieldOffset(Offset = "0x110")]
	private Animator m_Animator;

	[Token(Token = "0x40033A2")]
	[FieldOffset(Offset = "0x118")]
	private int m_AnimParameterHash_IsOpen;

	[Token(Token = "0x40033A3")]
	[FieldOffset(Offset = "0x11C")]
	private int m_AnimParameterHash_SpeedMultiplier;

	[Token(Token = "0x40033A4")]
	[FieldOffset(Offset = "0x120")]
	private float m_DefaultOpenCloseSpeedMultiplierValue;

	[Token(Token = "0x40033A5")]
	[FieldOffset(Offset = "0x128")]
	private NavMeshObstacle m_NavmeshObstacle;

	[Token(Token = "0x40033A6")]
	[FieldOffset(Offset = "0x130")]
	private bool m_ForceOpenOnUpdate;

	[Token(Token = "0x40033A7")]
	[FieldOffset(Offset = "0x138")]
	private SafeCracking m_Safe;

	[Token(Token = "0x40033A8")]
	[FieldOffset(Offset = "0x140")]
	private bool m_IsSafeCracking;

	[Token(Token = "0x40033A9")]
	private static OpenCloseSaveDataProxy m_OpenCloseSaveDataProxy;

	[Token(Token = "0x170002C9")]
	public override bool CanInteract
	{
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x9142E0", Offset = "0x9130E0", Length = "0x93")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002CA")]
	public override bool IsActive
	{
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x914380", Offset = "0x913180", Length = "0x17")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6002B24")]
	[Address(RVA = "0x9143A0", Offset = "0x9131A0", Length = "0x108")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002B25")]
	[Address(RVA = "0x9144B0", Offset = "0x9132B0", Length = "0x4BA")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002B26")]
	[Address(RVA = "0x914970", Offset = "0x913770", Length = "0xBE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002B27")]
	[Address(RVA = "0x914A30", Offset = "0x913830", Length = "0xB0")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x914AF0", Offset = "0x9138F0", Length = "0x14F")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002B29")]
	[Address(RVA = "0x914C40", Offset = "0x913A40", Length = "0xA3")]
	public void UpdateOpenClose()
	{
	}

	[Token(Token = "0x6002B2A")]
	[Address(RVA = "0x914CF0", Offset = "0x913AF0", Length = "0x406")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002B2B")]
	[Address(RVA = "0x915100", Offset = "0x913F00", Length = "0x22F")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002B2C")]
	[Address(RVA = "0x915330", Offset = "0x914130", Length = "0x1F")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6002B2D")]
	[Address(RVA = "0x915350", Offset = "0x914150", Length = "0x181")]
	private void UpdateHoverText()
	{
	}

	[Token(Token = "0x6002B2E")]
	[Address(RVA = "0x9154E0", Offset = "0x9142E0", Length = "0x244")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x6002B2F")]
	[Address(RVA = "0x915730", Offset = "0x914530", Length = "0x1D")]
	private void OnDoneSafeCracking(bool safeOpened)
	{
	}

	[Token(Token = "0x6002B30")]
	[Address(RVA = "0x915750", Offset = "0x914550", Length = "0x5E")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002B31")]
	[Address(RVA = "0x9157B0", Offset = "0x9145B0", Length = "0x29")]
	private bool DisabledInCurrentState()
	{
		return false;
	}

	[Token(Token = "0x6002B32")]
	[Address(RVA = "0x9157E0", Offset = "0x9145E0", Length = "0x8")]
	public bool IsOpen()
	{
		return false;
	}

	[Token(Token = "0x6002B33")]
	[Address(RVA = "0x9157F0", Offset = "0x9145F0", Length = "0xB")]
	public void Open(bool isImmediate)
	{
	}

	[Token(Token = "0x6002B34")]
	[Address(RVA = "0x915800", Offset = "0x914600", Length = "0x3CA")]
	private void Open(bool isImmediate, bool fromLink)
	{
	}

	[Token(Token = "0x6002B35")]
	[Address(RVA = "0x915BD0", Offset = "0x9149D0", Length = "0xB")]
	public void Close(bool isImmediate)
	{
	}

	[Token(Token = "0x6002B36")]
	[Address(RVA = "0x915BE0", Offset = "0x9149E0", Length = "0x3CA")]
	private void Close(bool isImmediate, bool fromLink)
	{
	}

	[Token(Token = "0x6002B37")]
	[Address(RVA = "0x915FB0", Offset = "0x914DB0", Length = "0x13A")]
	private void AnimateOpen(bool isOpen)
	{
	}

	[Token(Token = "0x6002B38")]
	[Address(RVA = "0x9160F0", Offset = "0x914EF0", Length = "0x40")]
	public void OnStateDone()
	{
	}

	[Token(Token = "0x6002B39")]
	[Address(RVA = "0x916130", Offset = "0x914F30", Length = "0x1DE")]
	private bool PlayAnimInReverse()
	{
		return false;
	}

	[Token(Token = "0x6002B3A")]
	[Address(RVA = "0x916310", Offset = "0x915110", Length = "0x155")]
	private void SetCollisionEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6002B3B")]
	[Address(RVA = "0x916470", Offset = "0x915270", Length = "0x113")]
	private void SetAnimationSpeed(float value)
	{
	}

	[Token(Token = "0x6002B3C")]
	[Address(RVA = "0x916590", Offset = "0x915390", Length = "0xADA")]
	private void MaybeCreateNavMeshObstacle()
	{
	}

	[Token(Token = "0x6002B3D")]
	[Address(RVA = "0x917070", Offset = "0x915E70", Length = "0x1D4")]
	private void MaybeUpdateNavmeshObstacleState()
	{
	}

	[Token(Token = "0x6002B3E")]
	[Address(RVA = "0x917250", Offset = "0x916050", Length = "0xB")]
	public void PlayAnimationsImmediate(bool open)
	{
	}

	[Token(Token = "0x6002B3F")]
	[Address(RVA = "0x917260", Offset = "0x916060", Length = "0x373")]
	private void PlayAnimations(bool open, bool isImmediate)
	{
	}

	[Token(Token = "0x6002B40")]
	[Address(RVA = "0x9175E0", Offset = "0x9163E0", Length = "0xF4")]
	private void ToggleRenderers(bool show)
	{
	}

	[Token(Token = "0x6002B41")]
	[Address(RVA = "0x9176E0", Offset = "0x9164E0", Length = "0xA")]
	private void OnTimelineOpenStart()
	{
	}

	[Token(Token = "0x6002B42")]
	[Address(RVA = "0x9176E0", Offset = "0x9164E0", Length = "0xA")]
	private void OnTimelineCloseStart()
	{
	}

	[Token(Token = "0x6002B43")]
	[Address(RVA = "0x9176F0", Offset = "0x9164F0", Length = "0x102")]
	private void OnTimelineOpenEnd()
	{
	}

	[Token(Token = "0x6002B44")]
	[Address(RVA = "0x917800", Offset = "0x916600", Length = "0x100")]
	private void OnTimelineCloseEnd()
	{
	}

	[Token(Token = "0x6002B45")]
	[Address(RVA = "0x917900", Offset = "0x916700", Length = "0x11")]
	private void OnTimelineEnd()
	{
	}

	[Token(Token = "0x6002B46")]
	[Address(RVA = "0x917920", Offset = "0x916720", Length = "0x108")]
	public OpenClose()
	{
	}
}
