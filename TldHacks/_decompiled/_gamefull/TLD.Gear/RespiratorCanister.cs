using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;
using Voice;

namespace TLD.Gear;

[RequireComponent(typeof(GearItem))]
[Token(Token = "0x2001435")]
public class RespiratorCanister : MonoBehaviour
{
	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4009351")]
	[FieldOffset(Offset = "0x20")]
	private GearItem m_GearItem;

	[Tooltip("How long the canister protects the player, in realtime")]
	[Token(Token = "0x4009352")]
	[FieldOffset(Offset = "0x28")]
	public float m_ProtectionDurationRTSeconds;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4009353")]
	[FieldOffset(Offset = "0x30")]
	private AK.Wwise.Event m_AttachAudio;

	[SerializeField]
	[Token(Token = "0x4009354")]
	[FieldOffset(Offset = "0x38")]
	private AK.Wwise.Event m_ExpireAudio;

	[SerializeField]
	[Token(Token = "0x4009355")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_ExplirePlayerVO;

	[SerializeField]
	[Token(Token = "0x4009356")]
	[FieldOffset(Offset = "0x48")]
	private Priority m_ExplirePlayerVOPriority;

	[SerializeField]
	[Token(Token = "0x4009357")]
	[FieldOffset(Offset = "0x50")]
	private AK.Wwise.Event m_UnattachAudio;

	[Token(Token = "0x17000B27")]
	public GearItem GearItem
	{
		[Token(Token = "0x60080FB")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B28")]
	public bool IsValid
	{
		[Token(Token = "0x60080FC")]
		[Address(RVA = "0x1212C90", Offset = "0x1211A90", Length = "0xEF")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B29")]
	public float NormalizedCondition
	{
		[Token(Token = "0x60080FD")]
		[Address(RVA = "0x1212D80", Offset = "0x1211B80", Length = "0x117")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60080FE")]
	[Address(RVA = "0x1212EA0", Offset = "0x1211CA0", Length = "0x23D")]
	public void DestroyAttachedWithParent()
	{
	}

	[Token(Token = "0x60080FF")]
	[Address(RVA = "0x12130E0", Offset = "0x1211EE0", Length = "0xDF")]
	public void ForceExpire()
	{
	}

	[Token(Token = "0x6008100")]
	[Address(RVA = "0x12131C0", Offset = "0x1211FC0", Length = "0x1AD")]
	public string GetPDID()
	{
		return null;
	}

	[Token(Token = "0x6008101")]
	[Address(RVA = "0x1213370", Offset = "0x1212170", Length = "0x339")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6008102")]
	[Address(RVA = "0x12136B0", Offset = "0x12124B0", Length = "0xB6")]
	public void PlayAttachAudio()
	{
	}

	[Token(Token = "0x6008103")]
	[Address(RVA = "0x1213770", Offset = "0x1212570", Length = "0xB6")]
	public void PlayUnattachAudio()
	{
	}

	[Token(Token = "0x6008104")]
	[Address(RVA = "0x1213830", Offset = "0x1212630", Length = "0x5E")]
	public void SetupAttachedState()
	{
	}

	[Token(Token = "0x6008105")]
	[Address(RVA = "0x1213890", Offset = "0x1212690", Length = "0x51")]
	public RespiratorCanister()
	{
	}
}
