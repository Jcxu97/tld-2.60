using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000463")]
public class FreezingBuff : MonoBehaviour
{
	[Range(0f, 100f)]
	[Token(Token = "0x40027BB")]
	[FieldOffset(Offset = "0x20")]
	public float m_InitialPercentDecrease;

	[Range(0f, 1f)]
	[Token(Token = "0x40027BC")]
	[FieldOffset(Offset = "0x24")]
	public float m_RateOfIncreaseScale;

	[Range(0f, 10f)]
	[Token(Token = "0x40027BD")]
	[FieldOffset(Offset = "0x28")]
	public float m_DurationHours;

	[SerializeField]
	[Token(Token = "0x40027BE")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x6002123")]
	[Address(RVA = "0x80C4A0", Offset = "0x80B2A0", Length = "0x1BE")]
	public void Apply(float normalizedValue)
	{
	}

	[Token(Token = "0x6002124")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FreezingBuff()
	{
	}
}
