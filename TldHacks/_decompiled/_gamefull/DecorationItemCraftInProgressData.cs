using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20002AA")]
public struct DecorationItemCraftInProgressData
{
	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0x0")]
	public string m_ItemId;

	[Token(Token = "0x40017C2")]
	[FieldOffset(Offset = "0x8")]
	public string m_CraftInProgressSerialized;
}
