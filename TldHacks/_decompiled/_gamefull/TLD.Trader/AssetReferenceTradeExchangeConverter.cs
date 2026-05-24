using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Trader;

[Token(Token = "0x20013B0")]
public class AssetReferenceTradeExchangeConverter : JsonConverter<AssetReferenceTradeExchange>
{
	[Token(Token = "0x6007DC1")]
	[Address(RVA = "0x11CEDF0", Offset = "0x11CDBF0", Length = "0xCF")]
	public override AssetReferenceTradeExchange ReadJson(JsonReader reader, Type objectType, AssetReferenceTradeExchange existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x6007DC2")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferenceTradeExchange value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x6007DC3")]
	[Address(RVA = "0x11CEEC0", Offset = "0x11CDCC0", Length = "0x2A")]
	public AssetReferenceTradeExchangeConverter()
	{
	}
}
