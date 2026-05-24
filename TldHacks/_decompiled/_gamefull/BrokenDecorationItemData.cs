using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000555")]
public struct BrokenDecorationItemData
{
	[Token(Token = "0x400314C")]
	[FieldOffset(Offset = "0x0")]
	public BrokenDecorationState m_State;

	[Token(Token = "0x400314D")]
	[FieldOffset(Offset = "0x8")]
	public string m_ItemId;
}
