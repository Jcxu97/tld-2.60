using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A16")]
public class LocalizedStringTest : MonoBehaviour
{
	[Token(Token = "0x4006621")]
	[FieldOffset(Offset = "0x20")]
	public string test_one;

	[Token(Token = "0x4006622")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString test_two;

	[Token(Token = "0x4006623")]
	[FieldOffset(Offset = "0x30")]
	public string test_three;

	[Token(Token = "0x600587A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LocalizedStringTest()
	{
	}
}
