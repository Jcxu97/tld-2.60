using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B2")]
internal class DefaultAssetBundleRefRequest : AssetBundleRefRequest
{
	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x10")]
	private AssetBundleRequest m_Request;

	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x61BBA0", Offset = "0x61A9A0", Length = "0x370")]
	public DefaultAssetBundleRefRequest(AssetBundle bundle, string name, Type type = null)
	{
	}

	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x61BF20", Offset = "0x61AD20", Length = "0x4F")]
	public override UnityEngine.Object GetObject()
	{
		return null;
	}

	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x18B0E90", Offset = "0x18AFC90", Length = "0x9C")]
	public override T GetObject<T>()
	{
		return null;
	}

	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x61BF70", Offset = "0x61AD70", Length = "0x73")]
	public override bool IsLoaded()
	{
		return false;
	}

	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x61BFF0", Offset = "0x61ADF0", Length = "0x74")]
	public override float GetProgress()
	{
		return 0f;
	}
}
