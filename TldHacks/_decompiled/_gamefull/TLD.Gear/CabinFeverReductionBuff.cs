using Cpp2ILInjected;
using TLD.Utility;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001407")]
public class CabinFeverReductionBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	[SerializeField]
	[Token(Token = "0x4009262")]
	[FieldOffset(Offset = "0x20")]
	private float m_RiskReductionInHours;

	[SerializeField]
	[Token(Token = "0x4009263")]
	[FieldOffset(Offset = "0x24")]
	private float m_FeverReductionInHours;

	[SerializeField]
	[Token(Token = "0x4009264")]
	[FieldOffset(Offset = "0x28")]
	private float m_BuffCooldownInHours;

	[Header("Notification")]
	[SerializeField]
	[Token(Token = "0x4009265")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_BuffAppliedText;

	[SerializeField]
	[Token(Token = "0x4009266")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_BuffTypeText;

	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x4009267")]
	[FieldOffset(Offset = "0x40")]
	private string m_BuffIcon;

	[Token(Token = "0x6007FB6")]
	[Address(RVA = "0x11FC650", Offset = "0x11FB450", Length = "0x217")]
	public void Apply(float fractionConsumed)
	{
	}

	[Token(Token = "0x6007FB7")]
	[Address(RVA = "0x11FC870", Offset = "0x11FB670", Length = "0x9")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x6007FB8")]
	[Address(RVA = "0x11FC880", Offset = "0x11FB680", Length = "0x58")]
	public CabinFeverReductionBuff()
	{
	}
}
