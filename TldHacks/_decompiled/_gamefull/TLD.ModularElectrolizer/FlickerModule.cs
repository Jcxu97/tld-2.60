using System;
using Cpp2ILInjected;

namespace TLD.ModularElectrolizer;

[Serializable]
[Token(Token = "0x20013CF")]
public class FlickerModule
{
	[Token(Token = "0x4009137")]
	[FieldOffset(Offset = "0x10")]
	public FlickerValueGenerator m_ValueGenerator;

	[Token(Token = "0x4009138")]
	[FieldOffset(Offset = "0x18")]
	public FlickerAmplitudeParameters m_AmplitudeModifier;

	[Token(Token = "0x4009139")]
	[FieldOffset(Offset = "0x20")]
	public FlickerTemporalParameters m_TemporalModifier;

	[Token(Token = "0x6007E91")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FlickerModule()
	{
	}
}
