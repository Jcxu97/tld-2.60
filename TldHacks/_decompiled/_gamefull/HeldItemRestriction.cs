using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Held Item Restriction")]
[Token(Token = "0x2000427")]
public class HeldItemRestriction : ScriptableObject
{
	[Token(Token = "0x4002579")]
	[FieldOffset(Offset = "0x18")]
	public HeldItemRestrictionType m_Type;

	[Token(Token = "0x400257A")]
	[FieldOffset(Offset = "0x20")]
	public List<GearItem> m_List;

	[Token(Token = "0x6001F51")]
	[Address(RVA = "0x7D9950", Offset = "0x7D8750", Length = "0x272")]
	public bool IsRestricted(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6001F52")]
	[Address(RVA = "0x7D9BD0", Offset = "0x7D89D0", Length = "0xB6")]
	public HeldItemRestriction()
	{
	}
}
