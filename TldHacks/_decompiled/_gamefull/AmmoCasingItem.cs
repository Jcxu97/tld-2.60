using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200044F")]
public class AmmoCasingItem : MonoBehaviour
{
	[Token(Token = "0x4002705")]
	[FieldOffset(Offset = "0x20")]
	public GunType m_AmmoForGunType;

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AmmoCasingItem()
	{
	}
}
