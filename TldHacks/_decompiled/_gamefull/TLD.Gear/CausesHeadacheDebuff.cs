using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001408")]
public class CausesHeadacheDebuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	[SerializeField]
	[Token(Token = "0x4009268")]
	[FieldOffset(Offset = "0x20")]
	private HeadacheData m_HeadacheSettings;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4009269")]
	[FieldOffset(Offset = "0x28")]
	private float m_CausesHeadacheThreshold;

	[Token(Token = "0x6007FB9")]
	[Address(RVA = "0x11FC8E0", Offset = "0x11FB6E0", Length = "0x1CC")]
	public void Apply(float fractionConsumed)
	{
	}

	[Token(Token = "0x6007FBA")]
	[Address(RVA = "0x11FCAB0", Offset = "0x11FB8B0", Length = "0xB")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x6007FBB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CausesHeadacheDebuff()
	{
	}
}
