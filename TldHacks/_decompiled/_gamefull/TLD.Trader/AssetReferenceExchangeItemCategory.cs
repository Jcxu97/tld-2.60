using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace TLD.Trader;

[Serializable]
[JsonConverter(typeof(AssetReferenceExchangeItemCategoryConverter))]
[Token(Token = "0x20013AB")]
public class AssetReferenceExchangeItemCategory : AssetReferenceT<ExchangeItemCategory>
{
	[Token(Token = "0x6007DB8")]
	[Address(RVA = "0x11CE520", Offset = "0x11CD320", Length = "0x49")]
	public AssetReferenceExchangeItemCategory(string guid)
		: base((string)null)
	{
	}
}
