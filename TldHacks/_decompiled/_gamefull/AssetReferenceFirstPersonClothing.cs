using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

[Serializable]
[Token(Token = "0x200019D")]
public class AssetReferenceFirstPersonClothing : AssetReferenceWithComponent<FirstPersonClothing>
{
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x610A70", Offset = "0x60F870", Length = "0x6A")]
	public AssetReferenceFirstPersonClothing(string guid)
		: base((string)null)
	{
	}
}
