using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000713")]
public class BaseAiSaveList
{
	[Token(Token = "0x4004B4E")]
	[FieldOffset(Offset = "0x10")]
	public List<BaseAiData> m_SerializedBaseAI;

	[Token(Token = "0x6003E1A")]
	[Address(RVA = "0xC014D0", Offset = "0xC002D0", Length = "0xAD")]
	public BaseAiSaveList()
	{
	}
}
