using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200070A")]
public class ArrowSaveList
{
	[Token(Token = "0x4004AF7")]
	[FieldOffset(Offset = "0x10")]
	public List<ArrowSaveData> m_SerializedItems;

	[Token(Token = "0x6003DC8")]
	[Address(RVA = "0xBF8FE0", Offset = "0xBF7DE0", Length = "0xAD")]
	public ArrowSaveList()
	{
	}
}
