using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.Utility;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001410")]
public class IngestedCarryCapacityBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	[SerializeField]
	[Token(Token = "0x4009284")]
	[FieldOffset(Offset = "0x20")]
	private float m_CarryCapacityBuffDurationInHours;

	[SerializeField]
	[Token(Token = "0x4009285")]
	[FieldOffset(Offset = "0x28")]
	private ItemWeight m_CarryCapacityChange;

	[Header("Notification")]
	[SerializeField]
	[Token(Token = "0x4009286")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_BuffAppliedText;

	[SerializeField]
	[Token(Token = "0x4009287")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_BuffTypeText;

	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x4009288")]
	[FieldOffset(Offset = "0x40")]
	private string m_BuffIcon;

	[Token(Token = "0x6007FD9")]
	[Address(RVA = "0x11FE020", Offset = "0x11FCE20", Length = "0x2B0")]
	public void Apply(float fractionConsumed)
	{
	}

	[Token(Token = "0x6007FDA")]
	[Address(RVA = "0x11FE2E0", Offset = "0x11FD0E0", Length = "0xA8")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[Token(Token = "0x6007FDB")]
	[Address(RVA = "0x11FE390", Offset = "0x11FD190", Length = "0x4A")]
	public IngestedCarryCapacityBuff()
	{
	}
}
