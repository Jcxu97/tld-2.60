using System;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001462")]
public struct BunkerLocationSaveData
{
	[Token(Token = "0x40093EE")]
	[FieldOffset(Offset = "0x0")]
	public string m_BunkerId;

	[Token(Token = "0x40093EF")]
	[FieldOffset(Offset = "0x8")]
	public string m_InteriorId;
}
