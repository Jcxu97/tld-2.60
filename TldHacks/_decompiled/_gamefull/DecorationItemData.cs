using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20002AB")]
public class DecorationItemData
{
	[Token(Token = "0x40017C3")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<DecorationItemParentData> m_ParentData;

	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<string> m_CraftedItemPlacementPendingData;

	[Token(Token = "0x6001699")]
	[Address(RVA = "0x6BCB40", Offset = "0x6BB940", Length = "0x159")]
	public DecorationItemData()
	{
	}
}
