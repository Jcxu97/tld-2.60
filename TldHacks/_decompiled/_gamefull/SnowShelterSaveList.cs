using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007DE")]
public class SnowShelterSaveList
{
	[Token(Token = "0x4005452")]
	[FieldOffset(Offset = "0x10")]
	public List<SnowShelterSaveData> m_SerializedSnowShelters;

	[Token(Token = "0x6004A39")]
	[Address(RVA = "0xD32400", Offset = "0xD31200", Length = "0xAD")]
	public SnowShelterSaveList()
	{
	}
}
