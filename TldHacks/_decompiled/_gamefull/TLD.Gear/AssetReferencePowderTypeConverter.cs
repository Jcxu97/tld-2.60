using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace TLD.Gear;

[Token(Token = "0x2001431")]
public class AssetReferencePowderTypeConverter : JsonConverter<AssetReferencePowderType>
{
	[Token(Token = "0x60080D4")]
	[Address(RVA = "0x120EFC0", Offset = "0x120DDC0", Length = "0xCF")]
	public override AssetReferencePowderType ReadJson(JsonReader reader, Type objectType, AssetReferencePowderType existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x60080D5")]
	[Address(RVA = "0x11B3000", Offset = "0x11B1E00", Length = "0x4A")]
	public override void WriteJson(JsonWriter writer, AssetReferencePowderType value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x60080D6")]
	[Address(RVA = "0x120F090", Offset = "0x120DE90", Length = "0x2A")]
	public AssetReferencePowderTypeConverter()
	{
	}
}
