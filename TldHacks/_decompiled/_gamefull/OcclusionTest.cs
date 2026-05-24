using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003DE")]
public class OcclusionTest : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40022E3")]
	[FieldOffset(Offset = "0x20")]
	private float m_OcclusionPollIntervalSeconds;

	[SerializeField]
	[Token(Token = "0x40022E4")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsOccluded;

	[Token(Token = "0x40022E5")]
	[FieldOffset(Offset = "0x28")]
	private float m_CurrentTime;

	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x7B2930", Offset = "0x7B1730", Length = "0xD3")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E08")]
	[Address(RVA = "0x7B2A10", Offset = "0x7B1810", Length = "0x384")]
	private bool CheckOcclusion()
	{
		return false;
	}

	[Token(Token = "0x6001E09")]
	[Address(RVA = "0x621E50", Offset = "0x620C50", Length = "0x5")]
	public bool IsOccluded()
	{
		return false;
	}

	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x784250", Offset = "0x783050", Length = "0x4E")]
	public OcclusionTest()
	{
	}
}
