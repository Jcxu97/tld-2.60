using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000726")]
public class DecalProjectorSaveList
{
	[Token(Token = "0x4004BCC")]
	[FieldOffset(Offset = "0x10")]
	public List<DecalProjectorSaveData> m_SerializedDecalProjectors;

	[Token(Token = "0x60040B5")]
	[Address(RVA = "0xC0C330", Offset = "0xC0B130", Length = "0xAD")]
	public DecalProjectorSaveList()
	{
	}
}
