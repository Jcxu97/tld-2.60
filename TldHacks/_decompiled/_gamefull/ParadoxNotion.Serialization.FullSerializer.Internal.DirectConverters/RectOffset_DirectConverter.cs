using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB9")]
public class RectOffset_DirectConverter : fsDirectConverter<RectOffset>
{
	[Token(Token = "0x6006AC7")]
	[Address(RVA = "0x1093B20", Offset = "0x1092920", Length = "0x459")]
	protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AC8")]
	[Address(RVA = "0x1093F80", Offset = "0x1092D80", Length = "0x68D")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AC9")]
	[Address(RVA = "0x1094610", Offset = "0x1093410", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006ACA")]
	[Address(RVA = "0x1094690", Offset = "0x1093490", Length = "0x2A")]
	public RectOffset_DirectConverter()
	{
	}
}
