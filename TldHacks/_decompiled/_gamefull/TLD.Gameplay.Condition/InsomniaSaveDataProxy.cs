using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Gameplay.Condition;

[Token(Token = "0x20014CC")]
public class InsomniaSaveDataProxy
{
	[Token(Token = "0x4009658")]
	[FieldOffset(Offset = "0x10")]
	public List<InsomniaParamsSaveDataProxy> m_ListOfParamData;

	[Token(Token = "0x4009659")]
	[FieldOffset(Offset = "0x18")]
	public float m_ResistInsomniaBuffHoursRemaining;

	[Token(Token = "0x400965A")]
	[FieldOffset(Offset = "0x1C")]
	public float m_ResistInsomniaBuffMultiplier;

	[Token(Token = "0x6008327")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InsomniaSaveDataProxy()
	{
	}
}
