using System;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
[Token(Token = "0x2000D8C")]
public class SerializedTypeInfo : ISerializationCallbackReceiver
{
	[SerializeField]
	[Token(Token = "0x400842D")]
	[FieldOffset(Offset = "0x10")]
	private string _baseInfo;

	[NonSerialized]
	[Token(Token = "0x400842E")]
	[FieldOffset(Offset = "0x18")]
	private Type _type;

	[Token(Token = "0x60069A5")]
	[Address(RVA = "0x1077D80", Offset = "0x1076B80", Length = "0xA1")]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60069A6")]
	[Address(RVA = "0x1077E30", Offset = "0x1076C30", Length = "0xAC")]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60069A7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializedTypeInfo()
	{
	}

	[Token(Token = "0x60069A8")]
	[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
	public SerializedTypeInfo(Type info)
	{
	}

	[Token(Token = "0x60069A9")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public Type Get()
	{
		return null;
	}
}
