using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004D0")]
public class Sharpenable : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4002C1E")]
	[FieldOffset(Offset = "0x20")]
	public GearItem[] m_RequiredGear;

	[HideInInspector]
	[Token(Token = "0x4002C1F")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_RequiredGearUnits;

	[Token(Token = "0x4002C20")]
	[FieldOffset(Offset = "0x30")]
	public float m_ConditionIncreaseMin;

	[Token(Token = "0x4002C21")]
	[FieldOffset(Offset = "0x34")]
	public float m_ConditionIncreaseMax;

	[Token(Token = "0x4002C22")]
	[FieldOffset(Offset = "0x38")]
	public int m_DurationMinutesMin;

	[Token(Token = "0x4002C23")]
	[FieldOffset(Offset = "0x3C")]
	public int m_DurationMinutesMax;

	[Token(Token = "0x4002C24")]
	[FieldOffset(Offset = "0x40")]
	public string m_SharpenAudio;

	[Token(Token = "0x4002C25")]
	[FieldOffset(Offset = "0x48")]
	public ToolsItem[] m_SharpenToolChoices;

	[Token(Token = "0x4002C26")]
	[FieldOffset(Offset = "0x50")]
	public bool m_RequiresToolToSharpen;

	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Sharpenable()
	{
	}
}
