using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000441")]
public class ScentRanges : MonoBehaviour
{
	[Token(Token = "0x4002643")]
	[FieldOffset(Offset = "0x20")]
	public float m_DistanceToPlayerIgnoreScent;

	[Header("Ranges")]
	[Token(Token = "0x4002644")]
	[FieldOffset(Offset = "0x24")]
	public int m_RawMeatScentRange;

	[Token(Token = "0x4002645")]
	[FieldOffset(Offset = "0x28")]
	public int m_RawFishScentRange;

	[Token(Token = "0x4002646")]
	[FieldOffset(Offset = "0x2C")]
	public int m_CookedMeatScentRange;

	[Token(Token = "0x4002647")]
	[FieldOffset(Offset = "0x30")]
	public int m_CookedFishScentRange;

	[Token(Token = "0x4002648")]
	[FieldOffset(Offset = "0x34")]
	public int m_GutsScentRange;

	[Token(Token = "0x4002649")]
	[FieldOffset(Offset = "0x38")]
	public int m_QuarterScentRange;

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x7E7F00", Offset = "0x7E6D00", Length = "0x148")]
	public float GetScentRange(ScentRangeCategory cat)
	{
		return 0f;
	}

	[Token(Token = "0x6002000")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ScentRanges()
	{
	}
}
