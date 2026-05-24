using System;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x200144F")]
public class AssetReferenceNutrientDefinition : AssetReferenceT<NutrientDefinition>
{
	[Token(Token = "0x600815C")]
	[Address(RVA = "0x121C050", Offset = "0x121AE50", Length = "0x49")]
	public AssetReferenceNutrientDefinition(string guid)
		: base((string)null)
	{
	}
}
