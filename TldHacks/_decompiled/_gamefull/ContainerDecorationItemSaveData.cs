using Cpp2ILInjected;
using TLD.Placement;

[Token(Token = "0x200055E")]
public class ContainerDecorationItemSaveData
{
	[Token(Token = "0x4003180")]
	[FieldOffset(Offset = "0x10")]
	public string m_GUID;

	[Token(Token = "0x4003181")]
	[FieldOffset(Offset = "0x18")]
	public PlaceableSaveData m_PlaceableSaveData;

	[Token(Token = "0x6002928")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ContainerDecorationItemSaveData()
	{
	}
}
