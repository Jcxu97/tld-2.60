using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D92")]
public sealed class fsContext
{
	[Token(Token = "0x400843A")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<Type, object> _contextObjects;

	[Token(Token = "0x60069BB")]
	[Address(RVA = "0x1078F90", Offset = "0x1077D90", Length = "0x49")]
	public void Reset()
	{
	}

	[Token(Token = "0x60069BC")]
	[Address(RVA = "0x1A605A0", Offset = "0x1A5F3A0", Length = "0xDC")]
	public void Set<T>(T obj)
	{
	}

	[Token(Token = "0x60069BD")]
	[Address(RVA = "0x1A604D0", Offset = "0x1A5F2D0", Length = "0xC9")]
	public bool Has<T>()
	{
		return false;
	}

	[Token(Token = "0x60069BE")]
	[Address(RVA = "0x1A5FF90", Offset = "0x1A5ED90", Length = "0x216")]
	public T Get<T>()
	{
		return default(T);
	}

	[Token(Token = "0x60069BF")]
	[Address(RVA = "0x1078FE0", Offset = "0x1077DE0", Length = "0xAD")]
	public fsContext()
	{
	}
}
