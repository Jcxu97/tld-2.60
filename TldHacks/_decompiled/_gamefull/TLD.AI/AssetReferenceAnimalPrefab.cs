using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

namespace TLD.AI;

[Serializable]
[Token(Token = "0x2001507")]
public class AssetReferenceAnimalPrefab : AssetReferenceWithComponent<BaseAi>
{
	[Token(Token = "0x6008500")]
	[Address(RVA = "0x126EC30", Offset = "0x126DA30", Length = "0x6A")]
	public AssetReferenceAnimalPrefab(string guid)
		: base((string)null)
	{
	}
}
