using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200052A")]
public class PoorCirculation : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002F93")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Range(0f, 30f)]
	[Token(Token = "0x4002F94")]
	[FieldOffset(Offset = "0x28")]
	private float m_BodyTemperatureReduction;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4002F95")]
	[FieldOffset(Offset = "0x2C")]
	private float m_WarmingUpMultiplier;

	[Token(Token = "0x17000278")]
	public float BodyTemperatureReduction
	{
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000279")]
	public float WarmingUpMultiplier
	{
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700027A")]
	[field: Token(Token = "0x4002F96")]
	[field: FieldOffset(Offset = "0x30")]
	public bool HasAffliction
	{
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x5027A0", Offset = "0x5015A0", Length = "0x5")]
		get;
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x5027B0", Offset = "0x5015B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x1700027B")]
	private string IconSpriteName
	{
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x8B3570", Offset = "0x8B2370", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x8B35C0", Offset = "0x8B23C0", Length = "0x1AB")]
	public void ApplyPoorCirculation(AfflictionOptions options = AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x8B3770", Offset = "0x8B2570", Length = "0x10C")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002778")]
	[Address(RVA = "0x7BDEB0", Offset = "0x7BCCB0", Length = "0x4A")]
	public PoorCirculation()
	{
	}
}
