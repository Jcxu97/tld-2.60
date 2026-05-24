using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200073D")]
public class ChimneySaveList
{
	[Token(Token = "0x4004CA4")]
	[FieldOffset(Offset = "0x10")]
	public List<LinkedChimneySaveData> m_SerializedChimneyData;

	[Token(Token = "0x4004CA5")]
	[FieldOffset(Offset = "0x18")]
	public string m_SceneName;

	[Token(Token = "0x600416E")]
	[Address(RVA = "0xC22A80", Offset = "0xC21880", Length = "0xAD")]
	public ChimneySaveList()
	{
	}
}
