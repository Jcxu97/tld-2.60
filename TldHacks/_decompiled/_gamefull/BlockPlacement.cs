using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000548")]
public class BlockPlacement : MonoBehaviour
{
	[Token(Token = "0x40030B0")]
	[FieldOffset(Offset = "0x20")]
	public bool m_BlockBedrollPlacement;

	[Token(Token = "0x40030B1")]
	[FieldOffset(Offset = "0x21")]
	public bool m_BlockCampfirePlacement;

	[Token(Token = "0x40030B2")]
	[FieldOffset(Offset = "0x22")]
	public bool m_BlockBodyPlacement;

	[Token(Token = "0x40030B3")]
	[FieldOffset(Offset = "0x23")]
	public bool m_BlockSnowShelterPlacement;

	[Token(Token = "0x40030B4")]
	[FieldOffset(Offset = "0x24")]
	public bool m_BlockGearItemPlacement;

	[Token(Token = "0x40030B5")]
	[FieldOffset(Offset = "0x25")]
	public bool m_BlockDecorationItemPlacement;

	[Token(Token = "0x6002877")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BlockPlacement()
	{
	}
}
