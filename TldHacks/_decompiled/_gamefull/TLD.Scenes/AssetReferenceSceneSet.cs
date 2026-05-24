using System;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[Serializable]
[Token(Token = "0x2001361")]
public class AssetReferenceSceneSet : AssetReferenceT<SceneSet>
{
	[Token(Token = "0x6007BB9")]
	[Address(RVA = "0x11A8A10", Offset = "0x11A7810", Length = "0x49")]
	public AssetReferenceSceneSet(string guid)
		: base((string)null)
	{
	}
}
