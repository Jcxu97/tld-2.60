using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/DamageEventTable")]
[Token(Token = "0x200016C")]
public class DamageEventTable : ScriptableObject
{
	[Flags]
	[Token(Token = "0x200016D")]
	public enum ApplyAttackOpts
	{
		[Token(Token = "0x4000D54")]
		None = 0,
		[Token(Token = "0x4000D55")]
		FadeoutEventUi = 1,
		[Token(Token = "0x4000D56")]
		ResetEvents = 2
	}

	[Header("Events")]
	[SerializeField]
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x18")]
	private BloodLossEvent m_BloodLossEvent;

	[SerializeField]
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x20")]
	private SprainedAnkleEvent m_SprainedAnkleEvent;

	[SerializeField]
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x28")]
	private SprainedWristEvent m_SprainedWristEvent;

	[SerializeField]
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x30")]
	private LacerationEvent m_LacerationEvent;

	[SerializeField]
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x38")]
	private MinorBruisingEvent m_MinorBruisingEvent;

	[SerializeField]
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x40")]
	private MajorBruisingEvent m_MajorBruisingEvent;

	[SerializeField]
	[Token(Token = "0x4000D4E")]
	[FieldOffset(Offset = "0x48")]
	private ClothingDamageEvent m_ClothingDamageEvent;

	[Header("UI Settings")]
	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0x50")]
	private float m_SecondsBeforeFadeout;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x54")]
	private float m_FadeoutSeconds;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x60")]
	private StruggleDamageEvent[] m_DamageEvents;

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x5E88F0", Offset = "0x5E76F0", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x5E8900", Offset = "0x5E7700", Length = "0x9")]
	public bool IsInitialized()
	{
		return false;
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x5E8910", Offset = "0x5E7710", Length = "0x276")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x5E8B90", Offset = "0x5E7990", Length = "0x94")]
	public void FadeOutEventUi(float withDelay)
	{
	}

	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x5E8C30", Offset = "0x5E7A30", Length = "0x43")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x5E8C80", Offset = "0x5E7A80", Length = "0x199")]
	public StruggleDamageEvent GetWeightedRandomAttack()
	{
		return null;
	}

	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x5E8E20", Offset = "0x5E7C20", Length = "0x1B9")]
	public StruggleDamageEvent MaybeApplyAttack(BaseAi instigator, ApplyAttackOpts opts)
	{
		return null;
	}

	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x5E8FE0", Offset = "0x5E7DE0", Length = "0x15")]
	public DamageEventTable()
	{
	}
}
