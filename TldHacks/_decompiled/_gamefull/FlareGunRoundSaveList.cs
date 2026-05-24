using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200073F")]
public class FlareGunRoundSaveList
{
	[Token(Token = "0x4004CC1")]
	[FieldOffset(Offset = "0x10")]
	public List<FlareGunRoundSaveData> m_SerializedItems;

	[Token(Token = "0x6004196")]
	[Address(RVA = "0xC284F0", Offset = "0xC272F0", Length = "0xAD")]
	public FlareGunRoundSaveList()
	{
	}
}
