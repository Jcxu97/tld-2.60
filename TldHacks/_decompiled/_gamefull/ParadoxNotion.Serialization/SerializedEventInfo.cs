using System;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
[Token(Token = "0x2000D85")]
public class SerializedEventInfo : ISerializationCallbackReceiver
{
	[SerializeField]
	[Token(Token = "0x4008419")]
	[FieldOffset(Offset = "0x10")]
	private string _baseInfo;

	[NonSerialized]
	[Token(Token = "0x400841A")]
	[FieldOffset(Offset = "0x18")]
	private EventInfo _event;

	[Token(Token = "0x6006980")]
	[Address(RVA = "0x1075EF0", Offset = "0x1074CF0", Length = "0x1A6")]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6006981")]
	[Address(RVA = "0x10760A0", Offset = "0x1074EA0", Length = "0x1C4")]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6006982")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializedEventInfo()
	{
	}

	[Token(Token = "0x6006983")]
	[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
	public SerializedEventInfo(EventInfo info)
	{
	}

	[Token(Token = "0x6006984")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public EventInfo Get()
	{
		return null;
	}
}
