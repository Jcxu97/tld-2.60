using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004D7")]
public class SplitItem : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4002C48")]
	[FieldOffset(Offset = "0x20")]
	public GearItem[] m_SplitGear;

	[HideInInspector]
	[Token(Token = "0x4002C49")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_SplitGearUnits;

	[Token(Token = "0x60024DD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SplitItem()
	{
	}
}
