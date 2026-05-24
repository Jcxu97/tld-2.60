using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Gear;

[Token(Token = "0x200142C")]
public class AssetReferenceLiquidTypeConverter : JsonConverter<AssetReferenceLiquidType>
{
	[Token(Token = "0x60080C5")]
	[Address(RVA = "0x120E750", Offset = "0x120D550", Length = "0xCF")]
	public override AssetReferenceLiquidType ReadJson(JsonReader reader, Type objectType, AssetReferenceLiquidType existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x60080C6")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferenceLiquidType value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x60080C7")]
	[Address(RVA = "0x120E820", Offset = "0x120D620", Length = "0x2A")]
	public AssetReferenceLiquidTypeConverter()
	{
	}
}
