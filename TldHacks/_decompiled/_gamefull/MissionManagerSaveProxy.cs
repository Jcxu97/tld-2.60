using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000820")]
public class MissionManagerSaveProxy
{
	[Token(Token = "0x400558C")]
	[FieldOffset(Offset = "0x10")]
	public string m_SerializedMainBlackboard;

	[Token(Token = "0x400558D")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_SerializedChildGraphs;

	[Token(Token = "0x6004B8A")]
	[Address(RVA = "0xD56C10", Offset = "0xD55A10", Length = "0xAD")]
	public MissionManagerSaveProxy()
	{
	}
}
