using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C43")]
public class CustomControllersTiltDemo : MonoBehaviour
{
	[Token(Token = "0x4007CBA")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4007CBB")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4007CBC")]
	[FieldOffset(Offset = "0x30")]
	private CustomController controller;

	[Token(Token = "0x4007CBD")]
	[FieldOffset(Offset = "0x38")]
	private Player player;

	[Token(Token = "0x6006362")]
	[Address(RVA = "0xFCCFF0", Offset = "0xFCBDF0", Length = "0x334")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006363")]
	[Address(RVA = "0xFCD330", Offset = "0xFCC130", Length = "0x2B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6006364")]
	[Address(RVA = "0xFCD5F0", Offset = "0xFCC3F0", Length = "0xAF")]
	private void OnInputUpdate()
	{
	}

	[Token(Token = "0x6006365")]
	[Address(RVA = "0x7B6A30", Offset = "0x7B5830", Length = "0x4A")]
	public CustomControllersTiltDemo()
	{
	}
}
