using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.BigCarry;

[Token(Token = "0x20014D6")]
public class BigCarrySystemSceneSaveData
{
	[Token(Token = "0x400969A")]
	[FieldOffset(Offset = "0x10")]
	public List<BigCarrySystemItemSaveData> m_ActiveBigCarryItems;

	[Token(Token = "0x400969B")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_RemovedBigCarryItems;

	[Token(Token = "0x6008396")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BigCarrySystemSceneSaveData()
	{
	}
}
