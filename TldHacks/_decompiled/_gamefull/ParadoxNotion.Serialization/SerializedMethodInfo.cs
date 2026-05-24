using System;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
[Token(Token = "0x2000D88")]
public class SerializedMethodInfo : SerializedMethodBaseInfo
{
	[SerializeField]
	[Token(Token = "0x400841D")]
	[FieldOffset(Offset = "0x10")]
	private string _baseInfo;

	[SerializeField]
	[Token(Token = "0x400841E")]
	[FieldOffset(Offset = "0x18")]
	private string _paramsInfo;

	[SerializeField]
	[Token(Token = "0x400841F")]
	[FieldOffset(Offset = "0x20")]
	private string _genericArgumentsInfo;

	[NonSerialized]
	[Token(Token = "0x4008420")]
	[FieldOffset(Offset = "0x28")]
	private MethodInfo _method;

	[NonSerialized]
	[Token(Token = "0x4008421")]
	[FieldOffset(Offset = "0x30")]
	private bool _hasChanged;

	[Token(Token = "0x6006991")]
	[Address(RVA = "0x1076610", Offset = "0x1075410", Length = "0x7D6")]
	public override void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6006992")]
	[Address(RVA = "0x1076DF0", Offset = "0x1075BF0", Length = "0x966")]
	public override void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6006993")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializedMethodInfo()
	{
	}

	[Token(Token = "0x6006994")]
	[Address(RVA = "0x1077760", Offset = "0x1076560", Length = "0x52")]
	public SerializedMethodInfo(MethodInfo method)
	{
	}

	[Token(Token = "0x6006995")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public MethodInfo Get()
	{
		return null;
	}

	[Token(Token = "0x6006996")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public override MethodBase GetBase()
	{
		return null;
	}

	[Token(Token = "0x6006997")]
	[Address(RVA = "0x5027A0", Offset = "0x5015A0", Length = "0x5")]
	public override bool HasChanged()
	{
		return false;
	}

	[Token(Token = "0x6006998")]
	[Address(RVA = "0x10777C0", Offset = "0x10765C0", Length = "0x104")]
	public override string GetMethodString()
	{
		return null;
	}
}
