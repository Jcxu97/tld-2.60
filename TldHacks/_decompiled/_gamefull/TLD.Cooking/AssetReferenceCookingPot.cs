using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

namespace TLD.Cooking;

[Serializable]
[Token(Token = "0x20013EF")]
public class AssetReferenceCookingPot : AssetReferenceWithComponent<CookingPotItem>
{
	[Token(Token = "0x6007F15")]
	[Address(RVA = "0x11EDBE0", Offset = "0x11EC9E0", Length = "0x6A")]
	public AssetReferenceCookingPot(string guid)
		: base((string)null)
	{
	}
}
