using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x200146E")]
public class AssetReferenceCustomSpawnedItem : AssetReferenceWithComponent<CustomSpawnedItem>
{
	[Token(Token = "0x600820C")]
	[Address(RVA = "0x122B560", Offset = "0x122A360", Length = "0x6A")]
	public AssetReferenceCustomSpawnedItem(string guid)
		: base((string)null)
	{
	}
}
