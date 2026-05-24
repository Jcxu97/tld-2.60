using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003DD")]
public class ObjectColorFlickering : MonoBehaviour
{
	[Token(Token = "0x40022E0")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40022E1")]
	[FieldOffset(Offset = "0x24")]
	public Color color0;

	[Token(Token = "0x40022E2")]
	[FieldOffset(Offset = "0x34")]
	public Color color1;

	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x7B2780", Offset = "0x7B1580", Length = "0x13B")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x7B28C0", Offset = "0x7B16C0", Length = "0x6A")]
	public ObjectColorFlickering()
	{
	}
}
