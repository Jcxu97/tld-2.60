using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB3")]
public class Bounds_DirectConverter : fsDirectConverter<Bounds>
{
	[Token(Token = "0x6006AAF")]
	[Address(RVA = "0x108E9C0", Offset = "0x108D7C0", Length = "0x245")]
	protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AB0")]
	[Address(RVA = "0x108EC10", Offset = "0x108DA10", Length = "0x2A9")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AB1")]
	[Address(RVA = "0x108EEC0", Offset = "0x108DCC0", Length = "0x56")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006AB2")]
	[Address(RVA = "0x108EF20", Offset = "0x108DD20", Length = "0x2A")]
	public Bounds_DirectConverter()
	{
	}
}
