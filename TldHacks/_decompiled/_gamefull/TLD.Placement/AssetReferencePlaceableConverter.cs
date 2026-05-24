using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Placement;

[Token(Token = "0x2001373")]
public class AssetReferencePlaceableConverter : JsonConverter<AssetReferencePlaceable>
{
	[Token(Token = "0x6007C4C")]
	[Address(RVA = "0x11B2F00", Offset = "0x11B1D00", Length = "0xF0")]
	public override AssetReferencePlaceable ReadJson(JsonReader reader, Type objectType, AssetReferencePlaceable existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x6007C4D")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferencePlaceable value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x6007C4E")]
	[Address(RVA = "0x11B3050", Offset = "0x11B1E50", Length = "0x2A")]
	public AssetReferencePlaceableConverter()
	{
	}
}
