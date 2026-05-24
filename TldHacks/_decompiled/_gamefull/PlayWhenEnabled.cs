using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001BC")]
public class PlayWhenEnabled : MonoBehaviour
{
	[Token(Token = "0x4000F3B")]
	[FieldOffset(Offset = "0x20")]
	public string m_Audio;

	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0x28")]
	private uint m_AudioID;

	[Token(Token = "0x600100A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x600100B")]
	[Address(RVA = "0x61E600", Offset = "0x61D400", Length = "0x7A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600100C")]
	[Address(RVA = "0x61E680", Offset = "0x61D480", Length = "0x54")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600100D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayWhenEnabled()
	{
	}
}
