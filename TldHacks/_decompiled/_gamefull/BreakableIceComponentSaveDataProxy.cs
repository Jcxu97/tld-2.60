using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008D9")]
public class BreakableIceComponentSaveDataProxy
{
	[Token(Token = "0x4005C9A")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4005C9B")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_BrokenIceData;

	[Token(Token = "0x6005154")]
	[Address(RVA = "0xE23070", Offset = "0xE21E70", Length = "0xAD")]
	public BreakableIceComponentSaveDataProxy()
	{
	}
}
