using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000556")]
public class BrokenDecorationSaveData
{
	[Token(Token = "0x400314E")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<BrokenDecorationItemData> m_DataList;

	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x8DA010", Offset = "0x8D8E10", Length = "0xAD")]
	public BrokenDecorationSaveData()
	{
	}
}
