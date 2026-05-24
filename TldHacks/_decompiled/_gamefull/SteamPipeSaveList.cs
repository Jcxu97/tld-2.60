using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007EB")]
public class SteamPipeSaveList
{
	[Token(Token = "0x400549C")]
	[FieldOffset(Offset = "0x10")]
	public List<SteamPipeSaveData> m_SerializedSteamPipes;

	[Token(Token = "0x6004A9F")]
	[Address(RVA = "0xD3F7E0", Offset = "0xD3E5E0", Length = "0xAD")]
	public SteamPipeSaveList()
	{
	}
}
