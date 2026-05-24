using System;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Serializable]
[Token(Token = "0x2000D83")]
public class SerializedConstructorInfo : SerializedMethodBaseInfo
{
	[SerializeField]
	[Token(Token = "0x4008411")]
	[FieldOffset(Offset = "0x10")]
	private string _baseInfo;

	[SerializeField]
	[Token(Token = "0x4008412")]
	[FieldOffset(Offset = "0x18")]
	private string _paramsInfo;

	[NonSerialized]
	[Token(Token = "0x4008413")]
	[FieldOffset(Offset = "0x20")]
	private ConstructorInfo _constructor;

	[NonSerialized]
	[Token(Token = "0x4008414")]
	[FieldOffset(Offset = "0x28")]
	private bool _hasChanged;

	[Token(Token = "0x6006973")]
	[Address(RVA = "0x1074F20", Offset = "0x1073D20", Length = "0x4CF")]
	public override void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6006974")]
	[Address(RVA = "0x10753F0", Offset = "0x10741F0", Length = "0x74B")]
	public override void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6006975")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializedConstructorInfo()
	{
	}

	[Token(Token = "0x6006976")]
	[Address(RVA = "0x1075B40", Offset = "0x1074940", Length = "0x52")]
	public SerializedConstructorInfo(ConstructorInfo constructor)
	{
	}

	[Token(Token = "0x6006977")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public ConstructorInfo Get()
	{
		return null;
	}

	[Token(Token = "0x6006978")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public override MethodBase GetBase()
	{
		return null;
	}

	[Token(Token = "0x6006979")]
	[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
	public override bool HasChanged()
	{
		return false;
	}

	[Token(Token = "0x600697A")]
	[Address(RVA = "0x1075BA0", Offset = "0x10749A0", Length = "0x1C4")]
	public override string GetMethodString()
	{
		return null;
	}
}
