using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Trader;

[Token(Token = "0x20013B5")]
public class AssetReferenceTraderConversationConverter : JsonConverter<AssetReferenceTraderConversation>
{
	[Token(Token = "0x6007DE3")]
	[Address(RVA = "0x11D1590", Offset = "0x11D0390", Length = "0xCF")]
	public override AssetReferenceTraderConversation ReadJson(JsonReader reader, Type objectType, AssetReferenceTraderConversation existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x6007DE4")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferenceTraderConversation value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x6007DE5")]
	[Address(RVA = "0x11D1660", Offset = "0x11D0460", Length = "0x2A")]
	public AssetReferenceTraderConversationConverter()
	{
	}
}
