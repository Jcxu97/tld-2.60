using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009C4")]
public class IceCrackingWarningTrigger : MonoBehaviour
{
	[Token(Token = "0x400637C")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedWarningMsg;

	[Token(Token = "0x400637D")]
	[FieldOffset(Offset = "0x28")]
	public string m_IceCrackingAudio;

	[Tooltip("Fade in time for the ice cracking audio volume")]
	[Token(Token = "0x400637E")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadeInTimeSeconds;

	[Tooltip("Fade out time for the ice cracking audio volume")]
	[Token(Token = "0x400637F")]
	[FieldOffset(Offset = "0x34")]
	public float m_FadeOutTimeSeconds;

	[Token(Token = "0x4006380")]
	[FieldOffset(Offset = "0x38")]
	public bool m_SetLayerToTriggerIgnoreRaycast;

	[Token(Token = "0x6005671")]
	[Address(RVA = "0xEB96F0", Offset = "0xEB84F0", Length = "0x6F")]
	private void Start()
	{
	}

	[Token(Token = "0x6005672")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Update()
	{
	}

	[Token(Token = "0x6005673")]
	[Address(RVA = "0xEB9760", Offset = "0xEB8560", Length = "0x289")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6005674")]
	[Address(RVA = "0xEB99F0", Offset = "0xEB87F0", Length = "0xCE")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6005675")]
	[Address(RVA = "0xEB9AC0", Offset = "0xEB88C0", Length = "0x47")]
	public IceCrackingWarningTrigger()
	{
	}
}
