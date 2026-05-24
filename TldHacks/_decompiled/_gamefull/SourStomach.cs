using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200052E")]
public class SourStomach : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002FA9")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Range(0f, 2500f)]
	[Token(Token = "0x4002FAA")]
	[FieldOffset(Offset = "0x28")]
	private float m_HungerMaxCalorieReduction;

	[SerializeField]
	[Range(1f, 3f)]
	[Token(Token = "0x4002FAB")]
	[FieldOffset(Offset = "0x2C")]
	private float m_FoodPoisoningChanceMultiplier;

	[SerializeField]
	[Range(1f, 2f)]
	[Token(Token = "0x4002FAC")]
	[FieldOffset(Offset = "0x30")]
	private float m_IntestinalParasitesChanceMultiplier;

	[Token(Token = "0x17000281")]
	public float HungerMaxCalorieReduction
	{
		[Token(Token = "0x600278F")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000282")]
	public float FoodPoisoningChanceMultiplier
	{
		[Token(Token = "0x6002790")]
		[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000283")]
	public float IntestinalParasitesChanceMultiplier
	{
		[Token(Token = "0x6002791")]
		[Address(RVA = "0x5093E0", Offset = "0x5081E0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000284")]
	[field: Token(Token = "0x4002FAD")]
	[field: FieldOffset(Offset = "0x34")]
	public bool HasAffliction
	{
		[Token(Token = "0x6002792")]
		[Address(RVA = "0x8B5020", Offset = "0x8B3E20", Length = "0x5")]
		get;
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x8B5030", Offset = "0x8B3E30", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000285")]
	private string IconSpriteName
	{
		[Token(Token = "0x6002794")]
		[Address(RVA = "0x8B5040", Offset = "0x8B3E40", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0x8B5090", Offset = "0x8B3E90", Length = "0x1AB")]
	public void ApplySourStomach(AfflictionOptions options = AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002796")]
	[Address(RVA = "0x8B5240", Offset = "0x8B4040", Length = "0x10C")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002797")]
	[Address(RVA = "0x8B5350", Offset = "0x8B4150", Length = "0x51")]
	public SourStomach()
	{
	}
}
