using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000952")]
public class SnowfallManagerSaveDataProxy
{
	[Token(Token = "0x4006090")]
	[FieldOffset(Offset = "0x10")]
	public List<string> m_SceneNames;

	[Token(Token = "0x4006091")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_Records;

	[Token(Token = "0x6005463")]
	[Address(RVA = "0xE7E680", Offset = "0xE7D480", Length = "0x139")]
	public SnowfallManagerSaveDataProxy()
	{
	}
}
