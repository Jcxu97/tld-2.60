using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000A37")]
public struct ScaledCurve
{
	[Token(Token = "0x400668F")]
	[FieldOffset(Offset = "0x0")]
	public AnimationCurve curve;

	[Token(Token = "0x6005921")]
	[Address(RVA = "0xEF0D10", Offset = "0xEEFB10", Length = "0xE1")]
	public ScaledCurve(float startVal, float endVal, bool easeInEaseOut = false)
	{
		curve = null;
	}

	[Token(Token = "0x6005922")]
	[Address(RVA = "0xEF0E00", Offset = "0xEEFC00", Length = "0xF1")]
	public ScaledCurve(float startPos, float startVal, float endPos, float endVal, bool easeInEaseOut = false)
	{
		curve = null;
	}
}
