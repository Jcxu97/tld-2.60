using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200055A")]
public class CampfireSaveDataProxy
{
	[Token(Token = "0x4003163")]
	[FieldOffset(Offset = "0x10")]
	public CampfireState m_State;

	[Token(Token = "0x4003164")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<string, string> m_RockGuids;

	[Token(Token = "0x6002911")]
	[Address(RVA = "0x8DB890", Offset = "0x8DA690", Length = "0xAD")]
	public CampfireSaveDataProxy()
	{
	}
}
