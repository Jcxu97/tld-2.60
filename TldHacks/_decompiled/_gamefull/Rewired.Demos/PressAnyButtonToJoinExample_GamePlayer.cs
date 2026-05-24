using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(CharacterController))]
[Token(Token = "0x2000C51")]
public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
{
	[Token(Token = "0x4007D0A")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Token(Token = "0x4007D0B")]
	[FieldOffset(Offset = "0x24")]
	public float moveSpeed;

	[Token(Token = "0x4007D0C")]
	[FieldOffset(Offset = "0x28")]
	public float bulletSpeed;

	[Token(Token = "0x4007D0D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4007D0E")]
	[FieldOffset(Offset = "0x38")]
	private CharacterController cc;

	[Token(Token = "0x4007D0F")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 moveVector;

	[Token(Token = "0x4007D10")]
	[FieldOffset(Offset = "0x4C")]
	private bool fire;

	[Token(Token = "0x170006AD")]
	private Player player
	{
		[Token(Token = "0x60063C8")]
		[Address(RVA = "0xFD77B0", Offset = "0xFD65B0", Length = "0xCA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60063C9")]
	[Address(RVA = "0xFD7880", Offset = "0xFD6680", Length = "0x8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60063CA")]
	[Address(RVA = "0xFD7910", Offset = "0xFD6710", Length = "0x16D")]
	private void Update()
	{
	}

	[Token(Token = "0x60063CB")]
	[Address(RVA = "0xFD7A80", Offset = "0xFD6880", Length = "0xC7")]
	private void GetInput()
	{
	}

	[Token(Token = "0x60063CC")]
	[Address(RVA = "0xFD7B50", Offset = "0xFD6950", Length = "0x52F")]
	private void ProcessInput()
	{
	}

	[Token(Token = "0x60063CD")]
	[Address(RVA = "0xFD25B0", Offset = "0xFD13B0", Length = "0x51")]
	public PressAnyButtonToJoinExample_GamePlayer()
	{
	}
}
