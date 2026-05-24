using Cpp2ILInjected;
using UnityEngine;

namespace FlyingWormConsole3;

[Token(Token = "0x2000D0A")]
public class ConsoleProRemoteServer : MonoBehaviour
{
	[Token(Token = "0x4008136")]
	[FieldOffset(Offset = "0x20")]
	public bool useNATPunch;

	[Token(Token = "0x4008137")]
	[FieldOffset(Offset = "0x24")]
	public int port;

	[Token(Token = "0x60066FC")]
	[Address(RVA = "0x1037BB0", Offset = "0x10369B0", Length = "0x5D")]
	public void Awake()
	{
	}

	[Token(Token = "0x60066FD")]
	[Address(RVA = "0x1037C10", Offset = "0x1036A10", Length = "0x4A")]
	public ConsoleProRemoteServer()
	{
	}
}
