using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(CharacterController))]
[Token(Token = "0x2000C54")]
public class PressStartToJoinExample_GamePlayer : MonoBehaviour
{
	[Token(Token = "0x4007D17")]
	[FieldOffset(Offset = "0x20")]
	public int gamePlayerId;

	[Token(Token = "0x4007D18")]
	[FieldOffset(Offset = "0x24")]
	public float moveSpeed;

	[Token(Token = "0x4007D19")]
	[FieldOffset(Offset = "0x28")]
	public float bulletSpeed;

	[Token(Token = "0x4007D1A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4007D1B")]
	[FieldOffset(Offset = "0x38")]
	private CharacterController cc;

	[Token(Token = "0x4007D1C")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 moveVector;

	[Token(Token = "0x4007D1D")]
	[FieldOffset(Offset = "0x4C")]
	private bool fire;

	[Token(Token = "0x170006AE")]
	private Player player
	{
		[Token(Token = "0x60063D5")]
		[Address(RVA = "0xFD89F0", Offset = "0xFD77F0", Length = "0xA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60063D6")]
	[Address(RVA = "0xFD8A00", Offset = "0xFD7800", Length = "0x8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60063D7")]
	[Address(RVA = "0xFD8A90", Offset = "0xFD7890", Length = "0x16D")]
	private void Update()
	{
	}

	[Token(Token = "0x60063D8")]
	[Address(RVA = "0xFD8C00", Offset = "0xFD7A00", Length = "0xC7")]
	private void GetInput()
	{
	}

	[Token(Token = "0x60063D9")]
	[Address(RVA = "0xFD8CD0", Offset = "0xFD7AD0", Length = "0x52F")]
	private void ProcessInput()
	{
	}

	[Token(Token = "0x60063DA")]
	[Address(RVA = "0xFD25B0", Offset = "0xFD13B0", Length = "0x51")]
	public PressStartToJoinExample_GamePlayer()
	{
	}
}
