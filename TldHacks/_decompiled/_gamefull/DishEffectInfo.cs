using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000231")]
public class DishEffectInfo : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x20")]
	private DishEffectInfoUI m_DishEffectInfoUI;

	[SerializeField]
	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x28")]
	private List<DishEffectInfoIcon> m_DishEffectIcons;

	[SerializeField]
	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x30")]
	private UIGrid m_DishEffectGrid;

	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0x38")]
	private List<IFoodEffect> m_FoodEffectCache;

	[Token(Token = "0x6001379")]
	[Address(RVA = "0x66AC00", Offset = "0x669A00", Length = "0x6C1")]
	public bool ShowDishBenefits(GameObject dish)
	{
		return false;
	}

	[Token(Token = "0x600137A")]
	[Address(RVA = "0x66B2D0", Offset = "0x66A0D0", Length = "0xE3")]
	public DishEffectInfo()
	{
	}
}
