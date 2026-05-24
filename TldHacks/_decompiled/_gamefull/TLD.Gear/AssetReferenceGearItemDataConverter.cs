using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Gear;

[Token(Token = "0x200141C")]
public class AssetReferenceGearItemDataConverter : JsonConverter<AssetReferenceGearItemData>
{
	[Token(Token = "0x600802F")]
	[Address(RVA = "0x1202C50", Offset = "0x1201A50", Length = "0xCF")]
	public override AssetReferenceGearItemData ReadJson(JsonReader reader, Type objectType, AssetReferenceGearItemData existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x6008030")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferenceGearItemData value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x6008031")]
	[Address(RVA = "0x1202D20", Offset = "0x1201B20", Length = "0x2A")]
	public AssetReferenceGearItemDataConverter()
	{
	}
}
