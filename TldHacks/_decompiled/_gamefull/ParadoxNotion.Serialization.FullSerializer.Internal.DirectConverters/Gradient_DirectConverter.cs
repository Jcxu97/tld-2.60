using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB4")]
public class Gradient_DirectConverter : fsDirectConverter<Gradient>
{
	[Token(Token = "0x6006AB3")]
	[Address(RVA = "0x108EF50", Offset = "0x108DD50", Length = "0x230")]
	protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AB4")]
	[Address(RVA = "0x108F190", Offset = "0x108DF90", Length = "0x42B")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AB5")]
	[Address(RVA = "0x108F5C0", Offset = "0x108E3C0", Length = "0x83")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006AB6")]
	[Address(RVA = "0x108F650", Offset = "0x108E450", Length = "0x2A")]
	public Gradient_DirectConverter()
	{
	}
}
