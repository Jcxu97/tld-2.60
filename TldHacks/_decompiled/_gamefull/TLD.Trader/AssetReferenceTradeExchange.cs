using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace TLD.Trader;

[Serializable]
[JsonConverter(typeof(AssetReferenceTradeExchangeConverter))]
[Token(Token = "0x20013AF")]
public class AssetReferenceTradeExchange : AssetReferenceT<TradeExchange>
{
	[Token(Token = "0x6007DC0")]
	[Address(RVA = "0x11CEDA0", Offset = "0x11CDBA0", Length = "0x49")]
	public AssetReferenceTradeExchange(string guid)
		: base((string)null)
	{
	}
}
