using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

[Token(Token = "0x2000DB6")]
public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle>
{
	[Token(Token = "0x6006ABB")]
	[Address(RVA = "0x108FF10", Offset = "0x108ED10", Length = "0x14E1")]
	protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006ABC")]
	[Address(RVA = "0x1091400", Offset = "0x1090200", Length = "0x1AB6")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006ABD")]
	[Address(RVA = "0x1092EC0", Offset = "0x1091CC0", Length = "0x49")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006ABE")]
	[Address(RVA = "0x1092F10", Offset = "0x1091D10", Length = "0x2A")]
	public GUIStyle_DirectConverter()
	{
	}
}
