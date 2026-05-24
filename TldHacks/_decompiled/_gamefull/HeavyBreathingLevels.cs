using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20001E6")]
public struct HeavyBreathingLevels
{
	[Range(0f, 100f)]
	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0x0")]
	public float m_Light;

	[Range(0f, 100f)]
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x4")]
	public float m_Medium;

	[Range(0f, 100f)]
	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x8")]
	public float m_Heavy;

	[Token(Token = "0x170001B9")]
	public float this[HeavyBreathingState state]
	{
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x63B890", Offset = "0x63A690", Length = "0x28")]
		get
		{
			return 0f;
		}
	}
}
