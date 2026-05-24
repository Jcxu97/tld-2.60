using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

[Serializable]
[JsonConverter(typeof(AssetReferenceGearItemDataConverter))]
[Token(Token = "0x200141B")]
public class AssetReferenceGearItemData : AssetReferenceT<GearItemData>
{
	[Token(Token = "0x600802E")]
	[Address(RVA = "0x1202C00", Offset = "0x1201A00", Length = "0x49")]
	public AssetReferenceGearItemData(string guid)
		: base((string)null)
	{
	}
}
