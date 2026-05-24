using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001473")]
public class DirectionalInfluenceMapping<T>
{
	[SerializeField]
	[Token(Token = "0x400945C")]
	[FieldOffset(Offset = "0x0")]
	private DirectionalInfluence m_DirectionalInfluence;

	[SerializeField]
	[Token(Token = "0x400945D")]
	[FieldOffset(Offset = "0x0")]
	private T m_Value;

	[Token(Token = "0x17000B45")]
	public DirectionalInfluence DirectionalInfluence
	{
		[Token(Token = "0x600821B")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B46")]
	public T Value
	{
		[Token(Token = "0x600821C")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return default(T);
		}
	}

	[Token(Token = "0x600821D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DirectionalInfluenceMapping()
	{
	}
}
