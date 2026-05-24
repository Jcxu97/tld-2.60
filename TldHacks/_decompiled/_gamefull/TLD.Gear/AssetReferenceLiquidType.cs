using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

[Serializable]
[JsonConverter(typeof(AssetReferenceLiquidTypeConverter))]
[Token(Token = "0x200142B")]
public class AssetReferenceLiquidType : AssetReferenceT<LiquidType>
{
	[Token(Token = "0x60080C4")]
	[Address(RVA = "0x120E700", Offset = "0x120D500", Length = "0x49")]
	public AssetReferenceLiquidType(string guid)
		: base((string)null)
	{
	}
}
