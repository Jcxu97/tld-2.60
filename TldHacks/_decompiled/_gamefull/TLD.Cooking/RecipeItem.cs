using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Cooking;

[Token(Token = "0x20013F7")]
public class RecipeItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009203")]
	[FieldOffset(Offset = "0x20")]
	private List<RecipeData> m_Recipes;

	[SerializeField]
	[Token(Token = "0x4009204")]
	[FieldOffset(Offset = "0x28")]
	private LocalizedString m_HudMessageOnPickup;

	[Token(Token = "0x6007F4F")]
	[Address(RVA = "0x11F1F20", Offset = "0x11F0D20", Length = "0x22E")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6007F50")]
	[Address(RVA = "0x11F2150", Offset = "0x11F0F50", Length = "0x74")]
	private void MaybeShowHudMessage()
	{
	}

	[Token(Token = "0x6007F51")]
	[Address(RVA = "0x11F21D0", Offset = "0x11F0FD0", Length = "0x205")]
	public bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6007F52")]
	[Address(RVA = "0x11F23E0", Offset = "0x11F11E0", Length = "0xE3")]
	public RecipeItem()
	{
	}
}
