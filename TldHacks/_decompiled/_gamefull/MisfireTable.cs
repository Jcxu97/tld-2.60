using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 15000)]
[Token(Token = "0x20004E9")]
public class MisfireTable : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20004EA")]
	public struct Range
	{
		[Range(0f, 100f)]
		[Token(Token = "0x4002CE7")]
		[FieldOffset(Offset = "0x0")]
		public float m_Minimum;

		[Range(0f, 100f)]
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x4")]
		public float m_Maximum;

		[Range(0f, 100f)]
		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x8")]
		public float m_FailurePercentage;
	}

	[Range(0f, 100f)]
	[Token(Token = "0x4002CE4")]
	[FieldOffset(Offset = "0x18")]
	public float m_AlwaysSucceedThreshold;

	[Range(0f, 100f)]
	[Token(Token = "0x4002CE5")]
	[FieldOffset(Offset = "0x1C")]
	public float m_AlwaysFailThreshold;

	[Token(Token = "0x4002CE6")]
	[FieldOffset(Offset = "0x20")]
	public List<Range> m_Ranges;

	[Token(Token = "0x6002551")]
	[Address(RVA = "0x878D40", Offset = "0x877B40", Length = "0x1DD")]
	public bool DoesMisfire(float condition)
	{
		return false;
	}

	[Token(Token = "0x6002552")]
	[Address(RVA = "0x878F20", Offset = "0x877D20", Length = "0xB6")]
	public MisfireTable()
	{
	}
}
