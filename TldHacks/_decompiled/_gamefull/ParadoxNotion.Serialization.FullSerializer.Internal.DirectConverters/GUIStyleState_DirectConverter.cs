using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB5")]
public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState>
{
	[Token(Token = "0x6006AB7")]
	[Address(RVA = "0x108F680", Offset = "0x108E480", Length = "0x3FD")]
	protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AB8")]
	[Address(RVA = "0x108FA80", Offset = "0x108E880", Length = "0x3D7")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006AB9")]
	[Address(RVA = "0x108FE60", Offset = "0x108EC60", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006ABA")]
	[Address(RVA = "0x108FEE0", Offset = "0x108ECE0", Length = "0x2A")]
	public GUIStyleState_DirectConverter()
	{
	}
}
