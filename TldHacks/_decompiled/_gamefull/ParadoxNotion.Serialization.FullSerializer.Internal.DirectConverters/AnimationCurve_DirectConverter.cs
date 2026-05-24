using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB2")]
public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
{
	[Token(Token = "0x6006AAB")]
	[Address(RVA = "0x108E120", Offset = "0x108CF20", Length = "0x39A")]
	protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AAC")]
	[Address(RVA = "0x108E4C0", Offset = "0x108D2C0", Length = "0x474")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AAD")]
	[Address(RVA = "0x108E940", Offset = "0x108D740", Length = "0x50")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006AAE")]
	[Address(RVA = "0x108E990", Offset = "0x108D790", Length = "0x2A")]
	public AnimationCurve_DirectConverter()
	{
	}
}
