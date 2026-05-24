using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007CF")]
public class RockCacheInfoSaveList
{
	[Token(Token = "0x40053C7")]
	[FieldOffset(Offset = "0x10")]
	public List<RockCacheInfo> m_SerializedRockCacheInfoList;

	[Token(Token = "0x40053C8")]
	[FieldOffset(Offset = "0x18")]
	public List<RockCacheDestroyedInfo> m_SerializedDestroyedRockCacheInScene;

	[Token(Token = "0x40053C9")]
	[FieldOffset(Offset = "0x20")]
	public int m_RockCacheIndex;

	[Token(Token = "0x60049AF")]
	[Address(RVA = "0xD23260", Offset = "0xD22060", Length = "0x159")]
	public RockCacheInfoSaveList()
	{
	}
}
