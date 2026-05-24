using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Trader;

[Token(Token = "0x20013AC")]
public class AssetReferenceExchangeItemCategoryConverter : JsonConverter<AssetReferenceExchangeItemCategory>
{
	[Token(Token = "0x6007DB9")]
	[Address(RVA = "0x11CE570", Offset = "0x11CD370", Length = "0xCF")]
	public override AssetReferenceExchangeItemCategory ReadJson(JsonReader reader, Type objectType, AssetReferenceExchangeItemCategory existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x6007DBA")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferenceExchangeItemCategory value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x6007DBB")]
	[Address(RVA = "0x11CE640", Offset = "0x11CD440", Length = "0x2A")]
	public AssetReferenceExchangeItemCategoryConverter()
	{
	}
}
