using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

[Serializable]
[Token(Token = "0x20002AC")]
public class AssetReferenceDecorationItem : AssetReferenceWithComponent<DecorationItem>
{
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x6BCCA0", Offset = "0x6BBAA0", Length = "0x6A")]
	public AssetReferenceDecorationItem(string guid)
		: base((string)null)
	{
	}
}
