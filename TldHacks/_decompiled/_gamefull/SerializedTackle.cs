using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200058C")]
public class SerializedTackle
{
	[Token(Token = "0x400330E")]
	[FieldOffset(Offset = "0x10")]
	public AssetReference m_AssetReference;

	[Token(Token = "0x400330F")]
	[FieldOffset(Offset = "0x18")]
	public GearItemSaveDataProxy m_GearItemData;

	[Token(Token = "0x6002AB0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializedTackle()
	{
	}
}
