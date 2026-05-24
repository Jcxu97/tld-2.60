using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D96")]
public abstract class fsDirectConverter : fsBaseConverter
{
	[Token(Token = "0x17000744")]
	public abstract Type ModelType
	{
		[Token(Token = "0x60069E4")]
		get;
	}

	[Token(Token = "0x60069E5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected fsDirectConverter()
	{
	}
}
[Token(Token = "0x2000D97")]
public abstract class fsDirectConverter<TModel> : fsDirectConverter
{
	[Token(Token = "0x17000745")]
	public override Type ModelType
	{
		[Token(Token = "0x60069E6")]
		[Address(RVA = "0x1E7AEF0", Offset = "0x1E79CF0", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60069E7")]
	[Address(RVA = "0x22FBEC0", Offset = "0x22FACC0", Length = "0x1F8")]
	public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069E8")]
	[Address(RVA = "0x22FC0C0", Offset = "0x22FAEC0", Length = "0x339")]
	public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x60069E9")]
	protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

	[Token(Token = "0x60069EA")]
	protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);

	[Token(Token = "0x60069EB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected fsDirectConverter()
	{
	}
}
