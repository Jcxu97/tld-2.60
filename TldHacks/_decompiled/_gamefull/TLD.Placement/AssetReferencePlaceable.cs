using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using TLD.AddressableAssets;

namespace TLD.Placement;

[Serializable]
[JsonConverter(typeof(AssetReferencePlaceableConverter))]
[Token(Token = "0x2001372")]
public class AssetReferencePlaceable : AssetReferenceWithComponent<Placeable>
{
	[Token(Token = "0x6007C4B")]
	[Address(RVA = "0x11B2E90", Offset = "0x11B1C90", Length = "0x6A")]
	public AssetReferencePlaceable(string guid)
		: base((string)null)
	{
	}
}
