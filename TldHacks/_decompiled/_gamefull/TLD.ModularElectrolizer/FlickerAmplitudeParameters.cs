using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[Serializable]
[Token(Token = "0x20013CE")]
public class FlickerAmplitudeParameters
{
	[Token(Token = "0x4009134")]
	[FieldOffset(Offset = "0x10")]
	public MinMax m_CurveRange;

	[Range(0f, 1f)]
	[Token(Token = "0x4009135")]
	[FieldOffset(Offset = "0x18")]
	public float m_CurveBias;

	[Range(0.1f, 4f)]
	[Token(Token = "0x4009136")]
	[FieldOffset(Offset = "0x1C")]
	public float m_CurveGain;

	[Token(Token = "0x6007E90")]
	[Address(RVA = "0x11E1EA0", Offset = "0x11E0CA0", Length = "0xA0")]
	public FlickerAmplitudeParameters()
	{
	}
}
