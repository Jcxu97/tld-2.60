using System;
using Cpp2ILInjected;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace TLD.Trader;

[Serializable]
[JsonConverter(typeof(AssetReferenceTraderConversationConverter))]
[Token(Token = "0x20013B4")]
public class AssetReferenceTraderConversation : AssetReferenceT<TraderConversation>
{
	[Token(Token = "0x6007DE2")]
	[Address(RVA = "0x11D1540", Offset = "0x11D0340", Length = "0x49")]
	public AssetReferenceTraderConversation(string guid)
		: base((string)null)
	{
	}
}
