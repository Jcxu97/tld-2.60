using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

[Token(Token = "0x20014C3")]
public class BaitItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40095ED")]
	[FieldOffset(Offset = "0x20")]
	private float m_MinFishWeightModifier;

	[Token(Token = "0x17000B5E")]
	public float MinFishWeightModifier
	{
		[Token(Token = "0x60082FD")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60082FE")]
	[Address(RVA = "0x1123A10", Offset = "0x1122810", Length = "0x4A")]
	public BaitItem()
	{
	}
}
