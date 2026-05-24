using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000336")]
public class FeatEnabledTrackerSaveData
{
	[Token(Token = "0x4001CE6")]
	[FieldOffset(Offset = "0x10")]
	public List<FeatType> m_FeatsEnabledThisSandbox;

	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x74F470", Offset = "0x74E270", Length = "0xAD")]
	public FeatEnabledTrackerSaveData()
	{
	}
}
