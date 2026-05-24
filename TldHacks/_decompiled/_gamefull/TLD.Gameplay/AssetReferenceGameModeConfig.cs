using System;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001455")]
public class AssetReferenceGameModeConfig : AssetReferenceT<GameModeConfig>
{
	[Token(Token = "0x6008171")]
	[Address(RVA = "0x121D120", Offset = "0x121BF20", Length = "0x49")]
	public AssetReferenceGameModeConfig(string guid)
		: base((string)null)
	{
	}
}
