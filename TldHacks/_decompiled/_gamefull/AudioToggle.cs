using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000543")]
public class AudioToggle : MonoBehaviour
{
	[Token(Token = "0x400308F")]
	[FieldOffset(Offset = "0x20")]
	public string m_LoopAudio;

	[Token(Token = "0x4003090")]
	[FieldOffset(Offset = "0x28")]
	public string m_TurnOffAudio;

	[Token(Token = "0x4003091")]
	[FieldOffset(Offset = "0x30")]
	public bool m_StartOn;

	[Token(Token = "0x4003092")]
	[FieldOffset(Offset = "0x34")]
	private uint m_LoopAudioID;

	[Token(Token = "0x6002854")]
	[Address(RVA = "0x8C5560", Offset = "0x8C4360", Length = "0x15")]
	private void Start()
	{
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0x8C5580", Offset = "0x8C4380", Length = "0xA0")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002856")]
	[Address(RVA = "0x8C5620", Offset = "0x8C4420", Length = "0x86")]
	private void TurnOff()
	{
	}

	[Token(Token = "0x6002857")]
	[Address(RVA = "0x8C56B0", Offset = "0x8C44B0", Length = "0x7A")]
	private void TurnOn()
	{
	}

	[Token(Token = "0x6002858")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AudioToggle()
	{
	}
}
