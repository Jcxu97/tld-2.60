using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Player;

[Token(Token = "0x200144B")]
public class NutritionSaveDataGlobal
{
	[Token(Token = "0x40093A4")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<string> m_NutrientNames;

	[Token(Token = "0x40093A5")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<float> m_Amounts;

	[Token(Token = "0x40093A6")]
	[FieldOffset(Offset = "0x20")]
	public readonly List<int> m_LossPerDay;

	[Token(Token = "0x6008144")]
	[Address(RVA = "0x1219EC0", Offset = "0x1218CC0", Length = "0x1E9")]
	public NutritionSaveDataGlobal()
	{
	}
}
