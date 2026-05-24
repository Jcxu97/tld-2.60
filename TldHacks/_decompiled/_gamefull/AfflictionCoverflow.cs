using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001FC")]
public class AfflictionCoverflow : MonoBehaviour
{
	[Token(Token = "0x4001205")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_SpriteEffect;

	[Token(Token = "0x600120B")]
	[Address(RVA = "0x647A40", Offset = "0x646840", Length = "0x7F")]
	public void SetAffliction(Affliction affliction)
	{
	}

	[Token(Token = "0x600120C")]
	[Address(RVA = "0x647AC0", Offset = "0x6468C0", Length = "0x4C")]
	public void SetEmptySlot()
	{
	}

	[Token(Token = "0x600120D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AfflictionCoverflow()
	{
	}
}
