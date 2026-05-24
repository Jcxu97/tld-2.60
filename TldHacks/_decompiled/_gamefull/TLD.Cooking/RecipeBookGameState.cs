using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Cooking;

[Token(Token = "0x20013F3")]
public class RecipeBookGameState
{
	[Token(Token = "0x40091EF")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<string> m_UnlockedRecipes;

	[Token(Token = "0x40091F0")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<string> m_CookedRecipes;

	[Token(Token = "0x6007F2B")]
	[Address(RVA = "0x11EFE00", Offset = "0x11EEC00", Length = "0x139")]
	public RecipeBookGameState()
	{
	}
}
