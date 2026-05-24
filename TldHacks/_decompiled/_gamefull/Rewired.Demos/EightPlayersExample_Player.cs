using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(CharacterController))]
[Token(Token = "0x2000C4B")]
public class EightPlayersExample_Player : MonoBehaviour
{
	[Token(Token = "0x4007CE6")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Token(Token = "0x4007CE7")]
	[FieldOffset(Offset = "0x24")]
	public float moveSpeed;

	[Token(Token = "0x4007CE8")]
	[FieldOffset(Offset = "0x28")]
	public float bulletSpeed;

	[Token(Token = "0x4007CE9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4007CEA")]
	[FieldOffset(Offset = "0x38")]
	private Player player;

	[Token(Token = "0x4007CEB")]
	[FieldOffset(Offset = "0x40")]
	private CharacterController cc;

	[Token(Token = "0x4007CEC")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 moveVector;

	[Token(Token = "0x4007CED")]
	[FieldOffset(Offset = "0x54")]
	private bool fire;

	[NonSerialized]
	[Token(Token = "0x4007CEE")]
	[FieldOffset(Offset = "0x55")]
	private bool initialized;

	[Token(Token = "0x6006398")]
	[Address(RVA = "0xFD1C90", Offset = "0xFD0A90", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006399")]
	[Address(RVA = "0xFD1D20", Offset = "0xFD0B20", Length = "0xB5")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600639A")]
	[Address(RVA = "0xFD1DE0", Offset = "0xFD0BE0", Length = "0x1EE")]
	private void Update()
	{
	}

	[Token(Token = "0x600639B")]
	[Address(RVA = "0xFD1FD0", Offset = "0xFD0DD0", Length = "0xAC")]
	private void GetInput()
	{
	}

	[Token(Token = "0x600639C")]
	[Address(RVA = "0xFD2080", Offset = "0xFD0E80", Length = "0x52F")]
	private void ProcessInput()
	{
	}

	[Token(Token = "0x600639D")]
	[Address(RVA = "0xFD25B0", Offset = "0xFD13B0", Length = "0x51")]
	public EightPlayersExample_Player()
	{
	}
}
