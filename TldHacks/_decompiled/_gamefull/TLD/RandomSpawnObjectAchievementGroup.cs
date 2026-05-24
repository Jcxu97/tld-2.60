using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD;

[Serializable]
[Token(Token = "0x200133E")]
public class RandomSpawnObjectAchievementGroup
{
	[Token(Token = "0x4008DF2")]
	[FieldOffset(Offset = "0x10")]
	public int m_RandomSpawnObjectDuplicatesPilgrim;

	[Token(Token = "0x4008DF3")]
	[FieldOffset(Offset = "0x14")]
	public int m_RandomSpawnObjectDuplicatesVoyageur;

	[Token(Token = "0x4008DF4")]
	[FieldOffset(Offset = "0x18")]
	public int m_RandomSpawnObjectDuplicatesStalker;

	[Token(Token = "0x4008DF5")]
	[FieldOffset(Offset = "0x1C")]
	public int m_RandomSpawnObjectDuplicatesInterloper;

	[Token(Token = "0x4008DF6")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_GroupAchievementLocIds;

	[Token(Token = "0x6007B56")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RandomSpawnObjectAchievementGroup()
	{
	}
}
