using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD;

[Serializable]
[Token(Token = "0x2001340")]
public class CartographyAchievementRegion
{
	[Token(Token = "0x4008DFC")]
	[FieldOffset(Offset = "0x10")]
	public string m_RegionName;

	[Token(Token = "0x4008DFD")]
	[FieldOffset(Offset = "0x18")]
	public int m_RandomSpawnObjectDuplicatesPilgrim;

	[Token(Token = "0x4008DFE")]
	[FieldOffset(Offset = "0x1C")]
	public int m_RandomSpawnObjectDuplicatesVoyageur;

	[Token(Token = "0x4008DFF")]
	[FieldOffset(Offset = "0x20")]
	public int m_RandomSpawnObjectDuplicatesStalker;

	[Token(Token = "0x4008E00")]
	[FieldOffset(Offset = "0x24")]
	public int m_RandomSpawnObjectDuplicatesInterloper;

	[Token(Token = "0x4008E01")]
	[FieldOffset(Offset = "0x28")]
	public List<CartographyAchievement> m_TopLevelIcons;

	[Token(Token = "0x4008E02")]
	[FieldOffset(Offset = "0x30")]
	public List<CartographyAchievement> m_LocationTriggers;

	[Token(Token = "0x4008E03")]
	[FieldOffset(Offset = "0x38")]
	public List<RandomSpawnObjectAchievementGroup> m_RandomSpawnObjectAchievementGroups;

	[Token(Token = "0x6007B58")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CartographyAchievementRegion()
	{
	}
}
