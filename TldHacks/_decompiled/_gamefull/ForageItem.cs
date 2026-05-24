using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000494")]
public class ForageItem : MonoBehaviour
{
	[Token(Token = "0x40029D8")]
	[FieldOffset(Offset = "0x20")]
	public float m_TinderUnitsPerHourOutdoor;

	[Token(Token = "0x40029D9")]
	[FieldOffset(Offset = "0x24")]
	public float m_TinderUnitsPerHourIndoor;

	[Token(Token = "0x40029DA")]
	[FieldOffset(Offset = "0x28")]
	public float m_SoftwoodUnitsPerHour;

	[Token(Token = "0x40029DB")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HardwoodUnitsPerHour;

	[Token(Token = "0x40029DC")]
	[FieldOffset(Offset = "0x30")]
	public float m_ReclaimedWoodUnitsPerHour;

	[Token(Token = "0x40029DD")]
	[FieldOffset(Offset = "0x34")]
	public float m_HPDecreasePerHourForaging;

	[Token(Token = "0x600228B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x600228C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ForageItem()
	{
	}
}
