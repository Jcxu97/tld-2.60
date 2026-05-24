using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

namespace TLD.BigCarry;

[Serializable]
[Token(Token = "0x20014D0")]
public class AssetReferenceBigCarryItem : AssetReferenceWithComponent<BigCarryItem>
{
	[Token(Token = "0x600836C")]
	[Address(RVA = "0x1247EF0", Offset = "0x1246CF0", Length = "0x6A")]
	public AssetReferenceBigCarryItem(string guid)
		: base((string)null)
	{
	}
}
