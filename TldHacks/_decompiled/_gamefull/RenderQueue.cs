using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A33")]
public class RenderQueue : MonoBehaviour
{
	[Token(Token = "0x400667F")]
	[FieldOffset(Offset = "0x20")]
	public int renderQueue;

	[Token(Token = "0x4006680")]
	[FieldOffset(Offset = "0x28")]
	private Material m_CachedMaterial;

	[Token(Token = "0x6005913")]
	[Address(RVA = "0xEEFB40", Offset = "0xEEE940", Length = "0xC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6005914")]
	[Address(RVA = "0xEEFC10", Offset = "0xEEEA10", Length = "0x4A")]
	public RenderQueue()
	{
	}
}
