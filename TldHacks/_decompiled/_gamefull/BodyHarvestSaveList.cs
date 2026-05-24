using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000716")]
public class BodyHarvestSaveList
{
	[Token(Token = "0x4004B6D")]
	[FieldOffset(Offset = "0x10")]
	public List<BodyHarvestSaveData> m_SerializedBodyHarvests;

	[Token(Token = "0x6003E42")]
	[Address(RVA = "0xC07650", Offset = "0xC06450", Length = "0xAD")]
	public BodyHarvestSaveList()
	{
	}
}
