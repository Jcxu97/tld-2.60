using Cpp2ILInjected;

[Token(Token = "0x2000217")]
public class CollectionListItemInfo
{
	[Token(Token = "0x40012D9")]
	[FieldOffset(Offset = "0x10")]
	public string m_NameLocID;

	[Token(Token = "0x40012DA")]
	[FieldOffset(Offset = "0x18")]
	public string m_ListIconName;

	[Token(Token = "0x40012DB")]
	[FieldOffset(Offset = "0x20")]
	public string m_ProgressString;

	[Token(Token = "0x40012DC")]
	[FieldOffset(Offset = "0x28")]
	public string m_DescLocID;

	[Token(Token = "0x40012DD")]
	[FieldOffset(Offset = "0x30")]
	public string m_BigIconName;

	[Token(Token = "0x40012DE")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Log.WhatIKnowType m_SubScreenToOpen;

	[Token(Token = "0x40012DF")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Log.CollectionsType m_CollectionType;

	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CollectionListItemInfo()
	{
	}
}
