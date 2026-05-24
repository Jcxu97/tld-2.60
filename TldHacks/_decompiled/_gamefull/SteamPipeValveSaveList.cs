using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007EE")]
public class SteamPipeValveSaveList
{
	[Token(Token = "0x40054A0")]
	[FieldOffset(Offset = "0x10")]
	public List<SteamPipeSaveData> m_SerializedSteamPipeValves;

	[Token(Token = "0x40054A1")]
	[FieldOffset(Offset = "0x18")]
	public List<SteamPipeSaveData> m_SerializedSteamPipeValveSockets;

	[Token(Token = "0x6004AA8")]
	[Address(RVA = "0xD404E0", Offset = "0xD3F2E0", Length = "0x139")]
	public SteamPipeValveSaveList()
	{
	}
}
