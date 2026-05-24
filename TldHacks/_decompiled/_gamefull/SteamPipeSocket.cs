using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200095E")]
public class SteamPipeSocket
{
	[Token(Token = "0x4006161")]
	[FieldOffset(Offset = "0x10")]
	public SteamPipe m_Socket;

	[Range(0f, 100f)]
	[Token(Token = "0x4006162")]
	[FieldOffset(Offset = "0x18")]
	public float m_MaxFlowPercent;

	[Token(Token = "0x60054B0")]
	[Address(RVA = "0xE8C6B0", Offset = "0xE8B4B0", Length = "0x8")]
	public SteamPipeSocket()
	{
	}
}
