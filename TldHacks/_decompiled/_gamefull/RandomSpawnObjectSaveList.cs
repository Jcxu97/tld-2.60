using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007C4")]
public class RandomSpawnObjectSaveList
{
	[Token(Token = "0x40053A3")]
	[FieldOffset(Offset = "0x10")]
	public List<RandomSpawnObjectSaveData> m_SaveDataList;

	[Token(Token = "0x6004977")]
	[Address(RVA = "0xD1EA80", Offset = "0xD1D880", Length = "0xAD")]
	public RandomSpawnObjectSaveList()
	{
	}
}
