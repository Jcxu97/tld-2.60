using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C52")]
public class PressStartToJoinExample_Assigner : MonoBehaviour
{
	[Token(Token = "0x2000C53")]
	private class PlayerMap
	{
		[Token(Token = "0x4007D15")]
		[FieldOffset(Offset = "0x10")]
		public int rewiredPlayerId;

		[Token(Token = "0x4007D16")]
		[FieldOffset(Offset = "0x14")]
		public int gamePlayerId;

		[Token(Token = "0x60063D4")]
		[Address(RVA = "0xC537A0", Offset = "0xC525A0", Length = "0x8")]
		public PlayerMap(int rewiredPlayerId, int gamePlayerId)
		{
		}
	}

	[Token(Token = "0x4007D11")]
	private static PressStartToJoinExample_Assigner instance;

	[Token(Token = "0x4007D12")]
	[FieldOffset(Offset = "0x20")]
	public int maxPlayers;

	[Token(Token = "0x4007D13")]
	[FieldOffset(Offset = "0x28")]
	private List<PlayerMap> playerMap;

	[Token(Token = "0x4007D14")]
	[FieldOffset(Offset = "0x30")]
	private int gamePlayerIdCounter;

	[Token(Token = "0x60063CE")]
	[Address(RVA = "0xFD8080", Offset = "0xFD6E80", Length = "0x2E3")]
	public static Player GetRewiredPlayer(int gamePlayerId)
	{
		return null;
	}

	[Token(Token = "0x60063CF")]
	[Address(RVA = "0xFD8370", Offset = "0xFD7170", Length = "0x136")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063D0")]
	[Address(RVA = "0xFD84B0", Offset = "0xFD72B0", Length = "0x1BF")]
	private void Update()
	{
	}

	[Token(Token = "0x60063D1")]
	[Address(RVA = "0xFD8670", Offset = "0xFD7470", Length = "0x312")]
	private void AssignNextPlayer(int rewiredPlayerId)
	{
	}

	[Token(Token = "0x60063D2")]
	[Address(RVA = "0xFD8990", Offset = "0xFD7790", Length = "0xA")]
	private int GetNextGamePlayerId()
	{
		return 0;
	}

	[Token(Token = "0x60063D3")]
	[Address(RVA = "0xFD89A0", Offset = "0xFD77A0", Length = "0x4A")]
	public PressStartToJoinExample_Assigner()
	{
	}
}
