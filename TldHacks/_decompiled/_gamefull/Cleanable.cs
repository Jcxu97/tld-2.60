using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000470")]
public class Cleanable : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x40027FD")]
	[FieldOffset(Offset = "0x20")]
	public GearItem[] m_RequiredGear;

	[HideInInspector]
	[Token(Token = "0x40027FE")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_RequiredGearUnits;

	[Token(Token = "0x40027FF")]
	[FieldOffset(Offset = "0x30")]
	public float m_ConditionIncreaseMin;

	[Token(Token = "0x4002800")]
	[FieldOffset(Offset = "0x34")]
	public float m_ConditionIncreaseMax;

	[Token(Token = "0x4002801")]
	[FieldOffset(Offset = "0x38")]
	public int m_DurationMinutesMin;

	[Token(Token = "0x4002802")]
	[FieldOffset(Offset = "0x3C")]
	public int m_DurationMinutesMax;

	[Token(Token = "0x4002803")]
	[FieldOffset(Offset = "0x40")]
	public string m_CleanAudio;

	[Token(Token = "0x4002804")]
	[FieldOffset(Offset = "0x48")]
	public ToolsItem[] m_CleanToolChoices;

	[Token(Token = "0x4002805")]
	[FieldOffset(Offset = "0x50")]
	public bool m_RequiresToolToClean;

	[Token(Token = "0x600214B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Cleanable()
	{
	}
}
