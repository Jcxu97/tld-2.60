using System;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[Serializable]
[Token(Token = "0x2001357")]
public class AssetReferenceRegionSpecification : AssetReferenceT<RegionSpecification>
{
	[Token(Token = "0x6007B96")]
	[Address(RVA = "0x11A7C90", Offset = "0x11A6A90", Length = "0x49")]
	public AssetReferenceRegionSpecification(string guid)
		: base((string)null)
	{
	}
}
