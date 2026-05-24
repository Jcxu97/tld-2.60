using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x200140D")]
public class FoodStatEffect : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	[Token(Token = "0x200140E")]
	public enum StatType
	{
		[Token(Token = "0x400927E")]
		Condition,
		[Token(Token = "0x400927F")]
		Stamina,
		[Token(Token = "0x4009280")]
		Fatigue,
		[Token(Token = "0x4009281")]
		Freezing,
		[Token(Token = "0x4009282")]
		Thirst,
		[Token(Token = "0x4009283")]
		Hunger
	}

	[SerializeField]
	[Token(Token = "0x400927B")]
	[FieldOffset(Offset = "0x20")]
	private StatType m_Stat;

	[SerializeField]
	[Token(Token = "0x400927C")]
	[FieldOffset(Offset = "0x24")]
	private float m_Effect;

	[Token(Token = "0x6007FD4")]
	[Address(RVA = "0x11FDDE0", Offset = "0x11FCBE0", Length = "0x1D7")]
	public void Apply(float fractionConsumed)
	{
	}

	[Token(Token = "0x6007FD5")]
	[Address(RVA = "0x11FDFC0", Offset = "0x11FCDC0", Length = "0xF")]
	public float GetStatEffect(StatType stat)
	{
		return 0f;
	}

	[Token(Token = "0x6007FD6")]
	[Address(RVA = "0x11FDFD0", Offset = "0x11FCDD0", Length = "0x44")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x6007FD7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FoodStatEffect()
	{
	}
}
