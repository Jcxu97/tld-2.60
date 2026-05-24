using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A8F")]
public class ExampleCommands : MonoBehaviour
{
	[Token(Token = "0x6005BAC")]
	[Address(RVA = "0xF2F280", Offset = "0xF2E080", Length = "0x2C9")]
	private void Start()
	{
	}

	[Token(Token = "0x6005BAD")]
	[Address(RVA = "0xF2F550", Offset = "0xF2E350", Length = "0xF8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005BAE")]
	[Address(RVA = "0xF2F650", Offset = "0xF2E450", Length = "0x14B")]
	public void EchoNothing()
	{
	}

	[Token(Token = "0x6005BAF")]
	[Address(RVA = "0xF2F7A0", Offset = "0xF2E5A0", Length = "0x13A")]
	public void EchoInteger()
	{
	}

	[Token(Token = "0x6005BB0")]
	[Address(RVA = "0xF2F8E0", Offset = "0xF2E6E0", Length = "0x10B")]
	public void EchoFloat()
	{
	}

	[Token(Token = "0x6005BB1")]
	[Address(RVA = "0xF2F9F0", Offset = "0xF2E7F0", Length = "0xE1")]
	public void EchoBool()
	{
	}

	[Token(Token = "0x6005BB2")]
	[Address(RVA = "0xF2FAE0", Offset = "0xF2E8E0", Length = "0xAE")]
	public void EchoString()
	{
	}

	[Token(Token = "0x6005BB3")]
	[Address(RVA = "0xF2FB90", Offset = "0xF2E990", Length = "0x11B")]
	public void EchoStrings()
	{
	}

	[Token(Token = "0x6005BB4")]
	[Address(RVA = "0xF2FCB0", Offset = "0xF2EAB0", Length = "0xCA")]
	public static void LoadScene()
	{
	}

	[Token(Token = "0x6005BB5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExampleCommands()
	{
	}
}
