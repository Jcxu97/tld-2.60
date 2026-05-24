using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Token(Token = "0x2000D87")]
public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver
{
	[Token(Token = "0x600698A")]
	public abstract MethodBase GetBase();

	[Token(Token = "0x600698B")]
	public abstract bool HasChanged();

	[Token(Token = "0x600698C")]
	public abstract string GetMethodString();

	[Token(Token = "0x600698D")]
	[Address(RVA = "0x10765F0", Offset = "0x10753F0", Length = "0x14")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600698E")]
	public abstract void OnBeforeSerialize();

	[Token(Token = "0x600698F")]
	public abstract void OnAfterDeserialize();

	[Token(Token = "0x6006990")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected SerializedMethodBaseInfo()
	{
	}
}
