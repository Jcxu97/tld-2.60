using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000460")]
public class ConditionOverTimeBuff : MonoBehaviour
{
	[Range(0f, 100f)]
	[Token(Token = "0x40027B0")]
	[FieldOffset(Offset = "0x20")]
	public float m_ConditionIncreasePerHour;

	[Tooltip("Multiple applications of buff will extend duration without affecting restoration rate")]
	[Range(0f, 10f)]
	[Token(Token = "0x40027B1")]
	[FieldOffset(Offset = "0x24")]
	public float m_NumHours;

	[SerializeField]
	[Token(Token = "0x40027B2")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x600211A")]
	[Address(RVA = "0x80BDD0", Offset = "0x80ABD0", Length = "0x120")]
	public void Apply(float normalizedValue)
	{
	}

	[Token(Token = "0x600211B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ConditionOverTimeBuff()
	{
	}
}
