using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(TimelinePlayback))]
[Token(Token = "0x2000965")]
public class SteamPipeValve : MonoBehaviour
{
	[Tooltip("The steam pipe this valve influences.")]
	[Token(Token = "0x40061B7")]
	[FieldOffset(Offset = "0x20")]
	public SteamPipe m_SteamPipe;

	[Tooltip("The interaction hover text.")]
	[Token(Token = "0x40061B8")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDisplayName;

	[Tooltip("The interaction hover text when frozen.")]
	[Token(Token = "0x40061B9")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_FrozenLocalizedName;

	[Tooltip("The interaction hover text when open.")]
	[Token(Token = "0x40061BA")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_OpenLocalizedName;

	[Tooltip("The interaction hover text when closed.")]
	[Token(Token = "0x40061BB")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_ClosedLocalizedName;

	[Tooltip("The amount of steam flow required before the valve becomes unfrozen.")]
	[Token(Token = "0x40061BC")]
	[FieldOffset(Offset = "0x48")]
	public float m_UnfrozenFlowValue;

	[Tooltip("The initial frozen state of the valve.")]
	[Token(Token = "0x40061BD")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_IsFrozen;

	[Tooltip("The maximum amount of steam flow when open.")]
	[Token(Token = "0x40061BE")]
	[FieldOffset(Offset = "0x50")]
	public float m_ValveOpenPercent;

	[Tooltip("The minimum amount of steam flow when closed.")]
	[Token(Token = "0x40061BF")]
	[FieldOffset(Offset = "0x54")]
	public float m_ValveClosedPercent;

	[Tooltip("The initial open/closed state of the valve.")]
	[Token(Token = "0x40061C0")]
	[FieldOffset(Offset = "0x58")]
	public bool m_IsOpen;

	[Tooltip("If there's different art for frozen specified and the pipe is closed, this game object will be enabled.")]
	[Token(Token = "0x40061C1")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_FrozenValve;

	[Tooltip("If there's different art for frozen specified and the pipe is opened, this game object will be enabled.")]
	[Token(Token = "0x40061C2")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_UnfrozenValve;

	[Token(Token = "0x40061C3")]
	[FieldOffset(Offset = "0x70")]
	public Animator m_ValveAnimator;

	[Header("Timeline")]
	[SerializeField]
	[Token(Token = "0x40061C4")]
	[FieldOffset(Offset = "0x78")]
	private TimelinePlayback.TimelineInfo m_TimelineToPlayOpen;

	[SerializeField]
	[Token(Token = "0x40061C5")]
	[FieldOffset(Offset = "0x80")]
	private TimelinePlayback.TimelineInfo m_TimelineToPlayClose;

	[Token(Token = "0x40061C6")]
	[FieldOffset(Offset = "0x88")]
	public Action m_TimelineOpenCompleteCallback;

	[Token(Token = "0x40061C7")]
	[FieldOffset(Offset = "0x90")]
	public Action m_TimelineOpenInterruptedCallback;

	[Token(Token = "0x40061C8")]
	[FieldOffset(Offset = "0x98")]
	public Action m_TimelineCloseCompleteCallback;

	[Token(Token = "0x40061C9")]
	[FieldOffset(Offset = "0xA0")]
	public Action m_TimelineCloseInterruptedCallback;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x40061CA")]
	[FieldOffset(Offset = "0xA8")]
	private TimelinePlayback m_TimelinePlayback;

	[HideInInspector]
	[Token(Token = "0x40061CB")]
	[FieldOffset(Offset = "0xB0")]
	public int m_AnimParameter_OpenState;

	[Token(Token = "0x40061CC")]
	[FieldOffset(Offset = "0xB8")]
	private string m_Guid;

	[AutoComponent(ComponentRequirement.Optional)]
	[SerializeField]
	[Token(Token = "0x40061CD")]
	[FieldOffset(Offset = "0xC0")]
	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	[Token(Token = "0x60054DF")]
	[Address(RVA = "0xE90B20", Offset = "0xE8F920", Length = "0x69")]
	public void Awake()
	{
	}

	[Token(Token = "0x60054E0")]
	[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
	public string GetGuid()
	{
		return null;
	}

	[Token(Token = "0x60054E1")]
	[Address(RVA = "0xE90B90", Offset = "0xE8F990", Length = "0x26B")]
	public void Start()
	{
	}

	[Token(Token = "0x60054E2")]
	[Address(RVA = "0xE90E00", Offset = "0xE8FC00", Length = "0xB5")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60054E3")]
	[Address(RVA = "0xE90EC0", Offset = "0xE8FCC0", Length = "0x13")]
	public void InteractOpenValve(bool isOpen)
	{
	}

	[Token(Token = "0x60054E4")]
	[Address(RVA = "0xE90EE0", Offset = "0xE8FCE0", Length = "0xFA")]
	public void Update()
	{
	}

	[Token(Token = "0x60054E5")]
	[Address(RVA = "0xE90FE0", Offset = "0xE8FDE0", Length = "0x113")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60054E6")]
	[Address(RVA = "0xE91100", Offset = "0xE8FF00", Length = "0x108")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60054E7")]
	[Address(RVA = "0xE91210", Offset = "0xE90010", Length = "0x3A")]
	public void MaybeUpdateFrozenState()
	{
	}

	[Token(Token = "0x60054E8")]
	[Address(RVA = "0xE91250", Offset = "0xE90050", Length = "0x2AB")]
	public void SetPipeOpenState(bool playerInteraction)
	{
	}

	[Token(Token = "0x60054E9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60054EA")]
	[Address(RVA = "0xE91500", Offset = "0xE90300", Length = "0xEB")]
	private void SetValvePosition()
	{
	}

	[Token(Token = "0x60054EB")]
	[Address(RVA = "0xE915F0", Offset = "0xE903F0", Length = "0x195")]
	private void MaybeShowFrozenValve()
	{
	}

	[Token(Token = "0x60054EC")]
	[Address(RVA = "0xE91790", Offset = "0xE90590", Length = "0xF")]
	public void ToggleValveInteraction()
	{
	}

	[Token(Token = "0x60054ED")]
	[Address(RVA = "0xE917A0", Offset = "0xE905A0", Length = "0x44F")]
	public void OnOpenValveInteraction(bool isOpening)
	{
	}

	[Token(Token = "0x60054EE")]
	[Address(RVA = "0xE91BF0", Offset = "0xE909F0", Length = "0x86")]
	private void OnTimelineInterrupted()
	{
	}

	[Token(Token = "0x60054EF")]
	[Address(RVA = "0xE91C80", Offset = "0xE90A80", Length = "0x163")]
	private void OnOpenValveComplete()
	{
	}

	[Token(Token = "0x60054F0")]
	[Address(RVA = "0xE91DF0", Offset = "0xE90BF0", Length = "0x9E")]
	private void OnCloseValveComplete()
	{
	}

	[Token(Token = "0x60054F1")]
	[Address(RVA = "0xE91E90", Offset = "0xE90C90", Length = "0x161")]
	public SteamPipeValve()
	{
	}
}
