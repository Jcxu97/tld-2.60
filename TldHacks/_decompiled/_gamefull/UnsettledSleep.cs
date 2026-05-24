using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200053B")]
public class UnsettledSleep : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003030")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Range(0f, 6f)]
	[Token(Token = "0x4003031")]
	[FieldOffset(Offset = "0x28")]
	private int m_MaxSleepReduction;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4003032")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ConditionRecoveryDuringSleepMultiplier;

	[Token(Token = "0x1700028A")]
	public int MaxSleepReduction
	{
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700028B")]
	public float ConditionRecoveryDuringSleepMultiplier
	{
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700028C")]
	[field: Token(Token = "0x4003033")]
	[field: FieldOffset(Offset = "0x30")]
	public bool HasAffliction
	{
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x5027A0", Offset = "0x5015A0", Length = "0x5")]
		get;
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x5027B0", Offset = "0x5015B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x1700028D")]
	private string IconSpriteName
	{
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x8BDDD0", Offset = "0x8BCBD0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002805")]
	[Address(RVA = "0x8BDE20", Offset = "0x8BCC20", Length = "0x1AB")]
	public void ApplyUnsettledSleep(AfflictionOptions options = AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002806")]
	[Address(RVA = "0x8BDFD0", Offset = "0x8BCDD0", Length = "0x10C")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002807")]
	[Address(RVA = "0x7BDEB0", Offset = "0x7BCCB0", Length = "0x4A")]
	public UnsettledSleep()
	{
	}
}
