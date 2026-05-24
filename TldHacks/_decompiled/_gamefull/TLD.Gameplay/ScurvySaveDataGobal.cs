using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x200149A")]
public class ScurvySaveDataGobal
{
	[Token(Token = "0x4009557")]
	[FieldOffset(Offset = "0x10")]
	public ScurvyState m_ScurvyState;

	[Token(Token = "0x4009558")]
	[FieldOffset(Offset = "0x14")]
	public bool m_Enabled;

	[Token(Token = "0x4009559")]
	[FieldOffset(Offset = "0x15")]
	public bool m_Repaired;

	[Token(Token = "0x60082BB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ScurvySaveDataGobal()
	{
	}
}
