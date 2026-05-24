using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200017E")]
public class PackManagerDataProxyList
{
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x10")]
	public List<PackManagerDataProxy> m_SerializedDataProxyList;

	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_RemoveOnLoadGuids;

	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x20")]
	public float m_SerializedTime;

	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x24")]
	public bool m_PlayerInPackCombatTrigger;

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x5F1A40", Offset = "0x5F0840", Length = "0x159")]
	public PackManagerDataProxyList()
	{
	}
}
