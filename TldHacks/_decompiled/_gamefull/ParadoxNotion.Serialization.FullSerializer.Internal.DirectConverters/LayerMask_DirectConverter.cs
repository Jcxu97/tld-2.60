using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB8")]
public class LayerMask_DirectConverter : fsDirectConverter<LayerMask>
{
	[Token(Token = "0x6006AC3")]
	[Address(RVA = "0x10937F0", Offset = "0x10925F0", Length = "0x140")]
	protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AC4")]
	[Address(RVA = "0x1093930", Offset = "0x1092730", Length = "0x163")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AC5")]
	[Address(RVA = "0x1093AA0", Offset = "0x10928A0", Length = "0x43")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006AC6")]
	[Address(RVA = "0x1093AF0", Offset = "0x10928F0", Length = "0x2A")]
	public LayerMask_DirectConverter()
	{
	}
}
