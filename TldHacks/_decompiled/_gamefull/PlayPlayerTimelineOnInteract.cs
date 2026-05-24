using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200059D")]
public class PlayPlayerTimelineOnInteract : MonoBehaviour
{
	[AutoComponent(ComponentRequirement.Optional)]
	[SerializeField]
	[Token(Token = "0x40033D3")]
	[FieldOffset(Offset = "0x20")]
	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	[SerializeField]
	[Token(Token = "0x40033D4")]
	[FieldOffset(Offset = "0x28")]
	private bool m_UsePlayerHeldItemPlacementZone;

	[SerializeField]
	[Token(Token = "0x40033D5")]
	[FieldOffset(Offset = "0x30")]
	private TimelinePlayback.TimelineInfo m_TimelineToPlay;

	[Header("Timeline Events")]
	[SerializeField]
	[Token(Token = "0x40033D6")]
	[FieldOffset(Offset = "0x38")]
	private UnityEvent m_OnTimelineBegin;

	[SerializeField]
	[Token(Token = "0x40033D7")]
	[FieldOffset(Offset = "0x40")]
	private UnityEvent m_OnTimelineInterrupted;

	[SerializeField]
	[Token(Token = "0x40033D8")]
	[FieldOffset(Offset = "0x48")]
	private UnityEvent m_OnTimelineEnded;

	[Token(Token = "0x40033D9")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_EquippedItem;

	[Token(Token = "0x40033DA")]
	[FieldOffset(Offset = "0x58")]
	private TimelinePlayback.TimelineCallbacks m_Callbacks;

	[Token(Token = "0x40033DB")]
	[FieldOffset(Offset = "0x60")]
	private HeldItemInPlacementZone m_ActiveHeldItemPlacementZone;

	[Token(Token = "0x6002B6F")]
	[Address(RVA = "0x91AE50", Offset = "0x919C50", Length = "0x293")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x91B0F0", Offset = "0x919EF0", Length = "0x1EC")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002B72")]
	[Address(RVA = "0x91B2E0", Offset = "0x91A0E0", Length = "0x11")]
	private void OnTimelineBegin()
	{
	}

	[Token(Token = "0x6002B73")]
	[Address(RVA = "0x91B300", Offset = "0x91A100", Length = "0x28")]
	private void OnTimelineInterrupted()
	{
	}

	[Token(Token = "0x6002B74")]
	[Address(RVA = "0x91B330", Offset = "0x91A130", Length = "0x28")]
	private void OnTimelineEnded()
	{
	}

	[Token(Token = "0x6002B75")]
	[Address(RVA = "0x91B360", Offset = "0x91A160", Length = "0x1BF")]
	private void RestoreItemInHands()
	{
	}

	[Token(Token = "0x6002B76")]
	[Address(RVA = "0x91B520", Offset = "0x91A320", Length = "0xD2")]
	public PlayPlayerTimelineOnInteract()
	{
	}
}
