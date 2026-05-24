using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001409")]
public class FoodMaxStatBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	[Token(Token = "0x200140A")]
	public enum StatType
	{
		[Token(Token = "0x400926F")]
		Condition,
		[Token(Token = "0x4009270")]
		Stamina
	}

	[SerializeField]
	[Token(Token = "0x400926A")]
	[FieldOffset(Offset = "0x20")]
	private StatType m_Stat;

	[SerializeField]
	[Token(Token = "0x400926B")]
	[FieldOffset(Offset = "0x24")]
	private float m_Buff;

	[SerializeField]
	[Token(Token = "0x400926C")]
	[FieldOffset(Offset = "0x28")]
	private float m_TimeActiveHours;

	[Tooltip("If false, will prevent stacking with other FoodMaxStatBuff")]
	[SerializeField]
	[Token(Token = "0x400926D")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_CanStack;

	[Token(Token = "0x6007FBC")]
	[Address(RVA = "0x11FCAC0", Offset = "0x11FB8C0", Length = "0x16A")]
	public void Apply(float fractionConsumed)
	{
	}

	[Token(Token = "0x6007FBD")]
	[Address(RVA = "0x11FCC30", Offset = "0x11FBA30", Length = "0x22")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x6007FBE")]
	[Address(RVA = "0x11FCC60", Offset = "0x11FBA60", Length = "0x47")]
	public FoodMaxStatBuff()
	{
	}
}
