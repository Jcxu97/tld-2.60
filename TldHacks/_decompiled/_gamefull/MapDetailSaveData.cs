using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000784")]
public class MapDetailSaveData
{
	[Token(Token = "0x400508B")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, bool> m_MapDetailUnlockedStates;

	[Token(Token = "0x400508C")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<string, MapDetailStateData> m_NewMapDetailStates;

	[Token(Token = "0x6004678")]
	[Address(RVA = "0xCA7070", Offset = "0xCA5E70", Length = "0x1C9")]
	public MapDetailSaveData()
	{
	}
}
