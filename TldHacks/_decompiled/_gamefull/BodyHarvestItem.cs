using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000458")]
public class BodyHarvestItem : MonoBehaviour
{
	[Token(Token = "0x4002781")]
	[FieldOffset(Offset = "0x20")]
	public float m_HarvestMeatMinutesPerKG;

	[Token(Token = "0x4002782")]
	[FieldOffset(Offset = "0x24")]
	public float m_HarvestFrozenMeatMinutesPerKG;

	[Token(Token = "0x4002783")]
	[FieldOffset(Offset = "0x28")]
	public float m_HarvestHideMinutesPerUnit;

	[Token(Token = "0x4002784")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HarvestGutMinutesPerUnit;

	[Token(Token = "0x4002785")]
	[FieldOffset(Offset = "0x30")]
	public float m_HPDecreasePerHourUse;

	[Token(Token = "0x60020D7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60020D8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BodyHarvestItem()
	{
	}
}
