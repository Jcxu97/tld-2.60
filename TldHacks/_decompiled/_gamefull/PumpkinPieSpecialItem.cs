using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004C8")]
public class PumpkinPieSpecialItem : MonoBehaviour
{
	[Range(0f, 100f)]
	[Token(Token = "0x4002BFD")]
	[FieldOffset(Offset = "0x20")]
	public float m_FreezingInitialPercentDecrease;

	[Range(0f, 1f)]
	[Token(Token = "0x4002BFE")]
	[FieldOffset(Offset = "0x24")]
	public float m_FreezingRateOfIncreaseScale;

	[Token(Token = "0x4002BFF")]
	[FieldOffset(Offset = "0x28")]
	public float m_DurationHours;

	[Token(Token = "0x4002C00")]
	[FieldOffset(Offset = "0x30")]
	private GearItem m_GearItem;

	[Token(Token = "0x6002485")]
	[Address(RVA = "0x86A090", Offset = "0x868E90", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002486")]
	[Address(RVA = "0x86A120", Offset = "0x868F20", Length = "0x13F")]
	private void Update()
	{
	}

	[Token(Token = "0x6002487")]
	[Address(RVA = "0x86A260", Offset = "0x869060", Length = "0x112")]
	public void Apply(float normalizedValue)
	{
	}

	[Token(Token = "0x6002488")]
	[Address(RVA = "0x86A380", Offset = "0x869180", Length = "0x4EF")]
	private void Hide(bool hide)
	{
	}

	[Token(Token = "0x6002489")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PumpkinPieSpecialItem()
	{
	}
}
