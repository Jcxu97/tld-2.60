using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20001D0")]
public class BearHuntReduxSaveData
{
	[Token(Token = "0x4000FB3")]
	[FieldOffset(Offset = "0x10")]
	public bool m_DeprecatedActive;

	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x11")]
	public bool m_Completed;

	[Token(Token = "0x4000FB5")]
	[FieldOffset(Offset = "0x14")]
	public int m_DeprecatedTreeEncounterWonCount;

	[Token(Token = "0x4000FB6")]
	[FieldOffset(Offset = "0x18")]
	public List<BearEncounterInfo> m_BearEncounterInfoList;

	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x20")]
	public bool m_PlayerDiesAfterSpearMiss;

	[Token(Token = "0x6001083")]
	[Address(RVA = "0x6289D0", Offset = "0x6277D0", Length = "0xAD")]
	public BearHuntReduxSaveData()
	{
	}
}
