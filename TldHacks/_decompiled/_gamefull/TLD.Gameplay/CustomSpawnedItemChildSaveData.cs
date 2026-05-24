using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x200146B")]
public class CustomSpawnedItemChildSaveData
{
	[Token(Token = "0x400944E")]
	[FieldOffset(Offset = "0x10")]
	public string m_LocalGuid;

	[Token(Token = "0x400944F")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x4009450")]
	[FieldOffset(Offset = "0x20")]
	public bool m_Destroyed;

	[Token(Token = "0x60081F6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CustomSpawnedItemChildSaveData()
	{
	}
}
