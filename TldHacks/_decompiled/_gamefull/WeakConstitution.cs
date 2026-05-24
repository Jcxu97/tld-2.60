using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x200053C")]
public class WeakConstitution : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003034")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003035")]
	[FieldOffset(Offset = "0x28")]
	private float m_StaminaBarReduction;

	[SerializeField]
	[Token(Token = "0x4003036")]
	[FieldOffset(Offset = "0x30")]
	private ItemWeight m_CarryCapacityDecrease;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4003037")]
	[FieldOffset(Offset = "0x38")]
	private float m_WolfStruggleFleeChanceMultiplier;

	[Token(Token = "0x1700028E")]
	public float StaminaBarReduction
	{
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700028F")]
	public ItemWeight CarryCapacityDecrease
	{
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return default(ItemWeight);
		}
	}

	[Token(Token = "0x17000290")]
	public float WolfStruggleFleeChanceModifier
	{
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000291")]
	[field: Token(Token = "0x4003038")]
	[field: FieldOffset(Offset = "0x3C")]
	public bool HasAffliction
	{
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x4C38C0", Offset = "0x4C26C0", Length = "0x5")]
		get;
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x8BE0E0", Offset = "0x8BCEE0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000292")]
	private string IconSpriteName
	{
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x8BE0F0", Offset = "0x8BCEF0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600280E")]
	[Address(RVA = "0x8BE140", Offset = "0x8BCF40", Length = "0x1AB")]
	public void ApplyWeakConstitution(AfflictionOptions options = AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x600280F")]
	[Address(RVA = "0x8BE2F0", Offset = "0x8BD0F0", Length = "0x10C")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002810")]
	[Address(RVA = "0x5CF1E0", Offset = "0x5CDFE0", Length = "0x4A")]
	public WeakConstitution()
	{
	}
}
