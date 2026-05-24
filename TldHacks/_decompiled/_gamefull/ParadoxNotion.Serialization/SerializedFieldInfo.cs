using System;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
[Token(Token = "0x2000D86")]
public class SerializedFieldInfo : ISerializationCallbackReceiver
{
	[SerializeField]
	[Token(Token = "0x400841B")]
	[FieldOffset(Offset = "0x10")]
	private string _baseInfo;

	[NonSerialized]
	[Token(Token = "0x400841C")]
	[FieldOffset(Offset = "0x18")]
	private FieldInfo _field;

	[Token(Token = "0x6006985")]
	[Address(RVA = "0x1076270", Offset = "0x1075070", Length = "0x1A6")]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6006986")]
	[Address(RVA = "0x1076420", Offset = "0x1075220", Length = "0x1C4")]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6006987")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializedFieldInfo()
	{
	}

	[Token(Token = "0x6006988")]
	[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
	public SerializedFieldInfo(FieldInfo info)
	{
	}

	[Token(Token = "0x6006989")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public FieldInfo Get()
	{
		return null;
	}
}
