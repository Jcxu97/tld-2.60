using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B3")]
public class DefaultAssetBundleRef : AssetBundleRef
{
	[Token(Token = "0x20001B4")]
	private enum State
	{
		[Token(Token = "0x4000F2A")]
		Created,
		[Token(Token = "0x4000F2B")]
		Loading,
		[Token(Token = "0x4000F2C")]
		Ready
	}

	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x28")]
	private AssetBundle m_Bundle;

	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x30")]
	private AssetBundleCreateRequest m_Request;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x38")]
	private State m_State;

	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x61B0C0", Offset = "0x619EC0", Length = "0x81")]
	public DefaultAssetBundleRef(string name)
		: base(null)
	{
	}

	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x61C070", Offset = "0x61AE70", Length = "0x102")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x61C180", Offset = "0x61AF80", Length = "0x29")]
	public override bool IsLoaded()
	{
		return false;
	}

	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x61C1B0", Offset = "0x61AFB0", Length = "0x2BA")]
	public override float GetProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x61C470", Offset = "0x61B270", Length = "0xE8")]
	public override bool IsValid()
	{
		return false;
	}

	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x61C560", Offset = "0x61B360", Length = "0x101")]
	public override bool Contains(string name)
	{
		return false;
	}

	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x61C670", Offset = "0x61B470", Length = "0x85")]
	internal override void LoadBundle()
	{
	}

	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x61C700", Offset = "0x61B500", Length = "0x85")]
	internal override void LoadBundleAsync()
	{
	}

	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x61C790", Offset = "0x61B590", Length = "0x146")]
	internal override void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x61C8E0", Offset = "0x61B6E0", Length = "0x1F6")]
	public override UnityEngine.Object[] LoadAllAssets()
	{
		return null;
	}

	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x61CAE0", Offset = "0x61B8E0", Length = "0x197")]
	public override UnityEngine.Object[] LoadAllAssets(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x18B0990", Offset = "0x18AF790", Length = "0x213")]
	public override T[] LoadAllAssets<T>()
	{
		return null;
	}

	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x61CC80", Offset = "0x61BA80", Length = "0x2B9")]
	public override UnityEngine.Object LoadAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x61CF40", Offset = "0x61BD40", Length = "0x24D")]
	public override UnityEngine.Object LoadAsset(string name, Type type)
	{
		return null;
	}

	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x18B0BB0", Offset = "0x18AF9B0", Length = "0x142")]
	public override T LoadAsset<T>(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x61D190", Offset = "0x61BF90", Length = "0x12A")]
	public override AssetBundleRefRequest LoadAssetAsync(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x61D2C0", Offset = "0x61C0C0", Length = "0x129")]
	public override AssetBundleRefRequest LoadAssetAsync(string name, Type type)
	{
		return null;
	}

	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x18B0D00", Offset = "0x18AFB00", Length = "0x187")]
	public override AssetBundleRefRequest LoadAssetAsync<T>(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x61D3F0", Offset = "0x61C1F0", Length = "0x91")]
	internal string CorrectAssetName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x61D490", Offset = "0x61C290", Length = "0x15F")]
	internal override bool UpdateBundleLoad()
	{
		return false;
	}

	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x619F30", Offset = "0x618D30", Length = "0x19")]
	public static bool DoesBundleExist(string bundleName)
	{
		return false;
	}

	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x61D5F0", Offset = "0x61C3F0", Length = "0xC9")]
	private static string GetFullBundlePath(string bundleName)
	{
		return null;
	}
}
