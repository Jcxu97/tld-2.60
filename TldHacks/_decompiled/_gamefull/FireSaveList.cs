using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200073C")]
public class FireSaveList
{
	[Token(Token = "0x4004CA2")]
	[FieldOffset(Offset = "0x10")]
	public List<FireSaveData> m_SerializedFires;

	[Token(Token = "0x4004CA3")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_DestroyedFires;

	[Token(Token = "0x600416D")]
	[Address(RVA = "0xC22920", Offset = "0xC21720", Length = "0x159")]
	public FireSaveList()
	{
	}
}
