using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x20014A6")]
public class AssetReferenceFPSWeapon : AssetReferenceWithComponent<vp_FPSWeapon>
{
	[Token(Token = "0x60082E4")]
	[Address(RVA = "0x123FB40", Offset = "0x123E940", Length = "0x6A")]
	public AssetReferenceFPSWeapon(string guid)
		: base((string)null)
	{
	}
}
