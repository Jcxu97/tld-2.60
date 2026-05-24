using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

[Serializable]
[Token(Token = "0x200049F")]
public class AssetReferenceGearItem : AssetReferenceWithComponent<GearItem>
{
	[Token(Token = "0x600234A")]
	[Address(RVA = "0x852D60", Offset = "0x851B60", Length = "0x6A")]
	public AssetReferenceGearItem(string guid)
		: base((string)null)
	{
	}
}
