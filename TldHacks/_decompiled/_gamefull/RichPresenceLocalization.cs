using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200090C")]
public class RichPresenceLocalization : MonoBehaviour
{
	[Token(Token = "0x4005E72")]
	[FieldOffset(Offset = "0x20")]
	public RichPresenceLocInfo[] RichPresenceLocKeys;

	[Token(Token = "0x6005284")]
	[Address(RVA = "0xE4A0F0", Offset = "0xE48EF0", Length = "0x150")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005285")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RichPresenceLocalization()
	{
	}
}
