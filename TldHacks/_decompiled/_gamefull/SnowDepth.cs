using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200030F")]
public class SnowDepth : MonoBehaviour
{
	[Token(Token = "0x4001AEA")]
	public const float DEFAULT_DEPTH = 0.25f;

	[Token(Token = "0x4001AEB")]
	public const float DEEP_DEPTH_RANGE = 0.75f;

	[Range(0f, 1f)]
	[Token(Token = "0x4001AEC")]
	[FieldOffset(Offset = "0x20")]
	public float m_Depth;

	[Token(Token = "0x4001AED")]
	[FieldOffset(Offset = "0x24")]
	public float m_BorderSize;

	[Token(Token = "0x4001AEE")]
	[FieldOffset(Offset = "0x28")]
	public bool m_BorderIsFractionOfSize;

	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x6F8EF0", Offset = "0x6F7CF0", Length = "0xAF")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x6F8FA0", Offset = "0x6F7DA0", Length = "0xAF")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x6F9050", Offset = "0x6F7E50", Length = "0x55")]
	public SnowDepth()
	{
	}
}
