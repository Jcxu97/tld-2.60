using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DBA")]
public class Rect_DirectConverter : fsDirectConverter<Rect>
{
	[Token(Token = "0x6006ACB")]
	[Address(RVA = "0x10946C0", Offset = "0x10934C0", Length = "0x324")]
	protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006ACC")]
	[Address(RVA = "0x10949F0", Offset = "0x10937F0", Length = "0x3C5")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006ACD")]
	[Address(RVA = "0x1094DC0", Offset = "0x1093BC0", Length = "0x43")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006ACE")]
	[Address(RVA = "0x1094E10", Offset = "0x1093C10", Length = "0x2A")]
	public Rect_DirectConverter()
	{
	}
}
