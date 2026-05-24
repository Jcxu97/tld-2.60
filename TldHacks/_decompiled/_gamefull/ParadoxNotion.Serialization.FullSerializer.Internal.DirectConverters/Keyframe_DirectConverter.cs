using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB7")]
public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
{
	[Token(Token = "0x6006ABF")]
	[Address(RVA = "0x1092F40", Offset = "0x1091D40", Length = "0x3B1")]
	protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AC0")]
	[Address(RVA = "0x1093300", Offset = "0x1092100", Length = "0x451")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AC1")]
	[Address(RVA = "0x1093760", Offset = "0x1092560", Length = "0x5A")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006AC2")]
	[Address(RVA = "0x10937C0", Offset = "0x10925C0", Length = "0x2A")]
	public Keyframe_DirectConverter()
	{
	}
}
