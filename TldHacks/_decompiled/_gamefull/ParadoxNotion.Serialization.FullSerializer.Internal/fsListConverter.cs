using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DAB")]
public class fsListConverter : fsConverter
{
	[Token(Token = "0x6006A7C")]
	[Address(RVA = "0x108A830", Offset = "0x1089630", Length = "0xE3")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A7D")]
	[Address(RVA = "0x108A920", Offset = "0x1089720", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006A7E")]
	[Address(RVA = "0x108A9A0", Offset = "0x10897A0", Length = "0x492")]
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A7F")]
	[Address(RVA = "0x108AE40", Offset = "0x1089C40", Length = "0x3DC")]
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A80")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsListConverter()
	{
	}
}
