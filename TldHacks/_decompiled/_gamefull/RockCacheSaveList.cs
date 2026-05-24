using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007CC")]
public class RockCacheSaveList
{
	[Token(Token = "0x40053BF")]
	[FieldOffset(Offset = "0x10")]
	public List<RockCacheSaveData> m_SerializedRockCacheList;

	[Token(Token = "0x60049AC")]
	[Address(RVA = "0xD231B0", Offset = "0xD21FB0", Length = "0xAD")]
	public RockCacheSaveList()
	{
	}
}
