using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200029D")]
public class DestroyGameObjectAfterTime : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0x20")]
	private float m_Lifetime;

	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0x24")]
	private float m_TimeRemaining;

	[Token(Token = "0x6001657")]
	[Address(RVA = "0x6B7200", Offset = "0x6B6000", Length = "0xB")]
	public void SetLifetime(float lifetime)
	{
	}

	[Token(Token = "0x6001658")]
	[Address(RVA = "0x6B7210", Offset = "0x6B6010", Length = "0x8")]
	public void Disable()
	{
	}

	[Token(Token = "0x6001659")]
	[Address(RVA = "0x6B7220", Offset = "0x6B6020", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600165A")]
	[Address(RVA = "0x6B7230", Offset = "0x6B6030", Length = "0x111")]
	private void Update()
	{
	}

	[Token(Token = "0x600165B")]
	[Address(RVA = "0x6B7350", Offset = "0x6B6150", Length = "0x51")]
	public DestroyGameObjectAfterTime()
	{
	}
}
