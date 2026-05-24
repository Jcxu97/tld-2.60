using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200071E")]
public class ContainerSaveList
{
	[Token(Token = "0x4004B83")]
	[FieldOffset(Offset = "0x10")]
	public List<ContainerSaveData> m_SerializedContainers;

	[Token(Token = "0x60040A2")]
	[Address(RVA = "0xC0A730", Offset = "0xC09530", Length = "0xAD")]
	public ContainerSaveList()
	{
	}
}
