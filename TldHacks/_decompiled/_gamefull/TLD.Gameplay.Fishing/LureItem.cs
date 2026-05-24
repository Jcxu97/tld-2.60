using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

[Token(Token = "0x20014C5")]
public class LureItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40095F0")]
	[FieldOffset(Offset = "0x20")]
	private float m_CatchModifier;

	[SerializeField]
	[Token(Token = "0x40095F1")]
	[FieldOffset(Offset = "0x24")]
	private float m_RareFishModifier;

	[Token(Token = "0x17000B5F")]
	public float CatchModifier
	{
		[Token(Token = "0x6008302")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B60")]
	public float RareFishModifier
	{
		[Token(Token = "0x6008303")]
		[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6008304")]
	[Address(RVA = "0x11240B0", Offset = "0x1122EB0", Length = "0x51")]
	public LureItem()
	{
	}
}
