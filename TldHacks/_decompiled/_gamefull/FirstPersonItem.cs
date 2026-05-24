using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[Token(Token = "0x2000483")]
public class FirstPersonItem : MonoBehaviour
{
	[Token(Token = "0x40028E9")]
	[FieldOffset(Offset = "0x20")]
	public FPSItem m_ItemData;

	[Token(Token = "0x40028EA")]
	[FieldOffset(Offset = "0x28")]
	public AK.Wwise.Event m_WieldAudioEvent;

	[Token(Token = "0x40028EB")]
	[FieldOffset(Offset = "0x30")]
	public AK.Wwise.Event m_UnwieldAudioEvent;

	[Token(Token = "0x40028EC")]
	[FieldOffset(Offset = "0x38")]
	public PlayerStateTransitions m_PlayerStateTransitions;

	[SerializeField]
	[Token(Token = "0x40028ED")]
	[FieldOffset(Offset = "0x40")]
	private string m_FirstPersonObjectName;

	[Token(Token = "0x6002209")]
	[Address(RVA = "0x8256E0", Offset = "0x8244E0", Length = "0x263")]
	private bool TryGetFPSWeapon(out vp_FPSWeapon weapon)
	{
		weapon = null;
		return false;
	}

	[Token(Token = "0x600220A")]
	[Address(RVA = "0x825950", Offset = "0x824750", Length = "0xF9")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x600220B")]
	[Address(RVA = "0x825A50", Offset = "0x824850", Length = "0x3F")]
	public int GetMeshID()
	{
		return 0;
	}

	[Token(Token = "0x600220C")]
	[Address(RVA = "0x825A90", Offset = "0x824890", Length = "0x227")]
	public void PlayWieldAudio()
	{
	}

	[Token(Token = "0x600220D")]
	[Address(RVA = "0x825CC0", Offset = "0x824AC0", Length = "0x227")]
	public void PlayUnWieldAudio()
	{
	}

	[Token(Token = "0x600220E")]
	[Address(RVA = "0x825EF0", Offset = "0x824CF0", Length = "0x77")]
	public void AnimateFPSMeshToExitPosition()
	{
	}

	[Token(Token = "0x600220F")]
	[Address(RVA = "0x825F70", Offset = "0x824D70", Length = "0x18F")]
	public void AnimateFPSMeshToDefaultPosition()
	{
	}

	[Token(Token = "0x6002210")]
	[Address(RVA = "0x826100", Offset = "0x824F00", Length = "0x167")]
	public bool AnimIsPlaying(int id, int layer)
	{
		return false;
	}

	[Token(Token = "0x6002211")]
	[Address(RVA = "0x826270", Offset = "0x825070", Length = "0x20A")]
	public void SetExteriorInteriorSwitch()
	{
	}

	[Token(Token = "0x6002212")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstPersonItem()
	{
	}
}
