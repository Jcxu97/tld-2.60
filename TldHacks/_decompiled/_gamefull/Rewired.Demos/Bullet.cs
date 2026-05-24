using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C55")]
public class Bullet : MonoBehaviour
{
	[Token(Token = "0x4007D1E")]
	[FieldOffset(Offset = "0x20")]
	public float lifeTime;

	[Token(Token = "0x4007D1F")]
	[FieldOffset(Offset = "0x24")]
	private bool die;

	[Token(Token = "0x4007D20")]
	[FieldOffset(Offset = "0x28")]
	private float deathTime;

	[Token(Token = "0x60063DB")]
	[Address(RVA = "0xFD9200", Offset = "0xFD8000", Length = "0x66")]
	private void Start()
	{
	}

	[Token(Token = "0x60063DC")]
	[Address(RVA = "0xFD9270", Offset = "0xFD8070", Length = "0xEB")]
	private void Update()
	{
	}

	[Token(Token = "0x60063DD")]
	[Address(RVA = "0xFD9360", Offset = "0xFD8160", Length = "0x4A")]
	public Bullet()
	{
	}
}
