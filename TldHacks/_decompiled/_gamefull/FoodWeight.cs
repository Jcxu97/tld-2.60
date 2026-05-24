using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x2000493")]
public class FoodWeight : MonoBehaviour
{
	[Token(Token = "0x40029D5")]
	[FieldOffset(Offset = "0x20")]
	public ItemWeight m_MinWeight;

	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0x28")]
	public ItemWeight m_MaxWeight;

	[Token(Token = "0x40029D7")]
	[FieldOffset(Offset = "0x30")]
	public float m_CaloriesPerKG;

	[Token(Token = "0x600228A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FoodWeight()
	{
	}
}
