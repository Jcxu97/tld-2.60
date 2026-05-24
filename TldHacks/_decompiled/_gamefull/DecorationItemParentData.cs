using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20002A9")]
public struct DecorationItemParentData
{
	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x0")]
	public string m_ItemId;

	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0x8")]
	public string m_ParentId;
}
