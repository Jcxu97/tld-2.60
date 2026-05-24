using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B1")]
public abstract class AssetBundleRef
{
	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x10")]
	protected List<AssetBundleRef> m_Dependencies;

	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x18")]
	protected readonly string m_Name;

	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x20")]
	protected readonly int m_NameHash;

	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x24")]
	protected int m_RefCount;

	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x61B0C0", Offset = "0x619EC0", Length = "0x81")]
	protected AssetBundleRef(string name)
	{
	}

	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x61B150", Offset = "0x619F50", Length = "0x18D")]
	public virtual bool IsLoaded()
	{
		return false;
	}

	[Token(Token = "0x6000FC6")]
	public abstract float GetProgress();

	[Token(Token = "0x6000FC7")]
	public abstract bool IsValid();

	[Token(Token = "0x6000FC8")]
	public abstract bool Contains(string name);

	[Token(Token = "0x6000FC9")]
	public abstract UnityEngine.Object LoadAsset(string name);

	[Token(Token = "0x6000FCA")]
	public abstract UnityEngine.Object LoadAsset(string name, Type type);

	[Token(Token = "0x6000FCB")]
	public abstract T LoadAsset<T>(string name) where T : UnityEngine.Object;

	[Token(Token = "0x6000FCC")]
	public abstract UnityEngine.Object[] LoadAllAssets();

	[Token(Token = "0x6000FCD")]
	public abstract UnityEngine.Object[] LoadAllAssets(Type type);

	[Token(Token = "0x6000FCE")]
	public abstract T[] LoadAllAssets<T>() where T : UnityEngine.Object;

	[Token(Token = "0x6000FCF")]
	public abstract AssetBundleRefRequest LoadAssetAsync(string name);

	[Token(Token = "0x6000FD0")]
	public abstract AssetBundleRefRequest LoadAssetAsync(string name, Type type);

	[Token(Token = "0x6000FD1")]
	public abstract AssetBundleRefRequest LoadAssetAsync<T>(string name) where T : UnityEngine.Object;

	[Token(Token = "0x6000FD2")]
	internal abstract bool UpdateBundleLoad();

	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x61B2E0", Offset = "0x61A0E0", Length = "0x21E")]
	internal virtual void LoadBundle()
	{
	}

	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x61B500", Offset = "0x61A300", Length = "0x21E")]
	internal virtual void LoadBundleAsync()
	{
	}

	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x61B720", Offset = "0x61A520", Length = "0x235")]
	internal virtual void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
	public override int GetHashCode()
	{
		return 0;
	}

	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
	public int GetRefCount()
	{
		return 0;
	}

	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0x61B960", Offset = "0x61A760", Length = "0x46")]
	public bool HasDependencies()
	{
		return false;
	}

	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x61B9B0", Offset = "0x61A7B0", Length = "0x133")]
	internal void AddDependent(AssetBundleRef bundle)
	{
	}

	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x61BAF0", Offset = "0x61A8F0", Length = "0x95")]
	internal int DecrementRefCount()
	{
		return 0;
	}

	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x61BB90", Offset = "0x61A990", Length = "0x9")]
	internal int IncrementRefCount()
	{
		return 0;
	}
}
