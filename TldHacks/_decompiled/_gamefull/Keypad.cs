using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000594")]
public class Keypad : MonoBehaviour
{
	[Token(Token = "0x400336E")]
	[FieldOffset(Offset = "0x20")]
	public Lock[] m_AttachedLocks;

	[Header("Audio")]
	[Token(Token = "0x400336F")]
	[FieldOffset(Offset = "0x28")]
	public string m_ButtonPressingAudio;

	[Token(Token = "0x4003370")]
	[FieldOffset(Offset = "0x30")]
	public string m_ButtonPressingAudioNoAurora;

	[Token(Token = "0x4003371")]
	[FieldOffset(Offset = "0x38")]
	public string m_ButtonPressingWithCodeFailAudio;

	[Token(Token = "0x4003372")]
	[FieldOffset(Offset = "0x40")]
	public string m_ButtonPressingWithSuccessAudio;

	[Header("State")]
	[Token(Token = "0x4003373")]
	[FieldOffset(Offset = "0x48")]
	public int m_Code;

	[Token(Token = "0x4003374")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_LockedFX;

	[Token(Token = "0x4003375")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_UnlockedFX;

	[Token(Token = "0x4003376")]
	[FieldOffset(Offset = "0x60")]
	public Light m_AttractionLight;

	[Token(Token = "0x4003377")]
	[FieldOffset(Offset = "0x68")]
	private uint m_PlayingAudioID;

	[Token(Token = "0x6002B11")]
	[Address(RVA = "0x912F50", Offset = "0x911D50", Length = "0x1A2")]
	public void Update()
	{
	}

	[Token(Token = "0x6002B12")]
	[Address(RVA = "0x913100", Offset = "0x911F00", Length = "0x28B")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002B13")]
	[Address(RVA = "0x913390", Offset = "0x912190", Length = "0x54")]
	private bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x6002B14")]
	[Address(RVA = "0x9133F0", Offset = "0x9121F0", Length = "0x1FB")]
	private bool CodeIsKnownByPlayer()
	{
		return false;
	}

	[Token(Token = "0x6002B15")]
	[Address(RVA = "0x9135F0", Offset = "0x9123F0", Length = "0xAC")]
	private void OnAkCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6002B16")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Keypad()
	{
	}
}
