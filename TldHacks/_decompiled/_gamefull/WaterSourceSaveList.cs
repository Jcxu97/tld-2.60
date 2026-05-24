using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007F5")]
public class WaterSourceSaveList
{
	[Token(Token = "0x40054C1")]
	[FieldOffset(Offset = "0x10")]
	public List<WaterSourceSaveData> m_SerializedWaterSources;

	[Token(Token = "0x6004AE3")]
	[Address(RVA = "0xD47230", Offset = "0xD46030", Length = "0xAD")]
	public WaterSourceSaveList()
	{
	}
}
