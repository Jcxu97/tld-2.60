using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/FPS Item")]
[Token(Token = "0x20014A7")]
public class FPSItem : ScriptableObject
{
	[Token(Token = "0x4009588")]
	[FieldOffset(Offset = "0x18")]
	public AssetReferenceFPSWeapon m_FPSWeaponPrefab;

	[Token(Token = "0x60082E5")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public FPSItem()
	{
	}
}
