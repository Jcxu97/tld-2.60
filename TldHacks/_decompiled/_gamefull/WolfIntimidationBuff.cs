using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200046C")]
public class WolfIntimidationBuff : MonoBehaviour
{
	[Range(0f, 100f)]
	[Token(Token = "0x40027E5")]
	[FieldOffset(Offset = "0x20")]
	public float m_IncreaseFleePercentagePoints;

	[Range(0f, 100f)]
	[Token(Token = "0x40027E6")]
	[FieldOffset(Offset = "0x24")]
	public float m_DecreaseAttackChancePercentagePoints;

	[Token(Token = "0x6002138")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6002139")]
	[Address(RVA = "0x80DB20", Offset = "0x80C920", Length = "0x64")]
	public void Apply()
	{
	}

	[Token(Token = "0x600213A")]
	[Address(RVA = "0x80DB90", Offset = "0x80C990", Length = "0x54")]
	public void Remove()
	{
	}

	[Token(Token = "0x600213B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WolfIntimidationBuff()
	{
	}
}
