using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B0")]
public abstract class AssetBundleRefRequest
{
	[Token(Token = "0x6000FBF")]
	public abstract Object GetObject();

	[Token(Token = "0x6000FC0")]
	public abstract T GetObject<T>() where T : Object;

	[Token(Token = "0x6000FC1")]
	public abstract bool IsLoaded();

	[Token(Token = "0x6000FC2")]
	public abstract float GetProgress();

	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected AssetBundleRefRequest()
	{
	}
}
