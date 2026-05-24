using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000751")]
public class GearSaveList
{
	[Token(Token = "0x4004E33")]
	[FieldOffset(Offset = "0x10")]
	public List<GearSaveData> m_SerializedItems;

	[Token(Token = "0x4004E34")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_SpawnedGearInOldSavesGUIDs;

	[Token(Token = "0x600434F")]
	[Address(RVA = "0xC53C60", Offset = "0xC52A60", Length = "0x159")]
	public GearSaveList()
	{
	}
}
