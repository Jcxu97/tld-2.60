using Cpp2ILInjected;

[Token(Token = "0x200055D")]
public class ContainerItemSaveData
{
	[Token(Token = "0x400317E")]
	[FieldOffset(Offset = "0x10")]
	public string m_PrefabName;

	[Token(Token = "0x400317F")]
	[FieldOffset(Offset = "0x18")]
	public string m_SerializedGear;

	[Token(Token = "0x6002927")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ContainerItemSaveData()
	{
	}
}
