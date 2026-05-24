using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

[Serializable]
[JsonConverter(typeof(AssetReferencePowderTypeConverter))]
[Token(Token = "0x2001430")]
public class AssetReferencePowderType : AssetReferenceT<PowderType>
{
	[Token(Token = "0x60080D3")]
	[Address(RVA = "0x120EF70", Offset = "0x120DD70", Length = "0x49")]
	public AssetReferencePowderType(string guid)
		: base((string)null)
	{
	}
}
