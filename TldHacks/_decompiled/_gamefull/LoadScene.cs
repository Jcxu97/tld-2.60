using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

[Token(Token = "0x20006F7")]
public class LoadScene : LockedInteraction
{
	[Token(Token = "0x40049FE")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40049FF")]
	private const float WAIT_ALLOW_SAVE_TIME_LIMIT = 5f;

	[Token(Token = "0x4004A00")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_ParentGO;

	[Token(Token = "0x4004A01")]
	[FieldOffset(Offset = "0x88")]
	public bool m_DisableInChallengeMode;

	[Token(Token = "0x4004A02")]
	[FieldOffset(Offset = "0x90")]
	public string m_SceneToLoad;

	[Token(Token = "0x4004A03")]
	[FieldOffset(Offset = "0x98")]
	public string m_ExitPointName;

	[Token(Token = "0x4004A04")]
	[FieldOffset(Offset = "0xA0")]
	public bool m_Active;

	[Token(Token = "0x4004A05")]
	[FieldOffset(Offset = "0xA1")]
	public bool m_SceneCanBeInstanced;

	[Token(Token = "0x4004A06")]
	[FieldOffset(Offset = "0xA8")]
	public string m_SoundDuringFadeOut;

	[Token(Token = "0x4004A07")]
	[FieldOffset(Offset = "0xB0")]
	public string m_SoundDuringFadeIn;

	[Token(Token = "0x4004A08")]
	[FieldOffset(Offset = "0xB8")]
	public LocalizedString m_LocalizedTransitionType;

	[Token(Token = "0x4004A09")]
	[FieldOffset(Offset = "0xC0")]
	public bool m_TransitionOnContact;

	[Token(Token = "0x4004A0A")]
	[FieldOffset(Offset = "0xC8")]
	public LoadSceneParent m_LoadSceneParent;

	[Tooltip("NOTE: This is for showing Region text, not Location text")]
	[Token(Token = "0x4004A0B")]
	[FieldOffset(Offset = "0xD0")]
	public string m_SceneLocationLocIDToShow;

	[Header("Animation")]
	[Token(Token = "0x4004A0C")]
	[FieldOffset(Offset = "0xD8")]
	public AnimatedInteraction m_AnimatedInteraction;

	[Token(Token = "0x4004A0D")]
	[FieldOffset(Offset = "0xE0")]
	public Animator m_AnimatedObjectAnimator;

	[Token(Token = "0x4004A0E")]
	[FieldOffset(Offset = "0xE8")]
	public string m_AnimatedObjectTrackName;

	[Header("Restrictions")]
	[Token(Token = "0x4004A0F")]
	[FieldOffset(Offset = "0xF0")]
	public bool m_RestrictTravois;

	[HideInInspector]
	[Token(Token = "0x4004A10")]
	[FieldOffset(Offset = "0xF1")]
	public bool m_Explored;

	[Token(Token = "0x4004A11")]
	public static List<LoadScene> m_LoadScenesList;

	[Token(Token = "0x4004A12")]
	[FieldOffset(Offset = "0xF8")]
	private string m_GUID;

	[Token(Token = "0x4004A13")]
	[FieldOffset(Offset = "0x100")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4004A14")]
	[FieldOffset(Offset = "0x101")]
	private bool m_FadeOutStarted;

	[Token(Token = "0x4004A15")]
	[FieldOffset(Offset = "0x102")]
	private bool m_HasDoneAnimatedInteraction;

	[Token(Token = "0x4004A16")]
	[FieldOffset(Offset = "0x103")]
	private bool m_ActivateWhenPlayerTouchGround;

	[Token(Token = "0x4004A17")]
	[FieldOffset(Offset = "0x104")]
	private bool m_WaitingToAllowSave;

	[Token(Token = "0x4004A18")]
	[FieldOffset(Offset = "0x108")]
	private float m_WaitingToAllowSaveTimer;

	[Token(Token = "0x4004A19")]
	private static LoadSceneSaveDataProxy m_LoadSceneSaveDataProxy;

	[Token(Token = "0x17000316")]
	[field: Token(Token = "0x4004A1A")]
	[field: FieldOffset(Offset = "0x110")]
	public LoadingZone PartnerLoadingZone
	{
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x677F90", Offset = "0x676D90", Length = "0x8")]
		get;
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x677FA0", Offset = "0x676DA0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x17000317")]
	public override bool CanInteract
	{
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0xB8B5B0", Offset = "0xB8A3B0", Length = "0xA8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6003D14")]
	[Address(RVA = "0xB8B660", Offset = "0xB8A460", Length = "0x202")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6003D15")]
	[Address(RVA = "0xB8B870", Offset = "0xB8A670", Length = "0x21E")]
	private void AssignBindingOverrides()
	{
	}

	[Token(Token = "0x6003D16")]
	[Address(RVA = "0xB8BA90", Offset = "0xB8A890", Length = "0x385")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003D17")]
	[Address(RVA = "0xB8BE20", Offset = "0xB8AC20", Length = "0x2C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D18")]
	[Address(RVA = "0xB8C0F0", Offset = "0xB8AEF0", Length = "0xCA")]
	private void ExitToMainMenu()
	{
	}

	[Token(Token = "0x6003D19")]
	[Address(RVA = "0xB8C1C0", Offset = "0xB8AFC0", Length = "0x403")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003D1A")]
	[Address(RVA = "0xB8C5D0", Offset = "0xB8B3D0", Length = "0x282")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003D1B")]
	[Address(RVA = "0xB8C860", Offset = "0xB8B660", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003D1C")]
	[Address(RVA = "0xB8C900", Offset = "0xB8B700", Length = "0x4C2")]
	public static void MaybeAddGUIDToPrevSceneSave()
	{
	}

	[Token(Token = "0x6003D1D")]
	[Address(RVA = "0xB8CDD0", Offset = "0xB8BBD0", Length = "0x3A0")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6003D1E")]
	[Address(RVA = "0xB8D180", Offset = "0xB8BF80", Length = "0x6D8")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6003D1F")]
	[Address(RVA = "0xB8D860", Offset = "0xB8C660", Length = "0xA")]
	public void Activate()
	{
	}

	[Token(Token = "0x6003D20")]
	[Address(RVA = "0xB8D870", Offset = "0xB8C670", Length = "0x29C")]
	public void Activate(bool transitionImmediately)
	{
	}

	[Token(Token = "0x6003D21")]
	[Address(RVA = "0xB8DB10", Offset = "0xB8C910", Length = "0x5DE")]
	private void CompleteActivate(bool transitionImmediately)
	{
	}

	[Token(Token = "0x6003D22")]
	[Address(RVA = "0x6BF850", Offset = "0x6BE650", Length = "0x8")]
	public string GetGUID()
	{
		return null;
	}

	[Token(Token = "0x6003D23")]
	[Address(RVA = "0xB8E0F0", Offset = "0xB8CEF0", Length = "0x113")]
	public void MarkExplored()
	{
	}

	[Token(Token = "0x6003D24")]
	[Address(RVA = "0xB8E210", Offset = "0xB8D010", Length = "0xA3")]
	public string GetSceneToLoad()
	{
		return null;
	}

	[Token(Token = "0x6003D25")]
	[Address(RVA = "0xB8E2C0", Offset = "0xB8D0C0", Length = "0x280")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6003D26")]
	[Address(RVA = "0xB8E550", Offset = "0xB8D350", Length = "0x34C")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x6003D27")]
	[Address(RVA = "0xB8E8A0", Offset = "0xB8D6A0", Length = "0x18")]
	private void AnimatedInteractionDone()
	{
	}

	[Token(Token = "0x6003D28")]
	[Address(RVA = "0xB8E8C0", Offset = "0xB8D6C0", Length = "0x2A")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6003D29")]
	[Address(RVA = "0xB8E8F0", Offset = "0xB8D6F0", Length = "0x1D")]
	protected override void EndHold()
	{
	}

	[Token(Token = "0x6003D2A")]
	[Address(RVA = "0xB8E910", Offset = "0xB8D710", Length = "0xE5")]
	private void LoadLevelWhenFadeOutComplete()
	{
	}

	[Token(Token = "0x6003D2B")]
	[Address(RVA = "0xB8EA00", Offset = "0xB8D800", Length = "0x676")]
	private void PerformSceneLoad()
	{
	}

	[Token(Token = "0x6003D2C")]
	[Address(RVA = "0xB8F080", Offset = "0xB8DE80", Length = "0x57")]
	private void HolsterItemInHands()
	{
	}

	[Token(Token = "0x6003D2D")]
	[Address(RVA = "0xB8F0E0", Offset = "0xB8DEE0", Length = "0xFD")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003D2E")]
	[Address(RVA = "0xB8F1E0", Offset = "0xB8DFE0", Length = "0x1E9")]
	private void MarkBrothersExplored()
	{
	}

	[Token(Token = "0x6003D2F")]
	[Address(RVA = "0xB8F3D0", Offset = "0xB8E1D0", Length = "0x117")]
	private static LoadScene FindLoadSceneByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6003D30")]
	[Address(RVA = "0xB8F4F0", Offset = "0xB8E2F0", Length = "0x4BC")]
	private static LoadScene FindLoadSceneByPosition(LoadSceneSaveDataProxy proxy)
	{
		return null;
	}

	[Token(Token = "0x6003D31")]
	[Address(RVA = "0xB8F9B0", Offset = "0xB8E7B0", Length = "0xE")]
	public LoadScene()
	{
	}
}
