using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x2001494")]
public static class RandomTableDataManager
{
	[Token(Token = "0x4009543")]
	private static readonly List<RandomTableData> m_InitializedData;

	[Token(Token = "0x60082A7")]
	[Address(RVA = "0x123BA40", Offset = "0x123A840", Length = "0x93")]
	public static void ResetLootTables()
	{
	}

	[Token(Token = "0x60082A8")]
	[Address(RVA = "0x123BAE0", Offset = "0x123A8E0", Length = "0x155")]
	public static bool DoesTableNeedInitialization(RandomTableData data)
	{
		return false;
	}

	[Token(Token = "0x60082A9")]
	[Address(RVA = "0x123BC40", Offset = "0x123AA40", Length = "0x82")]
	public static void SetTableDirty(RandomTableData data)
	{
	}
}
