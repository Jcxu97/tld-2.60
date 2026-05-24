using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008F2")]
public class RenderObjectInstanceVolume : MonoBehaviour
{
	[Token(Token = "0x4005DB6")]
	[FieldOffset(Offset = "0x20")]
	public float m_TriggerDistance;

	[Token(Token = "0x4005DB7")]
	[FieldOffset(Offset = "0x24")]
	public float m_Lod2Distance;

	[Token(Token = "0x4005DB8")]
	[FieldOffset(Offset = "0x28")]
	public float m_CullDistance;

	[Token(Token = "0x4005DB9")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_CachedPosition;

	[Token(Token = "0x600520B")]
	[Address(RVA = "0xE3B7D0", Offset = "0xE3A5D0", Length = "0x129")]
	private void Awake()
	{
	}

	[Token(Token = "0x600520C")]
	[Address(RVA = "0xE3B900", Offset = "0xE3A700", Length = "0x13")]
	public Vector3 GetCachedPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600520D")]
	[Address(RVA = "0xE3B920", Offset = "0xE3A720", Length = "0x51")]
	public RenderObjectInstanceVolume()
	{
	}
}
