using Cpp2ILInjected;
using TLD.Utility;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x20013FB")]
public class ResistInsomniaBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	[SerializeField]
	[Token(Token = "0x4009224")]
	[FieldOffset(Offset = "0x20")]
	private float m_CarryCapacityBuffDurationInHours;

	[Tooltip("Reduce odds of breaking sleep by this fraction. 0 eliminates any chance and 1 has no effect on risk.")]
	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4009225")]
	[FieldOffset(Offset = "0x24")]
	private float m_SleepInterruptionMultiplier;

	[Header("Notification")]
	[SerializeField]
	[Token(Token = "0x4009226")]
	[FieldOffset(Offset = "0x28")]
	private LocalizedString m_BuffAppliedText;

	[SerializeField]
	[Token(Token = "0x4009227")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_BuffTypeText;

	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x4009228")]
	[FieldOffset(Offset = "0x38")]
	private string m_BuffIcon;

	[Token(Token = "0x6007F71")]
	[Address(RVA = "0x11F64D0", Offset = "0x11F52D0", Length = "0x1E4")]
	public void Apply(float fractionConsumed)
	{
	}

	[Token(Token = "0x6007F72")]
	[Address(RVA = "0x80C0B0", Offset = "0x80AEB0", Length = "0x9")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x6007F73")]
	[Address(RVA = "0x11F66C0", Offset = "0x11F54C0", Length = "0x51")]
	public ResistInsomniaBuff()
	{
	}
}
