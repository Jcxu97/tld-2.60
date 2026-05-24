using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[Serializable]
[Token(Token = "0x20013D2")]
public class FlickerTemporalParameters
{
	[Range(0.1f, 10f)]
	[Token(Token = "0x4009145")]
	[FieldOffset(Offset = "0x10")]
	public float m_SampleRate;

	[Token(Token = "0x4009146")]
	[FieldOffset(Offset = "0x18")]
	public MinMax m_StartTimeVariance;

	[Token(Token = "0x4009147")]
	[FieldOffset(Offset = "0x20")]
	public MinMax m_SampleRateVariance;

	[Token(Token = "0x6007E98")]
	[Address(RVA = "0x11DEAE0", Offset = "0x11DD8E0", Length = "0x28")]
	public float GetRandomStartTime()
	{
		return 0f;
	}

	[Token(Token = "0x6007E99")]
	[Address(RVA = "0x11DEB10", Offset = "0x11DD910", Length = "0x28")]
	public float GetRandomRate()
	{
		return 0f;
	}

	[Token(Token = "0x6007E9A")]
	[Address(RVA = "0x11E23F0", Offset = "0x11E11F0", Length = "0x126")]
	public FlickerTemporalParameters()
	{
	}
}
