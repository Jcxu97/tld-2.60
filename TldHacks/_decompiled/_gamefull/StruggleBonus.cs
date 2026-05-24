using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004DE")]
public class StruggleBonus : MonoBehaviour
{
	[Token(Token = "0x20004DF")]
	public enum StruggleWeaponType
	{
		[Token(Token = "0x4002C79")]
		BareHands,
		[Token(Token = "0x4002C7A")]
		Knife,
		[Token(Token = "0x4002C7B")]
		Hatchet,
		[Token(Token = "0x4002C7C")]
		Prybar,
		[Token(Token = "0x4002C7D")]
		ImprovisedKnife,
		[Token(Token = "0x4002C7E")]
		ImprovisedHatchet,
		[Token(Token = "0x4002C7F")]
		Hammer,
		[Token(Token = "0x4002C80")]
		Revolver,
		[Token(Token = "0x4002C81")]
		Rifle,
		[Token(Token = "0x4002C82")]
		Bow,
		[Token(Token = "0x4002C83")]
		CougarClawKnife,
		[Token(Token = "0x4002C84")]
		SurvivalKnife
	}

	[Tooltip("How much to scale damage from player attacks during a struggle.")]
	[Range(0f, 20f)]
	[Token(Token = "0x4002C72")]
	[FieldOffset(Offset = "0x20")]
	public float m_DamageScalePercent;

	[Range(0.2f, 4f)]
	[Token(Token = "0x4002C73")]
	[FieldOffset(Offset = "0x24")]
	public float m_FleeChanceScale;

	[Range(0.2f, 4f)]
	[Token(Token = "0x4002C74")]
	[FieldOffset(Offset = "0x28")]
	public float m_TapIncrementScale;

	[Range(0.2f, 4f)]
	[Token(Token = "0x4002C75")]
	[FieldOffset(Offset = "0x2C")]
	public float m_BleedoutMinutesScale;

	[Token(Token = "0x4002C76")]
	[FieldOffset(Offset = "0x30")]
	public bool m_CanPuncture;

	[Token(Token = "0x4002C77")]
	[FieldOffset(Offset = "0x34")]
	public StruggleWeaponType m_StruggleWeaponType;

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6002511")]
	[Address(RVA = "0x8732D0", Offset = "0x8720D0", Length = "0x5F")]
	public StruggleBonus()
	{
	}
}
