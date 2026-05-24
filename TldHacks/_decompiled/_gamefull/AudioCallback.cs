using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B5")]
public class AudioCallback : MonoBehaviour
{
	[Token(Token = "0x20001B6")]
	public enum AudioTarget
	{
		[Token(Token = "0x4000F30")]
		Self,
		[Token(Token = "0x4000F31")]
		Player
	}

	[SerializeField]
	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x20")]
	private AudioTarget m_AudioTarget;

	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x24")]
	private bool m_DisableAudioEvents;

	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x61D6C0", Offset = "0x61C4C0", Length = "0x4")]
	public void ToggleDisableAudioEvents(bool toggle)
	{
	}

	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x61D6D0", Offset = "0x61C4D0", Length = "0xB7")]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x61D790", Offset = "0x61C590", Length = "0x11F")]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x61D8B0", Offset = "0x61C6B0", Length = "0xD5")]
	public void OnAudioStruggleEventOneShot(string audioEventName)
	{
	}

	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x61D990", Offset = "0x61C790", Length = "0xE4")]
	public void OnPlayerVoiceEvent(string audioEventName)
	{
	}

	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x61DA80", Offset = "0x61C880", Length = "0xB1")]
	public void OnPlayerVoiceEventWithArgs(Object arguments)
	{
	}

	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x61DB40", Offset = "0x61C940", Length = "0x61")]
	private GameObject GetAudioTarget()
	{
		return null;
	}

	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AudioCallback()
	{
	}
}
