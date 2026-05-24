using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000462")]
public class FatigueBuff : MonoBehaviour
{
	[Range(0f, 100f)]
	[Token(Token = "0x40027B6")]
	[FieldOffset(Offset = "0x20")]
	public float m_InitialPercentDecrease;

	[Range(0f, 1f)]
	[Token(Token = "0x40027B7")]
	[FieldOffset(Offset = "0x24")]
	public float m_RateOfIncreaseScale;

	[Range(0f, 10f)]
	[Token(Token = "0x40027B8")]
	[FieldOffset(Offset = "0x28")]
	public float m_DurationHours;

	[SerializeField]
	[Token(Token = "0x40027B9")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40027BA")]
	[FieldOffset(Offset = "0x38")]
	private GearItem m_GearItem;

	[Token(Token = "0x600211F")]
	[Address(RVA = "0x80C0C0", Offset = "0x80AEC0", Length = "0x8C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002120")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6002121")]
	[Address(RVA = "0x80C150", Offset = "0x80AF50", Length = "0x345")]
	public void Apply(float normalizedValue)
	{
	}

	[Token(Token = "0x6002122")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FatigueBuff()
	{
	}
}
