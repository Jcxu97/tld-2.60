using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000461")]
public class ConditionRestBuff : MonoBehaviour, IFoodEffect
{
	[Range(0f, 100f)]
	[Token(Token = "0x40027B3")]
	[FieldOffset(Offset = "0x20")]
	public float m_ConditionRestBonus;

	[Range(0f, 10f)]
	[Token(Token = "0x40027B4")]
	[FieldOffset(Offset = "0x24")]
	public float m_NumHoursRestAffected;

	[SerializeField]
	[Token(Token = "0x40027B5")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x600211C")]
	[Address(RVA = "0x80BF00", Offset = "0x80AD00", Length = "0x1A0")]
	public void Apply(float normalizedValue)
	{
	}

	[Token(Token = "0x600211D")]
	[Address(RVA = "0x80C0B0", Offset = "0x80AEB0", Length = "0x9")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x600211E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ConditionRestBuff()
	{
	}
}
