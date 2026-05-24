using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(CharacterController))]
[Token(Token = "0x2000C45")]
public class CustomControllerDemo_Player : MonoBehaviour
{
	[Token(Token = "0x4007CC9")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Token(Token = "0x4007CCA")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x4007CCB")]
	[FieldOffset(Offset = "0x28")]
	public float bulletSpeed;

	[Token(Token = "0x4007CCC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4007CCD")]
	[FieldOffset(Offset = "0x38")]
	private Player _player;

	[Token(Token = "0x4007CCE")]
	[FieldOffset(Offset = "0x40")]
	private CharacterController cc;

	[Token(Token = "0x170006A8")]
	private Player player
	{
		[Token(Token = "0x6006371")]
		[Address(RVA = "0xFCE690", Offset = "0xFCD490", Length = "0xC5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006372")]
	[Address(RVA = "0xFCE760", Offset = "0xFCD560", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006373")]
	[Address(RVA = "0xFCE7F0", Offset = "0xFCD5F0", Length = "0x68F")]
	private void Update()
	{
	}

	[Token(Token = "0x6006374")]
	[Address(RVA = "0xFCEE80", Offset = "0xFCDC80", Length = "0x51")]
	public CustomControllerDemo_Player()
	{
	}
}
