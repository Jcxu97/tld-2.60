using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200018A")]
public class WanderRegion : MonoBehaviour
{
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x24")]
	public float m_WanderMinHours;

	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x28")]
	public float m_WanderMaxHours;

	[HideInInspector]
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_Used;

	[Token(Token = "0x6000F11")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WanderRegion()
	{
	}
}
